namespace WillowMaze.Wasm.Decompiled;


class pb7728374$3 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9d3c9ec4 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 val$fromWNaf;
    readonly bool val$includeNegated;
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 val$pointDictionary;

    pb7728374$3(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var, bool z, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 p5da251d0Var) {
        this.val$fromWNaf = p66539f12Var;
        this.val$includeNegated = z;
        this.val$pointDictionary = p5da251d0Var;
    }

    private bool M05818fde(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var, int i, int i2, bool z) {
        if (p66539f12Var is not null && p66539f12Var.getWidth() >= i && m5a886b6c(p66539f12Var.getPreComp(), i2)) {
            return !z || m5a886b6c(p66539f12Var.getPreCompNeg(), i2);
        }
        return false;
    }

    private bool M5a886b6c(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i) {
        return p53a5793fVarArr is not null && p53a5793fVarArr.length >= i;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a Precompute(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        if ((27 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var = !(pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) ? null : (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) pabc8833aVar;
        int width = this.val$fromWNaf.getWidth();
        if (m05818fde(p66539f12Var, width, this.val$fromWNaf.getPreComp().length, this.val$includeNegated)) {
            p66539f12Var.decrementPromotionCountdown();
            return p66539f12Var;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12();
        p66539f12Var2.setPromotionCountdown(this.val$fromWNaf.getPromotionCountdown());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f twice = this.val$fromWNaf.getTwice();
        if (twice is not null) {
            p66539f12Var2.setTwice(this.val$pointDictionary.map(twice));
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] preComp = this.val$fromWNaf.getPreComp();
        int length = preComp.length;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[length];
        for (int i = 0; i < preComp.length; i++) {
            p53a5793fVarArr[i] = this.val$pointDictionary.map(preComp[i]);
        }
        p66539f12Var2.setPreComp(p53a5793fVarArr);
        p66539f12Var2.setWidth(width);
        if (this.val$includeNegated) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[length];
            for (int i2 = 0; i2 < length; i2++) {
                p53a5793fVarArr2[i2] = p53a5793fVarArr[i2].negate();
            }
            p66539f12Var2.setPreCompNeg(p53a5793fVarArr2);
        }
        return p66539f12Var2;
    }
}

