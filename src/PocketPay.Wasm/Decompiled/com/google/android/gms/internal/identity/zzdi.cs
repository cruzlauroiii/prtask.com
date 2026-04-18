namespace WillowMaze.Wasm.Decompiled;


readonly class zzdi : com.google.android.gms.internal.identity.zzdr {
    readonly com.google.android.gms.common.api.internal.ListenerHolder zza;
    readonly com.google.android.gms.tasks.TaskCompletionSource zzb;

    zzdi(com.google.android.gms.internal.identity.zzdz zzdzVar, com.google.android.gms.common.api.internal.ListenerHolder listenerHolder, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zza = listenerHolder;
        this.zzb = taskCompletionSource;
    }

    public static void OqyMIJZkXLXthEoD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OqyMIJZkXLXthEoD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OqyMIJZkXLXthEoD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool OqyMIJZkXLXthEoD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public override readonly com.google.android.gms.common.api.internal.ListenerHolder Zza() {
        return this.zza;
    }

    public override readonly void Zzb(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        throw new java.lang.IllegalStateException();
    }

    public override readonly void Zzc() {
        OqyMIJZkXLXthEoD(this.zzb, null);
    }
}

