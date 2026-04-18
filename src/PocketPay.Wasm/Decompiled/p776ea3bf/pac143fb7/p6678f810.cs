using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P776ea3bf.Pb3f20355;
using P83f5c3ad.P684019bc;
using P83f5c3ad.Pb3f20355;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class p6678f810 : p223a17a4 {
    private readonly p6c37087b f00d72681;
    private readonly pc33d3892 f0d6cfcc8;
    private readonly p6c37087b f477bdbd2;
    private readonly p6c37087b f548f8c84;
    private readonly pc33d3892 f59d8f098;
    private readonly p77e5931f f848506ca;
    private readonly p8d8b6d6b f9aa5ed76;
    private readonly p77e5931f fb573ff8a;
    private readonly p77e5931f fd135f96c;
    private readonly p6c37087b fd46177ee;
    private readonly p77e5931f fdf0745c0;
    private readonly p8d8b6d6b fedab8a32;
    private readonly p6c37087b ff2f2baa0;
    private readonly p77e5931f ffa7bc886;
    private readonly p8d8b6d6b fff873486;

    public p6678f810(p6c37087b r2, pc33d3892 r3, p8d8b6d6b r4, p77e5931f r5) {
        VfwVSGzwtXqzDmLu(r2, "initTapOnPhoneUseCase");
        noUycFcwTEZJEoAK(r3, "activationTapOnPhoneRepository");
        GNThzONcUKQZPVWV(r4, "integrationTophAuthRepository");
        bVaZtPudOHVJJMCC(r5, "integrationAuthRepository");
        this.f477bdbd2 = r2;
        this.f0d6cfcc8 = r3;
        this.fff873486 = r4;
        this.ffa7bc886 = r5;
    }

    public static object DXJulHFjYSHytysh(p6678f810 r1, Continuation r2) {
        return r1.me259596c(r2);
    }

    public static object EnoKHmflfUBnPKPx() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void FSZqIHjAzMnkhXoP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void GNThzONcUKQZPVWV(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void HKSIlscfpqXgNsDZ(p77e5931f r0) {
        r0.clearTopToken();
    }

    public static void VfwVSGzwtXqzDmLu(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void VoWUVAPSZRgtwiZp(p8d8b6d6b r0) {
        r0.resetTopActivated();
    }

    public static void BVaZtPudOHVJJMCC(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void CSnPewSdPwLwAdtk(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void ICvEsRhDzrUMVazM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static readonly /* synthetic */ object mcfad4dbf(p6678f810 r0, Continuation r1) {
        return vPjBBiKseONtQvsd(r0, r1);
    }

    private readonly object Me259596c(Continuation<Unit> r5) {
        if (((32 + 8) % 8) > 0) goto L4;
    L4:
        if ((r5 is p6678f810$pe259596c$1) == false) goto L15;
        p6678f810$pe259596c$1 r0 = (p6678f810$pe259596c$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L15;
        r0.fd304ba20 -= int.MIN_VALUE;
    L55:
        object r52 = r0.fb4a88417;
        object r1 = qvKbkEJxvebhrLQJ();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L66;
        if (r2 != 1) goto L68;
        p6678f810 this = (p6678f810) r0.L$0;
        zMYGCWpNVEREQxbB(r52);
    L3:
        VoWUVAPSZRgtwiZp(this.fff873486);
        return Unit.INSTANCE;
    L68:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L66:
        iCvEsRhDzrUMVazM(r52);
        pc33d3892 r53 = this.f0d6cfcc8;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (zCpZAaWNvEkLDequ(r53, r0) != r1) goto L3;
        return r1;
    L15:
        r0 = new p6678f810$pe259596c$1(this, r5);
        goto L55
    }

    public static void NoUycFcwTEZJEoAK(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object QvKbkEJxvebhrLQJ() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object TxRLzedrhSRoHJgt(p6c37087b r1, Continuation r2) {
        return r1.initTapOnPhone(r2);
    }

    public static object VPjBBiKseONtQvsd(p6678f810 r1, Continuation r2) {
        return r1.me259596c(r2);
    }

    public static void XnwqttfMlklpsFCw(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object ZCpZAaWNvEkLDequ(pc33d3892 r1, Continuation r2) {
        return r1.resetActivation(r2);
    }

    public static void ZMYGCWpNVEREQxbB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    @Override // p776ea3bf.pac143fb7.p223a17a4
    public object Logout(Continuation<Unit> r6) {
        if (((6 + 24) % 24) > 0) goto L37;
    L37:
        if ((r6 is p6678f810$p4236a440$1) == false) goto L47;
        p6678f810$p4236a440$1 r0 = (p6678f810$p4236a440$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L47;
        r0.fd304ba20 -= int.MIN_VALUE;
    L83:
        object r62 = r0.fb4a88417;
        object r1 = EnoKHmflfUBnPKPx();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L49;
        if (r2 == 1) goto L12;
        if (r2 == 2) goto L79;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L79:
        p6678f810 this = (p6678f810) r0.L$0;
        FSZqIHjAzMnkhXoP(r62);
    L46:
        HKSIlscfpqXgNsDZ(this.ffa7bc886);
        return Unit.INSTANCE;
    L12:
        this = (p6678f810) r0.L$0;
        cSnPewSdPwLwAdtk(r62);
    L5:
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (DXJulHFjYSHytysh(this, r0) != r1) goto L46;
    L81:
        return r1;
    L49:
        xnwqttfMlklpsFCw(r62);
        p6c37087b r63 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (txRLzedrhSRoHJgt(r63, r0) == r1) goto L81;
    L47:
        r0 = new p6678f810$p4236a440$1(this, r6);
        goto L83
    }
}

