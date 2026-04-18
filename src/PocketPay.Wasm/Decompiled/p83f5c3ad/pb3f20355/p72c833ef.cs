namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006J\u000e\u0010\u0007\u001a\u00020\bH¦@¢\u0006\u0002\u0010\tJ\u000e\u0010\n\u001a\u00020\u000bH¦@¢\u0006\u0002\u0010\tJ\u001e\u0010\f\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H¦@¢\u0006\u0002\u0010\u0011¨\u0006\u0012"}, d2 = {"Lp83f5c3ad/pb3f20355/p72c833ef;", "", "createQR", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/p150f1761;", "amount", "", "(JLkotlin/coroutines/Continuation;)Ljava/lang/object;", "checkStatus", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p9efab239/p407482fe/pcd9de119/p06660b7d;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "confirm", "", "refund", "total", "Ljava/math/decimal;", "referenceId", "", "(Ljava/math/decimal;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p72c833ef {
    java.lang.object checkStatus(kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p9efab239.p407482fe.pcd9de119.p06660b7d> continuation);

    java.lang.object confirm(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object createQR(long j, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p150f1761> continuation);

    java.lang.object refund(java.math.decimal bigDecimal, java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

