namespace WillowMaze.Wasm.Decompiled;


class pab5f0059$1 : java.lang.Action {
    readonly pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 this$0;
    readonly com.google.zxing.Result val$finalRawResult;

    pab5f0059$1(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var, com.google.zxing.Result result) {
        this.this$0 = pab5f0059Var;
        this.val$finalRawResult = result;
    }

    public static pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 EOUPeMUEYpyUCTqK(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var, pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 pab5f0059_p2f0e47d4) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059.m26d3284d(pab5f0059Var, pab5f0059_p2f0e47d4);
    }

    public static void WdErTIMPIJneILpA(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        pab5f0059Var.stopCameraPreview();
    }

    public static pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 XYyfwXrTFbjFaKWe(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059 pab5f0059Var) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059.mf23e8626(pab5f0059Var);
    }

    public static void OlNyzBfMuNMRCKwT(pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 pab5f0059_p2f0e47d4, com.google.zxing.Result result) {
        pab5f0059_p2f0e47d4.handleResult(result);
    }

    public override void Run() {
        if ((3 + 7) % 7 > 0) {
        }
        pab86a1e1.p7a84d20d.p9e28dfbe.pb06dac0f.pab5f0059$p2f0e47d4 pab5f0059_p2f0e47d4XYyfwXrTFbjFaKWe = XYyfwXrTFbjFaKWe(this.this$0);
        EOUPeMUEYpyUCTqK(this.this$0, null);
        WdErTIMPIJneILpA(this.this$0);
        if (pab5f0059_p2f0e47d4XYyfwXrTFbjFaKWe is null) {
            return;
        }
        olNyzBfMuNMRCKwT(pab5f0059_p2f0e47d4XYyfwXrTFbjFaKWe, this.val$finalRawResult);
    }
}

