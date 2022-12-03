
Console.WriteLine("Введите сумму которую надо разменять");
int sum = int.Parse(Console.ReadLine());
int remainsum = 0;
Console.WriteLine("Данную сумму можно разменять купюрами:");
if(sum /5000 != 0)
{
    Console.WriteLine("Купюры 5000 рублей:" + sum / 5000);
    sum = sum % 5000;
}
if (sum / 1000 != 0)
{
    Console.WriteLine("Купюры 1000 рублей:" + sum / 1000);
    sum = sum % 5000;
}
if (sum / 500 != 0)
{
    Console.WriteLine("Купюры 500 рублей:" + sum / 500);
    sum = sum % 500;
}
if (sum / 100 != 0)
{
    Console.WriteLine("Купюры 100 рублей:" + sum / 100);
    sum = sum % 100;
}
if (sum / 50 != 0)
{
    Console.WriteLine("Купюры 50 рублей:" + sum / 50);
    sum = sum % 50;
}
if (sum / 10 != 0)
{
    Console.WriteLine("Монеты 10 рублей:" + sum / 10);
    sum = sum % 10;
}
if (sum / 5 != 0)
{
    Console.WriteLine("Монеты 5 рублей:" + sum / 5);
    sum = sum % 5;
}
if (sum / 2 != 0)
{
    Console.WriteLine("Монеты 2 рубля:" + sum / 2);
    sum = sum % 2;
}
if (sum / 1 != 0)
{
    Console.WriteLine("Монеты 1 рубль:" + sum);
 
}