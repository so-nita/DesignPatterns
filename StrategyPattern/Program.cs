﻿
using StrategyPattern;
using StrategyPattern.Common;
using StrategyPattern.SortingExample;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sorting example");

        ISortStrategy sortStrategy = new SortByFirstName();

        var sortablePersons = new SortablePersons(sortStrategy);

        sortablePersons.Add(new Person("Dennis", "Ritchie", 1941));
        sortablePersons.Add(new Person("Linus", "Torvalds", 1969));
        sortablePersons.Add(new Person("Tim", "Berners-Lee", 1955));
        sortablePersons.Add(new Person("Larry", "Page", 1973));
        sortablePersons.Add(new Person("Anders", "Hejlsberg", 1960));
        sortablePersons.Add(new Person("Bjarne", "Stroustrup", 1950));

        Console.WriteLine("Sorting persons by first name.");

        SortAndDisplay(sortablePersons);

        sortablePersons.SortStrategy = new SortByYearOfBirth();
        Console.WriteLine("\nSorting persons by year of birth.\n");

        SortAndDisplay(sortablePersons);
    }
    private static void SortAndDisplay(SortablePersons sortablePersons)
    {
        foreach (var person in sortablePersons.Sort())
        {
            Console.WriteLine(person.ToString());
        }
    }
}
