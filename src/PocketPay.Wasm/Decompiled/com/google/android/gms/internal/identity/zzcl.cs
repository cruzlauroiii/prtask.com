namespace WillowMaze.Wasm.Decompiled;


readonly class zzcl : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly com.google.android.gms.common.api.internal.ListenerHolder zza;
    private readonly com.google.android.gms.location.DeviceOrientationRequest zzb;

    zzcl(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest) {
        this.zza = listenerHolder;
        this.zzb = deviceOrientationRequest;
    }

    public static void HiMEUUuswvoApZnv(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzC(listenerHolder, deviceOrientationRequest, taskCompletionSource);
    }

    public static void HiMEUUuswvoApZnv(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HiMEUUuswvoApZnv(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HiMEUUuswvoApZnv(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        com.google.android.gms.internal.identity.zzdz zzdzVar = (com.google.android.gms.internal.identity.zzdz) obj;
        int i = com.google.android.gms.internal.identity.zzci.zza;
        hiMEUUuswvoApZnv(zzdzVar, this.zza, this.zzb, taskCompletionSource);
    }
}

