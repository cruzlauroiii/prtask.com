namespace WillowMaze.Wasm.Decompiled;


class p231afe47$2 : p5a445d71.pd2420bf0.p99938282.p6a4234ce {
    readonly p5a445d71.pd2420bf0.pca15fd43.p231afe47 this$0;
    readonly java.lang.stringBuilder val$accum;

    p231afe47$2(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var, java.lang.stringBuilder sb) {
        this.this$0 = p231afe47Var;
        this.val$accum = sb;
    }

    public override void Head(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, int i) {
        if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p4526013c) {
            this.val$accum.append(((p5a445d71.pd2420bf0.pca15fd43.p4526013c) p6c3a6944Var).getWholeText());
        }
    }

    public override void Tail(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, int i) {
    }
}

