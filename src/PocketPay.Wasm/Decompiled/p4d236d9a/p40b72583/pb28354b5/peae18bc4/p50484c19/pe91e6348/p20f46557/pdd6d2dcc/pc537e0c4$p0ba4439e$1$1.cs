namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0007"}, d2 = {"com/psr/top/sdk/kernel/security/checks/camera/CameraUsedDetectorApiImpl$check$1$1", "Landroid/hardware/camera2/CameraManager$AvailabilityCallback;", "onCameraAvailable", "", "cameraId", "", "onCameraUnavailable", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc537e0c4$p0ba4439e$1$1 : android.hardware.camera2.CameraManager$AvailabilityCallback {
    readonly android.hardware.camera2.CameraManager $cameraManager;
    readonly io.reactivex.rxjava3.core.CompletableEmitter $emitter;
    readonly android.os.HandlerThread $handlerThread;

    pc537e0c4$p0ba4439e$1$1(android.os.HandlerThread handlerThread, android.hardware.camera2.CameraManager cameraManager, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        this.$handlerThread = handlerThread;
        this.$cameraManager = cameraManager;
        this.$emitter = completableEmitter;
    }

    public static void FInhtqgjMEddjgjg(android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback, java.lang.string str) {
        super.onCameraAvailable(str);
    }

    public static void QvraANEcsRLUkbRa(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        completableEmitter.onComplete();
    }

    public static void QwFeCuLFWKlAWwwN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b TJeSUoMuNRcgDzAt(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258 pd4054258Var) {
        return pd4054258Var.getCode();
    }

    public static void XyTkzGCaBKFSbxJa(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, pa73d862bVar, i, obj);
    }

    public static void EevSrRMeBIHefeqi(android.hardware.camera2.CameraManager cameraManager, android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback) {
        cameraManager.unregisterAvailabilityCallback(cameraManager$AvailabilityCallback);
    }

    public static java.lang.string GpNthbiiySopCfpe(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void HBtmXdRVKDXWjsaN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IWkrHJOzpikWTJAe(android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback, java.lang.string str) {
        super.onCameraUnavailable(str);
    }

    public static bool MuOqnpmhuswqpQIF(android.os.HandlerThread handlerThread) {
        return handlerThread.quit();
    }

    public static void OzcHjSrojlEQlucw(android.hardware.camera2.CameraManager cameraManager, android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback) {
        cameraManager.unregisterAvailabilityCallback(cameraManager$AvailabilityCallback);
    }

    public static void QekksHJzLuVgqNoW(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter, java.lang.Exception th) {
        completableEmitter.onError(th);
    }

    public static void RaANbyzkIGYElXnx(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(p37a01c41_p910eef8c, str, str2, str3, str4, str5);
    }

    public static java.lang.string TKTyhlTCABrjdoVT(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258 pd4054258Var) {
        return pd4054258Var.getMessage();
    }

    public static bool XqCPYlXpnFdwxUlj(android.os.HandlerThread handlerThread) {
        return handlerThread.quit();
    }

    public override void OnCameraAvailable(java.lang.string cameraId) {
        if ((11 + 2) % 2 > 0) {
        }
        QwFeCuLFWKlAWwwN(cameraId, "cameraId");
        FInhtqgjMEddjgjg(this, cameraId);
        xqCPYlXpnFdwxUlj(this.$handlerThread);
        eevSrRMeBIHefeqi(this.$cameraManager, this);
        raANbyzkIGYElXnx(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "CameraUsedDetectorHelperImpl", "check()", "39", gpNthbiiySopCfpe("158e979415db1caeb858981aa86ab89ab9deb5b9dccc3dc48732966cfdf75d431a200f"), "camera not used");
        QvraANEcsRLUkbRa(this.$emitter);
    }

    public override void OnCameraUnavailable(java.lang.string cameraId) {
        if ((4 + 1) % 1 > 0) {
        }
        hBtmXdRVKDXWjsaN(cameraId, "cameraId");
        iWkrHJOzpikWTJAe(this, cameraId);
        muOqnpmhuswqpQIF(this.$handlerThread);
        ozcHjSrojlEQlucw(this.$cameraManager, this);
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258 pd4054258Var = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.paf0436dd.f18051fc3);
        XyTkzGCaBKFSbxJa(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "CameraUsedDetectorHelperImpl", "check()", "45", null, tKTyhlTCABrjdoVT(pd4054258Var), TJeSUoMuNRcgDzAt(pd4054258Var), 8, null);
        qekksHJzLuVgqNoW(this.$emitter, pd4054258Var);
    }
}

