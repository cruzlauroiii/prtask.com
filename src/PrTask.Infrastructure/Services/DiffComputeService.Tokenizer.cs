using System.Collections.Frozen;
using System.Net;
using System.Text;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public sealed partial class DiffComputeService
{
    public string TokenizeLine(string Text, string Language)
    {
        if (string.IsNullOrEmpty(Text)) { return string.Empty; }
        var Keywords = DiffConstants.LanguageKeywords.GetValueOrDefault(Language);
        var IsSqlLike = Language == DiffConstants.LanguageSql;
        var Result = new StringBuilder(Text.Length * 2);
        var Position = 0;
        while (Position < Text.Length)
        {
            if (TryTokenizeComment(Text, Position, Language, Result, out var CommentEnd))
            {
                Position = CommentEnd;
                continue;
            }
            if (TryTokenizeString(Text, Position, Language, Result, out var StringEnd))
            {
                Position = StringEnd;
                continue;
            }
            if (TryTokenizeNumber(Text, Position, Result, out var NumberEnd))
            {
                Position = NumberEnd;
                continue;
            }
            if (TryTokenizeWord(Text, Position, Keywords, IsSqlLike, Result, out var WordEnd))
            {
                Position = WordEnd;
                continue;
            }
            if (TryTokenizeHtmlTag(Text, Position, Language, Result, out var TagEnd))
            {
                Position = TagEnd;
                continue;
            }
            Result.Append(WebUtility.HtmlEncode(Text[Position].ToString()));
            Position++;
        }
        return Result.ToString();
    }
    private static bool TryTokenizeComment(string Text, int Position, string Language, StringBuilder Result, out int End)
    {
        End = Position;
        if (!DiffConstants.CommentPrefixes.TryGetValue(Language, out var Prefix)) { return false; }
        if (Position + Prefix.Length > Text.Length) { return false; }
        if (!Text.AsSpan(Position).StartsWith(Prefix.AsSpan(), StringComparison.Ordinal)) { return false; }
        if (Prefix == DiffConstants.CommentBlockOpen)
        {
            var CloseIndex = Text.IndexOf(DiffConstants.CommentBlockClose, Position + 2, StringComparison.Ordinal);
            End = CloseIndex >= 0 ? CloseIndex + 2 : Text.Length;
        }
        else
        {
            End = Text.Length;
        }
        Result.Append(DiffConstants.SpanOpenComment).Append(WebUtility.HtmlEncode(Text[Position..End])).Append(DiffConstants.SpanClose);
        return true;
    }
    private static bool TryTokenizeString(string Text, int Position, string Language, StringBuilder Result, out int End)
    {
        End = Position;
        var Character = Text[Position];
        var IsStringDelimiter = Character == '"' || Character == '\''
            || (Character == '`' && (Language == DiffConstants.LanguageJavaScript || Language == DiffConstants.LanguageTypeScript));
        if (!IsStringDelimiter) { return false; }
        var SearchFrom = Position + 1;
        while (SearchFrom < Text.Length)
        {
            if (Text[SearchFrom] == '\\') { SearchFrom += 2; continue; }
            if (Text[SearchFrom] == Character) { SearchFrom++; break; }
            SearchFrom++;
        }
        End = SearchFrom;
        Result.Append(DiffConstants.SpanOpenString).Append(WebUtility.HtmlEncode(Text[Position..End])).Append(DiffConstants.SpanClose);
        return true;
    }
    private static bool TryTokenizeNumber(string Text, int Position, StringBuilder Result, out int End)
    {
        End = Position;
        var Character = Text[Position];
        if (!char.IsDigit(Character) && !(Character == '.' && Position + 1 < Text.Length && char.IsDigit(Text[Position + 1])))
        {
            return false;
        }
        if (Position > 0 && (char.IsLetter(Text[Position - 1]) || Text[Position - 1] == '_')) { return false; }
        var Current = Position;
        if (Current + 1 < Text.Length && Text[Current] == '0' && (Text[Current + 1] == 'x' || Text[Current + 1] == 'X'))
        {
            Current += 2;
            while (Current < Text.Length && IsHexDigit(Text[Current])) { Current++; }
        }
        else
        {
            while (Current < Text.Length && char.IsDigit(Text[Current])) { Current++; }
            if (Current < Text.Length && Text[Current] == '.')
            {
                Current++;
                while (Current < Text.Length && char.IsDigit(Text[Current])) { Current++; }
            }
            if (Current < Text.Length && (Text[Current] == 'e' || Text[Current] == 'E'))
            {
                Current++;
                if (Current < Text.Length && (Text[Current] == '+' || Text[Current] == '-')) { Current++; }
                while (Current < Text.Length && char.IsDigit(Text[Current])) { Current++; }
            }
        }
        while (Current < Text.Length && (Text[Current] == 'f' || Text[Current] == 'F' || Text[Current] == 'd'
            || Text[Current] == 'D' || Text[Current] == 'm' || Text[Current] == 'M'
            || Text[Current] == 'l' || Text[Current] == 'L' || Text[Current] == 'u' || Text[Current] == 'U'))
        {
            Current++;
        }
        End = Current;
        Result.Append(DiffConstants.SpanOpenNumber).Append(WebUtility.HtmlEncode(Text[Position..End])).Append(DiffConstants.SpanClose);
        return true;
    }
    private static bool TryTokenizeWord(string Text, int Position, FrozenSet<string>? Keywords, bool IsSqlLike, StringBuilder Result, out int End)
    {
        End = Position;
        if (!char.IsLetter(Text[Position]) && Text[Position] != '_' && Text[Position] != '@') { return false; }
        var Current = Position;
        if (Text[Current] == '@') { Current++; }
        while (Current < Text.Length && (char.IsLetterOrDigit(Text[Current]) || Text[Current] == '_' || Text[Current] == '?')) { Current++; }
        End = Current;
        var Word = Text[Position..End];
        var LookupWord = IsSqlLike ? Word.ToUpperInvariant() : Word;
        if (Keywords is not null && Keywords.Contains(LookupWord))
        {
            Result.Append(DiffConstants.SpanOpenKeyword).Append(WebUtility.HtmlEncode(Word)).Append(DiffConstants.SpanClose);
        }
        else
        {
            Result.Append(WebUtility.HtmlEncode(Word));
        }
        return true;
    }
    private static bool TryTokenizeHtmlTag(string Text, int Position, string Language, StringBuilder Result, out int End)
    {
        End = Position;
        if (Language is not DiffConstants.LanguageHtml and not DiffConstants.LanguageXml) { return false; }
        if (Text[Position] != '<') { return false; }
        var CloseIndex = Text.IndexOf('>', Position + 1);
        if (CloseIndex < 0) { return false; }
        End = CloseIndex + 1;
        var TagContent = Text[(Position + 1)..CloseIndex];
        Result.Append(WebUtility.HtmlEncode(DiffConstants.HtmlLessThan))
            .Append(DiffConstants.SpanOpenTag)
            .Append(WebUtility.HtmlEncode(TagContent))
            .Append(DiffConstants.SpanClose)
            .Append(WebUtility.HtmlEncode(DiffConstants.HtmlGreaterThan));
        return true;
    }
    private static bool IsHexDigit(char Character) =>
        char.IsDigit(Character) || (Character >= 'a' && Character <= 'f') || (Character >= 'A' && Character <= 'F');
}
