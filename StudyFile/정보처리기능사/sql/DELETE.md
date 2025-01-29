`DELETE`문은 테이블에서 특정 행을 삭제할 때 사용하는 sql구문

`DELETE`를 사용하면 조건에 맞는 데이터를 삭제할 수 있다

ex)
```sql
DELETE FROM table1
WHERE 조건;
```

조건 없이도 사용할 수 있다(주의가 필요)
```SQL
DELETE FROM table1
```

여러테이블에서도 `DELETE`를 사용할 수 있다.

```SQL
DELETE FROM table1
WHERE 조건 IN (
	SELECT column1
	FROM table1
	WHERE 조건
)
```

대규모 데이터 삭제는 트랜잭션을 사용하여 실행할 수 있다.
트랜젝션은 데이터를 안전하게 유지하는 방법으로 중간에 문제가 생기면 `ROLLBACK`할 수 있다.

```SQL
BEGIN TRANSACTION;

DELETE FROM table1
WHERE 조건

COMMIT;
```

```SQL
ROLLBACK;
```