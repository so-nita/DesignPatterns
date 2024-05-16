
using TemplateMethodPattern.BreadExample;

Console.WriteLine("Bread example Template Method Pattern");

var whiteBread = new WhiteBread();
whiteBread.Make();

Console.WriteLine();

var wholeWheatBread = new WholeWheatBread();
wholeWheatBread.Make();

