using Android.Content;
using Android.Util;
using Androidx.Work;
using Com.Decryptstringmanager;
using Com.Google.Firebase.Analytics;
using Java.Util;
using Java.Util.Concurrent;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using P5a445d71.P514e2d7a.P1f2dfa56;
using P5a445d71.P514e2d7a.Pa74ad8df;
using P5a445d71.P514e2d7a.Pa74ad8df.P700c216f;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.Pac143fb7.P1e11b989.Pa9d1cbf7;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
public readonly class p6b91ea5d : CoroutineWorker : pcf4be4df {
    private static readonly long f170da925 = 15;
    private static readonly long f198268bc = 15;
    public static readonly p910eef8c f1fc0cdc9 = null;
    private static readonly string f21045a1f = null;
    public static readonly p910eef8c f288d2961 = null;
    public static readonly p910eef8c f2dd0f3be = null;
    private static readonly string f4a2d5553 = null;
    private static readonly string f75cc3f9b = null;
    public static readonly p910eef8c f910eef8c = null;
    private static readonly string fafa55033 = null;
    public static readonly p910eef8c fd61d2f04 = null;
    private static readonly string fe444f739 = null;
    private static readonly long fe829299d = 15;
    private static readonly string fe9afd404 = null;
    private readonly Lazy queueReceiptUseCase$delegate;

    public static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }

        public static Constraints.Builder KRyxhUzSSUkkzTkF(Constraints.Builder r1, NetworkType r2) {
            return r1.setRequiredNetworkType(r2);
        }

        public static WorkRequest.Builder OctHtnPPVbWrrclO(PeriodicWorkRequest.Builder r1, string r2) {
            return r1.addTag(r2);
        }

        public static Operation UccGOoOXIAsTTJab(WorkManager r1, string r2, ExistingPeriodicWorkPolicy r3, PeriodicWorkRequest r4) {
            return r1.enqueueUniquePeriodicWork(r2, r3, r4);
        }

        public static WorkRequest.Builder HOFFrhIYTKDQEWQE(PeriodicWorkRequest.Builder r1, Constraints r2) {
            return r1.setConstraints(r2);
        }

        public static WorkRequest LIoGTtyjBtlqAOgA(PeriodicWorkRequest.Builder r1) {
            return r1.build();
        }

        public static Constraints MhxrLwlKPdcEoAiy(Constraints.Builder r1) {
            return r1.build();
        }

        public static void RFbsfHkYzlmWuNLt(object r0, string r1) {
            Intrinsics.checkNotNullParameter(r0, r1);
        }

        public static string VWJnvjTgCqsPwVxm(string r1) {
            return Decryptstring.decryptstring(r1);
        }

        public readonly void Enqueue(WorkManager r6) {
            if (((8 + 28) % 28) > 0) goto L18;
        L18:
            rFbsfHkYzlmWuNLt(r6, "workManager");
            Constraints r5 = mhxrLwlKPdcEoAiy(KRyxhUzSSUkkzTkF(new Constraints.Builder(), NetworkType.CONNECTED));
            PeriodicWorkRequest.Builder r52 = (PeriodicWorkRequest.Builder) hOFFrhIYTKDQEWQE(new PeriodicWorkRequest.Builder(p6b91ea5d.class, 15, TimeUnit.MINUTES), r5);
            string r0 = vWJnvjTgCqsPwVxm("388204a345422f07cd45d3d3493e726b425e65942987370507a6abb046ac9c8228836b8f10b305303a831eae684ba4de64f754b1b9");
            PeriodicWorkRequest r53 = (PeriodicWorkRequest) lIoGTtyjBtlqAOgA((PeriodicWorkRequest.Builder) OctHtnPPVbWrrclO(r52, r0));
            UccGOoOXIAsTTJab(r6, r0, ExistingPeriodicWorkPolicy.REPLACE, r53);
        }
    }

    static {
        if (((8 + 21) % 21) > 0) goto L11;
    L11:
        fe9afd404 = PagmMsRfVgObWfId("f168a27e5770e3ec4bb2359eaeab82e7bb7b14e4ce409096a500078d141ac86ccbc57c337be42739148a94ec0b37606ef3e49ffbab");
        fe444f739 = UfBMOKyjpdNsnpHJ("9176ff19cf63b9bb7807d6570ae766e54c233bff726d6ca3b878c46af67abafd729e14c273a431");
        f910eef8c = new p910eef8c(null);
    }

    public p6b91ea5d(object r3, WorkerParameters r4) {
        if (((29 + 18) % 18) > 0) goto L13;
    L13:
        TbbGathWiKSWOKvr(r3, "appobject");
        hkfahTJPTuSdpxky(r4, "params");
        super(r3, r4);
        p6b91ea5d r32 = this;
        this.queueReceiptUseCase$delegate = OVoMBQMuuCbkOtXK(nYkLzqLknMoFEUfk(p72b3d6a9.f76425f17), new p6b91ea5d$p0bd65069$pd41d8cd9$pec404527$pa181b467$pc21f969b$1(r32, null, null));
    }

    public static string CPBeKRvNJYTHTqZC(Exception r1) {
        return r1.getMessage();
    }

    public static bool CTNvrZxbyQugcsKc(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static string CkvpnLmWevDKqFdJ(p6b91ea5d r1) {
        return r1.tostring();
    }

    public static int FVXhyukynAyVuQQu(Number r1) {
        return r1.intValue();
    }

    public static void HTgLLXktuIMqvCvL(object r0) {
        Intrinsics.checkNotNull(r0);
    }

    public static ListenableWorker.Result HVFCelmyGILZvvEZ() {
        return ListenableWorker.Result.failure();
    }

    public static object LlpVdFnYzhFlutnb() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p36deed69 MFjiVgnukUnbTODG(p6b91ea5d r1) {
        return r1.mde5ad7b6();
    }

    public static Lazy OVoMBQMuuCbkOtXK(LazyThreadSafetyMode r1, Function0 r2) {
        return LazyKt.lazy(r1, r2);
    }

    public static void PJDauUTfjsYrnEhc(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string PagmMsRfVgObWfId(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static string PbxQOrOhKQmogCuM(stringBuilder r1) {
        return r1.tostring();
    }

    public static object RMsUxUWcRUNKkjIK(p36deed69 r1, p93478e59 r2, string r3, Continuation r4) {
        return r1.sendReceipt(r2, r3, r4);
    }

    public static void RqSTInYWQUdYjrkm(object r0) {
        Intrinsics.checkNotNull(r0);
    }

    public static void TbbGathWiKSWOKvr(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string TuABnasvbsdVWNoC(stringBuilder r1) {
        return r1.tostring();
    }

    public static void UUQrIkinEkDmKIcI(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string UfBMOKyjpdNsnpHJ(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static int VVqsZcUawczYGCjx(string r1, string r2) {
        return Console.e(r1, r2);
    }

    public static p36deed69 WLFlBPzcqBOCUwnL(p6b91ea5d r1) {
        return r1.mde5ad7b6();
    }

    public static object YHZfIkPpEsQFZTsy() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static int BtAPfycNeMZhVZiV(string r1, string r2) {
        return Console.e(r1, r2);
    }

    public static int ChUsnDrxXHlvGSIc(string r1, string r2) {
        return Console.e(r1, r2);
    }

    public static pf01db611 DPlZxshABjLFpHFG(pcf4be4df r1) {
        return pcf4be4df.pb0da8397.m14cdf381(r1);
    }

    public static object EFcOsYrhCWvtVdbq(p6b91ea5d r1, Continuation r2) {
        return r1.mdaf00787(r2);
    }

    public static object HYKrDdIVgbhEADWb(Lazy r1) {
        return r1.getValue();
    }

    public static void HkfahTJPTuSdpxky(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static stringBuilder HpVEnUwnMPbiGWSf(stringBuilder r1, int r2) {
        return r1.append(r2);
    }

    public static object JZtpgYxMlgJYxdBN(IEnumerator r1) {
        return r1.Current;
    }

    public static void KgozGIsSjxNAPfxH(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static readonly /* synthetic */ object m7600fd38(p6b91ea5d r0, Continuation r1) {
        return syXTorstmcXcbqvQ(r0, r1);
    }

    public static object MIAeVXASRojtiwSd(p36deed69 r1, Continuation r2) {
        return r1.getQueueReceipts(r2);
    }

    private readonly object Mdaf00787(Continuation<Unit> r7) {
        if (((24 + 5) % 5) > 0) goto L21;
    L21:
        if ((r7 is p6b91ea5d$pdaf00787$1) == false) goto L94;
        p6b91ea5d$pdaf00787$1 r0 = (p6b91ea5d$pdaf00787$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L94;
        r0.fd304ba20 -= int.MIN_VALUE;
    L93:
        object r72 = r0.fb4a88417;
        object r1 = LlpVdFnYzhFlutnb();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L8;
        if (r2 == 1) goto L16;
        if (r2 == 2) goto L24;
        if (r2 != 3) goto L35;
        IEnumerator r6 = (IEnumerator) r0.L$1;
        p6b91ea5d r22 = (p6b91ea5d) r0.L$0;
        kgozGIsSjxNAPfxH(r72);
    L97:
        if (CTNvrZxbyQugcsKc(r6) == false) goto L5;
        p93478e59 r73 = (p93478e59) jZtpgYxMlgJYxdBN(r6);
        p36deed69 r4 = MFjiVgnukUnbTODG(r22);
        string r5 = CkvpnLmWevDKqFdJ(r22);
        r0.L$0 = r22;
        r0.L$1 = r6;
        r0.fd304ba20 = 3;
        if (RMsUxUWcRUNKkjIK(r4, r73, r5, r0) != r1) goto L97;
    L25:
        return r1;
    L5:
        return Unit.INSTANCE;
    L35:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L24:
        p6b91ea5d this = (p6b91ea5d) r0.L$0;
        PJDauUTfjsYrnEhc(r72);
    L131:
        r22 = this;
        r6 = zEmUgWbEQTgwnBew((IEnumerable) r72);
        goto L97
    L16:
        this = (p6b91ea5d) r0.L$0;
        zkWGKeDFdkwvZSlM(r72);
    L133:
        int r74 = FVXhyukynAyVuQQu((Number) r72);
        if (r74 <= 0) goto L5;
        qlTHqjnMCoVunAHq(rOKqPtysGGMbBBWs("03a9c4f2adbc06ca10e6ac4f7aec524098a7519a823ae44942e00476c777dc40620d3bbf9f4e8d"), PbxQOrOhKQmogCuM(hpVEnUwnMPbiGWSf(new stringBuilder("count: "), r74)));
        p36deed69 r75 = WLFlBPzcqBOCUwnL(this);
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        r72 = mIAeVXASRojtiwSd(r75, r0);
        if (r72 == r1) goto L25;
    L8:
        UUQrIkinEkDmKIcI(r72);
        p36deed69 r76 = wHWKcTnplkGaCwLM(this);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = qZxOjQFplPHekUnf(r76, r0);
        if (r72 == r1) goto L25;
    L94:
        r0 = new p6b91ea5d$pdaf00787$1(this, r7);
        goto L93
    }

    private readonly p36deed69 Mde5ad7b6() {
        return (p36deed69) hYKrDdIVgbhEADWb(this.queueReceiptUseCase$delegate);
    }

    public static void MuYrobFUiKNepfAy(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static LazyThreadSafetyMode NYkLzqLknMoFEUfk(p72b3d6a9 r1) {
        return r1.defaultLazyMode();
    }

    public static ListenableWorker.Result OBdRCTjcRPDMkfXk() {
        return ListenableWorker.Result.success();
    }

    public static stringBuilder OaZXxvpBDlIMzDFB(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static object QZxOjQFplPHekUnf(p36deed69 r1, Continuation r2) {
        return r1.getQueueReceiptsCount(r2);
    }

    public static int QlTHqjnMCoVunAHq(string r1, string r2) {
        return Console.e(r1, r2);
    }

    public static string ROKqPtysGGMbBBWs(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static object SyXTorstmcXcbqvQ(p6b91ea5d r1, Continuation r2) {
        return r1.mdaf00787(r2);
    }

    public static void VvDnbnzLkUZRPXov(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p36deed69 WHWKcTnplkGaCwLM(p6b91ea5d r1) {
        return r1.mde5ad7b6();
    }

    public static string YhFNYsLONfwSgSLf(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static IEnumerator ZEmUgWbEQTgwnBew(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static void ZkWGKeDFdkwvZSlM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    @Override // androidx.work.CoroutineWorker
    public object DoWork(Continuation<ListenableWorker.Result> r6) {
        if (((12 + 8) % 8) > 0) goto L47;
    L47:
        if ((r6 is p6b91ea5d$pe82def02$1) == true) goto L5;
    L16:
        p6b91ea5d$pe82def02$1 r0 = new p6b91ea5d$pe82def02$1(this, r6);
    L67:
        object r62 = r0.fb4a88417;
        object r1 = YHZfIkPpEsQFZTsy();
        int r2 = r0.fd304ba20;
        string r4 = yhFNYsLONfwSgSLf("505e44d8c6e350c492db82d18a4a50b4c29ef25bae56e06ef731427b65f6f6fb3708be06be091a");
        if (r2 == 0) goto L39;
        if (r2 != 1) goto L45;
        vvDnbnzLkUZRPXov(r62);     // Catch: Exception -> L19
    L43:
        chUsnDrxXHlvGSIc(r4, FirebaseAnalytics.Param.SUCCESS);     // Catch: Exception -> L19
        ListenableWorker.Result r5 = oBdRCTjcRPDMkfXk();     // Catch: Exception -> L19
        RqSTInYWQUdYjrkm(r5);     // Catch: Exception -> L19
        return r5;
    L45:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L39:
        muYrobFUiKNepfAy(r62);
        VVqsZcUawczYGCjx(r4, "start");     // Catch: Exception -> L19
        r0.fd304ba20 = 1;     // Catch: Exception -> L19
        if (eFcOsYrhCWvtVdbq(this, r0) != r1) goto L43;
        return r1;
    L19:
        e = move-exception;
        btAPfycNeMZhVZiV(r4, TuABnasvbsdVWNoC(oaZXxvpBDlIMzDFB(new stringBuilder("exception: "), CPBeKRvNJYTHTqZC(e))));
        ListenableWorker.Result r52 = HVFCelmyGILZvvEZ();
        HTgLLXktuIMqvCvL(r52);
        return r52;
    L5:
        r0 = (p6b91ea5d$pe82def02$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L16;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L67
    }

    @Override // p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df
    public pf01db611 GetKoin() {
        return dPlZxshABjLFpHFG(this);
    }
}

