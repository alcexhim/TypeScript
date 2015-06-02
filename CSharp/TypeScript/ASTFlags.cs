using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScript
{
	[Flags()]
	public enum ASTFlags
	{
        None = 0,
        ExplicitSemicolon = 1,
        AutomaticSemicolon = 1 << 1,
        Writeable = 1 << 2,
        Error = 1 << 3,
        DotLHSPartial = 1 << 4,
        DotLHS = 1 << 5,
        IsStatement = 1 << 6,
        StrictMode = 1 << 7,
        PossibleOptionalParameter = 1 << 8,
        ClassBaseConstructorCall = 1 << 9,
        OptionalName = 1 << 10,
        SkipNextRParen = 1 << 11
	}
}
