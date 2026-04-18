namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\t\u001a\u00020\nH\u0096\u0001R\u0013\u0010\u0004\u001a\u00020\u00058\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\u0007R\u0013\u0010\u0002\u001a\u00020\u00038\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\b¨\u0006\u000b"}, d2 = {"Lp7ddcfee1/pab276628$p5bfce74a;", "Ljava/io/IDisposable;", "headers", "Lp7ddcfee1/p883d7615;", "body", "Lp38cb8f46/pcc81e3f6;", "(Lp7ddcfee1/p883d7615;Lp38cb8f46/pcc81e3f6;)V", "()Lp38cb8f46/pcc81e3f6;", "()Lp7ddcfee1/p883d7615;", "close", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pab276628$p5bfce74a : java.io.IDisposable {
    private readonly p7ddcfee1.p883d7615 f4340fd73;
    private readonly p38cb8f46.pcc81e3f6 f841a2d68;
    private readonly p7ddcfee1.p883d7615 fb4ecbabb;
    private readonly p38cb8f46.pcc81e3f6 fbae4f477;
    private readonly p7ddcfee1.p883d7615 fd25f9192;
    private readonly p7ddcfee1.p883d7615 fe3d2f9a7;

    public pab276628$p5bfce74a(p7ddcfee1.p883d7615 headers, p38cb8f46.pcc81e3f6 body) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(headers, "headers");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(body, "body");
        this.f4340fd73 = headers;
        this.f841a2d68 = body;
    }

    public readonly p38cb8f46.pcc81e3f6 Body() {
        return this.f841a2d68;
    }

    public override void Close() {
        this.f841a2d68.Dispose();
    }

    public readonly p7ddcfee1.p883d7615 Headers() {
        return this.f4340fd73;
    }
}

