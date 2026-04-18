namespace WillowMaze.Wasm.Decompiled;


public class pad1b94ef : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.p11b04310 f1359644e;
    p5a445d71.p7c922baa.pca323100.p364bf33a f19593ed9;
    p5a445d71.p7c922baa.pca323100.p11b04310 f3ce792d3;
    p5a445d71.p7c922baa.pca323100.p364bf33a f49346968;
    p5a445d71.p7c922baa.pca323100.p11b04310 f5da6a4a6;
    p5a445d71.p7c922baa.pca323100.p11b04310 fb6203d73;
    p5a445d71.p7c922baa.pca323100.p11b04310 fd1fc8eaf;

    public pad1b94ef(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        this.f19593ed9 = p364bf33aVar;
        this.fd1fc8eaf = p11b04310Var;
    }

    public pad1b94ef(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f19593ed9 = (p5a445d71.p7c922baa.pca323100.p364bf33a) MLbikzQntcXwqbJw(p80f8c729Var, 0);
        this.fd1fc8eaf = (p5a445d71.p7c922baa.pca323100.p11b04310) YdDHEtpfmMfUcJOt(p80f8c729Var, 1);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 GGtiLTYdwbAyKfgR(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MLbikzQntcXwqbJw(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 QhFvAKuIWzHNARkV(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 YdDHEtpfmMfUcJOt(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.pad1b94ef ZGxeisYvTXsKsidE(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static void GOIBVlWcKZRkqhdQ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.pad1b94ef M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p785c9c91.pad1b94ef) {
            return (p5a445d71.p7c922baa.pca323100.p785c9c91.pad1b94ef) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p785c9c91.pad1b94ef(GGtiLTYdwbAyKfgR(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p785c9c91.pad1b94ef M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return ZGxeisYvTXsKsidE(QhFvAKuIWzHNARkV(p582a4948Var, z));
    }

    public static void OkdBXwcizYQbDFXo(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p7c922baa.pca323100.p11b04310 GetResponse() {
        return this.fd1fc8eaf;
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetResponseType() {
        return this.f19593ed9;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((11 + 14) % 14 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        gOIBVlWcKZRkqhdQ(pd6ccb7fcVar, this.f19593ed9);
        okdBXwcizYQbDFXo(pd6ccb7fcVar, this.fd1fc8eaf);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

