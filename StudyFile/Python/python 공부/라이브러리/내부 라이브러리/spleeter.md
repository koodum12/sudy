설치 
```cmd
pip install spleeter
```


불러오기
```python
from spleeter.separator import Separator
```

오디오 분리

```python
Separator('spleeter:2stems')
```

1. spleeter:2stems -> 보컬과 반주
2. spleeter:4stems -> 보컬, 드럼, 베이스, 기타
3. spleeter:5stems -> 보컬, 드럼, 베이스, 피아노, 기타

오디오 파일을 지정한 폴더에 저장
 separate_to_file(audio_path, output_path)


