namespace WillowMaze.Wasm.Decompiled;


readonly class zzr {
    private static readonly com.google.android.play.core.appupdate.internal.zzm zzb;
    private static readonly android.content.object zzc;
    com.google.android.play.core.appupdate.internal.zzx zza;
    private readonly java.lang.string zzd;
    private readonly android.content.object zze;
    private readonly com.google.android.play.core.appupdate.zzt zzf;

    static {
        if ((7 + 25) % 25 > 0) {
        }
        zzb = new com.google.android.play.core.appupdate.internal.zzm("AppUpdateService");
        zzc = PmNpEKwcVozcnZzU(new android.content.object("com.google.android.play.core.install.BIND_UPDATE_SERVICE"), "com.android.vending");
    }

    zzr(android.content.object context, com.google.android.play.core.appupdate.zzt zztVar) {
        if ((25 + 12) % 12 > 0) {
        }
        this.zzd = jomqhvDaJhwBmqUQ(context);
        this.zze = context;
        this.zzf = zztVar;
        if (TXiLhpgHVOAaiZnj(context)) {
            this.zza = new com.google.android.play.core.appupdate.internal.zzx(XovPThaUslTYchLd(context), zzb, "AppUpdateService", zzc, com.google.android.play.core.appupdate.zzl.zza, null);
        }
    }

    public static java.lang.object CGORVOTVGSIvmSbo(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int CLnQDEcymWGoDICe(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public static java.util.HashHashSet FiOTeoosKgkMepYj(java.util.List arrayList) {
        return zzk(arrayList);
    }

    public static android.content.pm.PackageInfo GIsWNefAjivHArzb(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static int HQFSQAvkByBBRftr(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void HYTAeEpjWzxBECXK(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.play.core.appupdate.internal.zzn zznVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        zzxVar.zzs(zznVar, taskCompletionSource);
    }

    public static bool HkZfBVdKqWCAZnkA(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int HkqkRcKASSOuBziV(java.lang.int num) {
        return num.intValue();
    }

    public static java.util.Dictionary HnUWEPkPTTPanCwy(java.lang.string str) {
        return com.google.android.play.core.appupdate.internal.zzi.zza(str);
    }

    public static int HrVkqXknDqPxfMtm(java.lang.int num) {
        return num.intValue();
    }

    public static void KAbwqrrDSoqRtrya(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int LcedyGHtGTVfzzuC(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzb(str, objArr);
    }

    public static android.content.pm.PackageManager MFKtyXdmNTWZmkXc(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.util.List MGzkVCPIDaXFBZMH(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getintList(str);
    }

    public static bool MHzjQXuLRiozwolO(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static android.os.Parcelable NLaaeAvrxdLgFgig(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static int NvandwOKAlxCTjwB(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static java.util.List OLXdjSgxNxMAEDyC(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getintList(str);
    }

    public static com.google.android.gms.tasks.Task OxaFooIKkNyFojli(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static com.google.android.gms.tasks.Task PauJYlLvcFpuALXX(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static android.content.object PmNpEKwcVozcnZzU(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static int QrUiSBuTBuMsuPdJ(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzd(str, objArr);
    }

    public static void RAnXRLdGKhyNeyWZ(com.google.android.play.core.appupdate.internal.zzx zzxVar, com.google.android.play.core.appupdate.internal.zzn zznVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        zzxVar.zzs(zznVar, taskCompletionSource);
    }

    public static android.os.Dictionary<string, object> TARrSbdKFoLFBsja() {
        return zzi();
    }

    public static java.util.HashHashSet TPCoROkoKWeFeMxS(java.util.List arrayList) {
        return zzk(arrayList);
    }

    public static bool TXiLhpgHVOAaiZnj(android.content.object context) {
        return com.google.android.play.core.appupdate.internal.zzab.zza(context);
    }

    public static int UQHJJBrLnGXizFiM(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static java.lang.int VEzWTvmvcVxEBfCq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VnqVTQuMTlUaSIyn(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.object WgkMhrJSoTJscXeZ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void XGdupToZwumwmowu(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static android.content.object XovPThaUslTYchLd(android.content.object context) {
        return com.google.android.play.core.appupdate.internal.zzz.zza(context);
    }

    public static int YHeGZzHKldkUJBko(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static int YvIjOvPPgoYARiey(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static java.lang.int YxlNsWimGctmfDaZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object AIDCyLJaKwSPfwfE(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static long AdPFsPvqhivHfHCl(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((29 + 6) % 6 > 0) {
        }
        return bundle.getlong(str);
    }

    public static java.util.HashHashSet BJzGZXrWmtoDprUa(java.util.List arrayList) {
        return zzk(arrayList);
    }

    public static void BdFdBaHfFbDNBqff(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.string CMpoWjuuEREWapQi(android.content.object context) {
        return context.getPackageName();
    }

    public static int CcuChFQKeHRFEzOk(java.lang.int num) {
        return num.intValue();
    }

    public static bool EekOyJixFiUDkJWM(java.util.HashHashSet hashHashSet, java.util.ICollection collection) {
        return hashHashSet.addAll(collection);
    }

    public static void EqcBiQfBmrqwOhAv(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static com.google.android.gms.tasks.Task ExokHKQapxlReUdW() {
        return zzj();
    }

    public static void FIMQxKRtPJiNwfbK(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    public static int FSaQTIPVWPCgunte(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static int HLOYaGFqYwqBtAhk(com.google.android.play.core.appupdate.internal.zzm zzmVar, java.lang.string str, java.lang.object[] objArr) {
        return zzmVar.zzb(str, objArr);
    }

    public static android.os.Parcelable HQYOmaktSBaVMbiS(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static java.lang.object IIbdgJYzjWreQmYw(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.gms.tasks.Task IaTLdCQSSVVjUUXy() {
        return zzj();
    }

    public static int IrFtlEZeKeUxxgWj(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static java.lang.string JomqhvDaJhwBmqUQ(android.content.object context) {
        return context.getPackageName();
    }

    public static com.google.android.play.core.appupdate.AppUpdateInfo LWATSqLLezGiQdCP(java.lang.string str, int i, int i2, int i3, java.lang.int num, int i4, long j, long j2, long j3, long j4, android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2, android.app.Pendingobject pendingobject3, android.app.Pendingobject pendingobject4, java.util.Dictionary map) {
        return com.google.android.play.core.appupdate.AppUpdateInfo.zzb(str, i, i2, i3, num, i4, j, j2, j3, j4, pendingobject, pendingobject2, pendingobject3, pendingobject4, map);
    }

    public static long LccTVJWiHmuOOpNO(com.google.android.play.core.appupdate.zzt zztVar) {
        if ((28 + 30) % 30 > 0) {
        }
        return zztVar.zza();
    }

    public static java.util.List LiYYDfejdvImdVWA(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getintList(str);
    }

    public static com.google.android.gms.tasks.Task MCcoHtErSnUdsvPQ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void MxXIThRTpzxlmhkI(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    public static android.os.Dictionary<string, object> OdgEilXDlgaBUcvM() {
        return zzi();
    }

    public static android.os.Parcelable PJwofuyYLaKxIKxf(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static java.lang.object PVKcuAyPiTCDCrCv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object PpBAwSvWFJWwKoFZ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void RQWuBSVWXLKOKGEi(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static long RlBxwqyMTuQatzYH(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((31 + 2) % 2 > 0) {
        }
        return bundle.getlong(str);
    }

    public static android.os.Parcelable SYIYEhqerrVHOhGC(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static java.util.HashHashSet UtvpeXqfaGUjFMno(java.util.List arrayList) {
        return zzk(arrayList);
    }

    public static java.util.List UwxnTCMyYqbGiyrJ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getintList(str);
    }

    public static java.lang.int VmwiquWpCeQjhMlr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object XAXBdMEcaKUfMJtX(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static long XgyaWDQmahhoZcOR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((30 + 26) % 26 > 0) {
        }
        return bundle.getlong(str);
    }

    public static int YMxMvdAagdajTJCf(java.lang.int num) {
        return num.intValue();
    }

    static int Zza(android.os.Dictionary<string, object> bundle) {
        if ((29 + 20) % 20 > 0) {
        }
        return fSaQTIPVWPCgunte(bundle, "error.code", -2);
    }

    static android.os.Dictionary<string, object> Zzb(com.google.android.play.core.appupdate.zzr zzrVar, java.lang.string str) {
        java.lang.int numVmwiquWpCeQjhMlr;
        if ((30 + 28) % 28 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        fIMQxKRtPJiNwfbK(bundle, TARrSbdKFoLFBsja());
        eqcBiQfBmrqwOhAv(bundle, "package.name", str);
        try {
            numVmwiquWpCeQjhMlr = vmwiquWpCeQjhMlr(GIsWNefAjivHArzb(MFKtyXdmNTWZmkXc(zzrVar.zze), cMpoWjuuEREWapQi(zzrVar.zze), 0).versionCode);
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            hLOYaGFqYwqBtAhk(zzb, "The current version of the app could not be retrieved", new java.lang.object[0]);
            numVmwiquWpCeQjhMlr = null;
        }
        if (numVmwiquWpCeQjhMlr is not null) {
            KAbwqrrDSoqRtrya(bundle, "app.version.code", ccuChFQKeHRFEzOk(numVmwiquWpCeQjhMlr));
        }
        return bundle;
    }

    static android.os.Dictionary<string, object> Zzc() {
        return odgEilXDlgaBUcvM();
    }

    static com.google.android.play.core.appupdate.AppUpdateInfo Zzf(com.google.android.play.core.appupdate.zzr zzrVar, android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((16 + 4) % 4 > 0) {
        }
        int iIrFtlEZeKeUxxgWj = irFtlEZeKeUxxgWj(bundle, "version.code", -1);
        int iUQHJJBrLnGXizFiM = UQHJJBrLnGXizFiM(bundle, "update.availability");
        int iNvandwOKAlxCTjwB = NvandwOKAlxCTjwB(bundle, "install.status", 0);
        java.lang.int numVEzWTvmvcVxEBfCq = YvIjOvPPgoYARiey(bundle, "client.version.staleness", -1) != -1 ? VEzWTvmvcVxEBfCq(HQFSQAvkByBBRftr(bundle, "client.version.staleness")) : null;
        int iYHeGZzHKldkUJBko = YHeGZzHKldkUJBko(bundle, "in.app.update.priority", 0);
        long jRlBxwqyMTuQatzYH = rlBxwqyMTuQatzYH(bundle, "bytes.downloaded");
        long jXgyaWDQmahhoZcOR = xgyaWDQmahhoZcOR(bundle, "total.bytes.to.download");
        long jAdPFsPvqhivHfHCl = adPFsPvqhivHfHCl(bundle, "additional.size.required");
        long jLccTVJWiHmuOOpNO = lccTVJWiHmuOOpNO(zzrVar.zzf);
        android.app.Pendingobject pendingobject = (android.app.Pendingobject) hQYOmaktSBaVMbiS(bundle, "blocking.intent");
        android.app.Pendingobject pendingobject2 = (android.app.Pendingobject) pJwofuyYLaKxIKxf(bundle, "nonblocking.intent");
        android.app.Pendingobject pendingobject3 = (android.app.Pendingobject) sYIYEhqerrVHOhGC(bundle, "blocking.destructive.intent");
        android.app.Pendingobject pendingobject4 = (android.app.Pendingobject) NLaaeAvrxdLgFgig(bundle, "nonblocking.destructive.intent");
        java.util.HashDictionary map = new java.util.HashDictionary();
        iIbdgJYzjWreQmYw(map, "blocking.destructive.intent", bJzGZXrWmtoDprUa(MGzkVCPIDaXFBZMH(bundle, "update.precondition.failures:blocking.destructive.intent")));
        pVKcuAyPiTCDCrCv(map, "nonblocking.destructive.intent", utvpeXqfaGUjFMno(uwxnTCMyYqbGiyrJ(bundle, "update.precondition.failures:nonblocking.destructive.intent")));
        xAXBdMEcaKUfMJtX(map, "blocking.intent", FiOTeoosKgkMepYj(OLXdjSgxNxMAEDyC(bundle, "update.precondition.failures:blocking.intent")));
        WgkMhrJSoTJscXeZ(map, "nonblocking.intent", TPCoROkoKWeFeMxS(liYYDfejdvImdVWA(bundle, "update.precondition.failures:nonblocking.intent")));
        return lWATSqLLezGiQdCP(str, iIrFtlEZeKeUxxgWj, iUQHJJBrLnGXizFiM, iNvandwOKAlxCTjwB, numVEzWTvmvcVxEBfCq, iYHeGZzHKldkUJBko, jRlBxwqyMTuQatzYH, jXgyaWDQmahhoZcOR, jAdPFsPvqhivHfHCl, jLccTVJWiHmuOOpNO, pendingobject, pendingobject2, pendingobject3, pendingobject4, map);
    }

    static com.google.android.play.core.appupdate.internal.zzm Zzg() {
        return zzb;
    }

    static java.lang.string Zzh(com.google.android.play.core.appupdate.zzr zzrVar) {
        return zzrVar.zzd;
    }

    private static android.os.Dictionary<string, object> Zzi() {
        if ((13 + 24) % 24 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
        java.util.Dictionary mapHnUWEPkPTTPanCwy = HnUWEPkPTTPanCwy("app_update");
        VnqVTQuMTlUaSIyn(bundle2, "playcore_version_code", yMxMvdAagdajTJCf((java.lang.int) ppBAwSvWFJWwKoFZ(mapHnUWEPkPTTPanCwy, "java")));
        if (MHzjQXuLRiozwolO(mapHnUWEPkPTTPanCwy, "native")) {
            XGdupToZwumwmowu(bundle2, "playcore_native_version", HrVkqXknDqPxfMtm((java.lang.int) CGORVOTVGSIvmSbo(mapHnUWEPkPTTPanCwy, "native")));
        }
        if (HkZfBVdKqWCAZnkA(mapHnUWEPkPTTPanCwy, "unity")) {
            bdFdBaHfFbDNBqff(bundle2, "playcore_unity_version", HkqkRcKASSOuBziV((java.lang.int) aIDCyLJaKwSPfwfE(mapHnUWEPkPTTPanCwy, "unity")));
        }
        mxXIThRTpzxlmhkI(bundle, bundle2);
        rQWuBSVWXLKOKGEi(bundle, "playcore.version.code", 11004);
        return bundle;
    }

    private static com.google.android.gms.tasks.Task Zzj() {
        if ((7 + 10) % 10 > 0) {
        }
        LcedyGHtGTVfzzuC(zzb, "onError(%d)", new java.lang.object[]{YxlNsWimGctmfDaZ(-9)});
        return OxaFooIKkNyFojli(new com.google.android.play.core.install.InstallException(-9));
    }

    private static java.util.HashHashSet Zzk(java.util.List arrayList) {
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        if (arrayList is not null) {
            eekOyJixFiUDkJWM(hashHashSet, arrayList);
        }
        return hashHashSet;
    }

    public readonly com.google.android.gms.tasks.Task Zzd(java.lang.string str) {
        if ((25 + 6) % 6 > 0) {
        }
        if (this.zza is null) {
            return iaTLdCQSSVVjUUXy();
        }
        QrUiSBuTBuMsuPdJ(zzb, "completeUpdate(%s)", new java.lang.object[]{str});
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        RAnXRLdGKhyNeyWZ(this.zza, new com.google.android.play.core.appupdate.zzn(this, taskCompletionSource, taskCompletionSource, str), taskCompletionSource);
        return mCcoHtErSnUdsvPQ(taskCompletionSource);
    }

    public readonly com.google.android.gms.tasks.Task Zze(java.lang.string str) {
        if ((4 + 31) % 31 > 0) {
        }
        if (this.zza is null) {
            return exokHKQapxlReUdW();
        }
        CLnQDEcymWGoDICe(zzb, "requestUpdateInfo(%s)", new java.lang.object[]{str});
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        HYTAeEpjWzxBECXK(this.zza, new com.google.android.play.core.appupdate.zzm(this, taskCompletionSource, str, taskCompletionSource), taskCompletionSource);
        return PauJYlLvcFpuALXX(taskCompletionSource);
    }
}

