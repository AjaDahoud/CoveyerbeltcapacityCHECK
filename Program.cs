using System;

const double LimitPerMotor = 5.6;

Console.Write("How many motors are carrying the package? ");
if (!int.TryParse(Console.ReadLine(), out var motors) || motors <= 0)
{
    Console.WriteLine("Invalid number of motors. Please enter a positive whole number.");
    return;
}

Console.Write("How many kg of packages do we expect? ");
if (!double.TryParse(Console.ReadLine(), out var weight) || weight < 0)
{
    Console.WriteLine("Invalid weight. Please enter a non-negative number.");
    return;
}

var loadPerMotor = weight / motors;

if (loadPerMotor <= LimitPerMotor)
{
    Console.WriteLine($"Conveyor belt can carry the package. (Load per motor = {loadPerMotor:F2} kg)");
}
else
{
    Console.WriteLine($"Conveyor belt cannot carry the package. (Load per motor = {loadPerMotor:F2} kg)");
}