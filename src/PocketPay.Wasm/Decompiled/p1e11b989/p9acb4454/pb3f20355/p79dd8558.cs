namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\"\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\n0\u0007H\u0096@¢\u0006\u0002\u0010\u000bJj\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00102\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00132\u000e\u0010\u0015\u001a\n\u0012\u0004\u0012\u00020\n\u0018\u00010\u00072\u000e\u0010\u0016\u001a\n\u0012\u0004\u0012\u00020\n\u0018\u00010\u00072\b\u0010\u0017\u001a\u0004\u0018\u00010\n2\b\u0010\u0018\u001a\u0004\u0018\u00010\nH\u0096@¢\u0006\u0002\u0010\u0019R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lp1e11b989/p9acb4454/pb3f20355/p79dd8558;", "Lp1e11b989/p9acb4454/pb3f20355/p5926f3a5;", "receiptStatusApi", "Lp1e11b989/p9acb4454/p8a5da52e/pfc4f327e;", "<init>", "(Lp1e11b989/p9acb4454/p8a5da52e/pfc4f327e;)V", "getReceiptsStatus", "", "Lpad5f82e8/p07214c67/p1e11b989/pcbd86297;", "receiptUuids", "", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getReceipts", "Lp1e11b989/p9acb4454/p07214c67/pf7a6e566;", "userId", "size", "", "page", "dateStart", "", "dateEnd", "paymentTypes", "operationTypes", "shopId", "staffId", "(Ljava/lang/string;IIJJLjava/util/List;Ljava/util/List;Ljava/lang/string;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p79dd8558 : p1e11b989.p9acb4454.pb3f20355.p5926f3a5 {
    private readonly p1e11b989.p9acb4454.p8a5da52e.pfc4f327e f084c9fad;
    private readonly p1e11b989.p9acb4454.p8a5da52e.pfc4f327e fab9c8018;
    private readonly p1e11b989.p9acb4454.p8a5da52e.pfc4f327e fd3a22299;
    private readonly p1e11b989.p9acb4454.p8a5da52e.pfc4f327e ff5378e9d;

    public p79dd8558(p1e11b989.p9acb4454.p8a5da52e.pfc4f327e receiptStatusApi) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptStatusApi, "receiptStatusApi");
        this.fab9c8018 = receiptStatusApi;
    }

    public override java.lang.object GetReceipts(java.lang.string str, int i, int i2, long j, long j2, java.util.List<java.lang.string> list, java.util.List<java.lang.string> list2, java.lang.string str2, java.lang.string str3, kotlin.coroutines.Continuation<p1e11b989.p9acb4454.p07214c67.pf7a6e566> continuation) throws java.lang.Exception {
        p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1 p79dd8558_pbf619c3e_1;
        p1e11b989.p9acb4454.p07214c67.pf7a6e566 pf7a6e566Var;
        if ((17 + 32) % 32 > 0) {
        }
        if (continuation is p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1) {
            p79dd8558_pbf619c3e_1 = (p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1) continuation;
            if ((p79dd8558_pbf619c3e_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p79dd8558_pbf619c3e_1 = new p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1(this, continuation);
            } else {
                p79dd8558_pbf619c3e_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p79dd8558_pbf619c3e_1 = new p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1(this, continuation);
        }
        p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1 p79dd8558_pbf619c3e_12 = p79dd8558_pbf619c3e_1;
        java.lang.object receipts = p79dd8558_pbf619c3e_12.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i3 = p79dd8558_pbf619c3e_12.fd304ba20;
        if (i3 == 0) {
            kotlin.ResultKt.throwOnFailure(receipts);
            p1e11b989.p9acb4454.p8a5da52e.pfc4f327e pfc4f327eVar = this.fab9c8018;
            p79dd8558_pbf619c3e_12.fd304ba20 = 1;
            receipts = pfc4f327eVar.getReceipts(str, i, i2, j, j2, list, list2, str2, str3, p79dd8558_pbf619c3e_12);
            if (receipts == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i3 != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(receipts);
        }
        retrofit2.Response response = (retrofit2.Response) receipts;
        if (response.isSuccessful() && (pf7a6e566Var = (p1e11b989.p9acb4454.p07214c67.pf7a6e566) response.body()) is not null) {
            return pf7a6e566Var;
        }
        throw new java.lang.Exception("Error while loading receipts");
    }

    public override java.lang.object GetReceiptsStatus(java.util.List<java.lang.string> list, kotlin.coroutines.Continuation<? super java.util.List<pad5f82e8.p07214c67.p1e11b989.pcbd86297>> continuation) {
        return kotlin.collections.ICollectionsKt.emptyList();
    }
}

