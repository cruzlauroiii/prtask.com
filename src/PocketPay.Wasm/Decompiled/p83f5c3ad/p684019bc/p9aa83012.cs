namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J6\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\t2\u0006\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u000eH\u0096@¢\u0006\u0002\u0010\u000fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp83f5c3ad/p684019bc/p9aa83012;", "Lp83f5c3ad/p684019bc/p612644cb;", "tophCreateOrderRepository", "Lp83f5c3ad/pb3f20355/p8592f9a7;", "<init>", "(Lp83f5c3ad/pb3f20355/p8592f9a7;)V", "sendOrderTophAcquiring", "", "userId", "", "phone", "fio", "inn", "regionId", "", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;ILkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9aa83012 : p83f5c3ad.p684019bc.p612644cb {
    private readonly p83f5c3ad.pb3f20355.p8592f9a7 f34bf1db5;
    private readonly p83f5c3ad.pb3f20355.p8592f9a7 f3bb8308c;
    private readonly p83f5c3ad.pb3f20355.p8592f9a7 fcc1eeb1f;
    private readonly p83f5c3ad.pb3f20355.p8592f9a7 fd5988b92;
    private readonly p83f5c3ad.pb3f20355.p8592f9a7 ff45d857b;

    public p9aa83012(p83f5c3ad.pb3f20355.p8592f9a7 tophCreateOrderRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophCreateOrderRepository, "tophCreateOrderRepository");
        this.f34bf1db5 = tophCreateOrderRepository;
    }

    public override java.lang.object SendOrderTophAcquiring(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objSendOrderTophAcquiring = this.f34bf1db5.sendOrderTophAcquiring(str, str2, str3, str4, i, continuation);
        return objSendOrderTophAcquiring != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objSendOrderTophAcquiring;
    }
}

