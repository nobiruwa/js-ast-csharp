using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsGeneratorLib
{
	public class Program: Node
	{
		private List<Statement> __body = new List<Statement>();

		public Program ()
		{
		}

		[JsonProperty(Order = 2)]
		public List<Statement> body {
			get {
				return this.__body;
			}
		}
		public string Serialize()
		{
			return ProgramSerializer.Serialize (this);
		}
	}
}

