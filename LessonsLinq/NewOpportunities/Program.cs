//Chunk
using NewOpportunities;
using System.Collections.Generic;

List<Movie> movies = new List<Movie>
{
    new Movie("Titanic", 1998, 4.5f),
    new Movie("The Fifth Element", 1997, 4.6f),
    new Movie("Terminator 2", 1991, 4.7f),
    new Movie("Avatar", 2009, 5),
    new Movie("Platoon", 1986, 4),
    new Movie("My Neighbor Totoro", 1988, 5)
};

IEnumerable<Movie[]> chunksOf3 = movies.Chunk(3);



// TryGetNotEnumeratedCount
int sizeOfMovies = 0;
movies.TryGetNonEnumeratedCount(out sizeOfMovies);

IEnumerable<int> arrayOne = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
bool canGetCountDirectly = arrayOne.TryGetNonEnumeratedCount(out int theCount);
Console.WriteLine($"Array One count can be returned directly = {canGetCountDirectly}");
Console.WriteLine($"The count for Array One = {theCount}");

List<int> listOne = new List<int> { 1, 2, 3, 4, 5 };
canGetCountDirectly = listOne.TryGetNonEnumeratedCount(out int theCountList);
Console.WriteLine($"List One count can be returned directly = {canGetCountDirectly}");
Console.WriteLine($"The count for List One = {theCountList}");

MyItems<int> customOne = new MyItems<int>();
canGetCountDirectly = customOne.TryGetNonEnumeratedCount(out int theCountCustom);
Console.WriteLine($"Custom One count can be returned directly = {canGetCountDirectly}");
Console.WriteLine($"The count for Custom One = {theCountCustom}");


//Three way zipping
int[] numbers = { 1, 2, 3, 4 };
string[] words = { "one", "two", "three" };

var numbersAndWords = 
    numbers.Zip(
        words, 
        (first, second) => new { Number = first, Word = second });


//MaxBy
Movie maxYearMovie = movies.MaxBy(item => item.ReleaseYear);
//MinBy
Movie minRatioMovie = movies.MinBy(item => item.Rating);


//ElementAt
Movie movie = movies.ElementAt(2);
movie = movies.ElementAt(new Index (1, false));
movie = movies.ElementAt(new Index(1, true));

//Показать эксепшен
//movie = movies.ElementAt (new Index (0, true));

//Take
IEnumerable<Movie> _movies = movies.Take(4);

_movies = movies.Take(new Range (0, 4));

;
record Movie(string Name, int ReleaseYear, float Rating);