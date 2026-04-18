namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0007"}, d2 = {"com/psr/top/sdk/kernel/utils/extensions/api/ApiExtensionsKt$cameraEnabled$1$1", "Landroid/hardware/camera2/CameraManager$AvailabilityCallback;", "onCameraAvailable", "", "cameraId", "", "onCameraUnavailable", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb87090aa$p239a852a$1$1 : android.hardware.camera2.CameraManager$AvailabilityCallback {
    readonly android.hardware.camera2.CameraManager $cameraManager;
    readonly io.reactivex.rxjava3.core.SingleEmitter<java.lang.bool> $emitter;
    readonly android.os.HandlerThread $handlerThread;

    pb87090aa$p239a852a$1$1(android.os.HandlerThread handlerThread, android.hardware.camera2.CameraManager cameraManager, io.reactivex.rxjava3.core.SingleEmitter<java.lang.bool> singleEmitter) {
        this.$handlerThread = handlerThread;
        this.$cameraManager = cameraManager;
        this.$emitter = singleEmitter;
    }

    public static bool EcnhSDwXjVwXZhqm(android.os.HandlerThread handlerThread) {
        return handlerThread.quit();
    }

    public static void GYpWPMQpzoEyfwbH(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static void JnihvwqtFkrhSQYb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OPBHuEtyISqEsNtQ(android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback, java.lang.string str) {
        super.onCameraAvailable(str);
    }

    public static void XvQaVfTNsCDbtgrg(android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback, java.lang.string str) {
        super.onCameraUnavailable(str);
    }

    public static java.lang.bool DweMgJiQORDSrnFj(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void JjIjSlGrXHTpSQNc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KmrrKEDYwNtKRzOE(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static void SnTHhxnmjKwIJdXr(android.hardware.camera2.CameraManager cameraManager, android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback) {
        cameraManager.unregisterAvailabilityCallback(cameraManager$AvailabilityCallback);
    }

    public static bool TMIIielYNcVbJYCt(android.os.HandlerThread handlerThread) {
        return handlerThread.quit();
    }

    public static java.lang.bool UhgTVrEaVgVoBxFr(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void YpqLSmifhvlyGLzP(android.hardware.camera2.CameraManager cameraManager, android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback) {
        cameraManager.unregisterAvailabilityCallback(cameraManager$AvailabilityCallback);
    }

    public override void OnCameraAvailable(java.lang.string cameraId) {
        JnihvwqtFkrhSQYb(cameraId, "cameraId");
        OPBHuEtyISqEsNtQ(this, cameraId);
        tMIIielYNcVbJYCt(this.$handlerThread);
        ypqLSmifhvlyGLzP(this.$cameraManager, this);
        kmrrKEDYwNtKRzOE(this.$emitter, dweMgJiQORDSrnFj(false));
    }

    public override void OnCameraUnavailable(java.lang.string cameraId) {
        jjIjSlGrXHTpSQNc(cameraId, "cameraId");
        XvQaVfTNsCDbtgrg(this, cameraId);
        EcnhSDwXjVwXZhqm(this.$handlerThread);
        snTHhxnmjKwIJdXr(this.$cameraManager, this);
        GYpWPMQpzoEyfwbH(this.$emitter, uhgTVrEaVgVoBxFr(true));
    }
}

