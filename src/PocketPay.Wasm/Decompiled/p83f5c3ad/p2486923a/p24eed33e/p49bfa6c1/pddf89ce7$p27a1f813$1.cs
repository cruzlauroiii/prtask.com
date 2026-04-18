using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P83f5c3ad.P684019bc;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pddf89ce7$p27a1f813$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    int f2c93b43e;
    int fd304ba20;
    readonly /* synthetic */ pddf89ce7 this$0;

    pddf89ce7$p27a1f813$1(pddf89ce7 r1, Continuation<? super pddf89ce7$p27a1f813$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new pddf89ce7$p27a1f813$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pddf89ce7$p27a1f813$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((30 + 8) % 8) > 0) goto L65;
    L65:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        switch(this.fd304ba20) {
            case 0: goto L66;
            case 1: goto L29;
            case 2: goto L28;
            case 3: goto L27;
            case 4: goto L26;
            case 5: goto L25;
            case 6: goto L24;
            case 7: goto L60;
            case 8: goto L93;
            default: goto L19;
        };
    L24:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L11
    L43:
        return Unit.INSTANCE;
    L25:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L11
    L88:
        this.fd304ba20 = 6;     // Catch: Exception -> L11
        if (pddf89ce7.m32875bfb(this.this$0, this) != r0) goto L43;
    L47:
        return r0;
    L26:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L11
    L85:
        this.fd304ba20 = 5;     // Catch: Exception -> L11
        if (pddf89ce7.m1b35e6d8(this.this$0, pec53a8c4.fd0749aab, this) != r0) goto L88;
    L27:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L11
    L82:
        this.fd304ba20 = 4;     // Catch: Exception -> L11
        if (pe9ddd6b8.pb0da8397.mc0c6c995(pddf89ce7.mfab5c515(this.this$0), null, this, 1, null) != r0) goto L85;
    L28:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L11
    L78:
        string r62 = (string) r6;     // Catch: Exception -> L11
    L79:
        this.fd304ba20 = 3;     // Catch: Exception -> L11
        if (pddf89ce7.mfab5c515(this.this$0).initActivationWithToken(r62, this) != r0) goto L82;
    L29:
        ResultKt.throwOnFailure(r6);     // Catch: Exception -> L11
    L71:
        if (pddf89ce7.mfab5c515(this.this$0).checkActivated() == true) goto L88;
        if (pddf89ce7.mc4724e47(this.this$0).hasTopToken() == false) goto L75;
        r62 = pddf89ce7.mc4724e47(this.this$0).getTopToken();     // Catch: Exception -> L11
        goto L79
    L75:
        this.fd304ba20 = 2;     // Catch: Exception -> L11
        r6 = pddf89ce7.m73774f00(this.this$0).getTopTokenByPhone(this);     // Catch: Exception -> L11
        if (r6 != r0) goto L78;
    L66:
        ResultKt.throwOnFailure(r6);
        this.fd304ba20 = 1;     // Catch: Exception -> L11
        if (pddf89ce7.ma8a70b9b(this.this$0).logoutIfNeeded(this) != r0) goto L71;
    L93:
        ResultKt.throwOnFailure(r6);
        goto L43
    L60:
        ResultKt.throwOnFailure(r6);
    L94:
        pddf89ce7 r63 = this.this$0;
        pec53a8c4 r1 = pec53a8c4.fbb1ca97e;
        pddf89ce7$p27a1f813$1 r2 = this;
        this.fd304ba20 = 8;
        if (pddf89ce7.m1b35e6d8(r63, r1, r2) == r0) goto L47;
    L19:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L11:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        pddf89ce7 r12 = this.this$0;
        pddf89ce7$p27a1f813$1 r22 = this;
        this.fd304ba20 = 7;
        if (pddf89ce7.mc14faa11(r12, th, r22) == r0) goto L47;
        goto L47
    }
}

