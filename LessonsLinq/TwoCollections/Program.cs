//Join
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
var employees = from p in people
                join c in companies on p.Company equals c.Title
                select new { Name = p.Name, Company = c.Title, Language = c.Language };

var t = people.Join(companies, person=> person.Company, comp => comp.Title, (person, comp) => new { Name = person.Name, Lang = comp.Language } );
;
record class Person(string Name, string Company);
record class Company(string Title, string Language);

