namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u0000 \u00152\u00020\u0001:\u0001\u0015B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0018\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\u0007H\u0016J\u0018\u0010\r\u001a\u00020\u00072\u0006\u0010\u000e\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016J\u0018\u0010\u0011\u001a\u00020\u00072\u0006\u0010\u000e\u001a\u00020\t2\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\b\u0010\u0014\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp1e11b989/paad653ca/pfd9160bb/p97b6df61;", "Lp1e11b989/paad653ca/pfd9160bb/p542529df;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "openNoteReceiptScreen", "", "note", "", "operationType", "Lpad5f82e8/p07214c67/p1e11b989/p5a409c20;", "back", "sendResult", "key", "data", "", "setResultListener", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "getNoteKey", "Companion", "feature-receipt-note-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p97b6df61 : p1e11b989.paad653ca.pfd9160bb.p542529df {
    public static readonly p1e11b989.paad653ca.pfd9160bb.p97b6df61$p910eef8c f0b00600a = null;
    public static readonly java.lang.string f1955944c;
    public static readonly p1e11b989.paad653ca.pfd9160bb.p97b6df61$p910eef8c f41094a6f = null;
    public static readonly p1e11b989.paad653ca.pfd9160bb.p97b6df61$p910eef8c f591f9445 = null;
    public static readonly java.lang.string f70e2edd2 = null;
    public static readonly java.lang.string f743fd27d = null;
    public static readonly p1e11b989.paad653ca.pfd9160bb.p97b6df61$p910eef8c f910eef8c;
    public static readonly p1e11b989.paad653ca.pfd9160bb.p97b6df61$p910eef8c fcd477a5b = null;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f1f946736;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f8ec0a6a0;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fd284cf74;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    static {
        if ((30 + 21) % 21 > 0) {
        }
        f1955944c = com.decryptstringmanager.Decryptstring.decryptstring("f57870aecb991cbd29cbe78e3cd71a68e7a9b95f0e2b3b3ee226588bc148ca73ac0b4f8febe27c3e7189");
        f910eef8c = new p1e11b989.paad653ca.pfd9160bb.p97b6df61$p910eef8c(null);
    }

    public p97b6df61(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override java.lang.string GetNoteKey() {
        return com.decryptstringmanager.Decryptstring.decryptstring("aa3d13838598cd4e186e75d375ee5eee50cf5e6fe2ae4bc070afb305516a1b1458e7e70cb0112c04719c");
    }

    public override void OpenNoteReceiptScreen(java.lang.string note, pad5f82e8.p07214c67.p1e11b989.p5a409c20 operationType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(note, "note");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(operationType, "operationType");
        this.ff3395cd5.navigateTo(p1e11b989.paad653ca.pfd9160bb.p6c3616a9.f76425f17.NoteReceiptScreen(note, operationType));
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

