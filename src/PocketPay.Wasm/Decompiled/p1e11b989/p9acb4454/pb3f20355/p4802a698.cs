namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H¦@¢\u0006\u0002\u0010\u0005J\u001c\u0010\u0006\u001a\u00020\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u0003H¦@¢\u0006\u0002\u0010\nJ\u000e\u0010\u000b\u001a\u00020\fH¦@¢\u0006\u0002\u0010\u0005J\u0016\u0010\r\u001a\u00020\f2\u0006\u0010\u000e\u001a\u00020\u0004H¦@¢\u0006\u0002\u0010\u000fJ\u001c\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00130\u00120\u00112\u0006\u0010\u0014\u001a\u00020\u0015H&J\u0016\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00130\u00112\u0006\u0010\u0017\u001a\u00020\u0004H&¨\u0006\u0018"}, d2 = {"Lp1e11b989/p9acb4454/pb3f20355/p4802a698;", "", "getNotSuccessReceiptsUuids", "", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateReceiptsStatus", "", "fiscalizationReceipts", "Lpad5f82e8/p07214c67/p1e11b989/pcbd86297;", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "hasErrorReceipts", "", "isFullPaybackReceipt", "paybackReceiptUuid", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getPagedReceipts", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/paging/PagingData;", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "filter", "Lp1e11b989/p9acb4454/p07214c67/pc77da2af;", "getReceiptByUuid", "uuid", "feature-receipt-status-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p4802a698 {
    java.lang.object getNotSuccessReceiptsUuids(kotlin.coroutines.Continuation<? super java.util.List<java.lang.string>> continuation);

    kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p9ded6185>> getPagedReceipts(p1e11b989.p9acb4454.p07214c67.pc77da2af filter);

    kotlinx.coroutines.flow.Flow<pad5f82e8.p07214c67.p1e11b989.p9ded6185> getReceiptByUuid(java.lang.string uuid);

    java.lang.object hasErrorReceipts(kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object isFullPaybackReceipt(java.lang.string str, kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object updateReceiptsStatus(java.util.List<pad5f82e8.p07214c67.p1e11b989.pcbd86297> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

