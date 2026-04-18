namespace WillowMaze.Wasm.Decompiled;


readonly class zzpq : com.google.android.gms.measurement.internal.zzqe {
    readonly com.google.android.gms.measurement.internal.zzpv zza;

    zzpq(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        this.zza = zzpvVar;
    }

    public override readonly void Zza(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        if ((25 + 24) % 24 > 0) {
        }
        if (!android.text.TextUtils.isEmpty(str)) {
            this.zza.zzaX().zzq(new com.google.android.gms.measurement.internal.zzpp(this, str, str2, bundle));
            return;
        }
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zza;
        if (com.google.android.gms.measurement.internal.zzpv.zzs(zzpvVar) is null) {
            return;
        }
        com.google.android.gms.measurement.internal.zzpv.zzs(zzpvVar).zzaW().zze().zzb("AppId not known when logging event", str2);
    }
}

