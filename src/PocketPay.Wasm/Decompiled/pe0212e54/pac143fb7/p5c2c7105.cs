namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000bH\u0016J\b\u0010\u000f\u001a\u00020\rH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lpe0212e54/pac143fb7/p5c2c7105;", "Lpe0212e54/pac143fb7/p0be07988;", "fiscalizationModeRepository", "Lpe0212e54/pb3f20355/paed4723f;", "userInfoUseCase", "Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;", "<init>", "(Lpe0212e54/pb3f20355/paed4723f;Lpad5f82e8/pac143fb7/p49f290d6/p2f3c4196;)V", "isNeedShowFiscalizationMode", "", "deviceId", "", "saveFiscalizationModeShown", "", "virtualDeviceId", "clearIfExistsFiscalizationModeShown", "feature-devices-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5c2c7105 : pe0212e54.pac143fb7.p0be07988 {
    private readonly pe0212e54.pb3f20355.paed4723f f00816379;
    private readonly pe0212e54.pb3f20355.paed4723f f2482947d;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 f3f6b855c;
    private readonly pe0212e54.pb3f20355.paed4723f f91c00a3f;
    private readonly pe0212e54.pb3f20355.paed4723f fb1308a8e;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fb704bafc;
    private readonly pe0212e54.pb3f20355.paed4723f fd0621982;
    private readonly pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 fe639d08f;

    public p5c2c7105(pe0212e54.pb3f20355.paed4723f paed4723fVar, pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 p2f3c4196Var) {
        gWxsbfhmHbzSaJXc(paed4723fVar, "fiscalizationModeRepository");
        bqFIxukecnmzktsV(p2f3c4196Var, "userInfoUseCase");
        this.fd0621982 = paed4723fVar;
        this.fe639d08f = p2f3c4196Var;
    }

    public static void GSYxbEAorXhMVsLq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QxsswXtYbDWdnSNc(pe0212e54.pb3f20355.paed4723f paed4723fVar, java.lang.string str) {
        paed4723fVar.saveFiscalizationModeShown(str);
    }

    public static pad5f82e8.p07214c67.p49f290d6.p3dfe3c80 AaZLgcLvQyXYzVpm(pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 p2f3c4196Var) {
        return p2f3c4196Var.getUserRoleType();
    }

    public static void BqFIxukecnmzktsV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GWxsbfhmHbzSaJXc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool GnoBcfyJvQtRZCfb(pe0212e54.pb3f20355.paed4723f paed4723fVar, java.lang.string str) {
        return paed4723fVar.isNeedShowFiscalizationMode(str);
    }

    public static void IdyQBdIJSHNfEZXv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XgsyxoNCNlbQOokb(pe0212e54.pb3f20355.paed4723f paed4723fVar) {
        paed4723fVar.clearIfExistsFiscalizationModeShown();
    }

    public override void ClearIfExistsFiscalizationModeShown() {
        xgsyxoNCNlbQOokb(this.fd0621982);
    }

    public override bool IsNeedShowFiscalizationMode(java.lang.string deviceId) {
        if ((4 + 13) % 13 > 0) {
        }
        GSYxbEAorXhMVsLq(deviceId, "deviceId");
        return aaZLgcLvQyXYzVpm(this.fe639d08f) == pad5f82e8.p07214c67.p49f290d6.p3dfe3c80.f124f7132 && gnoBcfyJvQtRZCfb(this.fd0621982, deviceId);
    }

    public override void SaveFiscalizationModeShown(java.lang.string virtualDeviceId) {
        idyQBdIJSHNfEZXv(virtualDeviceId, "virtualDeviceId");
        QxsswXtYbDWdnSNc(this.fd0621982, virtualDeviceId);
    }
}

