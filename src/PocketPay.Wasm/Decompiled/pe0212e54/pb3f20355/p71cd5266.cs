using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using Pad5f82e8.P07214c67.P9efab239;
using Pe0212e54.Pf0719ea8;
using Pe0212e54.Pf5e638cc.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes17.dex */
public readonly class p71cd5266 : pfeb9ca41 {
    private readonly p3305d4f2 f26356ef5;
    private readonly p3305d4f2 f2856c1c6;
    private readonly pae06b677 f55767486;
    private readonly p54785431 f5702a3ef;
    private readonly p54785431 f841a88cb;
    private readonly p3305d4f2 fc8adcb35;
    private readonly p3305d4f2 fe8908e3f;
    private readonly p3305d4f2 fee013bac;
    private readonly pae06b677 ff5d15149;

    public p71cd5266(pae06b677 r2, p54785431 r3, p3305d4f2 r4) {
        lAcQVOEdsdaESMYX(r2, "shopDao");
        ZkuUVZLyDknoNvLd(r3, "deviceDao");
        EbsnBEjdCGzYRcEj(r4, "deviceStatusDao");
        this.f55767486 = r2;
        this.f841a88cb = r3;
        this.f2856c1c6 = r4;
    }

    public static object AdMdrVolFaqBZmoj() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void EbsnBEjdCGzYRcEj(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void FpSHNyZiWuVsqzun(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object GCErBWnkUEXixCeK(p54785431 r1, Continuation r2) {
        return r1.getLocalDevices(r2);
    }

    public static object GWWSnJweJpFlDqJs(p54785431 r1, p6285e3eb r2, Continuation r3) {
        return r1.updateDevice(r2, r3);
    }

    public static string HIVcokqAdXCcacnc(stringBuilder r1) {
        return r1.tostring();
    }

    public static object HYaowWGvuVuHQTsG(p54785431 r1, List r2, Continuation r3) {
        return r1.updateDevices(r2, r3);
    }

    public static object JweiEQDXTnCxGGcM(p54785431 r1, p6285e3eb r2, Continuation r3) {
        return r1.insertDevice(r2, r3);
    }

    public static void KiobvTzjyOMmgDmB(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object LqVNmmIwqyuAVpaR() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void MfxyQtCwONwffKOM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void NjAiMxlsfxvJskIg(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object PIUuTNmllHtWXTCP() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object PUtsQyiazWUeOBAN() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void RzQyHjpKenyoQknj(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object TJpEXapQoBJhMVkV() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object TqXNzrOgrgvPJOhA(pae06b677 r1, Continuation r2) {
        return r1.getShops(r2);
    }

    public static void TwxCcdLMMIKbjdVE(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void XMNFUdVpJFSDcTtJ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object XclRbkyAKGWSKqbp() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object YANrkjgqsVEiFOKe(p54785431 r1, Continuation r2) {
        return r1.removeRemoteDevices(r2);
    }

    public static bool YeVdOIodvjShEowd(bool r1) {
        return Boxing.boxbool(r1);
    }

    public static object YwBfhKfEenVucnMV(p54785431 r1, string r2, Continuation r3) {
        return r1.hasDevice(r2, r3);
    }

    public static void ZkuUVZLyDknoNvLd(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void ZqYUPtGWvkyepQip(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void AYryJIdsSdMJiDnb(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object AtHMHcgAayMombmI() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object BEKfElLnJwXXGICj(p54785431 r1, string r2, Continuation r3) {
        return r1.getDevice(r2, r3);
    }

    public static object BcGIKglIoMVgWmXv(p54785431 r1, List r2, Continuation r3) {
        return r1.updateRemoteDevices(r2, r3);
    }

    public static object BnGdmfrRaScDMdQk(p54785431 r1, string r2, Continuation r3) {
        return r1.hasDevice(r2, r3);
    }

    public static object COJoqGampBHheynm() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static stringBuilder CfuKXdMlFDFtxoOy(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static object DqCUHomKsHFVJgmS(p54785431 r1, string r2, Continuation r3) {
        return r1.selectDevice(r2, r3);
    }

    public static object IBPxreQtWkiyrMIz(pae06b677 r1, List r2, Continuation r3) {
        return r1.updateShops(r2, r3);
    }

    public static object IsexlaKImompZfWB() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object JMqEBIWaAlgBXdly(pae06b677 r1, Continuation r2) {
        return r1.clearShops(r2);
    }

    public static object JjITyEHWioniLgWO(p3305d4f2 r1, p94db0041 r2, Continuation r3) {
        return r1.insertDeviceStatus(r2, r3);
    }

    public static object JorkIjVhWaaSZpBT(p54785431 r1, Continuation r2) {
        return r1.clearDevices(r2);
    }

    public static object KUfXrwcXJUUWwOvK(p54785431 r1, Continuation r2) {
        return r1.getSelectedDevice(r2);
    }

    public static object KxjGRThgTznVSdvq() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void LAcQVOEdsdaESMYX(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string LlgkOcsdSiXVrouG(p6285e3eb r1) {
        return r1.getId();
    }

    public static void LmDaGzPNgfXmxhuM(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object MdZQWkvmDhdEtQQE(p54785431 r1, string r2, Continuation r3) {
        return r1.getDeviceIdByUuid(r2, r3);
    }

    public static object NBYROxxEFHzxfWmE() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static string NFHGQmZEHtegOibl(stringBuilder r1) {
        return r1.tostring();
    }

    public static void NpTdwUqnwDuDneht(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void OcesnLHuzNhirlHl(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object OpYAYWqblTQAPgNN() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static stringBuilder TdQWZGDpgkaAfrqI(stringBuilder r1, string r2) {
        return r1.append(r2);
    }

    public static object TtpDTWdRlKsmwKpx(p54785431 r1, Continuation r2) {
        return r1.getRemoteDevices(r2);
    }

    public static object VlUpWBXKvllBXwGQ() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object WRIdrfBWFnRIpUWV(p54785431 r1, string r2, Continuation r3) {
        return r1.removeDevice(r2, r3);
    }

    public static object WsjcUbIToTLAelTN(p3305d4f2 r1, string r2, Continuation r3) {
        return r1.getDeviceStatusByDeviceId(r2, r3);
    }

    public static object XRHcOcKgnovRvpYV(p54785431 r1, Continuation r2) {
        return r1.getAllDevices(r2);
    }

    public static object ZpGiRgAjoqMMoMwr() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object ClearDevices(Continuation<Unit> r1) {
        object r0 = jorkIjVhWaaSZpBT(this.f841a88cb, r1);
        if (r0 != isexlaKImompZfWB()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object ClearShops(Continuation<Unit> r1) {
        object r0 = jMqEBIWaAlgBXdly(this.f55767486, r1);
        if (r0 != nBYROxxEFHzxfWmE()) goto L4;
        return r0;
    L4:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object GetAllDevices(Continuation<? super List<p6285e3eb>> r1) {
        return xRHcOcKgnovRvpYV(this.f841a88cb, r1);
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object GetDevice(string r5, Continuation<p6285e3eb> r6) {
        if (((7 + 2) % 2) > 0) goto L43;
    L43:
        if ((r6 is p71cd5266$p80a7111c$1) == true) goto L26;
    L73:
        p71cd5266$p80a7111c$1 r0 = new p71cd5266$p80a7111c$1(this, r6);
    L17:
        object r62 = r0.fb4a88417;
        object r1 = XclRbkyAKGWSKqbp();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L76;
        if (r2 != 1) goto L50;
        r5 = (string) r0.L$0;
        XMNFUdVpJFSDcTtJ(r62);
    L60:
        p6285e3eb r63 = (p6285e3eb) r62;
        if (r63 is null) goto L79;
        return r63;
    L79:
        throw new Exception(HIVcokqAdXCcacnc(cfuKXdMlFDFtxoOy(new stringBuilder("Cannot found device with deviceId="), r5)));
    L50:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L76:
        ZqYUPtGWvkyepQip(r62);
        p54785431 r4 = this.f841a88cb;
        r0.L$0 = r5;
        r0.fd304ba20 = 1;
        r62 = bEKfElLnJwXXGICj(r4, r5, r0);
        if (r62 != r1) goto L60;
        return r1;
    L26:
        r0 = (p71cd5266$p80a7111c$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L73;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L17
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object GetDeviceIdByUuid(string r1, Continuation<string> r2) {
        return mdZQWkvmDhdEtQQE(this.f841a88cb, r1, r2);
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object GetDeviceStatusByDeviceId(string r5, Continuation<p94db0041> r6) {
        if (((5 + 16) % 16) > 0) goto L76;
    L76:
        if ((r6 is p71cd5266$p20c26332$1) == true) goto L16;
    L23:
        p71cd5266$p20c26332$1 r0 = new p71cd5266$p20c26332$1(this, r6);
    L7:
        object r62 = r0.fb4a88417;
        object r1 = PUtsQyiazWUeOBAN();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L61;
        lmDaGzPNgfXmxhuM(r62);
        p3305d4f2 r4 = this.f2856c1c6;
        r0.L$0 = r5;
        r0.fd304ba20 = 1;
        r62 = wsjcUbIToTLAelTN(r4, r5, r0);
        if (r62 == r1) goto L26;
    L48:
        p94db0041 r63 = (p94db0041) r62;
        if (r63 is null) goto L43;
        return r63;
    L43:
        throw new Exception(nFHGQmZEHtegOibl(tdQWZGDpgkaAfrqI(new stringBuilder("Cannot found deviceStatus with deviceId="), r5)));
    L26:
        return r1;
    L61:
        if (r2 == 1) goto L22;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L22:
        r5 = (string) r0.L$0;
        NjAiMxlsfxvJskIg(r62);
        goto L48
    L16:
        r0 = (p71cd5266$p20c26332$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L23;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L7
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object GetLocalDevices(Continuation<? super List<p6285e3eb>> r1) {
        return GCErBWnkUEXixCeK(this.f841a88cb, r1);
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object GetRemoteDevices(Continuation<? super List<p6285e3eb>> r1) {
        return ttpDTWdRlKsmwKpx(this.f841a88cb, r1);
    }

    @Override // pe0212e54.pb3f20355.p83b4b395
    public object GetSelectedDevice(Continuation<p6285e3eb> r5) {
        if (((10 + 16) % 16) > 0) goto L59;
    L59:
        if ((r5 is p71cd5266$pd7f4518e$1) == true) goto L64;
    L22:
        p71cd5266$pd7f4518e$1 r0 = new p71cd5266$pd7f4518e$1(this, r5);
    L25:
        object r52 = r0.fb4a88417;
        object r1 = LqVNmmIwqyuAVpaR();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L26;
        if (r2 != 1) goto L67;
        KiobvTzjyOMmgDmB(r52);
    L21:
        p6285e3eb r53 = (p6285e3eb) r52;
        if (r53 is null) goto L57;
        return r53;
    L57:
        throw new p203852f4("No one selected device found");
    L67:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L26:
        FpSHNyZiWuVsqzun(r52);
        p54785431 r4 = this.f841a88cb;
        r0.fd304ba20 = 1;
        r52 = kUfXrwcXJUUWwOvK(r4, r0);
        if (r52 != r1) goto L21;
        return r1;
    L64:
        r0 = (p71cd5266$pd7f4518e$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L22;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L25
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object GetShops(Continuation<? super List<p107d0d2a>> r1) {
        return TqXNzrOgrgvPJOhA(this.f55767486, r1);
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object HasDevice(string r5, Continuation<bool> r6) {
        if (((16 + 13) % 13) > 0) goto L56;
    L56:
        if ((r6 is p71cd5266$pe8334992$1) == true) goto L46;
    L4:
        p71cd5266$pe8334992$1 r0 = new p71cd5266$pe8334992$1(this, r6);
    L44:
        object r62 = r0.fb4a88417;
        object r1 = AdMdrVolFaqBZmoj();
        int r2 = r0.fd304ba20;
        bool r3 = true;
        if (r2 == 0) goto L50;
        if (r2 != 1) goto L29;
        TwxCcdLMMIKbjdVE(r62);
    L16:
        if (r62 is not null) goto L14;
        r3 = false;
    L14:
        return YeVdOIodvjShEowd(r3);
    L29:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L50:
        RzQyHjpKenyoQknj(r62);
        p54785431 r4 = this.f841a88cb;
        r0.fd304ba20 = 1;
        r62 = YwBfhKfEenVucnMV(r4, r5, r0);
        if (r62 != r1) goto L16;
        return r1;
    L46:
        r0 = (p71cd5266$pe8334992$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L4;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L44
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object RemoveDevice(string r1, Continuation<Unit> r2) {
        object r0 = wRIdrfBWFnRIpUWV(this.f841a88cb, r1, r2);
        if (r0 != cOJoqGampBHheynm()) goto L6;
        return r0;
    L6:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object RemoveRemoteDevices(Continuation<Unit> r1) {
        object r0 = YANrkjgqsVEiFOKe(this.f841a88cb, r1);
        if (r0 != vlUpWBXKvllBXwGQ()) goto L12;
        return r0;
    L12:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object SelectDevice(string r1, Continuation<Unit> r2) {
        object r0 = dqCUHomKsHFVJgmS(this.f841a88cb, r1, r2);
        if (r0 != atHMHcgAayMombmI()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object UpdateDevice(p6285e3eb r7, Continuation<Unit> r8) {
        if (((24 + 21) % 21) > 0) goto L32;
    L32:
        if ((r8 is p71cd5266$p50b94136$1) == false) goto L64;
        p71cd5266$p50b94136$1 r0 = (p71cd5266$p50b94136$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L64;
        r0.fd304ba20 -= int.MIN_VALUE;
    L8:
        object r82 = r0.fb4a88417;
        object r1 = opYAYWqblTQAPgNN();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L69;
        if (r2 == 1) goto L17;
        if (r2 != 2) goto L9;
        aYryJIdsSdMJiDnb(r82);
    L19:
        return Unit.INSTANCE;
    L9:
        if (r2 != 3) goto L74;
        npTdwUqnwDuDneht(r82);
    L92:
        return Unit.INSTANCE;
    L74:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L17:
        r7 = (p6285e3eb) r0.L$1;
        p71cd5266 this = (p71cd5266) r0.L$0;
        MfxyQtCwONwffKOM(r82);
    L23:
        if (r82 is not null) goto L35;
        p54785431 r6 = this.f841a88cb;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 3;
        if (JweiEQDXTnCxGGcM(r6, r7, r0) != r1) goto L92;
    L15:
        return r1;
    L35:
        p54785431 r62 = this.f841a88cb;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (GWWSnJweJpFlDqJs(r62, r7, r0) == r1) goto L15;
    L69:
        ocesnLHuzNhirlHl(r82);
        p54785431 r83 = this.f841a88cb;
        string r22 = llgkOcsdSiXVrouG(r7);
        r0.L$0 = this;
        r0.L$1 = r7;
        r0.fd304ba20 = 1;
        r82 = bnGdmfrRaScDMdQk(r83, r22, r0);
        if (r82 == r1) goto L15;
    L64:
        r0 = new p71cd5266$p50b94136$1(this, r8);
        goto L8
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object UpdateDeviceStatus(p94db0041 r1, Continuation<Unit> r2) {
        object r0 = jjITyEHWioniLgWO(this.f2856c1c6, r1, r2);
        if (r0 != kxjGRThgTznVSdvq()) goto L8;
        return r0;
    L8:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object UpdateDevices(List<p6285e3eb> r1, Continuation<Unit> r2) {
        object r0 = HYaowWGvuVuHQTsG(this.f841a88cb, r1, r2);
        if (r0 != TJpEXapQoBJhMVkV()) goto L13;
        return r0;
    L13:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object UpdateRemoteDevices(List<p6285e3eb> r1, Continuation<Unit> r2) {
        object r0 = bcGIKglIoMVgWmXv(this.f841a88cb, r1, r2);
        if (r0 != zpGiRgAjoqMMoMwr()) goto L13;
        return r0;
    L13:
        return Unit.INSTANCE;
    }

    @Override // pe0212e54.pb3f20355.pfeb9ca41
    public object UpdateShops(List<p107d0d2a> r1, Continuation<Unit> r2) {
        object r0 = iBPxreQtWkiyrMIz(this.f55767486, r1, r2);
        if (r0 != PIUuTNmllHtWXTCP()) goto L8;
        return r0;
    L8:
        return Unit.INSTANCE;
    }
}

