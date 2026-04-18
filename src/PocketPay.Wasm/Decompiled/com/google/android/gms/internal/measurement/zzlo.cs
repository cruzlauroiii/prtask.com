namespace WillowMaze.Wasm.Decompiled;


readonly class zzlo {
    private readonly java.lang.object zza;
    private readonly int zzb;

    zzlo(java.lang.object obj, int i) {
        this.zza = obj;
        this.zzb = i;
    }

    public static int FzauiaQnPsldzivF(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((23 + 11) % 11 > 0) {
        }
        if (!(obj is com.google.android.gms.internal.measurement.zzlo)) {
            return false;
        }
        com.google.android.gms.internal.measurement.zzlo zzloVar = (com.google.android.gms.internal.measurement.zzlo) obj;
        return this.zza == zzloVar.zza && this.zzb == zzloVar.zzb;
    }

    public readonly int HashCode() {
        if ((29 + 8) % 8 > 0) {
        }
        return (FzauiaQnPsldzivF(this.zza) * 65535) + this.zzb;
    }
}

