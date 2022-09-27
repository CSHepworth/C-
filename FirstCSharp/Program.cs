static string SayHello(string firstName = "buddy")
{
    return $"Hey {firstName}";
}
string greeting;
greeting = SayHello();
Console.WriteLine(greeting);