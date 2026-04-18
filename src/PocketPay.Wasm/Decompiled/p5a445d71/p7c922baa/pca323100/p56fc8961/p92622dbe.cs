namespace WillowMaze.Wasm.Decompiled;


public class p92622dbe : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p11b04310 f5e13bebd;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f76d1ec5c;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f7e017ad6;
    private p5a445d71.p7c922baa.pca323100.p11b04310 f81b71d08;
    private p5a445d71.p7c922baa.pca323100.p11b04310 f852341d5;
    private p5a445d71.p7c922baa.pca323100.p11b04310 f8d777f38;
    private p5a445d71.p7c922baa.pca323100.p11b04310 fd0802d34;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 ff8017daf;

    private p92622dbe(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        java.util.Enumeration enumerationNGwjuAXsBNjVljgX = NGwjuAXsBNjVljgX(p80f8c729Var);
        this.f7e017ad6 = MLaWpmYOUfWlguQb(DpdQGydNmuWBAChl(enumerationNGwjuAXsBNjVljgX));
        this.f8d777f38 = UniexYCOIBtGNQhz(KpglxMpbwsdTYgdj(enumerationNGwjuAXsBNjVljgX));
    }

    public p92622dbe(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr) {
        this.f7e017ad6 = p234a7530Var;
        this.f8d777f38 = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
    }

    public static java.lang.object DpdQGydNmuWBAChl(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 GwdXdAYntwWNvhUL(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.object KpglxMpbwsdTYgdj(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 MLaWpmYOUfWlguQb(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static void MxCnjkMqytotLMWh(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration NGwjuAXsBNjVljgX(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 UniexYCOIBtGNQhz(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static byte[] WotsnGoccQfbpVXb(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static void GbvfnWnUEHzXgcvB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.p92622dbe M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.p92622dbe) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.p92622dbe) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.p92622dbe(GwdXdAYntwWNvhUL(obj));
    }

    public byte[] GetEncryptedData() {
        return WotsnGoccQfbpVXb(this.f8d777f38);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetEncryptionAlgorithm() {
        return this.f7e017ad6;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((6 + 3) % 3 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        gbvfnWnUEHzXgcvB(pd6ccb7fcVar, this.f7e017ad6);
        MxCnjkMqytotLMWh(pd6ccb7fcVar, this.f8d777f38);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

