using LessonsLinq;

//Создание коллекции отделов
Departament[] departaments = new Departament[]
{
    new Departament("Бухгалтерия")
    , new Departament("Конструкторский Отдел")
    , new Departament("Кадры")
};

//Создание колл
List<Employee> employees = new List<Employee>
{
    new Employee{ Name = "Иван", Age = 20, Departament = departaments[0] }
    , new Employee{ Name = "Сергей", Age = 30, Departament = departaments[1] }
    , new Employee{ Name = "Василий", Age = 40, Departament = departaments[2] }
    , new Employee{ Name = "Светлана", Age = 40, Departament = departaments[1] }
};

Console.WriteLine("Вывод коллекции:");
employees.ForEach(item => Console.WriteLine(item.ToString()));


//1 вариант набора синтаксиса
IEnumerable<int> departmentIds_v1 = employees.Select(item => item.Departament.ID);

Console.WriteLine("Вывод коллекции отделов сотрудников(вариант 1):");
departmentIds_v1.ToList().ForEach(item => Console.WriteLine(item + "\t"));

//2 вариант набора синтаксиса
Console.WriteLine("Вывод коллекции отделов сотрудников(вариант 2):");
IEnumerable<string> departmentIds_v2 = 
    from _employee in employees                     //_employee - alias коллекции
    where _employee.Departament.Name.Length > 12    //условие выборки
    select _employee.Departament.Name;              //выборка

departmentIds_v2.ToList().ForEach(item => Console.WriteLine(item));



//Distinct
//Удаление дубликатов
string[] soft = { "Microsoft", "Google", "Apple", "Microsoft", "Google" };
IEnumerable<string> softWithoutDuplicates = soft.Distinct();



//Take
//Взять первые 3 элемента
IEnumerable<string> firstThree = soft.Take(3);

//Взять элементы с 1 по 5(не включительно)
IEnumerable<string> secondThree = soft.Take(new Range ( 1, 5 ));


//Skip
IEnumerable<string> skip = soft.Skip(3);

;