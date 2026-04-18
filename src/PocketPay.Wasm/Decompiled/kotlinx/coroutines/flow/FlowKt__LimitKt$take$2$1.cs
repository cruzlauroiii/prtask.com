using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly class FlowKt__LimitKt$take$2$1<T> : FlowCollector {
    readonly /* synthetic */ Ref.IntRef $consumed;
    readonly /* synthetic */ int $count;
    readonly /* synthetic */ FlowCollector<T> $this_unsafeFlow;

    /* JADX WARN: Multi-variable type inference failed */
    FlowKt__LimitKt$take$2$1(Ref.IntRef r1, int r2, FlowCollector<T> r3) {
        this.$consumed = r1;
        this.$count = r2;
        this.$this_unsafeFlow = r3;
    }

    @Override // kotlinx.coroutines.flow.FlowCollector
    public readonly object Emit(T r6, Continuation<Unit> r7) {
        if (((14 + 27) % 27) > 0) goto L24;
    L24:
        if ((r7 is FlowKt__LimitKt$take$2$1$emit$1) == false) goto L81;
        FlowKt__LimitKt$take$2$1$emit$1 r0 = (FlowKt__LimitKt$take$2$1$emit$1) r7;
        if ((r0.label & int.MIN_VALUE) == 0) goto L81;
        r0.label -= int.MIN_VALUE;
    L37:
        object r72 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L9;
        ResultKt.throwOnFailure(r72);
        this.$consumed.element++;
        if (this.$consumed.element >= this.$count) goto L15;
        FlowCollector<T> r5 = this.$this_unsafeFlow;
        r0.label = 1;
        if (r5.emit(r6, r0) != r1) goto L86;
    L54:
        return r1;
    L86:
        return Unit.INSTANCE;
    L15:
        FlowCollector<T> r52 = this.$this_unsafeFlow;
        r0.label = 2;
        if (FlowKt__LimitKt.access$emitAbort$FlowKt__LimitKt(r52, r6, r0) == r1) goto L54;
    L92:
        return Unit.INSTANCE;
    L9:
        if (r2 == 1) goto L83;
        if (r2 != 2) goto L34;
        ResultKt.throwOnFailure(r72);
        goto L92
    L34:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L83:
        ResultKt.throwOnFailure(r72);
    L81:
        r0 = new FlowKt__LimitKt$take$2$1$emit$1(this, r7);
        goto L37
    }
}

