# CLAUDE.md

  

This file provides guidance to Claude Code ([claude.ai/code](http://claude.ai/code)) when working with code in this repository.
## Project Overview

`checkNews` is a news crawling/checking project. The `crowling/` directory is the intended home for web crawling logic.

  

The project is in early scaffolding — no build system, dependencies, or source files have been created yet.

  

## Tech Stack
### AI / ML

- Python 3.11.8

- CUDA 12.2

- PyTorch 2.5.1+cu121

### Crawling

- Claude-based automation (Claude drives crawling behavior autonomously)

### Frontend

- Node.js 24.14.0

- npm 11.9.0

- Tailwind CSS 4.2

  

## Architecture

  

- `crowling/` — web crawling/scraping components for fetching news content

  

## 개발 규칙

  

### 공통

- 코드 변경 시 관련 파일만 수정하고, 불필요한 파일은 건드리지 않는다.

- 커밋 메시지는 변경 내용을 간결하게 한국어 또는 영어로 작성한다.

- 사용자가 요청하지 않은 기능 삭제 또는 추가는 구현하지 않는다.

- 코드 구현 후 충돌 및 에러가 날만한 부분에서 한번씩 꼭 테스트 후 수정해야함



### Python (AI / 크롤링)

- Python 버전: 3.11.8 고정

- GPU 관련 코드는 CUDA 12.2 / PyTorch 2.5.1+cu121 기준으로 작성한다.

- 의존성은 `requirements.txt`로 관리하며, 버전을 명시한다.

- 크롤링 로직은 `crowling/` 디렉토리 안에 작성한다.

- Claude API를 활용한 자동화 로직은 역할별로 모듈을 분리한다.

  

### 프론트엔드

- Node.js 24.14.0 / npm 11.9.0 환경 기준으로 작성한다.

- 스타일은 Tailwind CSS 4.2만 사용하고, 별도 CSS 파일 작성을 지양한다.

- 컴포넌트는 기능 단위로 분리하여 재사용성을 높인다.

- components,pages,hooks,mocks,auth와 같이 나눈다(추가적으로 나눠야하는 상황이 오면 추가하는 것은 상관 없다)

  

### 금지 사항

- 하드코딩된 API 키, 비밀번호, 토큰을 코드에 포함하지 않는다 (`.env` 사용).

- 사용하지 않는 코드(주석 처리된 Dead Code)는 남기지 않고 삭제한다.