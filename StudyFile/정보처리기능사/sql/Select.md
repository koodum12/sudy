`Select`문은데이터베이스에서 데이터를 조회할 때 사용하는 sql구문
`Select`문을 사용하면 테이블에서 원하는 데이터를 가져올 수 있다.

ex)
```sql
SELECT column1, column2;
FROM table_name;
```

위 구문에서 `SELECT`는 데이터를 조회할 때 사용하는 키워드이다.  column1,column2는 조회할 열(column)의 이름을 나타내며, `table_name`은 조회할 테이블(Table)의 이름을 나타낸다.

#### select 연산

`select`문이 단지 데이터를 조회하는 것에만 사용되는 것이 아니라 같은연산을 수행할 때에도 사용된다.

```sql
SELECT 1 + 1;
```


가져온 값도 연산이 가능하다

```sql
SELECT 상품명, 가격 + 1 FROM 상품;
```

#### 개행하기
구문을 작성할 때 가독성을높이기 위해 개행을 사용할 수 있다.
특히 `SELECT` 문을 작성할때, 여러 열(Column)을 조회할 때는 각 열(Column)을 개행하여 작성하는 것이 가독성을 높일 수 있다.

ex)
```sql
SELECT
	column1,
	column2,
	column3
FROM 상품;
```


### SELECT DISTINCT

DISTINCT는 중복된 데이터를 제거하는 키워드

```sql
SELECT column1 FROM table1
```

