namespace WillowMaze.Wasm.Decompiled;


public class p524c9481 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f38d4e456;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f8bda9252;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f9867b9af;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f99df3ee0;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fa088ac9a;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 fb59fe78e;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fc2a33941;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fe1896788;

    private p524c9481(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.fe1896788 = vtQCHjEtiOInuPdx(XDQPwWyBlIMIGDul(p80f8c729Var, 0));
        this.fb59fe78e = IJbDfkYysTCSMsaj(ztUuGoRXFdKhxaLn(p80f8c729Var, 1));
    }

    public p524c9481(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr) {
        this.fe1896788 = p234a7530Var;
        this.fb59fe78e = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
    }

    public static void BjuMAZNOORRKTUDz(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310 IJbDfkYysTCSMsaj(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 XDQPwWyBlIMIGDul(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void GWOyzVovBHqyxWeb(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p5360af35.p524c9481 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p5360af35.p524c9481) {
            return (p5a445d71.p9f931cf3.pca323100.p5360af35.p524c9481) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p5360af35.p524c9481(vacfPZYvQEHpCJJo(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 VacfPZYvQEHpCJJo(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 VtQCHjEtiOInuPdx(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ZtUuGoRXFdKhxaLn(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p9f931cf3.pca323100.p11b04310 GetEncryptedContent() {
        return this.fb59fe78e;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetEncryptionAlgorithm() {
        return this.fe1896788;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((21 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        BjuMAZNOORRKTUDz(pd6ccb7fcVar, this.fe1896788);
        gWOyzVovBHqyxWeb(pd6ccb7fcVar, this.fb59fe78e);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

