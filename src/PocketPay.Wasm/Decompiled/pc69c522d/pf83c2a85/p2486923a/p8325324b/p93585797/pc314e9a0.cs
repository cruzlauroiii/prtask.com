using Androidx.Lifecycle;
using Com.Google.Firebase.Crashlytics;
using Domain.Entities;
using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using P2b3583e6;
using P8325324b.Pac143fb7;
using P8325324b.Pfd9160bb;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.Pac143fb7.P1e11b989;
using Pc69c522d.Pf83c2a85.Pac143fb7;
using Pc69c522d.Pf83c2a85.Pfd9160bb;
using Pe0212e54.Pac143fb7;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class pc314e9a0 : objectModel {
    private p3a5cb279 f0700fffe;
    private readonly MutableLiveData f0a6402ed;
    private readonly MutableLiveData<ped663a3e> f159455b4;
    private p3a5cb279 f19e85445;
    private readonly p4b8940c0 f1e485821;
    private readonly p4b8940c0 f20d93db5;
    private readonly pc32333e1 f2397b504;
    private readonly pab691ef3 f249dce1b;
    private p3a5cb279 f2645324a;
    private readonly MutableLiveData f34ea0936;
    private readonly pab691ef3 f3df876a2;
    private readonly pf21d5ed1 f474d840d;
    private readonly pab691ef3 f48b580d8;
    private readonly MutableLiveData f4aa8f412;
    private readonly pc32333e1 f4cc6a9fe;
    private readonly p0bfd7fb7 f4fbdeb9c;
    private readonly p4b8940c0 f558879da;
    private readonly MutableLiveData f58b649ea;
    private p3a5cb279 f5a4f0fc5;
    private readonly p5fa140e9 f5df17e75;
    private readonly p0bfd7fb7 f64c2e955;
    private readonly p0bfd7fb7 f656c88ab;
    private readonly pc32333e1 f7cb58346;
    private readonly MutableLiveData<Event<ped663a3e>> f95ceb8d2;
    private readonly p5fa140e9 f9817bc27;
    private readonly p5fa140e9 f9820de24;
    private readonly p4b8940c0 f9adb7c0c;
    private readonly MutableLiveData f9e81c870;
    private readonly pc32333e1 fad31528b;
    private readonly p0bfd7fb7 fb21367f6;
    private readonly p5fa140e9 fb50d47d2;
    private readonly MutableLiveData fb5b312f8;
    private readonly pf21d5ed1 fb8fc0475;
    private readonly p5fa140e9 fbe98d71a;
    private readonly pab691ef3 fbfec8a6f;
    private readonly MutableLiveData fc633aeb5;
    private p3a5cb279 fcae1d338;
    private readonly pf21d5ed1 fcc8184d5;
    private readonly p4b8940c0 fda1713fa;
    private readonly p0bfd7fb7 fefeb7ff1;
    private readonly pc32333e1 ff3395cd5;
    private readonly pab691ef3 ffceec28b;

    public pc314e9a0(pab691ef3 r2, pf21d5ed1 r3, p0bfd7fb7 r4, p4b8940c0 r5, pc32333e1 r6, p5fa140e9 r7) {
        lvlpWdFxUcZflhDr(r2, "sellComboUseCase");
        kpfEZbCRycJWybxY(r3, "sendReceiptUseCase");
        RnmeEiQKjbbxFHAP(r4, "sellReceiptUseCase");
        RlohwlJJAVUEgDbp(r5, "devicesUseCase");
        wYPJlLNSVPnxbkCR(r6, "router");
        jYWjWkrMyXmwcNxZ(r7, "sellRouter");
        this.ffceec28b = r2;
        this.f474d840d = r3;
        this.f656c88ab = r4;
        this.fda1713fa = r5;
        this.ff3395cd5 = r6;
        this.f9817bc27 = r7;
        this.f159455b4 = new MutableLiveData();
        this.f95ceb8d2 = new p6a6d86aa();
        this.f5a4f0fc5 = p3a5cb279.f06972acc;
    }

    public static object CnWKuWCkBZvNrKNH(pc314e9a0 r1, Continuation r2) {
        return r1.m807ee7c0(r2);
    }

    public static pa4ecfc70 DIKleswOsDnGFpAi(pa4ecfc70.p910eef8c r1, object r2) {
        return r1.success(r2);
    }

    public static CoroutineScope DyParsGCsGGRjZac(objectModel r1) {
        return objectModelKt.getobjectModelScope(r1);
    }

    public static int HXqVHFbRpYfoSokR(decimal r1, decimal r2) {
        return r1.compareTo(r2);
    }

    public static void IpDeJtsztkZInAkh(p5fa140e9 r0, p9ded6185 r1) {
        r0.replaceSellReceiptSuccessfullySent(r1);
    }

    public static void JOnXymSDuwJgYtXD(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void LvpojgFePdPDkiJK(pc32333e1 r0) {
        r0.back();
    }

    public static void OyMdxeuvNxeydRzi(MutableLiveData r0, object r1) {
        r0.postValue(r1);
    }

    public static void QPxMdTzhAQtulAYK(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void RlohwlJJAVUEgDbp(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void RnmeEiQKjbbxFHAP(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static CoroutineScope TPLEIgxlqVsWeQPz(objectModel r1) {
        return objectModelKt.getobjectModelScope(r1);
    }

    public static void UHzJDItNATyJCpsW(p5fa140e9 r0) {
        r0.replaceSendSellReceiptError();
    }

    public static void VsaamDEwNsdgaimh(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static Job WIGvNcRPcyzZMoMx(CoroutineScope r1, Coroutineobject r2, CoroutineStart r3, Function2 r4, int r5, object r6) {
        return BuildersKt.launch$default(r1, r2, r3, r4, r5, r6);
    }

    public static void ZZZulYuXvGhatWbw(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void CaChWFGTozHzdhPo(MutableLiveData r0, object r1) {
        r0.postValue(r1);
    }

    public static string CylaSXsrfsGjbGaQ(pc314e9a0 r1) {
        return r1.tostring();
    }

    public static CoroutineScope DdtaRBUaRAMOOWMw(objectModel r1) {
        return objectModelKt.getobjectModelScope(r1);
    }

    public static void FVkRsLPNcHyysxSv(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object IpTCocKbhbnyLPSK(pf21d5ed1 r1, p9ded6185 r2, string r3, Continuation r4) {
        return r1.sendReceipt(r2, r3, r4);
    }

    public static void JYWjWkrMyXmwcNxZ(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static pa4ecfc70 JirzodoIkGiWPqGc(pa4ecfc70.p910eef8c r1) {
        return r1.loading();
    }

    public static FirebaseCrashlytics JyYvAtEkcoZZMMrR() {
        return FirebaseCrashlytics.getInstance();
    }

    public static void KpfEZbCRycJWybxY(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void LvlpWdFxUcZflhDr(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static readonly /* synthetic */ pab691ef3 m1d7af725(pc314e9a0 r0) {
        return r0.ffceec28b;
    }

    public static readonly /* synthetic */ p0bfd7fb7 m260c792f(pc314e9a0 r0) {
        return r0.f656c88ab;
    }

    public static readonly /* synthetic */ object m6573bf9e(pc314e9a0 r0, Continuation r1) {
        return CnWKuWCkBZvNrKNH(r0, r1);
    }

    public static readonly /* synthetic */ p4b8940c0 m701d8e58(pc314e9a0 r0) {
        return r0.fda1713fa;
    }

    public static readonly /* synthetic */ pc32333e1 m74e3994c(pc314e9a0 r0) {
        return r0.ff3395cd5;
    }

    private readonly object M807ee7c0(Continuation<Unit> r7) {
        if (((8 + 29) % 29) > 0) goto L69;
    L69:
        if ((r7 is pc314e9a0$p807ee7c0$1) == false) goto L92;
        pc314e9a0$p807ee7c0$1 r0 = (pc314e9a0$p807ee7c0$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L92;
        r0.fd304ba20 -= int.MIN_VALUE;
    L79:
        object r72 = r0.fb4a88417;
        object r1 = yDJPFaEUaqtEaoMB();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L77;
        if (r2 == 1) goto L87;
        if (r2 == 2) goto L11;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L11:
        ped663a3e r6 = (ped663a3e) r0.L$1;
        pc314e9a0 r02 = (pc314e9a0) r0.L$0;
        ZZZulYuXvGhatWbw(r72);     // Catch: Exception -> L33
        ped663a3e r73 = r6;
        pc314e9a0 this = r02;
    L52:
        OyMdxeuvNxeydRzi(this.f95ceb8d2, DIKleswOsDnGFpAi(pa4ecfc70.f910eef8c, r73));     // Catch: Exception -> L36
    L99:
        return Unit.INSTANCE;
    L33:
        Exception e = e;
    L12:
        Exception r62 = e;
        caChWFGTozHzdhPo(r02.f95ceb8d2, nklImpfOlbErFauP(pa4ecfc70.f910eef8c, r62));
        oANWXIvpmqOPXTKC(jyYvAtEkcoZZMMrR(), r62);
        goto L99
    L87:
        this = (pc314e9a0) r0.L$0;
        xvwcyNKpwsBUOuDW(r72);     // Catch: Exception -> L36
    L49:
        r73 = (ped663a3e) r72;     // Catch: Exception -> L36
        string r5 = cylaSXsrfsGjbGaQ(this);     // Catch: Exception -> L36
        r0.L$0 = this;     // Catch: Exception -> L36
        r0.L$1 = r73;     // Catch: Exception -> L36
        r0.fd304ba20 = 2;     // Catch: Exception -> L36
        if (ipTCocKbhbnyLPSK(this.f474d840d, r73, r5, r0) != r1) goto L52;
    L51:
        return r1;
    L77:
        JOnXymSDuwJgYtXD(r72);
        pJFSjGEXzqzokmXe(this.f95ceb8d2, jirzodoIkGiWPqGc(pa4ecfc70.f910eef8c));
        pab691ef3 r74 = this.ffceec28b;     // Catch: Exception -> L36
        r0.L$0 = this;     // Catch: Exception -> L36
        r0.fd304ba20 = 1;     // Catch: Exception -> L36
        r72 = pCphNvzxSdYpfhVB(r74, r0);     // Catch: Exception -> L36
        if (r72 != r1) goto L49;
    L36:
        e = move-exception;
        r02 = this;
        e = e;
    L92:
        r0 = new pc314e9a0$p807ee7c0$1(this, r7);
        goto L79
    }

    public static readonly /* synthetic */ pf21d5ed1 mbb30f96e(pc314e9a0 r0) {
        return r0.f474d840d;
    }

    public static readonly /* synthetic */ MutableLiveData mc5961be3(pc314e9a0 r0) {
        return r0.f159455b4;
    }

    public static readonly /* synthetic */ void mee67e975(pc314e9a0 r0, p3a5cb279 r1) {
        r0.f5a4f0fc5 = r1;
    }

    public static Job NRSvWPzHPaTXqYLJ(CoroutineScope r1, Coroutineobject r2, CoroutineStart r3, Function2 r4, int r5, object r6) {
        return BuildersKt.launch$default(r1, r2, r3, r4, r5, r6);
    }

    public static pa4ecfc70 NklImpfOlbErFauP(pa4ecfc70.p910eef8c r1, Exception r2) {
        return r1.error(r2);
    }

    public static void OANWXIvpmqOPXTKC(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static void OqMIfFywBxemTmys(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object PCphNvzxSdYpfhVB(pab691ef3 r1, Continuation r2) {
        return r1.getCurrentSellReceipt(r2);
    }

    public static void PJFSjGEXzqzokmXe(MutableLiveData r0, object r1) {
        r0.postValue(r1);
    }

    public static Job QhlbVKnsvGbCthYl(CoroutineScope r1, Coroutineobject r2, CoroutineStart r3, Function2 r4, int r5, object r6) {
        return BuildersKt.launch$default(r1, r2, r3, r4, r5, r6);
    }

    public static decimal UYvWSprmHSdsyGuf(decimal r1, decimal r2) {
        return r1.subtract(r2);
    }

    public static void VymBMxQaeLtXEKRq(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void WYPJlLNSVPnxbkCR(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void XvwcyNKpwsBUOuDW(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object YDJPFaEUaqtEaoMB() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public readonly void AddPaymentToReceipt(pad7c4a1f r9, decimal r10, bool r11) {
        if (((30 + 29) % 29) > 0) goto L13;
    L13:
        fVkRsLPNcHyysxSv(r10, "amount");
        qhlbVKnsvGbCthYl(DyParsGCsGGRjZac(this), null, null, new pc314e9a0$p89f84f65$1(this, r9, r10, r11, null), 3, null);
    }

    public readonly void GetCurrentSellReceipt() {
        if (((20 + 14) % 14) > 0) goto L6;
    L6:
        WIGvNcRPcyzZMoMx(ddtaRBUaRAMOOWMw(this), null, null, new pc314e9a0$p661f6c0a$1(this, null), 3, null);
    }

    public readonly bool IsFullAmount(decimal r1, decimal r2) {
        oqMIfFywBxemTmys(r1, "total");
        vymBMxQaeLtXEKRq(r2, "amount");
        decimal r0 = uYvWSprmHSdsyGuf(r1, r2);
        QPxMdTzhAQtulAYK(r0, "subtract(...)");
        if (HXqVHFbRpYfoSokR(r0, decimal.ZERO) <= 0) goto L3;
        return false;
    L3:
        return true;
    }

    public readonly LiveData<ped663a3e> ObserveCurrentSellReceipt() {
        return this.f159455b4;
    }

    public readonly LiveData<Event<ped663a3e>> ObserveSendReceipt() {
        return this.f95ceb8d2;
    }

    public readonly void OpenErrorScreen() {
        UHzJDItNATyJCpsW(this.f9817bc27);
    }

    public readonly void OpenPreviousScreen() {
        if (((1 + 18) % 18) > 0) goto L4;
    L4:
        if (this.f5a4f0fc5 == p3a5cb279.f06972acc) goto L14;
        return;
    L14:
        LvpojgFePdPDkiJK(this.ff3395cd5);
    }

    public readonly void OpenReceiptSentScreen(ped663a3e r2) {
        VsaamDEwNsdgaimh(r2, "receipt");
        IpDeJtsztkZInAkh(this.f9817bc27, r2);
    }

    public readonly void SaveQueueReceiptToDb() {
        if (((2 + 19) % 19) > 0) goto L6;
    L6:
        nRSvWPzHPaTXqYLJ(TPLEIgxlqVsWeQPz(this), null, null, new pc314e9a0$p812699ae$1(this, null), 3, null);
    }
}

