#designPattern #Atomic

[참고자료 1](https://velog.io/@seul06/AtomicDesignPattern)

>웹 인터페이스를 **원자, 분자, 유기체, 템플릿, 페이지**의 5단계로 나누어 설계하고,
>이들 요소들을 조합하여 복잡한 웹 페이지나 애플리케이션을 구축하는 것을 목표로 한다.


### 구조

##### atoms(원자)
더 이상 분해할 수 없는 기본 컴포넌트.

button, input, 색상, 폰트 등의 UI 요소가 여기에 해당
![[Atomic 패턴-20250708114322030.webp|362]]

##### Molecules (분자)
- 원자들의 조합으로 만들어진 간단한 UI 구성 요소

- label과 input,button이 결합된 `검색 폼`이 여기에 해당

![[Atomic 패턴-20250708114314345.webp|354]]
##### Organisms(유기체)

- atom,molecule,organism으로 구성

- header, footer,side bar와 같은 다양한 요소가 결합하여 만든 큰 UI구성요소
- ![[Atomic 패턴-20250708114553973.webp]]

##### Templates(템플릿)
- organism, molecule로 구성할 수 있음.
- 실제 콘텐츠가 없는 page수준의 스켈레톤
![[Atomic 패턴-20250708114748808.webp|328]]
##### Page(페이지)

유저가 볼 수 있는 실제 콘텐츠를 담고 있음
![[Atomic 패턴-20250708114858336.webp|387]]