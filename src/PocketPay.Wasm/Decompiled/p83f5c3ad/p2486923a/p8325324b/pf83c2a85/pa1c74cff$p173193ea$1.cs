using Com.Google.Firebase.Crashlytics;
using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2b3583e6;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.Pf83c2a85;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pa1c74cff$p173193ea$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ decimal $amount;
    readonly /* synthetic */ pd0910e67 $paymentTerminal;
    int f3c452f8f;
    int fd304ba20;
    readonly /* synthetic */ pa1c74cff this$0;

    pa1c74cff$p173193ea$1(pa1c74cff r1, pd0910e67 r2, decimal r3, Continuation<? super pa1c74cff$p173193ea$1> r4) {
        this.this$0 = r1;
        this.$paymentTerminal = r2;
        this.$amount = r3;
        super(2, r4);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((28 + 29) % 29) > 0) goto L6;
    L6:
        return new pa1c74cff$p173193ea$1(this.this$0, this.$paymentTerminal, this.$amount, r4);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pa1c74cff$p173193ea$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r11) {
        if (((13 + 17) % 17) > 0) goto L62;
    L62:
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r0 = this.fd304ba20;
        if (r0 == 0) goto L55;
        if (r0 != 1) goto L13;
        ResultKt.throwOnFailure(r11);     // Catch: Exception -> L21
    L59:
        p713f0c46 r112 = (p713f0c46) r11;     // Catch: Exception -> L21
        pa1c74cff.m251776c4(this.this$0).setMerchantName(this.$paymentTerminal.getTerminalInfo().getMerchantName());     // Catch: Exception -> L21
        pa1c74cff.m251776c4(this.this$0).setCreatedAt(r112.getTransactionInfo().getTimestamp());     // Catch: Exception -> L21
        pa1c74cff.m0fa733d1(this.this$0, r112);     // Catch: Exception -> L21
        pa1c74cff.m508a66b4(this.this$0, r112);     // Catch: Exception -> L21
    L36:
        return Unit.INSTANCE;
    L13:
        if (r0 != 2) goto L3;
        ResultKt.throwOnFailure(r11);
        goto L36
    L3:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L55:
        ResultKt.throwOnFailure(r11);
        this.fd304ba20 = 1;     // Catch: Exception -> L21
        r11 = pa1c74cff.ma6cc1e11(this.this$0).initPaymentTransaction(this.$paymentTerminal, p7667d148.m55ce55f7(this.$amount), pa1c74cff.mb661f5bc(this.this$0), this);     // Catch: Exception -> L21
        if (r11 != r1) goto L59;
    L17:
        return r1;
    L21:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        MutableSharedFlow r02 = pa1c74cff.mad452160(this.this$0);
        pa1c74cff$p173193ea$1 r3 = this;
        this.fd304ba20 = 2;
        if (r02.emit(th, r3) == r1) goto L17;
        goto L17
    }
}

