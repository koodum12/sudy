`INSERT`문은 테이블에 새 데이터를 추가할 때 사용하는 SQL구문이다.

`INSERT`를 사용하면 테이블의 새로운 행을 삽입할 수 있다.

### 1.사용법

ex)
```sql
INSERT INTO 테이블명 (열1,열2,열3....)
VALUES (값1, 값2,....);
```

모든 열에 삽입할 때에는 열 이름을 생략할 수 있다.

```sql
INSERT INTO table1
VALUES (1,2,3)

```

일부 열만 값을 삽입할 수 있다.
```sql
INSERT INTO table1 (column1, column2)VALUES (35, 45);
```

여러 행을 동시에 삽입할 수 도 있다.
```sql
INSERT INTO table1 (column1, column2, column3) 
VALUES
(21,34,234)
(3,4,5);
```