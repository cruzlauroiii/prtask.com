using Android.Content;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Flow;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.P24eed33e;
using P83f5c3ad.P07214c67;
using P83f5c3ad.P684019bc.P42552b1f;
using P83f5c3ad.P684019bc.P94a08da1;
using P83f5c3ad.Pb3f20355;
using Pad5f82e8.Pac143fb7.P49f290d6;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p0effc55e : pe9ddd6b8 {
    private readonly paa56254c f0a4a4279;
    private readonly p6c37087b f0a616434;
    private readonly pc33d3892 f0d6cfcc8;
    private readonly p4a931563 f1e998877;
    private readonly p6c37087b f25d88615;
    private readonly paa56254c f41102a0d;
    private readonly p6c37087b f477bdbd2;
    private readonly p6c37087b f606d1a56;
    private readonly pc33d3892 f7003fec1;
    private readonly p2f3c4196 f7ace4edf;
    private readonly p4a931563 fa1f2994b;
    private readonly pc33d3892 fa48a342d;
    private readonly pc33d3892 fa757b182;
    private readonly pc33d3892 fd007a140;
    private readonly p2f3c4196 fe639d08f;

    public p0effc55e(p4a931563 r2, pc33d3892 r3, p6c37087b r4, paa56254c r5, p2f3c4196 r6) {
        Intrinsics.checkNotNullParameter(r2, "globalTophActivationRepository");
        Intrinsics.checkNotNullParameter(r3, "activationTapOnPhoneRepository");
        Intrinsics.checkNotNullParameter(r4, "initTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r5, "tophTokenUseCase");
        Intrinsics.checkNotNullParameter(r6, "userInfoUseCase");
        this.fa1f2994b = r2;
        this.f0d6cfcc8 = r3;
        this.f477bdbd2 = r4;
        this.f0a4a4279 = r5;
        this.fe639d08f = r6;
    }

    public static readonly /* synthetic */ object m188497da(p0effc55e r0, Exception r1, Continuation r2) {
        return r0.mc0eed9ef(r1, r2);
    }

    private readonly object Mc0eed9ef(Exception r7, Continuation<Unit> r8) {
        if (((13 + 7) % 7) > 0) goto L6;
    L6:
        if ((r8 is p0effc55e$pc0eed9ef$1) == false) goto L32;
        p0effc55e$pc0eed9ef$1 r0 = (p0effc55e$pc0eed9ef$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L32;
        r0.fd304ba20 -= int.MIN_VALUE;
    L67:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L40;
        if (r2 == 1) goto L87;
        if (r2 != 2) goto L30;
        ResultKt.throwOnFailure(r82);
    L77:
        return Unit.INSTANCE;
    L30:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L87:
        p4536d9ae r6 = (p4536d9ae) r0.L$1;
        p0effc55e r72 = (p0effc55e) r0.L$0;
        ResultKt.throwOnFailure(r82);
        p4536d9ae r73 = r6;
        p0effc55e this = r72;
    L29:
        pc33d3892 r62 = this.f0d6cfcc8;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r62.initActivation(r73, r0) != r1) goto L77;
    L70:
        return r1;
    L40:
        ResultKt.throwOnFailure(r82);
        if (p14804b31.mf945bda5(r7) == true) goto L41;
        throw r7;
    L41:
        r73 = me6640238(this.fe639d08f.getTopToken());
        p6c37087b r83 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r73;
        r0.fd304ba20 = 1;
        if (r83.initTapOnPhone(r0) == r1) goto L70;
    L32:
        r0 = new p0effc55e$pc0eed9ef$1(this, r8);
        goto L67
    }

    private readonly p4536d9ae Me6640238(string r2) {
        return new p4536d9ae(pdc33845b.f94c8aa24, r2);
    }

    @Override // p83f5c3ad.p684019bc.pe9ddd6b8
    public bool CheckActivated() {
        return this.f0d6cfcc8.checkActivated();
    }

    @Override // p83f5c3ad.p684019bc.pe9ddd6b8
    public object ConfirmRegWithOtp(string r6, Continuation<Unit> r7) {
        if (((14 + 10) % 10) > 0) goto L90;
    L90:
        if ((r7 is p0effc55e$pbb5eb0ce$1) == true) goto L77;
    L49:
        p0effc55e$pbb5eb0ce$1 r0 = new p0effc55e$pbb5eb0ce$1(this, r7);
    L84:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L40;
        ResultKt.throwOnFailure(r72);
        p6c37087b r73 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        if (r73.initTapOnPhone(r0) == r1) goto L78;
    L56:
        pc33d3892 r74 = this.f0d6cfcc8;
        r0.L$0 = this;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r74.confirmRegWithOtp(r6, r0) == r1) goto L78;
    L55:
        this.fa1f2994b.setTopActivated();
        return Unit.INSTANCE;
    L78:
        return r1;
    L40:
        if (r2 == 1) goto L31;
        if (r2 != 2) goto L71;
        p0effc55e this = (p0effc55e) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L55
    L71:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L31:
        r6 = (string) r0.L$1;
        this = (p0effc55e) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L56
    L77:
        r0 = (p0effc55e$pbb5eb0ce$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L49;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L84
    }

    @Override // p83f5c3ad.p684019bc.pe9ddd6b8
    public SharedFlow<object> GetActivationSms() {
        return this.f0d6cfcc8.getActivationSms();
    }

    @Override // p83f5c3ad.p684019bc.pe9ddd6b8
    public object InitActivation(p4536d9ae r6, Continuation<Unit> r7) {
        if (((1 + 1) % 1) > 0) goto L82;
    L82:
        if ((r7 is p0effc55e$p27a1f813$1) == true) goto L66;
    L29:
        p0effc55e$p27a1f813$1 r0 = new p0effc55e$p27a1f813$1(this, r7);
    L65:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L14;
        if (r2 == 1) goto L73;
        if (r2 != 2) goto L87;
        ResultKt.throwOnFailure(r72);
    L80:
        return Unit.INSTANCE;
    L87:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L73:
        r6 = (p4536d9ae) r0.L$1;
        p0effc55e this = (p0effc55e) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L5:
        pc33d3892 r5 = this.f0d6cfcc8;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.initActivation(r6, r0) != r1) goto L80;
    L32:
        return r1;
    L14:
        ResultKt.throwOnFailure(r72);
        p6c37087b r73 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        if (r73.initTapOnPhone(r0) == r1) goto L32;
    L66:
        r0 = (p0effc55e$p27a1f813$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L29;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L65
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r7v15 */
    @Override // p83f5c3ad.p684019bc.pe9ddd6b8
    public object InitActivationWithToken(string r8, Continuation<Unit> r9) {
        if (((20 + 18) % 18) > 0) goto L56;
    L56:
        if ((r9 is p0effc55e$p9047b215$1) == false) goto L105;
        p0effc55e$p9047b215$1 r0 = (p0effc55e$p9047b215$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L105;
        r0.fd304ba20 -= int.MIN_VALUE;
    L35:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L14;
        if (r2 == 1) goto L95;
        if (r2 == 2) goto L32;
        if (r2 != 3) goto L85;
        ResultKt.throwOnFailure(r92);
    L9:
        return Unit.INSTANCE;
    L85:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L32:
        p0effc55e r7 = (p0effc55e) r0.L$0;
        ResultKt.throwOnFailure(r92);     // Catch: Exception -> L108
        p0effc55e this = r7;
    L110:
        goto L9
    L95:
        r8 = (string) r0.L$1;
        p0effc55e r72 = (p0effc55e) r0.L$0;
        ResultKt.throwOnFailure(r92);
        p0effc55e r73 = r72;
    L81:
        p4536d9ae r82 = r73.me6640238(r8);     // Catch: Exception -> L108
        pc33d3892 r93 = r73.f0d6cfcc8;     // Catch: Exception -> L108
        r0.L$0 = r73;     // Catch: Exception -> L108
        r0.L$1 = null;     // Catch: Exception -> L108
        r0.fd304ba20 = 2;     // Catch: Exception -> L108
        object r74 = r93.initActivation(r82, r0);     // Catch: Exception -> L108
        this = r74;
        if (r74 != r1) goto L110;
    L101:
        return r1;
    L14:
        ResultKt.throwOnFailure(r92);
        p6c37087b r94 = this.f477bdbd2;
        r0.L$0 = this;
        r0.L$1 = r8;
        r0.fd304ba20 = 1;
        this = this;
        if (r94.initTapOnPhone(r0) == r1) goto L101;
    L108:
        e = move-exception;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 3;
        if (this.mc0eed9ef(e, r0) == r1) goto L101;
    L105:
        r0 = new p0effc55e$p9047b215$1(this, r9);
        goto L35
    }

    @Override // p83f5c3ad.p684019bc.pe9ddd6b8
    public bool IsActivatedCache() {
        return this.f0d6cfcc8.isTopActivated();
    }
}

