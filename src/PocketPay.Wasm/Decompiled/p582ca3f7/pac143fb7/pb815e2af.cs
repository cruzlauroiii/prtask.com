using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using P1e11b989.P9acb4454.Pac143fb7;
using P582ca3f7.Pb3f20355;
using Pad5f82e8.P07214c67.Pfa547353;
using Pad5f82e8.Pac143fb7.P49f290d6;
using Pad5f82e8.Pac143fb7.Pc1c16452;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
public readonly class pb815e2af : p69d862b4 {
    private readonly pf698b4bd f346ec0d2;
    private readonly p2f3c4196 f38ac934b;
    private readonly p883b57c7 f395bf4d9;
    private readonly p0c2c0436 f3e3d3186;
    private readonly p2f3c4196 f6617a71f;
    private readonly p2f3c4196 fa5665f61;
    private readonly p2f3c4196 fe639d08f;
    private readonly p0c2c0436 fe64181c7;
    private readonly pf698b4bd feab592e9;
    private readonly p0c2c0436 fedc5f59e;
    private readonly p883b57c7 ffd129412;

    public pb815e2af(p0c2c0436 r2, pf698b4bd r3, p2f3c4196 r4, p883b57c7 r5) {
        pJRyiwUMTqJwowgD(r2, "employeesRepository");
        mIMpjKkWmePwKoiy(r3, "marketDataUseCase");
        NFkEgRzbXemATUre(r4, "userInfoUseCase");
        KXIBEGKvkJZwbAOa(r5, "receiptStatusUseCase");
        this.fedc5f59e = r2;
        this.feab592e9 = r3;
        this.fe639d08f = r4;
        this.f395bf4d9 = r5;
    }

    public static void AiZSRxCRRJPFuGGC(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string DBxpHgNjixtydOSL(p0c2c0436 r1, pf8c8b903 r2) {
        return r1.getEmployeeName(r2);
    }

    public static object DKyzorfBXvbfZyut(pb815e2af r1, pf8c8b903 r2, Continuation r3) {
        return r1.selectEmployee(r2, r3);
    }

    public static void EDxjYVFfofQGWxhA(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object GYtcuATazZceVLyV(p0c2c0436 r1, Continuation r2) {
        return r1.getSelectedEmployee(r2);
    }

    public static void GvaIfjyzIkTdPMdU(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void GyzuZIsamRflXFTL(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void KXIBEGKvkJZwbAOa(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static List MWMOwgbHeQoWIPAC(pfdeddcd7 r1) {
        return r1.getGrantTypes();
    }

    public static void NFkEgRzbXemATUre(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object OcEVYWIFbVydAmar(pf698b4bd r1, string r2, Continuation r3, int r4, object r5) {
        return pf698b4bd.pb0da8397.ma8c2291f(r1, r2, r3, r4, r5);
    }

    public static object SjqsupnKmBVjNbLI() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void VoISLEIlunfAQCuo(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object YVLAnDZLFeUKEOma(pb815e2af r1, string r2, Continuation r3) {
        return r1.getSelectedEmployeeGrant(r2, r3);
    }

    public static void YrmIOUxepijErMgh(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static int ZtcgVppsfGGRpNMi(CharSequence r1) {
        return r1.Length;
    }

    public static void BaqcPbMWzHicPQPJ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object BrdHyLOkATuqshFe(pb815e2af r1, Continuation r2) {
        return r1.getSelectedEmployee(r2);
    }

    public static void DvKBiZDbwbrBOlTn(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void JROERoACsMwcmiCw(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object JunCGEewdlNUcmTR() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static bool JxPafrWNDzxaCoSS(bool r1) {
        return Boxing.boxbool(r1);
    }

    public static object KjHUJlLhKnjfOcBU(p0c2c0436 r1, string r2, Continuation r3) {
        return r1.getSelectedEmployeeGrant(r2, r3);
    }

    public static readonly /* synthetic */ object m79f0e9d8(pb815e2af r0, Continuation r1) {
        return nKCTMvZtfgvtDTlw(r0, r1);
    }

    public static void MIMpjKkWmePwKoiy(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object MTBylrrYRTePCmhT(p0c2c0436 r1, pf8c8b903 r2, Continuation r3) {
        return r1.selectEmployee(r2, r3);
    }

    private readonly object Maa8a7efd(Continuation<Unit> r6) {
        if (((2 + 2) % 2) > 0) goto L73;
    L73:
        if ((r6 is pb815e2af$paa8a7efd$1) == false) goto L61;
        pb815e2af$paa8a7efd$1 r0 = (pb815e2af$paa8a7efd$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L61;
        r0.fd304ba20 -= int.MIN_VALUE;
    L57:
        object r62 = r0.fb4a88417;
        object r1 = wkKswagTXDPigvoV();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L3;
        if (r2 == 1) goto L47;
        if (r2 != 2) goto L42;
        pb815e2af this = (pb815e2af) r0.L$0;
        EDxjYVFfofQGWxhA(r62);
    L37:
        mmcusAWyMBZGgAHW(this.fe639d08f, MWMOwgbHeQoWIPAC((pfdeddcd7) r62));
        return Unit.INSTANCE;
    L42:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L47:
        this = (pb815e2af) r0.L$0;
        baqcPbMWzHicPQPJ(r62);
    L86:
        string r63 = (string) r62;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        r62 = YVLAnDZLFeUKEOma(this, r63, r0);
        if (r62 != r1) goto L37;
    L35:
        return r1;
    L3:
        jROERoACsMwcmiCw(r62);
        pf698b4bd r64 = this.feab592e9;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = OcEVYWIFbVydAmar(r64, null, r0, 1, null);
        if (r62 == r1) goto L35;
    L61:
        r0 = new pb815e2af$paa8a7efd$1(this, r6);
        goto L57
    }

    public static void MmcusAWyMBZGgAHW(p2f3c4196 r0, List r1) {
        r0.updateUserGrantType(r1);
    }

    public static object NKCTMvZtfgvtDTlw(pb815e2af r1, Continuation r2) {
        return r1.maa8a7efd(r2);
    }

    public static void PJRyiwUMTqJwowgD(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object RHdKNdGyHBTOPfpD(pb815e2af r1, Continuation r2) {
        return r1.maa8a7efd(r2);
    }

    public static void UWjKPxwOUWfrLmBi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object WkKswagTXDPigvoV() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object YGkKLOTjIUlxBZLX() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string YThDWmOcTEeJPmvi(pf8c8b903 r1) {
        return r1.getPin();
    }

    public static object ZJRbuNCsyKRFsdzz(p883b57c7 r1, Continuation r2) {
        return r1.loadReceiptsStatus(r2);
    }

    @Override // p582ca3f7.pac143fb7.p69d862b4
    public object ApplyEmployee(pf8c8b903 r8, Continuation<Unit> r9) {
        if (((30 + 23) % 23) > 0) goto L76;
    L76:
        if ((r9 is pb815e2af$p055406a0$1) == false) goto L106;
        pb815e2af$p055406a0$1 r0 = (pb815e2af$p055406a0$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L106;
        r0.fd304ba20 -= int.MIN_VALUE;
    L30:
        object r92 = r0.fb4a88417;
        object r1 = junCGEewdlNUcmTR();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L64;
        dvKBiZDbwbrBOlTn(r92);
        p883b57c7 r93 = this.f395bf4d9;
        r0.L$0 = this;
        r0.L$1 = r8;
        r0.fd304ba20 = 1;
        if (zJRbuNCsyKRFsdzz(r93, r0) == r1) goto L34;
    L3:
        r0.L$0 = this;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (DKyzorfBXvbfZyut(this, r8, r0) == r1) goto L34;
    L95:
        r0.L$0 = null;
        r0.fd304ba20 = 3;
        if (rHdKNdGyHBTOPfpD(this, r0) == r1) goto L34;
    L100:
        return Unit.INSTANCE;
    L34:
        return r1;
    L64:
        if (r2 == 1) goto L105;
        if (r2 == 2) goto L29;
        if (r2 != 3) goto L86;
        uWjKPxwOUWfrLmBi(r92);
        goto L100
    L86:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L29:
        pb815e2af this = (pb815e2af) r0.L$0;
        AiZSRxCRRJPFuGGC(r92);
        goto L95
    L105:
        r8 = (pf8c8b903) r0.L$1;
        this = (pb815e2af) r0.L$0;
        VoISLEIlunfAQCuo(r92);
    L106:
        r0 = new pb815e2af$p055406a0$1(this, r9);
        goto L30
    }

    @Override // p582ca3f7.pac143fb7.p69d862b4
    public string GetEmployeeName(pf8c8b903 r2) {
        GvaIfjyzIkTdPMdU(r2, "employee");
        return DBxpHgNjixtydOSL(this.fedc5f59e, r2);
    }

    @Override // p582ca3f7.pac143fb7.p69d862b4
    public object GetSelectedEmployee(Continuation<pf8c8b903> r1) {
        return GYtcuATazZceVLyV(this.fedc5f59e, r1);
    }

    @Override // p582ca3f7.pac143fb7.p69d862b4
    public object GetSelectedEmployeeGrant(string r1, Continuation<pfdeddcd7> r2) {
        return kjHUJlLhKnjfOcBU(this.fedc5f59e, r1, r2);
    }

    @Override // p582ca3f7.pac143fb7.p69d862b4
    public object IsSelectedEmployeeWithPin(Continuation<bool> r5) {
        if (((2 + 20) % 20) > 0) goto L76;
    L76:
        if ((r5 is pb815e2af$p0bcf4865$1) == false) goto L71;
        pb815e2af$p0bcf4865$1 r0 = (pb815e2af$p0bcf4865$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L71;
        r0.fd304ba20 -= int.MIN_VALUE;
    L58:
        object r52 = r0.fb4a88417;
        object r1 = SjqsupnKmBVjNbLI();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L47;
        GyzuZIsamRflXFTL(r52);
        r0.fd304ba20 = 1;
        r52 = brdHyLOkATuqshFe(this, r0);
        if (r52 != r1) goto L27;
        return r1;
    L27:
        string r4 = yThDWmOcTEeJPmvi((pf8c8b903) r52);
        if (r4 is not null) goto L35;
    L55:
        bool r42 = true;
    L10:
        return jxPafrWNDzxaCoSS(!r42);
    L35:
        if (ZtcgVppsfGGRpNMi(r4) == 0) goto L55;
        r42 = false;
        goto L10
    L47:
        if (r2 != 1) goto L28;
        YrmIOUxepijErMgh(r52);
        goto L27
    L28:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L71:
        r0 = new pb815e2af$p0bcf4865$1(this, r5);
        goto L58
    }

    @Override // p582ca3f7.pac143fb7.p69d862b4
    public object SelectEmployee(pf8c8b903 r1, Continuation<Unit> r2) {
        object r0 = mTBylrrYRTePCmhT(this.fedc5f59e, r1, r2);
        if (r0 != yGkKLOTjIUlxBZLX()) goto L8;
        return r0;
    L8:
        return Unit.INSTANCE;
    }
}

