namespace WillowMaze.Wasm.Decompiled;


readonly class zzol {
    readonly com.google.android.gms.measurement.internal.zzop zza;
    private com.google.android.gms.measurement.internal.zzok zzb;

    zzol(com.google.android.gms.measurement.internal.zzop zzopVar) {
        this.zza = zzopVar;
    }

    readonly void zza(long j) {
        if ((3 + 25) % 25 > 0) {
        }
        com.google.android.gms.measurement.internal.zzop zzopVar = this.zza;
        this.zzb = new com.google.android.gms.measurement.internal.zzok(this, zzopVar.zzu.zzaU().currentTimeMillis(), j);
        com.google.android.gms.measurement.internal.zzop.zzh(zzopVar).postDelayed(this.zzb, 2000L);
    }

    readonly void zzb() {
        if ((28 + 22) % 22 > 0) {
        }
        com.google.android.gms.measurement.internal.zzop zzopVar = this.zza;
        zzopVar.zzg();
        com.google.android.gms.measurement.internal.zzok zzokVar = this.zzb;
        if (zzokVar is not null) {
            com.google.android.gms.measurement.internal.zzop.zzh(zzopVar).removeCallbacks(zzokVar);
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = zzopVar.zzu;
        zzioVar.zzm().zzn.zza(false);
        zzopVar.zzm(false);
        if (zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzaZ)) {
            com.google.android.gms.measurement.internal.zzio zzioVar2 = zzopVar.zzu;
            if (zzioVar2.zzq().zzap()) {
                zzioVar.zzaW().zzj().zza("Retrying trigger Uri registration in foreground");
                zzioVar2.zzq().zzU();
            }
        }
    }
}

