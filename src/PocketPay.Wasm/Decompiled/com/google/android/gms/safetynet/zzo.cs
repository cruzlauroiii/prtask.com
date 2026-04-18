namespace WillowMaze.Wasm.Decompiled;


readonly class zzo : com.google.android.gms.internal.safetynet.zzd {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;

    zzo(com.google.android.gms.safetynet.SafetyNetClient safetyNetClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.Status status, bool z) {
        com.google.android.gms.internal.safetynet.zzad zzadVar = new com.google.android.gms.internal.safetynet.zzad(status, z);
        com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse = new com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse();
        safetyNetApi$VerifyAppsUserResponse.setResult(zzadVar);
        com.google.android.gms.common.api.internal.TaskUtil.setResultOrApiException(status, safetyNetApi$VerifyAppsUserResponse, this.zza);
    }
}

