using System;
using System.Collections.Generic;
using System.Linq;


List<string> names = new()
{
    "Миша",
    "Вася",
    "Петя",
    "Гриша"
};

var firstPeson = names.First();
Console.WriteLine($"первое имя: {firstPeson}");

var secondAndThird = names.Skip(1).Take(2);
Console.WriteLine("Второе и третье имена:");
foreach (var name in secondAndThird)
{
    Console.WriteLine(name);
}

var startsWithM = names.Where(names => names.StartsWith("М"));
Console.WriteLine("Имя которое начинается с буквы 'М'");
foreach (var name in startsWithM)
{
    Console.WriteLine(name);
}


var containsYa = names.Where(name => name.Contains("я"));
Console.WriteLine("Имена, содержащие букву 'я':");
foreach (var name in containsYa)
{
    Console.WriteLine(name);
}

var countContainsYa = containsYa.Count();
Console.WriteLine($"количество людей с буквой 'я' в имени: {countContainsYa}");

var checkForPetya = names.Contains("Петя");
Console.WriteLine($"проверка на наличие Пети... Петя под номером: {countContainsYa}");

var sortedNames = names.OrderBy(name => name);
Console.WriteLine("все имена в алфавитном порядке:");
foreach (var name in sortedNames)
{
    Console.WriteLine(name);
}