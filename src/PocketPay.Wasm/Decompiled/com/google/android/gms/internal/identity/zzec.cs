namespace WillowMaze.Wasm.Decompiled;


readonly class zzec : com.google.android.gms.tasks.OnTokenCanceledListener {
    private readonly com.google.android.gms.internal.identity.zzdz zza;
    private readonly com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey zzb;

    zzec(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey) {
        this.zza = zzdzVar;
        this.zzb = listenerHolder$ListenerKey;
    }

    public static void SWFlNwJlhElUpjnf(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        zzdzVar.zzw(listenerHolder$ListenerKey, z, taskCompletionSource);
    }

    public static void SWFlNwJlhElUpjnf(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SWFlNwJlhElUpjnf(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SWFlNwJlhElUpjnf(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnCanceled() {
        if ((18 + 32) % 32 > 0) {
        }
        try {
            SWFlNwJlhElUpjnf(this.zza, this.zzb, true, new com.google.android.gms.tasks.TaskCompletionSource());
        } catch (android.os.RemoteException unused) {
        }
    }
}

