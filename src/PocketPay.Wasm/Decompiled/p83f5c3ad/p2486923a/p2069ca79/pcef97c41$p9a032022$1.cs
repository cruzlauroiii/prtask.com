using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pcef97c41$p9a032022$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int I$0;
    int I$1;
    int f5b685c9f;
    int f993ce591;
    int fd304ba20;
    int fef6268d4;
    readonly /* synthetic */ pcef97c41 this$0;

    pcef97c41$p9a032022$1(pcef97c41 r1, Continuation<? super pcef97c41$p9a032022$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pcef97c41$p9a032022$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pcef97c41$p9a032022$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:84:0x016b -> B:73:0x012d). Please report as a decompilation issue!!! */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((17 + 4) % 4) > 0) goto L44;
    L44:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L41;
        if (r1 != 1) goto L66;
        int r12 = this.I$1;
        int r4 = this.I$0;
        ResultKt.throwOnFailure(r8);
    L3:
        pcef97c41$p9a032022$1 r82 = this;
        this.I$0 = r4;
        this.I$1 = r12;
        this.fd304ba20 = 2;
        if (DelayKt.delay(1000, r82) != r0) goto L69;
    L53:
        return r0;
    L69:
        int r83 = r4;
        r12 = r12 + 1;
    L10:
        if (r12 >= r83) goto L51;
        MutableSharedFlow r42 = pcef97c41.m708f95ff(this.this$0);
        float r5 = Boxing.boxfloat(r12);
        pcef97c41$p9a032022$1 r6 = this;
        this.I$0 = r83;
        this.I$1 = r12;
        this.fd304ba20 = 1;
        if (r42.emit(r5, r6) == r0) goto L53;
        r4 = r83;
        goto L3
    L51:
        pcef97c41.mdc7bed18(this.this$0).replaceToBalanceGone();
        return Unit.INSTANCE;
    L66:
        if (r1 != 2) goto L7;
        r12 = this.I$1;
        r4 = this.I$0;
        ResultKt.throwOnFailure(r8);
        goto L69
    L7:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L41:
        ResultKt.throwOnFailure(r8);
        r83 = 60;
        r12 = 0;
        goto L10
    }
}

