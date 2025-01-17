### 0. 애니메이션 장점

- 자바스크립트를 모르더라도 간단하게 애니메이션을 만들 수 있다.
- 자바스크립트를 이용한 애니메이션은 잘만들어졌더라도성능이 안 좋을 때가 있다.  css 애니메이션은 frame-skipping 같은 여러 기술을 이용하여 최대한 부드럽게 랜더링 할 수있다.
- 브라우저는 애니메이션의 성능을 효율적으로 최적화할 수 있다.
	- ex)현재 안보이는 엘리먼트에 대한 애니메이션은 업데이트 주기를 줄여 부하를 최소화 할 수 있다.

`animation`속성도 `transition`과 유사하게 단일속성과 속기형으로 작성할 수 있다.
animation은 위 언급과 같이 `animation-*`속성과 애니메이션의 중간상태를 정의할 수 있는 `@keyframes`으로 구성되어있다.


### 1. 속성
#### 1-1 animation 단일 속성

- animation-name : 애니메이션의 중간 상태를 지정하기 위한 이름을 정의합니다. 중간 상태는 `@keyframes` 규칙을 이용하여 기술한다.

- animation-duration : 한 싸이클의 애니메이션이 얼마에 걸쳐 일어날지 지정한다.

- animation-delay : 엘리먼트가 로드되고 나서 언제 애니메이션이 시작될지 지정한다.

- animation-direction : 애니메이션이 종료되고 다시 처음부터 시작할지 역방향으로 진행할지 지정한다.

- animation-iteration-count: 애니메이션이 몇 번 반복될지 지정합니다. `infinite` 로 지정하여 무한히 반복할 수 있다.

- animation-play-state : 애니메이션을 멈추거나 다시 시작할 수 있다.

- animation-timing-funnction : 중간 생태들의 전환을 어떤 시간간격으로 진행할지 지정한다.

- animation-fill-mode : 애니메이션이 시작되기 전이나 끝나고 난 후 어떤ㄷ 값이 적용될지 지정한다.

```css
/* 단일 속성 */
.object {
    animation-name: 1s;
    animation-duration: 2s;
    animation-delay: 1s;
    animation-direction: alternate;
    animation-iteration-count: 3;
    animation-play-state: paused;
    animation-timing-function: 1s;
    animation-fill-mode: both;
}
    
/* 속기형 */
animation: name | duration | timing-function | delay | iteration-count | direction | fill-mode | play-state> [,...];

출처: [https://webclub.tistory.com/621](https://webclub.tistory.com/621) [Web Club:티스토리]
```