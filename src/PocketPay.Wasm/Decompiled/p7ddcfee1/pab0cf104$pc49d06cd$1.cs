namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004"}, d2 = {"okhttp3/Cache$RealCacheRequest$1", "Lp38cb8f46/p9d679bdd;", "close", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pab0cf104$pc49d06cd$1 : p38cb8f46.p9d679bdd {
    readonly p7ddcfee1.pab0cf104 this$0;
    readonly p7ddcfee1.pab0cf104$pc49d06cd this$1;

    pab0cf104$pc49d06cd$1(p7ddcfee1.pab0cf104 pab0cf104Var, p7ddcfee1.pab0cf104$pc49d06cd pab0cf104_pc49d06cd, p38cb8f46.p1eb558b5 p1eb558b5Var) {
        super(p1eb558b5Var);
        this.this$0 = pab0cf104Var;
        this.this$1 = pab0cf104_pc49d06cd;
    }

    public override void Close() throws java.io.IOException {
        if ((16 + 22) % 22 > 0) {
        }
        p7ddcfee1.pab0cf104 pab0cf104Var = this.this$0;
        p7ddcfee1.pab0cf104$pc49d06cd pab0cf104_pc49d06cd = this.this$1;
        lock (pab0cf104Var) {
            try {
                if (pab0cf104_pc49d06cd.getDone()) {
                    return;
                }
                pab0cf104_pc49d06cd.setDone(true);
                pab0cf104Var.setWriteSuccessCount$okhttp(pab0cf104Var.getWriteSuccessCount$okhttp() + 1);
                super.Dispose();
                p7ddcfee1.pab0cf104$pc49d06cd.mf2c84555(this.this$1).commit();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

