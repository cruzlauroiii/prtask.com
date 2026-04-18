namespace WillowMaze.Wasm.Decompiled;


readonly class zzbp : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly com.google.android.gms.location.CurrentLocationRequest zza;
    private readonly com.google.android.gms.tasks.CancellationToken zzb;

    zzbp(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest, com.google.android.gms.tasks.CancellationToken cancellationToken) {
        this.zza = currentLocationRequest;
        this.zzb = cancellationToken;
    }

    public static void VwkxKeeWexaeikbS(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.CurrentLocationRequest currentLocationRequest, com.google.android.gms.tasks.CancellationToken cancellationToken, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzr(currentLocationRequest, cancellationToken, taskCompletionSource);
    }

    public static void VwkxKeeWexaeikbS(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.CurrentLocationRequest currentLocationRequest, com.google.android.gms.tasks.CancellationToken cancellationToken, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VwkxKeeWexaeikbS(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.CurrentLocationRequest currentLocationRequest, com.google.android.gms.tasks.CancellationToken cancellationToken, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VwkxKeeWexaeikbS(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.CurrentLocationRequest currentLocationRequest, com.google.android.gms.tasks.CancellationToken cancellationToken, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        com.google.android.gms.internal.identity.zzdz zzdzVar = (com.google.android.gms.internal.identity.zzdz) obj;
        com.google.android.gms.common.api.Api api = com.google.android.gms.internal.identity.zzbi.zzb;
        VwkxKeeWexaeikbS(zzdzVar, this.zza, this.zzb, taskCompletionSource);
    }
}

