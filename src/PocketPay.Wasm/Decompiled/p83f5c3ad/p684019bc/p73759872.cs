using Com.Google.Firebase.Analytics;
using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.P0eb9b3af.P8a5da52e.P07214c67;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.P0eb9b3af.P9efab239.P407482fe.Pcd9de119;
using P83f5c3ad.Pb3f20355;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p73759872 : p039f11a6 {
    private readonly p6c37087b f00f31c05;
    private readonly p6c37087b f22017631;
    private readonly p6c37087b f477bdbd2;
    private readonly p97ae8742 f497ccd8f;
    private readonly p6c37087b f71ef09c4;
    private readonly p6c37087b f7afb6d81;
    private readonly p72c833ef f7bf04f6e;
    private readonly p97ae8742 fc1c7626c;
    private readonly p72c833ef fc9ef0407;
    private readonly p72c833ef fcfe95268;
    private readonly p97ae8742 fd9721c08;
    private readonly p97ae8742 fdfd96483;
    private readonly p97ae8742 fef50e602;

    public p73759872(p72c833ef r2, p6c37087b r3, p97ae8742 r4) {
        Intrinsics.checkNotNullParameter(r2, "tophQRPaymentRepository");
        Intrinsics.checkNotNullParameter(r3, "initTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r4, "attestationTapOnPhoneUseCase");
        this.fc9ef0407 = r2;
        this.f477bdbd2 = r3;
        this.fef50e602 = r4;
    }

    @Override // p83f5c3ad.p684019bc.p039f11a6
    public object CheckStatus(Continuation<p06660b7d> r7) {
        if (((11 + 13) % 13) > 0) goto L32;
    L32:
        if ((r7 is p73759872$pa3fd92e9$1) == false) goto L45;
        p73759872$pa3fd92e9$1 r0 = (p73759872$pa3fd92e9$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L45;
        r0.fd304ba20 -= int.MIN_VALUE;
    L47:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L66;
        ResultKt.throwOnFailure(r72);
        p6c37087b r73 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r73.initTapOnPhone(r0) == r1) goto L7;
    L10:
        p97ae8742 r74 = this.fef50e602;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r74.initAttestation(r0) == r1) goto L7;
    L72:
        p72c833ef r6 = this.fc9ef0407;
        r0.L$0 = null;
        r0.fd304ba20 = 3;
        object r62 = r6.checkStatus(r0);
        if (r62 == r1) goto L7;
        return r62;
    L7:
        return r1;
    L66:
        if (r2 == 1) goto L60;
        if (r2 == 2) goto L71;
        if (r2 != 3) goto L95;
        ResultKt.throwOnFailure(r72);
        return r72;
    L95:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L71:
        p73759872 this = (p73759872) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L72
    L60:
        this = (p73759872) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L45:
        r0 = new p73759872$pa3fd92e9$1(this, r7);
        goto L47
    }

    @Override // p83f5c3ad.p684019bc.p039f11a6
    public object Confirm(Continuation<Unit> r7) {
        if (((25 + 1) % 1) > 0) goto L41;
    L41:
        if ((r7 is p73759872$pd0cf705f$1) == true) goto L97;
    L47:
        p73759872$pd0cf705f$1 r0 = new p73759872$pd0cf705f$1(this, r7);
    L17:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L71;
        ResultKt.throwOnFailure(r72);
        p6c37087b r73 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r73.initTapOnPhone(r0) == r1) goto L36;
    L94:
        p97ae8742 r74 = this.fef50e602;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r74.initAttestation(r0) == r1) goto L36;
    L40:
        p72c833ef r6 = this.fc9ef0407;
        r0.L$0 = null;
        r0.fd304ba20 = 3;
        if (r6.confirm(r0) == r1) goto L36;
    L67:
        return Unit.INSTANCE;
    L36:
        return r1;
    L71:
        if (r2 == 1) goto L15;
        if (r2 == 2) goto L101;
        if (r2 != 3) goto L20;
        ResultKt.throwOnFailure(r72);
        goto L67
    L20:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L101:
        p73759872 this = (p73759872) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L40
    L15:
        this = (p73759872) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L94
    L97:
        r0 = (p73759872$pd0cf705f$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L47;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L17
    }

    @Override // p83f5c3ad.p684019bc.p039f11a6
    public object CreateQR(long r9, Continuation<p150f1761> r11) {
        if (((1 + 32) % 32) > 0) goto L109;
    L109:
        if ((r11 is p73759872$pde767b34$1) == true) goto L33;
    L15:
        p73759872$pde767b34$1 r0 = new p73759872$pde767b34$1(this, r11);
    L51:
        object r112 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 == 0) goto L42;
        if (r2 != 1) goto L27;
        r9 = r0.J$0;
        p73759872 this = (p73759872) r0.L$0;
        ResultKt.throwOnFailure(r112);
    L97:
        p97ae8742 r113 = this.fef50e602;
        r0.L$0 = this;
        r0.J$0 = r9;
        r0.label = 2;
        if (r113.initAttestation(r0) != r1) goto L78;
    L13:
        return r1;
    L78:
        p73759872 r10 = this;
        long r8 = r9;
    L69:
        p72c833ef r102 = r10.fc9ef0407;
        r0.L$0 = null;
        r0.label = 3;
        object r82 = r102.createQR(r8, r0);
        if (r82 == r1) goto L13;
        return r82;
    L27:
        if (r2 != 2) goto L106;
        r8 = r0.J$0;
        r10 = (p73759872) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L69
    L106:
        if (r2 != 3) goto L23;
        ResultKt.throwOnFailure(r112);
        return r112;
    L23:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L42:
        ResultKt.throwOnFailure(r112);
        p6c37087b r114 = this.f477bdbd2;
        r0.L$0 = this;
        r0.J$0 = r9;
        r0.label = 1;
        if (r114.initTapOnPhone(r0) == r1) goto L13;
    L33:
        r0 = (p73759872$pde767b34$1) r11;
        if ((r0.label & int.MIN_VALUE) == 0) goto L15;
        r0.label -= int.MIN_VALUE;
        goto L51
    }

    @Override // p83f5c3ad.p684019bc.p039f11a6
    public object Refund(decimal r8, string r9, Continuation<Unit> r10) {
        if (((3 + 5) % 5) > 0) goto L96;
    L96:
        if ((r10 is p73759872$pdf6f8568$1) == true) goto L32;
    L115:
        p73759872$pdf6f8568$1 r0 = new p73759872$pdf6f8568$1(this, r10);
    L88:
        object r102 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L121;
        ResultKt.throwOnFailure(r102);
        p6c37087b r103 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r8;
        r0.L$2 = r9;
        r0.fd304ba20 = 1;
        if (r103.initTapOnPhone(r0) != r1) goto L111;
    L20:
        return r1;
    L111:
        p97ae8742 r104 = this.fef50e602;
        r0.L$0 = this;
        r0.L$1 = r8;
        r0.L$2 = r9;
        r0.fd304ba20 = 2;
        if (r104.initAttestation(r0) == r1) goto L20;
        string r6 = r9;
        p73759872 r92 = this;
        string r7 = r6;
    L40:
        p72c833ef r93 = r92.fc9ef0407;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 3;
        if (r93.refund(r8, r7, r0) == r1) goto L20;
    L69:
        return Unit.INSTANCE;
    L121:
        if (r2 == 1) goto L31;
        if (r2 == 2) goto L104;
        if (r2 != 3) goto L67;
        ResultKt.throwOnFailure(r102);
        goto L69
    L67:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L104:
        r7 = (string) r0.L$2;
        r8 = (decimal) r0.L$1;
        r92 = (p73759872) r0.L$0;
        ResultKt.throwOnFailure(r102);
        goto L40
    L31:
        r9 = (string) r0.L$2;
        r8 = (decimal) r0.L$1;
        p73759872 this = (p73759872) r0.L$0;
        ResultKt.throwOnFailure(r102);
        goto L111
    L32:
        r0 = (p73759872$pdf6f8568$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L115;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L88
    }
}

