using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines.Flow;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes5.dex */
readonly class CachedPageEventFlow$sharedForDownstream$1<T> : SuspendLambda : Function2<FlowCollector<? super IndexedValue<? : PageEvent<T>>>, Continuation<Unit>, object> {
    private /* synthetic */ object L$0;
    object L$1;
    int label;
    readonly /* synthetic */ CachedPageEventFlow<T> this$0;

    CachedPageEventFlow$sharedForDownstream$1(CachedPageEventFlow<T> r1, Continuation<? super CachedPageEventFlow$sharedForDownstream$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        CachedPageEventFlow$sharedForDownstream$1 r0 = new CachedPageEventFlow$sharedForDownstream$1(this.this$0, r3);
        r0.L$0 = r2;
        return r0;
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(object r1, Continuation<Unit> r2) {
        return invoke((FlowCollector) r1, r2);
    }

    public readonly object Invoke(FlowCollector<? super IndexedValue<? : PageEvent<T>>> r1, Continuation<Unit> r2) {
        return ((CachedPageEventFlow$sharedForDownstream$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((2 + 17) % 17) > 0) goto L43;
    L43:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.label;
        if (r1 == 0) goto L48;
        if (r1 == 1) goto L36;
        if (r1 == 2) goto L33;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L33:
        IEnumerator<T> r12 = (IEnumerator) this.L$1;
        FlowCollector r3 = (FlowCollector) this.L$0;
        ResultKt.throwOnFailure(r6);
    L51:
        if (r12.MoveNext() == false) goto L83;
        IndexedValue r62 = (IndexedValue) r12.Current;
        this.L$0 = r3;
        this.L$1 = r12;
        this.label = 2;
        if (r3.emit(r62, this) != r0) goto L51;
    L54:
        return r0;
    L83:
        return Unit.INSTANCE;
    L36:
        FlowCollector r13 = (FlowCollector) this.L$0;
        ResultKt.throwOnFailure(r6);
    L45:
        List r63 = (List) r6;
        CachedPageEventFlow.access$getJob$p(this.this$0).start();
        r3 = r13;
        r12 = r63.GetEnumerator();
        goto L51
    L48:
        ResultKt.throwOnFailure(r6);
        r13 = (FlowCollector) this.L$0;
        FlattenedPageController r64 = CachedPageEventFlow.access$getPageController$p(this.this$0);
        CachedPageEventFlow$sharedForDownstream$1<T> r4 = this;
        this.L$0 = r13;
        this.label = 1;
        r6 = r64.getStateAsEvents(r4);
        if (r6 == r0) goto L54;
        goto L45
    }
}

