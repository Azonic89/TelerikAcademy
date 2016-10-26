# Singleton(Creational Pattern)

###Bulgarian(Description)
> * Singleton или Единичен е клас които се инстанцира само един път в целия живот на програмата.
Когато има изрична нужда от единствена инстанция на обект, продиктувана от потенциални грешки в изпълнението по каквато и да било причина, целта е да бъде гарантирано съществуването на само една инстанция.
Singleton концепцията нарушава Single Responsibility Principle, тъй като той сам си оправлява създаването и живот.
Класовете също така се Couple-ват сериозно което прави кода трудно тестваем. 
Трябва да бъде и статичен клас което носи още минуси.

###English(Description)
> * Ensure a class has only one instance and provide a global point of access to it.
It's with private or protected constructor and a static field/property providing an instance of the spoken class.
One disadvantage is that it has to be a static class.

>  [_Click here for more information_](http://www.dofactory.com/net/singleton-design-pattern "Title")

>  [_Click here for more information_](https://en.wikipedia.org/wiki/Singleton_pattern "Title")

#####Important link below that helps understading patterns as a concept of ideas
 __(https://www.manning.com/books/dependency-injection-in-dot-net)__