using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p98cf21b1$pdcc8a541$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f3c1ff631;
    int f5f51e986;
    int fb6d922f5;
    int fbeb08bcf;
    int fd304ba20;
    readonly /* synthetic */ p98cf21b1 this$0;

    p98cf21b1$pdcc8a541$1(p98cf21b1 r1, Continuation<? super p98cf21b1$pdcc8a541$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p98cf21b1$pdcc8a541$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p98cf21b1$pdcc8a541$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((9 + 23) % 23) > 0) goto L38;
    L38:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L12;
        if (r1 != 1) goto L53;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L62
    L16:
        this.this$0.initPayback();     // Catch: Exception -> L62
    L6:
        return Unit.INSTANCE;
    L53:
        if (r1 != 2) goto L56;
        ResultKt.throwOnFailure(r5);
        goto L6
    L56:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L12:
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L62
        if (p98cf21b1.m2ca4942e(this.this$0).runAttestation(this) != r0) goto L16;
    L47:
        return r0;
    L62:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        MutableSharedFlow r12 = p98cf21b1.mad452160(this.this$0);
        p98cf21b1$pdcc8a541$1 r3 = this;
        this.fd304ba20 = 2;
        if (r12.emit(e, r3) == r0) goto L47;
        goto L47
    }
}

