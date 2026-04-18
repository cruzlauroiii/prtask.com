using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using P776ea3bf.Pb3f20355;
using P83f5c3ad.P07214c67;
using P83f5c3ad.P684019bc;
using P83f5c3ad.P684019bc.P94a08da1;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pe0212e54.Pb3f20355;
using Pe0212e54.Pf5e638cc.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class pa99796e8 : p943cc0d1 {
    private readonly pc037f116 f07435573;
    private readonly paa56254c f0a4a4279;
    private readonly pfeb9ca41 f0fc09813;
    private readonly p6c37087b f13f2abe2;
    private readonly pda65ae8b f183eafc1;
    private readonly pe9ddd6b8 f18eeba9c;
    private readonly p2a001473 f1d78bcc7;
    private readonly p2a001473 f2bdf82ca;
    private readonly paa56254c f2f9d43e7;
    private readonly pf0e0b2b5 f2ff95585;
    private readonly pe9ddd6b8 f39398a04;
    private readonly pe9ddd6b8 f41d23247;
    private readonly p6c37087b f477bdbd2;
    private readonly p6c37087b f4b90b10a;
    private readonly pc037f116 f4ceac0f2;
    private readonly pda65ae8b f691c13ab;
    private readonly pfeb9ca41 f73cfe306;
    private readonly paa56254c f85023390;
    private readonly pfeb9ca41 f94b1a5d3;
    private readonly p2a001473 f9cd5a712;
    private readonly pf0e0b2b5 f9f880688;
    private readonly pda65ae8b fa30a1903;
    private readonly pe9ddd6b8 faffe2d91;
    private readonly pda65ae8b fc7b95001;
    private readonly p2a001473 fcabb0f56;
    private readonly pc037f116 fd11adf5e;
    private readonly p2a001473 fd2ddab52;
    private readonly p6c37087b fde6995ed;
    private readonly pda65ae8b ffa0bf697;
    private readonly pfeb9ca41 ffa781974;
    private readonly p6c37087b ffe599087;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((21 + 8) % 8) > 0) goto L4;
        L4:
            int[] r0 = new int[xOimAbinGdZoAjeq().length];
            r0[inVPebZleolPwjPX(p15913342.f6718aa2c)] = 1;     // Catch: NoSuchFieldError -> L26
        L28:
            r0[dMPClKRhKchbZdLm(p15913342.f86e418e3)] = 2;     // Catch: NoSuchFieldError -> L27
        L25:
            $EnumSwitchDictionaryping$0 = r0;
        }

        public static int DMPClKRhKchbZdLm(p15913342 r1) {
            return r1.ordinal();
        }

        public static int InVPebZleolPwjPX(p15913342 r1) {
            return r1.ordinal();
        }

        public static p15913342[] XOimAbinGdZoAjeq() {
            return p15913342.Values;
        }
    }

    public pa99796e8(p6c37087b r2, pe9ddd6b8 r3, paa56254c r4, p2a001473 r5, pc037f116 r6, pf0e0b2b5 r7, pda65ae8b r8, pfeb9ca41 r9) {
        AJbcKftwbJvIEiKz(r2, "initTapOnPhoneUseCase");
        mdGXqQPXnAPcZonb(r3, "activationTapOnPhoneUseCase");
        UFykcpsVVDUfZrUi(r4, "tophTokenUseCase");
        HwInCUBeqhVtKtfp(r5, "integrationTophHashSettingsRepository");
        WUaUsWeYzIayMXAf(r6, "logoutTapOnPhoneUseCase");
        ZxcuspOwNqVnncsO(r7, "integrationAuthUseCase");
        NPkRhTDuIMLuCOgh(r8, "integrationDevicesRepository");
        rvHIKQktSGVKGFsL(r9, "devicesDbRepository");
        this.f477bdbd2 = r2;
        this.f18eeba9c = r3;
        this.f0a4a4279 = r4;
        this.f1d78bcc7 = r5;
        this.f4ceac0f2 = r6;
        this.f9f880688 = r7;
        this.fc7b95001 = r8;
        this.ffa781974 = r9;
    }

    public static void AJbcKftwbJvIEiKz(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void APXanOiBKCsgQPiv(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void BPXbSOplgsjxzFtH(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool DvJXyJORDUtXnxbj(bool r1) {
        return r1.boolValue();
    }

    public static string FwCficOxbKNeESfO(p6285e3eb r1) {
        return r1.getDeviceId();
    }

    public static void GuCwByCjSHWIugfr(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void HwInCUBeqhVtKtfp(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object HzomBotGIssbytOJ(p6c37087b r1, Continuation r2) {
        return r1.initTapOnPhone(r2);
    }

    public static void LMRpmXpTepfFIPGX(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p48bc8063 MLyKHpOaTInzLfOZ(pa99796e8 r1) {
        return r1.mef770b24();
    }

    public static void MvywdPmeDZAZlqzr(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void NPkRhTDuIMLuCOgh(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object POfPwgYFGDMgGplj(object r1) {
        return Result.m1390constructorimpl(r1);
    }

    public static object QVvOpHAgMDfDjEpN() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void ScXKeEzruaEOmNoi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void UFykcpsVVDUfZrUi(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static bool WAfVConsoleSdcJZalGx(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static void WUaUsWeYzIayMXAf(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static bool XMcILQHpwWuPKxHP(bool r1) {
        return Boxing.boxbool(r1);
    }

    public static object XgwXcUENHNwKFgOr(pa99796e8 r1, Continuation r2) {
        return r1.m6a2af343(r2);
    }

    public static void ZxcuspOwNqVnncsO(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object BdSPtcPYdWyXbLzt() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void DtqmaRVnHtVoasnP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object JVYEZdHCzsXkvlcj() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string JcknAXNJphNFhXKe(pf0e0b2b5 r1) {
        return r1.getTopToken();
    }

    public static p48bc8063 KAgIFPSHohJgWkvn(pa99796e8 r1) {
        return r1.mef770b24();
    }

    public static void LJsqMCGNyyecdaue(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void LZQPCGBVcJAtmYEb(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void LglzRywLIkiQmjLp(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static readonly /* synthetic */ object m32872c7c(pa99796e8 r0, Continuation r1) {
        return yWoSGTFBxqsUHstn(r0, r1);
    }

    public static readonly /* synthetic */ object m5718a856(pa99796e8 r0, Continuation r1) {
        return XgwXcUENHNwKFgOr(r0, r1);
    }

    public static readonly /* synthetic */ object m5a40e61c(pa99796e8 r0, Continuation r1) {
        return ulcZEoWLMsoETrqE(r0, r1);
    }

    private readonly object M6a2af343(Continuation<p48bc8063> r6) {
        if (((16 + 24) % 24) > 0) goto L49;
    L49:
        if ((r6 is pa99796e8$p6a2af343$1) == false) goto L78;
        pa99796e8$p6a2af343$1 r0 = (pa99796e8$p6a2af343$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L78;
        r0.fd304ba20 -= int.MIN_VALUE;
    L39:
        object r62 = r0.fb4a88417;
        object r1 = QVvOpHAgMDfDjEpN();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L40;
        lglzRywLIkiQmjLp(r62);
        string r63 = jcknAXNJphNFhXKe(this.f9f880688);
        pe9ddd6b8 r22 = this.f18eeba9c;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (vtOHXWwnbAEFCPEp(r22, r63, r0) != r1) goto L6;
    L46:
        return r1;
    L6:
        pe9ddd6b8 r64 = this.f18eeba9c;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (uyZPPokhlICrXLsj(r64, null, r0, 1, null) == r1) goto L46;
    L25:
        return kAgIFPSHohJgWkvn(this);
    L40:
        if (r2 == 1) goto L33;
        if (r2 == 2) goto L77;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L77:
        pa99796e8 this = (pa99796e8) r0.L$0;
        GuCwByCjSHWIugfr(r62);
        goto L25
    L33:
        this = (pa99796e8) r0.L$0;
        dtqmaRVnHtVoasnP(r62);
    L78:
        r0 = new pa99796e8$p6a2af343$1(this, r6);
        goto L39
    }

    private readonly object Mc512221d(Continuation<Unit> r6) {
        if (((10 + 25) % 25) > 0) goto L51;
    L51:
        if ((r6 is pa99796e8$pc512221d$1) == false) goto L68;
        pa99796e8$pc512221d$1 r0 = (pa99796e8$pc512221d$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L68;
        r0.fd304ba20 -= int.MIN_VALUE;
    L15:
        object r62 = r0.fb4a88417;
        object r1 = bdSPtcPYdWyXbLzt();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L24;
        if (r2 == 1) goto L3;
        if (r2 != 2) goto L35;
        LMRpmXpTepfFIPGX(r62);     // Catch: Exception -> L13
    L33:
        yBBbVmJHyyGyeBdX(Unit.INSTANCE);     // Catch: Exception -> L13
    L8:
        return Unit.INSTANCE;
    L35:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L3:
        pa99796e8 this = (pa99796e8) r0.L$0;
        oQWfChNrUStzxcGU(r62);     // Catch: Exception -> L13
    L29:
        if (DvJXyJORDUtXnxbj((bool) r62) == false) goto L33;
        pc037f116 r5 = this.f4ceac0f2;     // Catch: Exception -> L13
        r0.L$0 = null;     // Catch: Exception -> L13
        r0.fd304ba20 = 2;     // Catch: Exception -> L13
        if (ztyIorUaqHCIafaK(r5, r0) != r1) goto L33;
    L32:
        return r1;
    L24:
        smXqDdkjiZTWvsmf(r62);
        Result.Companion r63 = Result.Companion;     // Catch: Exception -> L13
        pa99796e8 r64 = this;     // Catch: Exception -> L13
        r0.L$0 = this;     // Catch: Exception -> L13
        r0.fd304ba20 = 1;     // Catch: Exception -> L13
        r62 = rBsUtIqkjDKkinSn(this, r0);     // Catch: Exception -> L13
        if (r62 != r1) goto L29;
    L13:
        th = move-exception;
        Result.Companion r65 = Result.Companion;
        POfPwgYFGDMgGplj(ynSFFspuIyebAxuZ(th));
    L68:
        r0 = new pa99796e8$pc512221d$1(this, r6);
        goto L15
    }

    public static void MdGXqQPXnAPcZonb(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    private readonly object Me4b240e9(Continuation<bool> r7) {
        if (((31 + 7) % 7) > 0) goto L85;
    L85:
        if ((r7 is pa99796e8$pe4b240e9$1) == true) goto L106;
    L9:
        pa99796e8$pe4b240e9$1 r0 = new pa99796e8$pe4b240e9$1(this, r7);
    L89:
        object r72 = r0.fb4a88417;
        object r1 = jVYEZdHCzsXkvlcj();
        int r2 = r0.fd304ba20;
        bool r4 = true;
        if (r2 != 0) goto L6;
        lZQPCGBVcJAtmYEb(r72);
        pda65ae8b r73 = this.fc7b95001;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = vQEoZbIckqrShsQM(r73, r0);
        if (r72 != r1) goto L71;
    L59:
        return r1;
    L71:
        string r74 = yUGZnVWqnOoUXCBb((p6285e3eb) r72);
        pfeb9ca41 r22 = this.ffa781974;
        r0.L$0 = this;
        r0.L$1 = r74;
        r0.fd304ba20 = 2;
        object r02 = tNUWhLAUBjYEqRwo(r22, r0);
        if (r02 == r1) goto L59;
        pa99796e8 r03 = this;
        string r6 = r74;
        r72 = r02;
    L50:
        if (WAfVConsoleSdcJZalGx(r6, FwCficOxbKNeESfO((p6285e3eb) r72)) == false) goto L108;
    L63:
        r4 = false;
    L80:
        return XMcILQHpwWuPKxHP(r4);
    L108:
        if (uLWEJFbQCxycSasb(r03.f18eeba9c) == true) goto L80;
    L6:
        if (r2 == 1) goto L28;
        if (r2 == 2) goto L62;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L62:
        r6 = (string) r0.L$1;
        r03 = (pa99796e8) r0.L$0;
        BPXbSOplgsjxzFtH(r72);
        goto L50
    L28:
        pa99796e8 this = (pa99796e8) r0.L$0;
        uDaBQGbIwmdcdTQf(r72);
        goto L71
    L106:
        r0 = (pa99796e8$pe4b240e9$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L9;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L89
    }

    private readonly p48bc8063 Mef770b24() {
        p15913342 r1 = qsysGmieKfaecVMx(this.f1d78bcc7);
        int r12 = p12c674ac.$EnumSwitchDictionaryping$0[paLWLApHiFRuTGEq(r1)];
        if (r12 == 1) goto L11;
        if (r12 == 2) goto L22;
        return p48bc8063.f6cddd593;
    L22:
        return p48bc8063.f9be5efb7;
    L11:
        return p48bc8063.f860926e6;
    }

    public static void OQWfChNrUStzxcGU(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static int PaLWLApHiFRuTGEq(p15913342 r1) {
        return r1.ordinal();
    }

    public static p15913342 QsysGmieKfaecVMx(p2a001473 r1) {
        return r1.getStartTopRoute();
    }

    public static object RBsUtIqkjDKkinSn(pa99796e8 r1, Continuation r2) {
        return r1.me4b240e9(r2);
    }

    public static void RvHIKQktSGVKGFsL(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void SmXqDdkjiZTWvsmf(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object TNUWhLAUBjYEqRwo(pfeb9ca41 r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static void UDaBQGbIwmdcdTQf(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool ULWEJFbQCxycSasb(pe9ddd6b8 r1) {
        return r1.isActivatedCache();
    }

    public static object UlcZEoWLMsoETrqE(pa99796e8 r1, Continuation r2) {
        return r1.mc512221d(r2);
    }

    public static object UyZPPokhlICrXLsj(pe9ddd6b8 r1, string r2, Continuation r3, int r4, object r5) {
        return pe9ddd6b8.pb0da8397.mc0c6c995(r1, r2, r3, r4, r5);
    }

    public static object VQEoZbIckqrShsQM(pda65ae8b r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static object VtOHXWwnbAEFCPEp(pe9ddd6b8 r1, string r2, Continuation r3) {
        return r1.initActivationWithToken(r2, r3);
    }

    public static object WnTYJeyXTfGsALrf() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static bool WzNqIczhIMZzHZGO(pe9ddd6b8 r1) {
        return r1.checkActivated();
    }

    public static object XMTwFSNMZWMUyUxj(pa99796e8 r1, Continuation r2) {
        return r1.mc512221d(r2);
    }

    public static object YBBbVmJHyyGyeBdX(object r1) {
        return Result.m1390constructorimpl(r1);
    }

    public static object YNTgtYoVtMAfcvgK(pa99796e8 r1, Continuation r2) {
        return r1.m6a2af343(r2);
    }

    public static string YUGZnVWqnOoUXCBb(p6285e3eb r1) {
        return r1.getDeviceId();
    }

    public static object YWoSGTFBxqsUHstn(pa99796e8 r1, Continuation r2) {
        return r1.me4b240e9(r2);
    }

    public static object YnSFFspuIyebAxuZ(Exception r1) {
        return ResultKt.createFailure(r1);
    }

    public static object ZtyIorUaqHCIafaK(pc037f116 r1, Continuation r2) {
        return r1.logout(r2);
    }

    @Override // p83f5c3ad.p684019bc.p6aaf2903
    public object GetStartScreen(Continuation<p48bc8063> r7) {
        if (((18 + 18) % 18) > 0) goto L37;
    L37:
        if ((r7 is pa99796e8$pe872ce79$1) == true) goto L90;
    L84:
        pa99796e8$pe872ce79$1 r0 = new pa99796e8$pe872ce79$1(this, r7);
    L91:
        object r72 = r0.fb4a88417;
        object r1 = wnTYJeyXTfGsALrf();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L12;
        if (r2 == 1) goto L23;
        if (r2 == 2) goto L49;
        if (r2 != 3) goto L100;
        lJsqMCGNyyecdaue(r72);
        return r72;
    L100:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L49:
        pa99796e8 this = (pa99796e8) r0.L$0;
        MvywdPmeDZAZlqzr(r72);
    L79:
        if (wzNqIczhIMZzHZGO(this.f18eeba9c) == false) goto L105;
        return MLyKHpOaTInzLfOZ(this);
    L105:
        r0.L$0 = null;
        r0.fd304ba20 = 3;
        object r6 = yNTgtYoVtMAfcvgK(this, r0);
        if (r6 == r1) goto L56;
        return r6;
    L56:
        return r1;
    L23:
        this = (pa99796e8) r0.L$0;
        ScXKeEzruaEOmNoi(r72);
    L75:
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (xMTwFSNMZWMUyUxj(this, r0) == r1) goto L56;
    L12:
        APXanOiBKCsgQPiv(r72);
        p6c37087b r73 = this.f477bdbd2;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (HzomBotGIssbytOJ(r73, r0) == r1) goto L56;
    L90:
        r0 = (pa99796e8$pe872ce79$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L84;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L91
    }
}

