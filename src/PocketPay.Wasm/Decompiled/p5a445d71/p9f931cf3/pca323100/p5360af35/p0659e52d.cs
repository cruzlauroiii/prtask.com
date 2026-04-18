namespace WillowMaze.Wasm.Decompiled;


public class p0659e52d : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f2fa9390a;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f51531c1b;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f5a5dfe4b;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f71bac74c;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f7fb7e482;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f9def4429;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fbfe9f117;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 fec1b43ee;

    private p0659e52d(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.fbfe9f117 = RwznfQxxfvqZJqWe(iCIFtYEnqswzpByb(p80f8c729Var, 0));
        this.f51531c1b = EvKsjOifpOPlagZb(LRsWqawmEofPGADh(p80f8c729Var, 1));
    }

    public p0659e52d(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr) {
        this.fbfe9f117 = p234a7530Var;
        this.f51531c1b = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(OBNRXzWcyqsTYsIY(bArr));
    }

    public static void BwaszOuYTDoMJiqy(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] DQFpiicLZmTHzYck(p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static byte[] DasWjnuqxoqNBaMp(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 EvKsjOifpOPlagZb(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 LRsWqawmEofPGADh(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] OBNRXzWcyqsTYsIY(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 RwznfQxxfvqZJqWe(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 HVoRfeotujmjEVqi(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ICIFtYEnqswzpByb(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void IxjfWGMUZEYCmKei(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p5360af35.p0659e52d M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p5360af35.p0659e52d) {
            return (p5a445d71.p9f931cf3.pca323100.p5360af35.p0659e52d) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p5360af35.p0659e52d(hVoRfeotujmjEVqi(obj));
    }

    public byte[] GetEncryptedKeyData() {
        return DasWjnuqxoqNBaMp(DQFpiicLZmTHzYck(this.f51531c1b));
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetKeyEncryptionAlgorithm() {
        return this.fbfe9f117;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((28 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        BwaszOuYTDoMJiqy(pd6ccb7fcVar, this.fbfe9f117);
        ixjfWGMUZEYCmKei(pd6ccb7fcVar, this.f51531c1b);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

