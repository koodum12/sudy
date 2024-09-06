# Series
- data구조 = index - value

```python
import pandas as pd

s1 = pd.Series([10,20,30,40])
print(s1)
```

--출력 결과--
0    10
1    20
2    30
3    40
dtype : int64
```python
s1.sum()
```
--출력 결과--
100
```python
s1.mean()
```
--출럭결과--
25.0
```python
s2 = pd.Series(['분식이','쏘니','홍길동','변사또'],index['하나','둘','셋','넷'], name = '출석부')
print(s2)
```
--출력 결과--
하나    분식이
둘       쏘니
셋       홍길똥
넷       변사또
Name = 출석부 dtype: object

```python
s3 = pd.Series({'name':'김분식','age':30,'gender':'male','job'})
```
# Dataframe
- index - column - value

