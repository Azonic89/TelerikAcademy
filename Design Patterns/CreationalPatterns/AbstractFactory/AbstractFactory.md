# Abstract Factory(Creational Pattern)

###Bulgarian(Description)
> * Abstract Factory концепцията предоставя начин, по който да се енкапсулира създаването на сходни конкретни обекти, без да се конкретизират техните класове. 
Клиентът създава конкретна имплементация на абстрактната фабрика и я използва през абстрактният интерфейс, за да създава конкретни обекти. 
Той не се интересува какъв конкретен обект получава, тъй като го изполва през съотвения интерфейс.
Най-често се изполва при приложения/системи, които подлежат често на промени.
Лесно зе заменят обекти и дава гъвкавост. 
Тази идея за дизайн разделя създаването на обект от използването му - фабриката определя конкретния обект и го създава, но връща само абстрактция към конкретния обект. 
Клиентът получава абстрактен обект от желания тип а не конкретика.

###English(Description)
> * Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
Each implementation initializes a different set of specific implementations of an abstraction.

>  [_Click here for more information_](http://www.dofactory.com/net/abstract-factory-design-pattern "Title")

>  [_Click here for more information_](https://en.wikipedia.org/wiki/Abstract_factory_pattern "Title")


#####Important link below that helps understading patterns as a concept of ideas
 __(https://www.manning.com/books/dependency-injection-in-dot-net)__