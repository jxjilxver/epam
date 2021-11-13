# Introduction to Testing
___
## Test cases for [Forex Club/Libertex](https://fxclub.by/)
___
Номер | Задание | Условия | Действия | Ожидаемый результат 
:-----|:-------:|:-------:|:--------:|-------------------:  
1 | Ставка "вверх" на пару EUR/USD | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 100$ | Слева выбрать пару EUR/USD, над графиком нажать <span style="color:green;">Buy</span>, в появившемся окне указать сумму 100$, мультипликатор 1, после чего нажать <span style="color:green;">Buy</span> | Со свободного счёта уйдёт 100$, совершённая сделка появится в списке активных сделок|
2 | Закрыть совершённую сделку | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь активную сделку | В списке активных сделов навестись мышью на сделку, которую хотим отменить, после чего снизу появится крестик, на который необходимо нажать. В появившемся окне нажать на кнопку <span style="color:blue;">Да, закрыть</span> | Баланс увеличится/уменьшится на значение прибыли/убытка, в списке закрытых операций появится данная сделка|
3 | Сделать ставку на сумму, которая больше текущего баланса | Быть авторизованным на [Libertex](https://libertex.fxclub.by/) | Выбрать любую пару валют, в поле сумма указать 50 000$ (на балансе имеется 49 950.82\$) | Появится сообщение о том, что доступно только 49 950.82$, сделать ставку будет невозможно|
4 | Создать отложенный ордер | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 100$ | Начать сделку "вниз", выбрав пару и нажав на кнопку <span style="color:red;">Sell</span>, в открывшемся окне нажать "Отложенный ордер". Указать сумму 100$, а также котировку, при которой сделка станет активной (например, на 0.0001 меньше текущей), указать мультипликатор, равный 1 | Сделка станет активной, когда котировка выбраной пары станет равной указанной ранее, со свободного баланса спишутся 100$|
5 | TakeProfit-ставка на пару | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 100$ | Начать сделку "вверх", сумма ставки - 100$, мультипликатор - 100, Take Profit - 1\$ и нажать кнопку <span style="color:green;">Buy</span> | Когда прибыль достигнет значения в 1$, сделка автоматически закроется|
6 | StopLoss-ставка на пару | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 100$ | Начать сделку "вниз", сумма ставки - 100$, мультипликатор - 100, Stop Loss - 1\$ и нажать кнопку <span style="color:red;">Sell</span> | Когда убытки достигнут 1$, сделка автоматически закроется|
7 | Сделать ставку 00 000 000$ | Быть авторизованным на [Libertex](https://libertex.fxclub.by/) | Нажать кнопку Buy, в поле сумма указать значение 00 000 000$ | Появится сообщение о том, что минимальная сумма ставки не может быть меньше 10$
8 | Указать значение Take Profit меньше 1% от общей суммы ставки | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 1000$ | Выбрать пару, нажать кнопку Sell, в поле сумма указать значение 1000$, нажать на чекбокс Take Profit, указать значение Take Profit равное 1\$ | Должно появиться сообщение о том, что значение Take Profit не может быть меньше 10$ (1% от изначальной ставки)
9 | Увеличить сумму активной операции | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 1000$, иметь активную сделку | В области "Активные сделки" навестись мышкой на необходиму сделку, после чего нажать на кнопку операции "Увеличить сумму операции". В появившемся окне в поле добавить указать 100\$ и нажать кнопку Ок | Со свободного счёта уйдёт ещё 100\$, значение вложенных средств увеличится на 100$, сумма текущей сделки увеличится на 100\$
10 | Указать значение Take Profit в режиме котировки меньше текущей при ставке на повышение | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 10$ | На главной странице выбрать любую пару, нажать кнопку Buy, в поле сумма указать 10$, в поле мультипликатор любое значение отличное от нуля, в выпадающем списке Take Profit и Stop Loss выбрать пункт "Котировка", нажать на чекбокс Take Profit, в поле Take Profit указать значение меньшее, чем текущая котировка, например, текущая котировка EUR/USD равняется 1.51242, тогда нужно указать 1 | Повится сообщение о том, что значение в поле Take Profit должно быть больше текущей котировки на 0.00003
