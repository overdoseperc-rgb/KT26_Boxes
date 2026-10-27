using System.Globalization;

Console.WriteLine("Задание 1. Обёртки");
var nameBox = new ReferenceBox<string>();
Console.WriteLine("ReferenceBox<string>");
Console.WriteLine($"До заполнения: IsEmpty = {nameBox.IsEmpty}");
Console.WriteLine($"Get() == null: {nameBox.Get() == null}");

Console.Write("Введите имя: ");
string name = Console.ReadLine() ?? "";
nameBox.Set(name);

Console.WriteLine($"После Set: IsEmpty = {nameBox.IsEmpty}");
Console.WriteLine($"Get() = {nameBox.Get()}");
Console.WriteLine();

var numberBox = new ValueBox<int>();
Console.WriteLine("ValueBox<int>");
Console.WriteLine($"До заполнения: IsEmpty = {numberBox.IsEmpty}");
Console.WriteLine($"Get() == null: {numberBox.Get() == null}");

Console.Write("Введите целое число: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Нужно целое число. Повторите ввод: ");
}

numberBox.Set(number);
Console.WriteLine($"После Set: IsEmpty = {numberBox.IsEmpty}");
Console.WriteLine($"Get() = {numberBox.Get()}");

Console.WriteLine();
Console.WriteLine("Задание 2. Кэш");

var textCache = new ReferenceCache<string>();
Console.WriteLine("ReferenceCache<string>");
bool textFound = textCache.TryGet(out string? text);
Console.WriteLine($"До заполнения: TryGet = {textFound}, value == null: {text == null}");

Console.Write("Введите строку для кэша: ");
textCache.Set(Console.ReadLine() ?? "");
textFound = textCache.TryGet(out text);
Console.WriteLine($"После Set: TryGet = {textFound}, value = {text}");
Console.WriteLine();

var valueCache = new ValueCache<double>();
Console.WriteLine("ValueCache<double>");
bool valueFound = valueCache.TryGet(out double? value);
Console.WriteLine($"До заполнения: TryGet = {valueFound}, value == null: {value == null}");

Console.Write("Введите число для кэша: ");
double cacheNumber;
while (!double.TryParse(Console.ReadLine()?.Replace(',', '.'),
    NumberStyles.Float, CultureInfo.InvariantCulture, out cacheNumber)
    || !double.IsFinite(cacheNumber))
{
    Console.Write("Введите число, например 12,5: ");
}

valueCache.Set(cacheNumber);
valueFound = valueCache.TryGet(out value);
Console.WriteLine($"После Set: TryGet = {valueFound}, value = {value}");

// var wrongReferenceBox = new ReferenceBox<int>();
// CS0452: int — тип значения, а требуется ссылочный тип.
// var wrongValueBox = new ValueBox<string>();
// CS0453: string — ссылочный тип, а требуется тип значения.
// var wrongReferenceCache = new ReferenceCache<double>();
// CS0452: double — тип значения, а требуется ссылочный тип.
// var wrongValueCache = new ValueCache<string>();
// CS0453: string — ссылочный тип, а требуется тип значения.
