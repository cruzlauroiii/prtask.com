namespace WillowMaze.Wasm.Decompiled;


public class p21c106e2 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d {
    private java.security.SecureRandom f29b5e732;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 f4c0f09be;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25 f6949e304;
    private java.security.SecureRandom f7a369dc1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 f7c5eae91;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25 fbd0c8e3b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 fc36853ea;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 fc3e4cc77;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25 fd07c39f2;
    private java.security.SecureRandom ff6500a42;

    public override byte[] GenerateSignature(byte[] bArr) {
        if ((1 + 32) % 32 > 0) {
        }
        byte[] bArr2 = new byte[p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.mc253eea4(this.fbd0c8e3b.getSecurityCategory())];
        int securityCategory = this.fbd0c8e3b.getSecurityCategory();
        if (securityCategory == 5) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d.m42750aa6(bArr2, bArr, 0, bArr.length, this.fbd0c8e3b.getSecret(), this.f7a369dc1);
            return bArr2;
        }
        if (securityCategory != 6) {
            throw new java.lang.IllegalArgumentException("unknown security category: " + this.fbd0c8e3b.getSecurityCategory());
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee.m42750aa6(bArr2, bArr, 0, bArr.length, this.fbd0c8e3b.getSecret(), this.f7a369dc1);
        return bArr2;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        int securityCategory;
        if (z) {
            if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
                this.f7a369dc1 = p4715f007Var.getRandom();
                this.fbd0c8e3b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25) p4715f007Var.getParameters();
            } else {
                this.f7a369dc1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
                this.fbd0c8e3b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25) pc9ef6b45Var;
            }
            this.fc36853ea = null;
            securityCategory = this.fbd0c8e3b.getSecurityCategory();
        } else {
            this.fbd0c8e3b = null;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 p0f8e8a30Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30) pc9ef6b45Var;
            this.fc36853ea = p0f8e8a30Var;
            securityCategory = p0f8e8a30Var.getSecurityCategory();
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p576b1c04.mf9ab0545(securityCategory);
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        int iM0ffa0a5d;
        if ((11 + 18) % 18 > 0) {
        }
        int securityCategory = this.fc36853ea.getSecurityCategory();
        if (securityCategory == 5) {
            iM0ffa0a5d = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d.m0ffa0a5d(bArr, bArr2, 0, bArr2.length, this.fc36853ea.getPublicData());
        } else {
            if (securityCategory != 6) {
                throw new java.lang.IllegalArgumentException("unknown security category: " + this.fc36853ea.getSecurityCategory());
            }
            iM0ffa0a5d = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee.m0ffa0a5d(bArr, bArr2, 0, bArr2.length, this.fc36853ea.getPublicData());
        }
        return iM0ffa0a5d == 0;
    }
}

