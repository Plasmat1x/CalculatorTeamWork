# CalculatorTeamWork

*Teamwork calculator* - Коммандный проект (лабораторная работа) деманстрирующий командную разработку приложения на примере калькулятора

## Команда

* Лапшин - Заказчик
* Мрясов - Тимлид + фронт/бэк
* Шишков - Внешний вид(фронт)
* Одиванов - Логика калькулятора(бэк)

---

### Журнал

---

#### Задачи на 21 августа(понедельник)

**Одиванов**

* ~~Сделать класс калькулятор и объявить функции с возможностью возврата результата(заглушки).~~ `Completed`
* ~~Сделать структуру, которая будет возвращать статус(error, success) результата и сам результат.~~ `Completed`
* ~~Основной тип данных для структуры float.~~ Completed
* ~~Класс не должен принимать элементы интерфейса. На ввод тип float, на вывод структура(статус, значение).~~ `Completed`

**Шишков**

* ~~Текстбокс с readonly.~~ `Completed`
* Внешний вид полностью.
* ~~Реализовать нажатия кнопок приложения: цифры - ввод в текстбокс, операции - сохранение в переменной, цифра, введенная до операции сохраняется в лэйбл~~ `Completed`
* ~~Основные операции - сложение, вычитание, умножкние, деление~~ `Completed`

**Итог работ:**

* Реализован бэкэкнд полностью
* Фронтэнд частично
* необходимы доработки по внешнему виду

---

#### Задачи на 25 августа(пятница)

**Внешний вид:**

* ~~настроить отступы между кнопками/границами контейнера.~~ Completed
* ~~подумать над оптимизацией xaml-разметки, конкретно уменьшению количества панелей~~ Completed
* ~~опционально: сделать современный внешний вид приложения(цвета, шаблоны кнопок, стили нажатия)~~ Completed

**Логика:**

* ~~починить повторный ввод запятой~~ `Completed`
* ~~сделать расчет результата после нажатия одного из операторов с последующим сохранением оператора и результата(если это целесообразно)~~ `Completed`


***Итог работ:***

* все замечания по визуальной части учтены

---

### Дополнительные задачи на 25 августа(пятница)

**Оптимизировать xaml-разметку:**
* вынести стили кнопок в ресурс окна, либо в отдельный файл с ресурсом. это касается и стилей наведения


---

#### Собрание 19 августа(суббота)

**Присутствовавшие:**

* Одиванов
* Мрясов

**Выполнено:**

* Создан класс калькулятор, Структура результата, перечесление статуса. Реализованы базовые операции сложение, вычитание, умножение, деление
* Выполнена векрстка формы приложения
* Выполнена логика интерфейса приложения

**На доработку**

* ~~После результирующей функции по нажатию на операцию продолжить вычисление, по нажатие на цифру очистить поле ввода и добавить введеную цифру~~ `Completed`

#### Собрание 22 августа (вторник)

**Пристутвовавшие:**

* Шишков
* Мрясов

**Задачи:**

* Верстка (Собственное решение или в соответствии с диаграммой)
* Цветовые решения (Собственное решение или в соответствии с диаграммой)

*Вариант [Mryasov](./GitResources/Var1.jpg)*
*Вариант [Shishkov](./GitResources/Var2.jpg)*

## Диаграммы и Скриншоты

![AppScr](./GitResources/TWCalculator.jpg)
![DiagramScr](./GitResources/TWCalculator-Page-2-Main.drawio.png)
![MockupScr](./GitResources/TWCalculatorMockup.drawio.png)
![MockupNewStyle](./GitResources/Var1.jpg)
![MockupVar2](./GitResources/Var2.jpg)
