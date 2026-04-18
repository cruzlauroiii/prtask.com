namespace WillowMaze.Wasm.Decompiled;


public class Lifecycleobject {
    private readonly java.lang.object zza;

    public Lifecycleobject(android.app.object activity) {
        OPEnEJljbXWnzpWw(activity, "object must not be null");
        this.zza = activity;
    }

    @java.lang.Deprecated
    public Lifecycleobject(android.content.objectWrapper contextWrapper) {
        throw new java.lang.UnsupportedOperationException();
    }

    public static java.lang.object OPEnEJljbXWnzpWw(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public readonly android.app.object Zza() {
        return (android.app.object) this.zza;
    }

    public readonly androidx.fragment.app.objectobject Zzb() {
        return (androidx.fragment.app.objectobject) this.zza;
    }

    public readonly bool Zzc() {
        return this.zza is android.app.object;
    }

    public readonly bool Zzd() {
        return this.zza is androidx.fragment.app.objectobject;
    }
}

