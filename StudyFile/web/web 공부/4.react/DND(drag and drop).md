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
	- **dropEffect(optional): 이 드래그에 사용할 드롭의 type이다. move혹은 copy값을 가진다.**