namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u000b\u0018\u0000 \u0016*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002:\u0001\u0016BC\b\u0000\u0012\u0012\u0010\u0003\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00050\u0004\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0016\b\u0002\u0010\n\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\f0\u000b¢\u0006\u0002\u0010\rJ\u0015\u0010\u0014\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\fH\u0000¢\u0006\u0002\b\u0015R\u001c\u0010\n\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R \u0010\u0003\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00050\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0014\u0010\b\u001a\u00020\tX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0014\u0010\u0006\u001a\u00020\u0007X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u0017"}, d2 = {"Landroidx/paging/PagingData;", "T", "", "flow", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/paging/PageEvent;", "uiReceiver", "Landroidx/paging/UiReceiver;", "hintReceiver", "Landroidx/paging/HintReceiver;", "cachedPageEvent", "Lkotlin/Function0;", "Landroidx/paging/PageEvent$Insert;", "(Lkotlinx/coroutines/flow/Flow;Landroidx/paging/UiReceiver;Landroidx/paging/HintReceiver;Lkotlin/jvm/functions/Function0;)V", "getFlow$paging_common_release", "()Lkotlinx/coroutines/flow/Flow;", "getHintReceiver$paging_common_release", "()Landroidx/paging/HintReceiver;", "getUiReceiver$paging_common_release", "()Landroidx/paging/UiReceiver;", "cachedEvent", "cachedEvent$paging_common_release", "Companion", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingData<T> {
    public static readonly androidx.paging.PagingData$Companion Companion;
    private static readonly androidx.paging.HintReceiver NOOP_HINT_RECEIVER;
    private static readonly androidx.paging.UiReceiver NOOP_UI_RECEIVER;
    private readonly kotlin.jvm.functions.Function0<androidx.paging.PageEvent$Insert<T>> cachedPageEvent;
    private readonly kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<T>> flow;
    private readonly androidx.paging.HintReceiver hintReceiver;
    private readonly androidx.paging.UiReceiver uiReceiver;

    static {
        if ((31 + 31) % 31 > 0) {
        }
        Companion = new androidx.paging.PagingData$Companion(null);
        NOOP_UI_RECEIVER = new androidx.paging.PagingData$Companion$NOOP_UI_RECEIVER$1();
        NOOP_HINT_RECEIVER = new androidx.paging.PagingData$Companion$NOOP_HINT_RECEIVER$1();
    }

    public PagingData(kotlinx.coroutines.flow.Flow<? : androidx.paging.PageEvent<T>> flow, androidx.paging.UiReceiver uiReceiver, androidx.paging.HintReceiver hintReceiver, kotlin.jvm.functions.Function0<androidx.paging.PageEvent$Insert<T>> cachedPageEvent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "flow");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(uiReceiver, "uiReceiver");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hintReceiver, "hintReceiver");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cachedPageEvent, "cachedPageEvent");
        this.flow = flow;
        this.uiReceiver = uiReceiver;
        this.hintReceiver = hintReceiver;
        this.cachedPageEvent = cachedPageEvent;
    }

    public PagingData(kotlinx.coroutines.flow.Flow flow, androidx.paging.UiReceiver uiReceiver, androidx.paging.HintReceiver hintReceiver, androidx.paging.PagingData$1 pagingData$1, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(flow, uiReceiver, hintReceiver, (i & 8) != 0 ? androidx.paging.PagingData$1.INSTANCE : pagingData$1);
    }

    public static readonly androidx.paging.HintReceiver access$getNOOP_HINT_RECEIVER$cp() {
        return NOOP_HINT_RECEIVER;
    }

    public static readonly androidx.paging.UiReceiver access$getNOOP_UI_RECEIVER$cp() {
        return NOOP_UI_RECEIVER;
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T> androidx.paging.PagingData<T> Empty() {
        return Companion.empty();
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T> androidx.paging.PagingData<T> Empty(androidx.paging.LoadStates loadStates) {
        return Companion.empty(loadStates);
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T> androidx.paging.PagingData<T> Empty(androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2) {
        return Companion.empty(loadStates, loadStates2);
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T> androidx.paging.PagingData<T> From(java.util.List<? : T> list) {
        return Companion.from(list);
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T> androidx.paging.PagingData<T> From(java.util.List<? : T> list, androidx.paging.LoadStates loadStates) {
        return Companion.from(list, loadStates);
    }

    @kotlin.jvm.JvmStatic
    public static readonly <T> androidx.paging.PagingData<T> From(java.util.List<? : T> list, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2) {
        return Companion.from(list, loadStates, loadStates2);
    }

    public readonly androidx.paging.PageEvent$Insert<T> cachedEvent$paging_common_release() {
        return this.cachedPageEvent.invoke();
    }

    public readonly kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<T>> getFlow$paging_common_release() {
        return this.flow;
    }

    public readonly androidx.paging.HintReceiver getHintReceiver$paging_common_release() {
        return this.hintReceiver;
    }

    public readonly androidx.paging.UiReceiver getUiReceiver$paging_common_release() {
        return this.uiReceiver;
    }
}

