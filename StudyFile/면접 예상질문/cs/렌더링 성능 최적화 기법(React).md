
#react #hook #렌더링
- `React.memo`: 컴포넌트의 props가 바뀌지 않으면 재렌더링 막음.
- `useMemo`: 계산 비용이 큰 값을 **메모이제이션**.
- `useCallback`: 함수를 메모이제이션해서 불필요한 재생성 방지.
- `lazy`, `Suspense`: 코드 스플리팅으로 초기 렌더링 최적화.

나 : 
최적화 기법에는 React.memo, useMemo, useCallback, lazy,Suspense가 있습니다, React.memo는 props가 바뀌지 않는다면 재렌더링을 막고, useMemo는 계산 비용이 큰 값을 메모이제이션 합니다, useCallback은 함수를 메모이제이션해서 불필요한 재생성을 방지합니다, lazy와 Suspense는 코드 스플리팅으로 초기 렌더링을 최적화 해줍니다.