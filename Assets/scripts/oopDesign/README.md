## Сейчас класс Player написан с нарушениями принципов ООП.
Разобьём класс Player на 3 класса:
- [PlayerConfig](https://github.com/DmitrySar/unityLessons/blob/main/Assets/scripts/PlayerConfig.cs)
  - вынесем сюда все константы
- [PlayerController](https://github.com/DmitrySar/unityLessons/blob/main/Assets/scripts/PlayerController.cs)
  - здесь будут только методы для управления игроком
- [Player](https://github.com/DmitrySar/unityLessons/blob/main/Assets/scripts/Player.cs)
  - класс, описывающий самого игрока

[Видео процесса рефакторинга](https://youtu.be/hJy7JGJzkYM) 
