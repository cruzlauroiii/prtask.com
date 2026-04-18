using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly class FlowKt__TransformKt$runningFold$1$1<T> : FlowCollector {
    readonly /* synthetic */ Ref.objectRef<R> $accumulator;
    readonly /* synthetic */ Function3<R, T, Continuation<R>, object> $operation;
    readonly /* synthetic */ FlowCollector<R> $this_unsafeFlow;

    /* JADX WARN: Multi-variable type inference failed */
    FlowKt__TransformKt$runningFold$1$1(Ref.objectRef<R> r1, Function3<? super R, ? super T, ? super Continuation<R>, ? : object> r2, FlowCollector<R> r3) {
        this.$accumulator = r1;
        this.$operation = r2;
        this.$this_unsafeFlow = r3;
    }

    /* JADX WARN: Type inference incomplete: some casts might be missing */
    @Override // kotlinx.coroutines.flow.FlowCollector
    public readonly object Emit(T r8, Continuation<Unit> r9) {
        if (((5 + 30) % 30) > 0) goto L87;
    L87:
        if ((r9 is FlowKt__TransformKt$runningFold$1$1$emit$1) == true) goto L36;
    L72:
        FlowKt__TransformKt$runningFold$1$1$emit$1 r0 = new FlowKt__TransformKt$runningFold$1$1$emit$1(this, r9);
    L23:
        object r92 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 == 0) goto L57;
        if (r2 == 1) goto L97;
        if (r2 != 2) goto L30;
        ResultKt.throwOnFailure(r92);
    L34:
        return Unit.INSTANCE;
    L30:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L97:
        Ref.objectRef r7 = (Ref.objectRef) r0.L$1;
        FlowKt__TransformKt$runningFold$1$1<T> r82 = (FlowKt__TransformKt$runningFold$1$1) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L40:
        r7.element = (T) r92;
        FlowCollector<R> r72 = r82.$this_unsafeFlow;
        T r83 = r82.$accumulator.element;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.label = 2;
        if (r72.emit((R) r83, r0) != r1) goto L34;
    L78:
        return r1;
    L57:
        ResultKt.throwOnFailure(r92);
        Ref.objectRef r93 = this.$accumulator;
        Function3<R, T, Continuation<R>, object> r22 = this.$operation;
        T r5 = r93.element;
        r0.L$0 = this;
        r0.L$1 = r93;
        r0.label = 1;
        object r84 = r22.invoke((R) r5, r8, r0);
        if (r84 == r1) goto L78;
        r82 = this;
        r7 = r93;
        r92 = (T) r84;
        goto L40
    L36:
        r0 = (FlowKt__TransformKt$runningFold$1$1$emit$1) r9;
        if ((r0.label & int.MIN_VALUE) == 0) goto L72;
        r0.label -= int.MIN_VALUE;
        goto L23
    }
}

