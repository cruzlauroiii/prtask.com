using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pcaf9b6b9;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.P593616de;
using P83f5c3ad.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p98cf21b1$p078de3ac$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p0e6dda02 $tophPayback;
    int f08ca4168;
    int f8d5bf84e;
    int fd304ba20;
    int fea812faf;
    readonly /* synthetic */ p98cf21b1 this$0;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((6 + 8) % 8) > 0) goto L10;
        L10:
            int[] r0 = new int[p8f652ce0.Values.length];
            r0[p8f652ce0.fc1040ea3.ordinal()] = 1;     // Catch: NoSuchFieldError -> L26
        L30:
            r0[p8f652ce0.fe4ac78c9.ordinal()] = 2;     // Catch: NoSuchFieldError -> L27
        L5:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    p98cf21b1$p078de3ac$1(p98cf21b1 r1, p0e6dda02 r2, Continuation<? super p98cf21b1$p078de3ac$1> r3) {
        this.this$0 = r1;
        this.$tophPayback = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new p98cf21b1$p078de3ac$1(this.this$0, this.$tophPayback, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p98cf21b1$p078de3ac$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r14) {
        if (((2 + 16) % 16) > 0) goto L52;
    L52:
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r0 = this.fd304ba20;
        if (r0 == 0) goto L81;
        if (r0 != 1) goto L7;
        ResultKt.throwOnFailure(r14);     // Catch: Exception -> L29
    L85:
        p1b0ffaae r142 = (p1b0ffaae) r14;     // Catch: Exception -> L29
        p98cf21b1.m251776c4(this.this$0).setReferenceNumber(r142.getTransactionInfo().getReferenceNumber());     // Catch: Exception -> L29
        p98cf21b1.m0fa733d1(this.this$0, r142);     // Catch: Exception -> L29
        int r02 = p12c674ac.$EnumSwitchDictionaryping$0[r142.getTransactionStatus().ordinal()];     // Catch: Exception -> L29
        if (r02 == 1) goto L91;
        if (r02 == 2) goto L91;
        p98cf21b1.m8aa7c174(this.this$0).reportPaymentPaybackErrorEvent();     // Catch: Exception -> L29
        this.fd304ba20 = 3;     // Catch: Exception -> L29
        if (p98cf21b1.mad452160(this.this$0).emit(new Exception(r142.getTransactionInfo().getResponseMessage()), this) != r1) goto L26;
    L97:
        return r1;
    L26:
        return Unit.INSTANCE;
    L91:
        p98cf21b1.m8aa7c174(this.this$0).reportPaymentPaybackSuccessEvent();     // Catch: Exception -> L29
        string r6 = r142.getTransactionInfo().getReferenceNumber();     // Catch: Exception -> L29
        string r7 = r142.getTransactionInfo().getStan();     // Catch: Exception -> L29
        string r8 = r142.getTransactionInfo().getAuthCode();     // Catch: Exception -> L29
        string r9 = r142.getTransactionInfo().getResponseCode();     // Catch: Exception -> L29
        string r10 = r142.getTransactionInfo().getRefId();     // Catch: Exception -> L29
        pd0910e67 r143 = (pd0910e67) p98cf21b1.m93b54e67(this.this$0).getValue();     // Catch: Exception -> L29
        string r03 = null;
        if (r143 is null) goto L59;
        p070c100b r144 = r143.getTerminalInfo();     // Catch: Exception -> L29
        if (r144 is null) goto L59;
        string r145 = r144.getTerminalId();     // Catch: Exception -> L29
    L36:
        if (r145 is not null) goto L62;
        string r11 = "";
    L63:
        pd0910e67 r146 = (pd0910e67) p98cf21b1.m93b54e67(this.this$0).getValue();     // Catch: Exception -> L29
        if (r146 is null) goto L68;
        p070c100b r147 = r146.getTerminalInfo();     // Catch: Exception -> L29
        if (r147 is null) goto L68;
        r03 = r147.getMerchantId();     // Catch: Exception -> L29
    L68:
        if (r03 is not null) goto L70;
        string r12 = "";
    L71:
        pf8872840 r5 = new pf8872840(r6, r7, r8, r9, r10, r11, r12);     // Catch: Exception -> L29
        this.fd304ba20 = 2;     // Catch: Exception -> L29
        if (p98cf21b1.m7dc00e3e(this.this$0, r5, this) == r1) goto L97;
    L70:
        r12 = r03;
        goto L71
    L62:
        r11 = r145;
    L59:
        r145 = null;
        goto L36
    L7:
        if (r0 != 2) goto L53;
    L11:
        ResultKt.throwOnFailure(r14);     // Catch: Exception -> L29
        goto L26
    L53:
        if (r0 == 3) goto L11;
        if (r0 != 4) goto L10;
        ResultKt.throwOnFailure(r14);
        goto L26
    L10:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L81:
        ResultKt.throwOnFailure(r14);
        this.fd304ba20 = 1;     // Catch: Exception -> L29
        r14 = p98cf21b1.m32f9f0c1(this.this$0).makePayback(this.$tophPayback, this);     // Catch: Exception -> L29
        if (r14 != r1) goto L85;
    L29:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        p98cf21b1.m8aa7c174(this.this$0).reportPaymentPaybackErrorEvent();
        MutableSharedFlow r04 = p98cf21b1.mad452160(this.this$0);
        p98cf21b1$p078de3ac$1 r3 = this;
        this.fd304ba20 = 4;
        if (r04.emit(th, r3) == r1) goto L97;
        goto L97
    }
}

