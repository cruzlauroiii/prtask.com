using Com.Google.Firebase.Crashlytics;
using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2b3583e6.P263e3cef;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.P593616de;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P83f5c3ad.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pa1c74cff$p877276a4$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ bool $showLoading;
    object L$0;
    object L$1;
    int f3b2abb01;
    int fd304ba20;
    int feb8ae66e;
    int fecb5a801;
    int ffcc5d2d1;
    readonly /* synthetic */ pa1c74cff this$0;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((24 + 3) % 3) > 0) goto L19;
        L19:
            int[] r0 = new int[pbfc85237.Values.length];
            r0[pbfc85237.fa59af09e.ordinal()] = 1;     // Catch: NoSuchFieldError -> L25
        L12:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    pa1c74cff$p877276a4$1(bool r1, pa1c74cff r2, Continuation<? super pa1c74cff$p877276a4$1> r3) {
        this.$showLoading = r1;
        this.this$0 = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pa1c74cff$p877276a4$1(this.$showLoading, this.this$0, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pa1c74cff$p877276a4$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r9) {
        if (((1 + 4) % 4) > 0) goto L117;
    L117:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        switch(this.fd304ba20) {
            case 0: goto L54;
            case 1: goto L18;
            case 2: goto L17;
            case 3: goto L16;
            case 4: goto L14;
            case 5: goto L42;
            case 6: goto L20;
            case 7: goto L26;
            case 8: goto L119;
            case 9: goto L7;
            default: goto L49;
        };
    L16:
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
    L68:
        ped663a3e r1 = (ped663a3e) r9;     // Catch: Exception -> L4
        this.L$0 = r1;     // Catch: Exception -> L4
        this.fd304ba20 = 4;     // Catch: Exception -> L4
        if (pa1c74cff.m260c792f(this.this$0).checkDuplicateReceipt(r1.getUuid(), this) == r0) goto L32;
    L71:
        decimal r92 = p517b902b.m29a3256d(r1);     // Catch: Exception -> L4
    L83:
        this.L$0 = r92;     // Catch: Exception -> L4
        this.fd304ba20 = 7;     // Catch: Exception -> L4
        object r12 = pa1c74cff.ma6cc1e11(this.this$0).getPaymentTerminal(this);     // Catch: Exception -> L4
        if (r12 == r0) goto L32;
        decimal r13 = r92;
        r9 = r12;
    L87:
        pd0910e67 r93 = (pd0910e67) r9;     // Catch: Exception -> L4
        pa1c74cff.m93b54e67(this.this$0).setValue(r93);     // Catch: Exception -> L4
        pa1c74cff.ma461eda3(this.this$0, r93);     // Catch: Exception -> L4
        if (r93.getTerminalStatus() != p83d39779.f18ff74f4) goto L102;
        pbfc85237 r3 = pa1c74cff.maae32a26(this.this$0);     // Catch: Exception -> L4
        if (r3 is not null) goto L92;
        int r32 = -1;
    L93:
        if (r32 != 1) goto L95;
        string r2 = pa1c74cff.m5fb81a65(this.this$0).getstring(C2815R.string.toph_cancel_payback_payment);     // Catch: Exception -> L4
    L96:
        this.L$0 = r13;     // Catch: Exception -> L4
        this.L$1 = r93;     // Catch: Exception -> L4
        this.fd304ba20 = 8;     // Catch: Exception -> L4
        if (pa1c74cff.mb3362370(this.this$0).emit(new p97fa68b7(r2, r13, r93.getTerminalInfo().getMerchantName() + ",\n" + r93.getTerminalInfo().getMerchantAddress()), this) == r0) goto L32;
        decimal r22 = r13;
        pd0910e67 r14 = r93;
    L100:
        pa1c74cff.m251776c4(this.this$0).setAmount(r22);     // Catch: Exception -> L4
        pa1c74cff.md815aa1c(this.this$0, r22, r14);     // Catch: Exception -> L4
    L106:
        return Unit.INSTANCE;
    L95:
        r2 = pa1c74cff.m5fb81a65(this.this$0).getstring(C2815R.string.toph_purchase_payment);     // Catch: Exception -> L4
        goto L96
    L92:
        r32 = p12c674ac.$EnumSwitchDictionaryping$0[r3.ordinal()];     // Catch: Exception -> L4
        goto L93
    L102:
        throw new IllegalArgumentException("terminal status is LOCKED");     // Catch: Exception -> L4
    L32:
        return r0;
    L17:
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
    L63:
        pa1c74cff.m247bc4ee(this.this$0).setValue((pb53cd12b) r9);     // Catch: Exception -> L4
        pad7c4a1f r94 = pa1c74cff.mc4f4919e(this.this$0).getComboPayment();     // Catch: Exception -> L4
        if (r94 is not null) goto L73;
        this.fd304ba20 = 3;     // Catch: Exception -> L4
        r9 = pa1c74cff.m260c792f(this.this$0).getCurrentSellReceipt(this);     // Catch: Exception -> L4
        if (r9 != r0) goto L68;
    L73:
        if (pa1c74cff.maae32a26(this.this$0) != pbfc85237.f860926e6) goto L82;
        this.L$0 = r94;     // Catch: Exception -> L4
        this.fd304ba20 = 5;     // Catch: Exception -> L4
        object r15 = pa1c74cff.m260c792f(this.this$0).getCurrentSellReceipt(this);     // Catch: Exception -> L4
        if (r15 == r0) goto L32;
        pad7c4a1f r16 = r94;
        r9 = r15;
    L78:
        this.L$0 = r16;     // Catch: Exception -> L4
        this.fd304ba20 = 6;     // Catch: Exception -> L4
        if (pa1c74cff.m260c792f(this.this$0).checkDuplicateReceipt(((ped663a3e) r9).getUuid(), this) == r0) goto L32;
    L81:
        r92 = r16.getAmount();     // Catch: Exception -> L4
        goto L83
    L82:
        r92 = r94.getAmount();     // Catch: Exception -> L4
        goto L83
    L18:
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
    L60:
        this.fd304ba20 = 2;     // Catch: Exception -> L4
        r9 = pa1c74cff.mecf2730e(this.this$0).getShowedNfcCalibrationCoordinates(this);     // Catch: Exception -> L4
        if (r9 != r0) goto L63;
    L7:
        ResultKt.throwOnFailure(r9);
        goto L106
    L54:
        ResultKt.throwOnFailure(r9);
        if (this.$showLoading == false) goto L60;
        this.fd304ba20 = 1;     // Catch: Exception -> L4
        if (pa1c74cff.m724546ab(this.this$0).emit(p0890727b.fa82b419a, this) != r0) goto L60;
    L49:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L26:
        r13 = (decimal) this.L$0;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
        goto L87
    L119:
        r14 = (pd0910e67) this.L$1;
        r22 = (decimal) this.L$0;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
        goto L100
    L42:
        r16 = (pad7c4a1f) this.L$0;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
        goto L78
    L20:
        r16 = (pad7c4a1f) this.L$0;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
        goto L81
    L14:
        r1 = (ped663a3e) this.L$0;
        ResultKt.throwOnFailure(r9);     // Catch: Exception -> L4
    L4:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        MutableSharedFlow r17 = pa1c74cff.mad452160(this.this$0);
        pa1c74cff$p877276a4$1 r23 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.fd304ba20 = 9;
        if (r17.emit(th, r23) == r0) goto L32;
        goto L32
    }
}

