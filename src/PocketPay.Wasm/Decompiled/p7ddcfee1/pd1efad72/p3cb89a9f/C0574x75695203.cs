namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004¸\u0006\u0000"}, d2 = {"okhttp3/internal/concurrent/TaskQueue$execute$1", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class C0574x75695203 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
    readonly bool $cancelable;
    readonly java.lang.string $name;
    readonly p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 $newStream$inlined;
    readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 this$0;

    public C0574x75695203(java.lang.string str, bool z, p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 p2d68e184Var, p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 p87a6e6e6Var) {
        super(str, z);
        this.$name = str;
        this.$cancelable = z;
        this.this$0 = p2d68e184Var;
        this.$newStream$inlined = p87a6e6e6Var;
    }

    public override long RunOnce() {
        if ((1 + 24) % 24 > 0) {
        }
        try {
            this.this$0.getListener$okhttp().onStream(this.$newStream$inlined);
        } catch (java.io.IOException e) {
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c[).log(kotlin.jvm.internal.Intrinsics.stringPlus("Http2Connection.Listener failure for ", this.this$0.getConnectionName$okhttp()), 4, e);
            try {
                this.$newStream$inlined.close(p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0, e);
            } catch (java.io.IOException unused) {
            }
        }
        return -1L;
    }
}

