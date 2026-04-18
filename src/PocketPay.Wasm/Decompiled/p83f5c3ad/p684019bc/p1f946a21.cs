using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P50484c19.P2b3583e6.Pc2c30812.Pcaf97d07;
using P83f5c3ad.P07214c67;
using P83f5c3ad.Pb3f20355;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p1f946a21 : p995fd851 {
    private readonly p97ae8742 f0f980bee;
    private readonly p97ae8742 f1066d67d;
    private readonly pf2914733 f2f60d940;
    private readonly p6c37087b f477bdbd2;
    private readonly pf2914733 f8a90370e;
    private readonly p6c37087b fc1319df2;
    private readonly p97ae8742 fc4c15ea5;
    private readonly p6c37087b fca3971c2;
    private readonly pf2914733 feb076e14;
    private readonly p97ae8742 fef50e602;

    public p1f946a21(pf2914733 r2, p6c37087b r3, p97ae8742 r4) {
        Intrinsics.checkNotNullParameter(r2, "nfcTapOnPhoneRepository");
        Intrinsics.checkNotNullParameter(r3, "initTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r4, "attestationTapOnPhoneUseCase");
        this.feb076e14 = r2;
        this.f477bdbd2 = r3;
        this.fef50e602 = r4;
    }

    public static readonly /* synthetic */ pf2914733 ma596edd8(p1f946a21 r0) {
        return r0.feb076e14;
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public object CalibrateNfc(pd0910e67 r6, Continuation<pe6ff918f> r7) {
        if (((13 + 20) % 20) > 0) goto L57;
    L57:
        if ((r7 is p1f946a21$p8b4c9bdf$1) == true) goto L14;
    L34:
        p1f946a21$p8b4c9bdf$1 r0 = new p1f946a21$p8b4c9bdf$1(this, r7);
    L48:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L5;
        if (r2 == 1) goto L81;
        if (r2 != 2) goto L21;
        ResultKt.throwOnFailure(r72);
        return r72;
    L21:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L81:
        r6 = (pd0910e67) r0.L$1;
        p1f946a21 this = (p1f946a21) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L33:
        p97ae8742 r73 = this.fef50e602;
        p1f946a21$p8b4c9bdf$2 r22 = new p1f946a21$p8b4c9bdf$2(this, r6, null);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        object r5 = r73.initAttestation(r22, r0);
        if (r5 == r1) goto L3;
        return r5;
    L3:
        return r1;
    L5:
        ResultKt.throwOnFailure(r72);
        p6c37087b r74 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        if (r74.initTapOnPhone(r0) == r1) goto L3;
    L14:
        r0 = (p1f946a21$p8b4c9bdf$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L34;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L48
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public object GetShowedNfcCalibrationCoordinates(Continuation<pb53cd12b> r6) {
        if (((30 + 19) % 19) > 0) goto L37;
    L37:
        if ((r6 is p1f946a21$p1658310a$1) == true) goto L52;
    L12:
        p1f946a21$p1658310a$1 r0 = new p1f946a21$p1658310a$1(this, r6);
    L60:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L26;
        if (r2 == 1) goto L50;
        if (r2 != 2) goto L9;
        ResultKt.throwOnFailure(r62);
        return r62;
    L9:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L50:
        p1f946a21 this = (p1f946a21) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L56:
        p97ae8742 r63 = this.fef50e602;
        p1f946a21$p1658310a$2 r22 = new p1f946a21$p1658310a$2(this, null);
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        object r5 = r63.initAttestation(r22, r0);
        if (r5 == r1) goto L57;
        return r5;
    L57:
        return r1;
    L26:
        ResultKt.throwOnFailure(r62);
        p6c37087b r64 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r64.initTapOnPhone(r0) == r1) goto L57;
    L52:
        r0 = (p1f946a21$p1658310a$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L12;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L60
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public bool HasNfcFeature() {
        return this.feb076e14.hasNfcFeature();
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public object IsNfcCalibrated(Continuation<bool> r6) {
        if (((31 + 15) % 15) > 0) goto L51;
    L51:
        if ((r6 is p1f946a21$pb48d42b5$1) == true) goto L79;
    L25:
        p1f946a21$pb48d42b5$1 r0 = new p1f946a21$pb48d42b5$1(this, r6);
    L57:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L60;
        ResultKt.throwOnFailure(r62);
        p6c37087b r63 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r63.initTapOnPhone(r0) == r1) goto L15;
    L80:
        p97ae8742 r64 = this.fef50e602;
        p1f946a21$pb48d42b5$2 r22 = new p1f946a21$pb48d42b5$2(this, null);
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        object r5 = r64.initAttestation(r22, r0);
        if (r5 == r1) goto L15;
        return r5;
    L15:
        return r1;
    L60:
        if (r2 == 1) goto L59;
        if (r2 != 2) goto L38;
        ResultKt.throwOnFailure(r62);
        return r62;
    L38:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L59:
        p1f946a21 this = (p1f946a21) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L80
    L79:
        r0 = (p1f946a21$pb48d42b5$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L25;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L57
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public bool IsNfcEnabled() {
        return this.feb076e14.isNfcEnabled();
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public bool IsShowNfcSpot() {
        return this.feb076e14.isShowNfcSpot();
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public Flow<p2484c164> ObserveNfcCardCommunicationStatus(pd0910e67 r2) {
        Intrinsics.checkNotNullParameter(r2, "paymentTerminal");
        return this.feb076e14.observeNfcCardCommunicationStatus(r2);
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public object SetNfcCalibrationCoordinates(pd0910e67 r6, pb53cd12b r7, Continuation<Unit> r8) {
        if (((30 + 19) % 19) > 0) goto L7;
    L7:
        if ((r8 is p1f946a21$p89cd2ac7$1) == false) goto L62;
        p1f946a21$p89cd2ac7$1 r0 = (p1f946a21$p89cd2ac7$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L62;
        r0.fd304ba20 -= int.MIN_VALUE;
    L6:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L64;
        ResultKt.throwOnFailure(r82);
        p6c37087b r83 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.L$2 = r7;
        r0.fd304ba20 = 1;
        if (r83.initTapOnPhone(r0) != r1) goto L13;
    L42:
        return r1;
    L13:
        p97ae8742 r84 = this.fef50e602;
        p1f946a21$p89cd2ac7$2 r22 = new p1f946a21$p89cd2ac7$2(this, r6, r7, null);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        if (r84.initAttestation(r22, r0) == r1) goto L42;
    L54:
        return Unit.INSTANCE;
    L64:
        if (r2 == 1) goto L61;
        if (r2 != 2) goto L35;
        ResultKt.throwOnFailure(r82);
        goto L54
    L35:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L61:
        r7 = (pb53cd12b) r0.L$2;
        r6 = (pd0910e67) r0.L$1;
        p1f946a21 this = (p1f946a21) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L62:
        r0 = new p1f946a21$p89cd2ac7$1(this, r8);
        goto L6
    }

    @Override // p83f5c3ad.p684019bc.p995fd851
    public void SetShowNfcSpot(bool r1) {
        this.feb076e14.setShowNfcSpot(r1);
    }
}

