//Any
using System.ComponentModel;

string[] people = { "Tom", "Tim", "Bob", "Sam" };

//Существуют ли элементы, начинающиеся с символа А
bool startT = people.Any(item => item.StartsWith("A"));


//All
//Все ли элементы имеют длину 3 символа
bool allLengthIsThree = people.All(item => item.Length == 3);

//Все ли элементы начинаются с T
bool allStartOnT = people.All(item => item.StartsWith("T"));

//Contains
bool isContainsTom = people.Contains("Tom");
bool isContainsAlice = people.Contains("Alice");

//Рассмотреть ли случай с компаратором?

;
// проверяем, все ли элементы имеют длину больше 3 символов
//bool allHasMore3Chars = people.Any(s => s.);     // false