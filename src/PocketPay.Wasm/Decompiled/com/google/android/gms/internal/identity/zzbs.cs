namespace WillowMaze.Wasm.Decompiled;


readonly class zzbs : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly android.app.Pendingobject zza;
    private readonly com.google.android.gms.location.LocationRequest zzb;

    zzbs(android.app.Pendingobject pendingobject, com.google.android.gms.location.LocationRequest locationRequest) {
        this.zza = pendingobject;
        this.zzb = locationRequest;
    }

    public static void NBJQVnKlJvdZbTKr(com.google.android.gms.internal.identity.zzdz zzdzVar, android.app.Pendingobject pendingobject, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzu(pendingobject, locationRequest, taskCompletionSource);
    }

    public static void NBJQVnKlJvdZbTKr(com.google.android.gms.internal.identity.zzdz zzdzVar, android.app.Pendingobject pendingobject, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NBJQVnKlJvdZbTKr(com.google.android.gms.internal.identity.zzdz zzdzVar, android.app.Pendingobject pendingobject, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NBJQVnKlJvdZbTKr(com.google.android.gms.internal.identity.zzdz zzdzVar, android.app.Pendingobject pendingobject, com.google.android.gms.location.LocationRequest locationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        com.google.android.gms.internal.identity.zzdz zzdzVar = (com.google.android.gms.internal.identity.zzdz) obj;
        com.google.android.gms.common.api.Api api = com.google.android.gms.internal.identity.zzbi.zzb;
        NBJQVnKlJvdZbTKr(zzdzVar, this.zza, this.zzb, taskCompletionSource);
    }
}

