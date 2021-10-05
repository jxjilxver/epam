# Introduction to Testing
___
## Test cases for [Forex Club](https://fxclub.by/)
___
Номер | Задание | Условия | Действия | Ожидаемый результат 
:-----|:-------:|:-------:|:--------:|-------------------:  
1 | Ставка "вверх" на пару EUR/USD | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 100$ | Слева выбрать пару EUR/USD, над графиком нажать <span style="color:green;">Buy</span>, в появившемся окне указать сумму 100$, мультипликатор 1, после чего нажать <span style="color:green;">Buy</span> | Со свободного счёта уйдёт 100$, совершённая сделка появится в списке активных сделок|
2 | Закрыть совершённую сделку | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь активную сделку | В списке активных сделов навестись мышью на сделку, которую хотим отменить, после чего снизу появится крестик, на который необходимо нажать. В появившемся окне нажать на кнопку <span style="color:blue;">Да, закрыть</span> | Баланс увеличится/уменьшится на значение прибыли/убытка, в списке закрытых операций появится данная сделка|
3 | Сделать ставку на сумму, которая больше текущего баланса | Быть авторизованным на [Libertex](https://libertex.fxclub.by/) | Выбрать любую пару валют, в поле сумма указать 50 000$ (на балансе имеется 49 950.82\$) | Появится сообщение о том, что доступно только 49 950.82$, сделать ставку будет невозможно|
4 | Создать отложенный ордер | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 100$ | Начать сделку "вниз", выбрав пару и нажав на кнопку <span style="color:red;">Sell</span>, в открывшемся окне нажать "Отложенный ордер". Указать сумму 100$, а также котировку, при которой сделка станет активной (например, на 0.0001 меньше текущей), указать мультипликатор, равный 1 | Сделка станет активной, когда котировка выбраной пары станет равной указанной ранее, со свободного баланса спишутся 100$|
5 | TakeProfit-ставка на пару | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 100$ | Начать сделку "вверх", сумма ставки - 100$, мультипликатор - 100, Take Profit - 1\$ и нажать кнопку <span style="color:green;">Buy</span> | Когда прибыль достигнет значения в 1$, сделка автоматически закроется|
6 | StopLoss-ставка на пару | Быть авторизованным на [Libertex](https://libertex.fxclub.by/), иметь на балансе хотя бы 100$ | Начать сделку "вниз", сумма ставки - 100$, мультипликатор - 100, Stop Loss - 1\$ и нажать кнопку <span style="color:red;">Sell</span> | Когда убытки достигнут 1$, сделка автоматически закроется|
7 | 
8 |
9 |
10 |