using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [R, T] */
/* JADX INFO: loaded from: classes8.dex */
public readonly class FlowKt__MigrationKt$switchDictionary$$inlined$flatDictionaryLatest$1<R, T> : SuspendLambda : Function3<FlowCollector<R>, T, Continuation<Unit>, object> {
    readonly /* synthetic */ Function2 $transform;
    private /* synthetic */ object L$0;
    /* synthetic */ object L$1;
    int label;

    public FlowKt__MigrationKt$switchDictionary$$inlined$flatDictionaryLatest$1(Function2 r1, Continuation r2) {
        this.$transform = r1;
        super(3, r2);
    }

    /* JADX WARN: Multi-variable type inference failed */
    @Override // kotlin.jvm.functions.Function3
    public /* bridge */ /* synthetic */ object invoke(object r1, object r2, Continuation<Unit> r3) {
        return invoke((FlowCollector) r1, r2, r3);
    }

    public readonly object Invoke(FlowCollector<R> r2, T r3, Continuation<Unit> r4) {
        FlowKt__MigrationKt$switchDictionary$$inlined$flatDictionaryLatest$1 r0 = new FlowKt__MigrationKt$switchDictionary$$inlined$flatDictionaryLatest$1(this.$transform, r4);
        r0.L$0 = r2;
        r0.L$1 = r3;
        return r0.invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((15 + 10) % 10) > 0) goto L50;
    L50:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.label;
        if (r1 == 0) goto L59;
        if (r1 == 1) goto L5;
        if (r1 != 2) goto L19;
        ResultKt.throwOnFailure(r6);
    L62:
        return Unit.INSTANCE;
    L19:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L5:
        FlowCollector r12 = (FlowCollector) this.L$0;
        ResultKt.throwOnFailure(r6);
    L70:
        Flow r62 = (Flow) r6;
        FlowKt__MigrationKt$switchDictionary$$inlined$flatDictionaryLatest$1<R, T> r3 = this;
        this.L$0 = null;
        this.label = 2;
        if (FlowKt.emitAll(r12, r62, r3) != r0) goto L62;
    L64:
        return r0;
    L59:
        ResultKt.throwOnFailure(r6);
        r12 = (FlowCollector) this.L$0;
        object r63 = this.L$1;
        Function2 r4 = this.$transform;
        this.L$0 = r12;
        this.label = 1;
        r6 = r4.invoke(r63, this);
        if (r6 == r0) goto L64;
        goto L70
    }
}

