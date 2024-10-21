원본 : https://sjkim-icd.github.io/deep-learning/LSTM/


![[LSTM 튜토리얼-20241021170822508.webp]]노란 박스: 뉴럴 넷 레이어

동그라미: point wise operation: 12개에 12개면 각각을 12dimension(차원) 만큼 곱해서 더하는 것

->: vector transfer

선이 합해지면: concat

선이 나눠지면: copy

![[LSTM 튜토리얼-20241021171234469.webp]]
초록색:
이전 정보가 100dim이고 input이 100dim이면 concat하면 200dim이 됨

주황색:
200dim에서 100dim으로 가는 network가 됨

**전체 구조**
![[LSTM 튜토리얼-20241021171358311.webp]]
1) Input X(t):
	- t번째 시간의 단어가 들어감
2)  Cell state:
	- 절대로 밖으로 빠져나가지 않음, 흘러가는 놈
3) Hidden state:
	- 이전 출력
4) Forget Gate, Input Gate, Output Gate
	- Gate가 총 3가지로 있고, 이게 잘 조합되어서 Long term & Short term을 둘 다 잘 고려하게 됨
	- **Core는 Celll state: 일종의 컨베이어 벨트 같은 것으로 지금까지의 정보를 잘 취합해서 cell state로 잘 흘러 들어감**

   \[Gate 설명]

1) Forget Gate
	- 셀 상태에서 어떤 정보를 버릴지 결정
	$$f_t = o(W_f*[h_{t-1},x_t] + b_f)$$
	- Forget Gate의 입력: 이전 output(h(t-1))과 현재 입력(x(t))
	- Forget Gate의 출력: cell state로 넘어가는게 아니라 cell state로 넘어가는 어떤 값이 나옴 sigmoid로 0~1값
	- - Forget Gate의 출력f(t)의 dim이 100 dim(주황)이고, 이전 cell state (c(t))값이 100 dim(초록)을 곱함