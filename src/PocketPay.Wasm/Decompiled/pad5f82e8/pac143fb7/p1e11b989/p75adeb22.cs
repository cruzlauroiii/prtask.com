using Com.Google.Firebase.Crashlytics;
using Java.Math;
using Java.Util;
using Java.Util.Concurrent.Atomic;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P1e11b989.P9acb4454.Pac143fb7;
using P2b3583e6;
using P2b3583e6.P19ad2780.P1e11b989;
using P4670093c.Pb3f20355;
using P7a1eabc3.P07214c67.P20f35e63.Pec5cb3e6;
using P7a1eabc3.Pac143fb7;
using P8325324b.Pb3f20355;
using P8d777f38.Pb3f20355.P1e11b989;
using P8d777f38.Pb3f20355.Pcf1e8c14;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.Pac143fb7.P68c4283d.Pbf12e151;
using Pe0212e54.Pb3f20355;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
public readonly class p75adeb22 : pf21d5ed1 {
    private readonly p24ddebba f0876ece0;
    private Atomicbool f1155bc61;
    private readonly p6d73504b f1d183dad;
    private readonly p68086021 f311d6339;
    private readonly p883b57c7 f395bf4d9;
    private readonly p7638dcb8 f4656f605;
    private readonly p883b57c7 f5141a624;
    private readonly p68086021 f56eabe9f;
    private readonly p24ddebba f581a44fa;
    private readonly p24ddebba f5c8283a7;
    private readonly p3851083a f5ddb616f;
    private readonly p3851083a f62fabc62;
    private Atomicbool f6520840d;
    private readonly p13d58ddc f68c4283d;
    private readonly p6d73504b f68dd5b56;
    private readonly p24ddebba f708651c4;
    private readonly p24ddebba f78129a46;
    private readonly p44cd4abe f7bf36dc5;
    private readonly p44cd4abe f8af308bf;
    private readonly p3851083a f91b5f5ab;
    private readonly p13d58ddc f9b232de2;
    private Atomicbool fa0c99f78;
    private readonly p13d58ddc faaff739f;
    private readonly p7638dcb8 fbbd9467c;
    private readonly p44cd4abe fc58d3bc2;
    private readonly p883b57c7 fd31a7c86;
    private readonly p883b57c7 fd875479b;
    private readonly p68086021 fde8ce21d;
    private readonly p883b57c7 fe1573b6f;
    private readonly p13d58ddc fe37eff54;
    private readonly p13d58ddc fee02a9e0;
    private readonly p7638dcb8 ff2fed930;

    public p75adeb22(p68086021 r2, p7638dcb8 r3, p3851083a r4, p24ddebba r5, p44cd4abe r6, p883b57c7 r7, p6d73504b r8, p13d58ddc r9) {
        wyIVFsQvfSHPnoJn(r2, "receiptServerRepository");
        ZKqEhvkeWUzolDiI(r3, "receiptDbRepository");
        MWOSlRUKMyQClbhh(r4, "sellReceiptRepository");
        oTHpouVUausemOZu(r5, "paybackReceiptRepository");
        DrATsDELugoDjRhz(r6, "devicesRepository");
        pidLQMDYYmsKFtWX(r7, "receiptStatusUseCase");
        PQBYnWuyvkHAJZys(r8, "inventoryUseCase");
        BwHeXnuznManiwtK(r9, "analytics");
        this.f56eabe9f = r2;
        this.ff2fed930 = r3;
        this.f91b5f5ab = r4;
        this.f78129a46 = r5;
        this.f8af308bf = r6;
        this.f395bf4d9 = r7;
        this.f68dd5b56 = r8;
        this.f68c4283d = r9;
        this.f6520840d = new Atomicbool(false);
    }

    public static object AFBkotRQdhxSpnGo() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object AVCAVtOsZQlxQOTo(p75adeb22 r1, p9ded6185 r2, Continuation r3) {
        return r1.m8307c351(r2, r3);
    }

    public static long BkTYtkUYCnCJyVMi() {
        if (((14 + 18) % 18) > 0) goto L7;
    L7:
        return p728cd16b.mc863d45c();
    }

    public static void BwHeXnuznManiwtK(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void DrATsDELugoDjRhz(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static bool EbDIsNPmeYxWexBY(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static void EuUurxsavdfmejpd(p13d58ddc r0, p8c261c90 r1, string r2, string r3, string r4) {
        r0.prepareSendReceipt(r1, r2, r3, r4);
    }

    public static pd6d7c5a3 FTdVBCYguINmnQqv(p9ded6185 r1, string r2, string r3, string r4, string r5, long r6, int r8) {
        return p434d238d.mcf761510(r1, r2, r3, r4, r5, r6, r8);
    }

    public static object FVMAGDBwWZithplB(p44cd4abe r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static object FwduUGbDxvgCHiii() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object GHjBfDOhOCvWJNUV(p75adeb22 r1, p9ded6185 r2, Continuation r3) {
        return r1.m19baaff4(r2, r3);
    }

    public static p8c261c90 GnnrgmzjZJhHqxzy(p9ded6185 r1) {
        return r1.getPaymentType();
    }

    public static object HIthaBuafBBmeRYz() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void HNFcguSpHHUCZrZn(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static ped663a3e HxcpqlndrXzyOaTY(ped663a3e r1, string r2, string r3, p22820a6f r4, int r5, List r6, string r7, string r8, p8c261c90 r9, List r10, bool r11, p5a409c20 r12, string r13, string r14, string r15, pc5f0acf1 r16, DateTime r17, pd751e33c r18, string r19, string r20, decimal r21, decimal r22, string r23, bool r24, bool r25, List r26, p471052f5 r27, int r28, object r29) {
        return ped663a3e.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29);
    }

    public static p22820a6f IHqhkxQgOHOceiAq(p9ded6185 r1) {
        return r1.getReceiptType();
    }

    public static object IJXPKixnRdlcOzLY(p3851083a r1, Continuation r2) {
        return r1.removeCurrentReceipt(r2);
    }

    public static string IKHOGlkbCXCSBTRp(p9ded6185 r1) {
        return r1.getUuid();
    }

    public static void IXYmKcEAywGDfTck(Exception r0) {
        r0.printStackTrace();
    }

    public static object JCBCtiAFuIBTLiEf(p24ddebba r1, Continuation r2) {
        return r1.removeCurrentReceipt(r2);
    }

    public static void JEPYDHnnmewhtSiI(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object JHMfZFIoDrPJbwuZ() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void JJNgaEMbKEyICMRa(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string JNlyhtQXBWVONBDM(p22820a6f r1) {
        return r1.name();
    }

    public static object JPLpHoOYqLYIoarV(p883b57c7 r1, Continuation r2) {
        return r1.updateReceiptsStatus(r2);
    }

    public static p8c261c90 KXdvgnAxpqVEVuml(p9ded6185 r1) {
        return r1.getPaymentType();
    }

    public static decimal KgsYzysCaxCWGHZI(pd031d465 r1) {
        return r1.getQuantity();
    }

    public static object LOfPutplJURBgOHa(p24ddebba r1, p18cf5223 r2, string r3, Continuation r4) {
        return r1.savePaybackReceipt(r2, r3, r4);
    }

    public static List LYPHykpdHsFiDusE(ped663a3e r1) {
        return r1.getPositions();
    }

    public static object LcRcqDHyNVXJMgvH(p68086021 r1, pd6d7c5a3 r2, bool r3, Continuation r4) {
        return r1.sendReceipt(r2, r3, r4);
    }

    public static pa006dee7 LiHLOHqPYhqAbzPX(pa006dee7 r1) {
        return r1.toRevaluationReceipt();
    }

    public static string MEGYKUtMjGnxaPOs(p4f30e9bd r1) {
        return r1.getUserId();
    }

    public static p22820a6f MFOQzXpLEAvoaini(p9ded6185 r1) {
        return r1.getReceiptType();
    }

    public static void MWOSlRUKMyQClbhh(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void MtFwWdbvrWByspWH(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object NVUcXPUndjIRckWC(p24ddebba r1, p18cf5223 r2, string r3, Continuation r4) {
        return r1.saveQueuePaybackReceipt(r2, r3, r4);
    }

    public static decimal OahdRnahLNoChpuW(pd031d465 r1) {
        return r1.getQuantity();
    }

    public static string PFiMLAGaNwuIXTQD(p4f30e9bd r1) {
        return r1.getShopId();
    }

    public static void PQBYnWuyvkHAJZys(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string PVcHqwVjmmNYgUDY(p4f30e9bd r1) {
        return r1.getDeviceId();
    }

    public static void PZaBrynzpnzYmQUF(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object PjcAYSDCCptnwQWR(p7638dcb8 r1, ped663a3e r2, string r3, Continuation r4) {
        return r1.saveSellReceipt(r2, r3, r4);
    }

    public static object PtQMdiLQviYJLzpW(p3851083a r1, Continuation r2) {
        return r1.removeCurrentReceipt(r2);
    }

    public static void PtgYgPZaGDsHRJru(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool QCUIVPPNvKXXkjFG(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static string QNeskJpzJFXWSAoH(pd031d465 r1) {
        return r1.getCommodityId();
    }

    public static object QOqwmEfEImRVJrlL(p75adeb22 r1, p9ded6185 r2, Continuation r3) {
        return r1.m19baaff4(r2, r3);
    }

    public static string RabtWCXHKoFqkJMv(p9ded6185 r1) {
        return r1.getUuid();
    }

    public static pd6d7c5a3 RkcXvTrQYjZuRfse(p9ded6185 r1, string r2, string r3, string r4, string r5, long r6, int r8) {
        return p434d238d.mcf761510(r1, r2, r3, r4, r5, r6, r8);
    }

    public static void RyLRddbRMRyoSgZY(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string SVnFGQFzMkdKcgmS(p4f30e9bd r1) {
        return r1.getUserId();
    }

    public static IEnumerator SaKkBgpyIVtniwXA(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static void ScnCKXCYouTVIxDa(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string SvwGXHrSAIMYrCHE(p22820a6f r1) {
        return r1.name();
    }

    public static object TLJbaGdRdOpqRmPW(p44cd4abe r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static void TmPbbxYxTmMpeJvH(p13d58ddc r0, p8c261c90 r1, string r2, string r3, string r4) {
        r0.saveReceiptToQueue(r1, r2, r3, r4);
    }

    public static decimal TnKeOJYnbrNqrNNb(pd031d465 r1) {
        return r1.getPrice();
    }

    public static void UDYjdpHnaSIFzhWD(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object UXLRcUbqmzifsCKV(p75adeb22 r1, p9ded6185 r2, Continuation r3) {
        return r1.m8307c351(r2, r3);
    }

    public static void UprNHxurDlyQwTQd(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static object UysOlVwtUgrZTdVl(p6d73504b r1, List r2, Continuation r3) {
        return r1.updateCommoditiesQuantity(r2, r3);
    }

    public static object VHMqUlTrFXdzZpSV(p75adeb22 r1, p9ded6185 r2, string r3, Continuation r4) {
        return r1.me9892eb1(r2, r3, r4);
    }

    public static List WBpeKCdTWaahdzYV(p75adeb22 r1, List r2) {
        return r1.mfa472504(r2);
    }

    public static object WIdyKWwMiqRgzTBF(p75adeb22 r1, p9ded6185 r2, Continuation r3) {
        return r1.mdddc363b(r2, r3);
    }

    public static string WPaAVVvlTntWpJRy(p9ded6185 r1) {
        return r1.getUuid();
    }

    public static ped663a3e WoBnsrGHfPduOedX(ped663a3e r1, string r2, string r3, p22820a6f r4, int r5, List r6, string r7, string r8, p8c261c90 r9, List r10, bool r11, p5a409c20 r12, string r13, string r14, string r15, pc5f0acf1 r16, DateTime r17, pd751e33c r18, string r19, string r20, decimal r21, decimal r22, string r23, bool r24, bool r25, List r26, p471052f5 r27, int r28, object r29) {
        return ped663a3e.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29);
    }

    public static object WvPyYbFhLoMlpOiR(p75adeb22 r1, p9ded6185 r2, Continuation r3) {
        return r1.m8307c351(r2, r3);
    }

    public static bool XOSuoIMepjPylhAI(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static void XSLOvpqLeaqSOCBQ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p8c261c90 XZSRwiIDWSQFHaab(p9ded6185 r1) {
        return r1.getPaymentType();
    }

    public static object XhoERCTemlTfoGUV() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void XtVNnrUKcFvtJfdS(p13d58ddc r0, p8c261c90 r1, string r2, string r3, string r4) {
        r0.sendErrorReceipt(r1, r2, r3, r4);
    }

    public static object XxVPNuSTxAETYjzC(p75adeb22 r1, p9ded6185 r2, string r3, Continuation r4) {
        return r1.m4d0efa5d(r2, r3, r4);
    }

    public static void YDvxrPvISNPZVFYn(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object YGEUcgXBgUnZwIZu() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void YOlizbAvnLtbXvms(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p18cf5223 YPfeVoXxpzLUujas(p18cf5223 r1, string r2, string r3, p22820a6f r4, int r5, List r6, string r7, string r8, p8c261c90 r9, List r10, bool r11, p5a409c20 r12, string r13, string r14, string r15, pc5f0acf1 r16, DateTime r17, pd751e33c r18, string r19, string r20, decimal r21, decimal r22, string r23, string r24, List r25, decimal r26, p471052f5 r27, int r28, object r29) {
        return p18cf5223.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29);
    }

    public static void YQzcBZVToYMQTLQB(Atomicbool r0, bool r1) {
        r0.set(r1);
    }

    public static p22820a6f ZEcefslrEFYRVVDi(p9ded6185 r1) {
        return r1.getReceiptType();
    }

    public static void ZKqEhvkeWUzolDiI(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string ZMybxNJzBVETkZGv(p4f30e9bd r1) {
        return r1.getDeviceId();
    }

    public static string ZnZCoviOzDfkSPGZ(p22820a6f r1) {
        return r1.name();
    }

    public static void ZwYpbchlbnoXHARc(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static object ZxqtaSdSmVcOvzmd(p75adeb22 r1, p9ded6185 r2, string r3, Continuation r4) {
        return r1.me9892eb1(r2, r3, r4);
    }

    public static object AAxdRwaSqSGrXshs(p68086021 r1, pd6d7c5a3 r2, bool r3, Continuation r4, int r5, object r6) {
        return p68086021.pb0da8397.m581aeacb(r1, r2, r3, r4, r5, r6);
    }

    public static void ALEIKrbhMhEFDKmm(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void ALOuxjbKGrGPHDrX(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string AZyRrLzEkDUpPPqs(p4f30e9bd r1) {
        return r1.getUserId();
    }

    public static void AfkPWZuROUHuxrHD(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static FirebaseCrashlytics AgVOBCjTpLFEboJS() {
        return FirebaseCrashlytics.getInstance();
    }

    public static IEnumerator BpZtUZHBpHpbMgYZ(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static void BwizwhNEPUiWOHLQ(Exception r0) {
        r0.printStackTrace();
    }

    public static string CKUGSzznSjKrurYP(p4f30e9bd r1) {
        return r1.getDeviceId();
    }

    public static void CPiHoCYORRtKdVLV(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static List CgUcTYhOjExOcNHl(p75adeb22 r1, List r2) {
        return r1.m816bcbd7(r2);
    }

    public static string CjRepawWGlZKFeGg(p4f30e9bd r1) {
        return r1.getDeviceId();
    }

    public static object CkOIOxwLmYboMfaz(IEnumerator r1) {
        return r1.Current;
    }

    public static decimal CtobQlNAjzmzNbxM(decimal r1) {
        return r1.negate();
    }

    public static FirebaseCrashlytics CxQjGBTpVBCqsczI() {
        return FirebaseCrashlytics.getInstance();
    }

    public static long DHDPHPhXjBISANkU() {
        if (((4 + 28) % 28) > 0) goto L17;
    L17:
        return p728cd16b.mc863d45c();
    }

    public static p8c261c90 DKecRAmoDTxHzBQY(p9ded6185 r1) {
        return r1.getPaymentType();
    }

    public static object DNDKAncHHvxNoLsd(p6d73504b r1, List r2, Continuation r3) {
        return r1.updateCommoditiesQuantityAndPrice(r2, r3);
    }

    public static object DPqQSYZsdyCqIzjC(IEnumerator r1) {
        return r1.Current;
    }

    public static p22820a6f DeJcWAOQfzCRKWzl(p9ded6185 r1) {
        return r1.getReceiptType();
    }

    public static object DlYyaLCWLALAyPEM(IEnumerator r1) {
        return r1.Current;
    }

    public static string DqyRVCcyIPBJEpiS(p18cf5223 r1) {
        return r1.getUuid();
    }

    public static pd6d7c5a3 ExXutPMtaxTItFcM(p9ded6185 r1, string r2, string r3, string r4, string r5, long r6, int r8) {
        return p434d238d.mcf761510(r1, r2, r3, r4, r5, r6, r8);
    }

    public static int ExeOEopOqRkJlump() {
        return p728cd16b.mfb101d56();
    }

    public static string FCyQqcjPWsFpLfPG(p4f30e9bd r1) {
        return r1.getDeviceUUid();
    }

    public static List FmLZULjmoqhlxKcu(p18cf5223 r1) {
        return r1.getPositions();
    }

    public static bool GGfpwvwzMntroAJI(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static void HBztxEkYDjUpzQiG(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void HeYqYtcwecsurOZL(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object IVkPcSjIzrEsHapu(p75adeb22 r1, p9ded6185 r2, string r3, Continuation r4) {
        return r1.m4d0efa5d(r2, r3, r4);
    }

    public static string IeudOdZkDQejazGp(p9ded6185 r1) {
        return r1.getUuid();
    }

    public static object IoKQJSrfjCbimPQs(p75adeb22 r1, p9ded6185 r2, Continuation r3) {
        return r1.mdddc363b(r2, r3);
    }

    public static void IuLeeobtnkiXGxXC(Exception r0) {
        r0.printStackTrace();
    }

    public static string KDOYyYxAECFAuaaC(p4f30e9bd r1) {
        return r1.getShopId();
    }

    public static void KKAfwVBjPJTGaOtD(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static bool KqpGKwndxTkwNAxX(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static object LIcAnkjajEBVyOku(p75adeb22 r1, p9ded6185 r2, Continuation r3) {
        return r1.m8307c351(r2, r3);
    }

    public static List LaWFdkzIemytBoHT(p3e0c0c49 r1) {
        return r1.getPositions();
    }

    private readonly List<p4a26ac24> M1958f08c(List<pd031d465> r7) {
        if (((11 + 3) % 3) > 0) goto L3;
    L3:
        List<pd031d465> r72 = r7;
        List r6 = new List();
        IEnumerator r73 = nluKZKdCAAbdXmit(r72);
    L19:
        if (kqpGKwndxTkwNAxX(r73) == false) goto L48;
        pd031d465 r0 = (pd031d465) ckOIOxwLmYboMfaz(r73);
        string r1 = yJCWXLwGkeLqPApn(r0);
        if (r1 is not null) goto L41;
        p4a26ac24 r2 = null;
    L42:
        if (r2 is null) goto L19;
        gGfpwvwzMntroAJI(r6, r2);
        goto L19
    L41:
        r2 = new p4a26ac24(r1, OahdRnahLNoChpuW(r0), new p5267f68e(TnKeOJYnbrNqrNNb(r0), qysLHsZpJEcIluYi(r0)));
        goto L42
    L48:
        return r6;
    }

    private readonly object M19baaff4(p9ded6185 r2, Continuation<Unit> r3) {
        if ((r2 is ped663a3e) == false) goto L25;
        object r1 = sGJPoFIQfghjmclD(this.f91b5f5ab, tnQwQnGKmiFYMFkc((ped663a3e) r2), r3);
        if (r1 != tiEYcWJYNpIpEWkF()) goto L22;
        return r1;
    L22:
        return Unit.INSTANCE;
    L25:
        if ((r2 is p18cf5223) == true) goto L42;
        return Unit.INSTANCE;
    L42:
        object r12 = oyqZMjFJPqVfHQCL(this.f78129a46, dqyRVCcyIPBJEpiS((p18cf5223) r2), r3);
        if (r12 != YGEUcgXBgUnZwIZu()) goto L15;
        return r12;
    L15:
        return Unit.INSTANCE;
    }

    public static readonly /* synthetic */ object m35532eee(p75adeb22 r0, p9ded6185 r1, Continuation r2) {
        return ioKQJSrfjCbimPQs(r0, r1, r2);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r1v1, types: [java.lang.object, pad5f82e8.pac143fb7.p1e11b989.p75adeb22] */
    /* JADX WARN: Type inference failed for: r1v12 */
    /* JADX WARN: Type inference failed for: r1v13 */
    /* JADX WARN: Type inference failed for: r1v17 */
    /* JADX WARN: Type inference failed for: r1v2 */
    /* JADX WARN: Type inference failed for: r1v20 */
    /* JADX WARN: Type inference failed for: r1v21 */
    /* JADX WARN: Type inference failed for: r1v22 */
    /* JADX WARN: Type inference failed for: r1v23, types: [pad5f82e8.pac143fb7.p1e11b989.p75adeb22] */
    /* JADX WARN: Type inference failed for: r1v25 */
    /* JADX WARN: Type inference failed for: r1v26, types: [pad5f82e8.pac143fb7.p1e11b989.p75adeb22] */
    /* JADX WARN: Type inference failed for: r1v27, types: [java.lang.object, pad5f82e8.pac143fb7.p1e11b989.p75adeb22] */
    /* JADX WARN: Type inference failed for: r1v28, types: [java.lang.object, pad5f82e8.pac143fb7.p1e11b989.p75adeb22] */
    /* JADX WARN: Type inference failed for: r1v29, types: [java.lang.object, pad5f82e8.pac143fb7.p1e11b989.p75adeb22] */
    /* JADX WARN: Type inference failed for: r1v30, types: [java.lang.object, pad5f82e8.pac143fb7.p1e11b989.p75adeb22] */
    /* JADX WARN: Type inference failed for: r1v31 */
    /* JADX WARN: Type inference failed for: r1v32 */
    /* JADX WARN: Type inference failed for: r1v33 */
    /* JADX WARN: Type inference failed for: r1v34 */
    /* JADX WARN: Type inference failed for: r1v35 */
    /* JADX WARN: Type inference failed for: r1v5 */
    /* JADX WARN: Type inference failed for: r1v8 */
    /* JADX WARN: Type inference failed for: r1v9 */
    /* JADX WARN: Type inference failed for: r2v1 */
    /* JADX WARN: Type inference failed for: r2v10 */
    /* JADX WARN: Type inference failed for: r2v13 */
    /* JADX WARN: Type inference failed for: r2v17 */
    /* JADX WARN: Type inference failed for: r2v19, types: [java.lang.string] */
    /* JADX WARN: Type inference failed for: r2v20 */
    /* JADX WARN: Type inference failed for: r2v21, types: [java.lang.string] */
    /* JADX WARN: Type inference failed for: r2v22, types: [java.lang.object] */
    /* JADX WARN: Type inference failed for: r2v23, types: [java.lang.object] */
    /* JADX WARN: Type inference failed for: r2v24, types: [java.lang.object] */
    /* JADX WARN: Type inference failed for: r2v26 */
    /* JADX WARN: Type inference failed for: r2v27 */
    /* JADX WARN: Type inference failed for: r2v28 */
    /* JADX WARN: Type inference failed for: r2v29 */
    /* JADX WARN: Type inference failed for: r2v30 */
    /* JADX WARN: Type inference failed for: r2v4 */
    /* JADX WARN: Type inference failed for: r2v6, types: [java.lang.string] */
    /* JADX WARN: Type inference failed for: r2v9 */
    /* JADX WARN: Type inference failed for: r4v2, types: [int] */
    private readonly object M4d0efa5d(p9ded6185 r22, string r23, Continuation<Unit> r24) {
        if (((7 + 1) % 1) > 0) goto L92;
    L92:
        ?? r1 = this;
        p9ded6185 r2 = r22;
        if ((r24 is p75adeb22$p4d0efa5d$1) == true) goto L52;
    L82:
        p75adeb22$p4d0efa5d$1 r3 = new p75adeb22$p4d0efa5d$1(r1, r24);
    L53:
        p75adeb22$p4d0efa5d$1 r7 = r3;
        object r0 = r7.fb4a88417;
        object r32 = AFBkotRQdhxSpnGo();
        ?? r4 = r7.fd304ba20;
        if (r4 != 0) goto L212;
        UDYjdpHnaSIFzhWD(r0);
        r7.L$0 = r1;     // Catch: p7f59467d -> L45
        r7.L$1 = r2;     // Catch: p7f59467d -> L45
        string r42 = r23;
        r7.L$2 = r42;     // Catch: p7f59467d -> L107
        r7.fd304ba20 = 1;     // Catch: p7f59467d -> L107
        object r02 = GHjBfDOhOCvWJNUV(r1, r2, r7);     // Catch: p7f59467d -> L107
        r1 = r1;
        if (r02 == r32) goto L102;
    L22:
        p44cd4abe r03 = r1.f8af308bf;     // Catch: p7f59467d -> L107
        r7.L$0 = r1;     // Catch: p7f59467d -> L107
        r7.L$1 = r2;     // Catch: p7f59467d -> L107
        r7.L$2 = r42;     // Catch: p7f59467d -> L107
        r7.fd304ba20 = 2;     // Catch: p7f59467d -> L107
        r0 = zjXOCnDiaWYTIBcG(r03, r7);     // Catch: p7f59467d -> L107
        if (r0 == r32) goto L102;
        p9ded6185 r12 = r2;
        ?? r25 = r42;
        r1 = r1;
    L215:
        p4f30e9bd r04 = (p4f30e9bd) r0;     // Catch: p7f59467d -> L149
        p68086021 r43 = r1.f56eabe9f;     // Catch: p7f59467d -> L149
        pd6d7c5a3 r6 = RkcXvTrQYjZuRfse(r12, cKUGSzznSjKrurYP(r04), fCyQqcjPWsFpLfPG(r04), wCrjPtUuWKWXKxmp(r04), SVnFGQFzMkdKcgmS(r04), tIuMLnUOsPSJcyey(), mHRbCIDyuwaRRDfH());     // Catch: p7f59467d -> L149
        r7.L$0 = r1;     // Catch: p7f59467d -> L149
        r7.L$1 = r12;     // Catch: p7f59467d -> L149
        r7.L$2 = r25;     // Catch: p7f59467d -> L149
        r7.L$3 = r04;     // Catch: p7f59467d -> L149
        r7.fd304ba20 = 3;     // Catch: p7f59467d -> L149
        ?? r13 = r1;
        ?? r26 = r25;
        if (ouTjOYoHjtSombGZ(r43, r6, false, r7, 2, null) == r32) goto L102;
    L97:
        string r05 = cjRepawWGlZKFeGg(r04);     // Catch: p7f59467d -> L149
        r7.L$0 = r13;     // Catch: p7f59467d -> L149
        r7.L$1 = r12;     // Catch: p7f59467d -> L149
        r7.L$2 = r26;     // Catch: p7f59467d -> L149
        r7.L$3 = null;     // Catch: p7f59467d -> L149
        r7.fd304ba20 = 4;     // Catch: p7f59467d -> L149
        object r06 = ZxqtaSdSmVcOvzmd(r13, r12, r05, r7);     // Catch: p7f59467d -> L149
        ?? r14 = r13;
        ?? r27 = r26;
        if (r06 == r32) goto L102;
    L100:
        r7.L$0 = r14;     // Catch: p7f59467d -> L149
        r7.L$1 = r12;     // Catch: p7f59467d -> L149
        r7.L$2 = r27;     // Catch: p7f59467d -> L149
        r7.fd304ba20 = 5;     // Catch: p7f59467d -> L149
        object r07 = WIdyKWwMiqRgzTBF(r14, r12, r7);     // Catch: p7f59467d -> L149
        r1 = r14;
        r25 = r27;
        if (r07 == r32) goto L102;
    L103:
        nbOdfBvoTPutxBrt(r1.f68c4283d, vfyrylqyvVMOxHlB(r12), WPaAVVvlTntWpJRy(r12), r25, JNlyhtQXBWVONBDM(IHqhkxQgOHOceiAq(r12)));     // Catch: p7f59467d -> L149
        return Unit.INSTANCE;
    L149:
        e = e;
    L185:
        XtVNnrUKcFvtJfdS(r1.f68c4283d, KXdvgnAxpqVEVuml(r12), IKHOGlkbCXCSBTRp(r12), r25, pjswYIscQMEgAFiU(MFOQzXpLEAvoaini(r12)));
        throw e;
    L102:
        return r32;
    L107:
        e = e;
    L203:
        r12 = r2;
        r25 = r42;
    L45:
        e = e;
        r42 = r23;
        goto L203
    L212:
        if (r4 == 1) goto L171;
        if (r4 == 2) goto L91;
        if (r4 == 3) goto L40;
        if (r4 == 4) goto L81;
        if (r4 == 5) goto L197;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L197:
        string r15 = (string) r7.L$2;
        p9ded6185 r28 = (p9ded6185) r7.L$1;
        p75adeb22 r33 = (p75adeb22) r7.L$0;
        cPiHoCYORRtKdVLV(r0);     // Catch: p7f59467d -> L134
        r12 = r28;
        r25 = r15;
        r1 = r33;
    L134:
        e = e;
        r12 = r28;
        r25 = r15;
        r1 = r33;
        goto L185
    L81:
        string r16 = (string) r7.L$2;
        p9ded6185 r29 = (p9ded6185) r7.L$1;
        p75adeb22 r44 = (p75adeb22) r7.L$0;
        JEPYDHnnmewhtSiI(r0);     // Catch: p7f59467d -> L144
        r12 = r29;
        r27 = r16;
        r14 = r44;
        goto L100
    L40:
        p4f30e9bd r17 = (p4f30e9bd) r7.L$3;
        r25 = (string) r7.L$2;
        p9ded6185 r45 = (p9ded6185) r7.L$1;
        p75adeb22 r5 = (p75adeb22) r7.L$0;
        ScnCKXCYouTVIxDa(r0);     // Catch: p7f59467d -> L124
        r04 = r17;
        r12 = r45;
        r13 = r5;
        r26 = r25;
    L124:
        e = e;
        r12 = r45;
        r1 = r5;
        goto L185
    L91:
        string r18 = (string) r7.L$2;
        p9ded6185 r210 = (p9ded6185) r7.L$1;
        p75adeb22 r46 = (p75adeb22) r7.L$0;
        hBztxEkYDjUpzQiG(r0);     // Catch: p7f59467d -> L144
        r12 = r210;
        r25 = r18;
        r1 = r46;
        goto L215
    L171:
        string r19 = (string) r7.L$2;
        r2 = (p9ded6185) r7.L$1;
        p75adeb22 r47 = (p75adeb22) r7.L$0;
        neTyqXCssQsvKAvd(r0);     // Catch: p7f59467d -> L144
        r42 = r19;
        r1 = r47;
    L144:
        e = e;
        r12 = r2;
        r25 = r1;
        r1 = r4;
        goto L185
    L52:
        r3 = (p75adeb22$p4d0efa5d$1) r24;
        if ((r3.fd304ba20 & int.MIN_VALUE) == 0) goto L82;
        r3.fd304ba20 -= int.MIN_VALUE;
        goto L53
    }

    public static readonly /* synthetic */ object m744e99aa(p75adeb22 r0, p9ded6185 r1, string r2, Continuation r3) {
        return VHMqUlTrFXdzZpSV(r0, r1, r2, r3);
    }

    private readonly List<p1b7a5668> M816bcbd7(List<pd031d465> r4) {
        if (((28 + 7) % 7) > 0) goto L20;
    L20:
        List<pd031d465> r42 = r4;
        List r3 = new List();
        IEnumerator r43 = bpZtUZHBpHpbMgYZ(r42);
    L39:
        if (vXMGLFIWwWWzwUDl(r43) == false) goto L15;
        pd031d465 r0 = (pd031d465) dPqQSYZsdyCqIzjC(r43);
        string r1 = QNeskJpzJFXWSAoH(r0);
        if (r1 is not null) goto L26;
        p1b7a5668 r2 = null;
    L17:
        if (r2 is null) goto L39;
        EbDIsNPmeYxWexBY(r3, r2);
        goto L39
    L26:
        r2 = new p1b7a5668(r1, tIwaINMHOefmRTcn(r0));
        goto L17
    L15:
        return r3;
    }

    private readonly object M8307c351(p9ded6185 r14, Continuation<Unit> r15) {
        if (((22 + 13) % 13) > 0) goto L98;
    L98:
        if ((r15 is p75adeb22$p8307c351$1) == true) goto L8;
    L41:
        p75adeb22$p8307c351$1 r0 = new p75adeb22$p8307c351$1(this, r15);
    L89:
        p75adeb22$p8307c351$1 r4 = r0;
        object r152 = r4.fb4a88417;
        object r02 = HIthaBuafBBmeRYz();
        int r1 = r4.fd304ba20;
        if (r1 != 0) goto L86;
        oiHGSvJfninLnSxB(r152);
        p44cd4abe r153 = this.f8af308bf;
        r4.L$0 = this;
        r4.L$1 = r14;
        r4.fd304ba20 = 1;
        r152 = FVMAGDBwWZithplB(r153, r4);
        if (r152 != r02) goto L55;
    L62:
        return r02;
    L55:
        p9ded6185 r5 = r14;
        p4f30e9bd r154 = (p4f30e9bd) r152;
        p68086021 r12 = this.f56eabe9f;
        pd6d7c5a3 r13 = FTdVBCYguINmnQqv(r5, ZMybxNJzBVETkZGv(r154), tZHJZhRLPsttaNQt(r154), PFiMLAGaNwuIXTQD(r154), MEGYKUtMjGnxaPOs(r154), dHDPHPhXjBISANkU(), uwlBHnLvwgLFDcqg());
        r4.L$0 = null;
        r4.L$1 = null;
        r4.fd304ba20 = 2;
        if (aAxdRwaSqSGrXshs(r12, r13, false, r4, 2, null) == r02) goto L62;
    L95:
        return Unit.INSTANCE;
    L86:
        if (r1 == 1) goto L37;
        if (r1 != 2) goto L21;
        YOlizbAvnLtbXvms(r152);
        goto L95
    L21:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L37:
        r14 = (p9ded6185) r4.L$1;
        p75adeb22 this = (p75adeb22) r4.L$0;
        aLOuxjbKGrGPHDrX(r152);
        goto L55
    L8:
        r0 = (p75adeb22$p8307c351$1) r15;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L41;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L89
    }

    public static int MHRbCIDyuwaRRDfH() {
        return p728cd16b.mfb101d56();
    }

    public static readonly /* synthetic */ object ma6baaec9(p75adeb22 r0, p9ded6185 r1, Continuation r2) {
        return UXLRcUbqmzifsCKV(r0, r1, r2);
    }

    public static readonly /* synthetic */ object md469c337(p75adeb22 r0, p9ded6185 r1, Continuation r2) {
        return QOqwmEfEImRVJrlL(r0, r1, r2);
    }

    private readonly object Mdddc363b(p9ded6185 r6, Continuation<Unit> r7) {
        if (((16 + 21) % 21) > 0) goto L13;
    L13:
        if ((r7 is p75adeb22$pdddc363b$1) == false) goto L57;
        p75adeb22$pdddc363b$1 r0 = (p75adeb22$pdddc363b$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L57;
        r0.fd304ba20 -= int.MIN_VALUE;
    L10:
        object r72 = r0.fb4a88417;
        object r1 = yZZKzPToCgUupjDI();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L81;
        rXJIvDeIrhavZmUv(r72);
        if ((r6 is ped663a3e) == false) goto L41;
        p3851083a r5 = this.f91b5f5ab;     // Catch: Exception -> L55
        r0.fd304ba20 = 1;     // Catch: Exception -> L55
        if (PtQMdiLQviYJLzpW(r5, r0) != r1) goto L11;
    L44:
        return r1;
    L11:
        return Unit.INSTANCE;
    L41:
        if ((r6 is p18cf5223) == false) goto L54;
        p24ddebba r52 = this.f78129a46;     // Catch: Exception -> L55
        r0.fd304ba20 = 2;     // Catch: Exception -> L55
        if (wqFSLVxoEQEWHUWr(r52, r0) != r1) goto L11;
    L54:
        return Unit.INSTANCE;
    L81:
        if (r2 != 1) goto L27;
    L19:
        suNzyFHQYhCAGXgP(r72);     // Catch: Exception -> L55
        goto L11
    L27:
        if (r2 == 2) goto L19;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L55:
        e = move-exception;
        bwizwhNEPUiWOHLQ(e);
        UprNHxurDlyQwTQd(zMshInkLWPyEFXXL(), e);
    L57:
        r0 = new p75adeb22$pdddc363b$1(this, r7);
        goto L10
    }

    private readonly object Me9892eb1(p9ded6185 r39, string r40, Continuation<Unit> r41) {
        if (((31 + 28) % 28) > 0) goto L54;
    L54:
        if ((r41 is p75adeb22$pe9892eb1$1) == true) goto L24;
    L19:
        p75adeb22$pe9892eb1$1 r4 = new p75adeb22$pe9892eb1$1(this, r41);
    L7:
        object r3 = r4.fb4a88417;
        object r5 = XhoERCTemlTfoGUV();
        int r6 = r4.fd304ba20;
        if (r6 != 0) goto L75;
        occjFZecdRjUWNQM(r3);
        if ((r39 is ped663a3e) == false) goto L65;
        p7638dcb8 r0 = this.ff2fed930;     // Catch: Exception -> L31
        ped663a3e r1 = HxcpqlndrXzyOaTY((ped663a3e) r39, null, null, null, null, null, null, null, null, null, false, null, null, null, null, null, null, pd751e33c.fd0749aab, null, null, null, null, null, null, false, null, null, 67043327, null);     // Catch: Exception -> L31
        r4.fd304ba20 = 1;     // Catch: Exception -> L31
        if (PjcAYSDCCptnwQWR(r0, r1, r40, r4) != r5) goto L34;
    L68:
        return r5;
    L34:
        return Unit.INSTANCE;
    L65:
        if ((r39 is p18cf5223) == false) goto L30;
        p24ddebba r02 = this.f78129a46;     // Catch: Exception -> L31
        p18cf5223 r12 = YPfeVoXxpzLUujas((p18cf5223) r39, null, null, null, null, null, null, null, null, null, false, null, null, null, null, null, null, pd751e33c.fd0749aab, null, null, null, null, null, null, null, null, null, 67043327, null);     // Catch: Exception -> L31
        r4.fd304ba20 = 2;     // Catch: Exception -> L31
        if (LOfPutplJURBgOHa(r02, r12, r40, r4) != r5) goto L34;
    L30:
        return Unit.INSTANCE;
    L75:
        if (r6 != 1) goto L82;
    L12:
        MtFwWdbvrWByspWH(r3);     // Catch: Exception -> L31
        goto L34
    L82:
        if (r6 == 2) goto L12;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L31:
        e = move-exception;
        IXYmKcEAywGDfTck(e);
        kKAfwVBjPJTGaOtD(agVOBCjTpLFEboJS(), e);
        goto L34
    L24:
        r4 = (p75adeb22$pe9892eb1$1) r41;
        if ((r4.fd304ba20 & int.MIN_VALUE) == 0) goto L19;
        r4.fd304ba20 -= int.MIN_VALUE;
        goto L7
    }

    public static readonly /* synthetic */ object med99ee84(p75adeb22 r0, p9ded6185 r1, string r2, Continuation r3) {
        return iVkPcSjIzrEsHapu(r0, r1, r2, r3);
    }

    private readonly List<p1b7a5668> Mfa472504(List<pd031d465> r5) {
        if (((16 + 19) % 19) > 0) goto L12;
    L12:
        List<pd031d465> r52 = r5;
        List r4 = new List();
        IEnumerator r53 = SaKkBgpyIVtniwXA(r52);
    L23:
        if (QCUIVPPNvKXXkjFG(r53) == false) goto L31;
        pd031d465 r0 = (pd031d465) dlYyaLCWLALAyPEM(r53);
        string r1 = stxtgcBIXUDJAjic(r0);
        if (r1 is not null) goto L4;
        p1b7a5668 r2 = null;
    L43:
        if (r2 is null) goto L23;
        XOSuoIMepjPylhAI(r4, r2);
        goto L23
    L4:
        decimal r02 = ctobQlNAjzmzNbxM(KgsYzysCaxCWGHZI(r0));
        ZwYpbchlbnoXHARc(r02, "negate(...)");
        r2 = new p1b7a5668(r1, r02);
        goto L43
    L31:
        return r4;
    }

    public static string MjjnsPPVgeJgwQNL(p4f30e9bd r1) {
        return r1.getDeviceUUid();
    }

    public static void NCHpCdduppCUhhhS(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static void NbOdfBvoTPutxBrt(p13d58ddc r0, p8c261c90 r1, string r2, string r3, string r4) {
        r0.fiscalizeReceipt(r1, r2, r3, r4);
    }

    public static void NeTyqXCssQsvKAvd(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static IEnumerator NluKZKdCAAbdXmit(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static void OTHpouVUausemOZu(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void OccjFZecdRjUWNQM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object OeQECmqcldBGfaem(p7638dcb8 r1, ped663a3e r2, string r3, Continuation r4) {
        return r1.saveQueueSellReceipt(r2, r3, r4);
    }

    public static List OhRqiyAkIuMemQsH(p75adeb22 r1, List r2) {
        return r1.m1958f08c(r2);
    }

    public static void OiHGSvJfninLnSxB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object OuTjOYoHjtSombGZ(p68086021 r1, pd6d7c5a3 r2, bool r3, Continuation r4, int r5, object r6) {
        return p68086021.pb0da8397.m581aeacb(r1, r2, r3, r4, r5, r6);
    }

    public static object OyqZMjFJPqVfHQCL(p24ddebba r1, string r2, Continuation r3) {
        return r1.checkDuplicateReceipt(r2, r3);
    }

    public static void PidLQMDYYmsKFtWX(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string PjswYIscQMEgAFiU(p22820a6f r1) {
        return r1.name();
    }

    public static object QMMRTrvGEyATjOun(p6d73504b r1, List r2, Continuation r3) {
        return r1.replaceCommoditiesQuantity(r2, r3);
    }

    public static p22820a6f QyQQdAkULpkwLMne(p9ded6185 r1) {
        return r1.getReceiptType();
    }

    public static decimal QysLHsZpJEcIluYi(pd031d465 r1) {
        return r1.getPurchasePrice();
    }

    public static void RXJIvDeIrhavZmUv(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool RblQhgkEZgJLBHdX(Atomicbool r1, bool r2, bool r3) {
        return r1.compareAndHashSet(r2, r3);
    }

    public static object SGJPoFIQfghjmclD(p3851083a r1, string r2, Continuation r3) {
        return r1.checkDuplicateReceipt(r2, r3);
    }

    public static void SPZJGKWBIfJodija(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string StxtgcBIXUDJAjic(pd031d465 r1) {
        return r1.getCommodityId();
    }

    public static void SuNzyFHQYhCAGXgP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object TEypHCiguNkWCgXu() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static long TIuMLnUOsPSJcyey() {
        if (((18 + 4) % 4) > 0) goto L4;
    L4:
        return p728cd16b.mc863d45c();
    }

    public static decimal TIwaINMHOefmRTcn(pd031d465 r1) {
        return r1.getQuantity();
    }

    public static void TXzfCETZteemGLhd(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string TZHJZhRLPsttaNQt(p4f30e9bd r1) {
        return r1.getDeviceUUid();
    }

    public static object TiEYcWJYNpIpEWkF() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string TnQwQnGKmiFYMFkc(ped663a3e r1) {
        return r1.getUuid();
    }

    public static p18cf5223 TwewjTUyZwImUFRP(p18cf5223 r1, string r2, string r3, p22820a6f r4, int r5, List r6, string r7, string r8, p8c261c90 r9, List r10, bool r11, p5a409c20 r12, string r13, string r14, string r15, pc5f0acf1 r16, DateTime r17, pd751e33c r18, string r19, string r20, decimal r21, decimal r22, string r23, string r24, List r25, decimal r26, p471052f5 r27, int r28, object r29) {
        return p18cf5223.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29);
    }

    public static List UHvGctdFiIxYdxPX(p75adeb22 r1, List r2) {
        return r1.m816bcbd7(r2);
    }

    public static int UwlBHnLvwgLFDcqg() {
        return p728cd16b.mfb101d56();
    }

    public static object VAGnzmtPqUsaHgRf(p75adeb22 r1, p9ded6185 r2, string r3, Continuation r4) {
        return r1.m4d0efa5d(r2, r3, r4);
    }

    public static string VPWUNdXiQTBDbDyy(p22820a6f r1) {
        return r1.name();
    }

    public static void VWjhwxjMUCkOQmAs(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool VXMGLFIWwWWzwUDl(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static p8c261c90 VfyrylqyvVMOxHlB(p9ded6185 r1) {
        return r1.getPaymentType();
    }

    public static string WCrjPtUuWKWXKxmp(p4f30e9bd r1) {
        return r1.getShopId();
    }

    public static void WlYnFPrwnmLbmDqd(p13d58ddc r0, p8c261c90 r1, string r2, string r3, string r4) {
        r0.saveReceiptToQueueError(r1, r2, r3, r4);
    }

    public static object WqFSLVxoEQEWHUWr(p24ddebba r1, Continuation r2) {
        return r1.removeCurrentReceipt(r2);
    }

    public static void WyIVFsQvfSHPnoJn(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string XJakzxEaQCMHUQWi(p9ded6185 r1) {
        return r1.getUuid();
    }

    public static string YJCWXLwGkeLqPApn(pd031d465 r1) {
        return r1.getCommodityId();
    }

    public static object YZZKzPToCgUupjDI() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void YerEWAuxJKOCXEmi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void YjsrqOEYKzVzbbkG(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static FirebaseCrashlytics ZMshInkLWPyEFXXL() {
        return FirebaseCrashlytics.getInstance();
    }

    public static object ZjXOCnDiaWYTIBcG(p44cd4abe r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static List ZkQQCEiQkublNCsx(pa006dee7 r1) {
        return r1.getPositions();
    }

    public static object ZsyKLcWTAsWjkzna(p6d73504b r1, List r2, Continuation r3) {
        return r1.updateCommoditiesQuantity(r2, r3);
    }

    @Override // pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1
    public object ResendReceipt(p9ded6185 r18, string r19, Continuation<Unit> r20) {
        if (((11 + 3) % 3) > 0) goto L61;
    L61:
        p75adeb22 r0 = this;
        if ((r20 is p75adeb22$pf011ec35$1) == true) goto L90;
    L41:
        p75adeb22$pf011ec35$1 r2 = new p75adeb22$pf011ec35$1(r0, r20);
    L89:
        object r1 = r2.fb4a88417;
        object r3 = JHMfZFIoDrPJbwuZ();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L70;
        HNFcguSpHHUCZrZn(r1);
        p44cd4abe r12 = r0.f8af308bf;
        r2.L$0 = r0;
        r2.L$1 = r18;
        r2.fd304ba20 = 1;
        r1 = TLJbaGdRdOpqRmPW(r12, r2);
        if (r1 == r3) goto L44;
        p9ded6185 r9 = r18;
    L35:
        p4f30e9bd r13 = (p4f30e9bd) r1;
        p68086021 r42 = r0.f56eabe9f;
        pd6d7c5a3 r14 = exXutPMtaxTItFcM(r9, PVcHqwVjmmNYgUDY(r13), mjjnsPPVgeJgwQNL(r13), kDOYyYxAECFAuaaC(r13), aZyRrLzEkDUpPPqs(r13), BkTYtkUYCnCJyVMi(), exeOEopOqRkJlump());
        r2.L$0 = r0;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (LcRcqDHyNVXJMgvH(r42, r14, true, r2) == r3) goto L44;
    L110:
        p883b57c7 r02 = r0.f395bf4d9;
        r2.L$0 = null;
        r2.fd304ba20 = 3;
        if (JPLpHoOYqLYIoarV(r02, r2) == r3) goto L44;
    L76:
        return Unit.INSTANCE;
    L44:
        return r3;
    L70:
        if (r4 == 1) goto L48;
        if (r4 == 2) goto L32;
        if (r4 != 3) goto L49;
        XSLOvpqLeaqSOCBQ(r1);
        goto L76
    L49:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L32:
        r0 = (p75adeb22) r2.L$0;
        yjsrqOEYKzVzbbkG(r1);
        goto L110
    L48:
        p9ded6185 r03 = (p9ded6185) r2.L$1;
        p75adeb22 r43 = (p75adeb22) r2.L$0;
        PZaBrynzpnzYmQUF(r1);
        r9 = r03;
        r0 = r43;
        goto L35
    L90:
        r2 = (p75adeb22$pf011ec35$1) r20;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L41;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L89
    }

    /* JADX WARN: Multi-variable type inference failed */
    @Override // pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1
    public object SaveQueueReceiptToDb(p9ded6185 r43, string r44, string r45, Continuation<Unit> r46) {
        if (((18 + 4) % 4) > 0) goto L80;
    L80:
        p75adeb22 r1 = this;
        p9ded6185 r2 = r43;
        string r3 = r45;
        if ((r46 is p75adeb22$p812699ae$1) == true) goto L145;
    L136:
        p75adeb22$p812699ae$1 r5 = new p75adeb22$p812699ae$1(r1, r46);
    L104:
        object r4 = r5.fb4a88417;
        object r6 = FwduUGbDxvgCHiii();
        int r7 = r5.fd304ba20;
        if (r7 != 0) goto L167;
        YDvxrPvISNPZVFYn(r4);
        TmPbbxYxTmMpeJvH(r1.f68c4283d, GnnrgmzjZJhHqxzy(r2), ieudOdZkDQejazGp(r2), r3, SvwGXHrSAIMYrCHE(qyQQdAkULpkwLMne(r2)));     // Catch: Exception -> L95
        if ((r2 is ped663a3e) == false) goto L18;
        p7638dcb8 r42 = r1.ff2fed930;     // Catch: Exception -> L95
        ped663a3e r72 = WoBnsrGHfPduOedX((ped663a3e) r2, null, null, null, null, null, null, null, null, null, false, null, null, null, null, null, null, pd751e33c.fd0749aab, null, null, null, null, null, null, false, null, null, 67043327, null);     // Catch: Exception -> L95
        r5.L$0 = r1;     // Catch: Exception -> L95
        r5.L$1 = r2;     // Catch: Exception -> L95
        r5.L$2 = r3;     // Catch: Exception -> L95
        r5.fd304ba20 = 1;     // Catch: Exception -> L95
        p75adeb22 r12 = r1;
        object r32 = r3;
        if (oeQECmqcldBGfaem(r42, r72, r44, r5) == r6) goto L24;
    L14:
        p3851083a r0 = r12.f91b5f5ab;     // Catch: Exception -> L95
        r5.L$0 = r12;     // Catch: Exception -> L95
        r5.L$1 = r2;     // Catch: Exception -> L95
        r5.L$2 = r32;     // Catch: Exception -> L95
        r5.fd304ba20 = 2;     // Catch: Exception -> L95
        if (IJXPKixnRdlcOzLY(r0, r5) == r6) goto L24;
    L146:
        return Unit.INSTANCE;
    L24:
        return r6;
    L18:
        if ((r2 is p18cf5223) == false) goto L94;
        p24ddebba r47 = r1.f78129a46;     // Catch: Exception -> L95
        p18cf5223 r73 = twewjTUyZwImUFRP((p18cf5223) r2, null, null, null, null, null, null, null, null, null, false, null, null, null, null, null, null, pd751e33c.fd0749aab, null, null, null, null, null, null, null, null, null, 67043327, null);     // Catch: Exception -> L95
        r5.L$0 = r1;     // Catch: Exception -> L95
        r5.L$1 = r2;     // Catch: Exception -> L95
        r5.L$2 = r3;     // Catch: Exception -> L95
        r5.fd304ba20 = 3;     // Catch: Exception -> L95
        p75adeb22 r13 = r1;
        object r33 = r3;
        if (NVUcXPUndjIRckWC(r47, r73, r44, r5) == r6) goto L24;
    L22:
        p24ddebba r02 = r13.f78129a46;     // Catch: Exception -> L95
        r5.L$0 = r13;     // Catch: Exception -> L95
        r5.L$1 = r2;     // Catch: Exception -> L95
        r5.L$2 = r33;     // Catch: Exception -> L95
        r5.fd304ba20 = 4;     // Catch: Exception -> L95
        if (JCBCtiAFuIBTLiEf(r02, r5) != r6) goto L146;
    L94:
        return Unit.INSTANCE;
    L95:
        e = e;
    L109:
        wlYnFPrwnmLbmDqd(r1.f68c4283d, dKecRAmoDTxHzBQY(r2), RabtWCXHKoFqkJMv(r2), r3, vPWUNdXiQTBDbDyy(deJcWAOQfzCRKWzl(r2)));
        iuLeeobtnkiXGxXC(e);
        nCHpCdduppCUhhhS(cxQjGBTpVBCqsczI(), e);
        goto L146
    L167:
        if (r7 == 1) goto L4;
        if (r7 == 2) goto L67;
        if (r7 == 3) goto L153;
        if (r7 == 4) goto L133;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L133:
        string r14 = (string) r5.L$2;
        p9ded6185 r22 = (p9ded6185) r5.L$1;
        p75adeb22 r34 = (p75adeb22) r5.L$0;
    L101:
        RyLRddbRMRyoSgZY(r4);     // Catch: Exception -> L47
        goto L146
    L153:
        object r15 = (string) r5.L$2;
        r2 = (p9ded6185) r5.L$1;
        p75adeb22 r35 = (p75adeb22) r5.L$0;
        sPZJGKWBIfJodija(r4);     // Catch: Exception -> L47
        r33 = r15;
        r13 = r35;
        goto L22
    L67:
        string r16 = (string) r5.L$2;
        p9ded6185 r23 = (p9ded6185) r5.L$1;
        p75adeb22 r36 = (p75adeb22) r5.L$0;
        goto L101
    L4:
        object r17 = (string) r5.L$2;
        r2 = (p9ded6185) r5.L$1;
        p75adeb22 r37 = (p75adeb22) r5.L$0;
        JJNgaEMbKEyICMRa(r4);     // Catch: Exception -> L47
        r32 = r17;
        r12 = r37;
    L47:
        e = e;
        r3 = r1;
        r1 = r3;
        goto L109
    L145:
        r5 = (p75adeb22$p812699ae$1) r46;
        if ((r5.fd304ba20 & int.MIN_VALUE) == 0) goto L136;
        r5.fd304ba20 -= int.MIN_VALUE;
        goto L104
    }

    @Override // pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1
    public object SendReceipt(p9ded6185 r10, string r11, Continuation<Unit> r12) {
        if (((29 + 30) % 30) > 0) goto L235;
    L235:
        if ((r12 is p75adeb22$p807ee7c0$1) == true) goto L179;
    L212:
        p75adeb22$p807ee7c0$1 r0 = new p75adeb22$p807ee7c0$1(this, r12);
    L143:
        object r122 = r0.fb4a88417;
        object r1 = tEypHCiguNkWCgXu();
        switch(r0.fd304ba20) {
            case 0: goto L200;
            case 1: goto L28;
            case 2: goto L9;
            case 3: goto L148;
            case 4: goto L9;
            case 5: goto L56;
            case 6: goto L250;
            case 7: goto L9;
            case 8: goto L87;
            case 9: goto L9;
            default: goto L243;
        };
    L200:
        yerEWAuxJKOCXEmi(r122);
        if (rblQhgkEZgJLBHdX(this.f6520840d, false, true) == true) goto L47;
    L127:
        return Unit.INSTANCE;
    L47:
        EuUurxsavdfmejpd(this.f68c4283d, XZSRwiIDWSQFHaab(r10), xJakzxEaQCMHUQWi(r10), r11, ZnZCoviOzDfkSPGZ(ZEcefslrEFYRVVDi(r10)));
        if ((r10 is ped663a3e) == false) goto L39;
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.fd304ba20 = 1;
        if (vAGnzmtPqUsaHgRf(this, r10, r11, r0) == r1) goto L64;
    L182:
        p6d73504b r112 = this.f68dd5b56;
        List r102 = WBpeKCdTWaahdzYV(this, LYPHykpdHsFiDusE((ped663a3e) r10));
        r0.L$0 = this;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (UysOlVwtUgrZTdVl(r112, r102, r0) == r1) goto L64;
    L156:
        YQzcBZVToYMQTLQB(this.f6520840d, false);
    L64:
        return r1;
    L39:
        if ((r10 is p18cf5223) == false) goto L75;
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.fd304ba20 = 3;
        if (XxVPNuSTxAETYjzC(this, r10, r11, r0) == r1) goto L64;
    L171:
        p6d73504b r113 = this.f68dd5b56;
        List r103 = uHvGctdFiIxYdxPX(this, fmLZULjmoqhlxKcu((p18cf5223) r10));
        r0.L$0 = this;
        r0.L$1 = null;
        r0.fd304ba20 = 4;
        if (zsyKLcWTAsWjkzna(r113, r103, r0) == r1) goto L64;
    L75:
        if ((r10 is pa006dee7) == false) goto L10;
        pa006dee7 r114 = LiHLOHqPYhqAbzPX((pa006dee7) r10);
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.L$2 = r114;
        r0.fd304ba20 = 5;
        if (lIcAnkjajEBVyOku(this, r10, r0) == r1) goto L64;
    L163:
        pa006dee7 r115 = r114;
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.L$2 = null;
        r0.fd304ba20 = 6;
        if (WvPyYbFhLoMlpOiR(this, r115, r0) == r1) goto L64;
    L161:
        p6d73504b r116 = this.f68dd5b56;
        List r104 = ohRqiyAkIuMemQsH(this, zkQQCEiQkublNCsx((pa006dee7) r10));
        r0.L$0 = this;
        r0.L$1 = null;
        r0.fd304ba20 = 7;
        if (dNDKAncHHvxNoLsd(r116, r104, r0) == r1) goto L64;
    L10:
        if ((r10 is p3e0c0c49) == false) goto L37;
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.fd304ba20 = 8;
        if (AVCAVtOsZQlxQOTo(this, r10, r0) == r1) goto L64;
    L245:
        p6d73504b r117 = this.f68dd5b56;
        List r105 = cgUcTYhOjExOcNHl(this, laWFdkzIemytBoHT((p3e0c0c49) r10));
        r0.L$0 = this;
        r0.L$1 = null;
        r0.fd304ba20 = 9;
        if (qMMRTrvGEyATjOun(r117, r105, r0) == r1) goto L64;
    L37:
        throw new NoWhenBranchMatchedException();
    L148:
        r10 = (p9ded6185) r0.L$1;
        p75adeb22 this = (p75adeb22) r0.L$0;
        afkPWZuROUHuxrHD(r122);
        goto L171
    L28:
        r10 = (p9ded6185) r0.L$1;
        this = (p75adeb22) r0.L$0;
        vWjhwxjMUCkOQmAs(r122);
        goto L182
    L250:
        p9ded6185 r9 = (p9ded6185) r0.L$1;
        p75adeb22 r106 = (p75adeb22) r0.L$0;
        heYqYtcwecsurOZL(r122);
        r10 = r9;
        this = r106;
        goto L161
    L56:
        pa006dee7 r92 = (pa006dee7) r0.L$2;
        r10 = (p9ded6185) r0.L$1;
        p75adeb22 r118 = (p75adeb22) r0.L$0;
        tXzfCETZteemGLhd(r122);
        r114 = r92;
        this = r118;
        goto L163
    L243:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L9:
        this = (p75adeb22) r0.L$0;
        PtgYgPZaGDsHRJru(r122);
        goto L156
    L87:
        r10 = (p9ded6185) r0.L$1;
        this = (p75adeb22) r0.L$0;
        aLEIKrbhMhEFDKmm(r122);
        goto L245
    L179:
        r0 = (p75adeb22$p807ee7c0$1) r12;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L212;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L143
    }
}

