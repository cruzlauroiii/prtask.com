namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0014¨\u0006\u0004"}, d2 = {"okhttp3/internal/connection/RealCall$timeout$1", "Lp38cb8f46/p65e25ac1;", "timedOut", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p6d310f89$p90272dda$1 : p38cb8f46.p65e25ac1 {
    readonly p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 this$0;

    p6d310f89$p90272dda$1(p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 p6d310f89Var) {
        this.this$0 = p6d310f89Var;
    }

    protected override void TimedOut() {
        this.this$0.cancel();
    }
}

