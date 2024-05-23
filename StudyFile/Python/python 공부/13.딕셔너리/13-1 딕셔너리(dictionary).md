### 딕셔너리란?
- dictionary는 단어 그대로 해석하면 사전이라는 뜻.

- "people"이라는 단어는 "사람","baseball"이라는 단어는 "야구"에 부합되듯이 dictionary는 Key와 Value를 한쌍으로 갖는 자료형.

- 딕셔너리 타입은 immutable(불변)한 Key와 mutable(변화가능)한 value로 맵핑되어있는 순서가 없는 집합.
### 딕셔너리
```python
딕셔너리명 = {Key:Value,Key:Value}
```
- Key에는 변하지 않는 값을 사용.
- Key의 값은 동일할 수 없다.
- Value부분에는 변하지 않는 값 모두 사용할 수 있다.



```python
a =  {}
b = {"name","MH"}
c = {1:5,2:3}
```
- a = 값이 없는 딕셔너
- b = 데이터 1개 
- c = 데이터 2
### 딕셔너리 값 추가 / 삭제
```python
dic1 = {"name":"MH","age":20,"phone":"010-1234-5678"}
dic["birth"] = "03/27"

print(dic)#{"name":"MH","age":20,"phone":"010-1234-5678","birth":"03/27"} 출력
```
- 변수\[새로 만들 값의 키] = "값"
- 맨 뒤 변수 추가.

```python
dic1 = {"name":"MH","age":20,"phone":"010-1234-5678"}
del dic1 ["age"]
print(dic1) #{"name":"MH","phone":"010-1234-5678"} 출력
```
- del 변수 이름\["지울 값의 key"]


### 딕셔너리 key로 값 불러오기
```python
dic1={"name":"MH","age":20,"phone":"010-1234-5678"}
print(dic1["name"]) #MH 출력
print(dic1["성별"]) #KeyError
temp = dic1.get("name")
temp1 = dic1.get("성별")

print(temp) #20출력
print(temp1) #none 출


```