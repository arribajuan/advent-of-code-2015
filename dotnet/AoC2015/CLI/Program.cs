// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello there!");

#region Day 1

var d01 = new Stars.Day01.Day01();
var d01FinalFloor = d01.CalculateFinalFloorFromDataFile();
var d01IndexReachingBasement = d01.FindIndexWhenReachingBasementFromDataFile();
    
Console.WriteLine("-----------------------------");
Console.WriteLine("Day 1");
Console.WriteLine($" Star 1 - final floor = {d01FinalFloor}");
Console.WriteLine($" Star 2 - index when reaching basement = {d01IndexReachingBasement}");
Console.WriteLine("-----------------------------");

#endregion

#region Day 2

var d02 = new Stars.Day02.Day02();
var d02PackageInformation = d02.CalculateSquareFeetFromDataFile();

Console.WriteLine("-----------------------------");
Console.WriteLine("Day 2");
Console.WriteLine($" Star 1 - total paper = {d02PackageInformation.TotalPaper}");
Console.WriteLine($" Star 2 - total ribbon = {d02PackageInformation.TotalRibbon}");
Console.WriteLine("-----------------------------");

#endregion




