using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P83f5c3ad.P07214c67;
using P83f5c3ad.Pb3f20355;
using Pad5f82e8.Pac143fb7.P610b272d;
using Pad5f82e8.Pac143fb7.Pc1c16452;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p07c4b34e : p0e3a3373 {
    private readonly p5cb20415 f0edfffde;
    private readonly p5cb20415 f14749627;
    private readonly pe7d2429f f22d651b0;
    private readonly p0f3e1f02 f265c35ec;
    private readonly p0f3e1f02 f35e270aa;
    private readonly p5cb20415 f51e529c8;
    private readonly p0f3e1f02 f6bfa8f56;
    private readonly pe7d2429f f780e0b8f;
    private readonly pf698b4bd f7c0a8f04;
    private readonly pe7d2429f f8f2246ed;
    private readonly pe7d2429f fe50db95d;
    private readonly pf698b4bd feab592e9;
    private readonly p5cb20415 fee887fde;
    private readonly pe7d2429f ff29f238f;
    private readonly p0f3e1f02 ffc51ab1c;

    public p07c4b34e(pe7d2429f r2, pf698b4bd r3, p5cb20415 r4, p0f3e1f02 r5) {
        Intrinsics.checkNotNullParameter(r2, "tophAuthDeviceRepository");
        Intrinsics.checkNotNullParameter(r3, "marketDataUseCase");
        Intrinsics.checkNotNullParameter(r4, "userDeviceUseCase");
        Intrinsics.checkNotNullParameter(r5, "tapOnPhoneInfoUseCase");
        this.ff29f238f = r2;
        this.feab592e9 = r3;
        this.f0edfffde = r4;
        this.ffc51ab1c = r5;
    }

    @Override // p83f5c3ad.p684019bc.p0e3a3373
    public object AuthDevice(Continuation<Unit> r9) {
        if (((20 + 30) % 30) > 0) goto L71;
    L71:
        if ((r9 is p07c4b34e$pb15d30e0$1) == true) goto L45;
    L80:
        p07c4b34e$pb15d30e0$1 r0 = new p07c4b34e$pb15d30e0$1(this, r9);
    L56:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L15;
        if (r2 == 1) goto L47;
        if (r2 != 2) goto L67;
        ResultKt.throwOnFailure(r92);
    L27:
        return Unit.INSTANCE;
    L67:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L47:
        p07c4b34e this = (p07c4b34e) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L52:
        pd239a801 r7 = new pd239a801((string) r92, this.f0edfffde.getUserDeviceId(), this.ffc51ab1c.getTapOnPhoneMid(), this.ffc51ab1c.getTapOnPhoneTid());
        pe7d2429f r8 = this.ff29f238f;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r8.authDevice(r7, r0) != r1) goto L27;
    L18:
        return r1;
    L15:
        ResultKt.throwOnFailure(r92);
        pf698b4bd r93 = this.feab592e9;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r92 = pf698b4bd.pb0da8397.ma8c2291f(r93, null, r0, 1, null);
        if (r92 == r1) goto L18;
    L45:
        r0 = (p07c4b34e$pb15d30e0$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L80;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L56
    }
}

