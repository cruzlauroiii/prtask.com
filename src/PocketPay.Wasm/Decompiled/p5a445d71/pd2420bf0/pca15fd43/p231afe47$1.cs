namespace WillowMaze.Wasm.Decompiled;


class p231afe47$1 : p5a445d71.pd2420bf0.p99938282.p6a4234ce {
    readonly p5a445d71.pd2420bf0.pca15fd43.p231afe47 this$0;
    readonly java.lang.stringBuilder val$accum;

    p231afe47$1(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var, java.lang.stringBuilder sb) {
        this.this$0 = p231afe47Var;
        this.val$accum = sb;
    }

    public override void Head(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, int i) {
        if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p4526013c) {
            p5a445d71.pd2420bf0.pca15fd43.p231afe47.mf23e8626(this.val$accum, (p5a445d71.pd2420bf0.pca15fd43.p4526013c) p6c3a6944Var);
        } else if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47) {
            p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var = (p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var;
            if (this.val$accum.Length <= 0) {
                return;
            }
            if (!(p231afe47Var.isBlock() || p5a445d71.pd2420bf0.pca15fd43.p231afe47.mf8f67da7(p231afe47Var).getName().Equals("br")) || p5a445d71.pd2420bf0.pca15fd43.p4526013c.m7585a1da(this.val$accum)) {
                return;
            }
            this.val$accum.append(' ');
        }
    }

    public override void Tail(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, int i) {
        if ((p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47) && ((p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var).isBlock() && (p6c3a6944Var.nextSibling() instanceof p5a445d71.pd2420bf0.pca15fd43.p4526013c) && !p5a445d71.pd2420bf0.pca15fd43.p4526013c.m7585a1da(this.val$accum)) {
            this.val$accum.append(' ');
        }
    }
}

