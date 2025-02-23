### 1.백엔드 파일 만들기

```cmd
npm init
```

↑ 프로젝트 생성

재대로 실행되었다면 package.json이 설치 되어있어야 함.


그 다음 
```cmd
npm install express
```
위 명령어 실행

package.json 파일 내부에 express패키지가 설치됨

```javascript
// server.js 또는 app.js
const express = require('express');
const app = express();
const port = 5000; // 사용할 포트 번호

app.get('/', (req, res) => {
  res.send('Hello World!');
});

app.listen(port, () => {
  console.log(`Server listening at http://localhost:${port}`);
});
```


```cmd
node server.js
```

제작한 파일의 이름이 server.js라는 가정하에 위처럼 작성하면 된다
위 파일을 실행할 수 있게 되었다.

```javascript
const express = require("express");
const app = express();
const port = 5000; // 사용할 포트 번호
const mysql = require("mysql2"); // 'mysql2' 모듈 사용

// MySQL 데이터베이스 연결 설정
const connection = mysql.createConnection({
  host: "localhost", // 데이터베이스 호스트 주소
  user: "root", // 데이터베이스 사용자 이름
  password: "password", // 사용자 비밀번호
  database: "mydb", // 접속하려는 데이터베이스 이름
  port: 3306, // MySQL 포트 번호
});

// 데이터베이스 연결
connection.connect((error) => {
  if (error) {
    return console.error("데이터베이스 연결 실패:", error);
  }
  console.log("데이터베이스에 성공적으로 연결됨");
});

// 데이터베이스 쿼리 실행 예제
app.get("/hello", (req, res) => {
  connection.query("SELECT VERSION()", (error, results, fields) => {
    if (error) {
      return res.send("쿼리 실행 실패: " + error.message);
    }
    res.send("데이터베이스 서버 버전: " + results[0]["VERSION()"]);
  });
});

// 서버 실행
app.listen(port, () => {
  console.log(`Server listening at http://localhost:${port}`);
});
```