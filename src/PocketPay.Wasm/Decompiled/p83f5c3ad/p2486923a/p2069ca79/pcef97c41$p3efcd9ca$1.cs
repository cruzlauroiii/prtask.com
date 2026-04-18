using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pcef97c41$p3efcd9ca$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f148e2111;
    int f2157c503;
    int fd304ba20;
    readonly /* synthetic */ pcef97c41 this$0;

    pcef97c41$p3efcd9ca$1(pcef97c41 r1, Continuation<? super pcef97c41$p3efcd9ca$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pcef97c41$p3efcd9ca$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pcef97c41$p3efcd9ca$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((31 + 4) % 4) > 0) goto L27;
    L27:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L11;
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L9
        if (pcef97c41.m2ca4942e(this.this$0).runAttestation(this) == r0) goto L64;
    L58:
        this.this$0.startBalanceInquiry(true);     // Catch: Exception -> L9
    L18:
        return Unit.INSTANCE;
    L64:
        return r0;
    L11:
        if (r1 != 1) goto L34;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L9
        goto L58
    L34:
        if (r1 != 2) goto L49;
        ResultKt.throwOnFailure(r5);
        goto L18
    L49:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L9:
        e = move-exception;
        MutableSharedFlow r12 = pcef97c41.mad452160(this.this$0);
        pcef97c41$p3efcd9ca$1 r3 = this;
        this.fd304ba20 = 2;
        if (r12.emit(e, r3) == r0) goto L64;
        goto L64
    }
}

