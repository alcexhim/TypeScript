using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScript
{
	[Flags()]
	public enum AllowedElements
	{
		None = 0,
        ModuleDeclarations = 1 << 2,
        ClassDeclarations = 1 << 3,
        InterfaceDeclarations = 1 << 4,
        AmbientDeclarations = 1 << 10,
        Properties = 1 << 11,
        Global = AllowedElements.ModuleDeclarations | AllowedElements.ClassDeclarations | AllowedElements.InterfaceDeclarations | AllowedElements.AmbientDeclarations,
        QuickParse = AllowedElements.Global | AllowedElements.Properties
	}
}
