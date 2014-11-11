using NUnit.Framework;
using System;
using JsGeneratorLib;

namespace JsGeneratorLibTest
{
	[TestFixture ()]
	public class ProgramTest
	{
		[Test ()]
		public void SerializeTest ()
		{
			Program p = new Program ();
			Assert.AreNotEqual("", p.Serialize ());
			Assert.AreEqual (@"{""type"":""Program"",""body"":[]}", p.Serialize ());
		}
		[Test ()]
		public void SerializeTest_WithEmptyStatement ()
		{
			Program p = new Program ();
			EmptyStatement s = new EmptyStatement ();
			p.body.Add (s);

			Assert.AreEqual (@"{""type"":""Program"",""body"":[{""type"":""EmptyStatement""}]}", p.Serialize ());
		}
	}
}

