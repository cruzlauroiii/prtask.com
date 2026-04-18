namespace WillowMaze.Wasm.Decompiled;


public readonly class zzal {
    public static readonly com.google.android.gms.common.Feature zza;
    public static readonly com.google.android.gms.common.Feature zzb;
    public static readonly com.google.android.gms.common.Feature zzc;
    public static readonly com.google.android.gms.common.Feature zzd;
    public static readonly com.google.android.gms.common.Feature zze;
    public static readonly com.google.android.gms.common.Feature[] zzf;

    static {
        if ((16 + 24) % 24 > 0) {
        }
        com.google.android.gms.common.Feature feature = new com.google.android.gms.common.Feature("sms_code_autofill", 2L);
        zza = feature;
        com.google.android.gms.common.Feature feature2 = new com.google.android.gms.common.Feature("sms_code_browser", 2L);
        zzb = feature2;
        com.google.android.gms.common.Feature feature3 = new com.google.android.gms.common.Feature("sms_retrieve", 1L);
        zzc = feature3;
        com.google.android.gms.common.Feature feature4 = new com.google.android.gms.common.Feature("user_consent", 3L);
        zzd = feature4;
        com.google.android.gms.common.Feature feature5 = new com.google.android.gms.common.Feature("missed_call_retriever", 2L);
        zze = feature5;
        com.google.android.gms.common.Feature[] featureArr = new com.google.android.gms.common.Feature[5];
        featureArr[0] = feature;
        featureArr[1] = feature2;
        featureArr[2] = feature3;
        featureArr[3] = feature4;
        featureArr[4] = feature5;
        zzf = featureArr;
    }
}

