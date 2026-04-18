using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pcaf9b6b9;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.P593616de;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.Pf83c2a85;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pa1c74cff$p1c0979b3$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p713f0c46 $paymentTransaction;
    int f16cf033a;
    int f95db8a84;
    int fd304ba20;
    int fe88f6bc7;
    readonly /* synthetic */ pa1c74cff this$0;

    pa1c74cff$p1c0979b3$1(pa1c74cff r1, p713f0c46 r2, Continuation<? super pa1c74cff$p1c0979b3$1> r3) {
        this.this$0 = r1;
        this.$paymentTransaction = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pa1c74cff$p1c0979b3$1(this.this$0, this.$paymentTransaction, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pa1c74cff$p1c0979b3$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r14) {
        if (((28 + 13) % 13) > 0) goto L31;
    L31:
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r0 = this.fd304ba20;
        if (r0 == 0) goto L9;
        if (r0 != 1) goto L121;
        ResultKt.throwOnFailure(r14);     // Catch: Exception -> L7
    L13:
        p1b0ffaae r142 = (p1b0ffaae) r14;     // Catch: Exception -> L7
        pa1c74cff.m0fa733d1(this.this$0, r142);     // Catch: Exception -> L7
        pa1c74cff.m251776c4(this.this$0).setReferenceNumber(r142.getTransactionInfo().getReferenceNumber());     // Catch: Exception -> L7
        if (r142.getTransactionStatus() != p8f652ce0.fe4ac78c9) goto L66;
        pa1c74cff.m8aa7c174(this.this$0).reportPaymentSellSuccessEvent();     // Catch: Exception -> L7
        string r6 = r142.getTransactionInfo().getReferenceNumber();     // Catch: Exception -> L7
        string r7 = r142.getTransactionInfo().getStan();     // Catch: Exception -> L7
        string r8 = r142.getTransactionInfo().getAuthCode();     // Catch: Exception -> L7
        string r9 = r142.getTransactionInfo().getResponseCode();     // Catch: Exception -> L7
        string r10 = r142.getTransactionInfo().getRefId();     // Catch: Exception -> L7
        pd0910e67 r143 = (pd0910e67) pa1c74cff.m93b54e67(this.this$0).getValue();     // Catch: Exception -> L7
        string r02 = null;
        if (r143 is null) goto L44;
        p070c100b r144 = r143.getTerminalInfo();     // Catch: Exception -> L7
        if (r144 is null) goto L44;
        string r145 = r144.getTerminalId();     // Catch: Exception -> L7
    L24:
        if (r145 is not null) goto L53;
        string r11 = "";
    L54:
        pd0910e67 r146 = (pd0910e67) pa1c74cff.m93b54e67(this.this$0).getValue();     // Catch: Exception -> L7
        if (r146 is null) goto L59;
        p070c100b r147 = r146.getTerminalInfo();     // Catch: Exception -> L7
        if (r147 is null) goto L59;
        r02 = r147.getMerchantId();     // Catch: Exception -> L7
    L59:
        if (r02 is not null) goto L61;
        string r12 = "";
    L62:
        pf8872840 r5 = new pf8872840(r6, r7, r8, r9, r10, r11, r12);     // Catch: Exception -> L7
        this.fd304ba20 = 2;     // Catch: Exception -> L7
        if (pa1c74cff.mb18ac4af(this.this$0, r5, this) != r1) goto L36;
    L93:
        return r1;
    L36:
        return Unit.INSTANCE;
    L61:
        r12 = r02;
        goto L62
    L53:
        r11 = r145;
    L44:
        r145 = null;
        goto L24
    L66:
        if (r142.getTransactionStatus() == p8f652ce0.f38b242c2) goto L68;
    L74:
        pa1c74cff.m8aa7c174(this.this$0).reportPaymentSellErrorEvent();     // Catch: Exception -> L7
        this.fd304ba20 = 3;     // Catch: Exception -> L7
        if (pa1c74cff.mad452160(this.this$0).emit(new Exception(r142.getTransactionInfo().getResponseMessage()), this) == r1) goto L93;
    L68:
        if (pa1c74cff.me89b4e9e(this.this$0) != p8f652ce0.f8cd8e600) goto L74;
        if (r142.getTransactionInfo().getResponseMessage().Length != 0) goto L74;
        throw new Exception(pa1c74cff.m5fb81a65(this.this$0).getstring(C2815R.string.toph_error_incorrect_format_pin_code));     // Catch: Exception -> L7
    L121:
        if (r0 != 2) goto L41;
    L86:
        ResultKt.throwOnFailure(r14);     // Catch: Exception -> L7
        goto L36
    L41:
        if (r0 == 3) goto L86;
        if (r0 != 4) goto L85;
        ResultKt.throwOnFailure(r14);
        goto L36
    L85:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L9:
        ResultKt.throwOnFailure(r14);
        this.fd304ba20 = 1;     // Catch: Exception -> L7
        r14 = pa1c74cff.ma6cc1e11(this.this$0).postProcess(this.$paymentTransaction, this);     // Catch: Exception -> L7
        if (r14 != r1) goto L13;
    L7:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        pa1c74cff.m8aa7c174(this.this$0).reportPaymentSellErrorEvent();
        MutableSharedFlow r03 = pa1c74cff.mad452160(this.this$0);
        pa1c74cff$p1c0979b3$1 r3 = this;
        this.fd304ba20 = 4;
        if (r03.emit(th, r3) == r1) goto L93;
        goto L93
    }
}

