[참고 자료 - 1](https://velog.io/@jihwankim94/Network-TCP-HTTP-Keep-alive)
# TCP
### TCP keep-alive란?
Keep alive 기능이란 single connection으로 여러 request와 response를 주고 받을 수 있게 끔 해주는 [Persistent](StudyFile/백엔드/이론/단어록/Persistent)을 만드는 기술중 하나이다.


### 사용 이유
connection을 오래 유지함으로서 얻을 수 있는 장점 때문
- 매 request마다 새로운 connection을 맺을 필요가 없기 때문에 3-Way handshake를 하지 않아 해당 작없을 하면서 생기는 round-trip을 줄이기 때문에 latency를 감소시킬 수 있다.

- 많은 양의 connection을 맺고 끊음으로서 발생할 수 있는 네트워크 혼잡 상황을 방지할 수 있다

### 문제점
client가 의도적이든 아니는 지속적으로 connection 
	-> sever단에서 socket이 부족해지는 문재 가능성 ↑


# HTTP
TCP keep - alive와 비슷하지만 약간의 차이가 있다
connection을 지속적으로 얼마나 유지하느냐에 초점을 맞추고 **http에서 keep-alive는 최대 얼마동안 connection을 유지할 것인가**'


http에서의 connection유지는 정해진 timeout 만큼만 유지를 하고 해당 시간 동안 packet교환이 없다면 server측에서 connection을 회수하게 된다.