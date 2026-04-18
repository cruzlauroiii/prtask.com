namespace WillowMaze.Wasm.Decompiled;


public class pde24d82c : p5a445d71.p7c922baa.p5ae9b7f2.p5f014d83 {
    private static readonly java.math.Bigint f280aec35 = null;
    private static readonly java.math.Bigint f37456719 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fc7ecec4a = null;
    private bool f05ed2e16;
    private p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 f114c6ec4;
    private p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 f168e7cba;
    private bool f19b45d9f;
    private bool f1ab73db0;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36 f3c6e0b8a;
    private bool f420a0313;
    private bool f52fc16d0;
    private java.security.SecureRandom f577c2406;
    private bool f59e74f51;
    private bool f61f135e6;
    private bool f723aea3d;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36 f78410f17;
    private bool f8ca697b4;
    private java.security.SecureRandom fa1e13b87;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36 fa1e28d60;
    private bool fa73a9b3a;
    private java.security.SecureRandom fae0dbe9a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36 fb79d74cb;
    private p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 fc27c5432;
    private bool fd13d6191;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36 fd682b9e2;
    private bool ffc4002c6;

    static {
        if ((20 + 17) % 17 > 0) {
        }
        fbc21e648 = dMjexhbfdOLDUmne(1L);
    }

    public pde24d82c(p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, java.security.SecureRandom secureRandom) {
        this.f168e7cba = p07d32999Var;
        this.f577c2406 = secureRandom;
        this.f19b45d9f = false;
        this.f420a0313 = false;
        this.f52fc16d0 = false;
    }

