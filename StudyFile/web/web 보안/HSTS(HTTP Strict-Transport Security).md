#web #web보안 

https://velog.io/@sejinkim/HTTP-Strict-Transport-Security

#### HSTS란?
웹 사이트가 오직 HTTPS를 통해서만 접근이 가능하다고 선언 하여. 보안 연결을 전제로 하는 상호작용을 지시하고, 강제하는 보안 정적 메커니즘


웹 서버가 모든 클라이언트에 대해 안전하지 않은 `HTTP` 연결은 거부하고 `HTTPS`만을 허용한다고 명시하면, 브라우저는 이를 해석하고 적용함으로써 구현

#### HSTS 사용예
```node js
app.use((req, res, next) => {
  res.setHeader(
    "Strict-Transport-Security",
    "max-age=31536000"
  );
  next();
});

```