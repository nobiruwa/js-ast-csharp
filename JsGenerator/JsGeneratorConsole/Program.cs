using System;
using JsGeneratorLib;

namespace JsGeneratorConsole
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Program p = new Program ();
			EmptyStatement s = new EmptyStatement ();
			p.body.Add (s);
			Console.WriteLine(p.Serialize ());
		}
	}
}
