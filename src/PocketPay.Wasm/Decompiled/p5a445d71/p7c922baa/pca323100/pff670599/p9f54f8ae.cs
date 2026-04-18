namespace WillowMaze.Wasm.Decompiled;


public class p9f54f8ae : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p11b04310 f32806cd8;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f63f452ed;
    private p5a445d71.p7c922baa.pca323100.p11b04310 fa1062315;
    private p5a445d71.p7c922baa.pca323100.p11b04310 fabc0c0c7;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fb05d30eb;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fc081ab8f;
    private p5a445d71.p7c922baa.pca323100.p11b04310 ff0b53b2d;
    private p5a445d71.p7c922baa.pca323100.p11b04310 ff305f5e3;

    public p9f54f8ae(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationTpFSddvxCrukRbmZ = TpFSddvxCrukRbmZ(p80f8c729Var);
        this.ff0b53b2d = (p5a445d71.p7c922baa.pca323100.p11b04310) NOXdesdnsIoTIbFs(enumerationTpFSddvxCrukRbmZ);
        this.fb05d30eb = (p5a445d71.p7c922baa.pca323100.p364bf33a) BCguNXHtPnWRwUuu(enumerationTpFSddvxCrukRbmZ);
    }

    public p9f54f8ae(byte[] bArr, p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar) {
        this.ff0b53b2d = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
        this.fb05d30eb = p364bf33aVar;
    }

    public static java.lang.object BCguNXHtPnWRwUuu(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.object NOXdesdnsIoTIbFs(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 PfnznjbdFTLKpcbR(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pff670599.p9f54f8ae PnUjubZbiaZxZygg(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.util.Enumeration TpFSddvxCrukRbmZ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static void YqfyXziYilEDBzEd(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void FgQyjEyOTJQtOGEB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] FglXMMsUNlwdkfsQ(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] IszUYKGJCHxgEGTc(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 LwFTSJJKVKZxtULP(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.pff670599.p9f54f8ae M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pff670599.p9f54f8ae) {
            return (p5a445d71.p7c922baa.pca323100.pff670599.p9f54f8ae) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pff670599.p9f54f8ae(PfnznjbdFTLKpcbR(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pff670599.p9f54f8ae M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return PnUjubZbiaZxZygg(lwFTSJJKVKZxtULP(p582a4948Var, z));
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetEncryptionParamHashSet() {
        return this.fb05d30eb;
    }

    public byte[] GetIV() {
        return fglXMMsUNlwdkfsQ(iszUYKGJCHxgEGTc(this.ff0b53b2d));
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((11 + 26) % 26 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        fgQyjEyOTJQtOGEB(pd6ccb7fcVar, this.ff0b53b2d);
        YqfyXziYilEDBzEd(pd6ccb7fcVar, this.fb05d30eb);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

