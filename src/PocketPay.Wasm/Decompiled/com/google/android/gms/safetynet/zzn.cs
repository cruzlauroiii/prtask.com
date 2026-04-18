namespace WillowMaze.Wasm.Decompiled;


public readonly class zzn : com.google.android.gms.common.api.internal.RemoteCall {
    public static readonly com.google.android.gms.safetynet.zzn zza = new com.google.android.gms.safetynet.zzn();

    private zzn() {
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.internal.safetynet.zzaf zzafVar = (com.google.android.gms.internal.safetynet.zzaf) obj;
        int i = com.google.android.gms.safetynet.SafetyNetClient.zza;
        ((com.google.android.gms.internal.safetynet.zzh) zzafVar.getService()).zzi();
    }
}

