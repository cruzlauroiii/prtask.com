using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P2e5d8aa3.Pee11cbb1.Pac143fb7;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P518a4861.P8325324b.P86ccec3d;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe907423b;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p47c05cb4$pe46e6a04$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p8c261c90 $paymentType;
    int f4cd03774;
    int fcc2be7c2;
    int fd304ba20;
    readonly /* synthetic */ p47c05cb4 this$0;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((18 + 20) % 20) > 0) goto L14;
        L14:
            int[] r0 = new int[p8c261c90.Values.length];
            r0[p8c261c90.fdf657148.ordinal()] = 1;     // Catch: NoSuchFieldError -> L28
        L36:
            r0[p8c261c90.faf50f824.ordinal()] = 2;     // Catch: NoSuchFieldError -> L29
        L34:
            r0[p8c261c90.f9e1ca306.ordinal()] = 3;     // Catch: NoSuchFieldError -> L30
        L38:
            r0[p8c261c90.f9cb40e51.ordinal()] = 4;     // Catch: NoSuchFieldError -> L31
        L23:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    p47c05cb4$pe46e6a04$1(p47c05cb4 r1, p8c261c90 r2, Continuation<? super p47c05cb4$pe46e6a04$1> r3) {
        this.this$0 = r1;
        this.$paymentType = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p47c05cb4$pe46e6a04$1(this.this$0, this.$paymentType, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p47c05cb4$pe46e6a04$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((5 + 16) % 16) > 0) goto L10;
    L10:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L50;
        ResultKt.throwOnFailure(r7);
        pfdb21b31 r72 = p47c05cb4.ma82a18e4(this.this$0);
        p47c05cb4$pe46e6a04$1 r12 = this;
        this.fd304ba20 = 1;
        r7 = r72.isFastSellEnabled(r12);
        if (r7 != r0) goto L64;
    L70:
        return r0;
    L64:
        ((bool) r7).boolValue();
        this.fd304ba20 = 2;     // Catch: Exception -> L8
        if (p47c05cb4.m260c792f(this.this$0).setPaymentType(this.$paymentType, this) == r0) goto L70;
    L68:
        this.fd304ba20 = 3;     // Catch: Exception -> L8
        if (p47c05cb4.m260c792f(this.this$0).openSinglePaymentIfNeeded(this) == r0) goto L70;
    L71:
        p8c261c90 r73 = this.$paymentType;     // Catch: Exception -> L8
        int r74 = p12c674ac.$EnumSwitchDictionaryping$0[r73.ordinal()];     // Catch: Exception -> L8
        if (r74 == 1) goto L85;
        if (r74 == 2) goto L84;
        if (r74 == 3) goto L81;
        if (r74 != 4) goto L79;
        p47c05cb4.mfaaabc0f(this.this$0);     // Catch: Exception -> L8
    L23:
        return Unit.INSTANCE;
    L79:
        throw new NoWhenBranchMatchedException();     // Catch: Exception -> L8
    L81:
        if (p47c05cb4.mecf2730e(this.this$0).isNfcEnabled() == false) goto L83;
        p47c05cb4.m2ef99fe7(this.this$0);     // Catch: Exception -> L8
        goto L23
    L83:
        p47c05cb4.m79e7eef2(this.this$0).setValue(new p89a5ff7f(p47c05cb4.m5fb81a65(this.this$0).getstring(C2845R.string.nfc_not_enabled_title)));     // Catch: Exception -> L8
        goto L23
    L84:
        p47c05cb4.m8742f7e2(this.this$0);     // Catch: Exception -> L8
        goto L23
    L85:
        p47c05cb4.mdc4df7ab(this.this$0);     // Catch: Exception -> L8
        goto L23
    L50:
        if (r1 != 1) goto L32;
        ResultKt.throwOnFailure(r7);
        goto L64
    L32:
        if (r1 != 2) goto L42;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L8
        goto L68
    L42:
        if (r1 != 3) goto L56;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L8
        goto L71
    L56:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L8:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L23
    }
}

