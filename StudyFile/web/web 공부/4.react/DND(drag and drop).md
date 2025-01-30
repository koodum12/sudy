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