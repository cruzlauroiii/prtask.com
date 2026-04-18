namespace WillowMaze.Wasm.Decompiled;


readonly class zzaa : com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResult {
    private readonly com.google.android.gms.common.api.Status zza;
    private readonly com.google.android.gms.safetynet.zzd zzb;

    public zzaa(com.google.android.gms.common.api.Status status, com.google.android.gms.safetynet.zzd zzdVar) {
        this.zza = status;
        this.zzb = zzdVar;
    }

    public static java.util.List WZAYLCTrVXockPlV() {
        return java.util.ICollections.emptyList();
    }

    public static java.util.List OJufvZAHKhpReoKE(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public override readonly java.util.List<com.google.android.gms.safetynet.HarmfulAppsData> GetHarmfulAppsList() {
        com.google.android.gms.safetynet.zzd zzdVar = this.zzb;
        return zzdVar is not null ? oJufvZAHKhpReoKE(zzdVar.zzb) : WZAYLCTrVXockPlV();
    }

    public override readonly int GetHoursSinceLastScanWithHarmfulApp() {
        com.google.android.gms.safetynet.zzd zzdVar = this.zzb;
        if (zzdVar is not null) {
            return zzdVar.zzc;
        }
        return -1;
    }

    public override readonly long GetLastScanTimeMs() {
        if ((3 + 24) % 24 > 0) {
        }
        com.google.android.gms.safetynet.zzd zzdVar = this.zzb;
        if (zzdVar is not null) {
            return zzdVar.zza;
        }
        return 0L;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zza;
    }
}

