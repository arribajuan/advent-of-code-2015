// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello there!");
Console.WriteLine("-----------------------------");

#region Day 1

var d01 = new Stars.Day01.Day01();
var d01FinalFloor = d01.CalculateFinalFloorFromDataFile();
var d01IndexReachingBasement = d01.FindIndexWhenReachingBasementFromDataFile();

Console.WriteLine("Day 1");
Console.WriteLine($" Star 1 - final floor = {d01FinalFloor}");
Console.WriteLine($" Star 2 - index when reaching basement = {d01IndexReachingBasement}");
Console.WriteLine("-----------------------------");

#endregion

#region Day 2

var d02 = new Stars.Day02.Day02();
var d02PackageInformation = d02.CalculateSquareFeetFromDataFile();

Console.WriteLine("Day 2");
Console.WriteLine($" Star 1 - total paper = {d02PackageInformation.TotalPaper}");
Console.WriteLine($" Star 2 - total ribbon = {d02PackageInformation.TotalRibbon}");
Console.WriteLine("-----------------------------");

#endregion

#region Day 3

var d03 = new Stars.Day03.Day03();
var d03Result1 = d03.ExecuteMovesFromFile(0);
var d03Result2 = d03.ExecuteMovesFromFile(1);

Console.WriteLine("Day 3");
Console.WriteLine($" Star 1 - houses with at least one present - santa = {d03Result1.HousesWithAtLeastOnePresent}");
Console.WriteLine($" Star 2 - houses with at least one present - santa + 1 robo santa = {d03Result2.HousesWithAtLeastOnePresent}");
Console.WriteLine("-----------------------------");

#endregion

#region Day 4

var d04 = new Stars.Day04.Day04();
var d04Result1 = d04.MineAdventCoinFromFile(5);
var d04Result2 = d04.MineAdventCoinFromFile(6);

Console.WriteLine("Day 4");
Console.WriteLine($" Star 1 - lowest positive number = {d04Result1}");
Console.WriteLine($" Star 2 - lowest positive number = {d04Result2}");
Console.WriteLine("-----------------------------");

#endregion

#region Day 5

var d05 = new Stars.Day05.Day05();
var d05Result1 = d05.TestStringFromFile();

Console.WriteLine("Day 5");
Console.WriteLine($" Star 1 - nice strings = {d05Result1}");
Console.WriteLine("-----------------------------");

#endregion


