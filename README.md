# GB_CSharp
---

Изначально мы создадим два массива - OldArray: входные данные; NewArray: новый массив с итоговым ответом.

В программе доступен ввод на количество строк и ввод на ограничение по кол-ву символов.

После ввода строк выведем массив на экран для наглядности. 

Теперь приступим к условию на ограничение по кол-ву строк. Мы проходимся массиву, предварительно заведя счетчик, который будет считать кол-во символов в строке, и если строка не удовлетворяет условию, мы заменим её на "" (пустую строку); 

Теперь, переместим все пустые строки в конец массива и выведем промежуточный результат на экран. Таким образом, в начале массива будут только непустые элементы. Также посчитаем их при помощи счетчика. 

Вспомним про второй массив, который мы завели в начале. Используя цикл for, мы пройдёмся только по непустым значениям старого массива, одновременно записывая его значения в новый. 

Последний шаг - выведем новый массив на экран.
