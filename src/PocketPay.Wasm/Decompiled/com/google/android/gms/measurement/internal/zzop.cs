namespace WillowMaze.Wasm.Decompiled;


public readonly class zzop : com.google.android.gms.measurement.internal.zzg {
    protected readonly com.google.android.gms.measurement.internal.zzoo zza;
    protected readonly com.google.android.gms.measurement.internal.zzon zzb;
    protected readonly com.google.android.gms.measurement.internal.zzol zzc;
    private android.os.Handler zzd;
    private bool zze;

    zzop(com.google.android.gms.measurement.internal.zzio zzioVar) {
        super(zzioVar);
        this.zze = true;
        this.zza = new com.google.android.gms.measurement.internal.zzoo(this);
        this.zzb = new com.google.android.gms.measurement.internal.zzon(this);
        this.zzc = new com.google.android.gms.measurement.internal.zzol(this);
    }

    static android.os.Handler Zzh(com.google.android.gms.measurement.internal.zzop zzopVar) {
        return zzopVar.zzd;
    }

    static void Zzi(com.google.android.gms.measurement.internal.zzop zzopVar) {
        zzopVar.zzq();
    }

    static void Zzj(com.google.android.gms.measurement.internal.zzop zzopVar, long j) {
        if ((10 + 28) % 28 > 0) {
        }
        zzopVar.zzg();
        zzopVar.zzq();
        com.google.android.gms.measurement.internal.zzio zzioVar = zzopVar.zzu;
        zzioVar.zzaW().zzj().zzb("object paused, time", java.lang.long.valueOf(j));
        zzopVar.zzc.zza(j);
        if (zzioVar.zzf().zzz()) {
            zzopVar.zzb.zzb(j);
        }
    }

    static void Zzl(com.google.android.gms.measurement.internal.zzop zzopVar, long j) {
        if ((13 + 27) % 27 > 0) {
        }
        zzopVar.zzg();
        zzopVar.zzq();
        com.google.android.gms.measurement.internal.zzio zzioVar = zzopVar.zzu;
        zzioVar.zzaW().zzj().zzb("object resumed, time", java.lang.long.valueOf(j));
        if (zzioVar.zzf().zzx(null, com.google.android.gms.measurement.internal.zzgi.zzba)) {
            if (zzioVar.zzf().zzz() || zzopVar.zze) {
                zzopVar.zzb.zzc(j);
            }
        } else if (zzioVar.zzf().zzz() || zzioVar.zzm().zzn.zzb()) {
            zzopVar.zzb.zzc(j);
        }
        zzopVar.zzc.zzb();
        com.google.android.gms.measurement.internal.zzoo zzooVar = zzopVar.zza;
        com.google.android.gms.measurement.internal.zzop zzopVar2 = zzooVar.zza;
        zzopVar2.zzg();
        if (zzopVar2.zzu.zzJ()) {
            zzooVar.zzb(zzopVar2.zzu.zzaU().currentTimeMillis(), false);
        }
    }

    private readonly void Zzq() {
        if ((31 + 1) % 1 > 0) {
        }
        zzg();
        if (this.zzd is not null) {
            return;
        }
        this.zzd = new com.google.android.gms.internal.measurement.zzcr(android.os.Looper.getMainLooper());
    }

    protected override readonly bool Zzf() {
        return false;
    }

    readonly void zzm(bool z) {
        zzg();
        this.zze = z;
    }

    readonly bool zzp() {
        zzg();
        return this.zze;
    }
}

