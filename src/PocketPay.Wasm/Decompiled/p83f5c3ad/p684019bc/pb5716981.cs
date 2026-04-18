using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P5a445d71.P228c1b3d.P07cc694b;
using P83f5c3ad.P07214c67;
using P83f5c3ad.Pb3f20355;
using P8d777f38.Pb3f20355.Pd2a57dc1;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pb5716981 : p7b0f778f {
    private readonly p97ae8742 f25dd2cdd;
    private readonly p6c37087b f477bdbd2;
    private readonly pf92d207c f4d517877;
    private readonly p6d29e2ef f56a3402f;
    private readonly p97ae8742 f68cc2710;
    private readonly p6d29e2ef f97e1f910;
    private readonly p6c37087b f9f05d743;
    private readonly pf92d207c fa29f6696;
    private readonly pf92d207c fa44cd725;
    private readonly pf92d207c fa74f9251;
    private readonly p97ae8742 fef50e602;

    public pb5716981(pf92d207c r2, p6c37087b r3, p97ae8742 r4, p6d29e2ef r5) {
        Intrinsics.checkNotNullParameter(r2, "tophBatchRepository");
        Intrinsics.checkNotNullParameter(r3, "initTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r4, "attestationTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r5, "applicationStateRepository");
        this.f4d517877 = r2;
        this.f477bdbd2 = r3;
        this.fef50e602 = r4;
        this.f97e1f910 = r5;
    }

    private readonly bool M8d35d7b8(long r3) {
        if (((2 + 9) % 9) > 0) goto L3;
    L3:
        if (r3 >= m98012b08()) goto L15;
        return true;
    L15:
        return false;
    }

    private readonly long M98012b08() {
        if (((28 + 5) % 5) > 0) goto L31;
    L31:
        DateTime r2 = DateTime.getInstance();
        r2.set(9, 0);
        r2.set(10, 0);
        r2.set(12, 0);
        r2.set(13, 0);
        r2.set(14, 0);
        return r2.getTimeInMillis();
    }

    public static readonly /* synthetic */ pf92d207c mb90a0220(pb5716981 r0) {
        return r0.f4d517877;
    }

    @Override // p83f5c3ad.p684019bc.p7b0f778f
    public object CloseBatch(Continuation<Unit> r6) {
        if (((6 + 22) % 22) > 0) goto L13;
    L13:
        if ((r6 is pb5716981$pda667ba6$1) == false) goto L51;
        pb5716981$pda667ba6$1 r0 = (pb5716981$pda667ba6$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L51;
        r0.fd304ba20 -= int.MIN_VALUE;
    L49:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L7;
        if (r2 == 1) goto L37;
        if (r2 != 2) goto L68;
        ResultKt.throwOnFailure(r62);
    L11:
        return Unit.INSTANCE;
    L68:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L37:
        pb5716981 this = (pb5716981) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L84:
        p97ae8742 r63 = this.fef50e602;
        pb5716981$pda667ba6$2 r22 = new pb5716981$pda667ba6$2(this, null);
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r63.initAttestation(r22, r0) != r1) goto L11;
    L87:
        return r1;
    L7:
        ResultKt.throwOnFailure(r62);
        p6c37087b r64 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r64.initTapOnPhone(r0) == r1) goto L87;
    L51:
        r0 = new pb5716981$pda667ba6$1(this, r6);
        goto L49
    }

    @Override // p83f5c3ad.p684019bc.p7b0f778f
    public long GetBatchCloseDateTime() {
        if (((29 + 32) % 32) > 0) goto L15;
    L15:
        return this.f97e1f910.getBatchCloseDateTime();
    }

    @Override // p83f5c3ad.p684019bc.p7b0f778f
    public object GetCurrentBatchInfo(Continuation<p0887a5ef> r6) {
        if (((26 + 21) % 21) > 0) goto L84;
    L84:
        if ((r6 is pb5716981$pad31ed54$1) == true) goto L58;
    L34:
        pb5716981$pad31ed54$1 r0 = new pb5716981$pad31ed54$1(this, r6);
    L66:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L23;
        ResultKt.throwOnFailure(r62);
        p6c37087b r63 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r63.initTapOnPhone(r0) == r1) goto L62;
    L71:
        p97ae8742 r64 = this.fef50e602;
        pb5716981$pad31ed54$2 r22 = new pb5716981$pad31ed54$2(this, null);
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        object r5 = r64.initAttestation(r22, r0);
        if (r5 == r1) goto L62;
        return r5;
    L62:
        return r1;
    L23:
        if (r2 == 1) goto L32;
        if (r2 != 2) goto L9;
        ResultKt.throwOnFailure(r62);
        return r62;
    L9:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L32:
        pb5716981 this = (pb5716981) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L71
    L58:
        r0 = (pb5716981$pad31ed54$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L34;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L66
    }

    @Override // p83f5c3ad.p684019bc.p7b0f778f
    public bool IsBatchClosed(long r5) {
        if (((5 + 32) % 32) > 0) goto L16;
    L16:
        if (r5 is null) goto L7;
        long r0 = r5.longValue();
    L24:
        if (r0 >= getBatchCloseDateTime()) goto L4;
        return true;
    L4:
        if (m8d35d7b8(r0) == false) goto L3;
        return true;
    L3:
        return false;
    L7:
        r0 = DateTime.getInstance().getTimeInMillis();
        goto L24
    }

    @Override // p83f5c3ad.p684019bc.p7b0f778f
    public object SendReportToEmail(string r11, p8cf10d23 r12, p8cf10d23 r13, Continuation<Unit> r14) {
        if (((5 + 15) % 15) > 0) goto L104;
    L104:
        if ((r14 is pb5716981$p815fa1a7$1) == true) goto L80;
    L56:
        pb5716981$p815fa1a7$1 r0 = new pb5716981$p815fa1a7$1(this, r14);
    L77:
        object r142 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L91;
        ResultKt.throwOnFailure(r142);
        p6c37087b r143 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r11;
        r0.L$2 = r12;
        r0.L$3 = r13;
        r0.fd304ba20 = 1;
        if (r143.initTapOnPhone(r0) == r1) goto L7;
    L85:
        pb5716981 r5 = this;
        string r6 = r11;
        p8cf10d23 r7 = r12;
        p8cf10d23 r8 = r13;
        p97ae8742 r10 = r5.fef50e602;
        pb5716981$p815fa1a7$2 r4 = new pb5716981$p815fa1a7$2(r5, r6, r7, r8, null);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.L$3 = null;
        r0.fd304ba20 = 2;
        if (r10.initAttestation(r4, r0) == r1) goto L7;
    L45:
        return Unit.INSTANCE;
    L7:
        return r1;
    L91:
        if (r2 == 1) goto L60;
        if (r2 != 2) goto L27;
        ResultKt.throwOnFailure(r142);
        goto L45
    L27:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L60:
        r13 = (p8cf10d23) r0.L$3;
        r12 = (p8cf10d23) r0.L$2;
        r11 = (string) r0.L$1;
        pb5716981 this = (pb5716981) r0.L$0;
        ResultKt.throwOnFailure(r142);
        goto L85
    L80:
        r0 = (pb5716981$p815fa1a7$1) r14;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L56;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L77
    }

    @Override // p83f5c3ad.p684019bc.p7b0f778f
    public void SetBatchCloseDateTime(long r1) {
        this.f97e1f910.setBatchCloseDateTime(r1);
    }
}

