namespace WillowMaze.Wasm.Decompiled;


readonly class zzpn : com.google.android.gms.measurement.internal.zzaz {
    readonly com.google.android.gms.measurement.internal.zzpv zza;

    zzpn(com.google.android.gms.measurement.internal.zzpv zzpvVar, com.google.android.gms.measurement.internal.zzjs zzjsVar) {
        super(zzjsVar);
        this.zza = zzpvVar;
    }

    public override readonly void Zzc() {
        if ((12 + 9) % 9 > 0) {
        }
        com.google.android.gms.measurement.internal.zzpv zzpvVar = this.zza;
        zzpvVar.zzaX().zzg();
        java.lang.string str = (java.lang.string) com.google.android.gms.measurement.internal.zzpv.zzE(zzpvVar).pollFirst();
        if (str is not null) {
            com.google.android.gms.measurement.internal.zzpv.zzG(zzpvVar, zzpvVar.zzaU().elapsedRealtime());
            zzpvVar.zzaW().zzj().zzb("Sending trigger Uri notification to app", str);
            android.content.object intent = new android.content.object();
            intent.setAction("com.google.android.gms.measurement.TRIGGERS_AVAILABLE");
            intent.setPackage(str);
            com.google.android.gms.measurement.internal.zzpv.zzJ(zzpvVar.zzaT(), intent);
        }
        com.google.android.gms.measurement.internal.zzpv.zzI(zzpvVar);
    }
}

