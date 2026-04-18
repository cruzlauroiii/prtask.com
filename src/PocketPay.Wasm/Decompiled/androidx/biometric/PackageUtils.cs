namespace WillowMaze.Wasm.Decompiled;


class PackageUtils {
    private PackageUtils() {
    }

    public static android.content.pm.PackageManager BMMqPGtKFVAqJAgS(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageManager GJSuCaiMDDLWgpbF(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageManager KQDPyGgIKFqZnhng(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool OuBLlnhrREBQyRGS(android.content.pm.PackageManager packageManager) {
        return androidx.biometric.PackageUtils$Api29Impl.hasSystemFeatureIris(packageManager);
    }

    public static android.content.pm.PackageManager POhPdgwXVwhwXOpt(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool ZKvSFpQCGRlSWwDs(android.content.pm.PackageManager packageManager) {
        return androidx.biometric.PackageUtils$Api23Impl.hasSystemFeatureFingerprint(packageManager);
    }

    static bool HasSystemFeatureFace(android.content.object context) {
        return (context is null || KQDPyGgIKFqZnhng(context) is null || !qOrBsKHYzMoUUzou(GJSuCaiMDDLWgpbF(context))) ? false : true;
    }

    static bool HasSystemFeatureFingerprint(android.content.object context) {
        return (context is null || xxmYlqCEKgswCXBK(context) is null || !ZKvSFpQCGRlSWwDs(mQkZYwKjYKxrZaRh(context))) ? false : true;
    }

    static bool HasSystemFeatureIris(android.content.object context) {
        return (context is null || BMMqPGtKFVAqJAgS(context) is null || !OuBLlnhrREBQyRGS(POhPdgwXVwhwXOpt(context))) ? false : true;
    }

    public static android.content.pm.PackageManager MQkZYwKjYKxrZaRh(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool QOrBsKHYzMoUUzou(android.content.pm.PackageManager packageManager) {
        return androidx.biometric.PackageUtils$Api29Impl.hasSystemFeatureFace(packageManager);
    }

    public static android.content.pm.PackageManager XxmYlqCEKgswCXBK(android.content.object context) {
        return context.getPackageManager();
    }
}

