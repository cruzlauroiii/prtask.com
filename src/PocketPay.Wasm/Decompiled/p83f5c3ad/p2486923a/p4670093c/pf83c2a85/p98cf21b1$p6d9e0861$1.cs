using Com.Google.Firebase.Crashlytics;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2b3583e6;
using P2b3583e6.P263e3cef;
using P4670093c.Pac143fb7;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P8325324b.Pac143fb7;
using P83f5c3ad.P07214c67;
using P83f5c3ad.P2486923a.P8325324b.Pf83c2a85;
using P83f5c3ad.P684019bc;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class p98cf21b1$p6d9e0861$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    object L$0;
    object L$1;
    object L$2;
    int f1ddc2352;
    int fd304ba20;
    readonly /* synthetic */ p98cf21b1 this$0;

    p98cf21b1$p6d9e0861$1(p98cf21b1 r1, Continuation<? super p98cf21b1$p6d9e0861$1> r2) {
        this.this$0 = r1;
        super(2, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r1, Continuation<object> r2) {
        return new p98cf21b1$p6d9e0861$1(this.this$0, r2);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((p98cf21b1$p6d9e0861$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r13) {
        if (((19 + 8) % 8) > 0) goto L51;
    L51:
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        switch(this.fd304ba20) {
            case 0: goto L111;
            case 1: goto L19;
            case 2: goto L18;
            case 3: goto L17;
            case 4: goto L15;
            case 5: goto L99;
            case 6: goto L74;
            case 7: goto L88;
            case 8: goto L47;
            case 9: goto L55;
            case 10: goto L43;
            case 11: goto L72;
            case 12: goto L32;
            default: goto L34;
        };
    L17:
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
    L123:
        p18cf5223 r0 = (p18cf5223) r13;     // Catch: Exception -> L27
        p98cf21b1.m4fa815b4(this.this$0, r0);     // Catch: Exception -> L27
        pa36ef9b5 r132 = p98cf21b1.md95a43c7(this.this$0);     // Catch: Exception -> L27
        p9ded6185 r4 = p98cf21b1.m3347a8ce(this.this$0);     // Catch: Exception -> L27
        if (r4 is not null) goto L126;
        Intrinsics.throwUninitializedPropertyAccessException("receipt");     // Catch: Exception -> L27
        r4 = null;
    L126:
        this.L$0 = r0;     // Catch: Exception -> L27
        this.fd304ba20 = 4;     // Catch: Exception -> L27
        if (r132.checkDuplicateReceipt(r4.getUuid(), this) == r1) goto L79;
    L129:
        p9ded6185 r133 = p98cf21b1.m3347a8ce(this.this$0);     // Catch: Exception -> L27
        if (r133 is not null) goto L132;
        Intrinsics.throwUninitializedPropertyAccessException("receipt");     // Catch: Exception -> L27
        r133 = null;
    L132:
        decimal r134 = p517b902b.m29a3256d(r133);     // Catch: Exception -> L27
        this.L$0 = r134;     // Catch: Exception -> L27
        this.fd304ba20 = 5;     // Catch: Exception -> L27
        object r02 = p98cf21b1.md95a43c7(this.this$0).getSellReceiptForPayback(r0.getSellReceiptUuid(), this);     // Catch: Exception -> L27
        if (r02 == r1) goto L79;
        decimal r03 = r134;
        r13 = r02;
    L136:
        ped663a3e r135 = (ped663a3e) r13;     // Catch: Exception -> L27
        if (r135 is null) goto L145;
        List<pad7c4a1f> r136 = r135.getPayments();     // Catch: Exception -> L27
        if (r136 is null) goto L145;
        pad7c4a1f r137 = (pad7c4a1f) ICollectionsKt.first(r136);     // Catch: Exception -> L27
        if (r137 is null) goto L145;
        pf8872840 r138 = r137.getTransaction();     // Catch: Exception -> L27
        if (r138 is null) goto L145;
        string r139 = r138.getRrn();     // Catch: Exception -> L27
    L146:
        decimal r42 = r03;
    L174:
        this.L$0 = r42;     // Catch: Exception -> L27
        this.L$1 = r139;     // Catch: Exception -> L27
        this.fd304ba20 = 9;     // Catch: Exception -> L27
        object r04 = p98cf21b1.m32f9f0c1(this.this$0).getPaymentTerminal(this);     // Catch: Exception -> L27
        if (r04 == r1) goto L79;
        string r05 = r139;
        r13 = r04;
    L178:
        pd0910e67 r1310 = (pd0910e67) r13;     // Catch: Exception -> L27
        p98cf21b1.m93b54e67(this.this$0).setValue(r1310);     // Catch: Exception -> L27
        p98cf21b1.ma461eda3(this.this$0, r1310);     // Catch: Exception -> L27
        this.L$0 = r42;     // Catch: Exception -> L27
        this.L$1 = r05;     // Catch: Exception -> L27
        this.L$2 = r1310;     // Catch: Exception -> L27
        this.fd304ba20 = 10;     // Catch: Exception -> L27
        if (p98cf21b1.mb3362370(this.this$0).emit(new p97fa68b7(p98cf21b1.m5fb81a65(this.this$0).getstring(C2815R.string.toph_payback_title), r42, r1310.getTerminalInfo().getMerchantName() + ",\n" + r1310.getTerminalInfo().getMerchantAddress()), this) == r1) goto L79;
        string r9 = r05;
        pd0910e67 r06 = r1310;
    L182:
        p43cba26b r5 = p98cf21b1.m32f9f0c1(this.this$0);     // Catch: Exception -> L27
        p9ded6185 r1311 = p98cf21b1.m3347a8ce(this.this$0);     // Catch: Exception -> L27
        if (r1311 is not null) goto L185;
        Intrinsics.throwUninitializedPropertyAccessException("receipt");     // Catch: Exception -> L27
        p9ded6185 r6 = null;
    L186:
        this.L$0 = r42;     // Catch: Exception -> L27
        this.L$1 = r06;     // Catch: Exception -> L27
        this.L$2 = null;     // Catch: Exception -> L27
        this.fd304ba20 = 11;     // Catch: Exception -> L27
        r13 = r5.initPayback(r6, p7667d148.m55ce55f7(r42), r9, this);     // Catch: Exception -> L27
        if (r13 == r1) goto L79;
        decimal r2 = r42;
    L190:
        p0e6dda02 r1312 = (p0e6dda02) r13;     // Catch: Exception -> L27
        p98cf21b1.m251776c4(this.this$0).setAmount(r2);     // Catch: Exception -> L27
        p98cf21b1.m251776c4(this.this$0).setMerchantName(r06.getTerminalInfo().getMerchantName());     // Catch: Exception -> L27
        p98cf21b1.m251776c4(this.this$0).setCreatedAt(r1312.getTransaction().getTransactionInfo().getTimestamp());     // Catch: Exception -> L27
        p98cf21b1.m0fa733d1(this.this$0, r1312.getTransaction());     // Catch: Exception -> L27
        p98cf21b1.m508a66b4(this.this$0, r1312);     // Catch: Exception -> L27
    L52:
        return Unit.INSTANCE;
    L185:
        r6 = r1311;
    L145:
        r139 = null;
    L79:
        return r1;
    L18:
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
    L118:
        p98cf21b1.m247bc4ee(this.this$0).setValue((pb53cd12b) r13);     // Catch: Exception -> L27
        p98cf21b1 r1313 = this.this$0;     // Catch: Exception -> L27
        p98cf21b1.m1cf38b96(r1313, p98cf21b1.mc4f4919e(r1313).getComboTypeScreen());     // Catch: Exception -> L27
        pad7c4a1f r43 = p98cf21b1.mc4f4919e(this.this$0).getComboPayment();     // Catch: Exception -> L27
        if (r43 is not null) goto L148;
        this.fd304ba20 = 3;     // Catch: Exception -> L27
        r13 = p98cf21b1.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);     // Catch: Exception -> L27
        if (r13 != r1) goto L123;
    L148:
        if (p98cf21b1.ma54a7856(this.this$0) != pbfc85237.f9be5efb7) goto L166;
        p98cf21b1 r07 = this.this$0;     // Catch: Exception -> L27
        this.L$0 = r43;     // Catch: Exception -> L27
        this.L$1 = r07;     // Catch: Exception -> L27
        this.fd304ba20 = 6;     // Catch: Exception -> L27
        r13 = p98cf21b1.md95a43c7(r07).getCurrentPaybackReceipt(this);     // Catch: Exception -> L27
        if (r13 == r1) goto L79;
    L152:
        p98cf21b1.m4fa815b4(r07, (p9ded6185) r13);     // Catch: Exception -> L27
        p0bfd7fb7 r1314 = p98cf21b1.m260c792f(this.this$0);     // Catch: Exception -> L27
        p9ded6185 r08 = p98cf21b1.m3347a8ce(this.this$0);     // Catch: Exception -> L27
        if (r08 is not null) goto L155;
        Intrinsics.throwUninitializedPropertyAccessException("receipt");     // Catch: Exception -> L27
        r08 = null;
    L155:
        this.L$0 = r43;     // Catch: Exception -> L27
        this.L$1 = null;     // Catch: Exception -> L27
        this.fd304ba20 = 7;     // Catch: Exception -> L27
        if (r1314.checkDuplicateReceipt(r08.getUuid(), this) == r1) goto L79;
        pad7c4a1f r09 = r43;
    L159:
        decimal r1315 = r09.getAmount();     // Catch: Exception -> L27
        pad7c4a1f r010 = p98cf21b1.mc4f4919e(this.this$0).getComboPayment();     // Catch: Exception -> L27
        if (r010 is null) goto L164;
        pf8872840 r011 = r010.getTransaction();     // Catch: Exception -> L27
        if (r011 is null) goto L164;
        string r012 = r011.getRrn();     // Catch: Exception -> L27
    L165:
        r42 = r1315;
        r139 = r012;
    L164:
        r012 = null;
        goto L165
    L166:
        p98cf21b1 r013 = this.this$0;     // Catch: Exception -> L27
        this.L$0 = r43;     // Catch: Exception -> L27
        this.L$1 = r013;     // Catch: Exception -> L27
        this.fd304ba20 = 8;     // Catch: Exception -> L27
        r13 = p98cf21b1.m260c792f(r013).getCurrentSellReceipt(this);     // Catch: Exception -> L27
        if (r13 == r1) goto L79;
    L169:
        p98cf21b1.m4fa815b4(r013, (p9ded6185) r13);     // Catch: Exception -> L27
        r1315 = r43.getAmount();     // Catch: Exception -> L27
        pad7c4a1f r014 = p98cf21b1.mc4f4919e(this.this$0).getComboPayment();     // Catch: Exception -> L27
        if (r014 is null) goto L164;
        pf8872840 r015 = r014.getTransaction();     // Catch: Exception -> L27
        if (r015 is null) goto L164;
        r012 = r015.getRrn();     // Catch: Exception -> L27
        goto L165
    L19:
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
    L115:
        this.fd304ba20 = 2;     // Catch: Exception -> L27
        r13 = p98cf21b1.mecf2730e(this.this$0).getShowedNfcCalibrationCoordinates(this);     // Catch: Exception -> L27
        if (r13 != r1) goto L118;
    L32:
        ResultKt.throwOnFailure(r13);
        goto L52
    L111:
        ResultKt.throwOnFailure(r13);
        this.fd304ba20 = 1;     // Catch: Exception -> L27
        if (p98cf21b1.m724546ab(this.this$0).emit(p0890727b.fa82b419a, this) != r1) goto L115;
    L88:
        r09 = (pad7c4a1f) this.L$0;
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
        goto L159
    L55:
        r05 = (string) this.L$1;
        r42 = (decimal) this.L$0;
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
        goto L178
    L43:
        r06 = (pd0910e67) this.L$2;
        string r44 = (string) this.L$1;
        decimal r52 = (decimal) this.L$0;
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
        r9 = r44;
        r42 = r52;
        goto L182
    L72:
        r06 = (pd0910e67) this.L$1;
        r2 = (decimal) this.L$0;
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
        goto L190
    L47:
        r013 = (p98cf21b1) this.L$1;
        r43 = (pad7c4a1f) this.L$0;
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
        goto L169
    L99:
        r03 = (decimal) this.L$0;
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
        goto L136
    L15:
        r0 = (p18cf5223) this.L$0;
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
        goto L129
    L34:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L74:
        r07 = (p98cf21b1) this.L$1;
        r43 = (pad7c4a1f) this.L$0;
        ResultKt.throwOnFailure(r13);     // Catch: Exception -> L27
    L27:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        MutableSharedFlow r016 = p98cf21b1.mad452160(this.this$0);
        p98cf21b1$p6d9e0861$1 r22 = this;
        this.L$0 = null;
        this.L$1 = null;
        this.L$2 = null;
        this.fd304ba20 = 12;
        if (r016.emit(th, r22) == r1) goto L79;
        goto L79
    }
}

