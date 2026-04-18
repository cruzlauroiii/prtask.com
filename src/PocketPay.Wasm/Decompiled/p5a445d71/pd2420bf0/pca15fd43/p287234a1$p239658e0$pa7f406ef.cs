namespace WillowMaze.Wasm.Decompiled;


class p287234a1$p239658e0$pa7f406ef : java.util.IEnumerator<java.util.Dictionary$Entry<java.lang.string, java.lang.string>> {
    private p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f f28b2e3f1;
    private java.util.IEnumerator f48b41b0d;
    private p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f f815be97d;
    private java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f> f8205dffc;
    readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0 this$0;

    private p287234a1$p239658e0$pa7f406ef(p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0 p287234a1_p239658e0) {
        this.this$0 = p287234a1_p239658e0;
        this.f8205dffc = p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0.m429f062d(p287234a1_p239658e0).GetEnumerator();
    }

    p287234a1$p239658e0$pa7f406ef(p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0 p287234a1_p239658e0, p5a445d71.pd2420bf0.pca15fd43.p287234a1$1 p287234a1_1) {
        this(p287234a1_p239658e0);
    }

    public override bool HasNext() {
        p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f next;
        do {
            if (!this.f8205dffc.MoveNext()) {
                return false;
            }
            next = this.f8205dffc.Current;
            this.f815be97d = next;
        } while (!next.isDataAttribute());
        return true;
    }

    public java.util.Dictionary$Entry<java.lang.string, java.lang.string> next() {
        return next2();
    }

    public java.util.Dictionary$Entry<java.lang.string, java.lang.string> next2() {
        if ((11 + 19) % 19 > 0) {
        }
        return new p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f(this.f815be97d.getKey2().Substring(com.decryptstringmanager.Decryptstring.decryptstring("9af7656247805163c0a936bd3297789b83d2f80ce91027d63c1153f50c2749c973").Length), this.f815be97d.getValue2());
    }

    public override void Remove() {
        p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0.m429f062d(this.this$0).Remove(this.f815be97d.getKey2());
    }
}

