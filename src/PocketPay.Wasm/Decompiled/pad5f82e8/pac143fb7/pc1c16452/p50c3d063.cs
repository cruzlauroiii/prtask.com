using Com.Google.Firebase.Crashlytics;
using Java.Sql;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P2b3583e6;
using P8d777f38.Pb3f20355.Pc1c16452;
using Pad5f82e8.P07214c67.Pc1c16452;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.Pac143fb7.P49f290d6;
using Pe0212e54.Pb3f20355;
using Pe0212e54.Pf5e638cc.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
public readonly class p50c3d063 : pf698b4bd {
    private readonly pda0b425a f0edc950e;
    private readonly p44cd4abe f1806a24e;
    private readonly p2f3c4196 f1c0c49a4;
    private readonly pda0b425a f3f96cece;
    private readonly p44cd4abe f83cfebcd;
    private readonly pda0b425a f88a0c5ab;
    private readonly p44cd4abe f8af308bf;
    private readonly pda0b425a f91902ffb;
    private readonly p2f3c4196 fe639d08f;
    private readonly p44cd4abe ff4d09bb0;
    private readonly pda0b425a ff9c49ed2;

    public p50c3d063(pda0b425a r2, p2f3c4196 r3, p44cd4abe r4) {
        iQtHFwHBeGevOnJm(r2, "marketDataRepository");
        PkYTnalJuNSfIFjL(r3, "userInfoUseCase");
        YYkHoiJJYsKWkcQS(r4, "devicesRepository");
        this.f88a0c5ab = r2;
        this.fe639d08f = r3;
        this.f8af308bf = r4;
    }

    public static object CcBIDsZCCkpLVyss(pda0b425a r1, string r2, Continuation r3) {
        return r1.getShopUUid(r2, r3);
    }

    public static string DgYWhOtDzAMBKiZZ(p2f3c4196 r1) {
        return r1.getUserId();
    }

    public static void KredAFjrLYtmuUfe(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static void LJaOKlJuBAgxCnhT(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void MdPmzOacDjkMrxgM(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string MvUlxfXatNoQXMPc(pd34153d4 r1) {
        return r1.getDeviceId();
    }

    public static string NyRUeBDUjmNNKiFQ(pd34153d4 r1) {
        return r1.getShopUuid();
    }

    public static void PkYTnalJuNSfIFjL(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object PyNYNFZttuoGxnRZ() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object QRDtIweWqyZMhGwf(p44cd4abe r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static string UVkfpFvykDxTWUzr(pd34153d4 r1) {
        return r1.getDeviceUuid();
    }

    public static bool VJVsBjBSKfJwpOku(bool r1) {
        return bool.valueOf(r1);
    }

    public static FirebaseCrashlytics VlaqsvkMQFyJQFyU() {
        return FirebaseCrashlytics.getInstance();
    }

    public static string WEICSbcylBoWAtjb(pd34153d4 r1) {
        return r1.getName();
    }

    public static void WghXfKqlcSyEdqNl(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Timestamp YBPPJcqYIFCxkDGG(long r1) {
        return p728cd16b.m9e5b1846(r1);
    }

    public static void YYkHoiJJYsKWkcQS(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object CBrpPOKrFLDuRFLl(pda0b425a r1, Continuation r2) {
        return r1.getName(r2);
    }

    public static string DdaHzpwuoJfVSprs(pd34153d4 r1) {
        return r1.getUserId();
    }

    public static object DzBvaFDyIFoKrHnx(pda0b425a r1, string r2, string r3, Continuation r4) {
        return r1.getMarketDeviceInfo(r2, r3, r4);
    }

    public static string ELYpnpAXZqcxdiEJ(p4f30e9bd r1) {
        return r1.getDeviceId();
    }

    public static string EuyorqiyvFWJCmFI(pd34153d4 r1) {
        return r1.getToken();
    }

    public static object GIVZiyZTCcPrzDSy(pda0b425a r1, string r2, Continuation r3) {
        return r1.getUserId(r2, r3);
    }

    public static void IQtHFwHBeGevOnJm(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string LeOwawqEQKERxZoP(p50c3d063 r1) {
        return r1.m0b6a0e0d();
    }

    public static long LuOVVMAqXYlIKldj() {
        if (((15 + 21) % 21) > 0) goto L18;
    L18:
        return System.currentTimeMillis();
    }

    private readonly string M0b6a0e0d() {
        return DgYWhOtDzAMBKiZZ(this.fe639d08f);
    L6:
        e = move-exception;
        KredAFjrLYtmuUfe(VlaqsvkMQFyJQFyU(), e);
        return null;
    }

    public static object MtwuWOiiQtYPguAL(pda0b425a r1, Continuation r2) {
        return r1.getToken(r2);
    }

    public static string RxNuJOzpWawPZMgf(p4f30e9bd r1) {
        return r1.getUserId();
    }

    public static List SEkBFEPtGmXixoNG() {
        return ICollectionsKt.emptyList();
    }

    public static string SahzNOUfqjwpPErx(p50c3d063 r1) {
        return r1.m0b6a0e0d();
    }

    public static void XTABfjhgaxPGhamr(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object XiRzzhBbBxZdcwQd(pda0b425a r1, string r2, string r3, Continuation r4) {
        return r1.updateDeviceInfo(r2, r3, r4);
    }

    @Override // pad5f82e8.pac143fb7.pc1c16452.pf698b4bd
    public p6285e3eb CreateDeviceEntity(pd34153d4 r20) {
        if (((22 + 17) % 17) > 0) goto L5;
    L5:
        MdPmzOacDjkMrxgM(r20, "marketDevice");
        string r3 = UVkfpFvykDxTWUzr(r20);
        string r2 = MvUlxfXatNoQXMPc(r20);
        string r8 = WEICSbcylBoWAtjb(r20);
        p9d21d731 r9 = p9d21d731.f86d1debf;
        Timestamp r12 = YBPPJcqYIFCxkDGG(luOVVMAqXYlIKldj());
        string r5 = NyRUeBDUjmNNKiFQ(r20);
        return new p6285e3eb(r2, r3, ddaHzpwuoJfVSprs(r20), r5, null, null, r8, r9, null, null, r12, null, null, sEkBFEPtGmXixoNG(), euyorqiyvFWJCmFI(r20), p854660d3.f54b4c407, VJVsBjBSKfJwpOku(true));
    }

    @Override // pad5f82e8.pac143fb7.pc1c16452.pf698b4bd
    public object GetMarketDeviceInfo(string r2, string r3, Continuation<pd34153d4> r4) {
        pda0b425a r0 = this.f88a0c5ab;
        string r1 = leOwawqEQKERxZoP(this);
        if (r1 is null) goto L6;
        r3 = r1;
    L6:
        return dzBvaFDyIFoKrHnx(r0, r2, r3, r4);
    }

    @Override // pad5f82e8.pac143fb7.pc1c16452.pf698b4bd
    public object GetName(Continuation<string> r1) {
        return cBrpPOKrFLDuRFLl(this.f88a0c5ab, r1);
    }

    @Override // pad5f82e8.pac143fb7.pc1c16452.pf698b4bd
    public object GetShopUUid(string r1, Continuation<string> r2) {
        return CcBIDsZCCkpLVyss(this.f88a0c5ab, r1, r2);
    }

    @Override // pad5f82e8.pac143fb7.pc1c16452.pf698b4bd
    public object GetToken(Continuation<string> r1) {
        return mtwuWOiiQtYPguAL(this.f88a0c5ab, r1);
    }

    @Override // pad5f82e8.pac143fb7.pc1c16452.pf698b4bd
    public object GetUserId(string r1, Continuation<string> r2) {
        return gIVZiyZTCcPrzDSy(this.f88a0c5ab, r1, r2);
    }

    @Override // pad5f82e8.pac143fb7.pc1c16452.pf698b4bd
    public object UpdateDeviceInfo(Continuation<Unit> r6) {
        if (((15 + 22) % 22) > 0) goto L45;
    L45:
        if ((r6 is p50c3d063$p2ad2d5b1$1) == true) goto L17;
    L50:
        p50c3d063$p2ad2d5b1$1 r0 = new p50c3d063$p2ad2d5b1$1(this, r6);
    L88:
        object r62 = r0.fb4a88417;
        object r1 = PyNYNFZttuoGxnRZ();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L14;
        xTABfjhgaxPGhamr(r62);
        p44cd4abe r63 = this.f8af308bf;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = QRDtIweWqyZMhGwf(r63, r0);
        if (r62 == r1) goto L64;
    L61:
        p4f30e9bd r64 = (p4f30e9bd) r62;
        pda0b425a r22 = this.f88a0c5ab;
        string r5 = sahzNOUfqjwpPErx(this);
        if (r5 is null) goto L48;
    L74:
        string r65 = eLYpnpAXZqcxdiEJ(r64);
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (xiRzzhBbBxZdcwQd(r22, r5, r65, r0) == r1) goto L64;
    L19:
        return Unit.INSTANCE;
    L48:
        r5 = rxNuJOzpWawPZMgf(r64);
    L64:
        return r1;
    L14:
        if (r2 == 1) goto L41;
        if (r2 != 2) goto L71;
        LJaOKlJuBAgxCnhT(r62);
        goto L19
    L71:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L41:
        p50c3d063 this = (p50c3d063) r0.L$0;
        WghXfKqlcSyEdqNl(r62);
        goto L61
    L17:
        r0 = (p50c3d063$p2ad2d5b1$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L50;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L88
    }
}

