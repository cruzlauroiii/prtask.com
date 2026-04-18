namespace WillowMaze.Wasm.Decompiled;


class p287234a1$1 : java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f> {
    int f5bf0d758;
    int f61fdcb37;
    int f865c0c0b = 0;
    int f8f86536b;
    int fbdfb1731;
    readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1 this$0;

    p287234a1$1(p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var) {
        this.this$0 = p287234a1Var;
    }

    public override bool HasNext() {
        return this.f865c0c0b < p5a445d71.pd2420bf0.pca15fd43.p287234a1.mf23e8626(this.this$0);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f Next() {
        return next2();
    }

    public override p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f Next2() {
        if ((25 + 5) % 5 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f pf2bbdf9fVar = new p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f(this.this$0.f14f802e1[this.f865c0c0b], this.this$0.fb2021c41[this.f865c0c0b], this.this$0);
        this.f865c0c0b++;
        return pf2bbdf9fVar;
    }

    public override void Remove() {
        if ((23 + 21) % 21 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var = this.this$0;
        int i = this.f865c0c0b - 1;
        this.f865c0c0b = i;
        p5a445d71.pd2420bf0.pca15fd43.p287234a1.mf8f67da7(p287234a1Var, i);
    }
}

