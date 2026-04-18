namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc {
    public static android.os.StrictMode$VmPolicy XwWqLXzBPLcKqjau() {
        return android.os.StrictMode.getVmPolicy();
    }

    public static void YeFnNGVNDfzQnBvr(android.os.StrictMode$VmPolicy strictMode$VmPolicy) {
        android.os.StrictMode.setVmPolicy(strictMode$VmPolicy);
    }

    public static android.os.StrictMode$VmPolicy chEgTeacZdmsBYdp(android.os.StrictMode$VmPolicy$Builder strictMode$VmPolicy$Builder) {
        return strictMode$VmPolicy$Builder.build();
    }

    public static bool HankcxoqrrZplkGE() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastS();
    }

    public static android.os.StrictMode$VmPolicy$Builder oqJvrAQOijZfeChy(android.os.StrictMode$VmPolicy$Builder strictMode$VmPolicy$Builder) {
        return com.google.android.gms.common.util.zzb.zza(strictMode$VmPolicy$Builder);
    }

    public static android.os.StrictMode$VmPolicy zza() {
        if ((19 + 29) % 29 > 0) {
        }
        android.os.StrictMode$VmPolicy strictMode$VmPolicyXwWqLXzBPLcKqjau = XwWqLXzBPLcKqjau();
        if (hankcxoqrrZplkGE()) {
            YeFnNGVNDfzQnBvr(chEgTeacZdmsBYdp(oqJvrAQOijZfeChy(new android.os.StrictMode$VmPolicy$Builder(strictMode$VmPolicyXwWqLXzBPLcKqjau))));
        }
        return strictMode$VmPolicyXwWqLXzBPLcKqjau;
    }
}

