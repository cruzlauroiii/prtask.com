namespace WillowMaze.Wasm.Decompiled;


readonly class zzy : com.google.android.gms.internal.safetynet.zzd {
    readonly com.google.android.gms.internal.safetynet.zzz zza;

    zzy(com.google.android.gms.internal.safetynet.zzz zzzVar) {
        this.zza = zzzVar;
    }

    public static void LchIaETVhumxRdWS(com.google.android.gms.internal.safetynet.zzz zzzVar, com.google.android.gms.common.api.Result result) {
        zzzVar.setResult(result);
    }

    public override readonly void Zzj(com.google.android.gms.common.api.Status status, com.google.android.gms.safetynet.SafeBrowsingData safeBrowsingData) {
        lchIaETVhumxRdWS(this.zza, new com.google.android.gms.internal.safetynet.zzac(status, safeBrowsingData));
    }
}

