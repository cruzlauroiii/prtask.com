namespace WillowMaze.Wasm.Decompiled;


class PackageUtils$Api23Impl {
    private PackageUtils$Api23Impl() {
    }

    static bool HasSystemFeatureFingerprint(android.content.pm.PackageManager packageManager) {
        return kHIwscvjufkHdFve(packageManager, "android.hardware.fingerprint");
    }

    public static bool KHIwscvjufkHdFve(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }
}

