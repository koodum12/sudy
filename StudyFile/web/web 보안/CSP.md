 #web #web보안

[참고 자료 1][https://hyeonql.tistory.com/entry/CSP-%ED%97%A4%EB%8D%94-%EC%BD%98%ED%85%90%EC%B8%A0-%EB%B3%B4%EC%95%88-%EC%A0%95%EC%B1%85-%EA%B0%80%EC%9D%B4%EB%93%9C]
GPT 사용

거의 배껴 적었지만 공부는 열심히 함
#### CSP란?
CSP는 Content Security Policy의 약자로, 웹 사이트의 **콘텐츠 보안 정책**이다


한마디로 웹 사이트에 포함된 콘텐츠를 제어하여 **클라이언트 측 공격**을 방지하는 보안 기능

#### CSP 주요 기능
- **스크립트 제어**: 허용된 스크립트만 실행
- **이미지 소스 제어**: 이미지가 로드되는 출처를 제어
- **스타일 제어**: 스타일시트의 출처 및 인라인 스타일 제어
- **프레임 제어**: iframe 등의 임베디드 콘텐츠 출처 제어
- **기타**: 오디오, 비디오, 웹소켓 등 다양한 리소스에 적용 가능

#### CSP 헤더 사용법
CSP를 구현하려면 **HTTP 헤더**에 CSP 정책을 선언해야 함.  
이 때의 헤더 이름은 **Content-Security-Policy**.


###### node js
```node js
app.use((req, res, next) => {
	res.setHeader(
		"Content-Security-Policy",
		"default-src 'self';"
	);
	next();
})
```
보통 app.js index.js에 포함되어있음

###### html (비추)
```html
<meta http-equiv="Content-Security-Policy"
      content="default-src 'self';">
```
위 방식보다 우선순위가 낮을 수 있음
일부 csp기능 제한





#### 3. CSP directive

CSP 정책을 구성하는 주요 directive

- **default-src**: 모든 콘텐츠의 기본 출처를 설정
- **script-src**: 스크립트 파일의 출처 제어
- **style-src**: 스타일시트 파일의 출처 제어
- **img-src**: 이미지 파일의 출처 제어
- **media-src**: 오디오 및 비디오 파일의 출처 제어
- **frame-src**: 프레임이나 iframe 콘텐츠의 출처 제어
- **font-src**: 폰트 파일의 출처 제어
- **connect-src**: 웹소켓, XMLHttpRequest, Fetch API 등의 출처 제어
- **form-action**: `<form>` 태그의 제출 대상 제어
- **frame-ancestors**: 페이지를 포함할 수 있는 프레임 제어