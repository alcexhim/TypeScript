using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScript.Compiler
{
	public class TypeScriptCompiler
	{
		private CodeGenTarget mvarCodeGenTarget = CodeGenTarget.ES3;
		public CodeGenTarget CodeGenTarget { get { return mvarCodeGenTarget; } set { mvarCodeGenTarget = value; } }

		private ModuleGenTarget mvarModuleGenTarget = ModuleGenTarget.Synchronous;
		public ModuleGenTarget ModuleGenTarget { get { return mvarModuleGenTarget; } set { mvarModuleGenTarget = value; } }

	}
}
