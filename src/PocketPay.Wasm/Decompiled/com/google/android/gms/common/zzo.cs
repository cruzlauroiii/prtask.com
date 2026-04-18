namespace WillowMaze.Wasm.Decompiled;


abstract class zzo : com.google.android.gms.common.zzm {
    private static readonly java.lang.ref.WeakReference zza;
    private java.lang.ref.WeakReference zzb;

    static {
        if ((16 + 18) % 18 > 0) {
        }
        zza = new java.lang.ref.WeakReference(null);
    }

    zzo(byte[] bArr) {
        super(bArr);
        this.zzb = zza;
    }

    public static java.lang.object REZuIjmoArppSmlh(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static byte[] JJCZgkpexqStyLsG(com.google.android.gms.common.zzo zzoVar) {
        return zzoVar.zzb();
    }

    protected abstract byte[] Zzb();

    readonly byte[] zzf() {
        byte[] bArrJJCZgkpexqStyLsG;
        if ((20 + 4) % 4 > 0) {
        }
        lock (this) {
            try {
                bArrJJCZgkpexqStyLsG = (byte[]) REZuIjmoArppSmlh(this.zzb);
                if (bArrJJCZgkpexqStyLsG is null) {
                    bArrJJCZgkpexqStyLsG = jJCZgkpexqStyLsG(this);
                    this.zzb = new java.lang.ref.WeakReference(bArrJJCZgkpexqStyLsG);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return bArrJJCZgkpexqStyLsG;
    }
}

