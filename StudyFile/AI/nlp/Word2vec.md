#### word2Vec이란?
백터간의 유사도를 계산하기 위해 만들어진 개념

ex)한국 - 서울 + 도쿄 -> 일본
ex2)박찬호 - 야구 + 축구 -> 호나우두 


### 학습 방식
##### CBOW
주변에 있는 단어들을 입력으로 중간에 있는 단어들을 예측하는 방법.
- 예문 - The fat cat sat on the mat
	- \['The','fat','cat','on','the','mat]으로 sat을 예측
	- 이 때 sat을 (center word)라고 하고 나머지 단어를 (content word)라고 함
##### Skip-Gram
중간에 있는 단어들을 입력으로 주변 단어들을 예측 하는 방법.