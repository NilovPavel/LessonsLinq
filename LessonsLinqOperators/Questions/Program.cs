//1. Анонимные типы
var person = new { id = 1, Name = "John" };

//Применение в linq
int i = 1;
string[] names = new string[] { "James", "Alice", "Anna" };
var namesOfanonimous = names.Select(name => new { id = i++, Name = name });


//2. Агрегатные функции
int[] nums = new int[] { 1, 2, 3, 4, 5 };
double[] numm = new double[] { 1, 2, 3, 4, 5 };
int a = nums.Count();
double b = numm.Average();
double c = numm.Max();


//3. Как работает селектор
//По сути просто как указатель на поле типа
Func<Student, int> func = (x)  =>  x.GroupId;

class Student
{
    public int id { get; set; }

    public int GroupId { get; set;}
}

class Group
{
    public int GroupId {  get; set; }
}


//4. Методы расширения
public static class Extents
{
    public static IEnumerable<TResult> Convert<TSource, TResult>(
            this IEnumerable<TSource> source
        , Func<TSource, TResult> selector)
    {
        return source.Select(item => selector.Invoke(item));
    }
}