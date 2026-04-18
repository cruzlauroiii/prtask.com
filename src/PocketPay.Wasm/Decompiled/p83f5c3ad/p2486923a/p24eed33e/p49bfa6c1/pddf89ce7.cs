using Android.Net;
using Androidx.Core.App;
using Androidx.Lifecycle;
using Com.Google.Firebase.Crashlytics;
using Java.Net;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2b3583e6;
using P2b3583e6.P22450232;
using P2b3583e6.P4a931512;
using P2e5d8aa3.P39652074;
using P2e5d8aa3.Pf83c2a85.Pac143fb7;
using P2e5d8aa3.Pfd9160bb;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.P19ad2780.P593616de;
using P582ca3f7.Pac143fb7;
using P83f5c3ad.P684019bc;
using P83f5c3ad.P684019bc.P42552b1f;
using P83f5c3ad.P684019bc.P94a08da1;
using P83f5c3ad.P68c4283d;
using P83f5c3ad.Pfd9160bb;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P49f290d6;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.P07214c67.Pfa547353;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pad5f82e8.Pac143fb7.P49f290d6;
using Pd2a57dc1.Pfd9160bb;
using Pe0212e54.Pac143fb7;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pddf89ce7 : objectModel {
    private readonly MutableSharedFlow<string> f02d84988;
    private readonly pbd754d99 f0539cf2b;
    private readonly p76204a3d f053d1b76;
    private readonly p1d2e04a5 f09320446;
    private readonly p69d862b4 f09e718e8;
    private readonly MutableSharedFlow<Unit> f0a49b529;
    private readonly paa56254c f0a4a4279;
    private readonly p76204a3d f10fc6d88;
    private readonly MutableSharedFlow f110b749a;
    private readonly paa56254c f12e1f6fa;
    private readonly paa56254c f131ca5e8;
    private readonly MutableSharedFlow f13fc5bd0;
    private readonly pe8cda3fc f1419159b;
    private readonly MutableSharedFlow f14d9655f;
    private readonly p11c216e8 f174e566e;
    private readonly p2e423cc6 f17cab80d;
    private readonly MutableSharedFlow f18237811;
    private readonly MutableSharedFlow f18bc2942;
    private readonly pe9ddd6b8 f18eeba9c;
    private readonly MutableSharedFlow<string> f1ebf6d39;
    private readonly MutableSharedFlow f20406761;
    private readonly MutableSharedFlow f22fbe580;
    private readonly MutableSharedFlow f23cec47e;
    private readonly p05375680 f24bb92ad;
    private readonly p11c216e8 f25e5c419;
    private readonly pbd754d99 f30b28014;
    private readonly MutableSharedFlow<string> f313a5556;
    private readonly pe9ddd6b8 f31b3f3ed;
    private readonly MutableSharedFlow f329fb5b0;
    private readonly MutableSharedFlow f33d9616a;
    private readonly pee785de8 f33e8079c;
    private readonly MutableSharedFlow f34ff2ffb;
    private readonly MutableSharedFlow f3556bab2;
    private readonly p05375680 f370bc604;
    private readonly pee785de8 f37c9e91b;
    private readonly MutableSharedFlow<string> f3df46d57;
    private readonly MutableSharedFlow<Unit> f418d61b9;
    private readonly pe8cda3fc f445d6041;
    private readonly p2e423cc6 f4734ade7;
    private readonly MutableSharedFlow<string> f499a3140;
    private readonly MutableSharedFlow f4b488ca2;
    private readonly MutableSharedFlow f4c551f00;
    private readonly MutableSharedFlow f4cec5616;
    private readonly p4b8940c0 f4eb3cc25;
    private readonly MutableSharedFlow f510223ba;
    private readonly MutableSharedFlow f525b4d6f;
    private readonly p76204a3d f54acb843;
    private readonly MutableSharedFlow f577d965e;
    private readonly MutableSharedFlow f58cf3ece;
    private readonly p2e423cc6 f594a30bc;
    private readonly paa56254c f59e85e58;
    private readonly MutableSharedFlow<string> f5b5be533;
    private readonly p05375680 f65c3b363;
    private readonly p69d862b4 f66ba40a3;
    private readonly MutableSharedFlow f6749946f;
    private readonly pe8cda3fc f68c4283d;
    private readonly MutableSharedFlow f6b11efe3;
    private readonly MutableSharedFlow<string> f6b5c6c5f;
    private readonly pee785de8 f6d0ab65c;
    private readonly MutableSharedFlow<string> f7285d86d;
    private readonly MutableSharedFlow<string> f762bd8ad;
    private readonly MutableSharedFlow f7bbf6ad8;
    private readonly MutableSharedFlow<string> f7c734188;
    private readonly MutableSharedFlow f80b00d63;
    private readonly MutableSharedFlow f8244cf7a;
    private readonly p995fd851 f86b275b0;
    private readonly MutableSharedFlow f8ae6324a;
    private readonly MutableSharedFlow f8dcd8db2;
    private readonly MutableSharedFlow<string> f904c30e8;
    private readonly MutableSharedFlow<string> f910c02c2;
    private readonly MutableSharedFlow<string> f92ce9217;
    private readonly MutableSharedFlow f9327c253;
    private readonly MutableSharedFlow f959fbd26;
    private readonly MutableSharedFlow f9b972593;
    private readonly MutableSharedFlow f9db3aeaf;
    private readonly MutableSharedFlow f9f64ec97;
    private readonly MutableSharedFlow f9f718d7d;
    private readonly p1ceed351 fa0581e49;
    private readonly MutableSharedFlow fab4af240;
    private readonly pe8cda3fc fb0efed82;
    private readonly MutableSharedFlow fb268f95d;
    private readonly p05375680 fb32f8a19;
    private readonly MutableSharedFlow fb407e29a;
    private readonly pe8cda3fc fb5521da5;
    private readonly p1ceed351 fb9876275;
    private readonly MutableSharedFlow fbba0b9ca;
    private readonly MutableSharedFlow fbe6aa8fe;
    private readonly p995fd851 fbf0d7499;
    private readonly p2e423cc6 fc2765c4a;
    private readonly MutableSharedFlow fc836449b;
    private readonly pdcfa0c32 fce765563;
    private readonly p995fd851 fd48447f6;
    private readonly p2f3c4196 fd5257a3e;
    private readonly p1ceed351 fd579ca29;
    private readonly MutableSharedFlow fd6bbe945;
    private readonly pee785de8 fd866032a;
    private readonly p4b8940c0 fda1713fa;
    private readonly p2f3c4196 fdac54668;
    private readonly MutableSharedFlow<string> fdc7903d8;
    private readonly MutableSharedFlow<string> fdceacd61;
    private readonly pbd754d99 fdcfa4a01;
    private readonly p69d862b4 fdda32b64;
    private readonly p1d2e04a5 fdda4ea7f;
    private readonly MutableSharedFlow fdf22be31;
    private readonly MutableSharedFlow fdf8c1a20;
    private readonly p1d2e04a5 fe15de61c;
    private readonly p2f3c4196 fe639d08f;
    private readonly p2e423cc6 fe80b9069;
    private readonly MutableSharedFlow fea2563e0;
    private readonly MutableSharedFlow feb9eb0a8;
    private readonly pbd754d99 feced03cd;
    private readonly p11c216e8 feefeb260;
    private readonly MutableSharedFlow<string> ff144fa11;
    private readonly MutableSharedFlow<string> ff15d4fda;
    private readonly p995fd851 ff4473c3c;
    private readonly MutableSharedFlow ff447589f;
    private readonly p1d2e04a5 ff525f739;
    private readonly MutableSharedFlow ff54cd568;
    private readonly MutableSharedFlow ff6291835;
    private readonly pdcfa0c32 ff830f41e;
    private readonly p995fd851 ff9f7d15f;
    private readonly MutableSharedFlow<string> ffe28c315;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$1 = null;

        static {
            if (((12 + 1) % 1) > 0) goto L23;
        L23:
            int[] r0 = new int[pec53a8c4.Values.length];
            r0[pec53a8c4.fd0749aab.ordinal()] = 1;     // Catch: NoSuchFieldError -> L36
        L40:
            r0[pec53a8c4.fbb1ca97e.ordinal()] = 2;     // Catch: NoSuchFieldError -> L37
        L18:
            $EnumSwitchDictionaryping$0 = r0;
            int[] r02 = new int[p15913342.Values.length];
            r02[p15913342.f6f2f7346.ordinal()] = 1;     // Catch: NoSuchFieldError -> L38
        L44:
            r02[p15913342.f66243b44.ordinal()] = 2;     // Catch: NoSuchFieldError -> L39
        L3:
            $EnumSwitchDictionaryping$1 = r02;
        }
    }

    public pddf89ce7(p05375680 r17, pe9ddd6b8 r18, p76204a3d r19, paa56254c r20, p2f3c4196 r21, p69d862b4 r22, p4b8940c0 r23, p1d2e04a5 r24, pdcfa0c32 r25, p995fd851 r26, pbd754d99 r27, p11c216e8 r28, p1ceed351 r29, pee785de8 r30, p2e423cc6 r31, pe8cda3fc r32) {
        if (((15 + 15) % 15) > 0) goto L55;
    L55:
        Intrinsics.checkNotNullParameter(r17, "tophAuthUseCase");
        Intrinsics.checkNotNullParameter(r18, "activationTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r19, "tophHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r20, "tophTokenUseCase");
        Intrinsics.checkNotNullParameter(r21, "userInfoUseCase");
        Intrinsics.checkNotNullParameter(r22, "employeeUseCase");
        Intrinsics.checkNotNullParameter(r23, "devicesUseCase");
        Intrinsics.checkNotNullParameter(r24, "feedbackUseCase");
        Intrinsics.checkNotNullParameter(r25, "paymentHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r26, "nfcTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r27, "appConfig");
        Intrinsics.checkNotNullParameter(r28, "flowRouter");
        Intrinsics.checkNotNullParameter(r29, "tophRouter");
        Intrinsics.checkNotNullParameter(r30, "settingsRouter");
        Intrinsics.checkNotNullParameter(r31, "resourceProvider");
        Intrinsics.checkNotNullParameter(r32, "analytics");
        this.f370bc604 = r17;
        this.f18eeba9c = r18;
        this.f053d1b76 = r19;
        this.f0a4a4279 = r20;
        this.fe639d08f = r21;
        this.f66ba40a3 = r22;
        this.fda1713fa = r23;
        this.ff525f739 = r24;
        this.fce765563 = r25;
        this.fd48447f6 = r26;
        this.feced03cd = r27;
        this.feefeb260 = r28;
        this.fd579ca29 = r29;
        this.f37c9e91b = r30;
        this.f4734ade7 = r31;
        this.f68c4283d = r32;
        MutableSharedFlow<string> r1 = p9667588a.m90331c9a();
        this.fdc7903d8 = r1;
        MutableSharedFlow<string> r2 = p9667588a.m90331c9a();
        this.f910c02c2 = r2;
        MutableSharedFlow<string> r3 = p9667588a.m90331c9a();
        this.f5b5be533 = r3;
        MutableSharedFlow<string> r4 = p9667588a.m90331c9a();
        this.f02d84988 = r4;
        MutableSharedFlow<string> r5 = p9667588a.m90331c9a();
        this.f1ebf6d39 = r5;
        MutableSharedFlow<string> r6 = p9667588a.m90331c9a();
        this.ff144fa11 = r6;
        MutableSharedFlow<string> r7 = p9667588a.m90331c9a();
        this.f92ce9217 = r7;
        MutableSharedFlow<string> r8 = p9667588a.m90331c9a();
        this.f904c30e8 = r8;
        MutableSharedFlow<string> r9 = p9667588a.m90331c9a();
        this.ff15d4fda = r9;
        MutableSharedFlow<Unit> r10 = p9667588a.m90331c9a();
        this.f418d61b9 = r10;
        this.f762bd8ad = r1;
        this.f6b5c6c5f = r2;
        this.f7285d86d = r3;
        this.f7c734188 = r4;
        this.f313a5556 = r5;
        this.f499a3140 = r6;
        this.ffe28c315 = r7;
        this.fdceacd61 = r8;
        this.f3df46d57 = r9;
        this.f0a49b529 = r10;
    }

    public static readonly /* synthetic */ object m1b35e6d8(pddf89ce7 r0, pec53a8c4 r1, Continuation r2) {
        return r0.m21c36cb8(r1, r2);
    }

    private readonly object M21c36cb8(pec53a8c4 r8, Continuation<Unit> r9) {
        if (((24 + 8) % 8) > 0) goto L63;
    L63:
        if ((r9 is pddf89ce7$p21c36cb8$1) == true) goto L28;
    L4:
        pddf89ce7$p21c36cb8$1 r0 = new pddf89ce7$p21c36cb8$1(this, r9);
    L112:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L38;
        ResultKt.throwOnFailure(r92);
        p4b8940c0 r93 = this.fda1713fa;
        r0.L$0 = this;
        r0.L$1 = r8;
        r0.fd304ba20 = 1;
        r92 = r93.getSelectedDevice(r0);
        if (r92 != r1) goto L148;
    L78:
        return r1;
    L148:
        p4f30e9bd r94 = (p4f30e9bd) r92;
        if (p12c674ac.$EnumSwitchDictionaryping$1[this.f053d1b76.getStartTopRoute().ordinal()] == 1) goto L21;
        p69d862b4 r22 = this.f66ba40a3;
        r0.L$0 = this;
        r0.L$1 = r8;
        r0.L$2 = r94;
        r0.fd304ba20 = 2;
        object r02 = r22.getSelectedEmployee(r0);
        if (r02 == r1) goto L78;
        pddf89ce7 r03 = this;
        p4f30e9bd r7 = r94;
        r92 = r02;
    L24:
        pf8c8b903 r95 = (pf8c8b903) r92;
        int r82 = p12c674ac.$EnumSwitchDictionaryping$0[r8.ordinal()];
        if (r82 == 1) goto L104;
        if (r82 == 2) goto L146;
    L69:
        return Unit.INSTANCE;
    L146:
        r03.f68c4283d.reportAutoConsoleinErrorEvent(r95.getId(), r7.getDeviceId());
        goto L69
    L104:
        r03.f68c4283d.reportAutoConsoleinSuccessEvent(r95.getId(), r7.getDeviceId());
        goto L69
    L21:
        int r83 = p12c674ac.$EnumSwitchDictionaryping$0[r8.ordinal()];
        if (r83 == 1) goto L59;
        if (r83 != 2) goto L69;
        this.f68c4283d.reportVirtualDeviceAutoConsoleinErrorEvent(r94.getDeviceId());
        goto L69
    L59:
        this.f68c4283d.reportVirtualDeviceAutoConsoleinSuccessEvent(r94.getDeviceId());
        goto L69
    L38:
        if (r2 == 1) goto L54;
        if (r2 == 2) goto L128;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L128:
        r7 = (p4f30e9bd) r0.L$2;
        r8 = (pec53a8c4) r0.L$1;
        r03 = (pddf89ce7) r0.L$0;
        ResultKt.throwOnFailure(r92);
        goto L24
    L54:
        r8 = (pec53a8c4) r0.L$1;
        pddf89ce7 this = (pddf89ce7) r0.L$0;
        ResultKt.throwOnFailure(r92);
        goto L148
    L28:
        r0 = (pddf89ce7$p21c36cb8$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L4;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L112
    }

    public static readonly /* synthetic */ object m32875bfb(pddf89ce7 r0, Continuation r1) {
        return r0.mafa944f7(r1);
    }

    public static readonly /* synthetic */ object m39b2ba6b(pddf89ce7 r0, pe68ad0c3 r1, Continuation r2) {
        return r0.m6cb2f123(r1, r2);
    }

    public static readonly /* synthetic */ object m45fa0239(pddf89ce7 r0, Continuation r1) {
        return r0.mdeb61ed8(r1);
    }

    private readonly object M5016cf86(Continuation<Unit> r7) {
        if (((31 + 28) % 28) > 0) goto L14;
    L14:
        if ((r7 is pddf89ce7$p5016cf86$1) == false) goto L84;
        pddf89ce7$p5016cf86$1 r0 = (pddf89ce7$p5016cf86$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L84;
        r0.fd304ba20 -= int.MIN_VALUE;
    L33:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L37;
        ResultKt.throwOnFailure(r72);
        p995fd851 r73 = this.fd48447f6;     // Catch: Exception -> L97
        r0.L$0 = this;     // Catch: Exception -> L97
        r0.fd304ba20 = 1;     // Catch: Exception -> L97
        r72 = r73.isNfcCalibrated(r0);     // Catch: Exception -> L97
        if (r72 != r1) goto L28;
    L34:
        return r1;
    L28:
        if (((bool) r72).boolValue() == false) goto L30;
        this.finishFlow();     // Catch: Exception -> L97
    L21:
        return Unit.INSTANCE;
    L30:
        this.fd579ca29.startTophNfcCalibrationFlow();     // Catch: Exception -> L97
        goto L21
    L37:
        if (r2 == 1) goto L64;
        if (r2 == 2) goto L10;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L10:
        Exception r6 = (Exception) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L76:
        FirebaseCrashlytics.getInstance().recordException(r6);
        goto L21
    L64:
        pddf89ce7 this = (pddf89ce7) r0.L$0;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L97
    L97:
        e = move-exception;
        r6 = e;
        Exception r22 = r6;
        r0.L$0 = r6;
        r0.fd304ba20 = 2;
        if (mfcf7c6b8(r22, r0) == r1) goto L34;
    L84:
        r0 = new pddf89ce7$p5016cf86$1(this, r7);
        goto L33
    }

    public static readonly /* synthetic */ object m5eb226a6(pddf89ce7 r0, Continuation r1) {
        return r0.m5016cf86(r1);
    }

    private readonly object M6cb2f123(pe68ad0c3 r2, Continuation<Unit> r3) {
        pe68ad0c3 r22 = r2;
        if (p14804b31.m236e0401(r22) == true) goto L25;
        if (p14804b31.m53a14122(r22) == false) goto L125;
        object r1 = this.f910c02c2.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r1;
    L138:
        return Unit.INSTANCE;
    L125:
        if (p14804b31.mfef4036d(r22) == true) goto L70;
        if (p14804b31.mc2f177de(r22) == false) goto L84;
        object r12 = this.f5b5be533.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r12 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r12;
    L84:
        if (p14804b31.m3feec0a5(r22) == true) goto L67;
        if (p14804b31.mc4828dad(r22) == false) goto L110;
        object r13 = this.f1ebf6d39.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r13 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r13;
    L110:
        if (p14804b31.m6176c187(r22) == true) goto L91;
        if (p14804b31.me2fd646f(r22) == true) goto L96;
        if (p14804b31.m4c496614(r22) == true) goto L22;
        object r14 = this.ff15d4fda.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r14 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r14;
    L22:
        object r15 = this.f904c30e8.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r15 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r15;
    L96:
        object r16 = this.f92ce9217.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r16 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r16;
    L91:
        object r17 = this.ff144fa11.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r17 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r17;
    L67:
        object r18 = this.f02d84988.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r18 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r18;
    L70:
        this.fd579ca29.startLauncherFlow();
        goto L138
    L25:
        object r19 = this.fdc7903d8.emit(p14804b31.md9ae7f57(r22, this.f4734ade7.getobject()), r3);
        if (r19 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L138;
        return r19;
    }

    public static readonly /* synthetic */ paa56254c m73774f00(pddf89ce7 r0) {
        return r0.f0a4a4279;
    }

    public static readonly /* synthetic */ p05375680 ma8a70b9b(pddf89ce7 r0) {
        return r0.f370bc604;
    }

    private readonly object Mafa944f7(Continuation<Unit> r3) {
        if (((5 + 30) % 30) > 0) goto L42;
    L42:
        p15913342 r0 = this.f053d1b76.getStartTopRoute();
        int r02 = p12c674ac.$EnumSwitchDictionaryping$1[r0.ordinal()];
        if (r02 != 1) goto L15;
    L44:
        object r2 = mdeb61ed8(r3);
        if (r2 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L23;
        return r2;
    L23:
        return Unit.INSTANCE;
    L15:
        if (r02 == 2) goto L44;
        this.fd579ca29.startAuthFlow();
        return Unit.INSTANCE;
    }

    public static readonly /* synthetic */ object mc14faa11(pddf89ce7 r0, Exception r1, Continuation r2) {
        return r0.mfcf7c6b8(r1, r2);
    }

    public static readonly /* synthetic */ p2f3c4196 mc4724e47(pddf89ce7 r0) {
        return r0.fe639d08f;
    }

    private readonly object Mdeb61ed8(Continuation<Unit> r10) {
        if (((23 + 29) % 29) > 0) goto L139;
    L139:
        if ((r10 is pddf89ce7$pdeb61ed8$1) == false) goto L134;
        pddf89ce7$pdeb61ed8$1 r0 = (pddf89ce7$pdeb61ed8$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L134;
        r0.fd304ba20 -= int.MIN_VALUE;
    L43:
        object r102 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L129;
        if (r2 == 1) goto L95;
        if (r2 == 2) goto L54;
        if (r2 == 3) goto L54;
        if (r2 != 4) goto L6;
        Exception r9 = (Exception) r0.L$0;
        ResultKt.throwOnFailure(r102);
        throw r9;
    L6:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L54:
        ResultKt.throwOnFailure(r102);
    L12:
        return Unit.INSTANCE;
    L95:
        pddf89ce7 this = (pddf89ce7) r0.L$0;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L92 Exception -> L118
    L30:
    L29:
        this.feefeb260.sendResult(this.fd579ca29.getTophAutoActivationKey(), new p325296ab(this.f4734ade7.getstring(C2815R.string.settings_attestation_toph_success)));
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (this.m5016cf86(r0) != r1) goto L12;
    L145:
        return r1;
    L129:
        ResultKt.throwOnFailure(r102);
        pdcfa0c32 r103 = this.fce765563;     // Catch: Exception -> L92 Exception -> L118
        r0.L$0 = this;     // Catch: Exception -> L92 Exception -> L118
        r0.fd304ba20 = 1;     // Catch: Exception -> L92 Exception -> L118
        if (r103.setTapOnPhonePaymentsEnabled(true, r0) == r1) goto L145;
    L118:
        th = move-exception;
        pddf89ce7 r104 = this;
        r104.feefeb260.sendResult(r104.fd579ca29.getTophAutoActivationKey(), new p325296ab(r104.f4734ade7.getstring(C2815R.string.settings_attestation_toph_success)));
        r0.L$0 = th;
        r0.fd304ba20 = 4;
        if (r104.m5016cf86(r0) == r1) goto L145;
        throw th;
    L92:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);     // Catch: Exception -> L118
        this.feefeb260.sendResult(this.fd579ca29.getTophAutoActivationKey(), new p325296ab(this.f4734ade7.getstring(C2815R.string.settings_attestation_toph_success)));
        r0.L$0 = null;
        r0.fd304ba20 = 3;
        if (this.m5016cf86(r0) == r1) goto L145;
    L134:
        r0 = new pddf89ce7$pdeb61ed8$1(this, r10);
        goto L43
    }

    public static readonly /* synthetic */ pe9ddd6b8 mfab5c515(pddf89ce7 r0) {
        return r0.f18eeba9c;
    }

    private readonly void Mfca8d010(string r3) {
        if (((12 + 6) % 6) > 0) goto L7;
    L7:
        p89a5ff7f r0 = new p89a5ff7f(r3);
        this.feefeb260.sendResult(this.fd579ca29.getTophAutoActivationKey(), r0);
        finishFlow();
    }

    private readonly object Mfcf7c6b8(Exception r2, Continuation<Unit> r3) {
        if ((r2 is pe68ad0c3) == true) goto L7;
        if ((r2 is UnknownHostException) == false) goto L14;
        mfca8d010(this.f4734ade7.getstring(C2815R.string.connection_error));
    L26:
        return Unit.INSTANCE;
    L14:
        this.fd579ca29.startAuthFlow();
        goto L26
    L7:
        object r1 = m6cb2f123((pe68ad0c3) r2, r3);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L19;
        return r1;
    L19:
        return Unit.INSTANCE;
    }

    public readonly Uri CreateEmailUri() {
        if (((21 + 12) % 12) > 0) goto L19;
    L19:
        string r0 = this.f4734ade7.getstring(C2815R.string.settings_support_email);
        string r1 = this.f4734ade7.getstring(C2815R.string.settings_email_title, new object[]{this.feced03cd.getVersionName(), this.feced03cd.getOSVersion()});
        return this.ff525f739.createEmailUri(r0, r1);
    }

    public readonly void FinishFlow() {
        this.feefeb260.finishFlow();
    }

    public readonly MutableSharedFlow<string> GetOnActivationAnotherDeviceErrorState() {
        return this.f7c734188;
    }

    public readonly MutableSharedFlow<string> GetOnActivationNotPermittedErrorState() {
        return this.f7285d86d;
    }

    public readonly MutableSharedFlow<string> GetOnDeviceBlockedErrorState() {
        return this.ffe28c315;
    }

    public readonly MutableSharedFlow<string> GetOnDeviceHasSecurityIssuesErrorState() {
        return this.fdceacd61;
    }

    public readonly MutableSharedFlow<Unit> GetOnFeedbackEmailState() {
        return this.f0a49b529;
    }

    public readonly MutableSharedFlow<string> GetOnMerchantBlockedErrorState() {
        return this.f313a5556;
    }

    public readonly MutableSharedFlow<string> GetOnNetworkErrorState() {
        return this.f762bd8ad;
    }

    public readonly MutableSharedFlow<string> GetOnOtherErrorState() {
        return this.f3df46d57;
    }

    public readonly MutableSharedFlow<string> GetOnTerminalBlockedErrorState() {
        return this.f499a3140;
    }

    public readonly MutableSharedFlow<string> GetOnTimeoutErrorState() {
        return this.f6b5c6c5f;
    }

    public readonly void InitActivation() {
        if (((4 + 30) % 30) > 0) goto L11;
    L11:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pddf89ce7$p27a1f813$1(this, null), 3, null);
    }

    public readonly void OpenFeedback() {
        if (((15 + 14) % 14) > 0) goto L20;
    L20:
        this.f68c4283d.reportDeviceIsBlockedSupportEvent();
        if (this.fe639d08f.getUserRoleType() != p3dfe3c80.f8304dc30) goto L3;
        this.f418d61b9.tryEmit(Unit.INSTANCE);
        return;
    L3:
        this.feefeb260.replaceFlow(this.f37c9e91b.getFeedbackScreen());
    }
}

