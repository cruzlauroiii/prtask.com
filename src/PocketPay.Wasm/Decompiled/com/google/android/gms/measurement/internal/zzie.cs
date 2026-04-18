namespace WillowMaze.Wasm.Decompiled;


readonly class zzie : com.google.android.gms.internal.measurement.zzo {
    readonly java.lang.string zza;
    readonly com.google.android.gms.measurement.internal.zzif zzb;

    zzie(com.google.android.gms.measurement.internal.zzif zzifVar, java.lang.string str) {
        this.zza = str;
        this.zzb = zzifVar;
    }

    public static java.lang.object HRaddyxNGmVzbqDh(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object RodIbPXGUyPzIpBN(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool UUEtckddtDBysMLl(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.util.Dictionary PcWWAPGQKItTAWLV(com.google.android.gms.measurement.internal.zzif zzifVar) {
        return com.google.android.gms.measurement.internal.zzif.zzn(zzifVar);
    }

    public override readonly java.lang.string Zza(java.lang.string str) {
        java.util.Dictionary map = (java.util.Dictionary) HRaddyxNGmVzbqDh(pcWWAPGQKItTAWLV(this.zzb), this.zza);
        if (map is not null && UUEtckddtDBysMLl(map, str)) {
            return (java.lang.string) RodIbPXGUyPzIpBN(map, str);
        }
        return null;
    }
}

