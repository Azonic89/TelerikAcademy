# Factory Method(Creational Pattern)

###Bulgarian(Description)
> * Абстрактен метод, имплементиран в типове наследници, които да инициализират нужните им зависимости.
В случай когато наследници на един и същи базов клас имат нужда от различни имплементации на еднаква друга абстракция, от която са зависими, отговорността за създаването на въпросните зависимости бива предадена на долу по веригата до компетентното ниво на имплементация чрез абстрактни или виртуални методи.
Компетентния клас съответно инициализира такава конкретна имплементация на абсракцията, от която е зависим, каквато му е нужда в конкретния случай.
Но тази концепция прави кода по труден за четене тъй като целия код стой за абстрактция. Може и да се окаже като атни-шаблон ако се използва не правилно.
###English(Description)
> * Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

>  [_Click here for more information_](http://www.dofactory.com/net/factory-method-design-pattern "Title")

>  [_Click here for more information_](https://en.wikipedia.org/wiki/Factory_method_pattern "Title")
#####Important link below that helps understading patterns as a concept of ideas.
 __(https://www.manning.com/books/dependency-injection-in-dot-net)__