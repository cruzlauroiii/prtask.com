namespace WillowMaze.Wasm.Decompiled;


public class pe5ad9313 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.pb907b377 f18015785;
    p5a445d71.p9f931cf3.pca323100.pb907b377 f1cb92b95;
    p5a445d71.p9f931cf3.pca323100.pb907b377 f2919902f;
    p5a445d71.p9f931cf3.pca323100.pb907b377 f81a3538f;
    p5a445d71.p9f931cf3.pca323100.pb907b377 f98351b2f;
    p5a445d71.p9f931cf3.pca323100.pb907b377 fa6ea113b;
    p5a445d71.p9f931cf3.pca323100.pb907b377 fbf5a956b;
    p5a445d71.p9f931cf3.pca323100.pb907b377 fccb7e05d;
    p5a445d71.p9f931cf3.pca323100.pb907b377 ff6d45b6f;

    private pe5ad9313(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((14 + 5) % 5 > 0) {
        }
        if (xsOoklaWBfohbmXi(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException(hjhzPKRntuIWjgnz(VAqwlguaARVkeqfk(new java.lang.stringBuilder("Bad sequence size: "), COqqoDbNvnNkfoCH(p80f8c729Var))));
        }
        this.f2919902f = nWnZmFPETfPrFbbm(TnpYrJCQKuYqhwWs(p80f8c729Var, 0));
        this.ff6d45b6f = fRaYdPZBvRFhkMMd(pIoZzUeEtLDTHGod(p80f8c729Var, 1));
    }

    public pe5ad9313(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var2) {
        this.f2919902f = pb907b377Var;
        this.ff6d45b6f = pb907b377Var2;
    }

    public static int COqqoDbNvnNkfoCH(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static void GmKWEAtOkrijSfKH(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 TnpYrJCQKuYqhwWs(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.stringBuilder VAqwlguaARVkeqfk(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.pb907b377 FRaYdPZBvRFhkMMd(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pb907b377.m8bab0102(obj);
    }

    public static java.lang.string HjhzPKRntuIWjgnz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 LqavfvGtdslIEISk(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe5ad9313 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe5ad9313) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe5ad9313) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe5ad9313(lqavfvGtdslIEISk(obj));
    }

    public static void MxfLqcljIavkUaKY(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.pb907b377 NWnZmFPETfPrFbbm(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pb907b377.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 PIoZzUeEtLDTHGod(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int XsOoklaWBfohbmXi(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public p5a445d71.p9f931cf3.pca323100.pb907b377 GetNotAfterTime() {
        return this.ff6d45b6f;
    }

    public p5a445d71.p9f931cf3.pca323100.pb907b377 GetNotBeforeTime() {
        return this.f2919902f;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((3 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        GmKWEAtOkrijSfKH(pd6ccb7fcVar, this.f2919902f);
        mxfLqcljIavkUaKY(pd6ccb7fcVar, this.ff6d45b6f);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

