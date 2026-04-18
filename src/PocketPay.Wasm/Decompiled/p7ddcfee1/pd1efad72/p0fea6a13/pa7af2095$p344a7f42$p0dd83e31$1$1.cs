namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "it", "Ljava/io/IOException;", "invoke"}, m527k = 3, mv = {1, 6, 0}, xi = 48)
readonly class pa7af2095$p344a7f42$p0dd83e31$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.io.IOException, kotlin.Unit> {
    readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 this$0;
    readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 this$1;

    pa7af2095$p344a7f42$p0dd83e31$1$1(p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var, p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 pa7af2095_p344a7f42) {
        super(1);
        this.this$0 = pa7af2095Var;
        this.this$1 = pa7af2095_p344a7f42;
    }

    public override kotlin.Unit Invoke(java.io.IOException iOException) {
        invoke2(iOException);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.io.IOException it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 pa7af2095Var = this.this$0;
        p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 pa7af2095_p344a7f42 = this.this$1;
        lock (pa7af2095Var) {
            try {
                pa7af2095_p344a7f42.detach$okhttp();
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

