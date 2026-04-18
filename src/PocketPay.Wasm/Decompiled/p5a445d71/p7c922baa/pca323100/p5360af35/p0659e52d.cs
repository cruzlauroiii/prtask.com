namespace WillowMaze.Wasm.Decompiled;


public class p0659e52d : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f1b3b6bcb;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 f48ceacc1;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 f51531c1b;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f7618bd18;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f9eded579;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fbfe9f117;

    private p0659e52d(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.fbfe9f117 = tHdobJXtzHfDOtYh(mtmWvsYDSKJhsVuZ(p80f8c729Var, 0));
        this.f51531c1b = wLPyutRAVCJjmxxZ(PRQRckuOsJkusrue(p80f8c729Var, 1));
    }

    public p0659e52d(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr) {
        this.fbfe9f117 = p234a7530Var;
        this.f51531c1b = new p5a445d71.p7c922baa.pca323100.p6f0e511c(wXxYytOkPAmcPOZO(bArr));
    }

    public static byte[] ETTClbndUUvPjmIr(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 PRQRckuOsJkusrue(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 TWAnumuiCoqTmoOB(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void WqWfRjUbcKUbarEd(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void AfEyrBoXgCVWuTEx(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p5360af35.p0659e52d M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p5360af35.p0659e52d) {
            return (p5a445d71.p7c922baa.pca323100.p5360af35.p0659e52d) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p5360af35.p0659e52d(TWAnumuiCoqTmoOB(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MtmWvsYDSKJhsVuZ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] ONIOtqnRMkgzsyDN(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 THdobJXtzHfDOtYh(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 WLPyutRAVCJjmxxZ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static byte[] WXxYytOkPAmcPOZO(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetEncryptedKeyData() {
        return ETTClbndUUvPjmIr(oNIOtqnRMkgzsyDN(this.f51531c1b));
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetKeyEncryptionAlgorithm() {
        return this.fbfe9f117;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((3 + 18) % 18 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        WqWfRjUbcKUbarEd(pd6ccb7fcVar, this.fbfe9f117);
        afEyrBoXgCVWuTEx(pd6ccb7fcVar, this.f51531c1b);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

