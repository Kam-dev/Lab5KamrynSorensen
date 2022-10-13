// Draw cat method function
  Drawcat();

  Takeuserinput();

  static void Drawcat() {
    Console.WriteLine("  A___A"); 
    Console.WriteLine(" ( o o )");
    Console.WriteLine("-==_Y_==-");
    Console.WriteLine("   `-'");
  }
  Console.ReadKey();

// user input method function
	static void Takeuserinput() {
	Console.WriteLine("User please enter input: letters, numbers, or words.");  
    string u = Console.ReadLine();
    Console.WriteLine(u); 
  }

// sum of two numbers method function
  static double Sumoftwonumbers(double x, double y) {
  return x + y;
  }
 Console.WriteLine(Sumoftwonumbers (5.20,3.50));

// subtraction of two numbers method function
  static double Subtractionoftwonumbers(double a, double b) {
  return a - b;
  }
 Console.WriteLine(Subtractionoftwonumbers (12.90,6.20));

 // Multiplication of two numbers method unction
  static double Multiplicationoftwonumbers(double c, double d) {
  return c * d;
  }
 Console.WriteLine(Multiplicationoftwonumbers (24.90,6.20));

 // Division of two numbers method function
  static double Divisionoftwonumbers(double e, double f) {
  return e / f;
  }
 Console.WriteLine(Divisionoftwonumbers (30.90,6.30));

  while (true) {
 
  }