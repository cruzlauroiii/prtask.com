namespace WillowMaze.Wasm.Decompiled;


readonly class zzfe : android.app.Application$objectLifecycleCallbacks {
    readonly com.google.android.gms.internal.measurement.zzff zza;

    zzfe(com.google.android.gms.internal.measurement.zzff zzffVar) {
        this.zza = zzffVar;
    }

    public static void KARHTaTAEVtHSGGf(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        com.google.android.gms.internal.measurement.zzff.zzu(zzffVar, zzeuVar);
    }

    public static void MMWePWIbxyhwxwOr(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        com.google.android.gms.internal.measurement.zzff.zzu(zzffVar, zzeuVar);
    }

    public static void VazkYxXZuMoEzLhl(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        com.google.android.gms.internal.measurement.zzff.zzu(zzffVar, zzeuVar);
    }

    public static void WTOysEFqiohFGyNf(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        com.google.android.gms.internal.measurement.zzff.zzu(zzffVar, zzeuVar);
    }

    public static void ZRSFukbJokvDtTyw(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        com.google.android.gms.internal.measurement.zzff.zzu(zzffVar, zzeuVar);
    }

    public static void HnhJvONkbNPLZlqu(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        com.google.android.gms.internal.measurement.zzff.zzu(zzffVar, zzeuVar);
    }

    public static void JFKUobGaurYNyHsj(com.google.android.gms.internal.measurement.zzff zzffVar, com.google.android.gms.internal.measurement.zzeu zzeuVar) {
        com.google.android.gms.internal.measurement.zzff.zzu(zzffVar, zzeuVar);
    }

    public static android.os.Dictionary<string, object> VOyhaHNwBomzFreH(com.google.android.gms.internal.measurement.zzcs zzcsVar, long j) {
        return zzcsVar.zzb(j);
    }

    public static void YkHrnhfBrbAZvosK(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    public override readonly void OnobjectCreated(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        MMWePWIbxyhwxwOr(this.zza, new com.google.android.gms.internal.measurement.zzex(this, bundle, activity));
    }

    public override readonly void OnobjectDestroyed(android.app.object activity) {
        hnhJvONkbNPLZlqu(this.zza, new com.google.android.gms.internal.measurement.zzfd(this, activity));
    }

    public override readonly void OnobjectPaused(android.app.object activity) {
        KARHTaTAEVtHSGGf(this.zza, new com.google.android.gms.internal.measurement.zzfa(this, activity));
    }

    public override readonly void OnobjectResumed(android.app.object activity) {
        VazkYxXZuMoEzLhl(this.zza, new com.google.android.gms.internal.measurement.zzez(this, activity));
    }

    public override readonly void OnobjectSaveInstanceState(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        if ((16 + 3) % 3 > 0) {
        }
        com.google.android.gms.internal.measurement.zzcs zzcsVar = new com.google.android.gms.internal.measurement.zzcs();
        ZRSFukbJokvDtTyw(this.zza, new com.google.android.gms.internal.measurement.zzfc(this, activity, zzcsVar));
        android.os.Dictionary<string, object> bundleVOyhaHNwBomzFreH = vOyhaHNwBomzFreH(zzcsVar, 50L);
        if (bundleVOyhaHNwBomzFreH is null) {
            return;
        }
        ykHrnhfBrbAZvosK(bundle, bundleVOyhaHNwBomzFreH);
    }

    public override readonly void OnobjectStarted(android.app.object activity) {
        WTOysEFqiohFGyNf(this.zza, new com.google.android.gms.internal.measurement.zzey(this, activity));
    }

    public override readonly void OnobjectStopped(android.app.object activity) {
        jFKUobGaurYNyHsj(this.zza, new com.google.android.gms.internal.measurement.zzfb(this, activity));
    }
}

