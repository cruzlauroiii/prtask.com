using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Flow.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly class FlowKt__TransformKt$runningReduce$1$1<T> : FlowCollector {
    readonly /* synthetic */ Ref.objectRef<object> $accumulator;
    readonly /* synthetic */ Function3<T, T, Continuation<T>, object> $operation;
    readonly /* synthetic */ FlowCollector<T> $this_unsafeFlow;

    /* JADX WARN: Multi-variable type inference failed */
    FlowKt__TransformKt$runningReduce$1$1(Ref.objectRef<object> r1, Function3<? super T, ? super T, ? super Continuation<T>, ? : object> r2, FlowCollector<T> r3) {
        this.$accumulator = r1;
        this.$operation = r2;
        this.$this_unsafeFlow = r3;
    }

    @Override // kotlinx.coroutines.flow.FlowCollector
    public readonly object Emit(T r8, Continuation<Unit> r9) {
        if (((29 + 22) % 22) > 0) goto L63;
    L63:
        if ((r9 is FlowKt__TransformKt$runningReduce$1$1$emit$1) == true) goto L55;
    L98:
        FlowKt__TransformKt$runningReduce$1$1$emit$1 r0 = new FlowKt__TransformKt$runningReduce$1$1$emit$1(this, r9);
    L33:
        object r92 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L71;
        ResultKt.throwOnFailure(r92);
        Ref.objectRef<object> r93 = this.$accumulator;
        if (r93.element != NullSurrogateKt.NULL) goto L54;
    L107:
        r93.element = r8;
        FlowCollector<T> r82 = this.$this_unsafeFlow;
        T r7 = this.$accumulator.element;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.label = 2;
        if (r82.emit(r7, r0) != r1) goto L52;
    L102:
        return r1;
    L52:
        return Unit.INSTANCE;
    L54:
        Function3<T, T, Continuation<T>, object> r22 = this.$operation;
        T r5 = this.$accumulator.element;
        r0.L$0 = this;
        r0.L$1 = r93;
        r0.label = 1;
        object r83 = r22.invoke(r5, r8, r0);
        if (r83 == r1) goto L102;
        FlowKt__TransformKt$runningReduce$1$1<T> r84 = this;
        Ref.objectRef<object> r72 = r93;
        r92 = r83;
    L81:
        object r6 = r92;
        r93 = r72;
        FlowKt__TransformKt$runningReduce$1$1<T> this = r84;
        r8 = (T) r6;
        goto L107
    L71:
        if (r2 == 1) goto L101;
        if (r2 != 2) goto L95;
        ResultKt.throwOnFailure(r92);
        goto L52
    L95:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L101:
        r72 = (Ref.objectRef) r0.L$1;
        r84 = (FlowKt__TransformKt$runningReduce$1$1) r0.L$0;
        ResultKt.throwOnFailure(r92);
        goto L81
    L55:
        r0 = (FlowKt__TransformKt$runningReduce$1$1$emit$1) r9;
        if ((r0.label & int.MIN_VALUE) == 0) goto L98;
        r0.label -= int.MIN_VALUE;
        goto L33
    }
}

