namespace WillowMaze.Wasm.Decompiled;


public readonly class zzm : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.safetynet.SafetyNetClient zza;

    public zzm(com.google.android.gms.safetynet.SafetyNetClient safetyNetClient) {
        this.zza = safetyNetClient;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.internal.safetynet.zzaf zzafVar = (com.google.android.gms.internal.safetynet.zzaf) obj;
        ((com.google.android.gms.internal.safetynet.zzh) zzafVar.getService()).zzf(new com.google.android.gms.safetynet.zzo(this.zza, (com.google.android.gms.tasks.TaskCompletionSource) obj2));
    }
}

