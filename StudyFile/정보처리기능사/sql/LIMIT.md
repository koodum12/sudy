SQLlite에서는 `LIMIT`구문을 사용하여 결과 집합의 상위 몇 개의 행만 가져올 수 있다.

`LIMIT`은 데이터를 조회할 때 반환할 행의 개수를 제한하는 데 유용하며, 많은 데이터를 효율적으로 처리할 수 있게 도와준다.

ex)
```sql
SELECT column1,column2
FROM table1
ORDER BY 조건 DESC
LIMIT 5
```

조건에 대한 내림차순으로 반환되는 행의 개수를 LIMIT으로 5개 제한


