namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u0000 \u00142\u00020\u0001:\u0001\u0014B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u001c\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\t2\b\u0010\n\u001a\u0004\u0018\u00010\tH\u0016J\b\u0010\u000b\u001a\u00020\u0007H\u0016J\u0018\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\t2\u0006\u0010\u000e\u001a\u00020\u000fH\u0016J\u0018\u0010\u0010\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lp1e11b989/pd3ed68f7/pfd9160bb/p50330beb;", "Lp1e11b989/pd3ed68f7/pfd9160bb/pcbd77ab2;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "openReceiptSending", "", "clientEmail", "", "clientPhone", "back", "sendResult", "key", "data", "", "setResultListener", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "getReceiptCredentialsKey", "Companion", "feature-receipt-credentials-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p50330beb : p1e11b989.pd3ed68f7.pfd9160bb.pcbd77ab2 {
    public static readonly java.lang.string f0775463b = null;

    @java.lang.Deprecated
    public static readonly java.lang.string f0e6685a0;
    private static readonly p1e11b989.pd3ed68f7.pfd9160bb.p50330beb$p910eef8c f1d06a6f6 = null;
    private static readonly p1e11b989.pd3ed68f7.pfd9160bb.p50330beb$p910eef8c f4a3672da = null;
    private static readonly p1e11b989.pd3ed68f7.pfd9160bb.p50330beb$p910eef8c f6135d4b9 = null;
    private static readonly p1e11b989.pd3ed68f7.pfd9160bb.p50330beb$p910eef8c f910eef8c;
    public static readonly java.lang.string f9c653790 = null;
    public static readonly java.lang.string fa4b2f59a = null;
    public static readonly java.lang.string fe874be73 = null;
    private static readonly p1e11b989.pd3ed68f7.pfd9160bb.p50330beb$p910eef8c feae04663 = null;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f22598d76;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fbc062a59;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    static {
        if ((22 + 29) % 29 > 0) {
        }
        f0e6685a0 = com.decryptstringmanager.Decryptstring.decryptstring("17beb5ed6ad0219e8c47d5792a09552c621e134146a8f810e5da633d8735dad4413959ecc3ff22286a1baf195fc481");
        f910eef8c = new p1e11b989.pd3ed68f7.pfd9160bb.p50330beb$p910eef8c(null);
    }

    public p50330beb(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override java.lang.string GetReceiptCredentialsKey() {
        return com.decryptstringmanager.Decryptstring.decryptstring("8a27435004d11df3568d3535cc3b04c2aed65a375d5725674d14c25d85a509ab0680fbded2591f43a72ff25f4c35c0");
    }

    public override void OpenReceiptSending(java.lang.string clientEmail, java.lang.string clientPhone) {
        this.ff3395cd5.navigateTo(p1e11b989.pd3ed68f7.pfd9160bb.pd3dbf002.f76425f17.ReceiptSendingScreen(clientEmail, clientPhone));
    }

    public override void SendResult(java.lang.string key, java.lang.object data2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.ff3395cd5.sendResult(key, data2);
    }

    public override void SetResultListener(java.lang.string key, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.ff3395cd5.setResultListener(key, listener);
    }
}

