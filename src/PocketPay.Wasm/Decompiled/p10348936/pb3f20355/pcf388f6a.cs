using Androidx.Core.App;
using Com.Decryptstringmanager;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P10348936.Pf5e638cc;
using P10348936.Pf5e638cc.Pd77d5e50;
using P2b3583e6;
using P2b3583e6.P263e3cef;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.P7a1eabc3;
using Pad5f82e8.P07214c67.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class pcf388f6a : pf94220ad {
    private readonly p226a374c f214796ac;
    private readonly p226a374c f414d6d77;
    private readonly p226a374c f6630115f;
    private readonly p226a374c f9f708994;
    private readonly p226a374c ff79b6d1d;

    public pcf388f6a(p226a374c r2) {
        WHuAXPbrwfEXPxmf(r2, "currentInventorizationDbRepository");
        this.f9f708994 = r2;
    }

    public static object APuwvRrYuqHfHFTw() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static decimal AiODvwgcUzBVieFW(pd031d465 r1) {
        return r1.getQuantity();
    }

    public static object AqoekpBykzWRXfnu(p226a374c r1, string r2, Continuation r3) {
        return r1.removeCurrentInventorizationPosition(r2, r3);
    }

    public static int BOztvxwogYfsztBQ(pd031d465 r1) {
        return r1.getPrecision();
    }

    public static void BrcEJckkNFmGbJaQ(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static string CDphUxmEgeXrtlfF(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static object CGnOriwkdGmRAfKP() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object CbPIxxdhJyTLJGoP(p226a374c r1, Continuation r2) {
        return r1.clearCurrentInventorizations(r2);
    }

    public static void CnScoQCTDHwhzYKh(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string DUinXkdpazqJTrGM(pd031d465 r1) {
        return r1.getTax();
    }

    public static object DafIZUyhJvCjIAyV() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object DwxqUMmARfZjHRbj(p226a374c r1, Continuation r2) {
        return r1.getCurrentInventorizationPositions(r2);
    }

    public static bool EoRuKjxGlmJAbHCh(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static object FJLOTAggRkTyZJAq(p226a374c r1, p0ed7807b r2, Continuation r3) {
        return r1.insertCurrentInventorizationPosition(r2, r3);
    }

    public static p0690dac5 HJcIAKbQLVOeAxje(pcf388f6a r1, p34c3b0bd r2) {
        return r1.m1e887f72(r2);
    }

    public static decimal HZFUtDSgEdpAVdUP(decimal r1) {
        return p7667d148.m26e017cd(r1);
    }

    public static void HtwIVcaORhpZhbuE(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object INSKcUlzIqfHvGls(pcf388f6a r1, Continuation r2) {
        return r1.getCurrentInventorization(r2);
    }

    public static void IQPFJuVfqeLDRmZY(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object IxHwqgDZHvFKWJVv(p226a374c r1, p0ed7807b r2, Continuation r3) {
        return r1.updateCurrentInventorizationPosition(r2, r3);
    }

    public static object KnxkYiuUXfuTvznF(p226a374c r1, p12e406c7 r2, Continuation r3) {
        return r1.createCurrentInventorization(r2, r3);
    }

    public static void MDcAYTaEEdWpKkUD(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p0ed7807b NXOTSPMIVfTrIlxb(pcf388f6a r1, pd031d465 r2, string r3) {
        return r1.m649c04a1(r2, r3);
    }

    public static decimal OIBdFxtNPEYReyWQ(p0ed7807b r1) {
        return r1.getPrice();
    }

    public static decimal PlEXGObTtoFGRcyh(pd031d465 r1) {
        return r1.getPrice();
    }

    public static string QTPyzapuOApDqput(p12e406c7 r1) {
        return r1.getEmployeeId();
    }

    public static string QaXbhbWqblgVDGJM(p0690dac5 r1) {
        return r1.getUuid();
    }

    public static IEnumerator QbvYyvOtmOcxXSGf(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static decimal RbHSMUsngQFBDKgK(pd031d465 r1) {
        return r1.getPurchasePrice();
    }

    public static string RkqCmFSwlHLLJRfv(pd031d465 r1) {
        return r1.getMeasure();
    }

    public static string RoZyCOOpJJNEPuAt(p0ed7807b r1) {
        return r1.getMeasure();
    }

    public static string SXBTKYzkChGwglOF(p0ed7807b r1) {
        return r1.getUuid();
    }

    public static object TpisTXlOvRjlQEuh() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string TzzkukkNJqKVAATF(p12e406c7 r1) {
        return r1.getUuid();
    }

    public static void UOltGPPdLiqAFpou(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p12e406c7 UlzaObeKzJBgmHTl(pcf388f6a r1, string r2) {
        return r1.m6df7a60a(r2);
    }

    public static object VTxnEYLfGIVffvgU(pcf388f6a r1, Continuation r2) {
        return r1.getCurrentInventorization(r2);
    }

    public static void WHuAXPbrwfEXPxmf(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string WVrPbbUmQtCrozcm(p0ed7807b r1) {
        return r1.getName();
    }

    public static void WqfcelTMcOfNeSla(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static decimal YKoZyFEmLmfOtGou(decimal r1) {
        return p7667d148.m26e017cd(r1);
    }

    public static p12e406c7 YtfqRIzTEqdDuDoV(p34c3b0bd r1) {
        return r1.getInventorizationDbEntity();
    }

    public static pa1fa2777 ZhdnYyDxqyBNfDbG(p0ed7807b r1) {
        return r1.getType();
    }

    public static object ZohscRWwKIOsxQfx(p226a374c r1, p14abd389 r2, Continuation r3) {
        return r1.updateCurrentInventorization(r2, r3);
    }

    public static string ZvhiQvqZeYCqaCJE(Guid r1) {
        return r1.tostring();
    }

    public static decimal AiIZyggRTRavbEMA(p0ed7807b r1) {
        return r1.getPriceWithDiscount();
    }

    public static bool BgFKqbiRhXQmSsAA(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static decimal CHLFjaMTYgcmxpGM(pd031d465 r1) {
        return r1.getInitialQuantity();
    }

    public static object CVbGlkrJwZPoUOhK() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string DVcEJSmnnXNgqnyc(pd031d465 r1) {
        return r1.getUuid();
    }

    public static decimal EHDOpSOGQitGGtWP(pd031d465 r1) {
        return r1.getPriceWithDiscount();
    }

    public static object EXdGBDZQghhabFRu() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static List EhattzsFYGzTOVIU(p34c3b0bd r1) {
        return r1.getInventorizationPositions();
    }

    public static decimal FFhgGAuRGmZtMreB(pd031d465 r1) {
        return r1.getTareVolume();
    }

    public static object FcdANsigoLbSTBDa(IEnumerator r1) {
        return r1.Current;
    }

    public static int GeZjkbBKjilTwCOU(IEnumerable r1, int r2) {
        return ICollectionsKt.collectionSizeOrDefault(r1, r2);
    }

    public static List HHHSipZqVLtxtxnV(pcf388f6a r1, List r2) {
        return r1.m522885ad(r2);
    }

    public static Guid HMaHWbpCgUcmtqvV() {
        return Guid.randomGuid();
    }

    public static decimal HStrkYSSoDOXXqDK(p0ed7807b r1) {
        return r1.getTareVolume();
    }

    public static p0ed7807b HYQtEPNmOczCYrna(pcf388f6a r1, pd031d465 r2, string r3) {
        return r1.m649c04a1(r2, r3);
    }

    public static void HtuHLzyUTTvqJBln(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static decimal IdqVwBnljaAcDDPa(p0ed7807b r1) {
        return r1.getPrice();
    }

    public static void IvrdniJTDFndWMCS(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string JwjXuWqJAqHkmMvy(p0ed7807b r1) {
        return r1.getCommodityId();
    }

    public static string KVCuUHDQSkqgfoVg(pd031d465 r1) {
        return r1.getCommodityId();
    }

    public static p14abd389 KXOeIPEiHbOpTubM(p12e406c7 r1) {
        return r1.getStatus();
    }

    public static decimal KZmgkdZEIJidtVJJ(p0ed7807b r1) {
        return r1.getInitialQuantity();
    }

    public static object KpxXZjVdMkFWRAcP() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string LcdQlzjQxmXjbxxs(p0ed7807b r1) {
        return r1.getTax();
    }

    public static decimal LtkcwnGxRhRzmCAi(pf22d65ed r1) {
        return r1.getRateNumber();
    }

    private readonly p0690dac5 M1e887f72(p34c3b0bd r5) {
        if (((24 + 29) % 29) > 0) goto L27;
    L27:
        return new p0690dac5(TzzkukkNJqKVAATF(nbQEAgFMkGgoseOr(r5)), QTPyzapuOApDqput(YtfqRIzTEqdDuDoV(r5)), kXOeIPEiHbOpTubM(tbfBlSceZCCdiQMf(r5)), qKUmgwqFmEGxUfhq(this, ehattzsFYGzTOVIU(r5)));
    }

    private readonly List<pd031d465> M522885ad(List<p5e3e4f48> r23) {
        if (((3 + 9) % 9) > 0) goto L63;
    L63:
        List<p5e3e4f48> r0 = r23;
        List r1 = new List(geZjkbBKjilTwCOU(r0, 10));
        IEnumerator r02 = QbvYyvOtmOcxXSGf(r0);
    L20:
        if (bgFKqbiRhXQmSsAA(r02) == false) goto L17;
        p5e3e4f48 r2 = (p5e3e4f48) fcdANsigoLbSTBDa(r02);
        p0ed7807b r3 = sgmrcZRItwGzBrBF(r2);
        string r5 = SXBTKYzkChGwglOF(r3);
        decimal r6 = OIBdFxtNPEYReyWQ(r3);
        decimal r7 = rkafZaCLbIZHFDtw(r3);
        string r8 = WVrPbbUmQtCrozcm(r3);
        string r9 = RoZyCOOpJJNEPuAt(r3);
        int r10 = tdedFXBmyWWkLbJE(r3);
        decimal r11 = HZFUtDSgEdpAVdUP(zDzRvbUTESvQJDPg(r3));
        decimal r12 = YKoZyFEmLmfOtGou(kZmgkdZEIJidtVJJ(r3));
        string r13 = lcdQlzjQxmXjbxxs(r3);
        if (r13 is null) goto L68;
    L23:
        string r14 = jwjXuWqJAqHkmMvy(r3);
        pa1fa2777 r15 = ZhdnYyDxqyBNfDbG(r3);
        decimal r16 = hStrkYSSoDOXXqDK(r3);
        decimal r17 = aiIZyggRTRavbEMA(r3);
        pf22d65ed r22 = yLGofDYszZswgJhm(r2);
        if (r22 is not null) goto L5;
        decimal r24 = null;
    L61:
        EoRuKjxGlmJAbHCh(r1, new pd031d465(r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, mwuAcsUQYbVXVKWB(r24, idqVwBnljaAcDDPa(r3)), null, 16384, null));
        goto L20
    L5:
        r24 = ltkcwnGxRhRzmCAi(r22);
        goto L61
    L68:
        r13 = CDphUxmEgeXrtlfF("cff80c75df7d99e0d91d6810007b02202abbb616d67bda23cdfc910a77667a4db38f");
        goto L23
    L17:
        return r1;
    }

    private readonly p0ed7807b M649c04a1(pd031d465 r17, string r18) {
        if (((16 + 11) % 11) > 0) goto L6;
    L6:
        return new p0ed7807b(dVcEJSmnnXNgqnyc(r17), r18, "", PlEXGObTtoFGRcyh(r17), RbHSMUsngQFBDKgK(r17), tPFRfSrcumYDSOOT(r17), RkqCmFSwlHLLJRfv(r17), BOztvxwogYfsztBQ(r17), AiODvwgcUzBVieFW(r17), cHLFjaMTYgcmxpGM(r17), DUinXkdpazqJTrGM(r17), kVCuUHDQSkqgfoVg(r17), mCVvOhRaqtndFCXl(r17), fFhgGAuRGmZtMreB(r17), eHDOpSOGQitGGtWP(r17));
    }

    private readonly p12e406c7 M6df7a60a(string r3) {
        if (((18 + 6) % 6) > 0) goto L10;
    L10:
        string r0 = ZvhiQvqZeYCqaCJE(hMaHWbpCgUcmtqvV());
        BrcEJckkNFmGbJaQ(r0, "tostring(...)");
        return new p12e406c7(r0, r3, p14abd389.f66f73e50);
    }

    public static pa1fa2777 MCVvOhRaqtndFCXl(pd031d465 r1) {
        return r1.getType();
    }

    public static decimal MwuAcsUQYbVXVKWB(decimal r1, decimal r2) {
        return pdf45491e.m63dfbd1d(r1, r2);
    }

    public static p12e406c7 NbQEAgFMkGgoseOr(p34c3b0bd r1) {
        return r1.getInventorizationDbEntity();
    }

    public static object PSbZPQdtaBxpeCAJ(p226a374c r1, Continuation r2) {
        return r1.getCurrentInventorization(r2);
    }

    public static List QKUmgwqFmEGxUfhq(pcf388f6a r1, List r2) {
        return r1.m522885ad(r2);
    }

    public static decimal RkafZaCLbIZHFDtw(p0ed7807b r1) {
        return r1.getPurchasePrice();
    }

    public static object SJxiytOSXhLkfmCh() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p0ed7807b SgmrcZRItwGzBrBF(p5e3e4f48 r1) {
        return r1.getCurrentInventorizationPositionDbEntity();
    }

    public static string TPFRfSrcumYDSOOT(pd031d465 r1) {
        return r1.getName();
    }

    public static p12e406c7 TbfBlSceZCCdiQMf(p34c3b0bd r1) {
        return r1.getInventorizationDbEntity();
    }

    public static int TdedFXBmyWWkLbJE(p0ed7807b r1) {
        return r1.getPrecision();
    }

    public static object TjAounlZCeMpXRPN() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void TxppFvjKFoxoyNMI(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object UmZbiSxzakprZogU(p226a374c r1, Continuation r2) {
        return r1.clearCurrentInventorizationPositions(r2);
    }

    public static void WhSXrFEWHVEezllb(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string YHAWHMzUbPMoTZPI(p0690dac5 r1) {
        return r1.getUuid();
    }

    public static pf22d65ed YLGofDYszZswgJhm(p5e3e4f48 r1) {
        return r1.getTaxDbEntity();
    }

    public static decimal ZDzRvbUTESvQJDPg(p0ed7807b r1) {
        return r1.getQuantity();
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object AddPositionToCurrentInventorization(pd031d465 r6, Continuation<Unit> r7) {
        if (((18 + 22) % 22) > 0) goto L22;
    L22:
        if ((r7 is pcf388f6a$pa497b6f6$1) == false) goto L36;
        pcf388f6a$pa497b6f6$1 r0 = (pcf388f6a$pa497b6f6$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L36;
        r0.fd304ba20 -= int.MIN_VALUE;
    L28:
        object r72 = r0.fb4a88417;
        object r1 = cVbGlkrJwZPoUOhK();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L19;
        if (r2 == 1) goto L53;
        if (r2 != 2) goto L47;
        CnScoQCTDHwhzYKh(r72);
    L11:
        return Unit.INSTANCE;
    L47:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L53:
        r6 = (pd031d465) r0.L$2;
        pcf388f6a this = (pcf388f6a) r0.L$1;
        p226a374c r22 = (p226a374c) r0.L$0;
        WqfcelTMcOfNeSla(r72);
    L49:
        p0ed7807b r5 = NXOTSPMIVfTrIlxb(this, r6, QaXbhbWqblgVDGJM((p0690dac5) r72));
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        if (FJLOTAggRkTyZJAq(r22, r5, r0) != r1) goto L11;
    L94:
        return r1;
    L19:
        htuHLzyUTTvqJBln(r72);
        r22 = this.f9f708994;
        r0.L$0 = r22;
        r0.L$1 = this;
        r0.L$2 = r6;
        r0.fd304ba20 = 1;
        r72 = INSKcUlzIqfHvGls(this, r0);
        if (r72 == r1) goto L94;
    L36:
        r0 = new pcf388f6a$pa497b6f6$1(this, r7);
        goto L28
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object ClearCurrentInventorizationPositions(Continuation<Unit> r1) {
        object r0 = umZbiSxzakprZogU(this.f9f708994, r1);
        if (r0 != eXdGBDZQghhabFRu()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object ClearCurrentInventorizations(Continuation<Unit> r1) {
        object r0 = CbPIxxdhJyTLJGoP(this.f9f708994, r1);
        if (r0 != sJxiytOSXhLkfmCh()) goto L14;
        return r0;
    L14:
        return Unit.INSTANCE;
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object CreateCurrentInventorization(string r1, Continuation<Unit> r2) {
        p12e406c7 r12 = UlzaObeKzJBgmHTl(this, r1);
        object r0 = KnxkYiuUXfuTvznF(this.f9f708994, r12, r2);
        if (r0 != APuwvRrYuqHfHFTw()) goto L7;
        return r0;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object GetCurrentInventorization(Continuation<p0690dac5> r5) {
        if (((11 + 25) % 25) > 0) goto L30;
    L30:
        if ((r5 is pcf388f6a$pc3bd4f53$1) == false) goto L3;
        pcf388f6a$pc3bd4f53$1 r0 = (pcf388f6a$pc3bd4f53$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L3;
        r0.fd304ba20 -= int.MIN_VALUE;
    L5:
        object r52 = r0.fb4a88417;
        object r1 = tjAounlZCeMpXRPN();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L25;
        if (r2 == 1) goto L35;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L35:
        pcf388f6a this = (pcf388f6a) r0.L$0;
        txppFvjKFoxoyNMI(r52);
    L46:
        return HJcIAKbQLVOeAxje(this, (p34c3b0bd) r52);
    L25:
        UOltGPPdLiqAFpou(r52);
        p226a374c r53 = this.f9f708994;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r52 = pSbZPQdtaBxpeCAJ(r53, r0);
        if (r52 != r1) goto L46;
        return r1;
    L3:
        r0 = new pcf388f6a$pc3bd4f53$1(this, r5);
        goto L5
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object GetCurrentInventorizationPositions(Continuation<? super List<pd031d465>> r5) {
        if (((3 + 13) % 13) > 0) goto L53;
    L53:
        if ((r5 is pcf388f6a$pa0e175d9$1) == true) goto L12;
    L28:
        pcf388f6a$pa0e175d9$1 r0 = new pcf388f6a$pa0e175d9$1(this, r5);
    L57:
        object r52 = r0.fb4a88417;
        object r1 = TpisTXlOvRjlQEuh();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L48;
        whSXrFEWHVEezllb(r52);
        p226a374c r53 = this.f9f708994;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r52 = DwxqUMmARfZjHRbj(r53, r0);
        if (r52 != r1) goto L3;
        return r1;
    L3:
        return hHHSipZqVLtxtxnV(this, (List) r52);
    L48:
        if (r2 == 1) goto L58;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L58:
        pcf388f6a this = (pcf388f6a) r0.L$0;
        ivrdniJTDFndWMCS(r52);
        goto L3
    L12:
        r0 = (pcf388f6a$pa0e175d9$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L28;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L57
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object RemoveCurrentInventorizationPosition(string r1, Continuation<Unit> r2) {
        object r0 = AqoekpBykzWRXfnu(this.f9f708994, r1, r2);
        if (r0 != DafIZUyhJvCjIAyV()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object UpdateCurrentInventorizationPosition(pd031d465 r6, Continuation<Unit> r7) {
        if (((13 + 15) % 15) > 0) goto L87;
    L87:
        if ((r7 is pcf388f6a$pb72c561a$1) == true) goto L68;
    L72:
        pcf388f6a$pb72c561a$1 r0 = new pcf388f6a$pb72c561a$1(this, r7);
    L12:
        object r72 = r0.fb4a88417;
        object r1 = CGnOriwkdGmRAfKP();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L62;
        if (r2 == 1) goto L47;
        if (r2 != 2) goto L48;
        MDcAYTaEEdWpKkUD(r72);
    L42:
        return Unit.INSTANCE;
    L48:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L47:
        r6 = (pd031d465) r0.L$2;
        pcf388f6a this = (pcf388f6a) r0.L$1;
        p226a374c r22 = (p226a374c) r0.L$0;
        HtwIVcaORhpZhbuE(r72);
    L13:
        p0ed7807b r5 = hYQtEPNmOczCYrna(this, r6, yHAWHMzUbPMoTZPI((p0690dac5) r72));
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        if (IxHwqgDZHvFKWJVv(r22, r5, r0) != r1) goto L42;
    L50:
        return r1;
    L62:
        IQPFJuVfqeLDRmZY(r72);
        r22 = this.f9f708994;
        r0.L$0 = r22;
        r0.L$1 = this;
        r0.L$2 = r6;
        r0.fd304ba20 = 1;
        r72 = VTxnEYLfGIVffvgU(this, r0);
        if (r72 == r1) goto L50;
    L68:
        r0 = (pcf388f6a$pb72c561a$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L72;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L12
    }

    @Override // p10348936.pb3f20355.pf94220ad
    public object UpdateCurrentInventorizationStatus(p14abd389 r1, Continuation<Unit> r2) {
        object r0 = ZohscRWwKIOsxQfx(this.f9f708994, r1, r2);
        if (r0 != kpxXZjVdMkFWRAcP()) goto L6;
        return r0;
    L6:
        return Unit.INSTANCE;
    }
}

