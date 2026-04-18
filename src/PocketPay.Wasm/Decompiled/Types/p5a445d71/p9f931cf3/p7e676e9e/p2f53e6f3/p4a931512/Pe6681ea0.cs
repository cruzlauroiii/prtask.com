namespace WillowMaze.Wasm.Decompiled;

public class Pe6681ea0
{
    private static void M2d5df9cc(p35e46fcb P0)
    {
        // str: "Optimized-sqrt sanity check failed"
        // call: object.equals
        // call: p5a196a0a.sqrt
        // call: pa827ecfa.fromBigInteger
        // call: string.toUpperCase
        // call: System.Numerics.BigInteger.valueOf
        // call: TextWriter.println
        // call: p5a196a0a.square
        // call: IllegalStateException.<init>
        // call: p5a196a0a.toBigInteger
        // call: System.Numerics.BigInteger.toString
        // call: p35e46fcb.getCurve
        // field: java.lang.System.out
        // type: IllegalStateException
    }

    public static void M5904c8bc(p35e46fcb P0)
    {
        // str: "Sqrt optimization only defined over characteristic-2 fields"
        // call: pe6681ea0.m2d5df9cc
        // call: p35e46fcb.getCurve
        // call: p8ede7675.m9758923d
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    private static List<object> Me6f6a01b(Enumeration P0)
    {
        // call: Enumeration.hasMoreElements
        // call: List<object>.<init>
        // call: Enumeration.nextElement
        // call: List<object>.add
        // type: List<object>
        return default!;
    }

    public static void Mfad58de7(string[] P0)
    {
        // str: ":"
        // call: StringBuilder.toString
        // call: HashSet<object>.<init>
        // call: SortedSet.addAll
        // call: p35e46fcb.getCurve
        // call: SortedSet.iterator
        // call: p46281eea.m03200c1c
        // call: p46281eea.mb83b9f17
        // call: StringBuilder.append
        // call: IEnumerator<object>.next
        // call: p8ede7675.m9758923d
        // call: IEnumerator<object>.hasNext
        // call: StringBuilder.<init>
        // call: TextWriter.print
        // call: pe6681ea0.m2d5df9cc
        // call: pe6681ea0.me6f6a01b
        // call: p625027bb.m03200c1c
        // call: p625027bb.mb83b9f17
        // field: java.lang.System.out
        // type: HashSet<object>
        // type: StringBuilder
    }

}
