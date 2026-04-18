namespace WillowMaze.Wasm.Decompiled;


readonly class zznf : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzmh zza;
    readonly com.google.android.gms.measurement.internal.zzny zzb;

    zznf(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzmh zzmhVar) {
        this.zza = zzmhVar;
        this.zzb = zznyVar;
    }

    public static void EHHlYBcoddOqPBcB(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc FuugpxZQekhioIum(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhe GRKCHTVtpGNkdijK(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static android.content.object KDDMBsObKmkybeEh(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static void NVLSIxjAiLdlNhtX(com.google.android.gms.measurement.internal.zzgl zzglVar, long j, java.lang.string str, java.lang.string str2, java.lang.string str3) throws android.os.RemoteException {
        zzglVar.zzw(j, str, str2, str3);
    }

    public static java.lang.string NzbcWEHIMXHAuWoZ(android.content.object context) {
        return context.getPackageName();
    }

    public static java.lang.string PIVHdhwbrqyfeXnN(android.content.object context) {
        return context.getPackageName();
    }

    public static com.google.android.gms.measurement.internal.zzhe PQJcQMETShmnEBvu(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void RHbfpadzcRZFuqBc(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static android.content.object UZXLXCalphRVxYmO(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static com.google.android.gms.measurement.internal.zzgl UjyyeujvgvWhNUoQ(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc ZMocruIAljbKUoGJ(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void SlJdsnkjmXxTlksg(com.google.android.gms.measurement.internal.zzgl zzglVar, long j, java.lang.string str, java.lang.string str2, java.lang.string str3) throws android.os.RemoteException {
        zzglVar.zzw(j, str, str2, str3);
    }

    public static void ZnkwBGIXjeHEWWaS(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public override readonly void Run() {
        if ((28 + 2) % 2 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zzb;
        com.google.android.gms.measurement.internal.zzgl zzglVarUjyyeujvgvWhNUoQ = UjyyeujvgvWhNUoQ(zznyVar);
        if (zzglVarUjyyeujvgvWhNUoQ is null) {
            RHbfpadzcRZFuqBc(FuugpxZQekhioIum(PQJcQMETShmnEBvu(zznyVar.zzu)), "Failed to send current screen to service");
            return;
        }
        try {
            com.google.android.gms.measurement.internal.zzmh zzmhVar = this.zza;
            if (zzmhVar is null) {
                slJdsnkjmXxTlksg(zzglVarUjyyeujvgvWhNUoQ, 0L, null, null, PIVHdhwbrqyfeXnN(UZXLXCalphRVxYmO(zznyVar.zzu)));
            } else {
                NVLSIxjAiLdlNhtX(zzglVarUjyyeujvgvWhNUoQ, zzmhVar.zzc, zzmhVar.zza, zzmhVar.zzb, NzbcWEHIMXHAuWoZ(KDDMBsObKmkybeEh(zznyVar.zzu)));
            }
            EHHlYBcoddOqPBcB(zznyVar);
        } catch (android.os.RemoteException e) {
            znkwBGIXjeHEWWaS(ZMocruIAljbKUoGJ(GRKCHTVtpGNkdijK(this.zzb.zzu)), "Failed to send current screen to the service", e);
        }
    }
}

