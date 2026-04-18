using Java.Util.Concurrent;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.P2069ca79;
using P83f5c3ad.P07214c67;
using P83f5c3ad.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pcef97c41$p3bbf95c6$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pdabbee7a $balanceTransaction;
    int f0e08e979;
    int f4c3d4721;
    int f9075b902;
    int fd304ba20;
    readonly /* synthetic */ pcef97c41 this$0;

    pcef97c41$p3bbf95c6$1(pcef97c41 r1, pdabbee7a r2, Continuation<? super pcef97c41$p3bbf95c6$1> r3) {
        this.this$0 = r1;
        this.$balanceTransaction = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pcef97c41$p3bbf95c6$1(this.this$0, this.$balanceTransaction, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pcef97c41$p3bbf95c6$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((25 + 27) % 27) > 0) goto L7;
    L7:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L29;
        if (r1 != 1) goto L16;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L37
    L33:
        p1ceed351 r12 = pcef97c41.mdc7bed18(this.this$0);     // Catch: Exception -> L37
        r12.replaceToBalanceSuccess((pbc0ca418) r6);     // Catch: Exception -> L37
    L53:
        return Unit.INSTANCE;
    L16:
        if (r1 != 2) goto L41;
        ResultKt.throwOnFailure(r6);
        goto L53
    L41:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L29:
        ResultKt.throwOnFailure(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L37
        r6 = pcef97c41.m63317c84(this.this$0).getBalance(this.$balanceTransaction, this);     // Catch: Exception -> L37
        if (r6 != r0) goto L33;
    L9:
        return r0;
    L37:
        th = move-exception;
        if ((th is CancellationException) == true) goto L53;
        MutableSharedFlow r13 = pcef97c41.mad452160(this.this$0);
        pcef97c41$p3bbf95c6$1 r3 = this;
        this.fd304ba20 = 2;
        if (r13.emit(th, r3) == r0) goto L9;
        goto L9
    }
}

