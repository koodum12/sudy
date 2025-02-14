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


#### separator.separate()
```python
import numpy as np from spleeter.audio.adapter 
import AudioAdapter from spleeter.separator 
import Separator separator = Separator('spleeter:2stems') 

audio_loader = AudioAdapter.default() # 오디오 파일 로드 
waveform, rate = audio_loader.load("input.mp3", sample_rate=44100) # 오디오 분리 

separated = separator.separate(waveform) # 결과 출력

vocals = separated["vocals"] # 보컬 부분 
accompaniment = separated["accompaniment"] # 반주 부분
```
음원을 numpy배열로 직접 분리

- separate(waveform: np.array)
- NumPy 배열 형식으로 오디오를 입력받아 분리된 오디오를 반환

#### AudioAdapter 클래스 (오디오 입출력 관련)

