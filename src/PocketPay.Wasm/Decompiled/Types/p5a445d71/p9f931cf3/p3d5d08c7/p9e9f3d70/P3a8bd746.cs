namespace WillowMaze.Wasm.Decompiled;

public class P3a8bd746 : PKIXRevocationChecker, Pd53d0176
{
    private static int F0246093c;
    private static int F23b46e1a;
    private static int F2415d57e;
    private static Dictionary<string, object> F4887374f;
    private static int F6afd7374;
    private static Dictionary<string, object> F9763d6ad;
    private static int F9e7f6c36;
    private static int Fbaff6152;
    private static int Fc2c50df4;
    private static int Fd413a7a9;
    private static Dictionary<string, object> Fd995a5f6;
    private readonly pa71bc741 F0aa38434;
    private pcb5fa6f0 F166e64f6;
    private pcb5fa6f0 F1bc797cc;
    private readonly pa71bc741 F334025b9;
    private pcb5fa6f0 F3e9d8094;
    private readonly pa71bc741 F4f3fe50c;
    private pcb5fa6f0 F6c9faee5;
    private readonly pb3b7fb02 F6f8e1c99;
    private readonly p205b5bac F81208e81;
    private readonly pa71bc741 Fbe1172c4;
    private readonly pa71bc741 Fca061839;
    private readonly p205b5bac Fcd8624f5;
    private readonly p205b5bac Fe1d7327d;
    private readonly p205b5bac Fe82dae43;
    private pcb5fa6f0 Ff723c12f;
    private readonly pb3b7fb02 Ffde5d67b;

    private bool M1d0c37b8(PKIXRevocationChecker$Option P0)
    {
        // call: p3a8bd746.getOptions
        // call: HashSet<object>.contains
        return false;
    }

    public void Check(Certificate P0, ICollection<object> P1)
    {
        // call: pa71bc741.check
        // call: p205b5bac.check
        // call: p3a8bd746.m1d0c37b8
        // call: X509Certificate.getBasicConstraints
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.f334025b9
        // field: java.security.cert.PKIXRevocationChecker$Option.PREFER_CRLS
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.fe1d7327d
        // field: java.security.cert.PKIXRevocationChecker$Option.NO_FALLBACK
        // field: java.security.cert.PKIXRevocationChecker$Option.ONLY_END_ENTITY
    }

    public List<object> GetSoftFailExceptions()
    {
        // call: pa71bc741.getSoftFailExceptions
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.f334025b9
        return default!;
    }

    public HashSet<object> GetSupportedExtensions()
    {
        return default!;
    }

    public void Init(bool P0)
    {
        // call: p205b5bac.init
        // call: pa71bc741.init
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.fe1d7327d
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.f334025b9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.f166e64f6
    }

    public void Initialize(pcb5fa6f0 P0)
    {
        // call: pa71bc741.initialize
        // call: p205b5bac.initialize
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.f334025b9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.f166e64f6
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a8bd746.fe1d7327d
    }

    public bool IsForwardCheckingSupported()
    {
        return false;
    }

    public void SetParameter(string P0, object P1)
    {
    }

}
