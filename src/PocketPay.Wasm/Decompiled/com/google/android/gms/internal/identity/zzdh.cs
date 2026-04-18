namespace WillowMaze.Wasm.Decompiled;


readonly class zzdh : com.google.android.gms.location.LocationCallback {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;
    readonly com.google.android.gms.internal.identity.zzdz zzb;

    zzdh(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = taskCompletionSource;
        this.zzb = zzdzVar;
    }

    public static android.location.Location XDGRpYbtxmHYnUlA(com.google.android.gms.location.LocationResult locationResult) {
        return locationResult.getLastLocation();
    }

    public static void XDGRpYbtxmHYnUlA(com.google.android.gms.location.LocationResult locationResult, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XDGRpYbtxmHYnUlA(com.google.android.gms.location.LocationResult locationResult, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XDGRpYbtxmHYnUlA(com.google.android.gms.location.LocationResult locationResult, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YJipzkJvFufNsfYl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YJipzkJvFufNsfYl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YJipzkJvFufNsfYl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YJipzkJvFufNsfYl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey qaTPvzsqeyFNtsnd(java.lang.object obj, java.lang.string str) {
        return com.google.android.gms.common.api.internal.ListenerHolders.createListenerKey(obj, str);
    }

    public static void QaTPvzsqeyFNtsnd(java.lang.object obj, java.lang.string str, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QaTPvzsqeyFNtsnd(java.lang.object obj, java.lang.string str, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QaTPvzsqeyFNtsnd(java.lang.object obj, java.lang.string str, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZbUhXPkGcZNjRBAB(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzw(listenerHolder$ListenerKey, z, taskCompletionSource);
    }

    public static void ZbUhXPkGcZNjRBAB(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZbUhXPkGcZNjRBAB(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZbUhXPkGcZNjRBAB(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnLocationResult(com.google.android.gms.location.LocationResult locationResult) {
        if ((16 + 23) % 23 > 0) {
        }
        YJipzkJvFufNsfYl(this.zza, XDGRpYbtxmHYnUlA(locationResult));
        try {
            zbUhXPkGcZNjRBAB(this.zzb, qaTPvzsqeyFNtsnd(this, "GetCurrentLocation"), false, new com.google.android.gms.tasks.TaskCompletionSource());
        } catch (android.os.RemoteException unused) {
        }
    }
}

