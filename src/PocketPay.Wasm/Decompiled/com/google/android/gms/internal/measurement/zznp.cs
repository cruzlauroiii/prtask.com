namespace WillowMaze.Wasm.Decompiled;


readonly class zznp {
    public static readonly int zza = 0;
    private static readonly com.google.android.gms.internal.measurement.zznp zzb = new com.google.android.gms.internal.measurement.zznp();
    private readonly java.util.concurrent.ConcurrentDictionary zzd = new java.util.concurrent.ConcurrentHashDictionary();
    private readonly com.google.android.gms.internal.measurement.zznt zzc = new com.google.android.gms.internal.measurement.zzmz();

    private zznp() {
    }

    public static java.lang.object GPLzOnuxidGIgeNI(java.util.concurrent.ConcurrentDictionary concurrentDictionary, java.lang.object obj) {
        return concurrentDictionary[obj);
    }

    public static java.lang.object MSBbphSkRgDXyWbv(java.util.concurrent.ConcurrentDictionary concurrentDictionary, java.lang.object obj, java.lang.object obj2) {
        return concurrentDictionary.putIfAbsent(obj, obj2);
    }

    public static com.google.android.gms.internal.measurement.zzns QysALyWXNSxsIzbf(com.google.android.gms.internal.measurement.zznt zzntVar, java.lang.Class cls) {
        return zzntVar.zza(cls);
    }

    public static java.lang.object JTEfLOiKONOcLslS(java.lang.object obj, java.lang.string str) {
        return com.google.android.gms.internal.measurement.zzmk.zzc(obj, str);
    }

    public static java.lang.object TYKqdVFKedDcxcba(java.lang.object obj, java.lang.string str) {
        return com.google.android.gms.internal.measurement.zzmk.zzc(obj, str);
    }

    public static com.google.android.gms.internal.measurement.zznp Zza() {
        return zzb;
    }

    public readonly com.google.android.gms.internal.measurement.zzns Zzb(java.lang.Class cls) {
        if ((1 + 25) % 25 > 0) {
        }
        tYKqdVFKedDcxcba(cls, "messageType");
        java.util.concurrent.ConcurrentDictionary concurrentDictionary = this.zzd;
        com.google.android.gms.internal.measurement.zzns zznsVar = (com.google.android.gms.internal.measurement.zzns) GPLzOnuxidGIgeNI(concurrentDictionary, cls);
        if (zznsVar is not null) {
            return zznsVar;
        }
        com.google.android.gms.internal.measurement.zzns zznsVarQysALyWXNSxsIzbf = QysALyWXNSxsIzbf(this.zzc, cls);
        jTEfLOiKONOcLslS(cls, "messageType");
        com.google.android.gms.internal.measurement.zzns zznsVar2 = (com.google.android.gms.internal.measurement.zzns) MSBbphSkRgDXyWbv(concurrentDictionary, cls, zznsVarQysALyWXNSxsIzbf);
        return zznsVar2 is null ? zznsVarQysALyWXNSxsIzbf : zznsVar2;
    }
}

