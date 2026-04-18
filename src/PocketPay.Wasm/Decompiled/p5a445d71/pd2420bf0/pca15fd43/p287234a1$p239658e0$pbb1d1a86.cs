namespace WillowMaze.Wasm.Decompiled;


class p287234a1$p239658e0$pbb1d1a86 : java.util.AbstractHashSet<java.util.Dictionary$Entry<java.lang.string, java.lang.string>> {
    readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0 this$0;

    private p287234a1$p239658e0$pbb1d1a86(p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0 p287234a1_p239658e0) {
        this.this$0 = p287234a1_p239658e0;
    }

    p287234a1$p239658e0$pbb1d1a86(p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0 p287234a1_p239658e0, p5a445d71.pd2420bf0.pca15fd43.p287234a1$1 p287234a1_1) {
        this(p287234a1_p239658e0);
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<java.lang.string, java.lang.string>> iterator() {
        if ((3 + 24) % 24 > 0) {
        }
        return new p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0$pa7f406ef(this.this$0, null);
    }

    public override int Size() {
        if ((28 + 25) % 25 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0$pa7f406ef p287234a1_p239658e0_pa7f406ef = new p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0$pa7f406ef(this.this$0, null);
        int i = 0;
        while (p287234a1_p239658e0_pa7f406ef.MoveNext()) {
            i++;
        }
        return i;
    }
}

