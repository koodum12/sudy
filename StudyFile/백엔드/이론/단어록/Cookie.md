참고: https://velog.io/@hihijin/Backend-%EC%9D%B8%EC%A6%9D-%EB%B3%B4%EC%95%88-%EC%BF%A0%ED%82%A4%EC%84%B8%EC%85%98

##### Cookie란?
서버에서 클라이언트에 **영속성있는 데이터**를 저장하는 방법.

쿠키를 이용하는 것은 단순히 **서버에서 클라이언트에 쿠키를 전송하는 것** 뿐이 **아닌** 클라이언트 서버로 **다시 전송**하는 것도 포함

##### Cookie이용법
사용자 선호,테마 등 장시간 보존해야하는 데이터에 적합
- ex) 로그인 상태 유지,장바구니 등등 

##### 쿠키 옵션
쿠키를 이용하면 서버가 클라이언트에 특정한 데이터를 저장할 수 있다. 또한 이 데이터를 다시 불러와 사용할 수 있다.

그러나 데이터를 저장한 이후에는 아무 때나 데이터를 가져올 수 없다.
데이터를 저장한 이후 특정 조건들이 만족되어야 다시 가져올 수 있다.
이를 http 헤더를 사용해 쿠키 옵션으로 표현.

- **Domain** : 서버와 요청의 도메인이 일치하는 경우 전송
- **Path** : 서버와 요청의 세부경로가 일치하는 경우
- **MaxAge** or Expires : 쿠키의 유효기간 설정
- **HttpOnly** : 스크립트의 쿠키 접근 가능 여부 결정
- **Secure** : HTTPS프로토콜에서만 쿠키 전송 여부 결정
- **SameSite** : CORS 요청의 경우 옵션 및 메서드에 따라 쿠키 전송 여부 결정

##### 쿠키를 이용한 상태 유지
클라이언트에 인증정보를 담은 쿠키를 전송하고, 클라이언트는 전달받은 쿠키를 서버에 요청과 함께 전송하면 Stateless한 인터넷 연결을 Stateful하게 유지할 수 있다.

하지만 기본적으로 쿠키는 오랜 시간 동안 유지될 수 있고, HttpOnly옵션을 사용하지 않았다면 js를 통해 쿠키에 접근할 수 있다.