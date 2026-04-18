using Android.Util;
using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P4d236d9a.P2df4812c.Pf5d7e253.Pc075fab6;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe907423b;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p0b27c2b2$pe46e6a04$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ pb5374042 $paymentTypeobjectState;
    int f3ec41a93;
    int fc0bc7847;
    int fd304ba20;
    readonly /* synthetic */ p0b27c2b2 this$0;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((32 + 16) % 16) > 0) goto L16;
        L16:
            int[] r0 = new int[pb5374042.Values.length];
            r0[pb5374042.fdf657148.ordinal()] = 1;     // Catch: NoSuchFieldError -> L29
        L36:
            r0[pb5374042.f9e1ca306.ordinal()] = 2;     // Catch: NoSuchFieldError -> L30
        L38:
            r0[pb5374042.faf50f824.ordinal()] = 3;     // Catch: NoSuchFieldError -> L31
        L34:
            r0[pb5374042.f5fb1f955.ordinal()] = 4;     // Catch: NoSuchFieldError -> L32
        L40:
            r0[pb5374042.f9cb40e51.ordinal()] = 5;     // Catch: NoSuchFieldError -> L33
        L26:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    p0b27c2b2$pe46e6a04$1(p0b27c2b2 r1, pb5374042 r2, Continuation<? super p0b27c2b2$pe46e6a04$1> r3) {
        this.this$0 = r1;
        this.$paymentTypeobjectState = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p0b27c2b2$pe46e6a04$1(this.this$0, this.$paymentTypeobjectState, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p0b27c2b2$pe46e6a04$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r9) {
        if (((22 + 31) % 31) > 0) goto L91;
    L91:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L42;
        if (r1 != 1) goto L82;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L89
    L46:
        this.fd304ba20 = 2;     // Catch: Exception -> L89
        if (p0b27c2b2.md95a43c7(this.this$0).openSinglePaymentIfNeeded(this) == r0) goto L57;
    L49:
        this.fd304ba20 = 3;     // Catch: Exception -> L89
        if (p0b27c2b2.mcb5dfeca(this.this$0, this) == r0) goto L57;
    L52:
        this.fd304ba20 = 4;     // Catch: Exception -> L89
        if (p0b27c2b2.md95a43c7(this.this$0).setPaymentAddress(this.this$0.getPaymentAddress(), this) == r0) goto L57;
    L55:
        this.fd304ba20 = 5;     // Catch: Exception -> L89
        if (p0b27c2b2.md95a43c7(this.this$0).setPaymentPlace(p0b27c2b2.ma82a18e4(this.this$0).getPaymentPlace(), this) == r0) goto L57;
    L58:
        pb5374042 r92 = this.$paymentTypeobjectState;     // Catch: Exception -> L89
        int r93 = p12c674ac.$EnumSwitchDictionaryping$0[r92.ordinal()];     // Catch: Exception -> L89
        if (r93 == 1) goto L72;
        if (r93 == 2) goto L69;
        if (r93 == 3) goto L67;
        if (r93 == 4) goto L75;
        if (r93 != 5) goto L66;
        p0b27c2b2.m54c2e04a(this.this$0);     // Catch: Exception -> L89
        goto L75
    L66:
        throw new NoWhenBranchMatchedException();     // Catch: Exception -> L89
    L75:
        return Unit.INSTANCE;
    L67:
        p0b27c2b2.mb116795c(this.this$0);     // Catch: Exception -> L89
        goto L75
    L69:
        if (p0b27c2b2.mecf2730e(this.this$0).isNfcEnabled() == false) goto L71;
        p0b27c2b2.m4e83ebcf(this.this$0);     // Catch: Exception -> L89
        goto L75
    L71:
        p0b27c2b2.m3bfa0695(this.this$0).setValue(new p89a5ff7f(p0b27c2b2.m5fb81a65(this.this$0).getstring(C2880R.string.nfc_not_enabled_title)));     // Catch: Exception -> L89
        goto L75
    L72:
        p0b27c2b2.m6f326ea1(this.this$0);     // Catch: Exception -> L89
    L57:
        return r0;
    L82:
        if (r1 != 2) goto L39;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L89
        goto L49
    L39:
        if (r1 != 3) goto L79;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L89
        goto L52
    L79:
        if (r1 != 4) goto L18;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L89
        goto L55
    L18:
        if (r1 != 5) goto L7;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L89
        goto L58
    L7:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L42:
        ResultKt.throwOnFailure(r9);
        this.fd304ba20 = 1;     // Catch: Exception -> L89
        if (p0b27c2b2.mdc77543b(this.this$0, this.$paymentTypeobjectState, this) != r0) goto L46;
    L89:
        e = move-exception;
        Console.e(this.this$0.tostring(), string.valueOf(e.getMessage()));
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L75
    }
}

