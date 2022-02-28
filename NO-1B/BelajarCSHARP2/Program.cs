/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 23/02/2022
 * Time: 22.38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BelajarCSHARP2
{
	class programHW
	{
		static void Main(string[] args)
		{
			Console.Write("Nama Kamu Siapa?");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama Kamu "+nama);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}