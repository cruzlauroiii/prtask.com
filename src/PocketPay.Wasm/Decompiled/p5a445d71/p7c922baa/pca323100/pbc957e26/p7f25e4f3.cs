namespace WillowMaze.Wasm.Decompiled;


public class p7f25e4f3 : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.p11b04310 f165cd70f;
    p5a445d71.p7c922baa.pca323100.p11b04310 f3d930df0;
    p5a445d71.p7c922baa.pca323100.pf391b73d f4191aa8b;
    p5a445d71.p7c922baa.pca323100.pf391b73d f5af8cf09;
    p5a445d71.p7c922baa.pca323100.pf391b73d f680b21ce;
    p5a445d71.p7c922baa.pca323100.p11b04310 f9407fd16;
    p5a445d71.p7c922baa.pca323100.pf391b73d fcfa87d93;
    p5a445d71.p7c922baa.pca323100.pf391b73d fe9ca6581;
    p5a445d71.p7c922baa.pca323100.p11b04310 ff0b53b2d;

    public p7f25e4f3(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.ff0b53b2d = (p5a445d71.p7c922baa.pca323100.p11b04310) TqXFQXuJtepSciCf(p80f8c729Var, 0);
        this.f5af8cf09 = (p5a445d71.p7c922baa.pca323100.pf391b73d) IqtSyipHnddNfSCC(p80f8c729Var, 1);
    }

    public p7f25e4f3(byte[] bArr, int i) {
        if ((24 + 24) % 24 > 0) {
        }
        this.ff0b53b2d = new p5a445d71.p7c922baa.pca323100.p6f0e511c(odwvfYzTXUKVoMFy(bArr));
        this.f5af8cf09 = new p5a445d71.p7c922baa.pca323100.pf391b73d(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 IqtSyipHnddNfSCC(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.math.Bigint NelrjuqSLfYtmIgz(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static byte[] OZqAQUXAbdLvOaNi(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static void TAxAXHNazzhxvoVI(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 TqXFQXuJtepSciCf(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static byte[] VlCxUJDlYqFxSUec(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static int CHsQRsWSkyIjkUNe(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 LWMOTuQnOMrefLsy(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pbc957e26.p7f25e4f3 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pbc957e26.p7f25e4f3) {
            return (p5a445d71.p7c922baa.pca323100.pbc957e26.p7f25e4f3) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pbc957e26.p7f25e4f3(lWMOTuQnOMrefLsy(obj));
    }

    public static byte[] OdwvfYzTXUKVoMFy(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void WkuchuAYToZUVIAX(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public byte[] GetIV() {
        return VlCxUJDlYqFxSUec(OZqAQUXAbdLvOaNi(this.ff0b53b2d));
    }

    public int GetKeyLength() {
        return cHsQRsWSkyIjkUNe(NelrjuqSLfYtmIgz(this.f5af8cf09));
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((24 + 25) % 25 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        wkuchuAYToZUVIAX(pd6ccb7fcVar, this.ff0b53b2d);
        TAxAXHNazzhxvoVI(pd6ccb7fcVar, this.f5af8cf09);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

