### vite

설치)
```cmd
npm install -D tailwindcss postcss autoprefixer
```

```cmd
npx tailwindcss init -p
```

```css
/*src/index.css*/
@tailwind base;
@tailwind components;
@tailwind utilities;
```

만약 두 번째 명령어가 실행되지 않는다면?



tailwind.config.js 파일 만든 후
```js
/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./index.html",
    "./src/**/*.{js,ts,jsx,tsx}"
  ],
  theme: {
    extend: {},
  },
  plugins: [],
}
```
입력

