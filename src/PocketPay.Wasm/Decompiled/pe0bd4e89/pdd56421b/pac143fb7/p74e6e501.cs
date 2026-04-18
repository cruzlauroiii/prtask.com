namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\bf\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0006J(\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b2\u0006\u0010\n\u001a\u00020\u00052\n\b\u0002\u0010\u000b\u001a\u0004\u0018\u00010\fH¦@¢\u0006\u0002\u0010\rJ&\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\t0\b2\u0006\u0010\n\u001a\u00020\u00052\b\u0010\u000f\u001a\u0004\u0018\u00010\u0005H¦@¢\u0006\u0002\u0010\u0010J\u001e\u0010\u0011\u001a\u00020\u00052\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\n\u001a\u00020\u0005H¦@¢\u0006\u0002\u0010\u0014J\b\u0010\u0015\u001a\u00020\u0003H&J\b\u0010\u0016\u001a\u00020\u0017H&¨\u0006\u0018"}, d2 = {"Lpe0bd4e89/pdd56421b/pac143fb7/p74e6e501;", "", "deleteAdvanceReceipt", "", "uuid", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getAdvanceReceipts", "", "Lpe0bd4e89/pdd56421b/p07214c67/p3a208855;", "cashierUuid", "filter", "Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;", "(Ljava/lang/string;Lpad5f82e8/p07214c67/p9efab239/pb2c97ae4/pd7778d0c;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getAdvanceReceiptsByQuery", "query", "(Ljava/lang/string;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "saveAdvanceReceipt", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;", "(Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "setAnimationPreviewIsShown", "isAnimationPreviewShown", "", "feature-advance-receipts-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p74e6e501 {
    java.lang.object deleteAdvanceReceipt(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object getAdvanceReceipts(java.lang.string str, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar, kotlin.coroutines.Continuation<? super java.util.List<pe0bd4e89.pdd56421b.p07214c67.p3a208855>> continuation);

    java.lang.object getAdvanceReceiptsByQuery(java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation<? super java.util.List<pe0bd4e89.pdd56421b.p07214c67.p3a208855>> continuation);

    bool isAnimationPreviewShown();

    java.lang.object saveAdvanceReceipt(pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation);

    void setAnimationPreviewIsShown();
}

