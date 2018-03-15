using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExample
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Console.Write("Press any key to continue...");

			Console.ReadKey();

		}

		static string BuilDisplayName(string fName, string lName)
		{
			string full = fName[0] + " " + lName.ToUpper();
			return full;

		} 



	}
}
