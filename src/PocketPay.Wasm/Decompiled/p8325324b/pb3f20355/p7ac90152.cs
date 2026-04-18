using Com.Google.Android.Gms.Measurement.Api;
using Com.Google.Firebase.Analytics;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P8325324b.P07214c67.Pd77d5e50;
using P8325324b.Pf0719ea8;
using P8d777f38.Pd77d5e50.Pf0719ea8;
using P8d777f38.Pd77d5e50.Pf5e638cc.P4b9f83e1;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p7ac90152 : pef9926d1 {
    private readonly pdc2c8d7c f21285072;
    private readonly p71d29d12 f67b0527e;
    private readonly pdc2c8d7c f79751c28;
    private readonly p71d29d12 f983760be;
    private readonly p71d29d12 fc3fb2402;
    private readonly p71d29d12 fcc18febe;
    private readonly p71d29d12 ffb5f4c94;

    public p7ac90152(p71d29d12 r2, pdc2c8d7c r3) {
        Intrinsics.checkNotNullParameter(r2, "currentSellReceiptDao");
        Intrinsics.checkNotNullParameter(r3, "fastSellHashSettingsDao");
        this.f67b0527e = r2;
        this.f79751c28 = r3;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object ClearCurrentSellReceipts(Continuation<Unit> r1) {
        object r0 = this.f67b0527e.clearCurrentSellReceipts(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L8;
        return r0;
    L8:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object CreateCurrentSellReceipt(pf79cee86 r1, List<p0160554c> r2, List<p32a285cf> r3, Continuation<Unit> r4) {
        object r0 = this.f67b0527e.createCurrentSellReceipt(r1, r2, r3, r4);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L15;
        return r0;
    L15:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object CreateSinglePayment(p32a285cf r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.createSinglePayment(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object DeletePayment(p32a285cf r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.deletePayment(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object DeletePayments(List<p32a285cf> r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.deletePayments(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L6;
        return r0;
    L6:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object DeletePosition(p0160554c r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.deletePosition(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L14;
        return r0;
    L14:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object DeletePositions(List<p0160554c> r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.deletePositions(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L10;
        return r0;
    L10:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object DeleteReceipt(pf79cee86 r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.deleteReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object GetCurrentSellReceipt(string r5, Continuation<p2c903942> r6) {
        if (((25 + 16) % 16) > 0) goto L67;
    L67:
        if ((r6 is p7ac90152$p661f6c0a$1) == true) goto L37;
    L65:
        p7ac90152$p661f6c0a$1 r0 = new p7ac90152$p661f6c0a$1(this, r6);
    L73:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L61;
        if (r2 != 1) goto L54;
        ResultKt.throwOnFailure(r62);
    L18:
        p2c903942 r63 = (p2c903942) r62;
        if (r63 is null) goto L49;
        return r63;
    L49:
        throw new Exception("Receipt not created");
    L54:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L61:
        ResultKt.throwOnFailure(r62);
        p71d29d12 r4 = this.f67b0527e;
        r0.fd304ba20 = 1;
        r62 = r4.getCurrentSellReceipt(r5, r0);
        if (r62 != r1) goto L18;
        return r1;
    L37:
        r0 = (p7ac90152$p661f6c0a$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L65;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L73
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object GetLastFastSellPosition(string r6, Continuation<p3df4ea74> r7) {
        if (((22 + 28) % 28) > 0) goto L14;
    L14:
        if ((r7 is p7ac90152$p99a76d2b$1) == true) goto L56;
    L65:
        p7ac90152$p99a76d2b$1 r0 = new p7ac90152$p99a76d2b$1(this, r7);
    L27:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L34;
        ResultKt.throwOnFailure(r72);
        p1d202900 r73 = p1d202900.f76425f17;
        pdc2c8d7c r5 = this.f79751c28;
        r0.L$0 = r73;
        r0.fd304ba20 = 1;
        object r52 = r5.getFastSellHashSettings(r6, r0);
        if (r52 != r1) goto L45;
        return r1;
    L45:
        r72 = r52;
        p1d202900 r53 = r73;
    L60:
        return r53.toFastSellPosition((p985d1fa1) r72);
    L34:
        if (r2 != 1) goto L12;
        r53 = (p1d202900) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L60
    L12:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L56:
        r0 = (p7ac90152$p99a76d2b$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L65;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L27
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object GetSellReceiptByType(string r1, string r2, Continuation<p2c903942> r3) {
        return this.f67b0527e.getSellReceiptByType(r1, r2, r3);
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object InsertPayment(p32a285cf r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.insertPayment(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object InsertPayments(List<p32a285cf> r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.insertPayments(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L15;
        return r0;
    L15:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object InsertPosition(p0160554c r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.insertPosition(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L9;
        return r0;
    L9:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object ReplacePosition(p0160554c r1, p0160554c r2, Continuation<Unit> r3) {
        object r0 = this.f67b0527e.replacePosition(r1, r2, r3);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L11;
        return r0;
    L11:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object SelectReceipt(string r1, string r2, Continuation<Unit> r3) {
        object r0 = this.f67b0527e.selectReceipt(r1, r2, r3);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L13;
        return r0;
    L13:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object SetLastSellPosition(string r14, string r15, decimal r16, Continuation<Unit> r17) {
        if (((20 + 16) % 16) > 0) goto L35;
    L35:
        if ((r17 is p7ac90152$pda46e512$1) == true) goto L109;
    L10:
        p7ac90152$pda46e512$1 r1 = new p7ac90152$pda46e512$1(this, r17);
    L99:
        object r0 = r1.fb4a88417;
        object r2 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r3 = r1.fd304ba20;
        if (r3 != 0) goto L54;
        ResultKt.throwOnFailure(r0);
        pdc2c8d7c r02 = this.f79751c28;
        r1.L$0 = this;
        r1.L$1 = r15;
        r1.L$2 = r16;
        r1.fd304ba20 = 1;
        r0 = r02.getFastSellHashSettings(r14, r1);
        if (r0 == r2) goto L106;
        string r7 = r15;
        decimal r8 = r16;
    L98:
        p985d1fa1 r5 = (p985d1fa1) r0;
        if (r5 is null) goto L22;
        pdc2c8d7c r13 = this.f79751c28;
        p985d1fa1 r142 = p985d1fa1.m1c1e012b(r5, null, r7, r8, false, false, 25, null);
        r1.L$0 = null;
        r1.L$1 = null;
        r1.L$2 = null;
        r1.fd304ba20 = 2;
        if (r13.saveFastSellHashSettings(r142, r1) == r2) goto L106;
    L22:
        return Unit.INSTANCE;
    L106:
        return r2;
    L54:
        if (r3 == 1) goto L67;
        if (r3 != 2) goto L7;
        ResultKt.throwOnFailure(r0);
        goto L22
    L7:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L67:
        decimal r132 = (decimal) r1.L$2;
        string r143 = (string) r1.L$1;
        p7ac90152 r32 = (p7ac90152) r1.L$0;
        ResultKt.throwOnFailure(r0);
        r8 = r132;
        r7 = r143;
        p7ac90152 this = r32;
        goto L98
    L109:
        r1 = (p7ac90152$pda46e512$1) r17;
        if ((r1.fd304ba20 & int.MIN_VALUE) == 0) goto L10;
        r1.fd304ba20 -= int.MIN_VALUE;
        goto L99
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object UpdatePayment(p32a285cf r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.updatePayment(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L14;
        return r0;
    L14:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object UpdatePaymentTransaction(string r11, p85cc901a r12, Continuation<Unit> r13) {
        if (((17 + 10) % 10) > 0) goto L26;
    L26:
        p71d29d12 r0 = this.f67b0527e;
        string r2 = r12.getRrn();
        string r3 = r12.getStan();
        string r4 = r12.getAuthCode();
        string r5 = r12.getResponseCode();
        string r10 = r12.getTopRefUuid();
        if (r10 is not null) goto L35;
        string r6 = "";
    L27:
        string r102 = r12.getTerminalId();
        if (r102 is not null) goto L43;
        string r7 = "";
    L34:
        string r103 = r12.getMerchantId();
        if (r103 is null) goto L50;
        string r8 = r103;
    L46:
        object r104 = r0.updatePaymentTransaction(r11, r2, r3, r4, r5, r6, r7, r8, r13);
        if (r104 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L48;
        return r104;
    L48:
        return Unit.INSTANCE;
    L50:
        r8 = "";
        goto L46
    L43:
        r7 = r102;
        goto L34
    L35:
        r6 = r10;
        goto L27
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object UpdatePosition(p0160554c r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.updatePosition(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.pef9926d1
    public object UpdateReceipt(pf79cee86 r1, Continuation<Unit> r2) {
        object r0 = this.f67b0527e.updateReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L12;
        return r0;
    L12:
        return Unit.INSTANCE;
    }
}

