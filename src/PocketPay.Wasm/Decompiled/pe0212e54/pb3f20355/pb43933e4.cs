using Java.Sql;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using P2e5d8aa3.Pf83c2a85.Pb3f20355;
using P582ca3f7.Pb3f20355;
using P8d777f38.Pb3f20355.P49f290d6;
using Pad5f82e8.P07214c67.P49f290d6;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.P07214c67.Pfa547353;
using Pe0212e54.P4b9f83e1;
using Pe0212e54.P8a5da52e;
using Pe0212e54.Pf5e638cc.P99e9bae6;
using Pe0212e54.Pf5e638cc.Pcf1e8c14;
using Pe0212e54.Pf5e638cc.Pd77d5e50;
using Retrofit2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class pb43933e4 : p44cd4abe {
    private readonly p0c2c0436 f015bbeba;
    private readonly pdba8e92c f11f2915a;
    private readonly p0c2c0436 f2076f1f4;
    private bool f20879484;
    private readonly List f34a56f7d;
    private readonly p3666b042 f4825b140;
    private readonly p3666b042 f5c8d3dd5;
    private bool f62d23005;
    private readonly p3666b042 f663c228e;
    private readonly pc60ad0d1 f7a3012f9;
    private readonly pdba8e92c f84d2a085;
    private readonly List<string> f8ae51f80;
    private readonly pfeb9ca41 f94d15e92;
    private p34dfc252 fb3dc37a9;
    private readonly pfeb9ca41 fb5be92e3;
    private p34dfc252 fbbd4156e;
    private readonly pc60ad0d1 fd1989962;
    private p34dfc252 fd273c5af;
    private readonly p0c2c0436 fdc359f07;
    private bool fe927e9da;
    private readonly p0c2c0436 fedc5f59e;
    private bool ff0c2a22a;
    private readonly pfeb9ca41 ff2732c44;
    private readonly pdba8e92c ff3429325;
    private readonly pfeb9ca41 ffa781974;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((15 + 5) % 5) > 0) goto L6;
        L6:
            int[] r0 = new int[ZQftrbJmgtySwjEN().length];
            r0[erFIchTrlKXQPHWN(p3dfe3c80.f124f7132)] = 1;     // Catch: NoSuchFieldError -> L25
        L16:
            $EnumSwitchDictionaryping$0 = r0;
        }

        public static p3dfe3c80[] ZQftrbJmgtySwjEN() {
            return p3dfe3c80.Values;
        }

        public static int ErFIchTrlKXQPHWN(p3dfe3c80 r1) {
            return r1.ordinal();
        }
    }

    public pb43933e4(pdba8e92c r8, p3666b042 r9, p0c2c0436 r10, pfeb9ca41 r11, pc60ad0d1 r12) {
        if (((2 + 32) % 32) > 0) goto L26;
    L26:
        CMDDKuPHryLssOQX(r8, "devicesApi");
        sDAzMKzAKsZWGKBZ(r9, "userInfoRepository");
        dYCeAKQxfHdfVeLq(r10, "employeesRepository");
        XJyQAJMuTuDKNJNu(r11, "devicesDbRepository");
        HrcTrZBaJgefHiqa(r12, "paymentHashSettingsRepository");
        this.f84d2a085 = r8;
        this.f663c228e = r9;
        this.fedc5f59e = r10;
        this.ffa781974 = r11;
        this.f7a3012f9 = r12;
        this.f20879484 = true;
        this.f8ae51f80 = new List();
        this.fb3dc37a9 = new p34dfc252(0, 0, 0, null, 15, null);
    }

    public static string AQXKoShCdtOqazSs(p6285e3eb r1) {
        return r1.getDeviceId();
    }

    public static object AvLqSJChcBHnBAdC() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static bool BIBJXTtKEMpEQKdU(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static object BOexFVAaJCBtSwtR(pb43933e4 r1, List r2, List r3, Continuation r4) {
        return r1.mbc3f1df3(r2, r3, r4);
    }

    public static string BavGttmFBpSdZXMX(p6285e3eb r1) {
        return r1.getDeviceId();
    }

    public static void CMDDKuPHryLssOQX(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object CkAJIadyogpdCnBc(pfeb9ca41 r1, Continuation r2) {
        return r1.getRemoteDevices(r2);
    }

    public static object CqcztqowEAUbVoBl() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p3dfe3c80 CsygFBhYOLnbZNms(p3666b042 r1) {
        return r1.getUserRoleType();
    }

    public static void DGSxLQudNKmEBixp(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool DSPrUYxaggJzhSNS(p13fc8880 r1) {
        return r1.getRemoteControlAvailable();
    }

    public static p3dfe3c80 DUMiYmRAVgJegaUf(p3666b042 r1) {
        return r1.getUserRoleType();
    }

    public static void EOwWulcjnSbXYhyQ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void GWnIqkLrIkNdDfSy(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void GXvkxTnjfngRMcMM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool GgtQgwKOAlbLuiwx(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static object GuznysfdCFsuJoHT(pfeb9ca41 r1, string r2, Continuation r3) {
        return r1.getDeviceIdByUuid(r2, r3);
    }

    public static object HEtjAhCuGoaIHMxA(pfeb9ca41 r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static object HacGmAueieHtZWsF(pfeb9ca41 r1, Continuation r2) {
        return r1.clearShops(r2);
    }

    public static List HfndbMjUzgNrmmnZ() {
        return ICollectionsKt.emptyList();
    }

    public static void HpikKnAJNyZfwUVo(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object HqiRRqKtLqZjXxXZ(Response r1) {
        return r1.body();
    }

    public static void HrcTrZBaJgefHiqa(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static List HxReEOmhkEhJMaZm(List r1) {
        return pcd945773.m8d17ca23(r1);
    }

    public static void IjhGGlfAmrrIdouP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static long IsnNtWqBTnQtRRYY(p13fc8880 r1) {
        return r1.getWarrantyExpirationDateTime();
    }

    public static bool JhYoWuHysCHgXfVA(bool r1) {
        return Boxing.boxbool(r1);
    }

    public static void JugoetRZWnIIpRpl(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string KHxECBXTnSNstXGv(p13fc8880 r1) {
        return r1.getId();
    }

    public static void KXVwTDdXusdFzYJy(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static long LbLDFMyuDPWummaB(p13fc8880 r1) {
        return r1.getLastOnlineDateTime();
    }

    public static string LhgFQbOmqimKmuSU(p3dfe3c80 r1) {
        return r1.name();
    }

    public static string LtlazIejmCeCWEan(p3666b042 r1) {
        return r1.getUserId();
    }

    public static string MHPNhZcPwaPOKOvI(p13fc8880 r1) {
        return r1.getDeviceId();
    }

    public static object NgvieqfYzqpUmmsm(p0c2c0436 r1, Continuation r2) {
        return r1.getSelectedEmployee(r2);
    }

    public static bool NqdNMYNhvXqwxHJw(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static bool OIFPhqbRDgKGOsUr(List r1, object r2) {
        return r1.Contains(r2);
    }

    public static List OVPSvHDwPsKEuyPy(List r1) {
        return pcd945773.me4fddbbd(r1);
    }

    public static string OWvbqjyBLeYRmJcl(p13fc8880 r1) {
        return r1.getShopId();
    }

    public static string OtQRonsDBVcojqzZ(pf8c8b903 r1) {
        return r1.getId();
    }

    public static object OwcCrKfqHjJstMbH(p0c2c0436 r1, Continuation r2) {
        return r1.getSelectedEmployee(r2);
    }

    public static string PYWcYhItGvjSWyAK(pf8c8b903 r1) {
        return r1.getId();
    }

    public static object PirdHajcgYVZUjmQ(Response r1) {
        return r1.body();
    }

    public static stringBuilder PoWRhFvZRzqxXSty(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static string QXEpklNIFgLCjrPD(p170c9f21 r1) {
        return r1.getId();
    }

    public static object QeTVvByNftCZuhjS(pfeb9ca41 r1, string r2, Continuation r3) {
        return r1.selectDevice(r2, r3);
    }

    public static List QhzYoXNoijWazWaV(List r1) {
        return pcd945773.m92cb54cc(r1);
    }

    public static object QrrSAeologXSCfVp(pdba8e92c r1, string r2, Continuation r3) {
        return r1.getDevices(r2, r3);
    }

    public static string QzfUpHlTlTDywwaX(p13fc8880 r1) {
        return r1.getName();
    }

    public static void QzySVxqAecDZIwlP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object RHfYudVvVbVCaLcw(IEnumerator r1) {
        return r1.Current;
    }

    public static string SELdBaHPqSQlvsqe(object r1) {
        return r1.tostring();
    }

    public static long SEzabDyHqSEmgsow(Number r2) {
        if (((17 + 29) % 29) > 0) goto L9;
    L9:
        return r2.longValue();
    }

    public static long SfuqxndBzAunMZSE(Number r2) {
        if (((11 + 2) % 2) > 0) goto L4;
    L4:
        return r2.longValue();
    }

    public static List SjIAdIHfYspePetL(List r1) {
        return pcd945773.m92cb54cc(r1);
    }

    public static object SrUmdPiFnNRFAeWj() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string SsjZwjlhdZsmmbJY(p3dfe3c80 r1) {
        return r1.name();
    }

    public static void SwAFqHzcyQWnTdso(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object THhnOUtKsrxRbcoO(pdba8e92c r1, string r2, string r3, Continuation r4) {
        return r1.getStores(r2, r3, r4);
    }

    public static bool TYJuUAfgvNSjbZtZ(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static object TjysIXfPdOrsvhey() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void TngGpJZLNckVFSKi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string UKZoMVcDdCxIpbtH(p13fc8880 r1) {
        return r1.getSerialNumber();
    }

    public static int UNVmZYIxPPVdAoSW(p3dfe3c80 r1) {
        return r1.ordinal();
    }

    public static object UPTvsfkOFZwlkQRO(pfeb9ca41 r1, string r2, Continuation r3) {
        return r1.removeDevice(r2, r3);
    }

    public static object UWZzAidiYJhHFLMk() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string UfCDcAbtltMIyBOW(p6285e3eb r1) {
        return r1.getDeviceId();
    }

    public static stringBuilder UmLRMEBohRoiGjaA(stringBuilder r1, bool r2) {
        return r1.append(r2);
    }

    public static string VTYHLCUbxuATEmEL(p170c9f21 r1) {
        return r1.getName();
    }

    public static bool VZDkTmdTawYUkJFT(Response r1) {
        return r1.isSuccessful();
    }

    public static bool VdcCguThUswNBxjW(List r1, object r2) {
        return r1.Contains(r2);
    }

    public static object VeuvWIimtiuYMOYh(pfeb9ca41 r1, List r2, Continuation r3) {
        return r1.updateRemoteDevices(r2, r3);
    }

    public static stringBuilder VqdxwATqlPXQMBQL(stringBuilder r1, bool r2) {
        return r1.append(r2);
    }

    public static string WFeWFLVgjFyaFUqP(p13fc8880 r1) {
        return r1.getDeviceId();
    }

    public static string WOsYhakxkgUcSSGV(p170c9f21 r1) {
        return r1.getId();
    }

    public static bool WtHDtjouqTnNfDKq(List r1, object r2) {
        return r1.Add(r2);
    }

    public static void XJyQAJMuTuDKNJNu(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object XQLnAtsrahmXiXIz(pb43933e4 r1, List r2, List r3, Continuation r4) {
        return r1.mbc3f1df3(r2, r3, r4);
    }

    public static bool XhTDzIFvLecjyuBG(List r1, object r2) {
        return r1.Add(r2);
    }

    public static object XhvUzoTklzSIePpW(Response r1) {
        return r1.body();
    }

    public static void XlIEooUaXgAqeXJF(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static List YQEaFFSUvBpWgnGd() {
        return ICollectionsKt.emptyList();
    }

    public static bool YfCoURXXLmfBIhSD(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static IEnumerator YkjktThRortyCAmy(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static string ZTKqxwlVJDYJGpAe(p6285e3eb r1) {
        return r1.getUserId();
    }

    public static bool ZoHLujduiNdMAEVx(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static int ASGbOxWccVzPXbzX(p3dfe3c80 r1) {
        return r1.ordinal();
    }

    public static void BgSkbgNhhdlOHxJi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string CZdfTvlRVDtQxSoC(p13fc8880 r1) {
        return r1.getDeviceId();
    }

    public static string CghDYtqNeAOoCEKB(p6285e3eb r1) {
        return r1.getToken();
    }

    public static object CpUQiewvUGwymSLD(IEnumerator r1) {
        return r1.Current;
    }

    public static object CyfhWZjASDdHlxQz(IEnumerator r1) {
        return r1.Current;
    }

    public static void DYCeAKQxfHdfVeLq(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object DksjluFniZukMubB(pfeb9ca41 r1, Continuation r2) {
        return r1.getRemoteDevices(r2);
    }

    public static string EGjzAPtNDFXiDetr(p170c9f21 r1) {
        return r1.getId();
    }

    public static object ELLUANrkUHtpgzSb() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static List ESYtKIABsLjKLmKb() {
        return ICollectionsKt.emptyList();
    }

    public static object ErihVZwdASipzAkS(pfeb9ca41 r1, List r2, Continuation r3) {
        return r1.updateShops(r2, r3);
    }

    public static void FFBNYaihlXtWznpS(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string FkePsokuHdKCyEfa(p170c9f21 r1) {
        return r1.getAddress();
    }

    public static object GHDLGHBmpXQEzHPj() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static List HNzrNHhnzxDhiouO(IEnumerable r1, Comparator r2) {
        return ICollectionsKt.sortedWith(r1, r2);
    }

    public static void HUKdObXjpkpCjewe(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static bool HcSHmrzKGWBjNnaB(Response r1) {
        return r1.isSuccessful();
    }

    public static object JNmzQceSeEjnQaiG(pc60ad0d1 r1, Continuation r2) {
        return r1.getRemoteDevicesPaymentHashSettingsDictionary(r2);
    }

    public static long JShYOZQSkXwdZggm(Number r2) {
        if (((15 + 6) % 6) > 0) goto L10;
    L10:
        return r2.longValue();
    }

    public static string JrRUAXXSBYagnsoR(p13fc8880 r1) {
        return r1.getShopId();
    }

    public static void KFUNAbBuudGzNDev(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object KGzTMuZGNNetuBxt() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void KftXAHjoFdDFsIEt(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool KuCgivEDKqgyzesa(Response r1) {
        return r1.isSuccessful();
    }

    public static void LBGbjxNrlKANJGCy(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string LEkOUIfnhIfphtSI(object r1) {
        return r1.tostring();
    }

    public static object LgUyMxgpjrqYkVdE(IEnumerator r1) {
        return r1.Current;
    }

    public static bool LvtPqMKFEzZOEaXE(Response r1) {
        return r1.isSuccessful();
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:182:0x0344 -> B:141:0x0277). Please report as a decompilation issue!!! */
    private readonly object Mbc3f1df3(List<p170c9f21> r33, List<p13fc8880> r34, Continuation<Unit> r35) {
        if (((24 + 22) % 22) > 0) goto L114;
    L114:
        pb43933e4 r0 = this;
        if ((r35 is pb43933e4$pbc3f1df3$1) == true) goto L253;
    L61:
        pb43933e4$pbc3f1df3$1 r2 = new pb43933e4$pbc3f1df3$1(r0, r35);
    L77:
        object r1 = r2.fb4a88417;
        object r3 = UWZzAidiYJhHFLMk();
        int r4 = r2.fd304ba20;
        int r6 = 3;
        if (r4 == 0) goto L366;
        if (r4 == 1) goto L348;
        if (r4 == 2) goto L185;
        if (r4 == 3) goto L236;
        if (r4 != 4) goto L143;
        bgSkbgNhhdlOHxJi(r1);
    L165:
        return Unit.INSTANCE;
    L143:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L236:
        p13fc8880 r02 = (p13fc8880) r2.L$6;
        IEnumerator r42 = (IEnumerator) r2.L$5;
        List r7 = (List) r2.L$4;
        Dictionary r8 = (Dictionary) r2.L$3;
        p6285e3eb r10 = (p6285e3eb) r2.L$2;
        List<p170c9f21> r11 = (List) r2.L$1;
        pb43933e4 r12 = (pb43933e4) r2.L$0;
        JugoetRZWnIIpRpl(r1);
    L362:
        List r27 = (List) r1;
        string r13 = KHxECBXTnSNstXGv(r02);
        if (r13 is not null) goto L332;
        string r15 = "";
    L343:
        string r14 = cZdfTvlRVDtQxSoC(r02);
        if (r14 is null) goto L251;
        string r142 = r14;
    L318:
        string r20 = QzfUpHlTlTDywwaX(r02);
        string r22 = UKZoMVcDdCxIpbtH(r02);
        p9d21d731 r21 = mzEFsMmmEVWrENdC(r02);
        long r16 = LbLDFMyuDPWummaB(r02);
        if (r16 is not null) goto L331;
        Timestamp r23 = null;
    L188:
        long r17 = rJGEpSbUxhMPueey(r02);
        if (r17 is not null) goto L223;
        Timestamp r24 = null;
    L273:
        long r18 = IsnNtWqBTnQtRRYY(r02);
        if (r18 is not null) goto L298;
        Timestamp r25 = null;
    L75:
        bool r26 = DSPrUYxaggJzhSNS(r02);
        List<p170c9f21> r19 = r11;
        IEnumerator r5 = ouCevkAtcDOkcZKo(r19);
    L260:
        if (YfCoURXXLmfBIhSD(r5) == false) goto L341;
        object r62 = cpUQiewvUGwymSLD(r5);
        if (NqdNMYNhvXqwxHJw(QXEpklNIFgLCjrPD((p170c9f21) r62), jrRUAXXSBYagnsoR(r02)) == false) goto L260;
    L277:
        p170c9f21 r63 = (p170c9f21) r62;
        if (r63 is not null) goto L131;
        string r172 = null;
    L287:
        IEnumerator r52 = vRxmIRwkfxcLhQpb(r19);
    L213:
        if (pnAtinWyHiwtiCOG(r52) == false) goto L157;
        object r64 = RHfYudVvVbVCaLcw(r52);
        if (toNVLmfSLQZxTbeA(WOsYhakxkgUcSSGV((p170c9f21) r64), OWvbqjyBLeYRmJcl(r02)) == false) goto L213;
    L245:
        p170c9f21 r65 = (p170c9f21) r64;
        if (r65 is not null) goto L239;
        string r182 = null;
    L278:
        IEnumerator r110 = YkjktThRortyCAmy(r19);
    L281:
        if (GgtQgwKOAlbLuiwx(r110) == false) goto L38;
        object r53 = lgUyMxgpjrqYkVdE(r110);
        if (BIBJXTtKEMpEQKdU(tWhTnwfvvNbOybGn((p170c9f21) r53), syDyAQvKxlcigmcO(r02)) == false) goto L281;
    L323:
        p170c9f21 r54 = (p170c9f21) r53;
        if (r54 is not null) goto L401;
        string r192 = null;
    L55:
        if (r10 is null) goto L59;
        string r111 = BavGttmFBpSdZXMX(r10);
    L10:
        if (ZoHLujduiNdMAEVx(r111, sKhLGpfiLEmYGCfO(r02)) == false) goto L381;
        if (r10 is null) goto L381;
        string r162 = ZTKqxwlVJDYJGpAe(r10);
    L398:
        if (r10 is not null) goto L130;
        string r112 = null;
    L84:
        if (oTOikAnbdWwykrfV(r112, WFeWFLVgjFyaFUqP(r02)) == true) goto L13;
    L293:
        string r28 = null;
    L233:
        p854660d3 r29 = p854660d3.f62f728a9;
        if (r10 is not null) goto L43;
        string r113 = null;
    L40:
        WtHDtjouqTnNfDKq(r7, new p6285e3eb(r142, r15, r162, r172, r182, r192, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, JhYoWuHysCHgXfVA(TYJuUAfgvNSjbZtZ(MHPNhZcPwaPOKOvI(r02), r113))));
        r6 = 3;
    L295:
        if (sAiRNcoEcIyBlsfG(r42) == true) goto L374;
        pfeb9ca41 r03 = r12.ffa781974;
        r2.L$0 = null;
        r2.L$1 = null;
        r2.L$2 = null;
        r2.L$3 = null;
        r2.L$4 = null;
        r2.L$5 = null;
        r2.L$6 = null;
        r2.fd304ba20 = 4;
        if (VeuvWIimtiuYMOYh(r03, r7, r2) != r3) goto L165;
    L309:
        return r3;
    L374:
        r02 = (p13fc8880) cyfhWZjASDdHlxQz(r42);
        pc60ad0d1 r114 = r12.f7a3012f9;
        List r132 = (List) vLjGrgAqCKvmXeKo(r8, wUEGDPRiJFVpEAMs(r02));
        r2.L$0 = r12;
        r2.L$1 = r11;
        r2.L$2 = r10;
        r2.L$3 = r8;
        r2.L$4 = r7;
        r2.L$5 = r42;
        r2.L$6 = r02;
        r2.fd304ba20 = r6;
        r1 = ntPyVTIlwhCNQhzh(r114, r132, r2);
        if (r1 == r3) goto L309;
    L43:
        r113 = AQXKoShCdtOqazSs(r10);
        goto L40
    L13:
        if (r10 is null) goto L293;
        r28 = cghDYtqNeAOoCEKB(r10);
        goto L233
    L130:
        r112 = UfCDcAbtltMIyBOW(r10);
    L381:
        r162 = null;
        goto L398
    L59:
        r111 = null;
        goto L10
    L401:
        r192 = fkePsokuHdKCyEfa(r54);
        goto L55
    L38:
        r53 = null;
        goto L323
    L239:
        r182 = VTYHLCUbxuATEmEL(r65);
        goto L278
    L157:
        r64 = null;
        goto L245
    L131:
        r172 = eGjzAPtNDFXiDetr(r63);
        goto L287
    L341:
        r62 = null;
        goto L277
    L298:
        r25 = new Timestamp(SEzabDyHqSEmgsow(r18));
        goto L75
    L223:
        r24 = new Timestamp(SfuqxndBzAunMZSE(r17));
        goto L273
    L331:
        r23 = new Timestamp(jShYOZQSkXwdZggm(r16));
        goto L188
    L251:
        r142 = "";
        goto L318
    L332:
        r15 = r13;
        goto L343
    L185:
        p6285e3eb r04 = (p6285e3eb) r2.L$3;
        List<p13fc8880> r43 = (List) r2.L$2;
        List<p170c9f21> r72 = (List) r2.L$1;
        pb43933e4 r82 = (pb43933e4) r2.L$0;
        qyyiuakWfMDdXSrE(r1);
    L340:
        Dictionary r115 = (Dictionary) r1;
        List r102 = new List();
        r42 = tKqWaBPJGLhIyzcI(r43);
        r11 = r72;
        r12 = r82;
        r7 = r102;
        r10 = r04;
        r8 = r115;
        goto L295
    L348:
        List<p13fc8880> r05 = (List) r2.L$2;
        List<p170c9f21> r44 = (List) r2.L$1;
        pb43933e4 r83 = (pb43933e4) r2.L$0;
        QzySVxqAecDZIwlP(r1);     // Catch: Exception -> L407
        List<p13fc8880> r103 = r05;
        r0 = r83;
    L82:
        r82 = r0;
        r04 = (p6285e3eb) r1;     // Catch: Exception -> L426
    L162:
        List<p170c9f21> r116 = r44;
        r43 = r103;
        pc60ad0d1 r104 = r82.f7a3012f9;
        r2.L$0 = r82;
        r2.L$1 = r116;
        r2.L$2 = r43;
        r2.L$3 = r04;
        r2.fd304ba20 = 2;
        object r73 = jNmzQceSeEjnQaiG(r104, r2);
        if (r73 == r3) goto L309;
        r72 = r116;
        r1 = r73;
    L421:
        r82 = r0;
        r04 = null;
    L257:
        r103 = r05;
        r0 = r83;
        goto L421
    L366:
        GXvkxTnjfngRMcMM(r1);
        pfeb9ca41 r117 = r0.ffa781974;     // Catch: Exception -> L140
        r2.L$0 = r0;     // Catch: Exception -> L140
        r44 = r33;
        r2.L$1 = r44;     // Catch: Exception -> L427
        r103 = r34;
        r2.L$2 = r103;     // Catch: Exception -> L426
        r2.fd304ba20 = 1;     // Catch: Exception -> L426
        r1 = xStCWxtOqhyLqdcG(r117, r2);     // Catch: Exception -> L426
        if (r1 != r3) goto L82;
    L305:
        r103 = r34;
    L93:
        r44 = r33;
        goto L305
    L253:
        r2 = (pb43933e4$pbc3f1df3$1) r35;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L61;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L77
    }

    public static readonly /* synthetic */ object mcc980c15(pb43933e4 r0, List r1, List r2, Continuation r3) {
        return BOexFVAaJCBtSwtR(r0, r1, r2, r3);
    }

    public static p9d21d731 MzEFsMmmEVWrENdC(p13fc8880 r1) {
        return r1.getState();
    }

    public static object NtPyVTIlwhCNQhzh(pc60ad0d1 r1, List r2, Continuation r3) {
        return r1.getIfNotExistPaymentHashSettings(r2, r3);
    }

    public static bool OTOikAnbdWwykrfV(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static IEnumerator OuCevkAtcDOkcZKo(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static object PdmhidTuSLQUbaqn(pfeb9ca41 r1, Continuation r2) {
        return r1.clearDevices(r2);
    }

    public static object PjnXJhEyOCmgcupY(pdba8e92c r1, string r2, string r3, Continuation r4) {
        return r1.getStores(r2, r3, r4);
    }

    public static bool PnAtinWyHiwtiCOG(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static string PsQpxinyvgcTVVDs(p3666b042 r1) {
        return r1.getUserId();
    }

    public static void QyyiuakWfMDdXSrE(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static long RJGEpSbUxhMPueey(p13fc8880 r1) {
        return r1.getRegistrationDateTime();
    }

    public static bool SAiRNcoEcIyBlsfG(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static void SDAzMKzAKsZWGKBZ(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string SKhLGpfiLEmYGCfO(p13fc8880 r1) {
        return r1.getDeviceId();
    }

    public static p4f30e9bd SNDnYIXDTlTkWaHL(p6285e3eb r1) {
        return pcd945773.m3d5c3f97(r1);
    }

    public static string SyDyAQvKxlcigmcO(p13fc8880 r1) {
        return r1.getShopId();
    }

    public static List SyigLAeHNEQlIdoy() {
        return ICollectionsKt.emptyList();
    }

    public static string TBpsgnEUnKJEccwK(stringBuilder r1) {
        return r1.tostring();
    }

    public static IEnumerator TKqWaBPJGLhIyzcI(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static string TWhTnwfvvNbOybGn(p170c9f21 r1) {
        return r1.getId();
    }

    public static bool ToNVLmfSLQZxTbeA(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static object VLjGrgAqCKvmXeKo(Dictionary r1, object r2) {
        return r1[r2);
    }

    public static object VPpbJnelqLKqEVeJ(Response r1) {
        return r1.body();
    }

    public static IEnumerator VRxmIRwkfxcLhQpb(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static void VwLUAzDhBzANDFdh(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string WQCOoDPQCLIfEpfL(p3666b042 r1) {
        return r1.getUserId();
    }

    public static string WUEGDPRiJFVpEAMs(p13fc8880 r1) {
        return r1.getDeviceId();
    }

    public static bool WwtEhIHAQFJajzeZ(List r1, object r2) {
        return r1.Remove(r2);
    }

    public static object XStCWxtOqhyLqdcG(pfeb9ca41 r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static bool YwgayfLNlrFpPsFf(List r1) {
        return r1.Count == 0;
    }

    public static bool ZEWEXtHPZJJihgeu(Response r1) {
        return r1.isSuccessful();
    }

    public static void ZdWVSvwtZoCMjMin(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public object ClearDevices(Continuation<Unit> r1) {
        object r0 = pdmhidTuSLQUbaqn(this.ffa781974, r1);
        if (r0 != gHDLGHBmpXQEzHPj()) goto L11;
        return r0;
    L11:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public object ClearShops(Continuation<Unit> r1) {
        object r0 = HacGmAueieHtZWsF(this.ffa781974, r1);
        if (r0 != eLLUANrkUHtpgzSb()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public object GetDeviceIdByUuid(string r1, Continuation<string> r2) {
        return GuznysfdCFsuJoHT(this.ffa781974, r1, r2);
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public List<string> GetExpandedShopIds() {
        return this.f8ae51f80;
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public p34dfc252 GetFilter() {
        return this.fb3dc37a9;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r3v0, types: [int] */
    /* JADX WARN: Type inference failed for: r8v0, types: [java.lang.object, pe0212e54.pb3f20355.pb43933e4] */
    /* JADX WARN: Type inference failed for: r8v1 */
    /* JADX WARN: Type inference failed for: r8v11 */
    /* JADX WARN: Type inference failed for: r8v15 */
    /* JADX WARN: Type inference failed for: r8v16 */
    /* JADX WARN: Type inference failed for: r8v17, types: [java.lang.object, pe0212e54.pb3f20355.pb43933e4] */
    /* JADX WARN: Type inference failed for: r8v2, types: [pe0212e54.pb3f20355.pb43933e4] */
    /* JADX WARN: Type inference failed for: r8v20, types: [java.lang.object, pe0212e54.pb3f20355.pb43933e4] */
    /* JADX WARN: Type inference failed for: r8v21, types: [java.lang.object, pe0212e54.pb3f20355.pb43933e4] */
    /* JADX WARN: Type inference failed for: r8v22, types: [java.lang.object, pe0212e54.pb3f20355.pb43933e4] */
    /* JADX WARN: Type inference failed for: r8v23, types: [java.lang.object, pe0212e54.pb3f20355.pb43933e4] */
    /* JADX WARN: Type inference failed for: r8v29 */
    /* JADX WARN: Type inference failed for: r8v30 */
    /* JADX WARN: Type inference failed for: r8v31 */
    /* JADX WARN: Type inference failed for: r8v32 */
    /* JADX WARN: Type inference failed for: r8v33 */
    /* JADX WARN: Type inference failed for: r8v34 */
    /* JADX WARN: Type inference failed for: r8v35 */
    /* JADX WARN: Type inference failed for: r8v36 */
    /* JADX WARN: Type inference failed for: r8v37 */
    /* JADX WARN: Type inference failed for: r8v8 */
    @Override // pe0212e54.pb3f20355.p44cd4abe
    public object GetRemoteDevices(Continuation<? super List<p4f30e9bd>> r9) {
        if (((32 + 20) % 20) > 0) goto L27;
    L27:
        if ((r9 is pb43933e4$p9b47ed42$1) == false) goto L58;
        pb43933e4$p9b47ed42$1 r1 = (pb43933e4$p9b47ed42$1) r9;
        if ((r1.fd304ba20 & int.MIN_VALUE) == 0) goto L58;
        r1.fd304ba20 -= int.MIN_VALUE;
    L171:
        object r92 = r1.fb4a88417;
        object r2 = CqcztqowEAUbVoBl();
        ?? r3 = r1.fd304ba20;
        switch(r3) {
            case 0: goto L89;
            case 1: goto L39;
            case 2: goto L40;
            case 3: goto L161;
            case 4: goto L144;
            case 5: goto L69;
            case 6: goto L136;
            case 7: goto L83;
            default: goto L34;
        };
    L83:
        TngGpJZLNckVFSKi(r92);
    L38:
        List r8 = SjIAdIHfYspePetL((List) r92);
        if (ywgayfLNlrFpPsFf(r8) == true) goto L66;
        return r8;
    L66:
        throw new IllegalStateException(SELdBaHPqSQlvsqe("devices db is empty"));
    L89:
        IjhGGlfAmrrIdouP(r92);
        p3dfe3c80 r93 = CsygFBhYOLnbZNms(this.f663c228e);     // Catch: Exception -> L177
        if (p12c674ac.$EnumSwitchDictionaryping$0[UNVmZYIxPPVdAoSW(r93)] != 1) goto L93;
        string r32 = LtlazIejmCeCWEan(this.f663c228e);     // Catch: Exception -> L177
        ?? r82 = this;
    L97:
        pdba8e92c r5 = r82.f84d2a085;     // Catch: Exception -> L177
        string r94 = LhgFQbOmqimKmuSU(r93);     // Catch: Exception -> L177
        r1.L$0 = r82;     // Catch: Exception -> L177
        r1.L$1 = null;     // Catch: Exception -> L177
        r1.fd304ba20 = 2;     // Catch: Exception -> L177
        r92 = THhnOUtKsrxRbcoO(r5, r32, r94, r1);     // Catch: Exception -> L177
        ?? r83 = r82;
        if (r92 == r2) goto L81;
    L100:
        Response r95 = (Response) r92;     // Catch: Exception -> L177
        pdba8e92c r33 = r83.f84d2a085;     // Catch: Exception -> L177
        string r52 = wQCOoDPQCLIfEpfL(r83.f663c228e);     // Catch: Exception -> L177
        r1.L$0 = r83;     // Catch: Exception -> L177
        r1.L$1 = r95;     // Catch: Exception -> L177
        r1.fd304ba20 = 3;     // Catch: Exception -> L177
        object r34 = QrrSAeologXSCfVp(r33, r52, r1);     // Catch: Exception -> L177
        if (r34 == r2) goto L81;
        Response r35 = r95;
        r92 = r34;
        ?? r84 = r83;
    L104:
        Response r96 = (Response) r92;     // Catch: Exception -> L177
        if (VZDkTmdTawYUkJFT(r35) == false) goto L130;
        if (hcSHmrzKGWBjNnaB(r96) == false) goto L130;
        pfeb9ca41 r0 = r84.ffa781974;     // Catch: Exception -> L177
        List r53 = (List) HqiRRqKtLqZjXxXZ(r35);     // Catch: Exception -> L177
        if (r53 is not null) goto L111;
        r53 = eSYtKIABsLjKLmKb();     // Catch: Exception -> L177
    L111:
        List r54 = HxReEOmhkEhJMaZm(r53);     // Catch: Exception -> L177
        r1.L$0 = r84;     // Catch: Exception -> L177
        r1.L$1 = r35;     // Catch: Exception -> L177
        r1.L$2 = r96;     // Catch: Exception -> L177
        r1.fd304ba20 = 4;     // Catch: Exception -> L177
        if (erihVZwdASipzAkS(r0, r54, r1) == r2) goto L81;
        Response r02 = r35;
        ?? r85 = r84;
    L115:
        List r03 = (List) XhvUzoTklzSIePpW(r02);     // Catch: Exception -> L177
        if (r03 is not null) goto L118;
        r03 = HfndbMjUzgNrmmnZ();     // Catch: Exception -> L177
    L118:
        List r97 = (List) vPpbJnelqLKqEVeJ(r96);     // Catch: Exception -> L177
        if (r97 is not null) goto L121;
        r97 = YQEaFFSUvBpWgnGd();     // Catch: Exception -> L177
    L121:
        r1.L$0 = r85;     // Catch: Exception -> L177
        r1.L$1 = null;     // Catch: Exception -> L177
        r1.L$2 = null;     // Catch: Exception -> L177
        r1.fd304ba20 = 5;     // Catch: Exception -> L177
        object r98 = XQLnAtsrahmXiXIz(r85, r03, r97, r1);     // Catch: Exception -> L177
        ?? r86 = r85;
        if (r98 == r2) goto L81;
    L124:
        pfeb9ca41 r99 = r86.ffa781974;     // Catch: Exception -> L177
        r1.L$0 = r86;     // Catch: Exception -> L177
        r1.fd304ba20 = 6;     // Catch: Exception -> L177
        r92 = dksjluFniZukMubB(r99, r1);     // Catch: Exception -> L177
        if (r92 == r2) goto L81;
    L128:
        return QhzYoXNoijWazWaV((List) r92);
    L130:
        throw new Exception(tBpsgnEUnKJEccwK(VqdxwATqlPXQMBQL(PoWRhFvZRzqxXSty(UmLRMEBohRoiGjaA(new stringBuilder("shops isSuccessful = "), kuCgivEDKqgyzesa(r35)), " and devices isSuccessful = "), zEWEXtHPZJJihgeu(r96))));     // Catch: Exception -> L177
    L81:
        return r2;
    L93:
        p0c2c0436 r36 = this.fedc5f59e;     // Catch: Exception -> L177
        r1.L$0 = this;     // Catch: Exception -> L177
        r1.L$1 = r93;     // Catch: Exception -> L177
        r1.fd304ba20 = 1;     // Catch: Exception -> L177
        object r37 = OwcCrKfqHjJstMbH(r36, r1);     // Catch: Exception -> L177
        ?? r87 = this;
        if (r37 == r2) goto L81;
    L96:
        r32 = PYWcYhItGvjSWyAK((pf8c8b903) r37);     // Catch: Exception -> L177
        r82 = r87;
        goto L97
    L136:
        pb43933e4 r88 = (pb43933e4) r1.L$0;
        KXVwTDdXusdFzYJy(r92);     // Catch: Exception -> L177
        goto L128
    L40:
        pb43933e4 r89 = (pb43933e4) r1.L$0;
        EOwWulcjnSbXYhyQ(r92);     // Catch: Exception -> L177
        r83 = r89;
        goto L100
    L69:
        pb43933e4 r810 = (pb43933e4) r1.L$0;
        XlIEooUaXgAqeXJF(r92);     // Catch: Exception -> L177
        r86 = r810;
        goto L124
    L144:
        Response r811 = (Response) r1.L$2;
        r02 = (Response) r1.L$1;
        pb43933e4 r38 = (pb43933e4) r1.L$0;
        lBGbjxNrlKANJGCy(r92);     // Catch: Exception -> L157
        r96 = r811;
        r85 = r38;
        goto L115
    L34:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L161:
        Response r812 = (Response) r1.L$1;
        pb43933e4 r39 = (pb43933e4) r1.L$0;
        SwAFqHzcyQWnTdso(r92);     // Catch: Exception -> L157
        r35 = r812;
        r84 = r39;
        goto L104
    L39:
        p3dfe3c80 r813 = (p3dfe3c80) r1.L$1;
        pb43933e4 r310 = (pb43933e4) r1.L$0;
        HpikKnAJNyZfwUVo(r92);     // Catch: Exception -> L157
        r93 = r813;
        r87 = r310;
        r37 = r92;
    L4:
        pfeb9ca41 r814 = this.ffa781974;
        r1.L$0 = null;
        r1.L$1 = null;
        r1.L$2 = null;
        r1.fd304ba20 = 7;
        r92 = CkAJIadyogpdCnBc(r814, r1);
        if (r92 == r2) goto L81;
    L132:
        pb43933e4 this = r3;
    L58:
        r1 = new pb43933e4$p9b47ed42$1(this, r9);
        goto L171
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public object GetSelectedDevice(Continuation<p4f30e9bd> r5) {
        if (((25 + 22) % 22) > 0) goto L45;
    L45:
        if ((r5 is pb43933e4$pd7f4518e$1) == true) goto L7;
    L32:
        pb43933e4$pd7f4518e$1 r0 = new pb43933e4$pd7f4518e$1(this, r5);
    L31:
        object r52 = r0.fb4a88417;
        object r1 = kGzTMuZGNNetuBxt();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L63;
        if (r2 != 1) goto L61;
        DGSxLQudNKmEBixp(r52);
    L23:
        return sNDnYIXDTlTkWaHL((p6285e3eb) r52);
    L61:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L63:
        kftXAHjoFdDFsIEt(r52);
        pfeb9ca41 r4 = this.ffa781974;
        r0.fd304ba20 = 1;
        r52 = HEtjAhCuGoaIHMxA(r4, r0);
        if (r52 != r1) goto L23;
        return r1;
    L7:
        r0 = (pb43933e4$pd7f4518e$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L32;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L31
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public object GetShops(Continuation<? super List<p9f82518d>> r8) {
        if (((17 + 16) % 16) > 0) goto L128;
    L128:
        if ((r8 is pb43933e4$p99196987$1) == false) goto L24;
        pb43933e4$p99196987$1 r0 = (pb43933e4$p99196987$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L24;
        r0.fd304ba20 -= int.MIN_VALUE;
    L66:
        object r82 = r0.fb4a88417;
        object r1 = TjysIXfPdOrsvhey();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L120;
        if (r2 == 1) goto L105;
        if (r2 != 2) goto L8;
        zdWVSvwtZoCMjMin(r82);
    L80:
        Response r83 = (Response) r82;
        if (lvtPqMKFEzZOEaXE(r83) == false) goto L28;
        List r7 = (List) PirdHajcgYVZUjmQ(r83);
        if (r7 is not null) goto L20;
    L35:
        return syigLAeHNEQlIdoy();
    L20:
        List r72 = hNzrNHhnzxDhiouO(r7, new pb43933e4$p99196987$pd41d8cd9$pec404527$pe8462a18$1());
        if (r72 is null) goto L35;
        List r73 = OVPSvHDwPsKEuyPy(r72);
        if (r73 is null) goto L35;
        return r73;
    L28:
        throw new IllegalStateException(lEkOUIfnhIfphtSI("Invalid shops"));
    L8:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L105:
        p3dfe3c80 r74 = (p3dfe3c80) r0.L$1;
        pb43933e4 r22 = (pb43933e4) r0.L$0;
        GWnIqkLrIkNdDfSy(r82);
        p3dfe3c80 r84 = r74;
        pb43933e4 this = r22;
        object r23 = r82;
    L85:
        string r24 = OtQRonsDBVcojqzZ((pf8c8b903) r23);
    L10:
        pdba8e92c r75 = this.f84d2a085;
        string r85 = SsjZwjlhdZsmmbJY(r84);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        r82 = pjnXJhEyOCmgcupY(r75, r24, r85, r0);
        if (r82 != r1) goto L80;
    L135:
        return r1;
    L120:
        vwLUAzDhBzANDFdh(r82);
        r84 = DUMiYmRAVgJegaUf(this.f663c228e);
        if (p12c674ac.$EnumSwitchDictionaryping$0[aSGbOxWccVzPXbzX(r84)] == 1) goto L73;
        p0c2c0436 r25 = this.fedc5f59e;
        r0.L$0 = this;
        r0.L$1 = r84;
        r0.fd304ba20 = 1;
        r23 = NgvieqfYzqpUmmsm(r25, r0);
        if (r23 == r1) goto L135;
    L73:
        r24 = psQpxinyvgcTVVDs(this.f663c228e);
    L24:
        r0 = new pb43933e4$p99196987$1(this, r8);
        goto L66
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public bool IsFirstTimeEnter() {
        return this.f20879484;
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public object RemoveDevice(string r1, Continuation<Unit> r2) {
        object r0 = UPTvsfkOFZwlkQRO(this.ffa781974, r1, r2);
        if (r0 != AvLqSJChcBHnBAdC()) goto L6;
        return r0;
    L6:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public void RemoveExpandedShopId(string r2) {
        fFBNYaihlXtWznpS(r2, "id");
        if (OIFPhqbRDgKGOsUr(this.f8ae51f80, r2) == true) goto L8;
    L3:
        this.f20879484 = false;
        return;
    L8:
        wwtEhIHAQFJajzeZ(this.f8ae51f80, r2);
        goto L3
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public void SaveExpandedShopId(string r2) {
        hUKdObXjpkpCjewe(r2, "id");
        if (VdcCguThUswNBxjW(this.f8ae51f80, r2) == false) goto L3;
    L9:
        this.f20879484 = false;
        return;
    L3:
        XhTDzIFvLecjyuBG(this.f8ae51f80, r2);
        goto L9
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public object SelectDevice(string r1, Continuation<Unit> r2) {
        object r0 = QeTVvByNftCZuhjS(this.ffa781974, r1, r2);
        if (r0 != SrUmdPiFnNRFAeWj()) goto L15;
        return r0;
    L15:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.p44cd4abe
    public void UpdateFilter(p34dfc252 r2) {
        kFUNAbBuudGzNDev(r2, "deviceFilter");
        this.fb3dc37a9 = r2;
    }
}

