namespace WillowMaze.Wasm.Decompiled;

public class P906ea63f : Pb9ab1283
{
    public void Validate(string P0)
    {
        // str: "value"
        // call: Intrinsics.checkNotNullParameter
        // call: CharSequence.charAt
        // call: StringsKt.trim
        // call: StringBuilder.<init>
        // call: char.isDigit
        // call: CharSequence.length
        // call: object.toString
        // call: Appendable.append
        // type: StringBuilder
    }

    public void Validate(string P0, int P1)
    {
        // str: "value"
        // call: Matcher.matches
        // call: p6befdea9.<init>
        // call: System.Text.RegularExpressions.Regex.matcher
        // call: Intrinsics.checkNotNullParameter
        // call: string.length
        // field: android.util.Patterns.PHONE
        // type: p6befdea9
    }

}
