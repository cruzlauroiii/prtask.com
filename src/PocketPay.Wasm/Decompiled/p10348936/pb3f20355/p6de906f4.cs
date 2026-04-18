using Com.Decryptstringmanager;
using Java.Math;
using Java.Sql;
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
public readonly class p6de906f4 : p42c3a015 {
    private readonly pba03ea40 f07071219;
    private readonly pba03ea40 f18931d69;
    private readonly pba03ea40 f6fbf82cb;
    private readonly pba03ea40 f9cfdfb4c;
    private readonly pba03ea40 fe6b4776f;

    public p6de906f4(pba03ea40 r2) {
        BendprJQXQAwtemr(r2, "inventorizationConsoleDbRepository");
        this.f6fbf82cb = r2;
    }

    public static decimal BGQpLGXgqJAGbFZg(pd031d465 r1) {
        return r1.getQuantity();
    }

    public static void BendprJQXQAwtemr(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static int BezvwofJWhNGyKBl(IEnumerable r1, int r2) {
        return ICollectionsKt.collectionSizeOrDefault(r1, r2);
    }

    public static int CJDBCFSgfdmNcdhe(IEnumerable r1, int r2) {
        return ICollectionsKt.collectionSizeOrDefault(r1, r2);
    }

    public static string CTKkuWCEuKCqmCOF(p555020e1 r1) {
        return r1.getUuid();
    }

    public static decimal CYSGKHdOhKnylENJ(decimal r1) {
        return p7667d148.m26e017cd(r1);
    }

    public static string EAwTxTDIcrXyhAyw(p555020e1 r1) {
        return r1.getMeasure();
    }

    public static decimal FLMCJhbSQPvtItCM(p555020e1 r1) {
        return r1.getPriceWithDiscount();
    }

    public static IEnumerator FWihalLUVlkmvpcP(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static bool FYInibNgKMMUKLSx(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static void GKSjImyEzaArLWFG(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static List GeYBChfEsrxCoJNG(p0690dac5 r1) {
        return r1.getPositions();
    }

    public static string HUeufUnMNxORgIeo(p4582d01f r1) {
        return r1.getEmployeeId();
    }

    public static List IPeolWNCQyvGeqTL(p649d38da r1) {
        return r1.getInventorizationPositions();
    }

    public static p4582d01f IVNDwocOxELjNRvI(p649d38da r1) {
        return r1.getInventorizationDbEntity();
    }

    public static string JarqvLIDBMAulnER(p555020e1 r1) {
        return r1.getTax();
    }

    public static List JurILZsPWVbmfbQV(p6de906f4 r1, List r2) {
        return r1.m3d94a5a7(r2);
    }

    public static string JxulkaLuZBZPEDCQ(p555020e1 r1) {
        return r1.getCommodityId();
    }

    public static object KGGsGvsCaEPatRdU(pba03ea40 r1, p4582d01f r2, List r3, Continuation r4) {
        return r1.saveInventorization(r2, r3, r4);
    }

    public static void KKqOvaJMfRcRwLAS(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void KOCZlftOMiKGBPZX(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string KuwqkNvNtFJwIhYX(pd031d465 r1) {
        return r1.getCommodityId();
    }

    public static decimal LnnlkrFntNpGqrAK(pd031d465 r1) {
        return r1.getPurchasePrice();
    }

    public static decimal MxzGtApPDCMCsZQP(decimal r1, decimal r2) {
        return pdf45491e.m63dfbd1d(r1, r2);
    }

    public static string NSoiUEWJRUQysViF(p555020e1 r1) {
        return r1.getName();
    }

    public static string ORZACYBjufDVTLVT(p0690dac5 r1) {
        return r1.getUuid();
    }

    public static object OjAoNjJHHuKXRjpt(p6de906f4 r1, p0690dac5 r2, Continuation r3) {
        return r1.m55c087ac(r2, r3);
    }

    public static decimal PCYUMIkBtvZyZJJX(pd031d465 r1) {
        return r1.getPrice();
    }

    public static p4582d01f PNcfhjstxhYvFOLh(p649d38da r1) {
        return r1.getInventorizationDbEntity();
    }

    public static string PxZSHFwocKGRyFsF(pd031d465 r1) {
        return r1.getTax();
    }

    public static int QsHyKODrqHJydwNL(pd031d465 r1) {
        return r1.getPrecision();
    }

    public static void RFapqBZsJJrrOLPa(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string RtRJONZGugtOLEek(p4582d01f r1) {
        return r1.getUuid();
    }

    public static int SFcSnkNnOfHrngMP(Number r1) {
        return r1.intValue();
    }

    public static decimal SUwJzfRCcoaSBIAK(pf22d65ed r1) {
        return r1.getRateNumber();
    }

    public static bool SdOZGNFzpNAzxvJd(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static bool TZDKMmVFQGPxQThB(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static p555020e1 UUepSxXJeOVkXLRV(p741b1ba9 r1) {
        return r1.getInventorizationPositionDbEntity();
    }

    public static IEnumerator VGlfvcuVWjEIemqe(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static decimal WYNprUCgnChqsKYj(decimal r1) {
        return p7667d148.m26e017cd(r1);
    }

    public static Timestamp WdcbexhNVUErhPiD(p4582d01f r1) {
        return r1.getDateTime();
    }

    public static decimal WsBVdadMcwknGpvX(p555020e1 r1) {
        return r1.getPrice();
    }

    public static bool YZvLcetZtumvHcOg(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static decimal YbGIASNpPfpUgxEc(p555020e1 r1) {
        return r1.getInitialQuantity();
    }

    public static object YoLcqQNAZTWtpJgX(p6de906f4 r1, p0690dac5 r2, Continuation r3) {
        return r1.m55c087ac(r2, r3);
    }

    public static int ZVdvrqeITwUVTEWg(p4582d01f r1) {
        return r1.getNumber();
    }

    public static string AHSuLBaTflZSapel(pd031d465 r1) {
        return r1.getName();
    }

    public static void ANBTPbkSOpWSXlYh(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pa1fa2777 AozGvXnvQZuTKklP(p555020e1 r1) {
        return r1.getType();
    }

    public static int AszFnlMfurqUyhzb(p555020e1 r1) {
        return r1.getPrecision();
    }

    public static List BLprOmFtrtYViHUI(p6de906f4 r1, List r2) {
        return r1.m522885ad(r2);
    }

    public static p14abd389 BQRxmgkpzlMwlwZQ(p0690dac5 r1) {
        return r1.getStatus();
    }

    public static object BSPSEmWsSZSsHrrQ(IEnumerator r1) {
        return r1.Current;
    }

    public static object CVQCIRLuvwpZfoSP() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string CWAAKPQkluxoCAbZ(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static IEnumerator DLfkcHFtNRfuQyye(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static decimal DQmYRNhdpKuJnGeJ(pd031d465 r1) {
        return r1.getTareVolume();
    }

    public static object DRZegvNVyjyeDWPZ(pba03ea40 r1, Continuation r2) {
        return r1.getLastInventorizationNumber(r2);
    }

    public static int DhShorHBlqWzInaB(IEnumerable r1, int r2) {
        return ICollectionsKt.collectionSizeOrDefault(r1, r2);
    }

    public static object ELyTaaAYJSgDgUBR(IEnumerator r1) {
        return r1.Current;
    }

    public static List FpllRkdezCXdotux(p6de906f4 r1, List r2, string r3) {
        return r1.m3b1c1f6e(r2, r3);
    }

    public static object GEGoymXRmBXcsdwr(pba03ea40 r1, Continuation r2) {
        return r1.getInventorizations(r2);
    }

    public static decimal GJiwASSXQfqnTRxi(p555020e1 r1) {
        return r1.getPurchasePrice();
    }

    public static string GjiiGoeaBNLdjlLZ(p0690dac5 r1) {
        return r1.getEmployeeId();
    }

    public static long HjpDXAoieyTxNIvx() {
        if (((21 + 25) % 25) > 0) goto L14;
    L14:
        return System.currentTimeMillis();
    }

    public static string JDSZABqnhufaqxPm(p649d38da r1) {
        return r1.getEmployeeName();
    }

    public static object JTgxzDFjXASpyXol() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static pa1fa2777 KqfZoKqfoLuDbPBI(pd031d465 r1) {
        return r1.getType();
    }

    public static p14abd389 LBlxRJCGUjDFiZjg(p4582d01f r1) {
        return r1.getStatus();
    }

    private readonly List<p555020e1> M3b1c1f6e(List<pd031d465> r20, string r21) {
        if (((16 + 6) % 6) > 0) goto L41;
    L41:
        List<pd031d465> r0 = r20;
        List r1 = new List(CJDBCFSgfdmNcdhe(r0, 10));
        IEnumerator r02 = dLfkcHFtNRfuQyye(r0);
    L22:
        if (YZvLcetZtumvHcOg(r02) == false) goto L18;
        pd031d465 r2 = (pd031d465) bSPSEmWsSZSsHrrQ(r02);
        SdOZGNFzpNAzxvJd(r1, new p555020e1(pwEFZFaOWdiklONb(r2), r21, "", PCYUMIkBtvZyZJJX(r2), LnnlkrFntNpGqrAK(r2), aHSuLBaTflZSapel(r2), sOwosOcRrtEEHlLs(r2), QsHyKODrqHJydwNL(r2), BGQpLGXgqJAGbFZg(r2), rxRxlDlcUzWTPlVv(r2), PxZSHFwocKGRyFsF(r2), KuwqkNvNtFJwIhYX(r2), kqfZoKqfoLuDbPBI(r2), dQmYRNhdpKuJnGeJ(r2), xGLqfqyKQBmwsmgX(r2)));
        goto L22
    L18:
        return r1;
    }

    private readonly List<p57eb274a> M3d94a5a7(List<p649d38da> r11) {
        if (((1 + 17) % 17) > 0) goto L43;
    L43:
        List<p649d38da> r112 = r11;
        List r0 = new List(BezvwofJWhNGyKBl(r112, 10));
        IEnumerator r113 = FWihalLUVlkmvpcP(r112);
    L47:
        if (FYInibNgKMMUKLSx(r113) == false) goto L22;
        p649d38da r1 = (p649d38da) sTHYLmptPNoEvAbD(r113);
        TZDKMmVFQGPxQThB(r0, new p57eb274a(RtRJONZGugtOLEek(pkxLwESZUQhRWEgE(r1)), ZVdvrqeITwUVTEWg(sMjlfDEhukRnJBjn(r1)), WdcbexhNVUErhPiD(IVNDwocOxELjNRvI(r1)), HUeufUnMNxORgIeo(nvFKFicieoXMnAts(r1)), jDSZABqnhufaqxPm(r1), lBlxRJCGUjDFiZjg(PNcfhjstxhYvFOLh(r1)), bLprOmFtrtYViHUI(this, IPeolWNCQyvGeqTL(r1))));
        goto L47
    L22:
        return r0;
    }

    private readonly List<pd031d465> M522885ad(List<p741b1ba9> r23) {
        if (((20 + 6) % 6) > 0) goto L59;
    L59:
        List<p741b1ba9> r0 = r23;
        List r1 = new List(dhShorHBlqWzInaB(r0, 10));
        IEnumerator r02 = VGlfvcuVWjEIemqe(r0);
    L14:
        if (sdgyBPoEzlIyVQxF(r02) == false) goto L36;
        p741b1ba9 r2 = (p741b1ba9) eLyTaaAYJSgDgUBR(r02);
        p555020e1 r3 = UUepSxXJeOVkXLRV(r2);
        string r5 = CTKkuWCEuKCqmCOF(r3);
        decimal r6 = WsBVdadMcwknGpvX(r3);
        decimal r7 = gJiwASSXQfqnTRxi(r3);
        string r8 = NSoiUEWJRUQysViF(r3);
        string r9 = EAwTxTDIcrXyhAyw(r3);
        int r10 = aszFnlMfurqUyhzb(r3);
        decimal r11 = WYNprUCgnChqsKYj(nJURuYRHzYlbhWWU(r3));
        decimal r12 = CYSGKHdOhKnylENJ(YbGIASNpPfpUgxEc(r3));
        string r13 = JarqvLIDBMAulnER(r3);
        if (r13 is null) goto L39;
    L27:
        string r14 = JxulkaLuZBZPEDCQ(r3);
        pa1fa2777 r15 = aozGvXnvQZuTKklP(r3);
        decimal r16 = vWQMMZpuFPqtRBEh(r3);
        decimal r17 = FLMCJhbSQPvtItCM(r3);
        pf22d65ed r22 = oeRTQYbTSPpSlZRi(r2);
        if (r22 is not null) goto L61;
        decimal r24 = null;
    L38:
        oLUdZLssjgXMVqxw(r1, new pd031d465(r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, MxzGtApPDCMCsZQP(r24, xCgkenPmsykyvEWc(r3)), null, 16384, null));
        goto L14
    L61:
        r24 = SUwJzfRCcoaSBIAK(r22);
        goto L38
    L39:
        r13 = cWAAKPQkluxoCAbZ("4162aa4922c6d586c5099a0e828016b53af90454f666c253e9524e97126688f52e83");
        goto L27
    L36:
        return r1;
    }

    private readonly object M55c087ac(p0690dac5 r11, Continuation<p4582d01f> r12) {
        if (((12 + 26) % 26) > 0) goto L9;
    L9:
        if ((r12 is p6de906f4$p55c087ac$1) == false) goto L19;
        p6de906f4$p55c087ac$1 r0 = (p6de906f4$p55c087ac$1) r12;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L19;
        r0.fd304ba20 -= int.MIN_VALUE;
    L46:
        object r122 = r0.fb4a88417;
        object r1 = cVQCIRLuvwpZfoSP();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L42;
        KKqOvaJMfRcRwLAS(r122);
        string r123 = wcoKhdRlTFlBZmgz(r11);
        pba03ea40 r10 = this.f6fbf82cb;
        r0.L$0 = r11;
        r0.L$1 = r123;
        r0.fd304ba20 = 1;
        object r102 = dRZegvNVyjyeDWPZ(r10, r0);
        if (r102 == r1) goto L4;
        string r5 = r123;
        r122 = r102;
    L65:
        return new p4582d01f(r5, SFcSnkNnOfHrngMP((Number) r122) + 1, vYEFgWpJfYMFYgiM(hjpDXAoieyTxNIvx()), gjiiGoeaBNLdjlLZ(r11), bQRxmgkpzlMwlwZQ(r11));
    L4:
        return r1;
    L42:
        if (r2 == 1) goto L26;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L26:
        string r103 = (string) r0.L$1;
        r11 = (p0690dac5) r0.L$0;
        xrDuHdrxvXKpooqM(r122);
        r5 = r103;
    L19:
        r0 = new p6de906f4$p55c087ac$1(this, r12);
        goto L46
    }

    public static readonly /* synthetic */ object mefc59b63(p6de906f4 r0, p0690dac5 r1, Continuation r2) {
        return YoLcqQNAZTWtpJgX(r0, r1, r2);
    }

    public static decimal NJURuYRHzYlbhWWU(p555020e1 r1) {
        return r1.getQuantity();
    }

    public static p4582d01f NvFKFicieoXMnAts(p649d38da r1) {
        return r1.getInventorizationDbEntity();
    }

    public static bool OLUdZLssjgXMVqxw(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static pf22d65ed OeRTQYbTSPpSlZRi(p741b1ba9 r1) {
        return r1.getTaxDbEntity();
    }

    public static p4582d01f PkxLwESZUQhRWEgE(p649d38da r1) {
        return r1.getInventorizationDbEntity();
    }

    public static void PosqJQnbNAimfnHk(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string PwEFZFaOWdiklONb(pd031d465 r1) {
        return r1.getUuid();
    }

    public static object RZDBmchXOzbxocMZ() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static decimal RxRxlDlcUzWTPlVv(pd031d465 r1) {
        return r1.getInitialQuantity();
    }

    public static p4582d01f SMjlfDEhukRnJBjn(p649d38da r1) {
        return r1.getInventorizationDbEntity();
    }

    public static string SOwosOcRrtEEHlLs(pd031d465 r1) {
        return r1.getMeasure();
    }

    public static object STHYLmptPNoEvAbD(IEnumerator r1) {
        return r1.Current;
    }

    public static bool SdgyBPoEzlIyVQxF(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static decimal VWQMMZpuFPqtRBEh(p555020e1 r1) {
        return r1.getTareVolume();
    }

    public static Timestamp VYEFgWpJfYMFYgiM(long r1) {
        return p728cd16b.m9e5b1846(r1);
    }

    public static string WcoKhdRlTFlBZmgz(p0690dac5 r1) {
        return r1.getUuid();
    }

    public static decimal XCgkenPmsykyvEWc(p555020e1 r1) {
        return r1.getPrice();
    }

    public static decimal XGLqfqyKQBmwsmgX(pd031d465 r1) {
        return r1.getPriceWithDiscount();
    }

    public static void XrDuHdrxvXKpooqM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    @Override // p10348936.pb3f20355.p42c3a015
    public object GetInventorizations(Continuation<? super List<p57eb274a>> r5) {
        if (((5 + 25) % 25) > 0) goto L59;
    L59:
        if ((r5 is p6de906f4$p49249b9e$1) == false) goto L25;
        p6de906f4$p49249b9e$1 r0 = (p6de906f4$p49249b9e$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L25;
        r0.fd304ba20 -= int.MIN_VALUE;
    L62:
        object r52 = r0.fb4a88417;
        object r1 = rZDBmchXOzbxocMZ();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L27;
        if (r2 == 1) goto L52;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L52:
        p6de906f4 this = (p6de906f4) r0.L$0;
        RFapqBZsJJrrOLPa(r52);
    L7:
        return JurILZsPWVbmfbQV(this, (List) r52);
    L27:
        GKSjImyEzaArLWFG(r52);
        pba03ea40 r53 = this.f6fbf82cb;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r52 = gEGoymXRmBXcsdwr(r53, r0);
        if (r52 != r1) goto L7;
        return r1;
    L25:
        r0 = new p6de906f4$p49249b9e$1(this, r5);
        goto L62
    }

    @Override // p10348936.pb3f20355.p42c3a015
    public object SaveInventorization(p0690dac5 r7, Continuation<Unit> r8) {
        if (((32 + 19) % 19) > 0) goto L54;
    L54:
        if ((r8 is p6de906f4$p3a2c4d23$1) == false) goto L43;
        p6de906f4$p3a2c4d23$1 r0 = (p6de906f4$p3a2c4d23$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L43;
        r0.fd304ba20 -= int.MIN_VALUE;
    L29:
        object r82 = r0.fb4a88417;
        object r1 = jTgxzDFjXASpyXol();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L47;
        posqJQnbNAimfnHk(r82);
        pba03ea40 r83 = this.f6fbf82cb;
        r0.L$0 = this;
        r0.L$1 = r7;
        r0.L$2 = r83;
        r0.fd304ba20 = 1;
        object r22 = OjAoNjJHHuKXRjpt(this, r7, r0);
        if (r22 != r1) goto L72;
    L21:
        return r1;
    L72:
        p6de906f4 r23 = this;
        pba03ea40 r6 = r83;
        r82 = r22;
    L7:
        p4582d01f r84 = (p4582d01f) r82;
        List r72 = fpllRkdezCXdotux(r23, GeYBChfEsrxCoJNG(r7), ORZACYBjufDVTLVT(r7));
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        if (KGGsGvsCaEPatRdU(r6, r84, r72, r0) == r1) goto L21;
    L89:
        return Unit.INSTANCE;
    L47:
        if (r2 == 1) goto L14;
        if (r2 != 2) goto L74;
        aNBTPbkSOpWSXlYh(r82);
        goto L89
    L74:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L14:
        r6 = (pba03ea40) r0.L$2;
        r7 = (p0690dac5) r0.L$1;
        r23 = (p6de906f4) r0.L$0;
        KOCZlftOMiKGBPZX(r82);
    L43:
        r0 = new p6de906f4$p3a2c4d23$1(this, r8);
        goto L29
    }
}

