using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScript
{
	[Flags()]
    public enum ErrorRecoverySet
    {
        None = 0,
        Comma = 1,
        SColon = 1 << 1,
        Asg = 1 << 2,
        BinOp = 1 << 3,
        RBrack = 1 << 4,
        RCurly = 1 << 5,
        RParen = 1 << 6,
        Dot = 1 << 7,
        Colon = 1 << 8,
        PrimType = 1 << 9,
        AddOp = 1 << 10,
        LCurly = 1 << 11,
        PreOp = 1 << 12,
        RegExp = 1 << 13,
        LParen = 1 << 14,
        LBrack = 1 << 15,
        Scope = 1 << 16,
        In = 1 << 17,
        SCase = 1 << 18,
        Else = 1 << 19,
        Catch = 1 << 20,
        Var = 1 << 21,
        Stmt = 1 << 22,
        While = 1 << 23,
        ID = 1 << 24,
        Prefix = 1 << 25,
        Literal = 1 << 26,
        RLit = 1 << 27,
        Func = 1 << 28,
        EOF = 1 << 29,
        TypeScriptS = 1 << 30,
        ExprStart = ErrorRecoverySet.SColon | ErrorRecoverySet.AddOp | ErrorRecoverySet.LCurly | ErrorRecoverySet.PreOp | ErrorRecoverySet.RegExp | ErrorRecoverySet.LParen | ErrorRecoverySet.LBrack | ErrorRecoverySet.ID | ErrorRecoverySet.Prefix | ErrorRecoverySet.RLit | ErrorRecoverySet.Func | ErrorRecoverySet.Literal,
        StmtStart = ErrorRecoverySet.ExprStart | ErrorRecoverySet.SColon | ErrorRecoverySet.Var | ErrorRecoverySet.Stmt | ErrorRecoverySet.While | ErrorRecoverySet.TypeScriptS,
        Postfix = ErrorRecoverySet.Dot | ErrorRecoverySet.LParen | ErrorRecoverySet.LBrack
    }
}
