딥러닝 학습시 최대한 틀리지 않는 방향으로 학습해야 한다.
얼마나 틀리는지를 알게 하는 함수가 loss function(손실 함수)이다.

최소값을 찾아가는 것 **최적화** = Optimization

이를 수행하는 알고리즘이 **최적화 알고리즘** = **Optimizer**이다.

그래프로 형상화 한 것(아직 난 이해 못함)
![[image 1.gif|469]]
## 옵티마이저 종류
 ![[Optimizer(옵티마이저)-20240517192737506.webp|568]]
 
#### GD
#### NAG
#### Nadam
#### Momentum
#### Adam
^42dc04
- Momentum 와 RMSProp 두가지를 섞어 쓴 알고리즘이다(대충 그렇구나 하고 넘기도록 하자)

- 진행하던 속도에 관성을 주고,최근 경로의 곡면의 변화량에 따른 **적응형 학습률**을 갖는 알고리즘이다.

- 아담의 강점은 bounded step size 이다.
[더욱 구체적인 설명](https://velog.io/@freesky/Optimizer)

#### SGD
#### Adagrad
#### AdaDelta
#### RmsProp

