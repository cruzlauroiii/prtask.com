namespace WillowMaze.Wasm.Decompiled;


readonly class zzlk : com.google.android.gms.measurement.internal.zzqe {
    readonly com.google.android.gms.measurement.internal.zzlw zza;

    zzlk(com.google.android.gms.measurement.internal.zzlw zzlwVar) {
        this.zza = zzlwVar;
    }

    public static void YUTwlAEntAHteleG(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        zzlwVar.zzO(str, str2, bundle);
    }

    public static void QtoxhmKvZkveRBag(com.google.android.gms.measurement.internal.zzlw zzlwVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, java.lang.string str3) {
        zzlwVar.zzQ(str, str2, bundle, str3);
    }

    public static bool SzTSWFLtxihQClOv(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public override readonly void Zza(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        if ((6 + 25) % 25 > 0) {
        }
        if (szTSWFLtxihQClOv(str)) {
            YUTwlAEntAHteleG(this.zza, "auto", "_err", bundle);
        } else {
            qtoxhmKvZkveRBag(this.zza, "auto", "_err", bundle, str);
        }
    }
}

