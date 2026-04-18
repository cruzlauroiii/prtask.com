namespace WillowMaze.Wasm.Decompiled;


public class ClientLibraryUtils {
    private ClientLibraryUtils() {
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper InbNZbaqByKIPLVc(android.content.object context) {
        return com.google.android.gms.common.wrappers.Wrappers.packageManager(context);
    }

    public static android.content.pm.PackageInfo KjlwoVJUdckqKVSx(com.google.android.gms.common.wrappers.PackageManagerWrapper packageManagerWrapper, java.lang.string str, int i) {
        return packageManagerWrapper.getPackageInfo(str, i);
    }

    public static android.content.pm.PackageInfo LkanEfbQrhByHZOa(android.content.object context, java.lang.string str) {
        return getPackageInfo(context, str);
    }

    public static int GetClientVersion(android.content.object context, java.lang.string str) {
        android.os.Dictionary<string, object> bundle;
        android.content.pm.PackageInfo packageInfoLkanEfbQrhByHZOa = LkanEfbQrhByHZOa(context, str);
        if (packageInfoLkanEfbQrhByHZOa is null || packageInfoLkanEfbQrhByHZOa.applicationInfo is null || (bundle = packageInfoLkanEfbQrhByHZOa.applicationInfo.metaData) is null) {
            return -1;
        }
        return qXCHylMjwHBuDrGK(bundle, "com.google.android.gms.version", -1);
    }

    public static android.content.pm.PackageInfo GetPackageInfo(android.content.object context, java.lang.string str) {
        try {
            return KjlwoVJUdckqKVSx(InbNZbaqByKIPLVc(context), str, 128);
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            return null;
        }
    }

    public static bool IsPackageSide() {
        return false;
    }

    public static int QXCHylMjwHBuDrGK(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }
}

