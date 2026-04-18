using Androidx.Paging;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines.Flow;
using Kotlinx.Coroutines.Sync;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [Value] */
/* JADX INFO: loaded from: classes5.dex */
readonly class PageFetcherSnapshot$pageEventFlow$2<Value> : SuspendLambda : Function2<FlowCollector<? super PageEvent<Value>>, Continuation<Unit>, object> {
    private /* synthetic */ object L$0;
    object L$1;
    object L$2;
    int label;
    readonly /* synthetic */ PageFetcherSnapshot<Key, Value> this$0;

    PageFetcherSnapshot$pageEventFlow$2(PageFetcherSnapshot<Key, Value> r1, Continuation<? super PageFetcherSnapshot$pageEventFlow$2> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        PageFetcherSnapshot$pageEventFlow$2 r0 = new PageFetcherSnapshot$pageEventFlow$2(this.this$0, r3);
        r0.L$0 = r2;
        return r0;
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(object r1, Continuation<Unit> r2) {
        return invoke((FlowCollector) r1, r2);
    }

    public readonly object Invoke(FlowCollector<? super PageEvent<Value>> r1, Continuation<Unit> r2) {
        return ((PageFetcherSnapshot$pageEventFlow$2) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((16 + 11) % 11) > 0) goto L88;
    L88:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.label;
        if (r1 == 0) goto L68;
        if (r1 == 1) goto L7;
        if (r1 != 2) goto L48;
        ResultKt.throwOnFailure(r8);
    L89:
        return Unit.INSTANCE;
    L48:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L7:
        FlowCollector r12 = (FlowCollector) this.L$2;
        Mutex r2 = (Mutex) this.L$1;
        PageFetcherSnapshotState.Holder r5 = (PageFetcherSnapshotState.Holder) this.L$0;
        ResultKt.throwOnFailure(r8);
    L92:
        LoadStates r82 = PageFetcherSnapshotState.Holder.access$getState$p(r5).getSourceLoadStates$paging_common_release().snapshot();     // Catch: Exception -> L90
        r2.unlock(null);
        PageEvent.LoadStateUpdate r22 = new PageEvent.LoadStateUpdate(r82, null, 2, null);
        PageFetcherSnapshot$pageEventFlow$2<Value> r83 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.L$2 = null;
        this.label = 2;
        if (r12.emit(r22, r83) != r0) goto L89;
    L84:
        return r0;
    L90:
        th = move-exception;
        r2.unlock(null);
        throw th;
    L68:
        ResultKt.throwOnFailure(r8);
        r12 = (FlowCollector) this.L$0;
        r5 = PageFetcherSnapshot.access$getStateHolder$p(this.this$0);
        Mutex r84 = PageFetcherSnapshotState.Holder.access$getLock$p(r5);
        PageFetcherSnapshot$pageEventFlow$2<Value> r6 = this;
        this.L$0 = r5;
        this.L$1 = r84;
        this.L$2 = r12;
        this.label = 1;
        if (r84.lock(null, r6) == r0) goto L84;
        r2 = r84;
        goto L92
    }
}

