#Recoil #library #Atomic 

[참고자료 - 1](https://velog.io/@zooyaho/Recoil%EC%9D%84-%EC%82%AC%EC%9A%A9%ED%95%98%EC%97%AC-%EC%83%81%ED%83%9C%EA%B4%80%EB%A6%AC-%ED%95%98%EA%B8%B0)
상태 관리 라이브러리
Atomic 디자인 패턴을 따르고 있다

### 설치

npm
```cmd
npm install recoil
```

yarn
```
yarn add recoil
```

### RecoilRoot 설정

>앱의 최상위 컴포넌트에 RecoilRoot 추가,
>Recoil 상태가 전체 앱에 공유됨

```jsx
import {RecoilRoot} from 'recoil';

function App() {
 return(
	 <RecoilRoot> /*이거 안하면 계속 오류남*/
		 <MyComponent>
	</RecoilRoot>
 );
}
```

### Atom 생성
>Atom은 상태의 기본 단위

```jsx
import {atom} from 'recoil';

export const textState = atom({
	key : 'textState',
	default : '',
})
```
### Atom 사용(with hook)
>컴포넌트에서 Atom을 사용하려면 전용 훅 사용

#### 1.useRecoilState
읽고 쓸 때 사용
그러나 recoil의 상태로 인자를 받는다.

```jsx
const [count, setCount] = useRecoilState(countState);

const increaseCount = () => {
	setCount(count + 1);
}
```

#### 2.useRecoilValue
```jsx
const count = useRecoilValue(countState);
```
Recoil 상태의 값을 반환한다.

#### 3.useSetRecoilState
```jsx
const setCount = useSetRecoilState(countState);
```
Recoil 상태를 변경
#### 4.useResetRecoilState

atom이나 selector의 값을 초기화하고 싶을 때 사용

```jsx
const resetCount = useResetRecoilState(countState)

```


#### 여기서 든 궁굼점

왜 useRecoilState로 한번에 해결하면 되는데 
useRecoilValue와 useSetRecoilState로 나누어 사용할까?

###### 이유 : 
1. 불필요한 구독 방지
	1. 값이 바뀔 때마다 리렌더됨
	2. 어떤 컴포넌트는 값이 얼마인지 관심 x오로지 트리거 역할만 함
2. 관심사 분리
	1. 코드가 더 직관적으로 보임
3. 불필요한 렌더링 방지
	1. `useRecoilState`를 쓰면 상태 변경시 이 컴포넌트도 리렌더 됨
### Selector 사용
> Selector를 사용하면 Atom에 기반한 계산된 상태를 생성할 수 있음

```jsx
import {selector} from 'recoil';
import {textState} from './path/to/your/atoms';

export const textLengthState = selector({
	key : 'textLengthState',
	get : ({get}) => {
		const text = get(textState);
		return text.length;
	},
});
```

이 함수는 다른 atom이나 selector의 값을 읽어오기만 할 뿐,값 변경이 없음

컴포넌트에서 이 selector를 사용하려면 useRecoilValue 훅을 사용하면 됨

```jsx
import {useRecoilValue} from 'recoil';
import {textLengthState} from './path/to/your/atom';

function MyComponent() {
	const length = useRecoilValue(textLengthState);
return (
	<p>Text length : {length} </p>
	);
}
```





# Selector()
>selector는 상태를 파생하거나 변환하는데 사용
>구성 객체(configuration object)내에서 여러 속성을 정의

###### 주요 속성(구성 객체에 추가할 수 있는)
1. `key` 
	- `selector`의 **고유 식별자**
	- 전체 애플리케이션에서 **유일**해야 함
	- **디버깅과 지속성에 사용**
2. get
	- 해당 selector의 값을 **계산**
	- `atom`및 `selector`의 값을 **읽을 수 있음**
	- **읽은 값에 의존하는 파생 값을 반환**
3. set
	- selector의 **값을 설정**할 수 있음
	- 다른 `atom`및 `selector`의 **값을 변경**할 수 있음
	- **읽기/쓰기 가능한 selector를 만들 수 있음**
4. cachePolicy_UNSTABLE
	- `selector`의 **캐시 동작을 구성**할 수 있음
	- 캐시 **크기 및 시간 제한같은 옵션이 포함될 수 있음**

###### 예시
```jsx
import {atom, selector} from 'recoil';

const numberState = atom({
	key : 'numberState',
	default : 0,
});

const multipliedState = selector({
	key : 'multipliedState',
	get : ({get}) =>{
		return get(numberState) * 2;
	},
	set : ({set}, newValue) => {
		set(numberState, newValue /2 );
	},
});
```

- numberState : atom

- `key` : 식별 이름

- `get` :
	- 현재 상태를 읽을 때 호출
	- `numberState`의 값을 가져와서 2배로 만들어 반환

- `set `:
	- `multipliedState`에 새로운 값을 넣으면 호출
	- 새로운 값(`newValue`)를 받아 `numberState`를 계산해서 변경
		- `numberState`를 다시 /2해주어 변경

