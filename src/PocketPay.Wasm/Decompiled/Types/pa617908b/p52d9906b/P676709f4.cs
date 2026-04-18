namespace WillowMaze.Wasm.Decompiled;

public class P676709f4 : P3cfc9edc
{
    public void ValidatePattern(string P0)
    {
        // str: "password"
        // str: "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=\\S+$).{8,}"
        // call: pf2b9c58e.<init>
        // call: System.Text.RegularExpressions.Regex.compile
        // call: Intrinsics.checkNotNullParameter
        // call: System.Text.RegularExpressions.Regex.matcher
        // call: Matcher.matches
        // type: pf2b9c58e
    }

    public void ValidateRepeat(string P0, string P1)
    {
        // str: "repeatedPassword"
        // str: "password"
        // call: Intrinsics.checkNotNullParameter
        // call: pe596bc9b.<init>
        // call: Intrinsics.areEqual
        // type: pe596bc9b
    }

}
