namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0006\bf\u0018\u00002\u00020\u0001J(\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\u0006\u0010\u0005\u001a\u00020\u00062\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\bH¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u0004H¦@¢\u0006\u0002\u0010\rJ\u0016\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\u000f\u001a\u00020\u0006H¦@¢\u0006\u0002\u0010\u0010¨\u0006\u0011"}, d2 = {"Lpe0bd4e89/pdd56421b/pb3f20355/p899245fc;", "", "getAdvanceReceipts", "", "Lpe0bd4e89/pdd56421b/p07214c67/p7894f0aa;", "cashierUuid", "", "filter", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;", "(Ljava/lang/string;Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "saveAdvanceReceipt", "", "advanceReceipt", "(Lpe0bd4e89/pdd56421b/p07214c67/p7894f0aa;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "deleteAdvanceReceipt", "uuid", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-advance-receipts-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p899245fc {
    java.lang.object deleteAdvanceReceipt(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getAdvanceReceipts(java.lang.string str, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar, kotlin.coroutines.Continuation<? super java.util.List<pe0bd4e89.pdd56421b.p07214c67.p7894f0aa>> continuation);

    java.lang.object saveAdvanceReceipt(pe0bd4e89.pdd56421b.p07214c67.p7894f0aa p7894f0aaVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

