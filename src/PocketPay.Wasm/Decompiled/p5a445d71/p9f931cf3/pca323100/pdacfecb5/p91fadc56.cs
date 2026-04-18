namespace WillowMaze.Wasm.Decompiled;


public class p91fadc56 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f4777ea66;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 faa6f6d62;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 fbaa32c2b;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 fd0ebe706;

    private p91fadc56(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.faa6f6d62 = p80f8c729Var;
    }

    public p91fadc56(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189[] pc41a3189VarArr) {
        this.faa6f6d62 = new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pc41a3189VarArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189 SrrTJNwayysrpkrr(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 XCKXgwZVuGqHHhcC(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.object CWfQnzKCIlmunFKu(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static bool EjiwtklnMBJlBVrk(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56(XCKXgwZVuGqHHhcC(obj));
    }

    public static java.util.Enumeration ROOcggGkHvlNftbq(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static int RUjQBHBlqZvReyCR(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189[] GetTargets() {
        if ((31 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189[] pc41a3189VarArr = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189[rUjQBHBlqZvReyCR(this.faa6f6d62)];
        java.util.Enumeration enumerationROOcggGkHvlNftbq = rOOcggGkHvlNftbq(this.faa6f6d62);
        int i = 0;
        while (ejiwtklnMBJlBVrk(enumerationROOcggGkHvlNftbq)) {
            int i2 = i + 1;
            pc41a3189VarArr[i] = SrrTJNwayysrpkrr(cWfQnzKCIlmunFKu(enumerationROOcggGkHvlNftbq));
            i = i2;
        }
        return pc41a3189VarArr;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.faa6f6d62;
    }
}

