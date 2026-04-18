using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P8d777f38.Pb3f20355.Pd2a57dc1;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.Pac143fb7.P31a1fd14;
using Pad5f82e8.Pac143fb7.P49f290d6;
using Pad5f82e8.Pac143fb7.Pc1c16452;
using Pe0212e54.Pb3f20355;
using Pe0212e54.Pf5e638cc.P99e9bae6;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class pbbc980a3 : p4b8940c0 {
    private readonly p44cd4abe f0ba52fb9;
    private readonly pf698b4bd f1c78d74b;
    private readonly p71c7ae29 f21d6f40c;
    private readonly pf698b4bd f2226688f;
    private readonly p44cd4abe f2b7a0d90;
    private readonly p2f3c4196 f2b90dee1;
    private readonly p44cd4abe f31e9aa4b;
    private readonly p2f3c4196 f3418ecae;
    private readonly p71c7ae29 f4d064115;
    private readonly pf698b4bd f71d8c433;
    private readonly p44cd4abe f86eba9c8;
    private readonly p44cd4abe f8af308bf;
    private readonly p71c7ae29 f8bdc5233;
    private readonly p6d29e2ef f97e1f910;
    private readonly p6d29e2ef fa22fc7eb;
    private readonly p71c7ae29 fabb94529;
    private readonly p2f3c4196 fe639d08f;
    private readonly pf698b4bd feab592e9;

    public pbbc980a3(pf698b4bd r2, p44cd4abe r3, p6d29e2ef r4, p2f3c4196 r5, p71c7ae29 r6) {
        jgGjZKaaYpZOlFfq(r2, "marketDataUseCase");
        BbdaQbwaPClsrrRd(r3, "devicesRepository");
        ADGEXFtQYmCffdcP(r4, "applicationStateRepository");
        xAceiLGhFStKtwIe(r5, "userInfoUseCase");
        wwzFFfNCbFNoHmXm(r6, "session");
        this.feab592e9 = r2;
        this.f8af308bf = r3;
        this.f97e1f910 = r4;
        this.fe639d08f = r5;
        this.f21d6f40c = r6;
    }

    public static void ADGEXFtQYmCffdcP(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static pd4ccf9ff AKJJXnXkgdMbiBPk(p6d29e2ef r1) {
        return r1.getAnimationPreview();
    }

    public static void BbdaQbwaPClsrrRd(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object IbczHZcdIJEOdnee(p44cd4abe r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static void JKAvlLXUwTMpSGEp(p71c7ae29 r0) {
        r0.startNewSession();
    }

    public static void LBgOTPhOLLihNrRi(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object MeYuCXnKIUPScKIk() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void NwEivchOejjfXUTh(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string QepkOhugmdJOJXlb(p9f82518d r1) {
        return r1.getId();
    }

    public static string RHQhybbqtgvbJwuh(p2f3c4196 r1) {
        return r1.getShopId();
    }

    public static void RIMgjLpcPGletUtA(p6d29e2ef r0, pd4ccf9ff r1) {
        r0.setAnimationPreview(r1);
    }

    public static bool RWhaPVAQizPZqERc(p44cd4abe r1) {
        return r1.isFirstTimeEnter();
    }

    public static void RqODAoKvCWEtcEPk(p44cd4abe r0, string r1) {
        r0.removeExpandedShopId(r1);
    }

    public static bool TxpQBSPqEIMHytJC(pd4ccf9ff r1) {
        return r1.getHashSettingsDeviceAnimation();
    }

    public static bool UXDdvjkuEaLrGsUx(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public static bool UoDtqGjwMVeEROGP(bool r1) {
        return bool.valueOf(r1);
    }

    public static object VmwaFwzvBpkVLbOJ(IEnumerator r1) {
        return r1.Current;
    }

    public static object XfesxVAeVxIQqhZN(p44cd4abe r1, Continuation r2) {
        return r1.clearDevices(r2);
    }

    public static object YOOleiBfOrSXkETS() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void YkKnRTOZSjoVnQjs(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pd4ccf9ff YutuLxsLvvVzuNXX(p6d29e2ef r1) {
        return r1.getAnimationPreview();
    }

    public static void YygdpXkAWKNWFOAK(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object BivXTvscsMXlqOcB(pbbc980a3 r1, string r2, Continuation r3) {
        return r1.selectDevice(r2, r3);
    }

    public static object COoPRGzSMBrdODga(p44cd4abe r1, string r2, Continuation r3) {
        return r1.removeDevice(r2, r3);
    }

    public static object CTyBGUqyTVwSNndM() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static IEnumerator CYOuLZbNDgeRoHqk(IEnumerable r1) {
        return r1.GetEnumerator();
    }

    public static object DEeFJuJodlnejMQd() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object ECgDsDjRggjyLZIC(p44cd4abe r1, Continuation r2) {
        return r1.getShops(r2);
    }

    public static void FClGGAOyLDHyTAxd(p44cd4abe r0, p34dfc252 r1) {
        r0.updateFilter(r1);
    }

    public static pd4ccf9ff GUwgxkfydBGWUmfL(pd4ccf9ff r1, bool r2, bool r3, bool r4, bool r5, bool r6, bool r7, int r8, object r9) {
        return pd4ccf9ff.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9);
    }

    public static void GhsFycINKTSGjOZH(p44cd4abe r0, string r1) {
        r0.saveExpandedShopId(r1);
    }

    public static void HZnHMTDkeCWhRqUE(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void HjzCUOATWGnExWVE(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void JgGjZKaaYpZOlFfq(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void JoYhIuBzkQPAvweG(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void JyNUfCtGmEBQlDqp(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static bool MHmKIUaSiLRHmUGD(bool r1) {
        return r1.boolValue();
    }

    public static void MmSCwpnZBZxTgmOA(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static p34dfc252 MzdsTsybIDFUnOlW(p44cd4abe r1) {
        return r1.getFilter();
    }

    public static void QJQuhqHebkEEXYkr(p9f82518d r0, bool r1) {
        r0.setSelected(r1);
    }

    public static object SJbMrmaWImISGIKz() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static bool UKEKJzrNhRUmBMzy(IEnumerator r1) {
        return r1.MoveNext();
    }

    public static object WLaZbviwWJPbiqXd(pf698b4bd r1, Continuation r2) {
        return r1.updateDeviceInfo(r2);
    }

    public static void WwzFFfNCbFNoHmXm(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void XAceiLGhFStKtwIe(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static List YLbajqINFUaDEWtd(p44cd4abe r1) {
        return r1.getExpandedShopIds();
    }

    public static void YbTpKshkkROGBdju(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object ZxkMhaCJwWyYJHWT(p44cd4abe r1, string r2, Continuation r3) {
        return r1.selectDevice(r2, r3);
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public object ApplyDevice(string r5, Continuation<Unit> r6) {
        if (((21 + 6) % 6) > 0) goto L35;
    L35:
        if ((r6 is pbbc980a3$p385cae29$1) == true) goto L57;
    L25:
        pbbc980a3$p385cae29$1 r0 = new pbbc980a3$p385cae29$1(this, r6);
    L62:
        object r62 = r0.fb4a88417;
        object r1 = MeYuCXnKIUPScKIk();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L43;
        if (r2 != 1) goto L46;
        pbbc980a3 this = (pbbc980a3) r0.L$0;
        joYhIuBzkQPAvweG(r62);
    L59:
        JKAvlLXUwTMpSGEp(this.f21d6f40c);
        return Unit.INSTANCE;
    L46:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L43:
        YkKnRTOZSjoVnQjs(r62);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (bivXTvscsMXlqOcB(this, r5, r0) != r1) goto L59;
        return r1;
    L57:
        r0 = (pbbc980a3$p385cae29$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L25;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L62
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public object ClearDevices(Continuation<Unit> r1) {
        object r0 = XfesxVAeVxIQqhZN(this.f8af308bf, r1);
        if (r0 != sJbMrmaWImISGIKz()) goto L15;
        return r0;
    L15:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public List<string> GetExpandedShopIds() {
        return yLbajqINFUaDEWtd(this.f8af308bf);
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public p34dfc252 GetFilter() {
        return mzdsTsybIDFUnOlW(this.f8af308bf);
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public object GetSelectedDevice(Continuation<p4f30e9bd> r1) {
        return IbczHZcdIJEOdnee(this.f8af308bf, r1);
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public object GetShops(Continuation<? super List<p9f82518d>> r6) {
        if (((4 + 31) % 31) > 0) goto L35;
    L35:
        if ((r6 is pbbc980a3$p99196987$1) == false) goto L44;
        pbbc980a3$p99196987$1 r0 = (pbbc980a3$p99196987$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L44;
        r0.fd304ba20 -= int.MIN_VALUE;
    L54:
        object r62 = r0.fb4a88417;
        object r1 = YOOleiBfOrSXkETS();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L68;
        YygdpXkAWKNWFOAK(r62);
        p44cd4abe r63 = this.f8af308bf;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = eCgDsDjRggjyLZIC(r63, r0);
        if (r62 == r1) goto L89;
    L38:
        List r64 = (List) r62;
        IEnumerator r02 = cYOuLZbNDgeRoHqk(r64);
    L40:
        if (uKEKJzrNhRUmBMzy(r02) == false) goto L11;
        object r12 = VmwaFwzvBpkVLbOJ(r02);
        if (UXDdvjkuEaLrGsUx(QepkOhugmdJOJXlb((p9f82518d) r12), RHQhybbqtgvbJwuh(this.fe639d08f)) == false) goto L40;
    L3:
        p9f82518d r13 = (p9f82518d) r12;
        if (r13 is not null) goto L22;
    L18:
        return r64;
    L22:
        qJQuhqHebkEEXYkr(r13, true);
        goto L18
    L11:
        r12 = null;
        goto L3
    L89:
        return r1;
    L68:
        if (r2 != 1) goto L5;
        pbbc980a3 this = (pbbc980a3) r0.L$0;
        hjzCUOATWGnExWVE(r62);
        goto L38
    L5:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L44:
        r0 = new pbbc980a3$p99196987$1(this, r6);
        goto L54
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public bool IsAnimationPreviewShown() {
        bool r0 = TxpQBSPqEIMHytJC(AKJJXnXkgdMbiBPk(this.f97e1f910));
        if (r0 is not null) goto L16;
        return false;
    L16:
        return mHmKIUaSiLRHmUGD(r0);
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public bool IsFirstTimeEnter() {
        return RWhaPVAQizPZqERc(this.f8af308bf);
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public object RemoveDevice(string r1, Continuation<Unit> r2) {
        object r0 = cOoPRGzSMBrdODga(this.f8af308bf, r1, r2);
        if (r0 != cTyBGUqyTVwSNndM()) goto L6;
        return r0;
    L6:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public void RemoveExpandedShopId(string r2) {
        NwEivchOejjfXUTh(r2, "id");
        RqODAoKvCWEtcEPk(this.f8af308bf, r2);
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public void SaveExpandedShopId(string r2) {
        LBgOTPhOLLihNrRi(r2, "id");
        ghsFycINKTSGjOZH(this.f8af308bf, r2);
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public object SelectDevice(string r6, Continuation<Unit> r7) {
        if (((3 + 6) % 6) > 0) goto L7;
    L7:
        if ((r7 is pbbc980a3$p64392418$1) == false) goto L3;
        pbbc980a3$p64392418$1 r0 = (pbbc980a3$p64392418$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L3;
        r0.fd304ba20 -= int.MIN_VALUE;
    L6:
        object r72 = r0.fb4a88417;
        object r1 = dEeFJuJodlnejMQd();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L70;
        if (r2 == 1) goto L84;
        if (r2 != 2) goto L52;
        ybTpKshkkROGBdju(r72);
    L80:
        return Unit.INSTANCE;
    L52:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L84:
        pbbc980a3 this = (pbbc980a3) r0.L$0;
        jyNUfCtGmEBQlDqp(r72);
    L47:
        pf698b4bd r5 = this.feab592e9;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (wLaZbviwWJPbiqXd(r5, r0) != r1) goto L80;
    L73:
        return r1;
    L70:
        hZnHMTDkeCWhRqUE(r72);
        p44cd4abe r73 = this.f8af308bf;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (zxkMhaCJwWyYJHWT(r73, r6, r0) == r1) goto L73;
    L3:
        r0 = new pbbc980a3$p64392418$1(this, r7);
        goto L6
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public void SetAnimationPreviewIsShown() {
        if (((18 + 19) % 19) > 0) goto L18;
    L18:
        pd4ccf9ff r1 = YutuLxsLvvVzuNXX(this.f97e1f910);
        RIMgjLpcPGletUtA(this.f97e1f910, gUwgxkfydBGWUmfL(r1, null, null, null, UoDtqGjwMVeEROGP(true), null, null, 55, null));
    }

    @Override // pe0212e54.pac143fb7.p4b8940c0
    public void UpdateFilter(p34dfc252 r2) {
        mmSCwpnZBZxTgmOA(r2, "deviceFilter");
        fClGGAOyLDHyTAxd(this.f8af308bf, r2);
    }
}

