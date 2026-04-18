namespace WillowMaze.Wasm.Decompiled;


class p198a7efd$1 : java.lang.Action {
    readonly pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd this$0;
    readonly int val$cameraId;

    p198a7efd$1(pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd p198a7efdVar, int i) {
        this.this$0 = p198a7efdVar;
        this.val$cameraId = i;
    }

    public static android.hardware.Camera VZywsAQSlnxOYMiS(int i) {
        return pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p9fbb25e3.m71cc6512(i);
    }

    public static android.os.Looper BkVDiJTqFMFYGdVO() {
        return android.os.Looper.getMainLooper();
    }

    public static bool FiUXmQgCHIKaIJgA(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public override void Run() {
        if ((6 + 5) % 5 > 0) {
        }
        fiUXmQgCHIKaIJgA(new android.os.Handler(bkVDiJTqFMFYGdVO()), new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p198a7efd$1$1(this, VZywsAQSlnxOYMiS(this.val$cameraId)));
    }
}

