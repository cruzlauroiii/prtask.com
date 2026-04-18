using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P83f5c3ad.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pcef97c41$p8ea39a08$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f672b6bfa;
    int fd304ba20;
    readonly /* synthetic */ pcef97c41 this$0;

    pcef97c41$p8ea39a08$1(pcef97c41 r1, Continuation<? super pcef97c41$p8ea39a08$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pcef97c41$p8ea39a08$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pcef97c41$p8ea39a08$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((5 + 6) % 6) > 0) goto L40;
    L40:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L35;
        if (r1 == 1) goto L11;
        if (r1 != 2) goto L41;
        ResultKt.throwOnFailure(r6);
    L65:
        return Unit.INSTANCE;
    L41:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L11:
        ResultKt.throwOnFailure(r6);
    L39:
        MutableStateFlow r62 = pcef97c41.m724546ab(this.this$0);
        p0890727b r12 = p0890727b.f4197ffec;
        pcef97c41$p8ea39a08$1 r3 = this;
        this.fd304ba20 = 2;
        if (r62.emit(r12, r3) != r0) goto L65;
    L47:
        return r0;
    L35:
        ResultKt.throwOnFailure(r6);
        pcef97c41$p8ea39a08$1 r63 = this;
        this.fd304ba20 = 1;
        if (DelayKt.delay(1000, r63) == r0) goto L47;
        goto L47
    }
}

