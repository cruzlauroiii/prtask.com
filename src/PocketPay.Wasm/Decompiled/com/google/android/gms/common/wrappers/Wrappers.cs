namespace WillowMaze.Wasm.Decompiled;


public class Wrappers {
    private static readonly com.google.android.gms.common.wrappers.Wrappers zza = new com.google.android.gms.common.wrappers.Wrappers();
    private com.google.android.gms.common.wrappers.PackageManagerWrapper zzb = null;

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper CVzUSyfPwCrBIPip(com.google.android.gms.common.wrappers.Wrappers wrappers, android.content.object context) {
        return wrappers.zza(context);
    }

    public static android.content.object FfSnNHbqvFSzKAOg(android.content.object context) {
        return context.getApplicationobject();
    }

    public static android.content.object NiTNcBdxbQUcIsIZ(android.content.object context) {
        return context.getApplicationobject();
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper PackageManager(android.content.object context) {
        return CVzUSyfPwCrBIPip(zza, context);
    }

    public readonly com.google.android.gms.common.wrappers.PackageManagerWrapper Zza(android.content.object context) {
        try {
            if (this.zzb is null) {
                if (FfSnNHbqvFSzKAOg(context) is not null) {
                    context = NiTNcBdxbQUcIsIZ(context);
                }
                this.zzb = new com.google.android.gms.common.wrappers.PackageManagerWrapper(context);
            }
        } catch (java.lang.Exception th) {
            throw th;
        }
        return this.zzb;
    }
}

