namespace WillowMaze.Wasm.Decompiled;


class p53a5793f$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9d3c9ec4 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f this$0;
    readonly bool val$checkOrder;
    readonly bool val$decompressed;

    p53a5793f$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, bool z, bool z2) {
        this.this$0 = p53a5793fVar;
        this.val$decompressed = z;
        this.val$checkOrder = z2;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a Precompute(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p7cf40e66 p7cf40e66Var = !(pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p7cf40e66) ? null : (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p7cf40e66) pabc8833aVar;
        if (p7cf40e66Var is null) {
            p7cf40e66Var = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p7cf40e66();
        }
        if (!p7cf40e66Var.hasFailed()) {
            if (!p7cf40e66Var.hasCurveEquationPassed()) {
                if (!this.val$decompressed && !this.this$0.satisfiesCurveEquation()) {
                    p7cf40e66Var.reportFailed();
                    return p7cf40e66Var;
                }
                p7cf40e66Var.reportCurveEquationPassed();
            }
            if (this.val$checkOrder && !p7cf40e66Var.hasOrderPassed()) {
                if (!this.this$0.satisfiesOrder()) {
                    p7cf40e66Var.reportFailed();
                    return p7cf40e66Var;
                }
                p7cf40e66Var.reportOrderPassed();
            }
        }
        return p7cf40e66Var;
    }
}

