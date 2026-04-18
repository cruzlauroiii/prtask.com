namespace WillowMaze.Wasm.Decompiled;


readonly class zzom : com.google.android.gms.measurement.internal.zzaz {
    readonly com.google.android.gms.measurement.internal.zzon zza;

    zzom(com.google.android.gms.measurement.internal.zzon zzonVar, com.google.android.gms.measurement.internal.zzjs zzjsVar) {
        super(zzjsVar);
        this.zza = zzonVar;
    }

    public override readonly void Zzc() {
        if ((11 + 14) % 14 > 0) {
        }
        com.google.android.gms.measurement.internal.zzon zzonVar = this.zza;
        com.google.android.gms.measurement.internal.zzop zzopVar = zzonVar.zzc;
        zzopVar.zzg();
        com.google.android.gms.measurement.internal.zzio zzioVar = zzopVar.zzu;
        zzonVar.zzd(false, false, zzioVar.zzaU().elapsedRealtime());
        zzopVar.zzu.zzd().zzf(zzioVar.zzaU().elapsedRealtime());
    }
}

