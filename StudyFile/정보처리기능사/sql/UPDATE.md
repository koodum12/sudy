`UPDATE` 문은 기존 테이블의 데이터를 수정할 때 사용하는 SQL 구문. 
`UPDATE`를 사용하면 특정 조건에 맞는 데이터를 변경할 수 있음.

ex)
```sql
UPDATE table1
SET row = value1, row2 = value2
WHERE 조건
```

여러 열도 수정할 수 있다

```sql
UPDATE table1
SET row = 400, row2 = 3
WHERE column2 = 45
```

조건 없이도 사용할 순 있는데 굳이 쓰지는 말자(되도록이면)

### 아직 다 안씀 !! ㄹㅇ임 https://www.books.weniv.co.kr/basecamp-sql/chapter02/02-14