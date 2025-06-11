#dom #cs #html #renderTree
내 답 : DOM트리로 변환해 pc가 이해하기 쉽게 변환해준다 그 다음 DOM트리의 순서에 맞게 변환해 사용자에게 화면을 보여준다.

gpt :

> 사용자가 브라우저에 접속해 HTML 문서를 받으면, 브라우저는 이 HTML을 문자 단위로 파싱하며 DOM(Document Object Model) 트리를 생성합니다. 이 DOM 트리는 HTML 문서의 구조를 브라우저가 프로그래밍적으로 접근 가능하게 만든 객체 트리입니다.
> 
> 동시에 `<link>`나 `<style>` 태그를 통해 CSS 파일이 로드되고 파싱되어 **CSSOM(CSS Object Model)**이 만들어집니다.
> 
> 이 두 개의 트리(DOM + CSSOM)를 결합해서 브라우저는 **Render Tree**를 구성하며, 이는 실제 화면에 그릴 요소들만 포함합니다. 이후 이 Render Tree에 대해 **Layout(=Reflow)**을 실행하여 각 요소의 정확한 위치와 크기를 계산하고, **Painting** 단계를 통해 픽셀 단위로 화면에 렌더링합니다.
> 
> 이런 전체 과정이 빠르게 반복되며 사용자는 시각적으로 웹 페이지를 보게 됩니다.