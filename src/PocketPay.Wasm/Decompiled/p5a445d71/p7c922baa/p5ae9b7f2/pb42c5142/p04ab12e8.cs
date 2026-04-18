namespace WillowMaze.Wasm.Decompiled;


public class p04ab12e8 : p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f07267213;
    private bool f1fd2f420;
    private bool f39c7e2db;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f5ea073cd;
    private bool f712fc2e6;
    private bool f7ebaec82;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe fad1943a9;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fb30e2501;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fda5a4626;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe fe6319370;

    public p04ab12e8(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fad1943a9 = p42a46bbeVar;
        this.fc10f7796 = pe5cfc515Var;
    }

    public static bool FqRPURDzUZftptBU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return pcfffbc4aVar.isPrivate();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 KQtPhxciDSAtxAal(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var) {
        return p4715f007Var.getParameters();
    }

    public static void NeChamnqqGAXdMvA(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static byte[] OsjftIiADREetWMH(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr, int i, int i2) {
        return p42a46bbeVar.processBlock(bArr, i, i2);
    }

    public static byte[] QYOuzCJUVJHhfxaf(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr, int i, int i2) {
        return p42a46bbeVar.processBlock(bArr, i, i2);
    }

    public static void ZFdlaTCGmWXMuUoQ(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static void CrhFqaNkJhHbVVBX(p5a445d71.p7c922baa.p5ae9b7f2.pb42c5142.p04ab12e8 p04ab12e8Var) {
        p04ab12e8Var.reset();
    }

    public static void DDBDjjZqAxiMMDOT(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p42a46bbeVar.init(z, pc9ef6b45Var);
    }

    public static bool DlOPbWusRZfUvrlP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return pcfffbc4aVar.isPrivate();
    }

    public static int EbnylFtpGUqfqWKF(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int FVrOsPTdpFZxBBlP(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void KyhnedstyzWMmMTv(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte b) {
        pe5cfc515Var.update(b);
    }

    public static bool SFZyXWglZshFftLZ(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m66e765de(bArr, bArr2);
    }

    public static int YAFluObnTSNiDldk(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int ZMfylUYeBynCJTKM(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static void ZbzmkzlhnfFahfux(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public override byte[] GenerateSignature() throws p5a445d71.p7c922baa.p5ae9b7f2.p48d8e57f, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((7 + 24) % 24 > 0) {
        }
        if (!this.f39c7e2db) {
            throw new java.lang.IllegalStateException("GenericSigner not initialised for signature generation.");
        }
        int iZMfylUYeBynCJTKM = zMfylUYeBynCJTKM(this.fc10f7796);
        byte[] bArr = new byte[iZMfylUYeBynCJTKM];
        ebnylFtpGUqfqWKF(this.fc10f7796, bArr, 0);
        return QYOuzCJUVJHhfxaf(this.fad1943a9, bArr, 0, iZMfylUYeBynCJTKM);
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((20 + 6) % 6 > 0) {
        }
        this.f39c7e2db = z;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = !(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) ? (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) pc9ef6b45Var : (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) KQtPhxciDSAtxAal((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var);
        if (z && !FqRPURDzUZftptBU(pcfffbc4aVar)) {
            throw new java.lang.IllegalArgumentException("signing requires private key");
        }
        if (!z && dlOPbWusRZfUvrlP(pcfffbc4aVar)) {
            throw new java.lang.IllegalArgumentException("verification requires public key");
        }
        crhFqaNkJhHbVVBX(this);
        dDBDjjZqAxiMMDOT(this.fad1943a9, z, pc9ef6b45Var);
    }

    public override void Reset() {
        ZFdlaTCGmWXMuUoQ(this.fc10f7796);
    }

    public override void Update(byte b) {
        kyhnedstyzWMmMTv(this.fc10f7796, b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        NeChamnqqGAXdMvA(this.fc10f7796, bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        if ((8 + 31) % 31 > 0) {
        }
        if (this.f39c7e2db) {
            throw new java.lang.IllegalStateException("GenericSigner not initialised for verification");
        }
        int iFVrOsPTdpFZxBBlP = fVrOsPTdpFZxBBlP(this.fc10f7796);
        byte[] bArr2 = new byte[iFVrOsPTdpFZxBBlP];
        yAFluObnTSNiDldk(this.fc10f7796, bArr2, 0);
        try {
            byte[] bArrOsjftIiADREetWMH = OsjftIiADREetWMH(this.fad1943a9, bArr, 0, bArr.length);
            if (bArrOsjftIiADREetWMH.length < iFVrOsPTdpFZxBBlP) {
                byte[] bArr3 = new byte[iFVrOsPTdpFZxBBlP];
                zbzmkzlhnfFahfux(bArrOsjftIiADREetWMH, 0, bArr3, iFVrOsPTdpFZxBBlP - bArrOsjftIiADREetWMH.length, bArrOsjftIiADREetWMH.length);
                bArrOsjftIiADREetWMH = bArr3;
            }
            return sFZyXWglZshFftLZ(bArrOsjftIiADREetWMH, bArr2);
        } catch (java.lang.Exception unused) {
            return false;
        }
    }
}

