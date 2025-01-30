https://everyday-is-christmas.tistory.com/73
#### 설치
react-dnd와 react-dnd-html5=backend를 설치한다.
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

const [{isDragging}, drag] = useDSrag({
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

### useDrop