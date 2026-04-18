namespace WillowMaze.Wasm.Decompiled;

public class P809ed339 : Pd1977c1b
{
    private readonly pe5cfc515 F1b8dde61;
    private bool F264a4dd3;
    private bool F39c7e2db;
    private readonly p240d858d F7aa19b8d;
    private readonly p240d858d F7eb67868;
    private readonly pe5cfc515 F9a98e4ab;
    private bool Fb1634446;
    private bool Fb9fadc79;
    private readonly p240d858d Fd3f0a038;

    public static void DZDpNsunmmjdLKJf(pe5cfc515 P0, byte P1)
    {
        // call: pe5cfc515.update
    }

    public static void ERDYlDxgAXZwSRap(pe5cfc515 P0)
    {
        // call: pe5cfc515.reset
    }

    public static int FairDHOmxjyLqQzC(pe5cfc515 P0, byte[] P1, int P2)
    {
        // call: pe5cfc515.doFinal
        return 0;
    }

    public static pc9ef6b45 NDBDIChyPuSFXEFq(p4715f007 P0)
    {
        // call: p4715f007.getParameters
        return default!;
    }

    public static void TlnGYvUvOOxaHSZA(p809ed339 P0)
    {
        // call: p809ed339.reset
    }

    public static void DLaKjacotCAXJEdI(p240d858d P0, bool P1, pc9ef6b45 P2)
    {
        // call: p240d858d.init
    }

    public static int DtyvHPTRhGgwKGwm(pe5cfc515 P0)
    {
        // call: pe5cfc515.getDigestSize
        return 0;
    }

    public static void IOIXqMDAcJtADofJ(pe5cfc515 P0, byte[] P1, int P2, int P3)
    {
        // call: pe5cfc515.update
    }

    public static byte[] LNEjBiCLKrrkEZzk(p240d858d P0, byte[] P1)
    {
        // call: p240d858d.generateSignature
        return default!;
    }

    public static bool MqhZRLpcKAOkFWle(pcfffbc4a P0)
    {
        // call: pcfffbc4a.isPrivate
        return false;
    }

    public static int UAXLkPVsnKspKqje(pe5cfc515 P0)
    {
        // call: pe5cfc515.getDigestSize
        return 0;
    }

    public static bool WwhSHlFeLSdnjyzd(pcfffbc4a P0)
    {
        // call: pcfffbc4a.isPrivate
        return false;
    }

    public static int ZTtrDLYrwkoILylo(pe5cfc515 P0, byte[] P1, int P2)
    {
        // call: pe5cfc515.doFinal
        return 0;
    }

    public static bool ZoBsHBRRkNuYJRmb(p240d858d P0, byte[] P1, byte[] P2)
    {
        // call: p240d858d.verifySignature
        return false;
    }

    public byte[] GenerateSignature()
    {
        // str: "DigestingMessageSigner not initialised for signature generation."
        // call: IllegalStateException.<init>
        // call: p809ed339.zTtrDLYrwkoILylo
        // call: p809ed339.lNEjBiCLKrrkEZzk
        // call: p809ed339.uAXLkPVsnKspKqje
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f39c7e2db
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f7aa19b8d
        // type: IllegalStateException
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "Signing Requires Private Key."
        // str: "Verification Requires Public Key."
        // call: p809ed339.NDBDIChyPuSFXEFq
        // call: IllegalArgumentException.<init>
        // call: p809ed339.TlnGYvUvOOxaHSZA
        // call: p809ed339.mqhZRLpcKAOkFWle
        // call: p809ed339.wwhSHlFeLSdnjyzd
        // call: p809ed339.dLaKjacotCAXJEdI
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f7aa19b8d
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f39c7e2db
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: p809ed339.ERDYlDxgAXZwSRap
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
    }

    public void Update(byte P0)
    {
        // call: p809ed339.DZDpNsunmmjdLKJf
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: p809ed339.iOIXqMDAcJtADofJ
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
    }

    public bool VerifySignature(byte[] P0)
    {
        // str: "DigestingMessageSigner not initialised for verification"
        // call: p809ed339.dtyvHPTRhGgwKGwm
        // call: p809ed339.FairDHOmxjyLqQzC
        // call: p809ed339.zoBsHBRRkNuYJRmb
        // call: IllegalStateException.<init>
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f7aa19b8d
        // field: p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339.f39c7e2db
        // type: IllegalStateException
        return false;
    }

}
