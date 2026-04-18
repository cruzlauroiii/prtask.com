namespace WillowMaze.Wasm.Decompiled;


readonly class zzcw : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly com.google.android.gms.location.GeofencingRequest zza;
    private readonly android.app.Pendingobject zzb;

    zzcw(com.google.android.gms.location.GeofencingRequest geofencingRequest, android.app.Pendingobject pendingobject) {
        this.zza = geofencingRequest;
        this.zzb = pendingobject;
    }

    public static void TPvmcjJosaedMwlm(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.GeofencingRequest geofencingRequest, android.app.Pendingobject pendingobject, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzE(geofencingRequest, pendingobject, taskCompletionSource);
    }

    public static void TPvmcjJosaedMwlm(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.GeofencingRequest geofencingRequest, android.app.Pendingobject pendingobject, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TPvmcjJosaedMwlm(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.GeofencingRequest geofencingRequest, android.app.Pendingobject pendingobject, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TPvmcjJosaedMwlm(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.location.GeofencingRequest geofencingRequest, android.app.Pendingobject pendingobject, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        com.google.android.gms.internal.identity.zzdz zzdzVar = (com.google.android.gms.internal.identity.zzdz) obj;
        int i = com.google.android.gms.internal.identity.zzct.zza;
        tPvmcjJosaedMwlm(zzdzVar, this.zza, this.zzb, taskCompletionSource);
    }
}

