using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P2e5d8aa3.Pf83c2a85.Pac143fb7;
using P83f5c3ad.Pb3f20355;
using Pad5f82e8.P07214c67.P12df53fe;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pe4f4fc44 : p0f3e1f02 {
    private readonly pe9f5a71f f1780f089;
    private readonly pe9f5a71f f41b67d7a;
    private readonly pe9f5a71f f4e0df132;
    private readonly pe9f5a71f f50679872;
    private readonly pe9f5a71f f8e4b3524;
    private readonly pdcfa0c32 f93a4a46b;
    private readonly pdcfa0c32 fce765563;

    public pe4f4fc44(pe9f5a71f r2, pdcfa0c32 r3) {
        Intrinsics.checkNotNullParameter(r2, "tapOnPhoneInfoRepository");
        Intrinsics.checkNotNullParameter(r3, "paymentHashSettingsUseCase");
        this.f50679872 = r2;
        this.fce765563 = r3;
    }

    private readonly object M6d01568a(bool r6, bool r7, Continuation<Unit> r8) {
        if (((16 + 2) % 2) > 0) goto L91;
    L91:
        if ((r8 is pe4f4fc44$p6d01568a$1) == true) goto L65;
    L16:
        pe4f4fc44$p6d01568a$1 r0 = new pe4f4fc44$p6d01568a$1(this, r8);
    L49:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L58;
        ResultKt.throwOnFailure(r82);
        if (r6 == false) goto L54;
        if (r7 == true) goto L23;
        pdcfa0c32 r62 = this.fce765563;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r62.setQrPaymentsEnabled(true, r0) != r1) goto L11;
    L31:
        return r1;
    L11:
        this.f50679872.showQrBanner();
    L23:
        return Unit.INSTANCE;
    L54:
        pdcfa0c32 r63 = this.fce765563;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r63.setQrPaymentsEnabled(false, r0) == r1) goto L31;
    L4:
        this.hideQrBanner();
        goto L23
    L58:
        if (r2 == 1) goto L56;
        if (r2 != 2) goto L46;
        pe4f4fc44 this = (pe4f4fc44) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L11
    L46:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L56:
        this = (pe4f4fc44) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L4
    L65:
        r0 = (pe4f4fc44$p6d01568a$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L16;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L49
    }

    public static readonly /* synthetic */ object mbba01bda(pe4f4fc44 r0, bool r1, bool r2, Continuation r3) {
        return r0.m6d01568a(r1, r2, r3);
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public void ClearTapOnPhoneInfo() {
        this.f50679872.clearTapOnPhoneInfo();
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public pe6acf149 GetQrBanner() {
        return this.f50679872.getQrBanner();
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public string GetTapOnPhoneMid() {
        return this.f50679872.getTapOnPhoneMid();
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public string GetTapOnPhoneTid() {
        return this.f50679872.getTapOnPhoneTid();
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public void HideQrBanner() {
        this.f50679872.hideQrBanner();
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public bool IsQrEnabled() {
        return this.f50679872.getTapOnPhoneIsQrEnabled();
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public object SetQrEnabled(bool r3, Continuation<Unit> r4) {
        if (((3 + 29) % 29) > 0) goto L12;
    L12:
        bool r0 = isQrEnabled();
        this.f50679872.setTapOnPhoneIsQrEnabled(r3);
        object r2 = m6d01568a(r3, r0, r4);
        if (r2 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r2;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public object UpdateTapOnPhoneInfo(Continuation<Unit> r6) {
        if (((25 + 29) % 29) > 0) goto L45;
    L45:
        if ((r6 is pe4f4fc44$p19bdeb17$1) == true) goto L4;
    L52:
        pe4f4fc44$p19bdeb17$1 r0 = new pe4f4fc44$p19bdeb17$1(this, r6);
    L38:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L59;
        ResultKt.throwOnFailure(r62);
        bool r63 = isQrEnabled();
        pe9f5a71f r22 = this.f50679872;
        r0.L$0 = this;
        r0.Z$0 = r63;
        r0.fd304ba20 = 1;
        if (r22.updateTapOnPhoneInfo(r0) != r1) goto L15;
    L21:
        return r1;
    L15:
        bool r23 = this.isQrEnabled();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (this.m6d01568a(r23, r63, r0) == r1) goto L21;
    L9:
        return Unit.INSTANCE;
    L59:
        if (r2 == 1) goto L78;
        if (r2 != 2) goto L90;
        ResultKt.throwOnFailure(r62);
        goto L9
    L90:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L78:
        bool r5 = r0.Z$0;
        pe4f4fc44 r24 = (pe4f4fc44) r0.L$0;
        ResultKt.throwOnFailure(r62);
        r63 = r5;
        pe4f4fc44 this = r24;
        goto L15
    L4:
        r0 = (pe4f4fc44$p19bdeb17$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L52;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L38
    }

    @Override // p83f5c3ad.p684019bc.p0f3e1f02
    public object UpdateTapOnPhoneQrInfo(Continuation<Unit> r6) {
        if (((20 + 17) % 17) > 0) goto L87;
    L87:
        if ((r6 is pe4f4fc44$peaf50bd0$1) == true) goto L42;
    L84:
        pe4f4fc44$peaf50bd0$1 r0 = new pe4f4fc44$peaf50bd0$1(this, r6);
    L23:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L57;
        if (r2 == 1) goto L24;
        if (r2 != 2) goto L64;
        ResultKt.throwOnFailure(r62);
    L46:
        return Unit.INSTANCE;
    L64:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L24:
        bool r5 = r0.Z$0;
        pe4f4fc44 r22 = (pe4f4fc44) r0.L$0;
        ResultKt.throwOnFailure(r62);
        bool r63 = r5;
        pe4f4fc44 this = r22;
    L56:
        bool r23 = this.isQrEnabled();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (this.m6d01568a(r23, r63, r0) != r1) goto L46;
    L21:
        return r1;
    L57:
        ResultKt.throwOnFailure(r62);
        r63 = isQrEnabled();
        pe9f5a71f r24 = this.f50679872;
        r0.L$0 = this;
        r0.Z$0 = r63;
        r0.fd304ba20 = 1;
        if (r24.updateTapOnPhoneQrInfo(r0) == r1) goto L21;
    L42:
        r0 = (pe4f4fc44$peaf50bd0$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L84;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L23
    }
}

