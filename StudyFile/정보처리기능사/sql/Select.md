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

위와 같이 작성한다면

| column1 | column2 |
| ------- | ------- |
| 1       | 123     |
| 1       | 123     |
| 1       | 123     |
| 2       | 342     |
| 3       | 123     |
| 4       | 3423    |
| 3       | 2345    |
이와 같은 테이블에 서

| column1 |
| ------- |
| 1       |
| 1       |
| 1       |
| 2       |
| 3       |
| 4       |
| 3       |
과 같이 중복된 데이터도 가져올 것이다

그러나 DISTINCT를 사용한다면

```sql
SELECT DISTINCT column1 FROM table1
```

| column1 |
| ------- |
| 1       |
| 2       |
| 3       |
| 4       |
과 같이 중복이 제거된 체 출력이 되는 것을 볼 수 있다.

#### 중복 제거 개수 확인
중복이 얼마나 제거되었는지 확인하려면 COUNT()함수를 사용하면 된다.

```sql
SELECT COUNT(DISTINCT column1) FROM table1;
```

원본 데이터는 아래와 같이 확인 가능.

```sql
SELECT COUNT(column1) FROM table1;
```

한번에 연산 가능

```sql
SELECT COUNT(column1) - COUNT(DISTINCT column1) FROM table1;
```

### ORDER BY

`ORDER BY`절은 `SELECT`문의 결과를 정렬하는데 사용된다

`ORDER BY`절은 `SELECT`문의 마지막에 위치하며 
`ORDER BY`절 뒤에 오는 열 이름에 따라 결과가 정렬된다

```sql
SELECT *
FROM table1
ORDER BY column1
```

위와 같이 작성하면 `table_name` 테이블의 `column_name`열을 기준으로 오름차순으로 정렬된 결과를 출력한다.

```sql
SELECT *
FROM table_name
ORDER BY column1 DESC;
```

위와 같이 작성하면 `table_name`테이블의 `column_name`열을 기준으로 내림차순으로 정렬된 결과를 출력한다. 

- 오름차순 : ASC(기본, 작은 수에서 큰 수로)
- 내림차순: DESC(큰 수에서 작은 수로)

`ORDER BY`절은 여러 열로 정렬할 수 있다.

```sql
SELECT *
FROM table1
ORDER BY column1, column2;
```

 위와 같이 작성하면 `table_name` 테이블의 `column1` 열을 기준으로 먼저 정렬하고, `column2`열을 기준으로 다시 정렬한다.




### AS
`AS`는 열의 별칭을 지정할 때 사용하는 키워드이다. 별칭을 지정하면 결과를 출력할 때 별칭을 사용할 수 있다. 별칭을 사용하면 열 이름이 길거나 복잡한 경우에도 간단하게 사용 ㄱㄴ

```sql
SELECT column1 AS new_name
FROM table1;
```

 