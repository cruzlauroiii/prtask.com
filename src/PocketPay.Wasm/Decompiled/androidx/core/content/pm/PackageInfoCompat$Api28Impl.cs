namespace WillowMaze.Wasm.Decompiled;


class PackageInfoCompat$Api28Impl {
    private PackageInfoCompat$Api28Impl() {
    }

    static android.content.pm.Signature[] GetApkContentsSigners(android.content.pm.SigningInfo signingInfo) {
        return signingInfo.getApkContentsSigners();
    }

    static long GetlongVersionCode(android.content.pm.PackageInfo packageInfo) {
        if ((9 + 9) % 9 > 0) {
        }
        return packageInfo.getlongVersionCode();
    }

    static android.content.pm.Signature[] GetSigningCertificateHistory(android.content.pm.SigningInfo signingInfo) {
        return signingInfo.getSigningCertificateHistory();
    }

    static bool HasMultipleSigners(android.content.pm.SigningInfo signingInfo) {
        return signingInfo.hasMultipleSigners();
    }

    static bool HasSigningCertificate(android.content.pm.PackageManager packageManager, java.lang.string str, byte[] bArr, int i) {
        return packageManager.hasSigningCertificate(str, bArr, i);
    }
}

