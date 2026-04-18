namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0007"}, d2 = {"com/psr/top/sdk/kernel/security/checks/camera/CameraUsedDetectorApiImpl$check$2$1", "Landroid/hardware/camera2/CameraManager$AvailabilityCallback;", "onCameraAvailable", "", "cameraId", "", "onCameraUnavailable", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc537e0c4$p0ba4439e$2$1 : android.hardware.camera2.CameraManager$AvailabilityCallback {
    readonly android.hardware.camera2.CameraManager $cameraManager;
    readonly io.reactivex.rxjava3.core.SingleEmitter<java.lang.int> $emitter;
    readonly android.os.HandlerThread $handlerThread;
    readonly int $value;

    pc537e0c4$p0ba4439e$2$1(android.os.HandlerThread handlerThread, android.hardware.camera2.CameraManager cameraManager, io.reactivex.rxjava3.core.SingleEmitter<java.lang.int> singleEmitter, int i) {
        this.$handlerThread = handlerThread;
        this.$cameraManager = cameraManager;
        this.$emitter = singleEmitter;
        this.$value = i;
    }

    public static java.lang.int BUULjGaLRgozuwCG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EmWgHLaVEHTPQplP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IkMlhoMsgwAIkiGr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void MrYLEvPDQZkDAZrb(android.hardware.camera2.CameraManager cameraManager, android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback) {
        cameraManager.unregisterAvailabilityCallback(cameraManager$AvailabilityCallback);
    }

    public static void NzLtFEorpCwLgDtR(android.hardware.camera2.CameraManager cameraManager, android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback) {
        cameraManager.unregisterAvailabilityCallback(cameraManager$AvailabilityCallback);
    }

    public static bool QrHHxjwpvdYIKExj(android.os.HandlerThread handlerThread) {
        return handlerThread.quit();
    }

    public static void UZwCLmyPpEJjkncU(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static bool YAZTuHqCcMuXPUjJ(android.os.HandlerThread handlerThread) {
        return handlerThread.quit();
    }

    public static kotlin.random.Random ZTNZJyKeqDeqhmeG(int i) {
        return kotlin.random.RandomKt.Random(i);
    }

    public static void DXYjTDrLbmZxldZQ(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static int GEatuCINOYlGyZsD(kotlin.random.Random random) {
        return random.nextInt();
    }

    public static java.lang.int QoXovikmHafrhpKO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void UtfGCGuCoTjghvUj(android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback, java.lang.string str) {
        super.onCameraAvailable(str);
    }

    public static void ZyDmIDWXEJPAgaWo(android.hardware.camera2.CameraManager$AvailabilityCallback cameraManager$AvailabilityCallback, java.lang.string str) {
        super.onCameraUnavailable(str);
    }

    public override void OnCameraAvailable(java.lang.string cameraId) {
        EmWgHLaVEHTPQplP(cameraId, "cameraId");
        utfGCGuCoTjghvUj(this, cameraId);
        QrHHxjwpvdYIKExj(this.$handlerThread);
        NzLtFEorpCwLgDtR(this.$cameraManager, this);
        UZwCLmyPpEJjkncU(this.$emitter, qoXovikmHafrhpKO(this.$value));
    }

    public override void OnCameraUnavailable(java.lang.string cameraId) {
        IkMlhoMsgwAIkiGr(cameraId, "cameraId");
        zyDmIDWXEJPAgaWo(this, cameraId);
        YAZTuHqCcMuXPUjJ(this.$handlerThread);
        MrYLEvPDQZkDAZrb(this.$cameraManager, this);
        dXYjTDrLbmZxldZQ(this.$emitter, BUULjGaLRgozuwCG(gEatuCINOYlGyZsD(ZTNZJyKeqDeqhmeG(this.$value))));
    }
}