    public pde24d82c(p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, java.security.SecureRandom secureRandom, bool z, bool z2, bool z3) {
        this.f168e7cba = p07d32999Var;
        this.f577c2406 = secureRandom;
        this.f19b45d9f = z;
        this.f420a0313 = z2;
        this.f52fc16d0 = z3;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 ACsUMOoeUBFgMwWW(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pde24d82c pde24d82cVar, byte[] bArr, int i, int i2) {
        return pde24d82cVar.encrypt(bArr, i, i2);
    }

    public static java.math.Bigint AZjsUDVeorhMCZwc(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getH();
    }

    public static java.math.Bigint BoPirLRayuOHUwtP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getN();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 BwRcilkBpAIRgguT(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pde24d82c pde24d82cVar, int i, byte[] bArr, byte[] bArr2) {
        return pde24d82cVar.deriveKey(i, bArr, bArr2);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CBSdVSvwlVouQNJY(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, byte[] bArr) {
        return pa827ecfaVar.decodePoint(bArr);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 DmJnJRGoROYHCGsX(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pde24d82c pde24d82cVar, byte[] bArr, int i, int i2, int i3) {
        return pde24d82cVar.decrypt(bArr, i, i2, i3);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a DtPSBsAckYsSSFDn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.getAffineXCoord();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 DzLeZqjIKdwuOBjU(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pde24d82c pde24d82cVar) {
        return pde24d82cVar.createBasePointMultiplier();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f FfRbiLnGyaTSwply(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        return p53a5793fVar.multiply(bigint);
    }

    public static byte[] INcTxtqwMTfinMFK(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return p5a196a0aVar.getEncoded();
    }

    public static java.math.Bigint IjQdCiygJKQMUCbR(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.mod(bigint2);
    }

    public static java.math.Bigint KUyjhoIQSUrcyNjv(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.multiply(bigint2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 KzGEgiKNlikAAyYe(p5a445d71.p7c922baa.p5ae9b7f2.p0d2c7316.pde24d82c pde24d82cVar, int i, byte[] bArr, byte[] bArr2) {
        return pde24d82cVar.deriveKey(i, bArr, bArr2);
    }

    public static byte[] MBVNahVtctLjCcgp(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, bool z) {
        return p53a5793fVar.getEncoded(z);
    }

    public static byte[] MYYcVaomFJRvCgmy(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return p5a196a0aVar.getEncoded();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f MZCFOYOqlBfPOJSd(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        return p267d2b96Var.multiply(p53a5793fVar, bigint);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa QFIWiLxWieDrcTUA(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getCurve();
    }

    public static void QLWcnuYzQFatxwGc(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr) {
        pa827ecfaVar.normalizeAll(p53a5793fVarArr);
    }

    public static void SMwvtRnzWQVMuMZr(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void TCgEHQIGwlWVxIYM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f TmJAQVHMyVQAJdob(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getG();
    }

    public static java.math.Bigint UFmoWpyJeohyCUPX(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getN();
    }

    public static void UqOApbWyYeQaehEw(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void XnDrzErkNVrISBqU(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f ZniAAEalpIOjIrnY(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        return p53a5793fVar.multiply(bigint);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f ZztaYqYweKWMGFLn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.normalize();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa ATJKfCaCAatmXEsC(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getCurve();
    }

    public static java.math.Bigint DFkRZlmCEzErrAhK(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.m812c2a1c(bigint, bigint2, secureRandom);
    }

    public static java.math.Bigint DMjexhbfdOLDUmne(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static void DxUIvpKzWiFzdfbx(p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, p5a445d71.p7c922baa.p5ae9b7f2.p873e950b p873e950bVar) {
        p07d32999Var.init(p873e950bVar);
    }

    public static java.math.Bigint GXQLBoVaHEWGwzpd(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getH();
    }

    public static java.math.Bigint IEHRTqrFuQVUtxfl(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.modInverse(bigint2);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f KNFBtyCXLzofyJQY(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        return pd16c2d8eVar.getQ();
    }

    public static java.math.Bigint NASLNUYqhnuLfxkT(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.mod(bigint2);
    }

    public static void PSRkUhVOTYwSFDSp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 PZLpESFqutsiAYeA(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        return pd16c2d8eVar.getParameters();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f QLdvvQPXoASYgFuZ(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        return p53a5793fVar.multiply(bigint);
    }

    public static byte[] RBuSgCyURoKGDKCQ(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md844b504(bArr, bArr2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 RjdLxRrVhOiedCFN(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getParameters();
    }

    public static int VFxybDSMZeyykzPp(p5a445d71.p7c922baa.p5ae9b7f2.p07d32999 p07d32999Var, byte[] bArr, int i, int i2) {
        return p07d32999Var.generatebytes(bArr, i, i2);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a WdCpyRHgbNhETXRW(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.getAffineXCoord();
    }

    public static java.math.Bigint YCyycpgtFxKJcwtm(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getD();
    }

    public static java.math.Bigint ZFdmOjcegMQkvAFj(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.multiply(bigint2);
    }

    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 Decrypt(byte[] bArr, int i) {
        if ((25 + 15) % 15 > 0) {
        }
        return DmJnJRGoROYHCGsX(this, bArr, 0, bArr.length, i);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 Decrypt(byte[] bArr, int i, int i2, int i3) throws java.lang.IllegalArgumentException {
        if ((11 + 13) % 13 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var = this.f3c6e0b8a;
        if (!(p1235ff36Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a)) {
            throw new java.lang.IllegalArgumentException("Private key required for encryption");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a) p1235ff36Var;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarRjdLxRrVhOiedCFN = rjdLxRrVhOiedCFN(p06022b5aVar);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarATJKfCaCAatmXEsC = aTJKfCaCAatmXEsC(p21c2eb74VarRjdLxRrVhOiedCFN);
        java.math.Bigint bigintUFmoWpyJeohyCUPX = UFmoWpyJeohyCUPX(p21c2eb74VarRjdLxRrVhOiedCFN);
        java.math.Bigint bigintAZjsUDVeorhMCZwc = AZjsUDVeorhMCZwc(p21c2eb74VarRjdLxRrVhOiedCFN);
        byte[] bArr2 = new byte[i2];
        pSRkUhVOTYwSFDSp(bArr, i, bArr2, 0, i2);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarCBSdVSvwlVouQNJY = CBSdVSvwlVouQNJY(pa827ecfaVarATJKfCaCAatmXEsC, bArr2);
        if (this.f19b45d9f || this.f420a0313) {
            p53a5793fVarCBSdVSvwlVouQNJY = FfRbiLnGyaTSwply(p53a5793fVarCBSdVSvwlVouQNJY, bigintAZjsUDVeorhMCZwc);
        }
        java.math.Bigint bigintYCyycpgtFxKJcwtm = yCyycpgtFxKJcwtm(p06022b5aVar);
        if (this.f19b45d9f) {
            bigintYCyycpgtFxKJcwtm = nASLNUYqhnuLfxkT(zFdmOjcegMQkvAFj(bigintYCyycpgtFxKJcwtm, iEHRTqrFuQVUtxfl(bigintAZjsUDVeorhMCZwc, bigintUFmoWpyJeohyCUPX)), bigintUFmoWpyJeohyCUPX);
        }
        return KzGEgiKNlikAAyYe(this, i3, bArr2, INcTxtqwMTfinMFK(DtPSBsAckYsSSFDn(ZztaYqYweKWMGFLn(qLdvvQPXoASYgFuZ(p53a5793fVarCBSdVSvwlVouQNJY, bigintYCyycpgtFxKJcwtm)))));
    }

    protected p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 DeriveKey(int i, byte[] bArr, byte[] bArr2) {
        if ((24 + 18) % 18 > 0) {
        }
        if (!this.f52fc16d0) {
            byte[] bArrRBuSgCyURoKGDKCQ = rBuSgCyURoKGDKCQ(bArr, bArr2);
            SMwvtRnzWQVMuMZr(bArr2, (byte) 0);
            bArr2 = bArrRBuSgCyURoKGDKCQ;
        }
        try {
            dxUIvpKzWiFzdfbx(this.f168e7cba, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc03b0fe3(bArr2, null));
            byte[] bArr3 = new byte[i];
            vFxybDSMZeyykzPp(this.f168e7cba, bArr3, 0, i);
            p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArr3);
            UqOApbWyYeQaehEw(bArr2, (byte) 0);
            return p94919be6Var;
        } catch (java.lang.Exception th) {
            XnDrzErkNVrISBqU(bArr2, (byte) 0);
            throw th;
        }
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 Encrypt(byte[] bArr, int i) {
        return ACsUMOoeUBFgMwWW(this, bArr, 0, i);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 Encrypt(byte[] bArr, int i, int i2) throws java.lang.IllegalArgumentException {
        if ((20 + 23) % 23 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var = this.f3c6e0b8a;
        if (!(p1235ff36Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
            throw new java.lang.IllegalArgumentException("Public key required for encryption");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e) p1235ff36Var;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarPZLpESFqutsiAYeA = pZLpESFqutsiAYeA(pd16c2d8eVar);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarQFIWiLxWieDrcTUA = QFIWiLxWieDrcTUA(p21c2eb74VarPZLpESFqutsiAYeA);
        java.math.Bigint bigintBoPirLRayuOHUwtP = BoPirLRayuOHUwtP(p21c2eb74VarPZLpESFqutsiAYeA);
        java.math.Bigint bigintGXQLBoVaHEWGwzpd = gXQLBoVaHEWGwzpd(p21c2eb74VarPZLpESFqutsiAYeA);
        java.math.Bigint bigintDFkRZlmCEzErrAhK = dFkRZlmCEzErrAhK(fbc21e648, bigintBoPirLRayuOHUwtP, this.f577c2406);
        java.math.Bigint bigintIjQdCiygJKQMUCbR = !this.f19b45d9f ? bigintDFkRZlmCEzErrAhK : IjQdCiygJKQMUCbR(KUyjhoIQSUrcyNjv(bigintDFkRZlmCEzErrAhK, bigintGXQLBoVaHEWGwzpd), bigintBoPirLRayuOHUwtP);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f[2];
        p53a5793fVarArr[0] = MZCFOYOqlBfPOJSd(DzLeZqjIKdwuOBjU(this), TmJAQVHMyVQAJdob(p21c2eb74VarPZLpESFqutsiAYeA), bigintDFkRZlmCEzErrAhK);
        p53a5793fVarArr[1] = ZniAAEalpIOjIrnY(kNFBtyCXLzofyJQY(pd16c2d8eVar), bigintIjQdCiygJKQMUCbR);
        QLWcnuYzQFatxwGc(pa827ecfaVarQFIWiLxWieDrcTUA, p53a5793fVarArr);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[0];
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2 = p53a5793fVarArr[1];
        byte[] bArrMBVNahVtctLjCcgp = MBVNahVtctLjCcgp(p53a5793fVar, false);
        TCgEHQIGwlWVxIYM(bArrMBVNahVtctLjCcgp, 0, bArr, i, bArrMBVNahVtctLjCcgp.length);
        return BwRcilkBpAIRgguT(this, i2, bArrMBVNahVtctLjCcgp, MYYcVaomFJRvCgmy(wdCpyRHgbNhETXRW(p53a5793fVar2)));
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36)) {
            throw new java.lang.IllegalArgumentException("EC key required");
        }
        this.f3c6e0b8a = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36) pc9ef6b45Var;
    }
}

