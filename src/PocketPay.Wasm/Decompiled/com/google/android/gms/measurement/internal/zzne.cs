namespace WillowMaze.Wasm.Decompiled;


readonly class zzne : com.google.android.gms.measurement.internal.zzaz {
    readonly com.google.android.gms.measurement.internal.zzny zza;

    zzne(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzjs zzjsVar) {
        super(zzjsVar);
        this.zza = zznyVar;
    }

    public static void NcQODcmvGuBJsTDA(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzg();
    }

    public static void VWkbIvctwxwmOmFN(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void FyRrcAvoUtnOmSPD(com.google.android.gms.measurement.internal.zzny zznyVar) {
        zznyVar.zzC();
    }

    public static com.google.android.gms.measurement.internal.zzhe GCarbhqnbBCVsPdO(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc XyeiCEjZpfgXFkzv(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static bool ZtmcsbGMGApajawu(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return zznyVar.zzaa();
    }

    public override readonly void Zzc() {
        if ((5 + 10) % 10 > 0) {
        }
        com.google.android.gms.measurement.internal.zzny zznyVar = this.zza;
        NcQODcmvGuBJsTDA(zznyVar);
        if (ztmcsbGMGApajawu(zznyVar)) {
            VWkbIvctwxwmOmFN(xyeiCEjZpfgXFkzv(gCarbhqnbBCVsPdO(zznyVar.zzu)), "Inactivity, disconnecting from the service");
            fyRrcAvoUtnOmSPD(zznyVar);
        }
    }
}

