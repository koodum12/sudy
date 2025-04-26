### Selenium 패키지란?
- selenium 패키지는 **chromedriver**를 **제어**하거나 **원하는 정보**를 **얻기 위해** 사용.

- 크롤링을 하다보면 무엇인가 **입력**하거나 **특정 버튼**을 눌러야 하는 상황이 발생.그러한 행동을 하는 대신 컴퓨터가 할 수 있도록 해주는 패키지가 **selenium**이다.
### 설치 방법
```python
pip install selenium
```
# <hr>
## 사용방법

- 간단하게 chrome 창 실행까지만 알려줌
### 1)관련 패키지 import
- selenium 패키지를 사용하기 위해서 두가지 모듈을 import해야 함

```python
# selenium의 webdriver를 사용하기 위한 import
from selenium import webdriver

#selenium으로 키를 조작하기 위한 import
from selenium.webdriver.common.keys import Keys
```
### 2) 크롬 드라이버 실행

```python
#크롬 드라이버 실행
driver = webdriver.Chrome()

#크롬 드라이버에 url 주소 넣고 실행
driver.get('https://www.google.co.kr/')
#페이지가 완전히 로딩되도록 3초동안 기다림
#import time 해 줘야 정상 작
time.sleep(3)
```

## selenium으로 화면 조작하기

### <개념>
##### 1)조작을 원하는 버튼이나 입력창의 html 파악
- F12를 눌러 개발자 도구로 자신이 눌러서  조작할 부분의 태그or class or id를 찾는다.
##### 2)아래의 두 함수에 html 정보를 입력해서 객체 선택
![[Selenium-20240611171528080.webp]]
```python
import selenium import webdriver

#키보드 키를 시뮬레이션하는 데 사용
import selenium.webdriver.commin.keys import Keys

#Selenium WebDriver에서 요소를 찾는 다양한 방법을 지정하는 데 사용
from selenium.webdriver.common.by import By
import time
```

```python
driver = webdriver.Chrome()

driver.get('https://www.google.co.kr/')

time.sleep(3)
```
**find_element( ) 함수**로 chromedriver가 검색창을 찾는다.
```python
# 검색어 창을 찾아 search 변수에 저장 (By.CLASS_NAME 방식)
serch_box = driver.find_element(By.CLASS_NAME, 'gLFyf.gsfi')

# 검색어 창을 찾아 search 변수에 저장 (By.XPATH 방식)
search_box = driver.find_element_by_xpath('//*[@id="google_search"]')
```
##### 3)기능 동작 관련 함수로 원하는 기능 조작
- 클릭 : .click()
- 키 입력 : . send_keys()
![[Selenium-20250310091706138.webp]]

