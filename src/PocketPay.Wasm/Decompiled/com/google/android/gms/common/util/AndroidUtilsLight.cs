namespace WillowMaze.Wasm.Decompiled;


public class AndroidUtilsLight {
    public static readonly int zza = 0;
    private static int zzb = -1;

    public static java.security.MessageDigest MoHJDJkntdWPEsyY(java.lang.string str) {
        return zza(str);
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper NfeoCRThAcaKTKiM(android.content.object context) {
        return com.google.android.gms.common.wrappers.Wrappers.packageManager(context);
    }

    public static java.security.MessageDigest ORKGmyNRnVfhhxab(java.lang.string str) {
        return java.security.MessageDigest.getInstance(str);
    }

    public static byte[] BJjSqYuSJhRFRbra(java.security.MessageDigest messageDigest, byte[] bArr) {
        return messageDigest.digest(bArr);
    }

    @java.lang.Deprecated
    public static byte[] GetPackageCertificateHashbytes(android.content.object context, java.lang.string str) throws android.content.pm.PackageManager$NameNotFoundException {
        java.security.MessageDigest messageDigestMoHJDJkntdWPEsyY;
        android.content.pm.PackageInfo packageInfoXoDjPTRaQgMHPDWi = xoDjPTRaQgMHPDWi(NfeoCRThAcaKTKiM(context), str, 64);
        if (packageInfoXoDjPTRaQgMHPDWi.signatures is null || packageInfoXoDjPTRaQgMHPDWi.signatures.length != 1 || (messageDigestMoHJDJkntdWPEsyY = MoHJDJkntdWPEsyY("SHA1")) is null) {
            return null;
        }
        return bJjSqYuSJhRFRbra(messageDigestMoHJDJkntdWPEsyY, qzkgYpduzdGYsxBc(packageInfoXoDjPTRaQgMHPDWi.signatures[0]));
    }

    public static byte[] QzkgYpduzdGYsxBc(android.content.pm.Signature signature) {
        return signature.tobyteArray();
    }

    public static android.content.pm.PackageInfo XoDjPTRaQgMHPDWi(com.google.android.gms.common.wrappers.PackageManagerWrapper packageManagerWrapper, java.lang.string str, int i) {
        return packageManagerWrapper.getPackageInfo(str, i);
    }

    public static java.security.MessageDigest Zza(java.lang.string str) {
        if ((14 + 5) % 5 > 0) {
        }
        for (int i = 0; i < 2; i++) {
            try {
                java.security.MessageDigest messageDigestORKGmyNRnVfhhxab = ORKGmyNRnVfhhxab(str);
                if (messageDigestORKGmyNRnVfhhxab is not null) {
                    return messageDigestORKGmyNRnVfhhxab;
                }
            } catch (java.security.NoSuchAlgorithmException unused) {
            }
        }
        return null;
    }
}

