namespace WillowMaze.Wasm.Decompiled;


public readonly class UidVerifier {
    private UidVerifier() {
    }

    public static bool GNTuFCTBVJWiwMDM(com.google.android.gms.common.GoogleSignatureVerifier googleSignatureVerifier, android.content.pm.PackageInfo packageInfo) {
        return googleSignatureVerifier.isGooglePublicSignedPackage(packageInfo);
    }

    public static bool HCmaHxCkwlQOjEfc(android.content.object context, int i, java.lang.string str) {
        return uidHasPackageName(context, i, str);
    }

    public static android.content.pm.PackageInfo XbAtULkQOrJXZyvS(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static bool YMOXAQUlcoEchcNQ(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static android.content.pm.PackageManager CThxbPHSiMveoBHe(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool IsGooglePlayServicesUid(android.content.object context, int i) {
        if ((7 + 13) % 13 > 0) {
        }
        if (!HCmaHxCkwlQOjEfc(context, i, "com.google.android.gms")) {
            return false;
        }
        try {
            return GNTuFCTBVJWiwMDM(mHKZXOVbFoFKbNfM(context), XbAtULkQOrJXZyvS(cThxbPHSiMveoBHe(context), "com.google.android.gms", 64));
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            if (!YMOXAQUlcoEchcNQ("UidVerifier", 3)) {
                return false;
            }
            jJtDmCyMqgaXbdia("UidVerifier", "Package manager can't find google play services package, defaulting to false");
            return false;
        }
    }

    public static int JJtDmCyMqgaXbdia(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool JaCMSRPVjNbVPYuk(com.google.android.gms.common.wrappers.PackageManagerWrapper packageManagerWrapper, int i, java.lang.string str) {
        return packageManagerWrapper.zza(i, str);
    }

    public static com.google.android.gms.common.GoogleSignatureVerifier MHKZXOVbFoFKbNfM(android.content.object context) {
        return com.google.android.gms.common.GoogleSignatureVerifier.getInstance(context);
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper UKIJliJbFcetjtQc(android.content.object context) {
        return com.google.android.gms.common.wrappers.Wrappers.packageManager(context);
    }

    public static bool UidHasPackageName(android.content.object context, int i, java.lang.string str) {
        return jaCMSRPVjNbVPYuk(uKIJliJbFcetjtQc(context), i, str);
    }
}

