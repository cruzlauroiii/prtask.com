namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010 \n\u0002\b\u0005\b\u0007\u0018\u00002\u00020\u0001B\u0011\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u0016\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\t0\b2\u0006\u0010\n\u001a\u00020\tH\u0016J\u0016\u0010\u000b\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\t0\u000eH\u0002J\u0016\u0010\u000f\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\t0\u000eH\u0002J\u0016\u0010\u0010\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\t0\u000eH\u0002J\u0016\u0010\u0011\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\t0\u000eH\u0002J\u0016\u0010\u0012\u001a\u00020\f2\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\t0\u000eH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p20f46557/p0ff85bf0/p1cc2e207;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p20f46557/p0ff85bf0/p3b75118a;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "checkAccessibilityService", "Lio/reactivex/rxjava3/core/Completable;", "Lio/reactivex/rxjava3/core/Single;", "", "value", "checkAudible", "", "enabledAccessibilityFeedbackTypes", "", "checkHaptic", "checkSpoken", "checkVisual", "checkBraille", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1cc2e207 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p3b75118a {
    private readonly android.content.object f102b820d;
    private readonly android.content.object f5c18ef72;
    private readonly android.content.object f8d6419b5;
    private readonly android.content.object fb932a6df;

    @javax.inject.Inject
    public p1cc2e207(android.content.object context) {
        ZFKsytxUBDlkKohJ(context, "context");
        this.f5c18ef72 = context;
    }

    public static void CMdgQtaGfrHNpMaq(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        mdeab67ff(p1cc2e207Var, completableEmitter);
    }

    public static void CnVIiaKrRqwACaxV(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter, java.lang.Exception th) {
        completableEmitter.onError(th);
    }

    public static bool DlwYMyhnovlaUXOf(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.m197e6a09(list);
    }

    public static java.util.List DlxPsBRBmRPKpuOr(android.view.accessibility.AccessibilityManager accessibilityManager, int i) {
        return accessibilityManager.getEnabledAccessibilityServiceList(i);
    }

    public static void FdvxvhLmgmvJwpsj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static int FjLlDdMMEdqdIigh(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static java.lang.int HRSknwORKEFWwOmf(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HhwLmAFHgWappIzG(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, int i, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        mf1eaf444(p1cc2e207Var, i, singleEmitter);
    }

    public static java.lang.int KAWNjHPcwTDUzpkK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool KLmZvjwsCwMjmcaR(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static java.lang.string KQJOpKsIneckzNLQ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void KimSdzYODqyccyLv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(p37a01c41_p910eef8c, str, str2, str3, str4, str5);
    }

    public static java.lang.int LiJBTdlkWHlYFyfW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void LpeUhSHYbpIwkFLK(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, pa73d862bVar, i, obj);
    }

    public static void OBKJBzWLIuwfVFTt(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        completableEmitter.onComplete();
    }

    public static void QaBPROcwXVUjRoMh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static bool RKtsXszrMtESwBIH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static kotlin.random.Random RTJerPuUllOOTxZr(int i) {
        return kotlin.random.RandomKt.Random(i);
    }

    public static void RjXThTbmrfUOtbAB(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static java.lang.int RlUjgYCYRdZLtWdo(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void SRvtTltMTOJRVFwS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object SxsJAOfTWJnuCTjp(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator TYOPfBFjwueruLgu(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool UGdbQkrNuxClOVFQ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.m3b79063d(list);
    }

    public static bool VKlwrrLJcRyDFwEu(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.m197e6a09(list);
    }

    public static java.lang.int WMGtibYlIDGktsqF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.List XVGwziMAvKvZupzM(android.view.accessibility.AccessibilityManager accessibilityManager, int i) {
        return accessibilityManager.getEnabledAccessibilityServiceList(i);
    }

    public static bool YJIpyLnhLSQZfXcB(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.ma6c8278d(list);
    }

    public static bool YXbQqJFbFBvRftGq(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static void ZFKsytxUBDlkKohJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZRDesanQaKVzEHGK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.int BJnQcaZQmCdkxyGh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool BWJjOLjgTftuEFWf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void BYcWyMcESFZFmJzS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.lang.string CFFQZouGtvxgpjte(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258 pd4054258Var) {
        return pd4054258Var.getMessage();
    }

    public static io.reactivex.rxjava3.core.Single CXUDiejeLAjXGIcm(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(singleOnSubscribe);
    }

    public static void CcqnjRnKOPASUkQd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static bool FBHRpjgAbOQfwGOh(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static java.lang.object FKzLNPssxnWDnsrf(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static java.lang.int FkmshrDeyrGMJEah(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool GeEpBcYnkXVYbqjH(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.ma6c8278d(list);
    }

    public static void IiPUSoBEIyRSduce(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static bool JntryviLNVmvrPhQ(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static java.util.IEnumerator KlvbtZNpJfcOCXgh(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool LmmAhqOAqGwIGkJN(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.m5590bd45(list);
    }

    private readonly bool M197e6a09(java.util.List<java.lang.int> list) {
        return fBHRpjgAbOQfwGOh(list, LiJBTdlkWHlYFyfW(4));
    }

    public static void M26c58ccc(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        CMdgQtaGfrHNpMaq(p1cc2e207Var, completableEmitter);
    }

    private readonly bool M3b79063d(java.util.List<java.lang.int> list) {
        return YXbQqJFbFBvRftGq(list, KAWNjHPcwTDUzpkK(32));
    }

    private readonly bool M5590bd45(java.util.List<java.lang.int> list) {
        return jntryviLNVmvrPhQ(list, WMGtibYlIDGktsqF(8));
    }

    private readonly bool Ma6c8278d(java.util.List<java.lang.int> list) {
        return rSEgKyJEiYjkRusC(list, bJnQcaZQmCdkxyGh(2));
    }

    private readonly bool Ma7b8338d(java.util.List<java.lang.int> list) {
        return KLmZvjwsCwMjmcaR(list, murDjMowmKzTQWME(1));
    }

    public static void Mcb53b04a(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, int i, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        HhwLmAFHgWappIzG(p1cc2e207Var, i, singleEmitter);
    }

    private static readonly void Mdeab67ff(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        if ((16 + 6) % 6 > 0) {
        }
        SRvtTltMTOJRVFwS(completableEmitter, "emitter");
        java.lang.object objFKzLNPssxnWDnsrf = fKzLNPssxnWDnsrf(p1cc2e207Var.f5c18ef72, "accessibility");
        bYcWyMcESFZFmJzS(objFKzLNPssxnWDnsrf, "null cannot be cast to non-null type android.view.accessibility.AccessibilityManager");
        java.util.List listXVGwziMAvKvZupzM = XVGwziMAvKvZupzM((android.view.accessibility.AccessibilityManager) objFKzLNPssxnWDnsrf, -1);
        ccqnjRnKOPASUkQd(listXVGwziMAvKvZupzM, "getEnabledAccessibilityServiceList(...)");
        java.util.List list = listXVGwziMAvKvZupzM;
        java.util.List arrayList = new java.util.List(FjLlDdMMEdqdIigh(list, 10));
        java.util.IEnumerator itKlvbtZNpJfcOCXgh = klvbtZNpJfcOCXgh(list);
        while (bWJjOLjgTftuEFWf(itKlvbtZNpJfcOCXgh)) {
            tcnMAXQdylxDTmsS(arrayList, wloBJGTbIIertQhq(((android.accessibilityservice.AccessibilityServiceInfo) wafwBDWnhJQwLRCm(itKlvbtZNpJfcOCXgh)).feedbackType));
        }
        java.util.List arrayList2 = arrayList;
        if (!DlwYMyhnovlaUXOf(p1cc2e207Var, arrayList2) && !geEpBcYnkXVYbqjH(p1cc2e207Var, arrayList2) && !nERWDheumKdCmoBb(p1cc2e207Var, arrayList2) && !vUoGzuqgjQzKCyAJ(p1cc2e207Var, arrayList2) && !zCCUjnWcOLIPxTlS(p1cc2e207Var, arrayList2)) {
            KimSdzYODqyccyLv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "AccessibilityDetectorApiImpl", "checkAccessibilityService()", "56", KQJOpKsIneckzNLQ("fc8b07a747af484318bb1b07614b3e8a78a13631a7a87c58e6bfdf3d70e87e6cce8222"), "accessibility service not used");
            OBKJBzWLIuwfVFTt(completableEmitter);
        } else {
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258 pd4054258Var = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.paf0436dd.f814f94e9);
            LpeUhSHYbpIwkFLK(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "AccessibilityDetectorApiImpl", "checkAccessibilityService()", "47", null, cFFQZouGtvxgpjte(pd4054258Var), yzDfoxOBuHsAmuth(pd4054258Var), 8, null);
            CnVIiaKrRqwACaxV(completableEmitter, pd4054258Var);
        }
    }

    private static readonly void Mf1eaf444(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, int i, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        if ((6 + 26) % 26 > 0) {
        }
        ZRDesanQaKVzEHGK(singleEmitter, "emitter");
        java.lang.object objSvssKZtROGXyehIP = svssKZtROGXyehIP(p1cc2e207Var.f5c18ef72, "accessibility");
        iiPUSoBEIyRSduce(objSvssKZtROGXyehIP, "null cannot be cast to non-null type android.view.accessibility.AccessibilityManager");
        java.util.List listDlxPsBRBmRPKpuOr = DlxPsBRBmRPKpuOr((android.view.accessibility.AccessibilityManager) objSvssKZtROGXyehIP, -1);
        FdvxvhLmgmvJwpsj(listDlxPsBRBmRPKpuOr, "getEnabledAccessibilityServiceList(...)");
        java.util.List list = listDlxPsBRBmRPKpuOr;
        java.util.List arrayList = new java.util.List(naBfDGJEGSRNnKGf(list, 10));
        java.util.IEnumerator itTYOPfBFjwueruLgu = TYOPfBFjwueruLgu(list);
        while (RKtsXszrMtESwBIH(itTYOPfBFjwueruLgu)) {
            zSBeOSYHCJZnBzMW(arrayList, RlUjgYCYRdZLtWdo(((android.accessibilityservice.AccessibilityServiceInfo) SxsJAOfTWJnuCTjp(itTYOPfBFjwueruLgu)).feedbackType));
        }
        java.util.List arrayList2 = arrayList;
        if (VKlwrrLJcRyDFwEu(p1cc2e207Var, arrayList2) || YJIpyLnhLSQZfXcB(p1cc2e207Var, arrayList2) || nbAREzoABCaSXlsG(p1cc2e207Var, arrayList2) || lmmAhqOAqGwIGkJN(p1cc2e207Var, arrayList2) || UGdbQkrNuxClOVFQ(p1cc2e207Var, arrayList2)) {
            RjXThTbmrfUOtbAB(singleEmitter, fkmshrDeyrGMJEah(zDDKOYnsjHifgHuf(RTJerPuUllOOTxZr(i))));
        } else {
            sAZhcxZOUHfuleru(singleEmitter, HRSknwORKEFWwOmf(i));
        }
    }

    public static java.lang.int MurDjMowmKzTQWME(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool NERWDheumKdCmoBb(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.ma7b8338d(list);
    }

    public static int NaBfDGJEGSRNnKGf(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static bool NbAREzoABCaSXlsG(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.ma7b8338d(list);
    }

    public static void OjpEHAeHfUJuYGuW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static bool RSEgKyJEiYjkRusC(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static void SAZhcxZOUHfuleru(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static io.reactivex.rxjava3.core.Completable SFefNqUGFqGYDfdu(io.reactivex.rxjava3.core.CompletableOnSubscribe completableOnSubscribe) {
        return io.reactivex.rxjava3.core.Completable.m76ea0beb(completableOnSubscribe);
    }

    public static java.lang.object SvssKZtROGXyehIP(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static bool TcnMAXQdylxDTmsS(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool VUoGzuqgjQzKCyAJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.m5590bd45(list);
    }

    public static java.lang.object WafwBDWnhJQwLRCm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.int WloBJGTbIIertQhq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b YzDfoxOBuHsAmuth(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258 pd4054258Var) {
        return pd4054258Var.getCode();
    }

    public static bool ZCCUjnWcOLIPxTlS(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207 p1cc2e207Var, java.util.List list) {
        return p1cc2e207Var.m3b79063d(list);
    }

    public static int ZDDKOYnsjHifgHuf(kotlin.random.Random random) {
        return random.nextInt();
    }

    public static bool ZSBeOSYHCJZnBzMW(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public override io.reactivex.rxjava3.core.Completable CheckAccessibilityService() {
        io.reactivex.rxjava3.core.Completable completableSFefNqUGFqGYDfdu = sFefNqUGFqGYDfdu(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207$pd41d8cd9$pcca4ef0e(this));
        QaBPROcwXVUjRoMh(completableSFefNqUGFqGYDfdu, "create(...)");
        return completableSFefNqUGFqGYDfdu;
    }

    public override io.reactivex.rxjava3.core.Single<java.lang.int> CheckAccessibilityService(int value) {
        io.reactivex.rxjava3.core.Single<java.lang.int> singleCXUDiejeLAjXGIcm = cXUDiejeLAjXGIcm(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p0ff85bf0.p1cc2e207$pd41d8cd9$p95263d50(this, value));
        ojpEHAeHfUJuYGuW(singleCXUDiejeLAjXGIcm, "create(...)");
        return singleCXUDiejeLAjXGIcm;
    }
}

