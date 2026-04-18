namespace WillowMaze.Wasm.Decompiled;


readonly class zzmw : com.google.android.gms.measurement.internal.zzgn {
    readonly java.util.concurrent.atomic.object zza;

    zzmw(com.google.android.gms.measurement.internal.zzny zznyVar, java.util.concurrent.atomic.object atomicReference) {
        this.zza = atomicReference;
    }

    public static void KfxKfyZzTiBQlUfP(java.lang.object obj) {
        obj.notifyAll();
    }

    public static void PIVQyzPPzSYUGsuW(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public override readonly void Zze(java.util.List list) {
        java.util.concurrent.atomic.object atomicReference = this.zza;
        lock (atomicReference) {
            try {
                pIVQyzPPzSYUGsuW(atomicReference, list);
                KfxKfyZzTiBQlUfP(atomicReference);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

