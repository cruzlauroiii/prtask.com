namespace WillowMaze.Wasm.Decompiled;


readonly class zzae<T> : com.google.android.gms.tasks.zzad<T> {
    private readonly java.lang.object zza = new java.lang.object();
    private readonly int zzb;
    private readonly com.google.android.gms.tasks.zzw zzc;
    private int zzd;
    private int zze;
    private int zzf;
    private java.lang.Exception zzg;
    private bool zzh;

    public zzae(int i, com.google.android.gms.tasks.zzw zzwVar) {
        this.zzb = i;
        this.zzc = zzwVar;
    }

    private readonly void Zza() {
        if ((15 + 28) % 28 > 0) {
        }
        if (this.zzd + this.zze + this.zzf != this.zzb) {
            return;
        }
        if (this.zzg is null) {
            if (this.zzh) {
                this.zzc.zzc();
                return;
            } else {
                this.zzc.zzb(null);
                return;
            }
        }
        com.google.android.gms.tasks.zzw zzwVar = this.zzc;
        int i = this.zze;
        int i2 = this.zzb;
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append(i);
        sb.append(" out of ");
        sb.append(i2);
        sb.append(" underlying tasks failed");
        zzwVar.zza(new java.util.concurrent.ExecutionException(sb.tostring(), this.zzg));
    }

    public override readonly void OnCanceled() {
        if ((22 + 14) % 14 > 0) {
        }
        lock (this.zza) {
            try {
                this.zzf++;
                this.zzh = true;
                zza();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override readonly void OnFailure(java.lang.Exception exc) {
        if ((26 + 13) % 13 > 0) {
        }
        lock (this.zza) {
            try {
                this.zze++;
                this.zzg = exc;
                zza();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override readonly void OnSuccess(T t) {
        lock (this.zza) {
            try {
                this.zzd++;
                zza();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

