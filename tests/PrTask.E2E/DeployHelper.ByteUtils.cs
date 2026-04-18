using System.Text;
namespace PrTask.E2E;
public static partial class DeployHelper
{
    private static byte[] ReplaceInBytes(byte[] Source, string Original, string Modified)
    {
        var Diff = FindReplacementPairs(Original, Modified);
        var Result = Source;
        foreach (var (OldStr, NewStr) in Diff)
        {
            var OldBytes = Encoding.UTF8.GetBytes(OldStr);
            var NewBytes = Encoding.UTF8.GetBytes(NewStr);
            Result = ByteReplace(Result, OldBytes, NewBytes);
        }

        return Result;
    }

    private static List<(string OldStr, string NewStr)> FindReplacementPairs(string Original, string Modified)
    {
        var Pairs = new List<(string OldStr, string NewStr)>();
        var OldLines = Original.Split('\n');
        var NewLines = Modified.Split('\n');
        for (var I = 0; I < OldLines.Length && I < NewLines.Length; I++)
        {
            if (OldLines[I] != NewLines[I])
            {
                var OldChars = OldLines[I].ToCharArray();
                var NewChars = NewLines[I].ToCharArray();
                var Start = 0;
                while (Start < OldChars.Length && Start < NewChars.Length && OldChars[Start] == NewChars[Start])
                {
                    Start++;
                }

                var OldEnd = OldChars.Length - 1;
                var NewEnd = NewChars.Length - 1;
                while (OldEnd > Start && NewEnd > Start && OldChars[OldEnd] == NewChars[NewEnd])
                {
                    OldEnd--;
                    NewEnd--;
                }

                Pairs.Add((new string(OldChars, Start, OldEnd - Start + 1), new string(NewChars, Start, NewEnd - Start + 1)));
            }
        }

        return Pairs;
    }

    private static byte[] ByteReplace(byte[] Source, byte[] Old, byte[] New)
    {
        var Result = new MemoryStream();
        var I = 0;
        while (I <= Source.Length - Old.Length)
        {
            if (Source.AsSpan(I, Old.Length).SequenceEqual(Old))
            {
                Result.Write(New);
                I += Old.Length;
            }
            else
            {
                Result.WriteByte(Source[I]);
                I++;
            }
        }

        while (I < Source.Length)
        {
            Result.WriteByte(Source[I]);
            I++;
        }

        return Result.ToArray();
    }
}
