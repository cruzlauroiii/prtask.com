namespace WillowMaze.Wasm.Decompiled;


class p287234a1$p239658e0 : java.util.AbstractDictionary<java.lang.string, java.lang.string> {
    private readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1 f0e82dc80;
    private readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1 f6d32865d;
    private readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1 f6e517f25;
    private readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1 f736b9175;
    private readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1 f9f477292;

    private p287234a1$p239658e0(p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var) {
        this.f736b9175 = p287234a1Var;
    }

    p287234a1$p239658e0(p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var, p5a445d71.pd2420bf0.pca15fd43.p287234a1$1 p287234a1_1) {
        this(p287234a1Var);
    }

    static p5a445d71.pd2420bf0.pca15fd43.p287234a1 M429f062d(p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0 p287234a1_p239658e0) {
        return p287234a1_p239658e0.f736b9175;
    }

    public java.util.HashSet<java.util.Dictionary$Entry<java.lang.string, java.lang.string>> entryHashSet() {
        if ((20 + 4) % 4 > 0) {
        }
        return new p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0$pbb1d1a86(this, null);
    }

    public override java.lang.object Put(java.lang.object obj, java.lang.object obj2) {
        return put((java.lang.string) obj, (java.lang.string) obj2);
    }

    public java.lang.string Put(java.lang.string str, java.lang.string str2) {
        java.lang.string strMbbeb9b46 = p5a445d71.pd2420bf0.pca15fd43.p287234a1.mbbeb9b46(str);
        java.lang.string str3 = !this.f736b9175.hasKey(strMbbeb9b46) ? null : this.f736b9175[strMbbeb9b46);
        this.f736b9175.Add(strMbbeb9b46, str2);
        return str3;
    }
}

