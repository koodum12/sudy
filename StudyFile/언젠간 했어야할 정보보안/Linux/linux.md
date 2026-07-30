# shell

### bash
sh를 대체하기 위해 나온 유닉스 셸

GNU / linux / mac os 등에 기본 탑제

sh 에 기능 + a 로 지원
- 명령 히스토리 지원
- tab 자동 완성 지원

- bash 로그인 시 아래 시작  파일 자동 실행
	- /etc/profile 이 존재한다면 읽고 실행
	- ~/. bash_profile, ~/.bash_login, ~/.profile을 순차적으로 탐색해 존재하면 읽고 실행

- bash 종료 시 아래 종료 파일 자동 실행
	- ~/bash_logout이 존재하면 읽은 후 실행

- 셀에서 bash 실행시 아래 시작 파일 자동 실행
	- /etc/bash.bashrc 와 ~/.bashrc가 존재하면 읽은 후 실행

### ash & dash
Almquist Shell(ash), Debian Almuqist shell(dash) ->
bash보다 가볍고 경량화된 유닉스 셸

FreeBSD, NetBSD 그리고 몇 리눅스 배포판의 기본 셸로 설치됨

라이브러리 의존성이 낮고 bash보다 가벼워
- 플로피 디스크에 셸을 설치하는 상황
- 루트 사용자의 셸
- /bin/sh (sh) 대체용


### zsh
mac에서 기본으로 zsh를 사용

bash, ksh등 다양한 셸의 장점을 모아 만든 커스텀 셸
- 커스텀 용이
- 설치 편함
