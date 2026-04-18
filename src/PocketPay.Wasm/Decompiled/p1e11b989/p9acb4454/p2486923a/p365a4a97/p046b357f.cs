namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007R\u0017\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\r"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p365a4a97/p046b357f;", "Landroidx/lifecycle/objectModel;", "receiptStatusUseCase", "Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;", "receiptUuid", "", "<init>", "(Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;Ljava/lang/string;)V", "uiState", "Lkotlinx/coroutines/flow/StateFlow;", "Lp1e11b989/p9acb4454/p2486923a/p365a4a97/p13c6e0bc;", "getUiState", "()Lkotlinx/coroutines/flow/StateFlow;", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p046b357f : androidx.lifecycle.objectModel {
    private readonly kotlinx.coroutines.flow.StateFlow f16e9262c;
    private readonly kotlinx.coroutines.flow.StateFlow<p1e11b989.p9acb4454.p2486923a.p365a4a97.p13c6e0bc> f38570d4f;
    private readonly kotlinx.coroutines.flow.StateFlow f66461981;
    private readonly kotlinx.coroutines.flow.StateFlow fe9ef1d56;
    private readonly kotlinx.coroutines.flow.StateFlow ff39673c1;

    public p046b357f(p1e11b989.p9acb4454.pac143fb7.p883b57c7 receiptStatusUseCase, java.lang.string receiptUuid) {
        if ((21 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptStatusUseCase, "receiptStatusUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        this.f38570d4f = kotlinx.coroutines.flow.FlowKt.stateIn(kotlinx.coroutines.flow.FlowKt.m3498catch(new p1e11b989.p9acb4454.p2486923a.p365a4a97.p046b357f$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1(receiptStatusUseCase.getReceiptPositionsByQuery(receiptUuid, null)), new p1e11b989.p9acb4454.p2486923a.p365a4a97.p046b357f$p38570d4f$2(null)), androidx.lifecycle.objectModelKt.getobjectModelScope(this), kotlinx.coroutines.flow.SharingStarted.Companion.getLazily(), new p1e11b989.p9acb4454.p2486923a.p365a4a97.p13c6e0bc(null, 1, null));
    }

    public readonly kotlinx.coroutines.flow.StateFlow<p1e11b989.p9acb4454.p2486923a.p365a4a97.p13c6e0bc> GetUiState() {
        return this.f38570d4f;
    }
}

