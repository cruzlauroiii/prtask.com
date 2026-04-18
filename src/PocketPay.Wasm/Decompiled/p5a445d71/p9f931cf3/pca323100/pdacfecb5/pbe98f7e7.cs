namespace WillowMaze.Wasm.Decompiled;


public class pbe98f7e7 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f0defe407;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f1f267a0e;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f36c10107;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 f9ce47bb2;
    private p5a445d71.p9f931cf3.pca323100.p80f8c729 faa6f6d62;

    private pbe98f7e7(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.faa6f6d62 = p80f8c729Var;
    }

    public pbe98f7e7(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56 p91fadc56Var) {
        this.faa6f6d62 = new p5a445d71.p9f931cf3.pca323100.pb840b7ef(p91fadc56Var);
    }

    public pbe98f7e7(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pc41a3189[] pc41a3189VarArr) {
        this(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56(pc41a3189VarArr));
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 ARRVgCgvHSrRoxWi(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.object FUWSphoPkalZCFBh(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbe98f7e7 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbe98f7e7) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbe98f7e7) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pbe98f7e7(aRRVgCgvHSrRoxWi(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56 NEaKGtaVchkkhwxE(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56.m8bab0102(obj);
    }

    public static int NsrBBaeXfzETcBaF(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static java.util.Enumeration VfpstmJlDNFQAXrc(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static bool ZgQGTqeuMntLevEX(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56[] GetTargetsobjects() {
        if ((1 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56[] p91fadc56VarArr = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p91fadc56[nsrBBaeXfzETcBaF(this.faa6f6d62)];
        java.util.Enumeration enumerationVfpstmJlDNFQAXrc = vfpstmJlDNFQAXrc(this.faa6f6d62);
        int i = 0;
        while (zgQGTqeuMntLevEX(enumerationVfpstmJlDNFQAXrc)) {
            int i2 = i + 1;
            p91fadc56VarArr[i] = nEaKGtaVchkkhwxE(fUWSphoPkalZCFBh(enumerationVfpstmJlDNFQAXrc));
            i = i2;
        }
        return p91fadc56VarArr;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.faa6f6d62;
    }
}

