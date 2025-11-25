#javaScripts
(python 영상을 보다 갑자기 생각나서 작성하게 됨)



### gpt 왈
(gpt를 이용하여 작성해, 오류가 있을 수 있음)
**속도 차이는 거의 없다**고 보면 된다
#### 1. 객체 기반 매핑
조건이 정확한 값 비교라면 객체를 만들어 매핑하면 됨
```js
const a = {
	'A' : () => console.log('A'),
	'B' : () => console.log('B'),
	'C' : () => console.log('C'),
};

const ch = 'A';
if(a[ch]){ //'A'
	a[ch] // A 출력
}else{
	console.log('알수 없는 명령')
}
```
##### 장점
- 추가 / 수정이 쉬움
- 보기 편함

##### 단점
- 범위 조절이 안 됨


#### 2. 조건 함수 분리
```js
function handleCommand(cmd) {
  if (cmd === 'start') return start();
  if (cmd === 'stop') return stop();
  if (cmd === 'pause') return pause();
  unknown();
}

```
아예 함수로 만드는 방법도 있다.


### blog 왈
여기서부턴 [inpa.tistory.com][https://inpa.tistory.com/entry/%E2%9A%99%EF%B8%8F-if-else-refactoring#%EA%B8%B8%EB%8B%A4%EB%9E%80_%EC%A1%B0%EA%B1%B4%EC%8B%9D%EC%9D%80_%ED%95%A8%EC%88%98%EB%A1%9C_%EB%B6%84%EB%A6%AC] 글을 인용하였다.

#### Early Return 기법 
**먼저 return할 수 있는 부분은 분리**하여 
우선 초반 라인의 **if문 내에서 Return하여 함수를 미리 종료**하는 기법을 뜻한다.

```js
function loginService(isLogin, user) {
    let result = '';

    // 1. 로그인 여부 확인
    if (isLogin == false) {
        // 2. 토큰 존재 확인
        if (checkToken() == true) {
            // 3. 가입 여부 재확인
            if (user.nickName == undefined) {
                registerUser(user); // 회원 가입하기
                result = '회원가입 성공';
            } else {
                refreshToken(); // 토큰 발급
                result = '로그인 성공';
            }
        } else {
            throw new Error('에러 - 토큰이 없습니다 !');
        }
    } else {
        result = '이미 로그인 중';
    }

    result += ` (+ 시도 횟수 ${count++}번)`;
    return result;
}
```

흐름도로 보면 다음과 같다.
![[긴 if else 해결방안-20251125115027796.webp|263]]
##### 1. if문 다음에 나오는 공통된 절차를 첫번째 분기점 내부에 각각 넣는다

첫번째 분기점 : 코드 레벨의 첫 if문

```js
    result += ` (+ 시도 횟수 ${count++}번)`;
    return result;
```
위 코드는 공통된 절차이기 때문에 else와 if문에 각각 넣어준다.

```js
function loginService(isLogin, user) {
    let result = '';


    if (isLogin == false) {

        if (checkToken() == true) {

            if (user.nickName == undefined) {
                registerUser(user);
                result = '회원가입 성공';
            } else {
                refreshToken(); 
                result = '로그인 성공';
            }
        } else {
            throw new Error('에러 - 토큰이 없습니다 !');
        }
        
        result += ` (+ 시도 횟수 ${count++}번)`; // 공통된 절차
	    return result; //공통된 절차
    } else {
        result = '이미 로그인 중';
        
        result += ` (+ 시도 횟수 ${count++}번)`; // 공통된 절차
	    return result; // 공통된 절차
    }
}
```

##### 2. 분기점에서 짧은 절차부터 실행하게 if문을 반전시킨다
if문 과 else문을 블럭을 보면 **코드 절차가 긴것은 if문**이다. 
절차가 짧은 else 블럭 코드 부분을 if 문에 넣어주기 위해 **if-else를 반전** 시킨다

ex ) if(isLogin == false) => if(isLogin == true)

```js
function loginService(isLogin, user) {
    let result = '';

    if (isLogin == true) { // else와 뒤바꾸기 위하여 boolean 을 반전시킨다
        result = '이미 로그인 중';

        result += ` (+ 시도 횟수 ${count++}번)`;
        return result;
    } else {
        if (checkToken() == true) {
            if (user.nickName == undefined) {
                registerUser(user);
                result = '회원가입 성공';
            } else {
                refreshToken();
                result = '로그인 성공';
            }
        } else {
            throw new Error('에러 - 토큰이 없습니다 !');
        }

        result += ` (+ 시도 횟수 ${count++}번)`;
        return result;
    }
}
```
만약 if문이 else문이 없다면 빈 else문을 만들어 진행해라
##### 3. 짧은 절차가 끝나면 return이나 break로 일찍 중단점을 추가한다.
```js
if (isLogin == true) {
       result = '이미 로그인 중';
       result += ` (+ 시도 횟수 ${count++}번)`;
       return result; // 이렇게
```
##### 4. else를 제거한다

```js
function loginService(isLogin, user) {
    let result = '';

    if (isLogin == true) {
        result = '이미 로그인 중';

        result += ` (+ 시도 횟수 ${count++}번)`;
        return result;
    } // else { 를 제거한다

    if (checkToken() == true) {
        if (user.nickName == undefined) {
            registerUser(user); 
            result = '회원가입 성공';
        } else {
            refreshToken(); 
            result = '로그인 성공';
        }
    } else {
        throw new Error('에러 - 토큰이 없습니다 !');
    }

    result += ` (+ 시도 횟수 ${count++}번)`;
    return result;
}
```
##### 5. 다시 1번부터 돌아가 작업을 반복한다

##### 6. 최종 확인
```js
function loginService(isLogin, user) {
    let result = '';

    // 1. 로그인 여부 확인
    if (isLogin == true) {
        result = '이미 로그인 중';

        result += ` (+ 시도 횟수 ${count++}번)`;
        return result;
    }

    // 2. 토큰 존재 확인
    if (checkToken() == false) {
        throw new Error('에러 - 토큰이 없습니다 !');
    }

    // 3. 가입 여부 재확인
    if (user.nickName == undefined) {
        registerUser(user); // 회원 가입하기
        result = '회원가입 성공';
    } else {
        refreshToken(); // 토큰 발급
        result = '로그인 성공';
    }

    result += ` (+ 시도 횟수 ${count++}번)`;
    return result;
}
```

###### 이 작성법의 장정
- 의미하는 것을 한번에 확일 할 수 있음.
- 코드 복기가 빠르다.

- 그냥 가독성이 좋다.

![[긴 if else 해결방안-20251125120623524.webp]]
