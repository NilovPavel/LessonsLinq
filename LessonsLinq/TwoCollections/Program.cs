using System;

Person[] people =
{
    new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
    new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
};

Company[] companies =
{
    new Company("Microsoft", "C#"),
    new Company("Google", "Go"),
    new Company("Oracle", "Java")
};


//Join
//Var1
var var1 = from p in people
                join c in companies on p.Company equals c.Title
                select new { Name = p.Name, Company = c.Title, Language = c.Language };
//Var2
var var2 = people.Join(
    companies, 
    person=> person.Company, 
    comp => comp.Title, 
    (person, comp) => new { Name = person.Name, Lang = comp.Language } 
    );


string[] soft = { "Microsoft", "Google", "Apple" };
string[] hard = { "Apple", "IBM", "Samsung" };

//Union
IEnumerable<string> unionCompanies = soft.Union(hard);

//Concat
IEnumerable<string> concatCompanies = soft.Concat(hard);

//Except 
IEnumerable<string> exceptCompaines = soft.Except(hard);

//InterSect
IEnumerable<string> intersectCompaines = soft.Intersect(hard);

;
record class Person(string Name, string Company);
record class Company(string Title, string Language);

