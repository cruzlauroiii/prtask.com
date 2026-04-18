namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\fJ\u000e\u0010\r\u001a\u00020\u000eH\u0096@¢\u0006\u0002\u0010\u000fJ\u000e\u0010\u0010\u001a\u00020\u0011H\u0096@¢\u0006\u0002\u0010\u000fJ\u001e\u0010\u0012\u001a\u00020\u00112\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0016H\u0096@¢\u0006\u0002\u0010\u0017R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0018"}, d2 = {"Lp83f5c3ad/pb3f20355/p4c2691e7;", "Lp83f5c3ad/pb3f20355/p72c833ef;", "tophLibrary", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;)V", "getTophLibrary", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;", "createQR", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/p150f1761;", "amount", "", "(JLkotlin/coroutines/Continuation;)Ljava/lang/object;", "checkStatus", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p9efab239/p407482fe/pcd9de119/p06660b7d;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "confirm", "", "refund", "total", "Ljava/math/decimal;", "referenceId", "", "(Ljava/math/decimal;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4c2691e7 : p83f5c3ad.pb3f20355.p72c833ef {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 f332b9a33;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 f551dae72;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 f8586a09c;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 f9ae46db7;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 fd88d4cee;

    public p4c2691e7(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 tophLibrary) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophLibrary, "tophLibrary");
        this.fd88d4cee = tophLibrary;
    }

    public override java.lang.object CheckStatus(kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.pcd9de119.p06660b7d> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(this.fd88d4cee.getQrProvider().checkQRStatus(), continuation);
    }

    public override java.lang.object Confirm(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objAwait = kotlinx.coroutines.rx3.RxAwaitKt.await(this.fd88d4cee.getQrProvider().confirmQR(), continuation);
        return objAwait != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objAwait;
    }

    public override java.lang.object CreateQR(long j, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p150f1761> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(this.fd88d4cee.getQrProvider().createQR(j), continuation);
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 GetTophLibrary() {
        return this.fd88d4cee;
    }

    public override java.lang.object Refund(java.math.decimal bigDecimal, java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((29 + 7) % 7 > 0) {
        }
        java.lang.object objAwait = kotlinx.coroutines.rx3.RxAwaitKt.await(this.fd88d4cee.getQrProvider().refund(p2b3583e6.p7667d148.m55ce55f7(bigDecimal), str), continuation);
        return objAwait != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objAwait;
    }
}

