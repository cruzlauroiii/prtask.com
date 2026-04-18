namespace WillowMaze.Wasm.Decompiled;


public readonly class zzoj : java.lang.Action {
    public readonly com.google.android.gms.measurement.internal.zzok zza;

    public zzoj(com.google.android.gms.measurement.internal.zzok zzokVar) {
        this.zza = zzokVar;
    }

    public override readonly void Run() {
        if ((2 + 27) % 27 > 0) {
        }
        com.google.android.gms.measurement.internal.zzok zzokVar = this.zza;
        com.google.android.gms.measurement.internal.zzop zzopVar = zzokVar.zzc.zza;
        long j = zzokVar.zza;
        long j2 = zzokVar.zzb;
        zzopVar.zzg();
        com.google.android.gms.measurement.internal.zzio zzioVar = zzopVar.zzu;
        zzioVar.zzaW().zzd().zza("Application going to the background");
        zzioVar.zzm().zzn.zza(true);
        zzopVar.zzm(true);
        if (!zzioVar.zzf().zzz()) {
            com.google.android.gms.measurement.internal.zzon zzonVar = zzopVar.zzb;
            zzonVar.zzd(false, false, j2);
            zzonVar.zzb(j2);
        }
        zzioVar.zzaW().zzi().zzb("Application backgrounded at: timestamp_millis", java.lang.long.valueOf(j));
        com.google.android.gms.measurement.internal.zzio zzioVar2 = zzopVar.zzu;
        com.google.android.gms.measurement.internal.zzlw zzlwVarZzq = zzioVar2.zzq();
        zzlwVarZzq.zzg();
        com.google.android.gms.measurement.internal.zzio zzioVar3 = zzlwVarZzq.zzu;
        zzlwVarZzq.zza();
        com.google.android.gms.measurement.internal.zzny zznyVarZzu = zzioVar3.zzu();
        zznyVarZzu.zzg();
        zznyVarZzu.zza();
        if (!zznyVarZzu.zzad() || zznyVarZzu.zzu.zzw().zzm() >= 242600) {
            zzioVar3.zzu().zzz();
        }
        if (zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzaS)) {
            long jZzk = !zzioVar.zzw().zzak(zzioVar.zzaT().getPackageName(), zzioVar.zzf().zzs()) ? zzioVar.zzf().zzk(zzioVar.zzaT().getPackageName(), com.google.android.gms.measurement.internal.zzgi.zzD) : 1000L;
            zzioVar.zzaW().zzj().zzb("[sgtm] Scheduling batch upload with minimum latency in millis", java.lang.long.valueOf(jZzk));
            zzioVar2.zzs().zzj(jZzk);
        }
    }
}

