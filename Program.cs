System.Console.Write("hello type your name : ");
string name = Console.ReadLine();
string greeting = $"Hello {name}";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age : ");
string ageStr = Console.ReadLine();
int age = Convert.ToInt32(ageStr);
System.Console.WriteLine("Sucsessfully converted !");

int keschasAge = 7;
string ageDiff = $"The difference betwenn keschas and your age {age - keschasAge}";
System.Console.WriteLine(ageDiff);