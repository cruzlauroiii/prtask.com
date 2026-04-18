namespace WillowMaze.Wasm.Decompiled;


class pb7728374$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9d3c9ec4 {
    readonly int val$confWidth;

    pb7728374$1(int i) {
        this.val$confWidth = i;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a Precompute(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        if ((5 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var = !(pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) ? null : (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) pabc8833aVar;
        if (p66539f12Var is not null && p66539f12Var.getConfWidth() == this.val$confWidth) {
            p66539f12Var.setPromotionCountdown(0);
            return p66539f12Var;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12();
        p66539f12Var2.setPromotionCountdown(0);
        p66539f12Var2.setConfWidth(this.val$confWidth);
        if (p66539f12Var is not null) {
            p66539f12Var2.setPreComp(p66539f12Var.getPreComp());
            p66539f12Var2.setPreCompNeg(p66539f12Var.getPreCompNeg());
            p66539f12Var2.setTwice(p66539f12Var.getTwice());
            p66539f12Var2.setWidth(p66539f12Var.getWidth());
        }
        return p66539f12Var2;
    }
}

