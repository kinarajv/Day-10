using MainProgram;
using System.Collections.Generic;

partial class Program 
{
	static void Main() 
	{
		int x = 4;
		int y = 2;
		Printer(CalculatorAdd(x, y));
		Printer(CalculatorDivider(x, y));
		Printer(CalculatorMultiply(x, y));
	}
}