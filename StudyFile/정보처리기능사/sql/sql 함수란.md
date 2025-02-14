### 1. SQL 함수란?
SQL 함수는 미리 정의된 기능을 수행하는 구문

#### 1.1 데이터 타입 관련 함수
**typeof**(값) : 값의 데이터 타입을 문자열로 반환
**cast**(값 AS 타입) : 값을 지정된 타입으로 변환


```sql
SELECT typeof(123), typeof('abc'), typeof(4.56);SELECT 
cast('123' AS INTEGER), cast(456 AS TEXT);
```
#### 1-2 문자열 처리 함수

- **lower('ABC')** → `'abc'`: 문자열을 소문자로 변환합니다.
- **upper('abc')** → `'ABC'`: 문자열을 대문자로 변환합니다.
- **substr('hello world', 1, 5)** → `'hello'`: 문자열의 일부분을 추출합니다. 첫 번째 숫자는 시작 위치, 두 번째 숫자는 추출할 문자열의 길이를 나타냅니다.
- **replace('hello world', 'world', 'SQL')** → `'hello SQL'`: 문자열의 일부를 다른 문자열로 대체합니다.
- **length('hello')** → `5`: 문자열의 길이를 반환합니다.
- **instr('ABCDEF', 'B')** → `2`: 특정 문자가 문자열 내에서 처음 등장하는 위치를 반환합니다. SQLite에서는 인덱스가 1부터 시작합니다.
```sql
SELECT lower('HELLO'), upper('world'), substr('SQLite', 1, 3), replace('Hello World', 'World', 'SQLite'), length('Function'), instr('ABCDEF', 'D');
```

#### 1-3 