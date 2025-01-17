https://velog.io/@shin6403/React-axios%EB%9E%80-feat.-Fetch-API

python의 axios라이브러리처럼 비동기 방식을 사용할 수 있게 해주는 라이브러리

#### 비동기 방식이란
**비동기 방식은 웹페이지를 리로드하지 않고 데이터를 불러오는 방식**이며,Ajax를 통해서 서버에 요청을 한 후 멈추어 있는 것이 아니라 그 프로그램은 계속 돌아간다는 의미를 내포하고 있다.

#### 비동기 장점
페이지 리로드의 경우 전체 리소스를 다시 불러와야하는데 이미지, 스크립트 , 기타 코드등을 모두 재요청할 경우 불필요한 리소스 낭비가 발생하게 되지만 비동기식 방식을 이용할 경우 필요한 부분만 불러와 사용할 수 있으므로 매우 큰 장점이 있다.

### Axios란?
Axios는 브라우저, Node.js를 위한 **Promise API를 활용하는 HTTP 비동기 통신 라이브러리이다.**

### axios 사용법
- axios 다운로드
- http methods
	- get
	- post
	- put
	- delete

#### Axios 다운로드
```
yarn add axios

npm i axios
```

```js
import axios from 'axios'
```


#### HTTP Methods

##### 1.get
y