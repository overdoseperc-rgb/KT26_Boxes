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

// var wrongReferenceBox = new ReferenceBox<int>();
// CS0452: int — тип значения, а требуется ссылочный тип.
// var wrongValueBox = new ValueBox<string>();
// CS0453: string — ссылочный тип, а требуется тип значения.
