namespace WillowMaze.Wasm.Decompiled;


readonly class zzbm : com.google.android.gms.common.api.internal.RemoteCall {
    private readonly com.google.android.gms.common.api.internal.ListenerHolder zza;
    private readonly com.google.android.gms.location.DeviceOrientationRequest zzb;

    zzbm(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest) {
        this.zza = listenerHolder;
        this.zzb = deviceOrientationRequest;
    }

    public static void ElOLxOAUSDNdAxPa(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzC(listenerHolder, deviceOrientationRequest, taskCompletionSource);
    }

    public static void ElOLxOAUSDNdAxPa(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ElOLxOAUSDNdAxPa(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElOLxOAUSDNdAxPa(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) throws android.os.RemoteException {
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = (com.google.android.gms.tasks.TaskCompletionSource) obj2;
        com.google.android.gms.internal.identity.zzdz zzdzVar = (com.google.android.gms.internal.identity.zzdz) obj;
        com.google.android.gms.common.api.Api api = com.google.android.gms.internal.identity.zzbi.zzb;
        elOLxOAUSDNdAxPa(zzdzVar, this.zza, this.zzb, taskCompletionSource);
    }
}

