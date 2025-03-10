map함수는 callbackFunction을 실행한 결과를 가지고 새로운 배열을 만들 때 사용.


```js
array.map(callbackFunction(currenValue, index, array), thisArg)
```

filter, forEach와 같은 구문이다(모르면 검색해보자)

callbackFunction, thisArg 두개의 매개변수가 있고
callbackFunction은 currentValue, index, array 3개의 매개변수를 갖는다.

- currentValue : 배열 내 현재 값
- index : 배열 내 현재 값의 인덱스
- array : 현재 배열
- thisArg : callbackFunction 내에서 this로 사용될 값


```js
const days = ["Mon", "Tue", "Wed", "Thus", "Fri"];
```

이러한 변수가있다고 하자
이때 모든 값에 숫자를 추가하고 싶다면 map()함수를 이용하는 것이다. 
map()함수는 모든 배열의 값에 Function을 실행하는 Method이다
(python map이랑 비슷한 듯)

```js
const smilmingDays = days.map(day => console.log(day));
```

여기서 console.log(day)를 return한다

