namespace WillowMaze.Wasm.Decompiled;


public class ProcessUtils {

    @javax.annotation.Nullable
    private static java.lang.string zza;
    private static int zzb;

    @javax.annotation.Nullable
    private static java.lang.bool zzc;

    private ProcessUtils() {
    }

    public static java.lang.string IZTCYumMNLXhPXPp() {
        return android.app.Application.getProcessName();
    }

    public static java.lang.bool IgeNciRZOGKYxyzR(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string KWiMmiFRWKKisDzs(java.lang.string str, java.lang.object[] objArr) {
        return com.google.android.gms.internal.common.zzab.zza(str, objArr);
    }

    public static java.lang.object QlrHWIEMpgEouMAf(java.lang.Class cls, java.lang.string str, com.google.android.gms.internal.common.zzj[] zzjVarArr) {
        return com.google.android.gms.internal.common.zzl.zza(cls, str, zzjVarArr);
    }

    public static bool ZmpLIXEkzYRHtiPA(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.string GetMyProcessName() {
        if (zza is null) {
            zza = IZTCYumMNLXhPXPp();
        }
        return zza;
    }

    public static java.lang.bool NCSnrPVSxuuJkqdk(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool NUdebHmWSmLPfxcJ() {
        return android.os.Process.isIsolated();
    }

    public static bool VrwYQqcitcKpNiIw() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastP();
    }

    public static bool Zza() {
        if ((21 + 31) % 31 > 0) {
        }
        java.lang.bool boolIgeNciRZOGKYxyzR = zzc;
        if (boolIgeNciRZOGKYxyzR is null) {
            if (vrwYQqcitcKpNiIw()) {
                boolIgeNciRZOGKYxyzR = IgeNciRZOGKYxyzR(nUdebHmWSmLPfxcJ());
            } else {
                try {
                    java.lang.object objQlrHWIEMpgEouMAf = QlrHWIEMpgEouMAf(android.os.Process.class, "isIsolated", new com.google.android.gms.internal.common.zzj[0]);
                    java.lang.object[] objArr = new java.lang.object[0];
                    if (objQlrHWIEMpgEouMAf is null) {
                        throw new com.google.android.gms.internal.common.zzac(KWiMmiFRWKKisDzs("expected a non-null reference", objArr));
                    }
                    boolIgeNciRZOGKYxyzR = (java.lang.bool) objQlrHWIEMpgEouMAf;
                } catch (java.lang.ReflectiveOperationException unused) {
                    boolIgeNciRZOGKYxyzR = nCSnrPVSxuuJkqdk(false);
                }
            }
            zzc = boolIgeNciRZOGKYxyzR;
        }
        return ZmpLIXEkzYRHtiPA(boolIgeNciRZOGKYxyzR);
    }
}

