using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace JsGeneratorLib
{
	public class ProgramSerializer
	{
		public ProgramSerializer ()
		{

		}

		public static string Serialize(Node node) {
			return JsonConvert.SerializeObject (node, new JsonSerializerSettings () {
				NullValueHandling = NullValueHandling.Ignore
			});
		}
	}
}

