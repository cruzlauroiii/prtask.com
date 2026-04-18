namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0006\bf\u0018\u00002\u00020\u0001J\u000e\u0010\u0002\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0006\u001a\u00020\u0007H¦@¢\u0006\u0002\u0010\u0004J\u001c\u0010\b\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\n0\t2\u0006\u0010\f\u001a\u00020\rH&J\u0016\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u000f0\t2\u0006\u0010\u0010\u001a\u00020\u0011H&J&\u0010\u0012\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00140\u00130\t2\u0006\u0010\u0015\u001a\u00020\u00112\b\u0010\u0016\u001a\u0004\u0018\u00010\u0011H&J\u0016\u0010\u0017\u001a\u00020\u00072\u0006\u0010\u0018\u001a\u00020\u0011H¦@¢\u0006\u0002\u0010\u0019¨\u0006\u001a"}, d2 = {"Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;", "", "loadReceiptsStatus", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateReceiptsStatus", "hasErrorReceipts", "", "getPagedReceipts", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/paging/PagingData;", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305;", "filter", "Lp1e11b989/p9acb4454/p07214c67/pc77da2af;", "getReceiptByUuid", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "uuid", "", "getReceiptPositionsByQuery", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "receiptUuid", "query", "isFullPaybackReceipt", "paybackReceiptUuid", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-receipt-status-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p883b57c7 {
    kotlinx.coroutines.flow.Flow<androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>> getPagedReceipts(p1e11b989.p9acb4454.p07214c67.pc77da2af filter);

    kotlinx.coroutines.flow.Flow<pad5f82e8.p07214c67.p1e11b989.p9ded6185> getReceiptByUuid(java.lang.string uuid);

    kotlinx.coroutines.flow.Flow<java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> getReceiptPositionsByQuery(java.lang.string receiptUuid, java.lang.string query);

    java.lang.object hasErrorReceipts(kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object isFullPaybackReceipt(java.lang.string str, kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object loadReceiptsStatus(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object updateReceiptsStatus(kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

