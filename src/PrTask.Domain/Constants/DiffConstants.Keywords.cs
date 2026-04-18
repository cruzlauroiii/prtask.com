using System.Collections.Frozen;
namespace PrTask.Domain.Constants;
public static partial class DiffConstants
{
    private static FrozenDictionary<string, FrozenSet<string>> BuildLanguageKeywords()
    {
        var Result = new Dictionary<string, FrozenSet<string>>(StringComparer.Ordinal)
        {
            [LanguageCSharp] = FrozenSet.ToFrozenSet<string>([
                "abstract", "as", "async", "await", "base", "bool", "break", "byte", "case", "catch",
                "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double",
                "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
                "foreach", "goto", "if", "implicit", "in", "init", "int", "interface", "internal", "is",
                "lock", "long", "namespace", "new", "not", "null", "object", "operator", "or", "out",
                "override", "params", "partial", "private", "protected", "public", "readonly", "record", "ref", "required",
                "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
                "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
                "using", "var", "virtual", "void", "volatile", "when", "where", "while", "with", "yield"
            ]),
            [LanguageJavaScript] = FrozenSet.ToFrozenSet<string>([
                "async", "await", "break", "case", "catch", "class", "const", "continue", "debugger", "default",
                "delete", "do", "else", "export", "extends", "false", "finally", "for", "from", "function",
                "if", "import", "in", "instanceof", "let", "new", "null", "of", "return", "static",
                "super", "switch", "this", "throw", "true", "try", "typeof", "undefined", "var", "void",
                "while", "with", "yield"
            ]),
            [LanguageTypeScript] = FrozenSet.ToFrozenSet<string>([
                "abstract", "any", "as", "async", "await", "bigint", "boolean", "break", "case", "catch",
                "class", "const", "continue", "debugger", "declare", "default", "delete", "do", "else", "enum",
                "export", "extends", "false", "finally", "for", "from", "function", "if", "implements", "import",
                "in", "infer", "instanceof", "interface", "is", "keyof", "let", "module", "namespace", "never",
                "new", "null", "number", "of", "override", "private", "protected", "public", "readonly", "return",
                "static", "string", "super", "switch", "symbol", "this", "throw", "true", "try", "type",
                "typeof", "undefined", "unique", "unknown", "var", "void", "while", "with", "yield"
            ]),
            [LanguagePython] = FrozenSet.ToFrozenSet<string>([
                "False", "None", "True", "and", "as", "assert", "async", "await", "break", "class",
                "continue", "def", "del", "elif", "else", "except", "finally", "for", "from", "global",
                "if", "import", "in", "is", "lambda", "nonlocal", "not", "or", "pass", "raise",
                "return", "try", "while", "with", "yield"
            ]),
            [LanguageRust] = FrozenSet.ToFrozenSet<string>([
                "as", "async", "await", "break", "const", "continue", "crate", "dyn", "else", "enum",
                "extern", "false", "fn", "for", "if", "impl", "in", "let", "loop", "match",
                "mod", "move", "mut", "pub", "ref", "return", "self", "static", "struct", "super",
                "trait", "true", "type", "unsafe", "use", "where", "while"
            ]),
            [LanguageGo] = FrozenSet.ToFrozenSet<string>([
                "break", "case", "chan", "const", "continue", "default", "defer", "else", "fallthrough", "false",
                "for", "func", "go", "goto", "if", "import", "interface", "map", "nil", "package",
                "range", "return", "select", "struct", "switch", "true", "type", "var"
            ]),
            [LanguageJava] = FrozenSet.ToFrozenSet<string>([
                "abstract", "assert", "boolean", "break", "byte", "case", "catch", "char", "class", "const",
                "continue", "default", "do", "double", "else", "enum", "extends", "false", "final", "finally",
                "float", "for", "if", "implements", "import", "instanceof", "int", "interface", "long", "native",
                "new", "null", "package", "private", "protected", "public", "return", "short", "static", "strictfp",
                "super", "switch", "synchronized", "this", "throw", "throws", "transient", "true", "try", "void",
                "volatile", "while"
            ]),
            [LanguageRuby] = FrozenSet.ToFrozenSet<string>([
                "BEGIN", "END", "alias", "and", "begin", "break", "case", "class", "def", "defined?",
                "do", "else", "elsif", "end", "ensure", "false", "for", "if", "in", "module",
                "next", "nil", "not", "or", "redo", "rescue", "retry", "return", "self", "super",
                "then", "true", "undef", "unless", "until", "when", "while", "yield"
            ]),
            [LanguageSql] = FrozenSet.ToFrozenSet<string>([
                "ADD", "ALL", "ALTER", "AND", "AS", "ASC", "BEGIN", "BETWEEN", "BY", "CASCADE",
                "CASE", "CHECK", "COLUMN", "COMMIT", "CONSTRAINT", "CREATE", "CROSS", "CURSOR", "DATABASE", "DECLARE",
                "DEFAULT", "DELETE", "DESC", "DISTINCT", "DROP", "ELSE", "END", "EXEC", "EXISTS", "FALSE",
                "FETCH", "FOR", "FOREIGN", "FROM", "FULL", "FUNCTION", "GRANT", "GROUP", "HAVING", "IF",
                "IN", "INDEX", "INNER", "INSERT", "INTO", "IS", "JOIN", "KEY", "LEFT", "LIKE",
                "LIMIT", "NOT", "NULL", "ON", "OR", "ORDER", "OUTER", "PRIMARY", "PROCEDURE", "REFERENCES",
                "RETURN", "RIGHT", "ROLLBACK", "ROWCOUNT", "SELECT", "SET", "TABLE", "THEN", "TOP", "TRANSACTION",
                "TRIGGER", "TRUE", "TRUNCATE", "UNION", "UNIQUE", "UPDATE", "USE", "VALUES", "VIEW", "WHEN",
                "WHERE", "WITH"
            ])
        };
        return Result.ToFrozenDictionary(StringComparer.Ordinal);
    }
}
