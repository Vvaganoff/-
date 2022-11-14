Console.Write( "Введите первое число: " );
int num1 = Convert.ToInt32( Console.ReadLine() );
Console.Write( "Введите второе число: " );
int num2 = Convert.ToInt32( Console.ReadLine() );

if (num1 > num2) 
{
    Console.WriteLine ( "Число " + num1 + " больше, чем " + num2 );
    Console.WriteLine ( "Число " + num2 + " меньше, чем " + num1 );
}
else if (num2 > num1) 
{
    Console.WriteLine ( "Число " + num2 + " больше, чем " + num1 );
    Console.WriteLine ( "Число " + num1 + " меньше, чем " + num2 );
}
else Console.WriteLine( "Эти числа равны" );