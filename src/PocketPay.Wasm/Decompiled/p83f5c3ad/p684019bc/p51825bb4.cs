using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using P776ea3bf.P07214c67;
using P776ea3bf.Pac143fb7;
using P776ea3bf.Pb3f20355;
using P83f5c3ad.P07214c67;
using P83f5c3ad.P684019bc;
using P83f5c3ad.Pb3f20355;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pad5f82e8.Pac143fb7.P49f290d6;
using Pe0212e54.Pb3f20355;
using Pe0212e54.Pf5e638cc.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p51825bb4 : p05375680 {
    private readonly p223a17a4 f089cb1ba;
    private readonly p8279a9a7 f0f5e326b;
    private readonly pda65ae8b f11d91285;
    private readonly p223a17a4 f128503b5;
    private readonly pe9ddd6b8 f18eeba9c;
    private readonly p6c37087b f425d625a;
    private readonly p6c37087b f477bdbd2;
    private readonly p8279a9a7 f65eae774;
    private readonly pe9ddd6b8 f67b950ae;
    private readonly p2f3c4196 f7399649b;
    private readonly p8d8b6d6b f7edd203d;
    private readonly pe9ddd6b8 f8789b18e;
    private readonly p8d8b6d6b f8805a22b;
    private readonly p2f3c4196 f8e861313;
    private readonly pe9ddd6b8 f9b44e4f1;
    private readonly p6c37087b f9b7b8d48;
    private readonly pda65ae8b f9dd9445d;
    private readonly p223a17a4 fbadb22bf;
    private readonly pda65ae8b fc7b95001;
    private readonly p2f3c4196 fe639d08f;
    private readonly p6c37087b feb115eec;
    private readonly pfeb9ca41 ff43d9e96;
    private readonly pe9ddd6b8 ff7ee403e;
    private readonly pfeb9ca41 ffa781974;
    private readonly p2f3c4196 ffeef6fb0;
    private readonly p8d8b6d6b fff873486;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((30 + 2) % 2) > 0) goto L17;
        L17:
            int[] r0 = new int[p15913342.Values.length];
            r0[p15913342.fae6110b4.ordinal()] = 1;     // Catch: NoSuchFieldError -> L36
        L60:
            r0[p15913342.f49787fcb.ordinal()] = 2;     // Catch: NoSuchFieldError -> L37
        L52:
            r0[p15913342.fa711e884.ordinal()] = 3;     // Catch: NoSuchFieldError -> L38
        L64:
            r0[p15913342.f6718aa2c.ordinal()] = 4;     // Catch: NoSuchFieldError -> L39
        L68:
            r0[p15913342.f86e418e3.ordinal()] = 5;     // Catch: NoSuchFieldError -> L40
        L54:
            r0[p15913342.f40e501aa.ordinal()] = 6;     // Catch: NoSuchFieldError -> L41
        L70:
            r0[p15913342.f3cdf9ab3.ordinal()] = 7;     // Catch: NoSuchFieldError -> L42
        L48:
            r0[p15913342.f23276272.ordinal()] = 8;     // Catch: NoSuchFieldError -> L43
        L62:
            r0[p15913342.f448a678d.ordinal()] = 9;     // Catch: NoSuchFieldError -> L44
        L66:
            r0[p15913342.fcc52df9f.ordinal()] = 10;     // Catch: NoSuchFieldError -> L45
        L56:
            r0[p15913342.f1bddaf38.ordinal()] = 11;     // Catch: NoSuchFieldError -> L46
        L58:
            r0[p15913342.f2f410414.ordinal()] = 12;     // Catch: NoSuchFieldError -> L47
        L10:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    public p51825bb4(p6c37087b r2, pe9ddd6b8 r3, p8279a9a7 r4, p223a17a4 r5, p2f3c4196 r6, p8d8b6d6b r7, pda65ae8b r8, pfeb9ca41 r9) {
        Intrinsics.checkNotNullParameter(r2, "initTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r3, "activationTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r4, "tophHashSettingsRepository");
        Intrinsics.checkNotNullParameter(r5, "integrationTophConsoleoutUseCase");
        Intrinsics.checkNotNullParameter(r6, "userInfoUseCase");
        Intrinsics.checkNotNullParameter(r7, "integrationTophAuthRepository");
        Intrinsics.checkNotNullParameter(r8, "integrationDevicesRepository");
        Intrinsics.checkNotNullParameter(r9, "devicesDbRepository");
        this.f477bdbd2 = r2;
        this.f18eeba9c = r3;
        this.f0f5e326b = r4;
        this.f089cb1ba = r5;
        this.fe639d08f = r6;
        this.fff873486 = r7;
        this.fc7b95001 = r8;
        this.ffa781974 = r9;
    }

    public static readonly /* synthetic */ object m2450e2fd(p51825bb4 r0, Continuation r1) {
        return r0.mb1b66f80(r1);
    }

    public static readonly /* synthetic */ object m5718a856(p51825bb4 r0, Continuation r1) {
        return r0.m6a2af343(r1);
    }

    private readonly object M6a2af343(Continuation<p48bc8063> r6) {
        if (((3 + 8) % 8) > 0) goto L62;
    L62:
        if ((r6 is p51825bb4$p6a2af343$1) == true) goto L26;
    L51:
        p51825bb4$p6a2af343$1 r0 = new p51825bb4$p6a2af343$1(this, r6);
    L54:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L95;
        if (r2 == 1) goto L69;
        if (r2 != 2) goto L17;
        p51825bb4 this = (p51825bb4) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L32:
        return this.mef770b24();
    L17:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L69:
        this = (p51825bb4) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L3:
        pe9ddd6b8 r63 = this.f18eeba9c;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (pe9ddd6b8.pb0da8397.mc0c6c995(r63, null, r0, 1, null) != r1) goto L32;
    L9:
        return r1;
    L95:
        ResultKt.throwOnFailure(r62);
        if (this.f18eeba9c.checkActivated() == true) goto L32;
        string r64 = this.fe639d08f.getTopToken();
        pe9ddd6b8 r22 = this.f18eeba9c;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r22.initActivationWithToken(r64, r0) == r1) goto L9;
    L26:
        r0 = (p51825bb4$p6a2af343$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L51;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L54
    }

    private readonly object Mb1b66f80(Continuation<bool> r7) {
        if (((24 + 11) % 11) > 0) goto L110;
    L110:
        if ((r7 is p51825bb4$pb1b66f80$1) == true) goto L103;
    L34:
        p51825bb4$pb1b66f80$1 r0 = new p51825bb4$pb1b66f80$1(this, r7);
    L40:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        bool r4 = true;
        if (r2 == 0) goto L38;
        if (r2 == 1) goto L109;
        if (r2 != 2) goto L51;
        string r6 = (string) r0.L$1;
        p51825bb4 r02 = (p51825bb4) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L13:
        if (Intrinsics.areEqual(r6, ((p6285e3eb) r72).getDeviceId()) == false) goto L104;
    L55:
        r4 = false;
    L83:
        return Boxing.boxbool(r4);
    L104:
        if (r02.fff873486.isTopActivated() == true) goto L83;
    L51:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L109:
        p51825bb4 this = (p51825bb4) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L62:
        string r73 = ((p6285e3eb) r72).getDeviceId();
        pda65ae8b r22 = this.fc7b95001;
        r0.L$0 = this;
        r0.L$1 = r73;
        r0.fd304ba20 = 2;
        object r03 = r22.getSelectedDevice(r0);
        if (r03 != r1) goto L31;
    L77:
        return r1;
    L31:
        r02 = this;
        r6 = r73;
        r72 = r03;
        goto L13
    L38:
        ResultKt.throwOnFailure(r72);
        pfeb9ca41 r74 = this.ffa781974;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = r74.getSelectedDevice(r0);
        if (r72 == r1) goto L77;
    L103:
        r0 = (p51825bb4$pb1b66f80$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L34;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L40
    }

    private readonly p48bc8063 Mef770b24() {
        p15913342 r1 = this.f0f5e326b.getStartTopRoute();
        switch(p12c674ac.$EnumSwitchDictionaryping$0[r1.ordinal()]) {
            case 1: goto L16;
            case 2: goto L34;
            case 3: goto L12;
            case 4: goto L14;
            case 5: goto L37;
            case 6: goto L19;
            case 7: goto L45;
            case 8: goto L47;
            case 9: goto L43;
            case 10: goto L43;
            case 11: goto L23;
            case 12: goto L31;
            default: goto L7;
        };
    L31:
        return p48bc8063.f70542fff;
    L34:
        return p48bc8063.fa814501f;
    L12:
        return p48bc8063.f317e94b7;
    L37:
        return p48bc8063.f9be5efb7;
    L43:
        return p48bc8063.f551b723e;
    L7:
        return p48bc8063.f6cddd593;
    L23:
        return p48bc8063.f97c9b9eb;
    L16:
        return p48bc8063.fbd50bfda;
    L14:
        return p48bc8063.f860926e6;
    L47:
        return p48bc8063.fa28f62ec;
    L19:
        return p48bc8063.f8b74b33f;
    L45:
        return p48bc8063.fbdd33f3f;
    }

    @Override // p83f5c3ad.p684019bc.p6aaf2903
    public object GetStartScreen(Continuation<p48bc8063> r7) {
        if (((27 + 24) % 24) > 0) goto L74;
    L74:
        if ((r7 is p51825bb4$pe872ce79$1) == true) goto L39;
    L49:
        p51825bb4$pe872ce79$1 r0 = new p51825bb4$pe872ce79$1(this, r7);
    L111:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L40;
        ResultKt.throwOnFailure(r72);
        p6c37087b r73 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r73.initTapOnPhone(r0) == r1) goto L28;
    L85:
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (this.logoutIfNeeded(r0) == r1) goto L28;
    L101:
        if (this.f18eeba9c.checkActivated() == true) goto L45;
        if (this.fe639d08f.hasTopToken() == true) goto L80;
        return p48bc8063.f6cddd593;
    L80:
        r0.L$0 = null;
        r0.fd304ba20 = 3;
        object r6 = this.m6a2af343(r0);
        if (r6 == r1) goto L28;
        return r6;
    L45:
        return this.mef770b24();
    L28:
        return r1;
    L40:
        if (r2 == 1) goto L71;
        if (r2 == 2) goto L95;
        if (r2 != 3) goto L65;
        ResultKt.throwOnFailure(r72);
        return r72;
    L65:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L95:
        p51825bb4 this = (p51825bb4) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L101
    L71:
        this = (p51825bb4) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L85
    L39:
        r0 = (p51825bb4$pe872ce79$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L49;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L111
    }

    @Override // p83f5c3ad.p684019bc.p05375680
    public object LogoutIfNeeded(Continuation<Unit> r6) {
        if (((28 + 4) % 4) > 0) goto L16;
    L16:
        if ((r6 is p51825bb4$pc512221d$1) == false) goto L81;
        p51825bb4$pc512221d$1 r0 = (p51825bb4$pc512221d$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L81;
        r0.fd304ba20 -= int.MIN_VALUE;
    L43:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L24;
        if (r2 == 1) goto L11;
        if (r2 != 2) goto L14;
        ResultKt.throwOnFailure(r62);     // Catch: Exception -> L73
    L79:
        return Unit.INSTANCE;
    L14:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L11:
        p51825bb4 this = (p51825bb4) r0.L$0;
        ResultKt.throwOnFailure(r62);     // Catch: Exception -> L73
    L29:
        if (((bool) r62).boolValue() == false) goto L79;
        p223a17a4 r5 = this.f089cb1ba;     // Catch: Exception -> L73
        r0.L$0 = null;     // Catch: Exception -> L73
        r0.fd304ba20 = 2;     // Catch: Exception -> L73
        if (r5.logout(r0) != r1) goto L79;
    L72:
        return r1;
    L24:
        ResultKt.throwOnFailure(r62);
        r0.L$0 = this;     // Catch: Exception -> L73
        r0.fd304ba20 = 1;     // Catch: Exception -> L73
        r62 = mb1b66f80(r0);     // Catch: Exception -> L73
        if (r62 != r1) goto L29;
    L73:
        e = move-exception;
        if ((e is p78d80ba2) == true) goto L79;
        throw e;
    L81:
        r0 = new p51825bb4$pc512221d$1(this, r6);
        goto L43
    }
}

