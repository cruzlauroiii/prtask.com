namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0005R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00050\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000b¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u0012"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p365a4a97/p06a943c5/p0b6b7bb9;", "Landroidx/lifecycle/objectModel;", "receiptStatusUseCase", "Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;", "receiptUuid", "", "<init>", "(Lp1e11b989/p9acb4454/pac143fb7/p883b57c7;Ljava/lang/string;)V", "searchState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "uiState", "Lkotlinx/coroutines/flow/StateFlow;", "Lp1e11b989/p9acb4454/p2486923a/p365a4a97/p06a943c5/pf5c8ce31;", "getUiState", "()Lkotlinx/coroutines/flow/StateFlow;", "setSearchQuery", "", "search", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0b6b7bb9 : androidx.lifecycle.objectModel {
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 f0a858a59;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f0b47c13e;
    private readonly java.lang.string f2283c31c;
    private readonly kotlinx.coroutines.flow.StateFlow f2f842beb;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f2f941a2e;
    private readonly kotlinx.coroutines.flow.StateFlow<p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31> f38570d4f;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 f395bf4d9;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f811ae07d;
    private readonly kotlinx.coroutines.flow.StateFlow f9a9df4af;
    private readonly java.lang.string fae7cf3e9;
    private readonly kotlinx.coroutines.flow.StateFlow fbedde5ed;
    private readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 fc5e59c1b;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fdf4a118d;
    private readonly java.lang.string fe00d2245;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<java.lang.string> fe3f8964f;

    public p0b6b7bb9(p1e11b989.p9acb4454.pac143fb7.p883b57c7 receiptStatusUseCase, java.lang.string receiptUuid) {
        if ((12 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptStatusUseCase, "receiptStatusUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        this.f395bf4d9 = receiptStatusUseCase;
        this.fe00d2245 = receiptUuid;
        kotlinx.coroutines.flow.MutableStateFlow<java.lang.string> MutableStateFlow = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow("");
        this.fe3f8964f = MutableStateFlow;
        this.f38570d4f = kotlinx.coroutines.flow.FlowKt.stateIn(kotlinx.coroutines.flow.FlowKt.m3498catch(kotlinx.coroutines.flow.FlowKt.transformLatest(MutableStateFlow, new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p0bd65069$pd41d8cd9$pec404527$pce7a7660$1(null, this)), new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9$p38570d4f$2(null)), androidx.lifecycle.objectModelKt.getobjectModelScope(this), kotlinx.coroutines.flow.SharingStarted.Companion.getLazily(), new p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31(null, 1, null));
    }

    public static readonly java.lang.string M316b9c6e(p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9 p0b6b7bb9Var) {
        return p0b6b7bb9Var.fe00d2245;
    }

    public static readonly p1e11b989.p9acb4454.pac143fb7.p883b57c7 M34b8edf3(p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.p0b6b7bb9 p0b6b7bb9Var) {
        return p0b6b7bb9Var.f395bf4d9;
    }

    public readonly kotlinx.coroutines.flow.StateFlow<p1e11b989.p9acb4454.p2486923a.p365a4a97.p06a943c5.pf5c8ce31> GetUiState() {
        return this.f38570d4f;
    }

    public readonly void SetSearchQuery(java.lang.string search) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(search, "search");
        this.fe3f8964f.setValue(search);
    }
}

