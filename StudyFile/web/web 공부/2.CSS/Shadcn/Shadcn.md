- Shadcn은 재사용성 좋은 컴포넌트 생성 
- tailwindcss 기반 headless디자인
- clsx를 사용하여 동적 디자인도 사용 가능
- 라이브러리 설치형이 아닌, 코드 복사·로컬 관리 방식
그냥 퍼블리싱 빨리 끝내는 용도인 듯

#### 장점
(gpt + 웹)
- 소스코드 수정이 쉬움
- headless에 가까운 구조
- Radix 기반으로 접근성 우수
- 동적 스타일링 쉬움
##### 내가 생각하는 장점
- 퍼블리싱 할 떄 편해보임
- 이미 코드 짜져있어서 빨리 프젝 마무리 할 수 있을 것 같음.

#### 단점 
(gpt + 웹)
- Shadcn UI는 **높은 유연성**과 **완전한 코드 소유권**을 제공하지만, 동시에 **자동 업데이트를 못 받는 점**, **코드 중복 가능성**, **제한된 컴포넌트 범위** 등의 단점
- 장기보다는 초반 MVP기능 퍼블리싱시 사용하는게 좋아보임

##### 내가 생각하는 단점
- js로 하기 힘듬(ts기반)
- vite 날먹이 힘듬(next쓰려면 여기저기 건드려야 함)





### 사용 방법
솔찍히 사용방법이라고 하기도 애매하다
그냥 만들었진 컴포넌트 위에 수정만 하면 되기 때문이다.

##### 시작
```terminal
npx create-next-app@latest --typescript --tailwindcss --eslint
```
- typeScript 기반
- tailwindcss 기반
- eslint 그냥 있으면 좋음(코드 품질 높이기 좋음)

```terminal
npx shadcn@latest init
```
- shadcn cli 초기화
- 프젝 구조 + tailwindcss + 기본 설정을 잡아줌

```terminal
npx shadcn@latest add "니가 생성하고 싶은 Shadcn 컴포넌트"
```
- 생성시 **src/components/ui** 에 들어감
- https://ui.shadcn.com/docs/components/ 여기서 원하는 거 찾으면 됨!

##### 사용방법

사용 방법은 앞서 말했지만 진짜 쉽다(react를 조금이라도 해보았다는 가정하에)

```jsx
// 예: src/components/MyButtonDemo.tsx

import React, { useState } from "react";
import { Button } from "@/components/ui/button"; // shadcn 버튼 import 경로 예시

export default function MyButtonDemo() {
  const [count, setCount] = useState(0);

  const handleClick = () => {
    setCount((prev) => prev + 1);
  };

  return (
    <div className="flex flex-col items-center justify-center p-8 space-y-4">
      <p className="text-lg">버튼이 {count}번 눌렸어요!</p>
      <Button variant="default" onClick={handleClick}>
        기본 버튼
      </Button>
      <Button variant="outline" size="lg" onClick={handleClick}>
        외곽선 버튼
      </Button>
      <Button variant="destructive" onClick={handleClick}>
        삭제 버튼
      </Button>
      <Button variant="link" asChild>
        <a href="https://example.com" target="_blank" rel="noopener noreferrer">
          링크처럼 생긴 버튼
        </a>
      </Button>
      <Button variant="outline" size="icon" aria-label="증가" onClick={handleClick}>
      </Button>
    </div>
  );
}

```
위 코드는 gpt한테 아무 코드나 작성해줘!  라는 프롬프트를 주고 만든 코드이다
`npx shadcn@latest add button` 로 버튼을 가져와 만든 페이지이다
별건 없지만, 기본적인 ui가 있어 사용하거나 수정하기 편하다.