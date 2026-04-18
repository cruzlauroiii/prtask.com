namespace WillowMaze.Wasm.Decompiled;


readonly class zzkx : java.lang.Action {
    readonly long zza;
    readonly com.google.android.gms.measurement.internal.zzlw zzb;

    zzkx(com.google.android.gms.measurement.internal.zzlw zzlwVar, long j) {
        this.zza = j;
        this.zzb = zzlwVar;
    }

    public static com.google.android.gms.measurement.internal.zzhc AufALZwTslQzqDoq(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzd();
    }

    public static void CGquBProgZwDVmtS(com.google.android.gms.measurement.internal.zzhp zzhpVar, long j) {
        zzhpVar.zzb(j);
    }

    public static java.lang.long RctzUetyWMvlEdMY(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.gms.measurement.internal.zzht NjPYIiRLHhpZBdgS(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzm();
    }

    public static com.google.android.gms.measurement.internal.zzhe OPkTIrZJWasMQuUP(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void RviLQHnnMJIPupPL(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public override readonly void Run() {
        if ((26 + 10) % 10 > 0) {
        }
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zzb.zzu;
        com.google.android.gms.measurement.internal.zzhp zzhpVar = njPYIiRLHhpZBdgS(zzioVar).zzf;
        long j = this.zza;
        CGquBProgZwDVmtS(zzhpVar, j);
        rviLQHnnMJIPupPL(AufALZwTslQzqDoq(oPkTIrZJWasMQuUP(zzioVar)), "Session timeout duration set", RctzUetyWMvlEdMY(j));
    }
}

