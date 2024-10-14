출처 : https://www.youtube.com/watch?v=006BjyZicCo

관측치들의 순서가 중요하지 않은 경우 순서를 나타내는 데이터 -> **독립 데이터**

시간의 흐름에 따라 관측되어 시간의 영향을 받게 되는 데이터 -> **시계열 데이터** (Time series data)

시계열 데이터 + 2개 이상의 변수의 시계열을 이용해 분석하는 것 -> **다변량 시계열 데이터**

### 전통 통계 기반시계열 데이터 분석 방법론
- 이동평균법(Moving average)
- 지수평활법(Exponential smoothing)
- ARIMA (Autoregressive integrated moving)모델
- SARIMA (Seasonal ARIMA) 모델
- Binary variable model (해당 서점만 1,나머지는 0으로 변환)
- Trigonometirc model (sine과 cosine 함수의 조합으로 표현)
- Growth curve model
- Autoregressive integrated moving average exogenous (ARIMAX) (X변수를 이용하여 시계열 Y예측)
- Prophet,......

### 머신러닝 기반 시계열 데이터 분석 방법론
- Linear regression/Logistic regression models
- Support yector machine/regression
- Random forest
- Boosting
- Hidden Markov model (HMM)

### 인공지능 기반 시계열 데이터 분석 방 
##### 선형회귀 모델
$$ f(x) = w_0 + w_1X_1 + w_2X_2 $$
##### 로지스틱회귀 모델
$$\frac{1}{2+e^{-(w_{01} + w_{11}X + w_{21}X_2)}}$$


##### 뉴럴네트워크 모델 (DNN)
$$1 + exp(-(z_{01} + z_{11}(\frac{1}{1+e^{-(w_{01}+w_{11}X_1+w_{21}X_2} + z^{21}(1+e^{-(w_{01}+w_{11}X_1+w_{21}X_2})}))$$
e = 자연 로그
w01 = 절편
w11,w21 = X1 X2에 대한 가중치
z01,z11 = 다층 신경망
**exp** =  자연상수 eee에 대한 지수 함수

#### 순환신경망