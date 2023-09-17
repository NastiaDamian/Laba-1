string my_name = "Nastia";
Console.WriteLine(my_name);


int value1 = Convert.ToInt32(Console.ReadLine());
int value2 = Convert.ToInt32(Console.ReadLine());

//Функція додавання
Console.WriteLine($" {value1} + {value2} = {value1 + value2} ");
int result = value1 + value2;

//Функція віднімання 
Console.WriteLine($" {value1} - {value2} = {value1 - value2} ");
int result_2 = value1 - value2;

//Функція множення 
Console.WriteLine($" {value1} * {value2} = {value1 * value2} ");
int result_3 = value1 * value2;

//Функція ділення 
Console.WriteLine($" {value1} / {value2} = {value1 / value2} ");
int result_4 = value1 / value2;

//Остача від цілочисельного ділення
Console.WriteLine($" {value1} % {value2} = {value1 % value2} ");
int result_5 = value1 % value2;
