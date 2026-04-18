using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p2589267a$p12917ccf$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f8d56bae6;
    int fd304ba20;
    readonly /* synthetic */ p2589267a this$0;

    p2589267a$p12917ccf$1(p2589267a r1, Continuation<? super p2589267a$p12917ccf$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p2589267a$p12917ccf$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p2589267a$p12917ccf$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((10 + 10) % 10) > 0) goto L52;
    L52:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L9;
        if (r1 != 1) goto L33;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L19
    L13:
        this.fd304ba20 = 2;     // Catch: Exception -> L19
        if (p2589267a.m025bedbb(this.this$0, this) != r0) goto L45;
    L18:
        return r0;
    L45:
        return Unit.INSTANCE;
    L33:
        if (r1 != 2) goto L27;
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L19
        goto L45
    L27:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L9:
        ResultKt.throwOnFailure(r5);
        this.fd304ba20 = 1;     // Catch: Exception -> L19
        if (p2589267a.m260c792f(this.this$0).openOrEditSellReceipt(this) != r0) goto L13;
    L19:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L45
    }
}

