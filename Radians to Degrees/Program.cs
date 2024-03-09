

//π=Math.Pi
//degrees=radians*180 / π
//INPUT:3.1416 OUTPUT:180.0004209182994 INPUT:6.2832 OUTPUT:360.0008418365988 INPUT:0.7854 OUTPUT:45.00010522957485
double radians = double.Parse(Console.ReadLine());
double degrees = radians * 180 / Math.PI;
Console.WriteLine(degrees);


