using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P83f5c3ad.Pb3f20355;
using P83f5c3ad.Pb3f20355.Pd229bbf3;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pf983ff65 : p6c37087b {
    private readonly pc33d3892 f0857568b;
    private readonly p7bc7bb5b f08de8767;
    private readonly pc33d3892 f0d6cfcc8;
    private readonly pc33d3892 f2b70622d;
    private readonly pa11ea85a f3133e1ba;
    private readonly p97ae8742 f5500491c;
    private readonly p7bc7bb5b f946e288e;
    private readonly pc33d3892 fa3142772;
    private readonly pc33d3892 fa4c74296;
    private readonly p7bc7bb5b fa8d5e891;
    private readonly pa11ea85a fd1bb1cb3;
    private readonly pa11ea85a fd21e412b;
    private readonly pa11ea85a fd70cd2b2;
    private readonly p7bc7bb5b fe48a5a31;
    private readonly p97ae8742 fef50e602;
    private readonly p7bc7bb5b ff981dc89;

    public pf983ff65(pa11ea85a r2, p7bc7bb5b r3, pc33d3892 r4, p97ae8742 r5) {
        Intrinsics.checkNotNullParameter(r2, "initTapOnPhoneRepository");
        Intrinsics.checkNotNullParameter(r3, "backgroundTapOnPhoneRepository");
        Intrinsics.checkNotNullParameter(r4, "activationTapOnPhoneRepository");
        Intrinsics.checkNotNullParameter(r5, "attestationTapOnPhoneUseCase");
        this.fd1bb1cb3 = r2;
        this.f08de8767 = r3;
        this.f0d6cfcc8 = r4;
        this.fef50e602 = r5;
    }

    public static readonly /* synthetic */ object m07c3cae2(pf983ff65 r0, Continuation r1) {
        return r0.m4114903d(r1);
    }

    private readonly object M4114903d(Continuation<Unit> r6) {
        if (((15 + 32) % 32) > 0) goto L61;
    L61:
        if ((r6 is pf983ff65$p4114903d$1) == true) goto L77;
    L79:
        pf983ff65$p4114903d$1 r0 = new pf983ff65$p4114903d$1(this, r6);
    L56:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L83;
        ResultKt.throwOnFailure(r62);
        pa11ea85a r63 = this.fd1bb1cb3;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r63.initTapOnPhone(r0) != r1) goto L34;
    L42:
        return r1;
    L34:
        if (this.f0d6cfcc8.checkActivated() == false) goto L87;
        p97ae8742 r5 = this.fef50e602;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r5.initAttestation(r0) == r1) goto L42;
    L51:
        return Unit.INSTANCE;
    L87:
        return Unit.INSTANCE;
    L83:
        if (r2 == 1) goto L44;
        if (r2 != 2) goto L3;
        ResultKt.throwOnFailure(r62);
        goto L51
    L3:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L44:
        pf983ff65 this = (pf983ff65) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L34
    L77:
        r0 = (pf983ff65$p4114903d$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L79;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L56
    }

    @Override // p83f5c3ad.p684019bc.p6c37087b
    public object InitTapOnPhone(Continuation<Unit> r4) {
        if (((13 + 12) % 12) > 0) goto L31;
    L31:
        object r3 = this.f08de8767.perform(new pf983ff65$p28472109$2(this, null), r4);
        if (r3 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L29;
        return r3;
    L29:
        return Unit.INSTANCE;
    }

    @Override // p83f5c3ad.p684019bc.p6c37087b
    public object InitTapOnPhoneInBackground(Continuation<Unit> r4) {
        if (((2 + 25) % 25) > 0) goto L13;
    L13:
        object r3 = this.f08de8767.async(new pf983ff65$p7e0a7386$2(this, null), r4);
        if (r3 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L4;
        return r3;
    L4:
        return Unit.INSTANCE;
    }
}

