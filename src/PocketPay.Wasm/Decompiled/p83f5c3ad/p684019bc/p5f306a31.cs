using Com.Decryptstringmanager;
using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Text;
using P83f5c3ad.P684019bc.P42552b1f;
using P83f5c3ad.Pb3f20355;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p5f306a31 : p97ae8742 {
    public static readonly string f0d7b5c5d = null;
    public static readonly string f1ce36f65 = null;
    private static readonly p910eef8c f29a535d6 = null;
    public static readonly string f3faca99b = null;

    [System.Obsolete]
    public static readonly string f45f3bf7e = null;
    private static readonly p910eef8c f757edb14 = null;
    private static readonly p910eef8c f910eef8c = null;
    private static readonly p910eef8c faf3166f2 = null;
    private readonly p4db3be80 f24e3ca9c;
    private readonly p0e3a3373 f2e92793e;
    private readonly p0f3e1f02 f4ddf8303;
    private readonly p0e3a3373 f5c86fab8;
    private readonly p4db3be80 f895dfa7a;
    private readonly p0e3a3373 fb8df4506;
    private readonly p0e3a3373 ff1ee6019;
    private readonly p0e3a3373 ffab53cc0;
    private readonly p0f3e1f02 ffc51ab1c;

    private static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((15 + 6) % 6) > 0) goto L23;
    L23:
        f45f3bf7e = Decryptstring.decryptstring("7410e13576987e7542086d1c9ed4de45373a39962c7a522a2aa27da73e7bbac3");
        f910eef8c = new p910eef8c(null);
    }

    public p5f306a31(p4db3be80 r2, p0f3e1f02 r3, p0e3a3373 r4) {
        Intrinsics.checkNotNullParameter(r2, "attestationTapOnPhoneRepository");
        Intrinsics.checkNotNullParameter(r3, "tapOnPhoneInfoUseCase");
        Intrinsics.checkNotNullParameter(r4, "tophAuthDeviceUseCase");
        this.f895dfa7a = r2;
        this.ffc51ab1c = r3;
        this.ffab53cc0 = r4;
    }

    @Override // p83f5c3ad.p684019bc.p97ae8742
    public object InitAttestation(Continuation<Unit> r2) {
        if (this.f895dfa7a.checkAttested() == true) goto L31;
        object r1 = runAttestation(r2);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L25;
        return r1;
    L25:
        return Unit.INSTANCE;
    L31:
        object r12 = this.ffc51ab1c.updateTapOnPhoneQrInfo(r2);
        if (r12 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L4;
        return r12;
    L4:
        return Unit.INSTANCE;
    }

    @Override // p83f5c3ad.p684019bc.p97ae8742
    public <T> object InitAttestation(Function1<? super Continuation<T>, ? : object> r9, Continuation<T> r10) {
        if (((10 + 3) % 3) > 0) goto L72;
    L72:
        if ((r10 is p5f306a31$p4434d349$1) == true) goto L71;
    L75:
        p5f306a31$p4434d349$1 r0 = new p5f306a31$p4434d349$1(this, r10);
    L63:
        object r102 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L22;
        ResultKt.throwOnFailure(r102);
        r0.L$0 = this;     // Catch: Exception -> L86
        r0.L$1 = r9;     // Catch: Exception -> L86
        r0.fd304ba20 = 1;     // Catch: Exception -> L86
        if (initAttestation(r0) == r1) goto L41;
    L9:
        r0.L$0 = this;     // Catch: Exception -> L86
        r0.L$1 = r9;     // Catch: Exception -> L86
        r0.fd304ba20 = 2;     // Catch: Exception -> L86
        object r8 = r9.invoke(r0);     // Catch: Exception -> L86
        if (r8 == r1) goto L41;
        return r8;
    L41:
        return r1;
    L22:
        if (r2 == 1) goto L101;
        if (r2 == 2) goto L67;
        if (r2 == 3) goto L108;
        if (r2 != 4) goto L26;
        ResultKt.throwOnFailure(r102);
    L43:
        return r102;
    L26:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L108:
        Function1<? super Continuation<T>, ? : object> r82 = (Function1) r0.L$0;
        ResultKt.throwOnFailure(r102);
    L47:
        r0.L$0 = null;
        r0.fd304ba20 = 4;
        r102 = r82.invoke(r0);
        if (r102 == r1) goto L41;
    L67:
        Function1 r92 = (Function1) r0.L$1;
        p5f306a31 r83 = (p5f306a31) r0.L$0;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L86
        return r102;
    L101:
        r9 = (Function1) r0.L$1;
        p5f306a31 this = (p5f306a31) r0.L$0;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L86
    L86:
        e = move-exception;
        if (p14804b31.m8d3f60fb(e) == true) goto L123;
        throw e;
    L123:
        r0.L$0 = r9;
        r0.L$1 = null;
        r0.fd304ba20 = 3;
        if (runAttestation(r0) == r1) goto L41;
        r82 = r9;
        goto L47
    L71:
        r0 = (p5f306a31$p4434d349$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L75;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L63
    }

    @Override // p83f5c3ad.p684019bc.p97ae8742
    public object RunAttestation(Continuation<Unit> r8) {
        if (((25 + 14) % 14) > 0) goto L83;
    L83:
        if ((r8 is p5f306a31$p1e284e26$1) == true) goto L82;
    L95:
        p5f306a31$p1e284e26$1 r0 = new p5f306a31$p1e284e26$1(this, r8);
    L49:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L35;
        ResultKt.throwOnFailure(r82);
        p4db3be80 r83 = this.f895dfa7a;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r83.initAttestation(r0) == r1) goto L110;
    L56:
        p4db3be80 r84 = this.f895dfa7a;
        byte[] r22 = Decryptstring.decryptstring("6a72ff8701dd1e3fea9cc6f621afbd1489cd858dad0a90d4a922fb9fe61230cd").getbytes(Charsets.UTF_8);
        Intrinsics.checkNotNullExpressionValue(r22, "getbytes(...)");
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r84.confirmAttestation(r22, r0) == r1) goto L110;
    L60:
        p0f3e1f02 r85 = this.ffc51ab1c;
        r0.L$0 = this;
        r0.fd304ba20 = 3;
        if (r85.updateTapOnPhoneInfo(r0) == r1) goto L110;
    L123:
        p0e3a3373 r7 = this.ffab53cc0;     // Catch: Exception -> L111
        r0.L$0 = null;     // Catch: Exception -> L111
        r0.fd304ba20 = 4;     // Catch: Exception -> L111
        if (r7.authDevice(r0) == r1) goto L110;
    L130:
    L103:
        return Unit.INSTANCE;
    L110:
        return r1;
    L35:
        if (r2 == 1) goto L18;
        if (r2 == 2) goto L80;
        if (r2 == 3) goto L99;
        if (r2 != 4) goto L90;
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L111
        goto L130
    L90:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L99:
        p5f306a31 this = (p5f306a31) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L123
    L80:
        this = (p5f306a31) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L60
    L18:
        this = (p5f306a31) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L111:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L103
    L82:
        r0 = (p5f306a31$p1e284e26$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L95;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L49
    }
}

