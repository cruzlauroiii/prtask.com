namespace WillowMaze.Wasm.Decompiled;


readonly class zzbj : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly com.google.android.gms.location.LastLocationRequest zza;

    zzbj(com.google.android.gms.location.LastLocationRequest lastLocationRequest) {
        this.zza = lastLocationRequest;
    }

    public static void ZkEcvGhDyvzbMwRw(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.LastLocationRequest lastLocationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzq(lastLocationRequest, taskCompletionSource);
    }

    public static void ZkEcvGhDyvzbMwRw(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.LastLocationRequest lastLocationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZkEcvGhDyvzbMwRw(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.LastLocationRequest lastLocationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZkEcvGhDyvzbMwRw(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.LastLocationRequest lastLocationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        com.google.android.gms.internal.identity.zzdz zzdzVar = (com.google.android.gms.internal.identity.zzdz) obj;
        com.google.android.gms.common.api.Api api = com.google.android.gms.internal.identity.zzbi.zzb;
        ZkEcvGhDyvzbMwRw(zzdzVar, this.zza, taskCompletionSource);
    }
}

