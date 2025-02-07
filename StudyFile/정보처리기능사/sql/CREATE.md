새로운 데이터베이스 객체 (테이블,뷰,인덱스)를 생성할 때 사용하는 명령어이다.


### 기본문법
#### table 생성
```sql
CREATE TABLE 테이블 명(
	컬럼1 데이터타입[제약조건]
	컬럼2 데이터타입 [제약조건]
)
```

ex)
```sql
CREATE TABLE employees (
    employee_id INT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    hire_date DATE,
    salary DECIMAL(10, 2)
);
```
- 이 명령은 `employees`라는 이름의 테이블을 생성하며, `employee_id`, `first_name`, `last_name`, `hire_date`, `salary` 컬럼을 정의합니다.