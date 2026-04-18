namespace WillowMaze.Wasm.Decompiled;


public class pd4a04c2e : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p11b04310 f297c54f0;
    private p5a445d71.p7c922baa.pca323100.p11b04310 f491de0d7;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f529531ac;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f8a5c4050;
    private p5a445d71.p7c922baa.pca323100.p11b04310 fab08024a;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fae16557b;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fd72ffeec;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fdfc554ae;

    private pd4a04c2e(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((18 + 30) % 30 > 0) {
        }
        if (WyvuahxRFGtNGOGt(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException(dicYUiSeZDsgIiIy(WPysUTscSGyffsvf(new java.lang.stringBuilder("Bad sequence size: "), VnnIxQebSgTcvype(p80f8c729Var))));
        }
        this.f529531ac = RqZfHARhvrGLNmRi(ZLREPimDEaPDyGum(p80f8c729Var, 0));
        this.f491de0d7 = MormKHkHFCRmMJRT(OLgtZJkzYPaHODpY(p80f8c729Var, 1));
    }

    public pd4a04c2e(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        this.f529531ac = p234a7530Var;
        this.f491de0d7 = p11b04310Var;
    }

    public static void BcptBiyolwBzQxOM(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 MormKHkHFCRmMJRT(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 OLgtZJkzYPaHODpY(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 RqZfHARhvrGLNmRi(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static int VnnIxQebSgTcvype(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.stringBuilder WPysUTscSGyffsvf(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WyvuahxRFGtNGOGt(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ZLREPimDEaPDyGum(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 ABdKWElGJiUerNGK(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.string DicYUiSeZDsgIiIy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FyZomgOwiMZEdCNV(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e(aBdKWElGJiUerNGK(obj));
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetHashAlgorithm() {
        return this.f529531ac;
    }

    public p5a445d71.p7c922baa.pca323100.p11b04310 GetHashValue() {
        return this.f491de0d7;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((14 + 24) % 24 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        fyZomgOwiMZEdCNV(pd6ccb7fcVar, this.f529531ac);
        BcptBiyolwBzQxOM(pd6ccb7fcVar, this.f491de0d7);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

