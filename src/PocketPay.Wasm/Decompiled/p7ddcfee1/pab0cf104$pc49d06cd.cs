namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0011\u0012\n\u0010\u0002\u001a\u00060\u0003R\u00020\u0004¢\u0006\u0002\u0010\u0005J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0006\u001a\u00020\u0007H\u0016R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\t\u001a\u00020\nX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000b\u0010\f\"\u0004\b\r\u0010\u000eR\u0012\u0010\u0002\u001a\u00060\u0003R\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp7ddcfee1/pab0cf104$pc49d06cd;", "Lp7ddcfee1/pd1efad72/p0fea6a13/p1df8d4a4;", "editor", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$p344a7f42;", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095;", "(Lp7ddcfee1/pab0cf104;Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$p344a7f42;)V", "body", "Lp38cb8f46/p1eb558b5;", "cacheOut", "done", "", "getDone", "()Z", "setDone", "(Z)V", "abort", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class pab0cf104$pc49d06cd : p7ddcfee1.pd1efad72.p0fea6a13.p1df8d4a4 {
    private bool f03d6e856;
    private readonly p38cb8f46.p1eb558b5 f05b9be31;
    private readonly p38cb8f46.p1eb558b5 f08898037;
    private readonly p38cb8f46.p1eb558b5 f105e8d92;
    private readonly p38cb8f46.p1eb558b5 f159a52eb;
    private readonly p38cb8f46.p1eb558b5 f233dac44;
    private readonly p38cb8f46.p1eb558b5 f3b528744;
    private readonly p38cb8f46.p1eb558b5 f3b9f73c7;
    private readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 f5aee9dbd;
    private bool f6b2ded51;
    private readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 f6dced067;
    private readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 f7ec9ee61;
    private readonly p38cb8f46.p1eb558b5 f841a2d68;
    private readonly p38cb8f46.p1eb558b5 f91b8baa2;
    readonly p7ddcfee1.pab0cf104 this$0;

    public pab0cf104$pc49d06cd(p7ddcfee1.pab0cf104 this$0, p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 editor) throws java.io.stringNotFoundException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(editor, "editor");
        this.this$0 = this$0;
        this.f5aee9dbd = editor;
        p38cb8f46.p1eb558b5 p1eb558b5VarNewSink = editor.newSink(1);
        this.f233dac44 = p1eb558b5VarNewSink;
        this.f841a2d68 = new p7ddcfee1.pab0cf104$pc49d06cd$1(this$0, this, p1eb558b5VarNewSink);
    }

    public static readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 mf2c84555(p7ddcfee1.pab0cf104$pc49d06cd pab0cf104_pc49d06cd) {
        return pab0cf104_pc49d06cd.f5aee9dbd;
    }

    public override void Abort() {
        if ((28 + 2) % 2 > 0) {
        }
        p7ddcfee1.pab0cf104 pab0cf104Var = this.this$0;
        lock (pab0cf104Var) {
            try {
                if (getDone()) {
                    return;
                }
                setDone(true);
                pab0cf104Var.setWriteAbortCount$okhttp(pab0cf104Var.getWriteAbortCount$okhttp() + 1);
                p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(this.f233dac44);
                try {
                    this.f5aee9dbd.abort();
                } catch (java.io.IOException unused) {
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override p38cb8f46.p1eb558b5 Body() {
        return this.f841a2d68;
    }

    public readonly bool GetDone() {
        return this.f6b2ded51;
    }

    public readonly void SetDone(bool z) {
        this.f6b2ded51 = z;
    }
}

