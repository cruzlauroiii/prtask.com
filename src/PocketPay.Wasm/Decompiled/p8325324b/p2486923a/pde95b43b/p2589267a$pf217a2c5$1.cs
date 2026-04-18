using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p2589267a$pf217a2c5$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f529f8209;
    int fb7c41347;
    int fd304ba20;
    readonly /* synthetic */ p2589267a this$0;

    p2589267a$pf217a2c5$1(p2589267a r1, Continuation<? super p2589267a$pf217a2c5$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p2589267a$pf217a2c5$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p2589267a$pf217a2c5$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((10 + 30) % 30) > 0) goto L5;
    L5:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L50;
        if (r1 != 1) goto L17;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L46
    L54:
        this.fd304ba20 = 2;     // Catch: Exception -> L46
        if (p2589267a.m025bedbb(this.this$0, this) != r0) goto L42;
    L45:
        return r0;
    L42:
        return Unit.INSTANCE;
    L17:
        if (r1 != 2) goto L35;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L46
        goto L42
    L35:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L50:
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L46
        if (p2589267a.m260c792f(this.this$0).removeAllPositionsFromReceipt(this) != r0) goto L54;
    L46:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L42
    }
}

