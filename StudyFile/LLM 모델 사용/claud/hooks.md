출처:  [DaleSeo][https://daleseo.com/claude-code-hooks/]
### hooks이라?
클로드 코드가 특정 작업을 수행하기 전이나 후에 자동으로 실행하는 사용자 정의 명령어


ex ) typeScript 파일을 수정할 때 자동으로 Prettier를 실행하거나 특정 디렉토리의 파일을 수정하려 할 때 차단하는 것과 같은 동작이 가능



### hook이벤트 종류
##### PreToolUse
- Claude가 도구(Bash, Edit, Write등)을 호출하기 직전에 실행
- 민감한 파일 보호나 명령어 검증에 유용

##### PostToolUse
- 도구 호출이 성공적으로 완료된 후에 실행
- 변경 사항 로깅할 때 활용 가능할 듯

##### Notification
- 클로드 코드가 알림을 보낼 때 실행
- 커스텀 알림을 구현할 수 있음 <- 굳ㅇ/ ?

##### Stop
- 응답을 완료한 후 실행
- 정리 작업이나 알림 보낼 때 사용 가능



