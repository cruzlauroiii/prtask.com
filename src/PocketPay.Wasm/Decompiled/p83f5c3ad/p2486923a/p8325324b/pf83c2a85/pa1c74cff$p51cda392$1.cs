using Com.Decryptstringmanager;
using Java.Math;
using Java.Util.Concurrent;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P83f5c3ad.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pa1c74cff$p51cda392$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ bool $showLoading;
    object L$0;
    object L$1;
    int f428d0d6e;
    int fd304ba20;
    readonly /* synthetic */ pa1c74cff this$0;

    pa1c74cff$p51cda392$1(bool r1, pa1c74cff r2, Continuation<? super pa1c74cff$p51cda392$1> r3) {
        this.$showLoading = r1;
        this.this$0 = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pa1c74cff$p51cda392$1(this.$showLoading, this.this$0, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pa1c74cff$p51cda392$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r9) {
        if (((12 + 2) % 2) > 0) goto L74;
    L74:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        switch(this.fd304ba20) {
            case 0: goto L15;
            case 1: goto L79;
            case 2: goto L78;
            case 3: goto L77;
            case 4: goto L73;
            case 5: goto L54;
            case 6: goto L53;
            case 7: goto L59;
            default: goto L49;
        };
    L53:
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L91
    L36:
        pa1c74cff.mdc7bed18(this.this$0).startPaymentSellSuccessFlow(null, pa1c74cff.m251776c4(this.this$0));     // Catch: Exception -> L91
    L71:
        return Unit.INSTANCE;
    L54:
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L91
    L33:
        pa1c74cff.m251776c4(this.this$0).setReferenceNumber(Decryptstring.decryptstring("de2cb853d363a0affd531763ca66e7aa3ef54bd2d332e681c79a171425114e358cada1d82be7b76b"));     // Catch: Exception -> L91
        this.fd304ba20 = 6;     // Catch: Exception -> L91
        if (DelayKt.delay(2000, this) != r0) goto L36;
    L64:
        return r0;
    L77:
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L91
    L27:
        pd0910e67 r3 = (pd0910e67) r9;     // Catch: Exception -> L91
        pa1c74cff.m93b54e67(this.this$0).setValue(r3);     // Catch: Exception -> L91
        pa1c74cff.ma461eda3(this.this$0, r3);     // Catch: Exception -> L91
        decimal r1 = pa1c74cff.f910eef8c.getNFC_CALIBRATION_TEST_AMOUNT();     // Catch: Exception -> L91
        this.L$0 = r3;     // Catch: Exception -> L91
        this.L$1 = r1;     // Catch: Exception -> L91
        this.fd304ba20 = 4;     // Catch: Exception -> L91
        if (pa1c74cff.mb3362370(this.this$0).emit(new p97fa68b7(pa1c74cff.m5fb81a65(this.this$0).getstring(C2815R.string.toph_test_payment), r1, pa1c74cff.m5fb81a65(this.this$0).getstring(C2815R.string.toph_test_merchant_address)), this) == r0) goto L64;
    L30:
        pa1c74cff.m251776c4(this.this$0).setAmount(r1);     // Catch: Exception -> L91
        this.L$0 = null;     // Catch: Exception -> L91
        this.L$1 = null;     // Catch: Exception -> L91
        this.fd304ba20 = 5;     // Catch: Exception -> L91
        if (pa1c74cff.mecf2730e(this.this$0).calibrateNfc(r3, this) != r0) goto L33;
    L78:
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L91
    L24:
        MutableStateFlow r12 = pa1c74cff.m247bc4ee(this.this$0);     // Catch: Exception -> L91
        r12.setValue((pb53cd12b) r9);     // Catch: Exception -> L91
        this.fd304ba20 = 3;     // Catch: Exception -> L91
        r9 = pa1c74cff.ma6cc1e11(this.this$0).getPaymentTerminal(this);     // Catch: Exception -> L91
        if (r9 != r0) goto L27;
    L79:
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L91
    L21:
        this.fd304ba20 = 2;     // Catch: Exception -> L91
        r9 = pa1c74cff.mecf2730e(this.this$0).getShowedNfcCalibrationCoordinates(this);     // Catch: Exception -> L91
        if (r9 != r0) goto L24;
    L59:
        ResultKt.throwOnFailure(r9);
        goto L71
    L15:
        ResultKt.throwOnFailure(r9);
        if (this.$showLoading == false) goto L21;
        this.fd304ba20 = 1;     // Catch: Exception -> L91
        if (pa1c74cff.m724546ab(this.this$0).emit(p0890727b.fa82b419a, this) != r0) goto L21;
    L73:
        r1 = (decimal) this.L$1;
        r3 = (pd0910e67) this.L$0;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L91
        goto L30
    L49:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L91:
        e = move-exception;
        if ((e is CancellationException) == true) goto L71;
        MutableSharedFlow r13 = pa1c74cff.mad452160(this.this$0);
        pa1c74cff$p51cda392$1 r32 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.fd304ba20 = 7;
        if (r13.emit(e, r32) == r0) goto L64;
        goto L64
    }
}

