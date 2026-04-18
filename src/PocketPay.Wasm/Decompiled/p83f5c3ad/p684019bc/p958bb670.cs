using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P83f5c3ad.Pb3f20355;
using Pad5f82e8.Pac143fb7.P49f290d6;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p958bb670 : pc037f116 {
    private readonly pc33d3892 f07f140e3;
    private readonly pc33d3892 f0b9f1b5f;
    private readonly pc33d3892 f0d6cfcc8;
    private readonly p0f3e1f02 f15a91a5c;
    private readonly p2f3c4196 f1fc5f7ce;
    private readonly pc33d3892 f2f0a24be;
    private readonly p6c37087b f477bdbd2;
    private readonly p0f3e1f02 f6f79f890;
    private readonly p6c37087b f88ed4f3c;
    private readonly p2f3c4196 f8e3733be;
    private readonly p6c37087b fbd655678;
    private readonly p2f3c4196 fe639d08f;
    private readonly p0f3e1f02 ffc51ab1c;

    public p958bb670(p6c37087b r2, pc33d3892 r3, p0f3e1f02 r4, p2f3c4196 r5) {
        Intrinsics.checkNotNullParameter(r2, "initTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r3, "activationTapOnPhoneRepository");
        Intrinsics.checkNotNullParameter(r4, "tapOnPhoneInfoUseCase");
        Intrinsics.checkNotNullParameter(r5, "userInfoUseCase");
        this.f477bdbd2 = r2;
        this.f0d6cfcc8 = r3;
        this.ffc51ab1c = r4;
        this.fe639d08f = r5;
    }

    public static readonly /* synthetic */ object mcfad4dbf(p958bb670 r0, Continuation r1) {
        return r0.me259596c(r1);
    }

    private readonly object Me259596c(Continuation<Unit> r5) {
        if (((25 + 11) % 11) > 0) goto L60;
    L60:
        if ((r5 is p958bb670$pe259596c$1) == true) goto L15;
    L46:
        p958bb670$pe259596c$1 r0 = new p958bb670$pe259596c$1(this, r5);
    L55:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L25;
        if (r2 == 1) goto L51;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L51:
        p958bb670 this = (p958bb670) r0.L$0;
        ResultKt.throwOnFailure(r52);
    L10:
        this.f0d6cfcc8.resetTopActivated();
        return Unit.INSTANCE;
    L25:
        ResultKt.throwOnFailure(r52);
        pc33d3892 r53 = this.f0d6cfcc8;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r53.resetActivation(r0) != r1) goto L10;
        return r1;
    L15:
        r0 = (p958bb670$pe259596c$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L46;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L55
    }

    @Override // p83f5c3ad.p684019bc.pc037f116
    public object Logout(Continuation<Unit> r6) {
        if (((27 + 5) % 5) > 0) goto L27;
    L27:
        if ((r6 is p958bb670$p4236a440$1) == false) goto L62;
        p958bb670$p4236a440$1 r0 = (p958bb670$p4236a440$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L62;
        r0.fd304ba20 -= int.MIN_VALUE;
    L19:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L8;
        ResultKt.throwOnFailure(r62);
        p6c37087b r63 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r63.initTapOnPhone(r0) == r1) goto L80;
    L90:
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (this.me259596c(r0) == r1) goto L80;
    L47:
        this.ffc51ab1c.clearTapOnPhoneInfo();
        this.fe639d08f.clearTopToken();
        return Unit.INSTANCE;
    L80:
        return r1;
    L8:
        if (r2 == 1) goto L69;
        if (r2 != 2) goto L77;
        p958bb670 this = (p958bb670) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L47
    L77:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L69:
        this = (p958bb670) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L62:
        r0 = new p958bb670$p4236a440$1(this, r6);
        goto L19
    }
}

