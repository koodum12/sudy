#javaScripts #library 

##### 설치
`npm install @dnd-kit/core @dnd-kit/sortable`

- @dnd-kit/core: Dnd Kit의 기본 기능 제공 (드래그, 드롭, 컨텍스트 등)

- @dnd-kit/sortable: 정렬 가능한 리스트(Sortable List) 구현에 필요한 기능 제공



### 함수 / 훅

##### 1. useDraggable()
요소를 드래그할 수 있도록 설정하는 훙

###### 주요 반환 값
- **attributes** : 키보드 드래그 지원을 위한 aria속성과 tabIndex등을 포함
- **listeners** : 드래그 시작 이벤트
- **setNodeRef** : 이 요소가 draggable이라고 알려줌
- **transform** : x,y위치 변환값
###### ex1)
```js
const {attributes, listeners, setNodeRef, transform} = useDraggable({id : 'item-1'})
```

##### 2. useDroppable()
요소를 드롭 가능한 영역으로 설정하는 훅

###### 반환 값
- setNodeRef : droppable 요소에 연결.
- isOver : 현재 드래그 중인 요소가 이 영역 뒤에 있는지.

###### ex1)
```js
const {setNodeRef, isOver} = useDroppable({
	id : 'drop-area'
});
```

##### 3. DndContext
드래그 앤 드롭 범위와 동작을 감싸는 최상위 컨텍스트

###### props
- onDragStart
- onDragOver
- onDragEnd : 드래그 종료 시 동작 지정
- sensors : 사용자 입력 장치 정의 (나중에 sensors라는 함수도 배울꺼임)

###### ex1)
```html
<DndContext onDragEnd={handleDragEnd}>
	<Draggable />
	<Droppable /> 
	{/* 등등 */}
</DndContext>
```



##### 4. useSortable()
정렬 가능한 리스트의 개별 요소 설정

useDraggable과 비슷 그러나 **정렬기능**이 포함되어있음.

###### ex1)
```js
const {
	setNodeRef,
	attributes,
	listeners,
	transform,
}
```

##### 5. DragOverlay
드래그 중일 때 화면에 따로 표시할 요소

`DndContext`안에서 사용

###### ex1)
```html
<DragOverlay>
	{activeId ? <Item id={activeId} /> : null}
</DragOverlay>
```


##### useSensors / useSensor
useSensors : 입력장치 여러개 지정
useSensor : 입력장치 하나 지정

###### ex1)
```js
const sensors = useSensors(
	useSensor(MouseSensor),
	useSensor(TouchSensor),
	useSensor(keyboardSensor, {
		coordinateGetter : sortableKeyboardCoordinates,
	})
)
```