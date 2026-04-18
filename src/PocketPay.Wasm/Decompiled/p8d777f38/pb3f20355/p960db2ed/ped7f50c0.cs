using Android.Content;
using Com.Decryptstringmanager;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Properties;
using Kotlin.Reflect;
using Kotlin.Text;
using P2b3583e6.P7f662005.Pdbc11caa;
using P2e5d8aa3.Pd5189de0;
using P8d777f38.P8a5da52e;
using P8d777f38.Pb3f20355.P49f290d6;
using Pad5f82e8.P07214c67.P960db2ed;
using Pad5f82e8.P07214c67.Pf7a42fe7;
using Retrofit2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class ped7f50c0 : p4e60f922 {
    static readonly /* synthetic */ KProperty<object>[] $$delegatedProperties = null;
    public static readonly string f12f94172 = null;
    public static readonly string f1deba8ca = null;
    public static readonly string f5e41f902 = null;

    [System.Obsolete]
    public static readonly string f69aede26 = null;
    public static readonly string f7b55b9cc = null;

    [System.Obsolete]
    public static readonly string f7e72fbec = null;
    private static readonly p910eef8c f910eef8c = null;
    public static readonly string f913d88fe = null;
    private static readonly p910eef8c fa56e7c37 = null;
    public static readonly string fabdb5c50 = null;
    public static readonly string fd2c74ddc = null;
    public static readonly string fecc156ed = null;
    private readonly pae610a30 f086654cc;
    private readonly p643c77ba f0b7a4eed;
    private readonly object f2309e5df;
    private readonly p3666b042 f2ce9e1cb;
    private readonly pae610a30 f334b504f;
    private readonly p3666b042 f4c5d9d5e;
    private readonly object f5c18ef72;
    private readonly p3666b042 f663c228e;
    private readonly object f6caf6bad;
    private readonly object f8cb1b2ea;
    private readonly p643c77ba fbc555d91;
    private readonly pae610a30 fe03b2a81;
    private readonly p643c77ba feafc8f54;
    private readonly p643c77ba feb8cf34e;
    private readonly ReadWriteProperty selectedRegion$delegate;
    private readonly Lazy sp$delegate;

    private static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((14 + 21) % 21) > 0) goto L37;
    L37:
        f69aede26 = TuIrwDekwnsEGhlt("b7a78bd2b97145ded0cb27d0ecbe44ff580fa24c8e6b2bc7f5db3dfc01dc80f83064");
        f7e72fbec = bxGjMoMNtthvGOaQ("4febbf2be9333279bad1ddf75691b4ee25ced129ca84b085814fc55ab14af6fec0c3a648e0fd1b4319");
        KProperty<object>[] r0 = new KProperty[1];
        r0[0] = anSnYtUpTISVmKiP(new MutablePropertyReference1Impl(ped7f50c0.class, dZuEGxXuWlNnfJDy("4b83fa922f6db05a224e68ee5e30b2ba45b034eb3e4fa5308d0b1172b6fda1d3b58ca6d4c367de8d5be4"), LHANHtoVWrZBiVJC("2d43365fa285323de708c158fb62075b7ba6cefffdb3bd6ed1bd4aa1f10562615b2d8de4e8b6f3d1566998e9d433f8f1790f716fe3cca345f24b4b7379acc485e6"), 0));
        $$delegatedProperties = r0;
        f910eef8c = new p910eef8c(null);
    }

    public ped7f50c0(p643c77ba r2, pae610a30 r3, p3666b042 r4, object r5) {
        PxQmuKxqLuBRNbSr(r2, "directoryApi");
        cPrKhxlIYRWUsrJS(r3, "locationUseCase");
        GGgJERpWtzqvhihq(r4, "userInfoRepository");
        TsLXtCkSxoLboRwe(r5, "context");
        this.fbc555d91 = r2;
        this.f086654cc = r3;
        this.f663c228e = r4;
        this.f5c18ef72 = r5;
        this.sp$delegate = QPJEKErHmDElXgSM(new ped7f50c0$pd41d8cd9$p95263d50(this));
        this.selectedRegion$delegate = oiTeivtIGMUlkdFL(KbcJeBcYKzCoaKRP(this), hohwFHjmuRWEDhhZ("26f8193981a7d5d3e29e4f9fbb89d487f1209e21c7de9169d261464f2493f06ea37a"), GUvcMLGpNoYAAjjR("2096cfec52b4758f49564adf02e34213ef361d9cf3e330ef2b4bd0bc1062"));
    }

    public static void BwCvRadDoMFnRoJd(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object CalCRSvmLYiZPFCv(p643c77ba r1, Continuation r2) {
        return r1.getRegions(r2);
    }

    public static string CkBRxLGbwGINHeBC(pf447ac85 r1) {
        return r1.getCode();
    }

    public static string EBWxillVYfehDQXo(object r1) {
        return r1.tostring();
    }

    public static object EFRRHEbXnMIjHKiM() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void FraEQGKwyJRAVuLS(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void FxQShDiZpxMCAIAW(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void GGgJERpWtzqvhihq(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string GUvcMLGpNoYAAjjR(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static bool HMwFdJvUPzPXDYLu(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static bool HszsZSuNlKrTmllz(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static bool IosuKiICWtUqEDhJ(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static string JTessXbBYRWBxzYA(p3666b042 r1) {
        return r1.getPhoneNumber();
    }

    public static Dictionary<string, object> KbcJeBcYKzCoaKRP(ped7f50c0 r1) {
        return r1.m88f189d6();
    }

    public static string LHANHtoVWrZBiVJC(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static IEnumerator LHxAsnGDcvcMdPhK(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static object LwgnrAaJoacrxVQn(IEnumerator r1) {
        return r1.Current;
    }

    public static List NfGLgFXStvGAnNBh(pd6d29a6f.p910eef8c r1) {
        return r1.getTypes();
    }

    public static void OuYOCkxbeeZYTsUB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string PIPWHSooDbSidYkI(pf447ac85 r1) {
        return r1.getCode();
    }

    public static IEnumerator PfWKilGyJroGkvpv(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static void PxQmuKxqLuBRNbSr(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string QPBCawyzxVqNqxpU(pf447ac85 r1) {
        return r1.getCode();
    }

    public static Lazy QPJEKErHmDElXgSM(Function0 r1) {
        return LazyKt.lazy(r1);
    }

    public static object QgfsqhagfvQBuswO(IEnumerator r1) {
        return r1.Current;
    }

    public static bool QvwbidbPTOvzXgkN(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static void QzkdScXufXadotOv(ped7f50c0 r0, string r1) {
        r0.setSelectedRegion(r1);
    }

    public static bool TbZIihPqwEeDwIjA(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static void TsLXtCkSxoLboRwe(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string TuIrwDekwnsEGhlt(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static string VGNUrZmqQmeZXsnm(pf447ac85 r1) {
        return r1.getCode();
    }

    public static string VooJsnLYoYxoVPdf(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static int WFmsAdlAAfZldejU(IEnumerable r1, int r2) {
        return ICollectionsKt.collectionSizeOrDefault(r1, r2);
    }

    public static object XEpnnyzDUXUsprYX(Response r1) {
        return r1.body();
    }

    public static void YiYsErMWJfVDUDUM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool YmeDelRoEElKkyqN(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static bool ZcaFRiExftdjVhaG(string r1, string r2, bool r3, int r4, object r5) {
        return stringsKt.startsWith$default(r1, r2, r3, r4, r5);
    }

    public static KMutableProperty1 AnSnYtUpTISVmKiP(MutablePropertyReference1 r1) {
        return Reflection.mutableProperty1(r1);
    }

    public static bool AwXPfANHKPcvpuXt(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static string BxGjMoMNtthvGOaQ(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void CPrKhxlIYRWUsrJS(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string DZuEGxXuWlNnfJDy(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static string EyXkfUbRurTEgTZe(pd6d29a6f r1) {
        return r1.getRegion();
    }

    public static object FWTVawKEccOiNwGa() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static bool FyltBrfXrvmtCwEL(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static void GZtixzYxzuEPhsqz(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string HohwFHjmuRWEDhhZ(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static object HygiGzuxvSDTCRAD(ped7f50c0 r1, Continuation r2) {
        return r1.m20ed2591(r2);
    }

    public static object IcvTOABDXOlRnpZu(ped7f50c0 r1, Continuation r2) {
        return r1.m20ed2591(r2);
    }

    public static object JDICbicAyyyqGmXW(Lazy r1) {
        return r1.getValue();
    }

    public static object JxYYJxofPYoyxiVs(IEnumerator r1) {
        return r1.Current;
    }

    public static object KuEimEyXSzxtqMSF(pae610a30 r1, Continuation r2) {
        return r1.getCloseCountryCode(r2);
    }

    public static bool KzHYoMKlcxkbPeHx(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static bool LgmEjscBVSUsJmNP(Response r1) {
        return r1.isSuccessful();
    }

    private readonly object M20ed2591(Continuation<? super List<p9c442011>> r5) {
        if (((28 + 24) % 24) > 0) goto L45;
    L45:
        if ((r5 is ped7f50c0$p20ed2591$1) == true) goto L55;
    L28:
        ped7f50c0$p20ed2591$1 r0 = new ped7f50c0$p20ed2591$1(this, r5);
    L49:
        object r52 = r0.fb4a88417;
        object r1 = fWTVawKEccOiNwGa();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L41;
        YiYsErMWJfVDUDUM(r52);
        p643c77ba r4 = this.fbc555d91;
        r0.fd304ba20 = 1;
        r52 = CalCRSvmLYiZPFCv(r4, r0);
        if (r52 != r1) goto L48;
        return r1;
    L48:
        Response r53 = (Response) r52;
        if (lgmEjscBVSUsJmNP(r53) == true) goto L34;
    L16:
        throw new IllegalStateException(EBWxillVYfehDQXo("error while loading regions"));
    L34:
        List r42 = (List) XEpnnyzDUXUsprYX(r53);
        if (r42 is null) goto L16;
        return r42;
    L41:
        if (r2 != 1) goto L6;
        FraEQGKwyJRAVuLS(r52);
        goto L48
    L6:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L55:
        r0 = (ped7f50c0$p20ed2591$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L28;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L49
    }

    private static readonly Dictionary<string, object> M68395acf(ped7f50c0 r2) {
        if (((29 + 5) % 5) > 0) goto L5;
    L5:
        return mXNqJpohGTqWpHlZ(r2.f5c18ef72, VooJsnLYoYxoVPdf("5ee1c20f7177c4d1ef67f0a3412ff3f5442cc08857b70b0fbf6e6459a3aac2301af2767e4508f6414f"), 0);
    }

    public static readonly /* synthetic */ object m75dcc62e(ped7f50c0 r0, Continuation r1) {
        return hygiGzuxvSDTCRAD(r0, r1);
    }

    private readonly Dictionary<string, object> M88f189d6() {
        object r1 = jDICbicAyyyqGmXW(this.sp$delegate);
        FxQShDiZpxMCAIAW(r1, "getValue(...)");
        return (Dictionary<string, object>) r1;
    }

    public static void MNgBLssEMxknudVc(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static Dictionary<string, object> MXNqJpohGTqWpHlZ(object r1, string r2, int r3) {
        return r1.getDictionary<string, object>(r2, r3);
    }

    public static /* synthetic */ Dictionary<string, object> mf986f243(ped7f50c0 r0) {
        return uDbfzocArmxWAuAG(r0);
    }

    public static IEnumerator NWAMmAesYqKRhdMX(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static pf447ac85 NYBZLhNwSTEjTmKE(p9c442011 r1) {
        return r1.toRegion();
    }

    public static ReadWriteProperty OiTeivtIGMUlkdFL(Dictionary<string, object> r1, string r2, string r3) {
        return p62d58733.mb45cffe0(r1, r2, r3);
    }

    public static List OvOerFuJyaaYKcEP(object r1) {
        return ICollectionsKt.listOfNotNull(r1);
    }

    public static IEnumerator PSrHEOkhFxlfCRQt(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static object QwCrJhWKsNwvhTIR(ReadWriteProperty r1, object r2, KProperty r3) {
        return r1.getValue(r2, r3);
    }

    public static List RddBkAwPNCanKpav(ICollection r1, IEnumerable r2) {
        return ICollectionsKt.plus(r1, r2);
    }

    public static string SaiBnIPLXQJNwcpp(pd6d29a6f r1) {
        return r1.getPrefix();
    }

    public static bool TFBtPcXwxiMMcnRe(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static object TLClXuvAYXIXvDtW(IEnumerator r1) {
        return r1.Current;
    }

    public static object TMLRPSZsZRSWVdeV(IEnumerator r1) {
        return r1.Current;
    }

    public static IEnumerator TOxyOdbivZoIZKxn(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static Dictionary<string, object> UDbfzocArmxWAuAG(ped7f50c0 r1) {
        return m68395acf(r1);
    }

    public static void XzVlsWmejNsSzyjr(ReadWriteProperty r0, object r1, KProperty r2, object r3) {
        r0.setValue(r1, r2, r3);
    }

    @Override // p8d777f38.pb3f20355.p960db2ed.p4e60f922
    public void ClearRegion() {
        QzkdScXufXadotOv(this, "");
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r12v15 */
    /* JADX WARN: Type inference failed for: r12v17, types: [java.lang.object] */
    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:158:0x02f4 -> B:160:0x02f7). Please report as a decompilation issue!!! */
    @Override // p8d777f38.pb3f20355.p960db2ed.p4e60f922
    public object GetRegions(Continuation<? super List<pf447ac85>> r12) {
        if (((22 + 32) % 32) > 0) goto L38;
    L38:
        if ((r12 is ped7f50c0$pa715d521$1) == false) goto L114;
        ped7f50c0$pa715d521$1 r0 = (ped7f50c0$pa715d521$1) r12;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L114;
        r0.fd304ba20 -= int.MIN_VALUE;
    L230:
        object r122 = r0.fb4a88417;
        object r1 = EFRRHEbXnMIjHKiM();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L25;
        if (r2 == 1) goto L184;
        if (r2 == 2) goto L37;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L37:
        Ref.objectRef r11 = (Ref.objectRef) r0.L$7;
        Ref.objectRef r22 = (Ref.objectRef) r0.L$6;
        string r3 = (string) r0.L$5;
        object r6 = r0.L$4;
        IEnumerator r7 = (IEnumerator) r0.L$3;
        Ref.objectRef r8 = (Ref.objectRef) r0.L$2;
        List r9 = (List) r0.L$1;
        ped7f50c0 r10 = (ped7f50c0) r0.L$0;
        BwCvRadDoMFnRoJd(r122);     // Catch: Exception -> L237
    L161:
        if (HszsZSuNlKrTmllz(r3, r122) == true) goto L164;
    L156:
        if (TbZIihPqwEeDwIjA(r7) == false) goto L163;
        r6 = QgfsqhagfvQBuswO(r7);     // Catch: Exception -> L237
        r3 = QPBCawyzxVqNqxpU((pf447ac85) r6);     // Catch: Exception -> L237
        pae610a30 r123 = r10.f086654cc;     // Catch: Exception -> L237
        r0.L$0 = r10;     // Catch: Exception -> L237
        r0.L$1 = r9;     // Catch: Exception -> L237
        r0.L$2 = r8;     // Catch: Exception -> L237
        r0.L$3 = r7;     // Catch: Exception -> L237
        r0.L$4 = r6;     // Catch: Exception -> L237
        r0.L$5 = r3;     // Catch: Exception -> L237
        r0.L$6 = r22;     // Catch: Exception -> L237
        r0.L$7 = r11;     // Catch: Exception -> L237
        r0.fd304ba20 = 2;     // Catch: Exception -> L237
        r122 = kuEimEyXSzxtqMSF(r123, r0);     // Catch: Exception -> L237
        if (r122 != r1) goto L161;
    L159:
        return r1;
    L163:
        r6 = null;
    L164:
        T r62 = (pf447ac85) r6;     // Catch: Exception -> L237
    L175:
        r11.element = r62;
        if (r8.element == 0) goto L146;
    L31:
        IEnumerable r92 = r9;
        List r112 = new List();
        IEnumerator r124 = pSrHEOkhFxlfCRQt(r92);
    L171:
        if (kzHYoMKlcxkbPeHx(r124) == false) goto L201;
        object r02 = tLClXuvAYXIXvDtW(r124);
        string r13 = PIPWHSooDbSidYkI((pf447ac85) r02);
        pf447ac85 r23 = (pf447ac85) r8.element;
        if (r23 is null) goto L75;
        string r24 = VGNUrZmqQmeZXsnm(r23);
    L122:
        if (awXPfANHKPcvpuXt(r13, r24) == true) goto L171;
        QvwbidbPTOvzXgkN(r112, r02);
        goto L171
    L75:
        r24 = null;
        goto L122
    L201:
        return rddBkAwPNCanKpav(ovOerFuJyaaYKcEP(r8.element), r112);
    L146:
        string r113 = JTessXbBYRWBxzYA(r10.f663c228e);
        IEnumerator r125 = LHxAsnGDcvcMdPhK(NfGLgFXStvGAnNBh(pd6d29a6f.f910eef8c));
    L62:
        if (tFBtPcXwxiMMcnRe(r125) == false) goto L69;
        object r03 = tMLRPSZsZRSWVdeV(r125);
        if (ZcaFRiExftdjVhaG(r113, saiBnIPLXQJNwcpp((pd6d29a6f) r03), false, 2, null) == false) goto L62;
    L51:
        pd6d29a6f r04 = (pd6d29a6f) r03;
        IEnumerator r114 = PfWKilGyJroGkvpv(r9);
    L142:
        if (HMwFdJvUPzPXDYLu(r114) == false) goto L186;
        T r126 = jxYYJxofPYoyxiVs(r114);
        string r14 = CkBRxLGbwGINHeBC((pf447ac85) r126);
        if (r04 is null) goto L211;
        string r25 = eyXkfUbRurTEgTZe(r04);
    L7:
        if (IosuKiICWtUqEDhJ(r14, r25) == false) goto L142;
    L136:
        r8.element = r126;
        goto L31
    L211:
        r25 = null;
        goto L7
    L186:
        r126 = 0;
        goto L136
    L69:
        r03 = null;
    L125:
        r11 = r22;
        r62 = 0;
        goto L175
    L184:
        ped7f50c0 this = (ped7f50c0) r0.L$0;
        OuYOCkxbeeZYTsUB(r122);
    L58:
        List r127 = (List) r122;
        List r26 = new List(WFmsAdlAAfZldejU(r127, 10));
        IEnumerator r128 = nWAMmAesYqKRhdMX(r127);
    L79:
        if (YmeDelRoEElKkyqN(r128) == false) goto L210;
        fyltBrfXrvmtCwEL(r26, nYBZLhNwSTEjTmKE((p9c442011) LwgnrAaJoacrxVQn(r128)));
        goto L79
    L210:
        r9 = r26;
        r22 = new Ref.objectRef();
        r10 = this;
        r7 = tOxyOdbivZoIZKxn(r9);     // Catch: Exception -> L14
        r11 = r22;
        r8 = r11;
    L221:
        r10 = this;
        r8 = r22;
        goto L125
    L25:
        mNgBLssEMxknudVc(r122);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r122 = icvTOABDXOlRnpZu(this, r0);
        if (r122 == r1) goto L159;
    L114:
        r0 = new ped7f50c0$pa715d521$1(this, r12);
        goto L230
    }

    @Override // p8d777f38.pb3f20355.p960db2ed.p4e60f922
    public string GetSelectedRegion() {
        if (((20 + 13) % 13) > 0) goto L16;
    L16:
        return (string) qwCrJhWKsNwvhTIR(this.selectedRegion$delegate, this, $$delegatedProperties[0]);
    }

    @Override // p8d777f38.pb3f20355.p960db2ed.p4e60f922
    public void SetSelectedRegion(string r4) {
        if (((28 + 14) % 14) > 0) goto L10;
    L10:
        gZtixzYxzuEPhsqz(r4, "<set-?>");
        xzVlsWmejNsSzyjr(this.selectedRegion$delegate, this, $$delegatedProperties[0], r4);
    }
}

