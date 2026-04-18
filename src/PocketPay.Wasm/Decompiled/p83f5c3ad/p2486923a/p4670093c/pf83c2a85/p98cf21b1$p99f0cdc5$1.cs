using Com.Google.Firebase.Crashlytics;
using Java.Util.Concurrent;
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
readonly class p98cf21b1$p99f0cdc5$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p0e6dda02 $tophPayback;
    int fd304ba20;
    int ff99a0aae;
    readonly /* synthetic */ p98cf21b1 this$0;

    p98cf21b1$p99f0cdc5$1(p98cf21b1 r1, p0e6dda02 r2, Continuation<? super p98cf21b1$p99f0cdc5$1> r3) {
        this.this$0 = r1;
        this.$tophPayback = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p98cf21b1$p99f0cdc5$1(this.this$0, this.$tophPayback, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p98cf21b1$p99f0cdc5$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((20 + 29) % 29) > 0) goto L41;
    L41:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L19;
        ResultKt.throwOnFailure(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L47
        r6 = p98cf21b1.m32f9f0c1(this.this$0).startContactless(this.$tophPayback, this);     // Catch: Exception -> L47
        if (r6 == r0) goto L3;
    L15:
        p0e6dda02 r62 = (p0e6dda02) r6;     // Catch: Exception -> L47
        p98cf21b1.m0fa733d1(this.this$0, r62.getTransaction());     // Catch: Exception -> L47
        p98cf21b1.mfe221994(this.this$0, r62);     // Catch: Exception -> L47
    L51:
        return Unit.INSTANCE;
    L3:
        return r0;
    L19:
        if (r1 != 1) goto L63;
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L47
        goto L15
    L63:
        if (r1 != 2) goto L7;
        ResultKt.throwOnFailure(r6);
        goto L51
    L7:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L47:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        if ((th is CancellationException) == true) goto L51;
        MutableSharedFlow r12 = p98cf21b1.mad452160(this.this$0);
        p98cf21b1$p99f0cdc5$1 r3 = this;
        this.fd304ba20 = 2;
        if (r12.emit(th, r3) == r0) goto L3;
        goto L3
    }
}

