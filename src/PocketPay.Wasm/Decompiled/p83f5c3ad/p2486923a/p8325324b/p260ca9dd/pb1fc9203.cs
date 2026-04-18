using Androidx.Lifecycle;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using P2b3583e6;
using P2b3583e6.P263e3cef;
using P2e5d8aa3.Pee11cbb1.Pac143fb7;
using P4670093c.Pfd9160bb;
using P8325324b.Pac143fb7;
using P8325324b.Pfd9160bb;
using P83f5c3ad.P684019bc;
using P83f5c3ad.Pfd9160bb;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pc69c522d.Pf83c2a85.Pac143fb7;
using Pc69c522d.Pf83c2a85.Pfd9160bb;
using Pd2a57dc1.Pfd9160bb;
using Pe0bd4e89.Pdd56421b.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pb1fc9203 : objectModel {
    private readonly p76204a3d f053d1b76;
    private readonly p1ceed351 f0e223d3b;
    private readonly LiveData<pb3f3bb37> f19e12fb9;
    private readonly p1b3a5bf0 f2b2a1791;
    private readonly pc32333e1 f2c7cc7fa;
    private readonly pd44f3792 f35636a7b;
    private readonly pfdb21b31 f37b6a15b;
    private readonly pc32333e1 f3e785377;
    private readonly pd44f3792 f3f793272;
    private readonly p76204a3d f4cad11f4;
    private readonly p1ceed351 f4df1b583;
    private readonly p1ceed351 f62520fad;
    private readonly p0bfd7fb7 f656c88ab;
    private readonly pd44f3792 f6c2676d5;
    private pad7c4a1f f6cefba87;
    private pad7c4a1f f73be81ac;
    private readonly p5fa140e9 f7c886773;
    private readonly MutableLiveData<pb3f3bb37> f7fd6b7fe;
    private readonly p1b3a5bf0 f82375300;
    private readonly LiveData f852df831;
    private readonly pc32333e1 f97aeea31;
    private readonly p5fa140e9 f9817bc27;
    private readonly pb88b530f f9ce9b510;
    private readonly MutableLiveData fa41bc8a5;
    private readonly p76204a3d fa6b11a18;
    private readonly p76204a3d fa6fce7c7;
    private readonly p1b3a5bf0 fac4ea88d;
    private readonly pb88b530f facbeeb72;
    private readonly pb88b530f facf5b200;
    private readonly p5fa140e9 fb0400c49;
    private pad7c4a1f fb155b5d8;
    private readonly pc32333e1 fbba394c9;
    private readonly p0bfd7fb7 fbba87fec;
    private readonly p5fa140e9 fc20e7a59;
    private readonly p76204a3d fc598f8a0;
    private readonly pfdb21b31 fc60cfa04;
    private readonly LiveData fcb414d50;
    private readonly pb88b530f fde4561b6;
    private pad7c4a1f fe2f71f6d;
    private readonly pfdb21b31 fe4ef1a6a;
    private readonly pc32333e1 febbee703;
    private readonly LiveData fed06c767;
    private readonly p11c216e8 feefeb260;
    private pad7c4a1f ffcb3626b;
    private readonly p11c216e8 fffa39ac4;

    public pb1fc9203(pfdb21b31 r2, p0bfd7fb7 r3, p76204a3d r4, pb88b530f r5, p11c216e8 r6, p1ceed351 r7, pd44f3792 r8, p5fa140e9 r9, pc32333e1 r10, p1b3a5bf0 r11) {
        Intrinsics.checkNotNullParameter(r2, "userHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r3, "sellReceiptUseCase");
        Intrinsics.checkNotNullParameter(r4, "tophHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r5, "paybackComboUseCase");
        Intrinsics.checkNotNullParameter(r6, "flowRouter");
        Intrinsics.checkNotNullParameter(r7, "tapOnPhoneRouter");
        Intrinsics.checkNotNullParameter(r8, "advanceReceiptsRouter");
        Intrinsics.checkNotNullParameter(r9, "sellRouter");
        Intrinsics.checkNotNullParameter(r10, "comboPaymentRouter");
        Intrinsics.checkNotNullParameter(r11, "paybackRouter");
        this.f37b6a15b = r2;
        this.f656c88ab = r3;
        this.f053d1b76 = r4;
        this.facf5b200 = r5;
        this.feefeb260 = r6;
        this.f62520fad = r7;
        this.f6c2676d5 = r8;
        this.f9817bc27 = r9;
        this.f3e785377 = r10;
        this.f2b2a1791 = r11;
        p6a6d86aa r22 = new p6a6d86aa();
        this.f7fd6b7fe = r22;
        this.f19e12fb9 = r22;
    }

    public static /* synthetic */ void m08682853(pb1fc9203 r0, p9ded6185 r1, object r2) {
        me040328a(r0, r1, r2);
    }

    public static readonly /* synthetic */ void m1029195c(pb1fc9203 r0, ped663a3e r1) {
        r0.mc81fad03(r1);
    }

    private readonly bool M2c7d7c34(ped663a3e r1) {
        if (p517b902b.m842bf95c(r1).compareTo(decimal.ZERO) == 0) goto L5;
        return false;
    L5:
        return true;
    }

    public static readonly /* synthetic */ object m56f945da(pb1fc9203 r0, ped663a3e r1, Continuation r2) {
        return r0.m6abf6ddc(r1, r2);
    }

    public static readonly /* synthetic */ object m5abc8463(pb1fc9203 r0, ped663a3e r1, Continuation r2) {
        return r0.m5ecd558e(r1, r2);
    }

    private readonly object M5ecd558e(ped663a3e r1, Continuation<Unit> r2) {
        object r0 = m6abf6ddc(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    private readonly object M6182313d(p18cf5223 r9, Continuation<Unit> r10) {
        if (((20 + 32) % 32) > 0) goto L59;
    L59:
        if ((r10 is pb1fc9203$p6182313d$1) == false) goto L43;
        pb1fc9203$p6182313d$1 r0 = (pb1fc9203$p6182313d$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L43;
        r0.fd304ba20 -= int.MIN_VALUE;
    L7:
        object r102 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L41;
        if (r2 == 1) goto L40;
        if (r2 == 2) goto L115;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L115:
        pb1fc9203 this = (pb1fc9203) r0.L$0;
        ResultKt.throwOnFailure(r102);
    L14:
        this.f2b2a1791.backToPaybackReceiptList();
    L110:
        return Unit.INSTANCE;
    L40:
        this = (pb1fc9203) r0.L$0;
        ResultKt.throwOnFailure(r102);
    L116:
        pb88b530f r92 = this.facf5b200;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r92.clearPaybackPositions(r0) != r1) goto L14;
    L77:
        return r1;
    L41:
        ResultKt.throwOnFailure(r102);
        List<pad7c4a1f> r93 = ICollectionsKt.sortedWith(r9.getPayments(), new pb1fc9203$p6182313d$pd41d8cd9$pec404527$pe8462a18$1());
        if (this.facf5b200.isFullCancelAmount(this.fe2f71f6d, r93) == false) goto L104;
        pb88b530f r94 = this.facf5b200;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r94.removeAllPaymentsFromReceipt(r0) == r1) goto L77;
    L104:
        this.feefeb260.replaceFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.f6718aa2c, null, this.facf5b200.getNextCancelPayment(this.fe2f71f6d, r93), pbfc85237.fa59af09e, 2, null));
    L43:
        r0 = new pb1fc9203$p6182313d$1(this, r10);
        goto L7
    }

    private readonly object M6abf6ddc(ped663a3e r6, Continuation<Unit> r7) {
        if (((13 + 6) % 6) > 0) goto L42;
    L42:
        if ((r7 is pb1fc9203$p6abf6ddc$1) == false) goto L54;
        pb1fc9203$p6abf6ddc$1 r0 = (pb1fc9203$p6abf6ddc$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L54;
        r0.fd304ba20 -= int.MIN_VALUE;
    L47:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L61;
        ResultKt.throwOnFailure(r72);
        if (r6.getReceiptType() == p22820a6f.fcc52554c) goto L26;
        pfdb21b31 r62 = this.f37b6a15b;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = r62.isFastSellEnabled(r0);
        if (r72 != r1) goto L65;
    L48:
        return r1;
    L65:
        if (((bool) r72).boolValue() == true) goto L111;
        p0bfd7fb7 r63 = this.f656c88ab;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r63.openEmptySellReceipt(r0) == r1) goto L48;
    L100:
        this.feefeb260.backFromFlowTo(p5fa140e9.pb0da8397.mbcdc39c7(this.f9817bc27, null, 1, null));
    L40:
        return Unit.INSTANCE;
    L111:
        this.feefeb260.backFromFlowTo(this.f9817bc27.getFastSellChoosePaySystemScreen());
        goto L40
    L26:
        this.feefeb260.backFromFlowTo(this.f6c2676d5.getAdvanceReceiptListScreen());
        goto L40
    L61:
        if (r2 == 1) goto L38;
        if (r2 == 2) goto L77;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L77:
        pb1fc9203 this = (pb1fc9203) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L100
    L38:
        this = (pb1fc9203) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L54:
        r0 = new pb1fc9203$p6abf6ddc$1(this, r7);
        goto L47
    }

    public static readonly /* synthetic */ object m80399c29(pb1fc9203 r0, p18cf5223 r1, Continuation r2) {
        return r0.m6182313d(r1, r2);
    }

    private readonly void M8d94c3b6(p9ded6185 r4) {
        if (((4 + 1) % 1) > 0) goto L14;
    L14:
        p1ceed351 r0 = this.f62520fad;
        r0.setResultListener(r0.getTophPaymentKey(), new pb1fc9203$pd41d8cd9$p95263d50(this, r4));
    }

    private readonly void Mc81fad03(ped663a3e r2) {
        if (m2c7d7c34(r2) == false) goto L16;
        md0a0e572(r2);
        return;
    L16:
        this.feefeb260.backFromFlowTo(this.f3e785377.getComboPaymentScreen());
    }

    private readonly void Md0a0e572(ped663a3e r2) {
        this.feefeb260.replaceFlow(this.f9817bc27.getSellReceiptSuccessfullySent(r2));
    }

    public static readonly /* synthetic */ p1ceed351 mdc7bed18(pb1fc9203 r0) {
        return r0.f62520fad;
    }

    private static readonly void Me040328a(pb1fc9203 r1, p9ded6185 r2, object r3) {
        Intrinsics.checkNotNullParameter(r3, "snackBarData");
        if ((r3 is pb3f3bb37) == true) goto L16;
        r1.backToScreen(r2);
        return;
    L16:
        r1.f7fd6b7fe.setValue(r3);
    }

    public readonly void BackToScreen(p9ded6185 r8) {
        if (((13 + 3) % 3) > 0) goto L12;
    L12:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pb1fc9203$p48be14e4$1(r8, this, null), 3, null);
    }

    public readonly pbfc85237 GetComboTypeScreen() {
        return this.f053d1b76.getComboTypeScreen();
    }

    public readonly LiveData<pb3f3bb37> GetSnackBarState() {
        return this.f19e12fb9;
    }

    public readonly void OpenQrSlip(p9ded6185 r2) {
        Intrinsics.checkNotNullParameter(r2, "receipt");
        m8d94c3b6(r2);
        this.f62520fad.openQrSlip(r2);
    }

    public readonly void OpenSendReceiptToEmail(p9ded6185 r2) {
        Intrinsics.checkNotNullParameter(r2, "receipt");
        m8d94c3b6(r2);
        this.f62520fad.openSendReceiptToEmail(r2);
    }

    public readonly void OpenSendReceiptToPhone(p9ded6185 r2) {
        Intrinsics.checkNotNullParameter(r2, "receipt");
        m8d94c3b6(r2);
        this.f62520fad.openSendReceiptToPhone(r2);
    }
}

