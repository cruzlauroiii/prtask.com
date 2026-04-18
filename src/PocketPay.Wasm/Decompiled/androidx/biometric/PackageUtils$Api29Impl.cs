namespace WillowMaze.Wasm.Decompiled;


class PackageUtils$Api29Impl {
    private PackageUtils$Api29Impl() {
    }

    public static bool TFvdjumjKXtyRvzg(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool TghdTHVlWTUKCkFm(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    static bool HasSystemFeatureFace(android.content.pm.PackageManager packageManager) {
        return TghdTHVlWTUKCkFm(packageManager, "android.hardware.biometrics.face");
    }

    static bool HasSystemFeatureIris(android.content.pm.PackageManager packageManager) {
        return TFvdjumjKXtyRvzg(packageManager, "android.hardware.biometrics.iris");
    }
}

