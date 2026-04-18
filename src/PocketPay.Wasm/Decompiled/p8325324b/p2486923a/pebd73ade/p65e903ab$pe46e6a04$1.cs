using Com.Google.Firebase.Crashlytics;
using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P2b3583e6.P263e3cef;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p65e903ab$pe46e6a04$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pb5374042 $paymentTypeobjectState;
    int fd304ba20;
    int fd401d31c;
    readonly /* synthetic */ p65e903ab this$0;

    p65e903ab$pe46e6a04$1(pb5374042 r1, p65e903ab r2, Continuation<? super p65e903ab$pe46e6a04$1> r3) {
        this.$paymentTypeobjectState = r1;
        this.this$0 = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p65e903ab$pe46e6a04$1(this.$paymentTypeobjectState, this.this$0, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p65e903ab$pe46e6a04$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((4 + 21) % 21) > 0) goto L40;
    L40:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        switch(this.fd304ba20) {
            case 0: goto L42;
            case 1: goto L28;
            case 2: goto L27;
            case 3: goto L26;
            case 4: goto L25;
            case 5: goto L24;
            case 6: goto L23;
            default: goto L22;
        };
    L23:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L13
    L64:
        if (p517b902b.m29a3256d((p9ded6185) r6).compareTo(decimal.ONE) >= 0) goto L66;
        p65e903ab.m0e05a866(this.this$0).postValue(Boxing.boxbool(true));     // Catch: Exception -> L13
    L68:
        return Unit.INSTANCE;
    L66:
        p65e903ab.mbb00931f(this.this$0, this.$paymentTypeobjectState);     // Catch: Exception -> L13
        goto L68
    L24:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L13
    L60:
        this.fd304ba20 = 6;     // Catch: Exception -> L13
        r6 = p65e903ab.m260c792f(this.this$0).getCurrentSellReceipt(this);     // Catch: Exception -> L13
        if (r6 != r0) goto L64;
    L62:
        return r0;
    L25:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L13
    L57:
        this.fd304ba20 = 5;     // Catch: Exception -> L13
        if (p65e903ab.m260c792f(this.this$0).setPaymentPlace(p65e903ab.ma82a18e4(this.this$0).getPaymentPlace(), this) != r0) goto L60;
    L26:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L13
    L54:
        this.fd304ba20 = 4;     // Catch: Exception -> L13
        if (p65e903ab.m260c792f(this.this$0).setPaymentAddress(this.this$0.getPaymentAddress(), this) != r0) goto L57;
    L27:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L13
    L51:
        this.fd304ba20 = 3;     // Catch: Exception -> L13
        if (p65e903ab.m38ab72de(this.this$0, this) != r0) goto L54;
    L28:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L13
    L48:
        this.fd304ba20 = 2;     // Catch: Exception -> L13
        if (p65e903ab.m260c792f(this.this$0).openSinglePaymentIfNeeded(this) != r0) goto L51;
    L42:
        ResultKt.throwOnFailure(r6);
        p8c261c90 r62 = pb5374042.f910eef8c.getPaymentType(this.$paymentTypeobjectState);     // Catch: Exception -> L13
        if (r62 is null) goto L51;
        this.fd304ba20 = 1;     // Catch: Exception -> L13
        if (p65e903ab.m260c792f(this.this$0).setPaymentType(r62, this) != r0) goto L48;
    L22:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L13:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L68
    }
}

