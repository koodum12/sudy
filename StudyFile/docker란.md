### 도커란?
2013년에 등장한 **컨테이너 기반 가상화 도구**
- 다양한 프로그램, 실행환경을 컨테이너로 추상화 하고 동일한 인터페이스를 제공하여 프로그램의 배포 및관리를 단순하게 해준다.
- 백엔드 프로그램, 데이터베이스 서버, 메시지 큐등 어떤 프로그램도 Container를 추상화 할 수 있다. 
- 어디서든 실행할 수 있다.


- Container 
	- 이전 방식 Vmware 등은 사용법이 간단 하지만, 무겁고 느리다.
	- CPU의 가상화 기술(HVM)을 이용한 반 가상화 방식 Xen을 사용
	- 전체 OS를 가상화 하지 않고 Host OS를 가상화
	- 하나의 서버에 여러 개의 Container 가능

- Image
	- Container에 필요한 파일과 설정 값등을 포함
	- Image 안에 여러 개의 Container
	- Docker hub을 통해 필요한 Image 다운 가능 


- Docker 설치 전
	먼저 컴퓨터 하드웨어가 가상환경을 지원해야한다.
	(ctrl + alt + del)에 진입 후 성능에 들어가 확인 


- Docker 설치
	가상화가 사용가능하다면 **Docker DeskTop for Windows**를 사용해야 한다.

- Image 다운로드
	만약 Docker의 ubuntu Image를 다운 받고 싶다면 ubuntu검색을 통해 사용할 수 있다
	또한 
	`docker search ubuntu`
	같은 명령어를 통해 사용할 수 도 있다

	원하는 이미지를 찾았다면 아래 명령어 처럼 다운로드 받으면 된다.
	`docker pull ubuntu:18.04` 

- Container 생성및 실행
	Image를 생성했다면 해당 Image안에 여러 개의 Container 설치 가능

	docker run -it --name 이름 image이름/bin/bash
	`docker run -it -name Ubuntu ubuntu:18.04 /bin/bash`

	`docker ps -a`
	위 명령어로 Container 확인 가능
	