#javaScripts  #library 
https://everyday-is-christmas.tistory.com/73
#### 설치
react-dnd와 react-dnd-html5-backend를 설치한다.
드래그 앤 드롭 API를 사용하는 기본 백엔드이다.
```cmd
npm i react-dnd react-dnd-html5-backend
```

#### useDrag()
드래그 소스를 설정하는데 사용하는 훅
드래그 상태 및 레퍼런스를 관리할 수 있다.
useDrag 훅은 dnd시스템에서 드래그 소스를 연결하는 것.
useDrag에 사양(정보)를 전달하면 아래의것들을 선언적으로 사용할 수 있다.

- item객체
- 수집할 props
- draggable 요소의  type

필수요소로는 type, item이 있다.
```jsx
import {useDrag, useDrop, DndProvider} from 'react-dnd'

const [{isDragging}, drag] = useDrag({
	type: 'MARKER',
	item: {id : point.id, middleIdx},
	collect : (monitor) => ({
		isDragging: monitor.isDragging(),
	}),
});
```

type 
- 필수 요소
- string || symbol
- 같은 종료로 등록된 드롭 대상만 이 아이템에 반응
- 드래그 아이템의 유형을 식별하는 데 사용한다


item
- 필수요소
- object || function
- 드래그되는 아이템에 대한 데이터를 정의
- object라면
	- 드래그되는 데이터를 설명하는 일반 js객체
	- 드래그 소스에 대해 드롭 대상이 사용할 수 있는 유일한 정보
	- 알아야하 ㄹ최소한의 데이터(id값 같은)를 선택하는게 좋다.
	- 드래그 소스와 드롭 대상이 결합되므로 복잡한 참조는 넣지않는게 좋다. 
- function이라면
	- 드래그 시작할 때 실행되고, 드래그 작업을 나타내는 개체를 반환한다.
	- null이 반환되면 drag 작업이 취소된다.

previewOptions
- optional요소이다
- 드래그 미리보기옵션을 설명하는일반 js요소

options
- optional 요소
- dropEffect를 선택적으로 포함하는 일반 개체
	- **dropEffect(optional): 이 드래그에 사용할 드롭의 type이다. move혹은 copy값을 가진다.
	- 

end(item, monitor)
- optional 요소
- 드래깅을 멈추면 end가호출
- 모든 시작 호출에는 그 상응하는 end가 보장
- monitor.didDrop()을 호출해서, drop이 드롭 타겟에 의해 handle되었는지 체크할 수 있다.
- 만약 handle되었고, 드롭 타겟이 drop()메서드에서 일반객체를 반환해서 드롭결과를 지정했다면 monitor.getDropResult()로 사용가능하다.


canDrag(monitor)
- optional요소
- drag가 현재 허용되는지여부를 지정할 수 있다. 
- 항상 허용하려면 canDrag()를 생략하면 된다.
- prop로 드래그 비활성화를 조정 하려고 한다면 canDrag()지정하는게 좋다.
- 이 메서드에서는 monitor.canDrag()를 호출할 수 없다.


IsDragging(monitor)
- optional 요소
- 현재 드래그 중인지 여부를 나타내는 bool 값
- 컴포넌트가 드래그중일 때와 아닐 때를 시각적으로 구분할 수 있게 해줌.
- 기번적으로 드래그 작업을 시작한 드래그소스만 드래그하는 것으로 간주한다.
- 드래그 하는 소스를 변경하고 싶다면 사용자정의 isDragging 메서드를 재정의 하면된다.
	- props.id === monitor,getItem().id와 같이 return하면 된다.
- 기술적으로 컴포넌트가 다른곳으로 위치를 이동할 때, 기본 컴포넌트는 unmount되고 새로운곳에서 mounted된다. isDargging을 사용하면 드래그 시작 상태(원본 상태)를 유지하고, 드래그를 하는 매 순간동안 그 상태를 옮겨질 위치의 컴포넌트에 전달한다. 또한 사용자가 드래그중임을 알수있도록 카드가 unmount되고 다른 위치에서 mount되더라도 드래그중인 카드의 시각적 스타일(투명도, 그림자 등)을 일관되게 해준다.
- 이 메소드 내에서 moonitor.isDragged()를 호출 불가

collect(monitor, props)
- optional 요소
- 드래그 상태 정보를 수집하는 함수를 정의한다.
- 이 함수의 return 값은 컴포넌트 리랜더링에 사용하는 데이터 객체
- 두개의 매개변수를 받는다. (monitor, props)
	- monitor 객체를 사용하는 드래그 중인지의 여부(isDragging)를 체크

#### useDrop()
```jsx
const [,drop] = useDrop({
	accept: 'MARKER',
	hover: (item, monitor) => {

	if (!ref.current){
		return;
	}
	const dragIndex = item.index;
	const hoverIndex = middleIdx;
	if (dragIndex === hoverIndex){
		return;
	}
	const hoverBoundingRect = 
	ref.current?.getBoundingClientReact();
	const hoverMiddleY = (hoverBoundingRect.bottom - hoverBoundingRect.top) / 2;
	const hoverClientY = clientOffset.y - hoverBoundingRect.top;

	if(dragIndex < hoverIndex && hoverClientY < hoverMiddleY) {
		return;
	}
	if (dragIndex > hoverIndex && hoverClientY > hoverMiddleY){
		return;
	}
	_dragToReorder(dragIndex, hoverIndex);
	item.index = hoverIndex;
},
});
```

useDrop은 구성요소를 dnd 시스템에 드롭 대상으로 연결할수있게 해준다.

useDrop에 사양(accept, hover)을 전달함으로써

- **accept** : 드롭 타겟이 수락하는 드래그 아이템의 타입을 정의한다. useDrag의 type으로 지정한것을 여기에 적어줘야 같은 type이므로 드롭이 된다. (drag item과 drag target을 맞춰주는 과정이다)
- **hover(item, monitor)** : drop target의 위에 drag item이 hover되었을때 실행되는 함수, 두개의 매개변수를 받는다
    - item: 현재 드래그중인 아이템 정보 (item.index는 아이템의 인덱스 정보)
    - monitor: 드래그 상태 관련 정보를 제공하는 객체(**monitor.getClientOffset()** 은 드래그 아이템의 현재 마우스 위치값)


 **hover 함수가 실행 중단하는 상황**

1. ref.current가 존재하지 않을때(DOM요소가 없음)
2. drag item과 호버하는 아이템 위치가 같은(위치변경이 필요없는) 경우



 **hover 함수의 로직**

**- 요소 경계를 계산**: ref.current.getBoundingClientRect() 를 호출해서 drop target의 위치,크기 정보를 얻는다. 그렇게 요소의 수직 중앙 위치(hoverMiddleY) 값을 계산한다.

**- 마우스 위치를 계산**: **monitor.getClientOffset()**로 얻은 마우스 위치에서 요소 상단위치(hoverBoundingRect.top)를 뺀 값이 hoverClientY(마우스 포인터의 요소 내 수직 위치)이다.

**- 위치 변경 조건**

1. 드래그 아이템의 인덱스가 호버 인덱스보다 작은데 마우스 위치가 요소의 수직 중앙 아래에 있는 경우
2. 드래그 아이템의 인덱스가 호버인덱스보다 큰데 마우스 위치가 요소의 수직 중앙 위에 있는 경우