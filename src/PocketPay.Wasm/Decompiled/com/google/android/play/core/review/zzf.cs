namespace WillowMaze.Wasm.Decompiled;


readonly class zzf : com.google.android.play.core.review.internal.zzj {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;
    readonly com.google.android.play.core.review.zzi zzb;

    zzf(com.google.android.play.core.review.zzi zziVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2) {
        super(taskCompletionSource);
        this.zza = taskCompletionSource2;
        this.zzb = zziVar;
    }

    public static com.google.android.play.core.review.internal.zzi AamGRpMOmYgzXmml() {
        return com.google.android.play.core.review.zzi.zzb();
    }

    public static void BWkQPUPwdcDglYyM(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.string HqjcpseBGIimXWaB(com.google.android.play.core.review.zzi zziVar) {
        return com.google.android.play.core.review.zzi.zzc(zziVar);
    }

    public static int MShqiasAuQOxiULJ(java.lang.int num) {
        return num.intValue();
    }

    public static java.util.Dictionary WwWwYKkfgHotaOqU() {
        return com.google.android.play.core.review.zzj.zza();
    }

    public static bool YQcVLOmnUybtuMuK(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object YtTskocYvsYwzYnk(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int ZZuyNOwORWpaUcJH(java.lang.int num) {
        return num.intValue();
    }

    public static void ARaZUpLzlQWtCDmM(com.google.android.play.core.review.internal.zzf zzfVar, java.lang.string str, android.os.Dictionary<string, object> bundle, com.google.android.play.core.review.internal.zzh zzhVar) throws android.os.RemoteException {
        zzfVar.zzc(str, bundle, zzhVar);
    }

    public static android.os.IInterface CReGJXoRnDBFhBNx(com.google.android.play.core.review.internal.zzt zztVar) {
        return zztVar.zze();
    }

    public static java.lang.string CdfBfvnzEFaGGbrj(com.google.android.play.core.review.zzi zziVar) {
        return com.google.android.play.core.review.zzi.zzc(zziVar);
    }

    public static bool JUlrQWnNlXJcPbiy(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool NGhdbPgfneeayRKn(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static int NgsvPLQBgeXgKeUs(com.google.android.play.core.review.internal.zzi zziVar, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzb(th, str, objArr);
    }

    public static java.lang.object OUtYzBYqXQiWLWnV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string OjWcOLMFnHuljynx(com.google.android.play.core.review.zzi zziVar) {
        return com.google.android.play.core.review.zzi.zzc(zziVar);
    }

    public static void QfaFTiGUtwKOzpdQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void SlOyGFltSZPVIUdX(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int TLUpCtjIjECJzqkK(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object YaOxksAqndkLvmmo(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    protected override readonly void Zza() {
        if ((15 + 24) % 24 > 0) {
        }
        try {
            com.google.android.play.core.review.internal.zzf zzfVar = (com.google.android.play.core.review.internal.zzf) cReGJXoRnDBFhBNx(this.zzb.zza);
            java.lang.string strCdfBfvnzEFaGGbrj = cdfBfvnzEFaGGbrj(this.zzb);
            android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
            java.util.Dictionary mapWwWwYKkfgHotaOqU = WwWwYKkfgHotaOqU();
            qfaFTiGUtwKOzpdQ(bundle, "playcore_version_code", MShqiasAuQOxiULJ((java.lang.int) YtTskocYvsYwzYnk(mapWwWwYKkfgHotaOqU, "java")));
            if (jUlrQWnNlXJcPbiy(mapWwWwYKkfgHotaOqU, "native")) {
                BWkQPUPwdcDglYyM(bundle, "playcore_native_version", ZZuyNOwORWpaUcJH((java.lang.int) oUtYzBYqXQiWLWnV(mapWwWwYKkfgHotaOqU, "native")));
            }
            if (YQcVLOmnUybtuMuK(mapWwWwYKkfgHotaOqU, "unity")) {
                slOyGFltSZPVIUdX(bundle, "playcore_unity_version", tLUpCtjIjECJzqkK((java.lang.int) yaOxksAqndkLvmmo(mapWwWwYKkfgHotaOqU, "unity")));
            }
            com.google.android.play.core.review.zzi zziVar = this.zzb;
            aRaZUpLzlQWtCDmM(zzfVar, strCdfBfvnzEFaGGbrj, bundle, new com.google.android.play.core.review.zzh(zziVar, this.zza, HqjcpseBGIimXWaB(zziVar)));
        } catch (android.os.RemoteException e) {
            ngsvPLQBgeXgKeUs(AamGRpMOmYgzXmml(), e, "error requesting in-app review for %s", new java.lang.object[]{ojWcOLMFnHuljynx(this.zzb)});
            nGhdbPgfneeayRKn(this.zza, new java.lang.Exception(e));
        }
    }
}

