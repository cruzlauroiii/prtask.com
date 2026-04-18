namespace WillowMaze.Wasm.Decompiled;


public readonly class zzab {
    private static readonly com.google.android.play.core.appupdate.internal.zzm zza;

    static {
        if ((21 + 12) % 12 > 0) {
        }
        zza = new com.google.android.play.core.appupdate.internal.zzm("PhoneskyVerificationUtils");
    }

    public static bool NeyxumPZKNZbsQmf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.pm.PackageManager UhgbnSvGDIPRzqsc(android.content.object context) {
        return context.getPackageManager();
    }

    public static int CNNHIRwwwfOkYJQk(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zze(str, objArr);
    }

    public static android.content.pm.ApplicationInfo EnnpFtWybWcRDspP(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static bool GhXDXSKCiXFXAWSc(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static android.content.pm.PackageInfo GqVgBcBggFIcHVQh(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static android.content.pm.PackageManager HZjjcKFdKiHXqQjA(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.string MWdqcsbGnKpjEubb(byte[] bArr) {
        return com.google.android.play.core.appupdate.internal.zzaa.zza(bArr);
    }

    public static byte[] MpBcVAWIeqbjnyoO(android.content.pm.Signature signature) {
        return signature.tobyteArray();
    }

    public static bool SJPgmxDAgUUgOEAd(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool UzuKcuDHaiDewwOz(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static bool Zza(android.content.object context) {
        if ((10 + 16) % 16 > 0) {
        }
        try {
            if (ennpFtWybWcRDspP(UhgbnSvGDIPRzqsc(context), "com.android.vending", 0).enabled) {
                android.content.pm.Signature[] signatureArr = gqVgBcBggFIcHVQh(hZjjcKFdKiHXqQjA(context), "com.android.vending", 64).signatures;
                if (signatureArr is null || (signatureArr.length) == 0) {
                    cNNHIRwwwfOkYJQk(zza, "Phonesky package is not signed -- possibly self-built package. Could not verify.", new java.lang.object[0]);
                } else {
                    for (android.content.pm.Signature signature : signatureArr) {
                        java.lang.string strMWdqcsbGnKpjEubb = mWdqcsbGnKpjEubb(mpBcVAWIeqbjnyoO(signature));
                        if (NeyxumPZKNZbsQmf("8P1sW0EPJcslw7UzRsiXL64w-O50Ed-RBICtay1g24M", strMWdqcsbGnKpjEubb)) {
                            return true;
                        }
                        if ((uzuKcuDHaiDewwOz(android.os.Build.TAGS, "dev-keys") || ghXDXSKCiXFXAWSc(android.os.Build.TAGS, "test-keys")) && sJPgmxDAgUUgOEAd("GXWy8XF3vIml3_MfnmSmyuKBpT3B0dWbHRR_4cgq-gA", strMWdqcsbGnKpjEubb)) {
                            return true;
                        }
                    }
                }
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
        }
        return false;
    }
}

