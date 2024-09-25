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

//Select

//1 вариант набора синтаксиса
IEnumerable<int> departmentIds_v1 = employees.Select(item => item.Departament.ID);

Console.WriteLine("Вывод коллекции отделов сотрудников(вариант 1):");
departmentIds_v1.ToList().ForEach(item => Console.WriteLine(item + "\t"));

//2 вариант набора синтаксиса
Console.WriteLine("Вывод коллекции отделов сотрудников(вариант 2):");
IEnumerable<string> departmentIds_v2 = 
    from _employee in employees                     //_employee - alias коллекции
    select _employee.Departament.Name;              //выборка

departmentIds_v2.ToList().ForEach(item => Console.WriteLine(item));


//Where 

//1 вариант набора синтаксиса
Console.WriteLine("where(вариант 1):");
IEnumerable<Employee> employee_v1 = employees.Where<Employee>(item => item.Name.Equals("Иван"));

//2 вариант набора синтаксиса
Console.WriteLine("where(вариант 2):");
IEnumerable<Employee> employee_v2 =
    from _employee in employees                     //_employee - alias коллекции
    where _employee.Name.Equals("Иван")             //условие выборки
    select _employee;                               //выборка



//Order by 

//1 вариант набора синтаксиса
Console.WriteLine("order by(вариант 1):");
employee_v1 = employees
    //.OrderBy(item => item.Name);
    .OrderByDescending(item => item.Name);

//2 вариант набора синтаксиса
Console.WriteLine("order by(вариант 2):");
employee_v2 =
    from _employee in employees                     //_employee - alias коллекции
    orderby _employee.Name                          //ключ сортировки
    descending                                      //убывание/возрастание
    select _employee;                               //выборка

//ThenBy
//1 вариант набора синтаксиса

//Добавить идентичного пользователя с другим возрастом
employees.Add(new Employee { Name = "Иван", Age = 21, Departament = departaments[1] });
employees.Add(new Employee { Name = "Иван", Age = 21, Departament = departaments[0] });

employee_v1 = employees.OrderBy(item => item.Name)
    .ThenBy(item => item.Age)
    .ThenBy(item => item.Departament.ID);
    //.ThenByDescending(item => item.Age);

//2 вариант набора синтаксиса
employee_v2 =
    from _employee in employees                     //_employee - alias коллекции
    orderby _employee.Name                          //ключ сортировки
    , _employee.Age                                 //Дополнительный ключ сортировки
    /*descending*/
    select _employee;                               //выборка


//GroupBy
//1 вариант набора синтаксиса
var departmentNames_v1 =  employees.GroupBy(item => item.Departament.Name);

//2 вариант набора синтаксиса
var departmentNames_v2 =
    (from _employee in employees                     //_employee - alias коллекции
    group _employee by _employee.Departament.Name)   //ключ сортировки
    ;                               //выборка


//Distinct
//Удаление дубликатов

IEnumerable<Employee> tempEmpl = employees.Distinct(new EmplEqualityComparer());

string[] soft = { "Microsoft", "Google", "Apple", "Microsoft", "Google" };
IEnumerable<string> softWithoutDuplicates = soft.Distinct();


//Take
//Взять первые 3 элемента
IEnumerable<string> firstThree = soft.Take(3);


//Взять элементы с 1 по 5(не включительно)
IEnumerable<string> secondThree = soft.Take(new Range(1, soft.Length));


//Skip
IEnumerable<string> skip = soft.Skip(3);

;