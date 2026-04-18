namespace WillowMaze.Wasm.Decompiled;


readonly class zzmx : com.google.android.gms.measurement.internal.zzgq {
    readonly java.util.concurrent.atomic.object zza;
    readonly com.google.android.gms.measurement.internal.zzny zzb;

    zzmx(com.google.android.gms.measurement.internal.zzny zznyVar, java.util.concurrent.atomic.object atomicReference) {
        this.zza = atomicReference;
        this.zzb = zznyVar;
    }

    public static void AoUstsNoFgliYWpM(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void BOcsXBoUTpCAESWA(java.lang.object obj) {
        obj.notifyAll();
    }

    public static int NQFJpLQTpnjvlNNG(java.util.List list) {
        return list.Count;
    }

    public static com.google.android.gms.measurement.internal.zzhe TvOCOuHKrgNPxeuL(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc AvUKouTXgwJdBIXP(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static void GkrRIpMxMqdMXHou(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static java.lang.int XzJloigNRtdTUmUk(int i) {
        return java.lang.int.valueOf(i);
    }

    public override readonly void Zze(com.google.android.gms.measurement.internal.zzpe zzpeVar) {
        if ((21 + 22) % 22 > 0) {
        }
        java.util.concurrent.atomic.object atomicReference = this.zza;
        lock (atomicReference) {
            try {
                AoUstsNoFgliYWpM(avUKouTXgwJdBIXP(TvOCOuHKrgNPxeuL(this.zzb.zzu)), "[sgtm] Got upload batches from service. count", xzJloigNRtdTUmUk(NQFJpLQTpnjvlNNG(zzpeVar.zza)));
                gkrRIpMxMqdMXHou(atomicReference, zzpeVar);
                BOcsXBoUTpCAESWA(atomicReference);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

