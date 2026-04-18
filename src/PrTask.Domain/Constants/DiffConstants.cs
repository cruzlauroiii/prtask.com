using System.Collections.Frozen;
namespace PrTask.Domain.Constants;
public static partial class DiffConstants
{
    public const string GitDiffPrefix = "diff --git";
    public const string AdditionPrefix = "+++";
    public const string DeletionPrefix = "---";
    public const string HunkPrefix = "@@";
    public const int HeaderMinParts = 4;
    public const int PrefixLength = 3;
    public const int HeaderPartAIndex = 2;
    public const int HeaderPartBIndex = 3;
    public const string RedactedMarker = "[REDACTED]";
    public const string DefaultFileName = "changes";
    public const string CssClassAdded = "diff-line-added";
    public const string CssClassDeleted = "diff-line-deleted";
    public const string CssClassModified = "diff-line-modified";
    public const string CssClassUnchanged = "diff-line-unchanged";
    public const string CssClassImaginary = "diff-line-imaginary";
    public const string CssClassSideBySide = "diff-side-by-side";
    public const string CssClassInline = "diff-inline";
    public const string LanguageCSharp = "csharp";
    public const string LanguageJavaScript = "javascript";
    public const string LanguageTypeScript = "typescript";
    public const string LanguageCss = "css";
    public const string LanguageHtml = "html";
    public const string LanguageJson = "json";
    public const string LanguageXml = "xml";
    public const string LanguageSql = "sql";
    public const string LanguagePython = "python";
    public const string LanguageRust = "rust";
    public const string LanguageGo = "go";
    public const string LanguageJava = "java";
    public const string LanguageRuby = "ruby";
    public const string LanguagePlainText = "plaintext";
    public const string ExtensionCs = ".cs";
    public const string ExtensionRazor = ".razor";
    public const string ExtensionJs = ".js";
    public const string ExtensionJsx = ".jsx";
    public const string ExtensionTs = ".ts";
    public const string ExtensionTsx = ".tsx";
    public const string ExtensionCss = ".css";
    public const string ExtensionScss = ".scss";
    public const string ExtensionHtml = ".html";
    public const string ExtensionHtm = ".htm";
    public const string ExtensionJson = ".json";
    public const string ExtensionXml = ".xml";
    public const string ExtensionSql = ".sql";
    public const string ExtensionPy = ".py";
    public const string ExtensionRs = ".rs";
    public const string ExtensionGo = ".go";
    public const string ExtensionJava = ".java";
    public const string ExtensionRb = ".rb";
    public const string SideBySideViewLabel = "Side-by-Side";
    public const string InlineViewLabel = "Inline";
    public const string DiffStatsFormat = "+{0} -{1} ~{2}";
    public const string NoContentMessage = "No content to compare.";
    public const string EmptyLineMarker = " ";
    public const string LineTypeAdd = "add";
    public const string LineTypeDel = "del";
    public const string LineTypeContext = "context";
    public const string DiffSpacePrefix = "diff ";
    public const char AdditionChar = '+';
    public const char DeletionChar = '-';
    public const int MinLineLength = 1;
    public const string SpanOpenComment = "<span class=\"cmt\">";
    public const string SpanOpenString = "<span class=\"str\">";
    public const string SpanOpenNumber = "<span class=\"num\">";
    public const string SpanOpenKeyword = "<span class=\"kw\">";
    public const string SpanOpenTag = "<span class=\"tag\">";
    public const string SpanClose = "</span>";
    public const string CommentBlockOpen = "/*";
    public const string CommentBlockClose = "*/";
    public const string CommentSlash = "//";
    public const string CommentHash = "#";
    public const string CommentDash = "--";
    public const string HtmlLessThan = "<";
    public const string HtmlGreaterThan = ">";
    public static readonly FrozenDictionary<string, FrozenSet<string>> LanguageKeywords = BuildLanguageKeywords();
    public static readonly FrozenDictionary<string, string> CommentPrefixes = new Dictionary<string, string>(StringComparer.Ordinal)
    {
        [LanguageCSharp] = CommentSlash, [LanguageJavaScript] = CommentSlash, [LanguageTypeScript] = CommentSlash,
        [LanguageRust] = CommentSlash, [LanguageGo] = CommentSlash, [LanguageJava] = CommentSlash,
        [LanguageCss] = CommentBlockOpen, [LanguagePython] = CommentHash, [LanguageRuby] = CommentHash,
        [LanguageSql] = CommentDash
    }.ToFrozenDictionary(StringComparer.Ordinal);
    public static readonly FrozenSet<string> SlashCommentLanguages = FrozenSet.ToFrozenSet(
        [LanguageCSharp, LanguageJavaScript, LanguageTypeScript, LanguageRust, LanguageGo, LanguageJava, LanguageCss]);
    public static readonly FrozenDictionary<string, string> ExtensionToLanguageMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        [ExtensionCs] = LanguageCSharp, [ExtensionRazor] = LanguageCSharp,
        [ExtensionJs] = LanguageJavaScript, [ExtensionJsx] = LanguageJavaScript,
        [ExtensionTs] = LanguageTypeScript, [ExtensionTsx] = LanguageTypeScript,
        [ExtensionCss] = LanguageCss, [ExtensionScss] = LanguageCss,
        [ExtensionHtml] = LanguageHtml, [ExtensionHtm] = LanguageHtml,
        [ExtensionJson] = LanguageJson, [ExtensionXml] = LanguageXml, [ExtensionSql] = LanguageSql,
        [ExtensionPy] = LanguagePython, [ExtensionRs] = LanguageRust, [ExtensionGo] = LanguageGo,
        [ExtensionJava] = LanguageJava, [ExtensionRb] = LanguageRuby
    }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase);
}
