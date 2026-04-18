namespace WillowMaze.Wasm.Decompiled;

public class P883d7615_p910eef8c
{
    private void M3d5ae189(string P0, string P1)
    {
        // str: ": "
        // str: "Unexpected char %#04x at %d in %s value"
        // str: ""
        // call: p23e8a4b4.isSensitiveHeader
        // call: Intrinsics.stringPlus
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: p23e8a4b4.format
        // call: int.valueOf
        // call: string.charAt
        // call: string.length
        // type: IllegalArgumentException
    }

    public static void M87c01aa1(p883d7615$p910eef8c P0, string P1)
    {
        // call: p883d7615$p910eef8c.mcc26dbde
    }

    public static string M916f98a9(p883d7615$p910eef8c P0, string[] P1, string P2)
    {
        // call: p883d7615$p910eef8c.mb5eda0a7
        return string.Empty;
    }

    private string Mb5eda0a7(string[] P0, string P1)
    {
        // call: StringsKt.equals
        // call: ProgressionUtilKt.getProgressionLastElement
        return string.Empty;
    }

    private void Mcc26dbde(string P0)
    {
        // str: "name is empty"
        // str: "Unexpected char %#04x at %d in header name: %s"
        // call: p23e8a4b4.format
        // call: IllegalArgumentException.<init>
        // call: string.length
        // call: CharSequence.length
        // call: int.valueOf
        // call: string.charAt
        // call: object.toString
        // type: IllegalArgumentException
    }

    public static void Me2e17271(p883d7615$p910eef8c P0, string P1, string P2)
    {
        // call: p883d7615$p910eef8c.m3d5ae189
    }

    public p883d7615 -deprecated_of(Dictionary<string, object> P0)
    {
        // str: "headers"
        // call: Intrinsics.checkNotNullParameter
        // call: p883d7615$p910eef8c.of
        return default!;
    }

    public p883d7615 -deprecated_of(string[] P0)
    {
        // str: "namesAndValues"
        // call: Arrays.copyOf
        // call: p883d7615$p910eef8c.of
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public p883d7615 Of(Dictionary<string, object> P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.next
        // call: object.toString
        // call: p883d7615$p910eef8c.mcc26dbde
        // call: StringsKt.trim
        // call: HashSet<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: p883d7615.<init>
        // call: Map$Entry.getValue
        // call: p883d7615$p910eef8c.m3d5ae189
        // call: Map$Entry.getKey
        // call: Dictionary<string, object>.entrySet
        // call: Dictionary<string, object>.size
        // type: p883d7615
        return default!;
    }

    public p883d7615 Of(string[] P0)
    {
        // str: "Expected alternating header names and values"
        // str: "Headers cannot be null"
        // str: "namesAndValues"
        // call: Intrinsics.checkNotNullParameter
        // call: ProgressionUtilKt.getProgressionLastElement
        // call: IllegalArgumentException.<init>
        // call: object.clone
        // call: object.toString
        // call: p883d7615.<init>
        // call: p883d7615$p910eef8c.m3d5ae189
        // call: StringsKt.trim
        // call: p883d7615$p910eef8c.mcc26dbde
        // type: IllegalArgumentException
        // type: p883d7615
        return default!;
    }

}
