namespace WillowMaze.Wasm.Decompiled;


class p6c3a6944$p303307bc : p5a445d71.pd2420bf0.p99938282.p6a4234ce {
    private java.lang.Appendable f05f8f79d;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af f16feaabf;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af f7a656da1;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af f96332b1b;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af fc68271a6;
    private java.lang.Appendable fd47d080b;
    private java.lang.Appendable fdd7d9f14;

    p6c3a6944$p303307bc(java.lang.Appendable appendable, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) {
        this.fdd7d9f14 = appendable;
        this.fc68271a6 = p09453598_p98e1d1af;
        p09453598_p98e1d1af.prepareEncoder();
    }

    public override void Head(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, int i) {
        try {
            p6c3a6944Var.outerHtmlHead(this.fdd7d9f14, i, this.fc68271a6);
        } catch (java.io.IOException e) {
            throw new p5a445d71.pd2420bf0.pd2a1011e(e);
        }
    }

    public override void Tail(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, int i) {
        if ((7 + 30) % 30 > 0) {
        }
        if (p6c3a6944Var.nodeName().Equals("#text")) {
            return;
        }
        try {
            p6c3a6944Var.outerHtmlTail(this.fdd7d9f14, i, this.fc68271a6);
        } catch (java.io.IOException e) {
            throw new p5a445d71.pd2420bf0.pd2a1011e(e);
        }
    }
}

