### 0.설치 방벙
```python
pip install openpyxl
```

### 1.Excel 파일 열기
```python
import openpyxl 

#엑셀 파일 열기
wb = load_workbook('파일 경로/파일 이름.xlsx')
```

### 2.Excel 파일 생성하기
```python
import openpyxl 

wb = openpyxl.WorkBook()
```

### 3.시트 선택 및 생성
##### 선택
```python
#시트 선택
import openpyxl

wb = load_workbook('파일 경로/파일 이름.xlsx')

ws = wb['시트 이름']
```

##### 생성
```python
#시트 선택
import openpyxl

wb = load_workbook('파일 경로/파일 이름.xlsx')

ws = wb.create_sheet('새로운 시트')
```


### 4.셀에 데이터 입력
ex1)
```python
#시트 선택
import openpyxl

wb = load_workbook('파일 경로/파일 이름.xlsx')

ws = wb('시트 이름')

ws,cell(row=1,column=1,value='Hello')
# A1셀에 Hello가 들어감
```

ex2)
```python
import openpyxl

wb = load_workbook('파일 경로/파일 이름.xlsx')

ws = wb('시트 이름')

ws[A1] = 'Hello'
#A1셀에 Hello가 들어감
```

### 5.셀 값 읽기
```python
import openpyxl

wb = load_workbook('파일 경로/파일 이름.xlsx')

ws = wb('시트 이름')

ws,cell(row=1,column=1,value='Hello')

value = ws.cell(row=1,column = 1).value
#.value은 Excel 셀에 저장된 실제 값을 검색하는 데 사용

print(value) 
#셀 안에 있는 값을 읽을 수 있다.
```

### 6.엑셀 파일 저장
열린 엑셀 파일을 저장하기 위해 사용
```python
wb.save('파일 경로/새로운 파일 이름.xlsx')
```

# <hr>

# 함수 활용
이거는 나중에 
https://gr-st-dev.tistory.com/1780