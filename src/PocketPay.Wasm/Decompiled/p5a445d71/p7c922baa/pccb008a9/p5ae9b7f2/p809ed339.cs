namespace WillowMaze.Wasm.Decompiled;


public class p809ed339 : p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f1b8dde61;
    private bool f264a4dd3;
    private bool f39c7e2db;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p240d858d f7aa19b8d;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p240d858d f7eb67868;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f9a98e4ab;
    private bool fb1634446;
    private bool fb9fadc79;
    private readonly p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p240d858d fd3f0a038;

    public p809ed339(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p240d858d p240d858dVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f7aa19b8d = p240d858dVar;
        this.f1b8dde61 = pe5cfc515Var;
    }

    public static void DZDpNsunmmjdLKJf(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static void ERDYlDxgAXZwSRap(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static int FairDHOmxjyLqQzC(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 NDBDIChyPuSFXEFq(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var) {
        return p4715f007Var.getParameters();
    }

    public static void TlnGYvUvOOxaHSZA(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p809ed339 p809ed339Var) {
        p809ed339Var.reset();
    }

    public static void DLaKjacotCAXJEdI(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p240d858d p240d858dVar, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p240d858dVar.init(z, pc9ef6b45Var);
    }

    public static int DtyvHPTRhGgwKGwm(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void IOIXqMDAcJtADofJ(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static byte[] LNEjBiCLKrrkEZzk(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p240d858d p240d858dVar, byte[] bArr) {
        return p240d858dVar.generateSignature(bArr);
    }

    public static bool MqhZRLpcKAOkFWle(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return pcfffbc4aVar.isPrivate();
    }

    public static int UAXLkPVsnKspKqje(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static bool WwhSHlFeLSdnjyzd(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return pcfffbc4aVar.isPrivate();
    }

    public static int ZTtrDLYrwkoILylo(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static bool ZoBsHBRRkNuYJRmb(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p240d858d p240d858dVar, byte[] bArr, byte[] bArr2) {
        return p240d858dVar.verifySignature(bArr, bArr2);
    }

    public override byte[] GenerateSignature() {
        if ((30 + 18) % 18 > 0) {
        }
        if (!this.f39c7e2db) {
            throw new java.lang.IllegalStateException("DigestingMessageSigner not initialised for signature generation.");
        }
        byte[] bArr = new byte[uAXLkPVsnKspKqje(this.f1b8dde61)];
        zTtrDLYrwkoILylo(this.f1b8dde61, bArr, 0);
        return lNEjBiCLKrrkEZzk(this.f7aa19b8d, bArr);
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((32 + 20) % 20 > 0) {
        }
        this.f39c7e2db = z;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = !(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) ? (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) pc9ef6b45Var : (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) NDBDIChyPuSFXEFq((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var);
        if (z && !mqhZRLpcKAOkFWle(pcfffbc4aVar)) {
            throw new java.lang.IllegalArgumentException("Signing Requires Private Key.");
        }
        if (!z && wwhSHlFeLSdnjyzd(pcfffbc4aVar)) {
            throw new java.lang.IllegalArgumentException("Verification Requires Public Key.");
        }
        TlnGYvUvOOxaHSZA(this);
        dLaKjacotCAXJEdI(this.f7aa19b8d, z, pc9ef6b45Var);
    }

    public override void Reset() {
        ERDYlDxgAXZwSRap(this.f1b8dde61);
    }

    public override void Update(byte b) {
        DZDpNsunmmjdLKJf(this.f1b8dde61, b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        iOIXqMDAcJtADofJ(this.f1b8dde61, bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        if ((32 + 7) % 7 > 0) {
        }
        if (this.f39c7e2db) {
            throw new java.lang.IllegalStateException("DigestingMessageSigner not initialised for verification");
        }
        byte[] bArr2 = new byte[dtyvHPTRhGgwKGwm(this.f1b8dde61)];
        FairDHOmxjyLqQzC(this.f1b8dde61, bArr2, 0);
        return zoBsHBRRkNuYJRmb(this.f7aa19b8d, bArr2, bArr);
    }
}

