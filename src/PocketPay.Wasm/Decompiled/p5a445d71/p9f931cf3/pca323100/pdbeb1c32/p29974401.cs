namespace WillowMaze.Wasm.Decompiled;


public class p29974401 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p2f096beb f0273607c;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f0ac02c0c;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f2464c876;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f4796a0f5;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 f5e7e2554;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f60b4911d;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f6fb19b03;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 f8c9cb155;
    private p5a445d71.p9f931cf3.pca323100.p2f096beb fb04ec0ad;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 fdb718310;

    private p29974401(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f6fb19b03 = p80f8c729Var;
        this.f5e7e2554 = heJooPZDkPDMuZVI(fcLthKIarUKIHPYP(p80f8c729Var, 0));
        this.fb04ec0ad = gntABdhTTvLXqsyY(zKbGKKNStKINaaaL(p80f8c729Var, 1));
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 JhilrJwtaBfMbEgE(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 FcLthKIarUKIHPYP(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p2f096beb GntABdhTTvLXqsyY(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p2f096beb.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 HeJooPZDkPDMuZVI(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401) {
            return (p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401(JhilrJwtaBfMbEgE(obj));
    }

    public static java.lang.string VRVIekbINLNirLoi(p5a445d71.p9f931cf3.pca323100.p2f096beb p2f096bebVar) {
        return p2f096bebVar.getstring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ZKbGKKNStKINaaaL(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p9f931cf3.pca323100.pff11dfb3 GetChallenge() {
        if ((3 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p2f096beb p2f096bebVar = this.fb04ec0ad;
        return (p2f096bebVar is null || (p2f096bebVar is p5a445d71.p9f931cf3.pca323100.pff11dfb3)) ? (p5a445d71.p9f931cf3.pca323100.pff11dfb3) p2f096bebVar : new p5a445d71.p9f931cf3.pca323100.pff11dfb3(vRVIekbINLNirLoi(this.fb04ec0ad), false);
    }

    public p5a445d71.p9f931cf3.pca323100.p2f096beb GetChallengeIA5() {
        return this.fb04ec0ad;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 GetSubjectPublicKeyInfo() {
        return this.f5e7e2554;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f6fb19b03;
    }
}

