using LinqUndeclarativeExamples;

string[] words = ["the", "quick", "brown", "fox", "jumps"];

// Where
IEnumerable<string> query = from word in words
                            where word.Length == 3
                            select word;

/*IEnumerable<string> query =
    words.Where(word => word.Length == 3);*/

foreach (string str in query)
{
    Console.WriteLine(str);
}

// OfType
List<IPerson> peoples = new List<IPerson>()
{
    new Child {  }
    , new Child {  }
    , new Parent { }
};

var onlyChilds = peoples.OfType<Child>().ToList();