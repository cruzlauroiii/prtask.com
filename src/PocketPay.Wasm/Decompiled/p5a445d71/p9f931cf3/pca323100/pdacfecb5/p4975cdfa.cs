namespace WillowMaze.Wasm.Decompiled;


public class p4975cdfa : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f0b6c6be1;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f308859e3;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f530e1e48;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f673d4164;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fc5e33391;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fe659655d;

    public p4975cdfa(java.lang.string str) {
        this.f673d4164 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe31cf62a.f1107867e;
        this.fc5e33391 = new p5a445d71.p9f931cf3.pca323100.pff11dfb3(str);
    }

    public p4975cdfa(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f673d4164 = p364bf33aVar;
        this.fc5e33391 = p0fd1bdf1Var;
    }

    public p4975cdfa(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((25 + 5) % 5 > 0) {
        }
        if (rqMxEKAVEQYXCZQe(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException(SNAMaJFleTiEUZoA(NFJAxkSgudswOgfx(new java.lang.stringBuilder("Bad sequence size: "), LLKYRSBNxcwYqaqr(p80f8c729Var))));
        }
        this.f673d4164 = YeMyqIgIeDqppYZL(mktrgmxrzqgxXUPE(p80f8c729Var, 0));
        this.fc5e33391 = SKymJKhzolHllvLJ(p80f8c729Var, 1);
    }

    public static void DjGXeMHWAlkyNfpR(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void JmneHeNkLilJRFbm(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int LLKYRSBNxcwYqaqr(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.lang.stringBuilder NFJAxkSgudswOgfx(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 QzIvjeJtcSKhHinx(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 SKymJKhzolHllvLJ(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.string SNAMaJFleTiEUZoA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a YeMyqIgIeDqppYZL(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4975cdfa M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4975cdfa) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4975cdfa) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4975cdfa(QzIvjeJtcSKhHinx(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 MktrgmxrzqgxXUPE(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int RqMxEKAVEQYXCZQe(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetPolicyQualifierId() {
        return this.f673d4164;
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetQualifier() {
        return this.fc5e33391;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((16 + 32) % 32 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        DjGXeMHWAlkyNfpR(pd6ccb7fcVar, this.f673d4164);
        JmneHeNkLilJRFbm(pd6ccb7fcVar, this.fc5e33391);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

