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

##### 1-1-1 animation-name
유효한 이름
- 문자열 시작
- 언더바 시작
- 하이픈 시작

유효 x
- 숫자로 시작
- 특수문자로 시작



##### 1-1-2 animation-duration
- normal : 애니메이션을 순방향으로 재생한다(기본값). 재생이 한 번 끝나면 첫 번째 프레임부터 다시 시작한다.
        
 - alternate : 순방향으로 애니메이션을 시작해 역방향과 순방향으로 번갈아 애니메이션을 재생한다. 홀수 번째로 재생할 때는 순방향으로 재생하고, 짝수 번째로 재생할 때는 역방향으로 재생한다.
            
 - reverse : 애니메이션을 역방향으로 재생한다. 재생이 한 번 끝나면 마지막 프레임부터 다시 시작한다.

 - alternate-reverse : 역방향으로 애니메이션을 시작해 순방향과 역방향으로 번갈아 애니메이션을 재생한다. 홀수 번째로 재생할 때는 역방향으로 재생하고, 짝수 번째로 재생할 때는 순방향으로 재생한다.

##### 1-1-3 animation-iteration-count

- 숫자 : 기본값은 1이며, 설정한 횟수만큼 애니메이션을 재생합니다.   
     그리고 숫자가 소수면 애니메이션을 재생하는 도중에 첫 번째 프레임으로 돌아가 멈추고, 숫자가 음수면 애니메이션을 재생하지 않습니다.

 - infinite : 애니메이션을 무한으로 반복합니다.


##### 1-1-4 animation-play-state
- running : 애니메이션을 재생한다(기본값).
- paused : 애니메이션을 정지한다.





##### 1-1-5 animation-timing-function

애니메이션의 키프레임 사이의 재생 속도를 조절하는 속성으로 재생하는 동안 단계별 재생 속도를 설정합니다.

예를 들어 `animation-timing-function:ease-in-out;` 속성은 시작 부분의 재생 속도를 점점 빠르게 하고, 마지막 부분의 재생 속도를 점점 느리게 한다.

`transition-timing-function` 과 유사하다.






