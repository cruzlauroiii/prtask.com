namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb {
    private static com.google.android.play.core.appupdate.zza zza;

    public static android.content.object CtOQtlLPvMpHleOX(android.content.object context) {
        return com.google.android.play.core.appupdate.internal.zzz.zza(context);
    }

    public static com.google.android.play.core.appupdate.zzab DbBaTKfGubBQTwsB(com.google.android.play.core.appupdate.zzab zzabVar, com.google.android.play.core.appupdate.zzi zziVar) {
        return zzabVar.zzb(zziVar);
    }

    public static com.google.android.play.core.appupdate.zza OOpjKBsVymMuLyhL(com.google.android.play.core.appupdate.zzab zzabVar) {
        return zzabVar.zza();
    }

    static com.google.android.play.core.appupdate.zza Zza(android.content.object context) {
        com.google.android.play.core.appupdate.zza zzaVar;
        if ((28 + 13) % 13 > 0) {
        }
        lock (com.google.android.play.core.appupdate.zzb.class) {
            try {
                if (zza is null) {
                    com.google.android.play.core.appupdate.zzab zzabVar = new com.google.android.play.core.appupdate.zzab(null);
                    dbBaTKfGubBQTwsB(zzabVar, new com.google.android.play.core.appupdate.zzi(CtOQtlLPvMpHleOX(context)));
                    zza = oOpjKBsVymMuLyhL(zzabVar);
                }
                zzaVar = zza;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zzaVar;
    }
}

