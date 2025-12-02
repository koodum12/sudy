### Redux 란?
- props 없이 state를 공유할 수 있게 도아주는 라이브러리
- js파일 하나에 state들을 보관할 수 있음


#### 설치
```
npm install @reduxjs/toolkit react-redux
```


#### 세팅
```js

import {configureStore} from '@reduxjs/toolkit'

export default configureStore({
	reducer : {}
})
```
Redux 전용 store.js 파일 생성

/src/store/index.js
store안에 있는 index.js = state들을 보관하는 파일


```jsx
import store from './store';
import {Provider} from 'react-redux';

ReactDOM.render(
	<React.StrictMode>
		<Provider store={store}>
			<App />
		</Provider> 
	</React.StrictMode>
)
```

\<App>과 그 자식 컴포넌트들은 store.js안에 있던 모든 state를 꺼내 쓸 수 있다

#### Redux 상태 보관
``` jsx
import {configureStore,createSlice} from '@reduxjs/toolkit'

let 변수 : createSlice({
	name : 이름변수,
	initialState : 이름변수 초기값,
})

export default configureStore({
	reducer : {
		변수2 : 변수.reducer
	}
})
```

위처럼 작성하면 state를 보관할 수 있다.

**createSlice**를 통해 state를 생성할 수 있고

**configureStore()** 안에 등록함으로써 모든 컴포넌트가 마음대로 쓸 수 있게된다.

ex)

```jsx
import {createSlice, configureStore} from '@reduxjs/toolkit'

let user_state = createSlice({
	name : 'user_state',
	initialState : {
		name : 'anonymous',
		level : 0,
		state : 'live'
	}
})

export default configureStore({
	reducer : {
		user_state : user_state.reducer
	}
})
```


```jsx
import {useSelector} from "react-redux";

function componnet1(){
	let state = useSelector((state) => {return state})

	return ...
}
```

store전체 상태 반환

근데 위 코드처럼 쓰면 너무 비효율적

```jsx
import {useSelector} from "react-redux";

function componnet1(){
	let state = useSelector((state) => {return state.user_state})

	return ...
}
```
이렇게 특정 슬라이스만 가져오는 것이 좋음


#### Redux 상태 수정

```jsx
import {createSlice, configureStore} from '@reduxjs/toolkit'

let user_state = createSlice({
	name : 'user_state',
	initialState : {
		name : 'anonymous',
		level : 0,
		state : 'live'
	}
})

export default configureStore({
	reducer : {
		user_state : user_state.reducer
	}
})
```

상태를 수정하려면 store.js에서 수정하는 함수를 만들어야 함.





