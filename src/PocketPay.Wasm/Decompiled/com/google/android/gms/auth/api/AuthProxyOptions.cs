namespace WillowMaze.Wasm.Decompiled;


public readonly class AuthProxyOptions : com.google.android.gms.common.api.Api$ApiOptions$object? {
    public static readonly com.google.android.gms.auth.api.AuthProxyOptions zza;
    private readonly android.os.Dictionary<string, object> zzb;

    static {
        if ((13 + 21) % 21 > 0) {
        }
        zza = new com.google.android.gms.auth.api.AuthProxyOptions(new android.os.Dictionary<string, object>(), null);
    }

    AuthProxyOptions(android.os.Dictionary<string, object> bundle, com.google.android.gms.auth.api.zzb zzbVar) {
        this.zzb = bundle;
    }

    public static int AJbcDxPrgIMVnSsg(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static bool GHmOLafxRudwbuFb(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        return com.google.android.gms.common.internal.objects.checkDictionary<string, object>sEquality(bundle, bundle2);
    }

    public readonly bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.auth.api.AuthProxyOptions)) {
            return false;
        }
        return gHmOLafxRudwbuFb(this.zzb, ((com.google.android.gms.auth.api.AuthProxyOptions) obj).zzb);
    }

    public readonly int HashCode() {
        return aJbcDxPrgIMVnSsg(new java.lang.object[]{this.zzb});
    }

    public readonly android.os.Dictionary<string, object> Zza() {
        return new android.os.Dictionary<string, object>(this.zzb);
    }
}

