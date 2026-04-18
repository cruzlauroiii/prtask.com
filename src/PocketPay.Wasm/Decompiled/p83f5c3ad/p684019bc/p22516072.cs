using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P83f5c3ad.Pb3f20355;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p22516072 : p6c387cae {
    private readonly p97ae8742 f2b65ced4;
    private readonly p6c37087b f477bdbd2;
    private readonly p5701b2ff f479f6a11;
    private readonly p97ae8742 f69c87676;
    private readonly p5701b2ff f7f93a8f8;
    private readonly p6c37087b f8dfc1aeb;
    private readonly p5701b2ff fbe869830;
    private readonly p97ae8742 fce82f7e3;
    private readonly p97ae8742 fef50e602;

    public p22516072(p5701b2ff r2, p6c37087b r3, p97ae8742 r4) {
        Intrinsics.checkNotNullParameter(r2, "tophReceiptRepository");
        Intrinsics.checkNotNullParameter(r3, "initTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r4, "attestationTapOnPhoneUseCase");
        this.f7f93a8f8 = r2;
        this.f477bdbd2 = r3;
        this.fef50e602 = r4;
    }

    public static readonly /* synthetic */ p5701b2ff m459df111(p22516072 r0) {
        return r0.f7f93a8f8;
    }

    @Override // p83f5c3ad.p684019bc.p6c387cae
    public object GetPaymentTransaction(p9ded6185 r6, string r7, Continuation<pf8872840> r8) {
        if (((12 + 4) % 4) > 0) goto L74;
    L74:
        if ((r8 is p22516072$p646a1688$1) == false) goto L4;
        p22516072$p646a1688$1 r0 = (p22516072$p646a1688$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L4;
        r0.fd304ba20 -= int.MIN_VALUE;
    L43:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L18;
        ResultKt.throwOnFailure(r82);
        p6c37087b r83 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.L$2 = r7;
        r0.fd304ba20 = 1;
        if (r83.initTapOnPhone(r0) == r1) goto L63;
    L50:
        p97ae8742 r84 = this.fef50e602;
        p22516072$p646a1688$2 r22 = new p22516072$p646a1688$2(this, r6, r7, null);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        object r5 = r84.initAttestation(r22, r0);
        if (r5 == r1) goto L63;
        return r5;
    L63:
        return r1;
    L18:
        if (r2 == 1) goto L68;
        if (r2 != 2) goto L6;
        ResultKt.throwOnFailure(r82);
        return r82;
    L6:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L68:
        r7 = (string) r0.L$2;
        r6 = (p9ded6185) r0.L$1;
        p22516072 this = (p22516072) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L4:
        r0 = new p22516072$p646a1688$1(this, r8);
        goto L43
    }

    @Override // p83f5c3ad.p684019bc.p6c387cae
    public object GetReceiptLink(p9ded6185 r6, string r7, Continuation<string> r8) {
        if (((12 + 12) % 12) > 0) goto L50;
    L50:
        if ((r8 is p22516072$pca754add$1) == false) goto L10;
        p22516072$pca754add$1 r0 = (p22516072$pca754add$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L10;
        r0.fd304ba20 -= int.MIN_VALUE;
    L36:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L65;
        if (r2 == 1) goto L74;
        if (r2 != 2) goto L47;
        ResultKt.throwOnFailure(r82);
        return r82;
    L47:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L74:
        r7 = (string) r0.L$2;
        r6 = (p9ded6185) r0.L$1;
        p22516072 this = (p22516072) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L6:
        p97ae8742 r83 = this.fef50e602;
        p22516072$pca754add$2 r22 = new p22516072$pca754add$2(this, r6, r7, null);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        object r5 = r83.initAttestation(r22, r0);
        if (r5 == r1) goto L58;
        return r5;
    L58:
        return r1;
    L65:
        ResultKt.throwOnFailure(r82);
        p6c37087b r84 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.L$2 = r7;
        r0.fd304ba20 = 1;
        if (r84.initTapOnPhone(r0) == r1) goto L58;
    L10:
        r0 = new p22516072$pca754add$1(this, r8);
        goto L36
    }

    @Override // p83f5c3ad.p684019bc.p6c387cae
    public object SendReceiptToEmail(p9ded6185 r11, string r12, string r13, Continuation<Unit> r14) {
        if (((8 + 11) % 11) > 0) goto L51;
    L51:
        if ((r14 is p22516072$pac0d5389$1) == false) goto L12;
        p22516072$pac0d5389$1 r0 = (p22516072$pac0d5389$1) r14;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L12;
        r0.fd304ba20 -= int.MIN_VALUE;
    L87:
        object r142 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L68;
        ResultKt.throwOnFailure(r142);
        p6c37087b r143 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r11;
        r0.L$2 = r12;
        r0.L$3 = r13;
        r0.fd304ba20 = 1;
        if (r143.initTapOnPhone(r0) == r1) goto L99;
    L67:
        p22516072 r5 = this;
        p9ded6185 r6 = r11;
        string r7 = r12;
        string r8 = r13;
        p97ae8742 r10 = r5.fef50e602;
        p22516072$pac0d5389$2 r4 = new p22516072$pac0d5389$2(r5, r6, r7, r8, null);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.L$3 = null;
        r0.fd304ba20 = 2;
        if (r10.initAttestation(r4, r0) == r1) goto L99;
    L33:
        return Unit.INSTANCE;
    L99:
        return r1;
    L68:
        if (r2 == 1) goto L17;
        if (r2 != 2) goto L55;
        ResultKt.throwOnFailure(r142);
        goto L33
    L55:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L17:
        r13 = (string) r0.L$3;
        r12 = (string) r0.L$2;
        r11 = (p9ded6185) r0.L$1;
        p22516072 this = (p22516072) r0.L$0;
        ResultKt.throwOnFailure(r142);
    L12:
        r0 = new p22516072$pac0d5389$1(this, r14);
        goto L87
    }

    @Override // p83f5c3ad.p684019bc.p6c387cae
    public object SendReceiptToPhone(p9ded6185 r11, string r12, string r13, Continuation<Unit> r14) {
        if (((14 + 7) % 7) > 0) goto L12;
    L12:
        if ((r14 is p22516072$pe52ef3ad$1) == false) goto L61;
        p22516072$pe52ef3ad$1 r0 = (p22516072$pe52ef3ad$1) r14;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L61;
        r0.fd304ba20 -= int.MIN_VALUE;
    L102:
        object r142 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L95;
        if (r2 == 1) goto L44;
        if (r2 != 2) goto L74;
        ResultKt.throwOnFailure(r142);
    L46:
        return Unit.INSTANCE;
    L74:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L44:
        r13 = (string) r0.L$3;
        r12 = (string) r0.L$2;
        r11 = (p9ded6185) r0.L$1;
        p22516072 this = (p22516072) r0.L$0;
        ResultKt.throwOnFailure(r142);
    L26:
        p22516072 r5 = this;
        p9ded6185 r6 = r11;
        string r7 = r12;
        string r8 = r13;
        p97ae8742 r10 = r5.fef50e602;
        p22516072$pe52ef3ad$2 r4 = new p22516072$pe52ef3ad$2(r5, r6, r7, r8, null);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.L$3 = null;
        r0.fd304ba20 = 2;
        if (r10.initAttestation(r4, r0) != r1) goto L46;
    L93:
        return r1;
    L95:
        ResultKt.throwOnFailure(r142);
        p6c37087b r143 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r11;
        r0.L$2 = r12;
        r0.L$3 = r13;
        r0.fd304ba20 = 1;
        if (r143.initTapOnPhone(r0) == r1) goto L93;
    L61:
        r0 = new p22516072$pe52ef3ad$1(this, r14);
        goto L102
    }
}

