namespace WillowMaze.Wasm.Decompiled;


class objectResultRegistry$LifecycleContainer {
    readonly androidx.lifecycle.Lifecycle mLifecycle;
    private readonly java.util.List<androidx.lifecycle.LifecycleEventObserver> mObservers = new java.util.List<>();

    objectResultRegistry$LifecycleContainer(androidx.lifecycle.Lifecycle lifecycle) {
        this.mLifecycle = lifecycle;
    }

    public static java.util.IEnumerator IuDcVzSztztvbxFl(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void IuDcVzSztztvbxFl(java.util.List arrayList, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IuDcVzSztztvbxFl(java.util.List arrayList, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IuDcVzSztztvbxFl(java.util.List arrayList, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBTsbbwdfuLpFvpX(java.util.List arrayList, java.lang.object obj, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OBTsbbwdfuLpFvpX(java.util.List arrayList, java.lang.object obj, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OBTsbbwdfuLpFvpX(java.util.List arrayList, java.lang.object obj, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OBTsbbwdfuLpFvpX(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object PGMmJJWeNSmhuGyZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void PGMmJJWeNSmhuGyZ(java.util.IEnumerator it, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGMmJJWeNSmhuGyZ(java.util.IEnumerator it, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGMmJJWeNSmhuGyZ(java.util.IEnumerator it, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QYUnBEasisXCOkHb(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver) {
        lifecycle.removeObserver(lifecycleObserver);
    }

    public static void QYUnBEasisXCOkHb(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QYUnBEasisXCOkHb(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QYUnBEasisXCOkHb(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ECZlDWrDWFsraTir(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver) {
        lifecycle.addObserver(lifecycleObserver);
    }

    public static void ECZlDWrDWFsraTir(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ECZlDWrDWFsraTir(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ECZlDWrDWFsraTir(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleObserver lifecycleObserver, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WHSzCrqQeWEJiZqM(java.util.IEnumerator it, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WHSzCrqQeWEJiZqM(java.util.IEnumerator it, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WHSzCrqQeWEJiZqM(java.util.IEnumerator it, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WHSzCrqQeWEJiZqM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ZPTGNPdRMEmUtKKd(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void ZPTGNPdRMEmUtKKd(java.util.List arrayList, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZPTGNPdRMEmUtKKd(java.util.List arrayList, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZPTGNPdRMEmUtKKd(java.util.List arrayList, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    void addObserver(androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver) {
        eCZlDWrDWFsraTir(this.mLifecycle, lifecycleEventObserver);
        OBTsbbwdfuLpFvpX(this.mObservers, lifecycleEventObserver);
    }

    void clearObservers() {
        if ((28 + 16) % 16 > 0) {
        }
        java.util.IEnumerator itIuDcVzSztztvbxFl = IuDcVzSztztvbxFl(this.mObservers);
        while (wHSzCrqQeWEJiZqM(itIuDcVzSztztvbxFl)) {
            QYUnBEasisXCOkHb(this.mLifecycle, (androidx.lifecycle.LifecycleEventObserver) PGMmJJWeNSmhuGyZ(itIuDcVzSztztvbxFl));
        }
        zPTGNPdRMEmUtKKd(this.mObservers);
    }
}

