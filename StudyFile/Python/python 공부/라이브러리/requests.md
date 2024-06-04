- HTTP 통신을 위한 파이썬 라이브러리.
	- HTTP 통신이란?
	- 인터넷 접속할 때 발생하는 대화(Get요청 post 요청)
- HTTP Request 옵션 PUT, OPTIONS, HEAD, DELETE  들을 아주 간편하게 지원합니다.
### 0.requests 설치
```python
pip install requests
```


### 1.Get
- 요청을 보내기 위해 requests .get()함수를 사용해야 한다
ex)
```python
import requests

response = requests.get('https://news.naver.com/section/101')
print(response.text)
```

### 2.POST 요청
- post 요청을 보내려면 requests.post()함수를 사용한다.
ex)
```python
import requests
import json

data = {'Key':'value'}
headers = {'Content-type': 'application/json'}

response = requests.post('http://news.naver.com/101',data = json.dumps(data),headers)
print(response)
```
