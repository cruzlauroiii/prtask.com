using Java.Sql;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P8d777f38.P8a5da52e.Pc1c16452;
using Pad5f82e8.P07214c67.P9efab239;
using Pad5f82e8.P07214c67.Pc1c16452;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pe0212e54.Pb3f20355;
using Pe0212e54.Pf5e638cc.Pd77d5e50;
using Retrofit2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class p32dbd090 : pda0b425a {
    private readonly pfeb9ca41 f24ecc10f;
    private readonly pfeb9ca41 f3691e6f0;
    private readonly pfeb9ca41 f548761ed;
    private readonly p2109a012 f6931b8f1;
    private readonly p2109a012 f9860e364;
    private readonly pfeb9ca41 feda50ab1;
    private readonly pfeb9ca41 ffa781974;

    public p32dbd090(p2109a012 r2, pfeb9ca41 r3) {
        TfcjXLooIRGWYpNT(r2, "marketDeviceInfoApi");
        SNqNrFpmuIDgNLoh(r3, "devicesDbRepository");
        this.f6931b8f1 = r2;
        this.ffa781974 = r3;
    }

    public static p6285e3eb BLsujAMBkIQyXeFO(p6285e3eb r1, string r2, string r3, string r4, string r5, string r6, string r7, string r8, p9d21d731 r9, string r10, Timestamp r11, Timestamp r12, Timestamp r13, bool r14, List r15, string r16, p854660d3 r17, bool r18, int r19, object r20) {
        return p6285e3eb.m1c1e012b(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20);
    }

    public static void DmWstjGcaonhKqCF(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string ENySYJjZniyvXYpa(p6285e3eb r1) {
        return r1.getDeviceName();
    }

    public static object EQfxsjBkinXcWPdq(pfeb9ca41 r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static object FoavVpQkGgdmkxgj() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string FxYqxaLDlHCnLGaD(p6285e3eb r1) {
        return r1.getUserId();
    }

    public static object GibZUhSgVslrTtMU(pfeb9ca41 r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static object JSUADvVmfXRZkmrX() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object KedcpSaydQRnAngo() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void OiXmhdNRHaDUrzdY(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object PbeYLTHmtIODXlDb(p32dbd090 r1, string r2, Continuation r3) {
        return r1.m80a7111c(r2, r3);
    }

    public static void PpgloPSAcclgGkGR(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object QSWbpYocxksRbPPs(pfeb9ca41 r1, p94db0041 r2, Continuation r3) {
        return r1.updateDeviceStatus(r2, r3);
    }

    public static object RWjriUkpMyJAQYDi(p32dbd090 r1, string r2, Continuation r3) {
        return r1.m80a7111c(r2, r3);
    }

    public static void SNqNrFpmuIDgNLoh(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string TTcYlNjAMlsIFfSZ(p6285e3eb r1) {
        return r1.getDeviceId();
    }

    public static void TfcjXLooIRGWYpNT(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void TkCVObrbCSaPAOii(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void WeeononthPGYiDyW(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string XFbcasBmpDOzAbdq(p6285e3eb r1) {
        return r1.getShopId();
    }

    public static string YrIIkZvufYSsqyaT(pd34153d4 r1) {
        return r1.getName();
    }

    public static void AEUqxYQxmjKxXBgP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object AWcWqluUSlkSFFul() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string BTCEIbVNmELsVIhO(pd34153d4 r1) {
        return r1.getUserId();
    }

    public static void BTbUiuDQXhAyrNCz(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string BYaaQpRgnyXpYaTJ(pd34153d4 r1) {
        return r1.getToken();
    }

    public static object CgAgLadKXVLLnTYF(pfeb9ca41 r1, string r2, Continuation r3) {
        return r1.getDevice(r2, r3);
    }

    public static int DQvbJFhGPFwaFNco(p9bc96b38 r1) {
        return r1.getCode();
    }

    public static object DUWeuuLzRaNdUxBj() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object HyvbcFKkrFwyTxkq(p32dbd090 r1, string r2, string r3, Continuation r4) {
        return r1.getMarketDeviceInfo(r2, r3, r4);
    }

    public static void JvNOPMroWfCgTZiF(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object KDDauaobaHEtWuGW(pfeb9ca41 r1, p6285e3eb r2, Continuation r3) {
        return r1.updateDevice(r2, r3);
    }

    public static string KZXdeqERseHoLGMv(p6285e3eb r1) {
        return r1.getToken();
    }

    public static void KdUqIlmkTxFHOwRM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void KxvSAbUweedbXIgP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static readonly /* synthetic */ object m07708a54(p32dbd090 r0, string r1, string r2, Continuation r3) {
        return vchtTcyKNGkXPUeU(r0, r1, r2, r3);
    }

    private readonly object M2b58d113(string r5, string r6, Continuation<pd34153d4> r7) {
        if (((27 + 26) % 26) > 0) goto L79;
    L79:
        if ((r7 is p32dbd090$p2b58d113$1) == true) goto L46;
    L26:
        p32dbd090$p2b58d113$1 r0 = new p32dbd090$p2b58d113$1(this, r7);
    L88:
        object r72 = r0.fb4a88417;
        object r1 = dUWeuuLzRaNdUxBj();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L15;
        if (r2 != 1) goto L72;
        TkCVObrbCSaPAOii(r72);
    L41:
        Response r73 = (Response) r72;
        if (sakzRiLxewyFhwtE(r73) == false) goto L82;
        pd34153d4 r4 = (pd34153d4) uAoLHSpUKPzjRPEN(r73);
        if (r4 is null) goto L82;
        return r4;
    L82:
        if (sBKfvGEzfBjBayVW(r73) == dQvbJFhGPFwaFNco(p9bc96b38.f45d9cc15)) goto L55;
        throw new Exception("Cannot load market device info");
    L55:
        throw new pcbfcd609(p9bc96b38.f45d9cc15);
    L72:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L15:
        bTbUiuDQXhAyrNCz(r72);
        p2109a012 r42 = this.f6931b8f1;
        r0.fd304ba20 = 1;
        r72 = qxmdVNmqVroIFDbT(r42, r6, r5, r0);
        if (r72 != r1) goto L41;
        return r1;
    L46:
        r0 = (p32dbd090$p2b58d113$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L26;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L88
    }

    private readonly object M80a7111c(string r1, Continuation<p6285e3eb> r2) {
        if (r1 is not null) goto L5;
        return EQfxsjBkinXcWPdq(this.ffa781974, r2);
    L5:
        return cgAgLadKXVLLnTYF(this.ffa781974, r1, r2);
    }

    public static string MQycotGTFLEnYSJU(pd34153d4 r1) {
        return r1.getShopUuid();
    }

    public static readonly /* synthetic */ object md1140353(p32dbd090 r0, string r1, Continuation r2) {
        return PbeYLTHmtIODXlDb(r0, r1, r2);
    }

    public static object MynJIqIrXsxJajXY(p32dbd090 r1, string r2, Continuation r3) {
        return r1.m80a7111c(r2, r3);
    }

    public static string NjEiJgrwmwpAdwkn(p6285e3eb r1) {
        return r1.getDeviceId();
    }

    public static void OMKbMdVcIAZAeotP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object ONAqOSQefThaXalh(pfeb9ca41 r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static void PbPvrwClFtXecEzR(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object QocaIJEUDsiiNgOp() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object QxmdVNmqVroIFDbT(p2109a012 r1, string r2, string r3, Continuation r4) {
        return r1.getMarketDeviceInfo(r2, r3, r4);
    }

    public static object RpjTAgofHPgFLatS(p32dbd090 r1, string r2, string r3, Continuation r4) {
        return r1.m2b58d113(r2, r3, r4);
    }

    public static int SBKfvGEzfBjBayVW(Response r1) {
        return r1.code();
    }

    public static bool SKtpeUIHlmABOIEp(pd87e81b8 r1) {
        return r1.isKktReadyForDelivery();
    }

    public static bool SakzRiLxewyFhwtE(Response r1) {
        return r1.isSuccessful();
    }

    public static object TCYNDNIfmevnYADs(p32dbd090 r1, string r2, Continuation r3) {
        return r1.m80a7111c(r2, r3);
    }

    public static object UAoLHSpUKPzjRPEN(Response r1) {
        return r1.body();
    }

    public static void VBPjRgcnenALIdhR(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object VchtTcyKNGkXPUeU(p32dbd090 r1, string r2, string r3, Continuation r4) {
        return r1.m2b58d113(r2, r3, r4);
    }

    public static bool VlUNilXqRvTMHmDN(bool r1) {
        return r1.boolValue();
    }

    public static void XMTgKCdKraURQvks(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void ZNFvQxJekVqwwQdJ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pd87e81b8 ZTThKLsswZHateyd(pd34153d4 r1) {
        return r1.getDeviceStatus();
    }

    @Override // p8d777f38.pb3f20355.pc1c16452.pda0b425a
    public object GetMarketDeviceInfo(string r1, string r2, Continuation<pd34153d4> r3) {
        return rpjTAgofHPgFLatS(this, r1, r2, r3);
    }

    @Override // p8d777f38.pb3f20355.pc1c16452.pda0b425a
    public object GetName(Continuation<string> r5) {
        if (((5 + 26) % 26) > 0) goto L54;
    L54:
        if ((r5 is p32dbd090$p32132c89$1) == true) goto L26;
    L20:
        p32dbd090$p32132c89$1 r0 = new p32dbd090$p32132c89$1(this, r5);
    L73:
        object r52 = r0.fb4a88417;
        object r1 = KedcpSaydQRnAngo();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L32;
        DmWstjGcaonhKqCF(r52);
        pfeb9ca41 r4 = this.ffa781974;
        r0.fd304ba20 = 1;
        r52 = GibZUhSgVslrTtMU(r4, r0);
        if (r52 != r1) goto L68;
        return r1;
    L68:
        string r42 = ENySYJjZniyvXYpa((p6285e3eb) r52);
        if (r42 is null) goto L17;
        return r42;
    L17:
        throw new Exception("name is null");
    L32:
        if (r2 != 1) goto L24;
        WeeononthPGYiDyW(r52);
        goto L68
    L24:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L26:
        r0 = (p32dbd090$p32132c89$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L20;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L73
    }

    @Override // p8d777f38.pb3f20355.pc1c16452.pda0b425a
    public object GetShopUUid(string r5, Continuation<string> r6) {
        if (((14 + 31) % 31) > 0) goto L29;
    L29:
        if ((r6 is p32dbd090$pdd1b20e5$1) == true) goto L34;
    L58:
        p32dbd090$pdd1b20e5$1 r0 = new p32dbd090$pdd1b20e5$1(this, r6);
    L28:
        object r62 = r0.fb4a88417;
        object r1 = aWcWqluUSlkSFFul();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L26;
        if (r2 != 1) goto L55;
        kdUqIlmkTxFHOwRM(r62);
    L11:
        string r4 = XFbcasBmpDOzAbdq((p6285e3eb) r62);
        if (r4 is null) goto L16;
        return r4;
    L16:
        throw new Exception("shopId is null");
    L55:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L26:
        zNFvQxJekVqwwQdJ(r62);
        r0.fd304ba20 = 1;
        r62 = mynJIqIrXsxJajXY(this, r5, r0);
        if (r62 != r1) goto L11;
        return r1;
    L34:
        r0 = (p32dbd090$pdd1b20e5$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L58;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L28
    }

    @Override // p8d777f38.pb3f20355.pc1c16452.pda0b425a
    public object GetToken(Continuation<string> r5) {
        if (((3 + 19) % 19) > 0) goto L18;
    L18:
        if ((r5 is p32dbd090$pe7110545$1) == false) goto L50;
        p32dbd090$pe7110545$1 r0 = (p32dbd090$pe7110545$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L50;
        r0.fd304ba20 -= int.MIN_VALUE;
    L4:
        object r52 = r0.fb4a88417;
        object r1 = qocaIJEUDsiiNgOp();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L14;
        kxvSAbUweedbXIgP(r52);
        pfeb9ca41 r4 = this.ffa781974;
        r0.fd304ba20 = 1;
        r52 = oNAqOSQefThaXalh(r4, r0);
        if (r52 != r1) goto L61;
        return r1;
    L61:
        string r42 = kZXdeqERseHoLGMv((p6285e3eb) r52);
        if (r42 is null) goto L72;
        return r42;
    L72:
        throw new Exception("token is null");
    L14:
        if (r2 != 1) goto L40;
        xMTgKCdKraURQvks(r52);
        goto L61
    L40:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L50:
        r0 = new p32dbd090$pe7110545$1(this, r5);
        goto L4
    }

    @Override // p8d777f38.pb3f20355.pc1c16452.pda0b425a
    public object GetUserId(string r5, Continuation<string> r6) {
        if (((18 + 8) % 8) > 0) goto L56;
    L56:
        if ((r6 is p32dbd090$p594751a0$1) == true) goto L61;
    L23:
        p32dbd090$p594751a0$1 r0 = new p32dbd090$p594751a0$1(this, r6);
    L19:
        object r62 = r0.fb4a88417;
        object r1 = JSUADvVmfXRZkmrX();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L55;
        if (r2 != 1) goto L69;
        pbPvrwClFtXecEzR(r62);
    L3:
        string r4 = FxYqxaLDlHCnLGaD((p6285e3eb) r62);
        if (r4 is null) goto L31;
        return r4;
    L31:
        throw new Exception("userId is null");
    L69:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L55:
        OiXmhdNRHaDUrzdY(r62);
        r0.fd304ba20 = 1;
        r62 = tCYNDNIfmevnYADs(this, r5, r0);
        if (r62 != r1) goto L3;
        return r1;
    L61:
        r0 = (p32dbd090$p594751a0$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L23;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L19
    }

    @Override // p8d777f38.pb3f20355.pc1c16452.pda0b425a
    public object UpdateDeviceInfo(string r29, string r30, Continuation<Unit> r31) {
        if (((26 + 25) % 25) > 0) goto L41;
    L41:
        p32dbd090 r0 = this;
        if ((r31 is p32dbd090$p2ad2d5b1$1) == true) goto L131;
    L7:
        p32dbd090$p2ad2d5b1$1 r2 = new p32dbd090$p2ad2d5b1$1(r0, r31);
    L166:
        object r1 = r2.fb4a88417;
        object r3 = FoavVpQkGgdmkxgj();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L55;
        if (r4 == 1) goto L168;
        if (r4 == 2) goto L32;
        if (r4 == 3) goto L124;
        if (r4 != 4) goto L13;
        vBPjRgcnenALIdhR(r1);
    L175:
        return Unit.INSTANCE;
    L13:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L124:
        pd34153d4 r02 = (pd34153d4) r2.L$2;
        p6285e3eb r42 = (p6285e3eb) r2.L$1;
        p32dbd090 r6 = (p32dbd090) r2.L$0;
        aEUqxYQxmjKxXBgP(r1);
    L117:
        string r43 = njEiJgrwmwpAdwkn(r42);
        pd87e81b8 r03 = zTThKLsswZHateyd(r02);
        if (r03 is null) goto L96;
        bool r04 = sKtpeUIHlmABOIEp(r03);
        if (r04 is null) goto L96;
        bool r05 = vlUNilXqRvTMHmDN(r04);
    L28:
        p94db0041 r12 = new p94db0041(r43, r05);
        pfeb9ca41 r06 = r6.ffa781974;
        r2.L$0 = null;
        r2.L$1 = null;
        r2.L$2 = null;
        r2.fd304ba20 = 4;
        if (QSWbpYocxksRbPPs(r06, r12, r2) != r3) goto L175;
    L158:
        return r3;
    L96:
        r05 = false;
        goto L28
    L32:
        p6285e3eb r07 = (p6285e3eb) r2.L$1;
        p32dbd090 r44 = (p32dbd090) r2.L$0;
        PpgloPSAcclgGkGR(r1);
        p6285e3eb r7 = r07;
        r0 = r44;
    L35:
        pd34153d4 r13 = (pd34153d4) r1;
        pfeb9ca41 r45 = r0.ffa781974;
        string r14 = YrIIkZvufYSsqyaT(r13);
        p6285e3eb r8 = BLsujAMBkIQyXeFO(r7, null, null, bTCEIbVNmELsVIhO(r13), mQycotGTFLEnYSJU(r13), null, null, r14, null, null, null, null, null, null, null, bYaaQpRgnyXpYaTJ(r13), null, null, 114611, null);
        r2.L$0 = r0;
        r2.L$1 = r7;
        r2.L$2 = r13;
        r2.fd304ba20 = 3;
        if (kDDauaobaHEtWuGW(r45, r8, r2) == r3) goto L158;
        r6 = r0;
        r02 = r13;
        r42 = r7;
        goto L117
    L168:
        string r08 = (string) r2.L$1;
        p32dbd090 r46 = (p32dbd090) r2.L$0;
        oMKbMdVcIAZAeotP(r1);
        string r15 = r08;
        r0 = r46;
        object r47 = r1;
    L100:
        p6285e3eb r48 = (p6285e3eb) r47;
        string r82 = TTcYlNjAMlsIFfSZ(r48);
        r2.L$0 = r0;
        r2.L$1 = r48;
        r2.fd304ba20 = 2;
        r1 = hyvbcFKkrFwyTxkq(r0, r82, r15, r2);
        if (r1 == r3) goto L158;
        r7 = r48;
        goto L35
    L55:
        jvNOPMroWfCgTZiF(r1);
        r2.L$0 = r0;
        r15 = r29;
        r2.L$1 = r15;
        r2.fd304ba20 = 1;
        r47 = RWjriUkpMyJAQYDi(r0, r30, r2);
        if (r47 == r3) goto L158;
    L131:
        r2 = (p32dbd090$p2ad2d5b1$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L7;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L166
    }
}

