


using System;
using System.Collections.Generic;
using Mango.Templates.Minge;



public static class MingeDemo {

	public static void Main ()
	{
		MingeEnvironment env = new MingeEnvironment ("", new string [] { "demos" });
		MingeContext manager = new MingeContext (env);

		Console.WriteLine ("template directory needs update:  {0}", manager.CheckForUpdates ());

		manager.CompileTemplates ();
		manager.LoadTemplates ();

		manager.RenderToStream ("template.html", Console.Out, new Dictionary<string,object> ());
	}
}
