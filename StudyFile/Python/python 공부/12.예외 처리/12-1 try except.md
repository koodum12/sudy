#python

### try - except
```python
try:
	실행될 코드
except:
	예외가 발생했을 때 처리한는 코드
```
ex)
```python
try:
	x = int(input('나눌 숫자를 입력하세요: '))
	y = 10/x
	print(y)
except:
	print("예외가 발생했습니다")

```