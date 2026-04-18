using Androidx.Lifecycle;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using P0c985ebf.P2486923a.P1e11b989;
using P0c985ebf.Pac143fb7;
using P0c985ebf.Pfd9160bb;
using P2b3583e6;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.P7a1eabc3;
using Pad5f82e8.Pac143fb7.P1e11b989;
using Pf3e08b51.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class p78015202 : objectModel {
    private readonly p4ee8dd59 f091cc433;
    private readonly MutableLiveData<pb532d556> f32930c38;
    private readonly MutableLiveData f3f2fdfe1;
    private readonly pf21d5ed1 f474d840d;
    private readonly MutableLiveData<List<pd031d465>> f5d3dfc4f;
    private readonly p02eb2260 f606b851a;
    private readonly p41e6ee8c f705d2cd0;
    private readonly p41e6ee8c f707626f7;
    private readonly pf21d5ed1 f7ea71ed5;
    private readonly pf21d5ed1 f895bb244;
    private readonly pf21d5ed1 faca0915b;
    private readonly p02eb2260 fc51f6822;
    private readonly p41e6ee8c fd03d340b;
    private readonly p02eb2260 fe38e01fc;
    private readonly p02eb2260 fe5f9a630;
    private readonly p4ee8dd59 fe9f2d35f;
    private readonly MutableLiveData fecad5a90;
    private readonly p02eb2260 ff9009811;

    public p78015202(pf21d5ed1 r2, p4ee8dd59 r3, p41e6ee8c r4, p02eb2260 r5) {
        rjGrfVnvvHLlyFNT(r2, "sendReceiptUseCase");
        gUoddBRJFzUHmWEe(r3, "inspectionUseCase");
        RdBnGsHrXNoiNKJD(r4, "inspectionRouter");
        diWoetxyZOAxjxGK(r5, "launcherRouter");
        this.f474d840d = r2;
        this.f091cc433 = r3;
        this.fd03d340b = r4;
        this.ff9009811 = r5;
        this.f32930c38 = new p6a6d86aa();
        this.f5d3dfc4f = new p6a6d86aa();
    }

    public static void LNampyMGfUAYVgXm(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static IEnumerator QlSagoMskeglndOq(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static Job RZJdzOtWuIWXyUvN(CoroutineScope r1, Coroutineobject r2, CoroutineStart r3, Function2 r4, int r5, object r6) {
        return BuildersKt.launch$default(r1, r2, r3, r4, r5, r6);
    }

    public static void RdBnGsHrXNoiNKJD(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static bool WCbxvezwXwbFAkeU(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static object YxGTvpByjVcfzbpT(IEnumerator r1) {
        return r1.Current;
    }

    public static void DiWoetxyZOAxjxGK(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object DtczBPwuaNEMPGMH(p78015202 r1, Continuation r2) {
        return r1.m974a8423(r2);
    }

    public static object EKnSQlzIwhHHvHST(p4ee8dd59 r1, List r2, Continuation r3) {
        return r1.updateInspectedPositions(r2, r3);
    }

    public static void FsNLUngXhEAudjPW(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void GUoddBRJFzUHmWEe(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void GbLlAUMxukQpoOyC(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void IonvBFTFlXxDdjQh(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static p5267f68e JWqSETFcMytfvUQQ(pd031d465 r1) {
        return r1.getCommodityPrice();
    }

    public static List KXzzhxCJmESOyLgW(p9ded6185 r1) {
        return r1.getPositions();
    }

    public static object LsEVyxBTmgINkkNf() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static readonly /* synthetic */ p02eb2260 m245216f0(p78015202 r0) {
        return r0.ff9009811;
    }

    public static readonly /* synthetic */ p41e6ee8c m26e218d3(p78015202 r0) {
        return r0.fd03d340b;
    }

    public static readonly /* synthetic */ p4ee8dd59 m4aee790e(p78015202 r0) {
        return r0.f091cc433;
    }

    public static readonly /* synthetic */ MutableLiveData m8dbe1e72(p78015202 r0) {
        return r0.f5d3dfc4f;
    }

    private readonly object M974a8423(Continuation<Unit> r26) {
        if (((18 + 31) % 31) > 0) goto L44;
    L44:
        if ((r26 is p78015202$p974a8423$1) == false) goto L83;
        p78015202$p974a8423$1 r2 = (p78015202$p974a8423$1) r26;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L83;
        r2.fd304ba20 -= int.MIN_VALUE;
    L79:
        object r1 = r2.fb4a88417;
        object r3 = lsEVyxBTmgINkkNf();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L41;
        if (r4 == 1) goto L36;
        if (r4 != 2) goto L63;
        gbLlAUMxukQpoOyC(r1);
    L109:
        return Unit.INSTANCE;
    L63:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L36:
        p4ee8dd59 r0 = (p4ee8dd59) r2.L$0;
        uHjqiUfNeaLNQBrg(r1);
    L65:
        List r12 = kXzzhxCJmESOyLgW((p9ded6185) r1);
        List r42 = new List(yXADGSnwCdGcfjFz(r12, 10));
        IEnumerator r13 = QlSagoMskeglndOq(r12);
    L116:
        if (WCbxvezwXwbFAkeU(r13) == false) goto L101;
        pd031d465 r7 = (pd031d465) YxGTvpByjVcfzbpT(r13);
        p5267f68e r6 = jWqSETFcMytfvUQQ(r7);
        if (r6 is null) goto L42;
        decimal r62 = nfxttLfFsqccUGFO(r6);
        if (r62 is null) goto L42;
    L60:
        decimal r10 = r62;
        xCWhqPbVcpsWBKhW(r10);
        xmEUnrkxInwTtinI(r42, oaFKysMIRLyMTmuq(r7, null, null, r10, null, null, 0, null, null, null, null, null, null, null, null, null, 32763, null));
    L42:
        r62 = decimal.ZERO;
        goto L60
    L101:
        List r43 = r42;
        r2.L$0 = null;
        r2.fd304ba20 = 2;
        if (eKnSQlzIwhHHvHST(r0, r43, r2) != r3) goto L109;
    L9:
        return r3;
    L41:
        ionvBFTFlXxDdjQh(r1);
        r0 = this.f091cc433;
        r2.L$0 = r0;
        r2.fd304ba20 = 1;
        r1 = zjAtjnOVspKdgRcL(r0, r2);
        if (r1 == r3) goto L9;
    L83:
        r2 = new p78015202$p974a8423$1(this, r26);
        goto L79
    }

    public static readonly /* synthetic */ pf21d5ed1 mbb30f96e(p78015202 r0) {
        return r0.f474d840d;
    }

    public static readonly /* synthetic */ object mc8e7b41d(p78015202 r0, Continuation r1) {
        return dtczBPwuaNEMPGMH(r0, r1);
    }

    public static readonly /* synthetic */ MutableLiveData mdbbe0d99(p78015202 r0) {
        return r0.f32930c38;
    }

    public static decimal NfxttLfFsqccUGFO(p5267f68e r1) {
        return r1.getPurchasePrice();
    }

    public static pd031d465 OaFKysMIRLyMTmuq(pd031d465 r1, string r2, decimal r3, decimal r4, string r5, string r6, int r7, decimal r8, decimal r9, string r10, string r11, pa1fa2777 r12, decimal r13, decimal r14, decimal r15, p5267f68e r16, int r17, object r18) {
        return pd031d465.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18);
    }

    public static CoroutineScope QafGpSPMirplioiK(objectModel r1) {
        return objectModelKt.getobjectModelScope(r1);
    }

    public static void RjGrfVnvvHLlyFNT(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static Job SyEZdQOBMWuHHeho(CoroutineScope r1, Coroutineobject r2, CoroutineStart r3, Function2 r4, int r5, object r6) {
        return BuildersKt.launch$default(r1, r2, r3, r4, r5, r6);
    }

    public static void UHjqiUfNeaLNQBrg(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void XCWhqPbVcpsWBKhW(object r0) {
        Intrinsics.checkNotNull(r0);
    }

    public static void XXJluZRlXpdLHJaZ(p41e6ee8c r0) {
        r0.back();
    }

    public static bool XmEUnrkxInwTtinI(ICollection r1, object r2) {
        return r1.Add(r2);
    }

    public static int YXADGSnwCdGcfjFz(IEnumerable r1, int r2) {
        return ICollectionsKt.collectionSizeOrDefault(r1, r2);
    }

    public static CoroutineScope ZHfYjXHRaHoVqZMH(objectModel r1) {
        return objectModelKt.getobjectModelScope(r1);
    }

    public static object ZjAtjnOVspKdgRcL(p4ee8dd59 r1, Continuation r2) {
        return r1.getInspectionReceipt(r2);
    }

    public readonly void GetPositions() {
        if (((10 + 2) % 2) > 0) goto L16;
    L16:
        syEZdQOBMWuHHeho(zHfYjXHRaHoVqZMH(this), null, null, new p78015202$pb694da19$1(this, null), 3, null);
    }

    public readonly LiveData<List<pd031d465>> ObserveInspectionPositions() {
        return this.f5d3dfc4f;
    }

    public readonly LiveData<pb532d556> ObserveNotificationState() {
        return this.f32930c38;
    }

    public readonly void OpenPreviousScreen() {
        xXJluZRlXpdLHJaZ(this.fd03d340b);
    }

    public readonly void SendReceipt(p013bab85.p0750a1fd r8, string r9) {
        if (((9 + 15) % 15) > 0) goto L17;
    L17:
        fsNLUngXhEAudjPW(r8, "currentState");
        LNampyMGfUAYVgXm(r9, "reason");
        RZJdzOtWuIWXyUvN(qafGpSPMirplioiK(this), null, null, new p78015202$p807ee7c0$1(r8, this, r9, null), 3, null);
    }
}

