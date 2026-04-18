namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\bf\u0018\u00002\u00020\u0001J\u001c\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\u0006\u0010\u0005\u001a\u00020\u0006H¦@¢\u0006\u0002\u0010\u0007J\u001c\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t2\u0006\u0010\u000b\u001a\u00020\u0004H¦@¢\u0006\u0002\u0010\fJ\u001c\u0010\r\u001a\b\u0012\u0004\u0012\u00020\n0\t2\u0006\u0010\u000e\u001a\u00020\u0006H¦@¢\u0006\u0002\u0010\u0007¨\u0006\u000f"}, d2 = {"Lpe0bd4e89/pdd56421b/pb3f20355/p4891a1a9;", "", "getAdvanceReceiptsFromRemote", "", "Lpe0bd4e89/pdd56421b/p07214c67/p7894f0aa;", "cashierUuid", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "saveAdvanceReceipt", "Lretrofit2/Response;", "Lp7ddcfee1/p42c567ea;", "advanceReceipt", "(Lpe0bd4e89/pdd56421b/p07214c67/p7894f0aa;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "deleteAdvanceReceipt", "uuid", "feature-advance-receipts-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p4891a1a9 {
    java.lang.object deleteAdvanceReceipt(java.lang.string str, kotlin.coroutines.Continuation<? super retrofit2.Response<p7ddcfee1.p42c567ea>> continuation);

    java.lang.object getAdvanceReceiptsFromRemote(java.lang.string str, kotlin.coroutines.Continuation<? super java.util.List<pe0bd4e89.pdd56421b.p07214c67.p7894f0aa>> continuation);

    java.lang.object saveAdvanceReceipt(pe0bd4e89.pdd56421b.p07214c67.p7894f0aa p7894f0aaVar, kotlin.coroutines.Continuation<? super retrofit2.Response<p7ddcfee1.p42c567ea>> continuation);
}

