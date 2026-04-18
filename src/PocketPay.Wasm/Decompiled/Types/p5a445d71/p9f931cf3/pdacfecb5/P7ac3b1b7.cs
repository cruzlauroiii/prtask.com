namespace WillowMaze.Wasm.Decompiled;

public class P7ac3b1b7 : P619bcd87
{
    private int F0c9999a0;
    private HashSet<object> F332fc9f6;
    private HashSet<object> F67374b26;
    private int F6f06bc87;
    private int F8686744d;
    private HashSet<object> Faac06314;
    private HashSet<object> Fb11ef25a;
    private HashSet<object> Fd354ac44;

    public static p619bcd87 M8bab0102(PKIXParameters P0)
    {
        // call: PKIXParameters.getTrustAnchors
        // call: PKIXParameters.getTargetCertConstraints
        // call: p27cbb5a8.m8bab0102
        // call: p7ac3b1b7.<init>
        // call: p7ac3b1b7.setParams
        // call: Exception.getMessage
        // call: Exception.<init>
        // type: p7ac3b1b7
        // type: Exception
        return default!;
    }

    public object Clone()
    {
        // call: p7ac3b1b7.getTrustAnchors
        // call: p7ac3b1b7.getTargetConstraints
        // call: p7ac3b1b7.<init>
        // call: Exception.<init>
        // call: Exception.getMessage
        // call: p7ac3b1b7.setParams
        // type: p7ac3b1b7
        // type: Exception
        return default!;
    }

    public HashSet<object> GetExcludedCerts()
    {
        // call: Collections.unmodifiableSet
        // field: p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7.f67374b26
        return default!;
    }

    public int GetMaxPathLength()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7.f0c9999a0
        return 0;
    }

    public void SetExcludedCerts(HashSet<object> P0)
    {
        // call: HashSet<object>.<init>
        // field: java.util.Collections.EMPTY_SET
        // field: p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7.f67374b26
        // type: HashSet<object>
    }

    public void SetMaxPathLength(int P0)
    {
        // str: "The maximum path length parameter can not be less than -1."
        // call: InvalidParameterException.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7.f0c9999a0
        // type: InvalidParameterException
    }

    private void SetParams(PKIXParameters P0)
    {
        // call: p619bcd87.setParams
        // call: PKIXBuilderParameters.getMaxPathLength
        // call: HashSet<object>.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7.f67374b26
        // field: p5a445d71.p9f931cf3.pdacfecb5.p7ac3b1b7.f0c9999a0
        // type: HashSet<object>
    }

}
