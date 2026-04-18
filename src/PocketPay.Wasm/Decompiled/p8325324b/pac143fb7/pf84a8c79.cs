using Com.Google.Android.Gms.Measurement.Api;
using Com.Google.Firebase.Analytics;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P8325324b.Pb3f20355;
using P8d777f38.Pb3f20355.Pd2a57dc1;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pe0212e54.Pb3f20355;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pf84a8c79 : p0bfd7fb7 {
    private readonly pef9926d1 f1ffe46c0;
    private readonly p44cd4abe f2a446288;
    private readonly p6d29e2ef f3b221080;
    private readonly pef9926d1 f3cd4a202;
    private readonly p44cd4abe f8af308bf;
    private readonly p3851083a f91b5f5ab;
    private readonly p6d29e2ef f97e1f910;
    private readonly p6d29e2ef f9b0a5a29;
    private readonly p3851083a f9d84311b;
    private readonly p44cd4abe fab168a8c;
    private readonly p44cd4abe fb14c10aa;
    private readonly pef9926d1 fd8f0064e;

    public pf84a8c79(p3851083a r2, pef9926d1 r3, p44cd4abe r4, p6d29e2ef r5) {
        Intrinsics.checkNotNullParameter(r2, "sellReceiptRepository");
        Intrinsics.checkNotNullParameter(r3, "sellReceiptDbRepository");
        Intrinsics.checkNotNullParameter(r4, "devicesRepository");
        Intrinsics.checkNotNullParameter(r5, "applicationStateRepository");
        this.f91b5f5ab = r2;
        this.fd8f0064e = r3;
        this.f8af308bf = r4;
        this.f97e1f910 = r5;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object AddPositionToReceipt(pd031d465 r6, Continuation<Unit> r7) {
        if (((32 + 8) % 8) > 0) goto L16;
    L16:
        if ((r7 is pf84a8c79$p234facb0$1) == true) goto L10;
    L3:
        pf84a8c79$p234facb0$1 r0 = new pf84a8c79$p234facb0$1(this, r7);
    L42:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L56;
        if (r2 == 1) goto L46;
        if (r2 != 2) goto L59;
        ResultKt.throwOnFailure(r72);
    L88:
        return Unit.INSTANCE;
    L59:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L46:
        r6 = (pd031d465) r0.L$1;
        pf84a8c79 this = (pf84a8c79) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L61:
        p3851083a r5 = this.f91b5f5ab;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.addPositionToReceipt(r6, r0) != r1) goto L88;
    L26:
        return r1;
    L56:
        ResultKt.throwOnFailure(r72);
        p3851083a r73 = this.f91b5f5ab;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        if (r73.clearReceiptDiscount(r0) == r1) goto L26;
    L10:
        r0 = (pf84a8c79$p234facb0$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L3;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L42
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object CheckDuplicateReceipt(string r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.checkDuplicateReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object GetCurrentSellReceipt(Continuation<ped663a3e> r1) {
        return this.f91b5f5ab.getSellReceipt(r1);
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object GetLastFastSellPosition(Continuation<p3df4ea74> r7) {
        if (((19 + 21) % 21) > 0) goto L18;
    L18:
        if ((r7 is pf84a8c79$p99a76d2b$1) == false) goto L77;
        pf84a8c79$p99a76d2b$1 r0 = (pf84a8c79$p99a76d2b$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L77;
        r0.fd304ba20 -= int.MIN_VALUE;
    L3:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L25;
        ResultKt.throwOnFailure(r72);
        pef9926d1 r73 = this.fd8f0064e;
        p44cd4abe r6 = this.f8af308bf;
        r0.L$0 = r73;
        r0.fd304ba20 = 1;
        object r62 = r6.getSelectedDevice(r0);
        if (r62 != r1) goto L59;
    L34:
        return r1;
    L59:
        r72 = r62;
        pef9926d1 r63 = r73;
    L76:
        string r74 = ((p4f30e9bd) r72).getDeviceId();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        object r64 = r63.getLastFastSellPosition(r74, r0);
        if (r64 == r1) goto L34;
        return r64;
    L25:
        if (r2 == 1) goto L24;
        if (r2 != 2) goto L21;
        ResultKt.throwOnFailure(r72);
        return r72;
    L21:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L24:
        r63 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L77:
        r0 = new pf84a8c79$p99a76d2b$1(this, r7);
        goto L3
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object GetNoteReceipt(Continuation<string> r1) {
        return this.f91b5f5ab.getNoteReceipt(r1);
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object GetReceiptPositions(Continuation<? super List<pd031d465>> r1) {
        return this.f91b5f5ab.getReceiptPositions(r1);
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object HasUnfinishedReceipt(Continuation<bool> r1) {
        return this.f91b5f5ab.hasUnfinishedReceipt(r1);
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object IncreasePositionQuantity(pd031d465 r6, decimal r7, Continuation<Unit> r8) {
        if (((27 + 22) % 22) > 0) goto L7;
    L7:
        if ((r8 is pf84a8c79$p643683c5$1) == false) goto L80;
        pf84a8c79$p643683c5$1 r0 = (pf84a8c79$p643683c5$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L80;
        r0.fd304ba20 -= int.MIN_VALUE;
    L76:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L11;
        if (r2 == 1) goto L63;
        if (r2 != 2) goto L26;
        ResultKt.throwOnFailure(r82);
    L70:
        return Unit.INSTANCE;
    L26:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L63:
        r7 = (decimal) r0.L$2;
        r6 = (pd031d465) r0.L$1;
        pf84a8c79 this = (pf84a8c79) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L51:
        p3851083a r5 = this.f91b5f5ab;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        if (r5.increasePositionQuantity(r6, r7, r0) != r1) goto L70;
    L12:
        return r1;
    L11:
        ResultKt.throwOnFailure(r82);
        p3851083a r83 = this.f91b5f5ab;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.L$2 = r7;
        r0.fd304ba20 = 1;
        if (r83.clearReceiptDiscount(r0) == r1) goto L12;
    L80:
        r0 = new pf84a8c79$p643683c5$1(this, r8);
        goto L76
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public bool IsAnimationNotePreviewShown() {
        bool r0 = this.f97e1f910.getAnimationPreview().getNoteReceiptAnimation();
        if (r0 is not null) goto L4;
        return false;
    L4:
        return r0.boolValue();
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public bool IsAnimationPreviewShown() {
        bool r0 = this.f97e1f910.getAnimationPreview().getSellPositionAnimation();
        if (r0 is not null) goto L13;
        return false;
    L13:
        return r0.boolValue();
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object OpenEmptySellReceipt(Continuation<Unit> r1) {
        object r0 = this.f91b5f5ab.openEmptySellReceipt(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L15;
        return r0;
    L15:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object OpenNotEmptySellReceipt(ped663a3e r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.openNotEmptySellReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L9;
        return r0;
    L9:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object OpenOrEditSellReceipt(Continuation<Unit> r1) {
        object r0 = this.f91b5f5ab.openOrEditSellReceipt(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object OpenSinglePaymentIfNeeded(Continuation<Unit> r1) {
        object r0 = this.f91b5f5ab.openSinglePaymentIfNeeded(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L7;
        return r0;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object RemoveAllPositionsFromReceipt(Continuation<Unit> r6) {
        if (((32 + 26) % 26) > 0) goto L63;
    L63:
        if ((r6 is pf84a8c79$p5be57e9d$1) == true) goto L66;
    L43:
        pf84a8c79$p5be57e9d$1 r0 = new pf84a8c79$p5be57e9d$1(this, r6);
    L76:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L6;
        ResultKt.throwOnFailure(r62);
        p3851083a r63 = this.f91b5f5ab;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r63.clearReceiptDiscount(r0) == r1) goto L33;
    L70:
        p3851083a r5 = this.f91b5f5ab;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r5.removeAllPositionsFromReceipt(r0) == r1) goto L33;
    L12:
        return Unit.INSTANCE;
    L33:
        return r1;
    L6:
        if (r2 == 1) goto L37;
        if (r2 != 2) goto L16;
        ResultKt.throwOnFailure(r62);
        goto L12
    L16:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L37:
        pf84a8c79 this = (pf84a8c79) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L70
    L66:
        r0 = (pf84a8c79$p5be57e9d$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L43;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L76
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object RemoveCurrentReceipt(Continuation<Unit> r1) {
        object r0 = this.f91b5f5ab.removeCurrentReceipt(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L13;
        return r0;
    L13:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object RemovePositionFromReceipt(pd031d465 r6, Continuation<Unit> r7) {
        if (((11 + 1) % 1) > 0) goto L53;
    L53:
        if ((r7 is pf84a8c79$pc5336464$1) == false) goto L27;
        pf84a8c79$pc5336464$1 r0 = (pf84a8c79$pc5336464$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L27;
        r0.fd304ba20 -= int.MIN_VALUE;
    L39:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L73;
        ResultKt.throwOnFailure(r72);
        p3851083a r73 = this.f91b5f5ab;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        if (r73.clearReceiptDiscount(r0) == r1) goto L90;
    L84:
        p3851083a r5 = this.f91b5f5ab;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.removePositionFromReceipt(r6, r0) == r1) goto L90;
    L47:
        return Unit.INSTANCE;
    L90:
        return r1;
    L73:
        if (r2 == 1) goto L45;
        if (r2 != 2) goto L18;
        ResultKt.throwOnFailure(r72);
        goto L47
    L18:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L45:
        r6 = (pd031d465) r0.L$1;
        pf84a8c79 this = (pf84a8c79) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L27:
        r0 = new pf84a8c79$pc5336464$1(this, r7);
        goto L39
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object ReplacePosition(pd031d465 r6, pd031d465 r7, Continuation<Unit> r8) {
        if (((20 + 13) % 13) > 0) goto L68;
    L68:
        if ((r8 is pf84a8c79$pb7ecc47b$1) == true) goto L81;
    L82:
        pf84a8c79$pb7ecc47b$1 r0 = new pf84a8c79$pb7ecc47b$1(this, r8);
    L66:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L53;
        ResultKt.throwOnFailure(r82);
        p3851083a r83 = this.f91b5f5ab;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.L$2 = r7;
        r0.fd304ba20 = 1;
        if (r83.clearReceiptDiscount(r0) == r1) goto L48;
    L29:
        p3851083a r5 = this.f91b5f5ab;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        if (r5.replacePosition(r6, r7, r0) == r1) goto L48;
    L92:
        return Unit.INSTANCE;
    L48:
        return r1;
    L53:
        if (r2 == 1) goto L88;
        if (r2 != 2) goto L64;
        ResultKt.throwOnFailure(r82);
        goto L92
    L64:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L88:
        r7 = (pd031d465) r0.L$2;
        r6 = (pd031d465) r0.L$1;
        pf84a8c79 this = (pf84a8c79) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L29
    L81:
        r0 = (pf84a8c79$pb7ecc47b$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L82;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L66
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public void SetAnimationNotePreviewIsShown() {
        if (((25 + 5) % 5) > 0) goto L23;
    L23:
        pd4ccf9ff r1 = this.f97e1f910.getAnimationPreview();
        this.f97e1f910.setAnimationPreview(pd4ccf9ff.m1c1e012b(r1, null, null, null, null, true, null, 47, null));
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public void SetAnimationPreviewIsShown() {
        if (((28 + 28) % 28) > 0) goto L29;
    L29:
        pd4ccf9ff r1 = this.f97e1f910.getAnimationPreview();
        this.f97e1f910.setAnimationPreview(pd4ccf9ff.m1c1e012b(r1, true, null, null, null, null, null, 62, null));
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetLastFastSellPosition(string r7, decimal r8, Continuation<Unit> r9) {
        if (((22 + 9) % 9) > 0) goto L29;
    L29:
        if ((r9 is pf84a8c79$padc69192$1) == false) goto L25;
        pf84a8c79$padc69192$1 r0 = (pf84a8c79$padc69192$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L25;
        r0.fd304ba20 -= int.MIN_VALUE;
    L87:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L50;
        if (r2 == 1) goto L71;
        if (r2 != 2) goto L52;
        ResultKt.throwOnFailure(r92);
    L80:
        return Unit.INSTANCE;
    L52:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L71:
        pef9926d1 r6 = (pef9926d1) r0.L$2;
        r8 = (decimal) r0.L$1;
        r7 = (string) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L51:
        string r93 = ((p4f30e9bd) r92).getDeviceId();
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        if (r6.setLastSellPosition(r93, r7, r8, r0) != r1) goto L80;
    L56:
        return r1;
    L50:
        ResultKt.throwOnFailure(r92);
        pef9926d1 r94 = this.fd8f0064e;
        p44cd4abe r62 = this.f8af308bf;
        r0.L$0 = r7;
        r0.L$1 = r8;
        r0.L$2 = r94;
        r0.fd304ba20 = 1;
        object r63 = r62.getSelectedDevice(r0);
        if (r63 == r1) goto L56;
        r92 = r63;
        r6 = r94;
    L25:
        r0 = new pf84a8c79$padc69192$1(this, r9);
        goto L87
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetNoteReceipt(string r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setNoteReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L7;
        return r0;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetPaymentAddress(string r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setPaymentAddress(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L15;
        return r0;
    L15:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetPaymentPlace(string r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setPaymentPlace(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L7;
        return r0;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetPaymentType(p8c261c90 r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setPaymentType(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetQRPayInfo(pc5f0acf1 r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setQRPayInfo(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetReceiptClientEmail(string r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setReceiptClientEmail(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetReceiptClientPhone(string r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setReceiptClientPhone(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L12;
        return r0;
    L12:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetShouldPrintReceipt(bool r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setShouldPrintReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L4;
        return r0;
    L4:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object SetTransactionToFirstPayment(pf8872840 r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.setTransactionToFirstPayment(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L6;
        return r0;
    L6:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object UpdatePayment(pad7c4a1f r1, string r2, Continuation<Unit> r3) {
        object r0 = this.f91b5f5ab.updatePayment(r1, r2, r3);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L9;
        return r0;
    L9:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object UpdatePosition(pd031d465 r6, Continuation<Unit> r7) {
        if (((30 + 3) % 3) > 0) goto L4;
    L4:
        if ((r7 is pf84a8c79$p4c5a4754$1) == false) goto L13;
        pf84a8c79$p4c5a4754$1 r0 = (pf84a8c79$p4c5a4754$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L13;
        r0.fd304ba20 -= int.MIN_VALUE;
    L7:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L85;
        ResultKt.throwOnFailure(r72);
        p3851083a r73 = this.f91b5f5ab;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        if (r73.clearReceiptDiscount(r0) == r1) goto L64;
    L70:
        p3851083a r5 = this.f91b5f5ab;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.updatePosition(r6, r0) == r1) goto L64;
    L74:
        return Unit.INSTANCE;
    L64:
        return r1;
    L85:
        if (r2 == 1) goto L69;
        if (r2 != 2) goto L23;
        ResultKt.throwOnFailure(r72);
        goto L74
    L23:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L69:
        r6 = (pd031d465) r0.L$1;
        pf84a8c79 this = (pf84a8c79) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L13:
        r0 = new pf84a8c79$p4c5a4754$1(this, r7);
        goto L7
    }

    @Override // p8325324b.pac143fb7.p0bfd7fb7
    public object UpdateReceiptDiscount(decimal r1, Continuation<Unit> r2) {
        object r0 = this.f91b5f5ab.updateReceiptDiscount(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L10;
        return r0;
    L10:
        return Unit.INSTANCE;
    }
}

