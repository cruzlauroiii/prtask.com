namespace WillowMaze.Wasm.Decompiled;

public class P9fc2d28c
{
    private static ThreadLocal F0004b46f;
    private static ThreadLocal F1b993fe0;
    private static ThreadLocal F3b491eba;
    private static ThreadLocal Fa995f9c9;

    private static string M0e75c301(string P0)
    {
        // call: p9fc2d28c$1.<init>
        // call: AccessController.doPrivileged
        // type: p9fc2d28c$1
        return string.Empty;
    }

    public static HashSet<object> M3fd154a7(string P0)
    {
        // str: "777c565b8580acbabdba7bc1761c085c5ffeee248874cd4dd1e90ef796"
        // call: HashSet<object>.add
        // call: StringTokenizer.nextToken
        // call: HashSet<object>.<init>
        // call: Collections.unmodifiableSet
        // call: p89be9433.m84b7c84e
        // call: StringTokenizer.<init>
        // call: p9fc2d28c.m0e75c301
        // call: DecryptString.decryptString
        // call: string.trim
        // call: StringTokenizer.hasMoreElements
        // type: StringTokenizer
        // type: HashSet<object>
        return default!;
    }

    public static System.Numerics.BigInteger M4a2b7392(string P0)
    {
        // call: p9fc2d28c.m0e75c301
        // call: System.Numerics.BigInteger.<init>
        // type: System.Numerics.BigInteger
        return default!;
    }

    public static bool Mb19ca41c(string P0, bool P1)
    {
        // str: "false"
        // str: "true"
        // call: ThreadLocal.set
        // call: ThreadLocal.get
        // call: Dictionary<string, object>.<init>
        // call: Dictionary<string, object>.put
        // call: p9fc2d28c.mf2b2f421
        // field: p5a445d71.p7c922baa.p05c7e247.p9fc2d28c.fa995f9c9
        // type: Dictionary<string, object>
        return false;
    }

    public static bool Mcabe45cb(string P0)
    {
        // call: Dictionary<string, object>.isEmpty
        // call: p9fc2d28c.mf2b2f421
        // call: Dictionary<string, object>.remove
        // call: ThreadLocal.remove
        // call: ThreadLocal.get
        // call: ThreadLocal.set
        // field: p5a445d71.p7c922baa.p05c7e247.p9fc2d28c.fa995f9c9
        return false;
    }

    private static ThreadLocal Mf23e8626()
    {
        // field: p5a445d71.p7c922baa.p05c7e247.p9fc2d28c.fa995f9c9
        return default!;
    }

    public static bool Mf2b2f421(string P0)
    {
        // str: "true"
        // call: p9fc2d28c.m0e75c301
        // call: p89be9433.m84b7c84e
        // call: string.equals
        return false;
    }

}
