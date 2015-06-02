using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScript
{
	public enum ModuleGenTarget
	{
        Synchronous = 0,
        Asynchronous = 1,
        Local = 1 << 1
	}
}
