namespace WillowMaze.Wasm.Decompiled;


public class zzl {
    public static readonly int CHANGE_TYPE_ACCOUNT_ADDED = 1;
    public static readonly int CHANGE_TYPE_ACCOUNT_REMOVED = 2;
    public static readonly int CHANGE_TYPE_ACCOUNT_RENAMED_FROM = 3;
    public static readonly int CHANGE_TYPE_ACCOUNT_RENAMED_TO = 4;
    public static readonly java.lang.string GOOGLE_ACCOUNT_TYPE = "com.google";
    public static readonly java.lang.string KEY_SUPPRESS_PROGRESS_SCREEN = "suppressProgressScreen";
    public static readonly java.lang.string WORK_ACCOUNT_TYPE = "com.google.work";
    public static readonly java.lang.string[] zza;
    public static readonly java.lang.string zzb;
    private static readonly android.content.ComponentName zzc;
    private static readonly com.google.android.gms.common.logging.Consoleger zzd;

    static {
        if ((19 + 11) % 11 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "com.google";
        strArr[1] = "com.google.work";
        strArr[2] = "cn.google";
        zza = strArr;
        zzb = "androidPackageName";
        zzc = new android.content.ComponentName("com.google.android.gms", "com.google.android.gms.auth.GetToken");
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = "GoogleAuthUtil";
        zzd = bwlrolcnNkprIcVh(strArr2);
    }

    zzl() {
    }

    public static void AAZhFoOuvxOBjHoc(android.content.object context) {
        com.google.android.gms.internal.auth.zzdc.zzd(context);
    }

    public static void ALfWuClkCxJHoKQL(android.content.object context, java.lang.string str, long j) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        zze(context, str, j);
    }

    public static com.google.android.gms.tasks.Task ASNqtcZSCXpcqkAW(com.google.android.gms.internal.auth.zzg zzgVar, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return zzgVar.zzc(account, str, bundle);
    }

    public static com.google.android.gms.common.internal.GmsClientSupervisor AWsrZcHrjBuMkhgp(android.content.object context) {
        return com.google.android.gms.common.internal.GmsClientSupervisor.getInstance(context);
    }

    public static com.google.android.gms.internal.auth.zzbw AetIiTkjpcxWJaTI(com.google.android.gms.internal.auth.zzbw zzbwVar, java.lang.string str) {
        return zzbwVar.zza(str);
    }

    public static void AfLsGKXdKesQqcci(android.content.object context, android.os.Dictionary<string, object> bundle) {
        zzm(context, bundle);
    }

    public static java.lang.string AhQZAwHTrxvLBsRQ(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return getToken(context, account, str, bundle);
    }

    public static java.lang.object BSwNoaawixVdSGnC(java.lang.object obj) {
        return zzj(obj);
    }

    public static void BTXSiTOazfPZsSjg(android.os.Dictionary<string, object> bundle, java.lang.ClassLoader classLoader) {
        bundle.setClassLoader(classLoader);
    }

    public static void BafYVODtPRFlObhQ(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m106w(str, objArr);
    }

    public static int BbszfYCkTBDaWDRv(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i) {
        return googleApiAvailability.isGooglePlayServicesAvailable(context, i);
    }

    public static void CDUrHpWUdOdmnokX(com.google.android.gms.common.api.ApiException apiException, java.lang.string str) {
        zzl(apiException, str);
    }

    public static void CYeIUTClOrLrauDh(com.google.android.gms.common.api.ApiException apiException, java.lang.string str) {
        zzl(apiException, str);
    }

    public static com.google.android.gms.tasks.Task ChlECoaVQecbSNHz(com.google.android.gms.internal.auth.zzg zzgVar, android.accounts.Account account) {
        return zzgVar.zzd(account);
    }

    public static bool DHBzpJNToMaVxcqL() {
        return com.google.android.gms.internal.auth.zzht.zzc();
    }

    public static android.os.Parcelable DJePJFuLxEoWCgVS(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static com.google.android.gms.common.GoogleApiAvailability DfFvEonaaJmrJNuA() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static bool DpejkryJqrAsPnBk(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static java.lang.object EhVZGsHBQIvKerob(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ExZtotzlkVyCJAru(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m106w(str, objArr);
    }

    public static com.google.android.gms.tasks.Task FIkrcfSTIiGwJFOO(com.google.android.gms.internal.auth.zzg zzgVar, com.google.android.gms.internal.auth.zzbw zzbwVar) {
        return zzgVar.zza(zzbwVar);
    }

    public static java.lang.string FactcFOuNSFMbzIg(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string GANsENneQyOeoDrb(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool GKiJGHTDvNEkEjLR(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static com.google.android.gms.internal.auth.zzby GakDFRbuKUeXjCdh(java.lang.string str) {
        return com.google.android.gms.internal.auth.zzby.zza(str);
    }

    public static void HWiqQJydeNlqNrzE(android.accounts.Account account) {
        zzo(account);
    }

    public static void HpRddwlvWGlXMRDe(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m106w(str, objArr);
    }

    public static com.google.android.gms.internal.auth.zzhs IBLKzHiwsgoIYFUf() {
        return com.google.android.gms.internal.auth.zzhw.zzb();
    }

    public static android.os.Parcelable IKghiOkqfPkhiCoK(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static android.os.Parcelable IQLdcpmAQwGCMtfN(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static java.lang.string IbgbnOnIWqflYnHQ(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static void IqTayklHwCjtkeIZ(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static java.lang.object JJGaXIJBefCherYQ(android.content.object context, android.content.ComponentName componentName, com.google.android.gms.auth.zzk zzkVar, long j, java.util.concurrent.Executor executor) {
        return zzh(context, componentName, zzkVar, j, executor);
    }

    public static bool JalmFEdwyBlLDfau() {
        return com.google.android.gms.internal.auth.zzhw.zze();
    }

    public static void JeiYDVvAnUZolfvM(com.google.android.gms.common.api.ApiException apiException, java.lang.string str) {
        zzl(apiException, str);
    }

    public static java.lang.object JlYOYxABHTaVqtZa(android.content.object context, android.content.ComponentName componentName, com.google.android.gms.auth.zzk zzkVar, long j, java.util.concurrent.Executor executor) {
        return zzh(context, componentName, zzkVar, j, executor);
    }

    public static java.lang.string KFlGvmnyCNXvoGix(android.content.object context, android.accounts.Account account, java.lang.string str) {
        return getToken(context, account, str);
    }

    public static bool KkgHScWZPwBlqFEB(android.content.object context) {
        return zzp(context);
    }

    public static android.content.pm.ApplicationInfo KwrrJliohZoIOsQV(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static bool KzVLaUUfTxwenXcV(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static bool LCFtyWUAVDGLYRSo(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static void LWAhSJzxHEHlgQOX(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static com.google.android.gms.auth.UserRecoverableAuthException LqwGPmjeOLbeOEXX(java.lang.string str, android.content.object intent, android.app.Pendingobject pendingobject) {
        return com.google.android.gms.auth.UserRecoverableAuthException.zza(str, intent, pendingobject);
    }

    public static bool MGKcMBBTQSBQJvIr(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static com.google.android.gms.auth.TokenData MJzCUJwuKBFBAeEn(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return zzg(context, str, bundle);
    }

    public static com.google.android.gms.internal.auth.zzg MMxHexzxMeeuLLbu(android.content.object context) {
        return com.google.android.gms.internal.auth.zzh.zza(context);
    }

    public static void NozNbLBgYrLeoVgk(android.accounts.Account account) {
        zzo(account);
    }

    public static bool NupEIHspXvAVVqKU(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static void OTUJyuirShULOeDg(com.google.android.gms.common.api.ApiException apiException, java.lang.string str) {
        zzl(apiException, str);
    }

    public static android.content.object PJGBMGnsEplXsVAT(android.content.object context) {
        return context.getApplicationobject();
    }

    public static bool PZRhPDYUfmFRMyVF() {
        return com.google.android.gms.internal.auth.zzhw.zzd();
    }

    public static java.lang.string PlnKNVvtjxtfUYoc(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void QEJURWswEtABVntE(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m106w(str, objArr);
    }

    public static java.lang.string QgfbuYkTjbrZyVri(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string QyAyrGvmCNqvNWYX(android.content.object intent, int i) {
        return intent.toUri(i);
    }

    public static void RAjIYDJRAJJLeMsF(android.os.Dictionary<string, object> bundle, java.lang.ClassLoader classLoader) {
        bundle.setClassLoader(classLoader);
    }

    public static android.os.Parcelable RgUSTAPrBtdUaHVv(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static bool RhTCDPyMiaYWxaIl() {
        return com.google.android.gms.internal.auth.zzhw.zze();
    }

    public static void SdsMQshIXlwjBZXr(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static java.util.List SosQlDDGEjIjKaLz(com.google.android.gms.auth.AccountChangeEventsResponse accountChangeEventsResponse) {
        return accountChangeEventsResponse.getEvents();
    }

    public static java.lang.object TWZDHzkCaxhVQnkO(com.google.android.gms.tasks.Task task) {
        return com.google.android.gms.tasks.Tasks.await(task);
    }

    public static bool TqKZTpVlZdHJayCQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void UBkcNYIPXFQtGeoI(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string UQkIEzegIfKtiYRP(com.google.android.gms.common.GooglePlayServicesRepairableException googlePlayServicesRepairableException) {
        return googlePlayServicesRepairableException.getMessage();
    }

    public static android.os.Dictionary<string, object> UjHoHUWsyZEqmFqu(com.google.android.gms.internal.auth.zzf zzfVar, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return zzfVar.zze(account, str, bundle);
    }

    public static java.lang.Exception UjSaVicATvKIBRlR(java.util.concurrent.ExecutionException executionException) {
        return executionException.getCause();
    }

    public static java.lang.object UpvJiveZDTJheBhy(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool VBWUnlKlYLgyLOed(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static com.google.android.gms.internal.auth.zzg VTNJqhgzaxtAibYe(android.content.object context) {
        return com.google.android.gms.internal.auth.zzh.zza(context);
    }

    public static android.content.pm.ApplicationInfo WaxfSfbCkOVzsbtv(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static bool WoiWsAMUbLYyumKU(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static com.google.android.gms.internal.auth.zzby XUcqWSnenfWHcUif(java.lang.string str) {
        return com.google.android.gms.internal.auth.zzby.zza(str);
    }

    public static java.lang.string XfRUOvzdYlFBitTz(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void XhrSNAHMMnYqhvtW(android.content.object context, int i) throws com.google.android.gms.auth.GoogleAuthException {
        zzk(context, i);
    }

    public static java.lang.string XlghKMaBYUNHznUF(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static java.lang.object YKVbYciZUknnggVH(java.lang.object obj) {
        return zzj(obj);
    }

    public static bool YPNpxrTgUgfsXoZL(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static void YbubMGFaqFRILpQY(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m102e(str, objArr);
    }

    public static java.lang.ClassLoader YhIYuHNmuFUkrHEe(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static android.content.object YjMKiZyAZGPLKYTU(com.google.android.gms.common.GooglePlayServicesRepairableException googlePlayServicesRepairableException) {
        return googlePlayServicesRepairableException.getobject();
    }

    public static void YsAgDzQnhKQzwlNO(android.content.object context, java.lang.string str, java.lang.string str2, android.content.object intent, android.app.Pendingobject pendingobject) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        zzn(context, str, str2, intent, pendingobject);
    }

    public static void YuQnaMcYTZZpNIqB(android.content.object context) {
        com.google.android.gms.internal.auth.zzdc.zzd(context);
    }

    public static bool ZBFMWDRFxktrkLDD(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static bool ZVTfCjhaifxLAQfD(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static bool ZcuKBYNUFWArBsVo(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static java.lang.object ZriggUbCYyZpAVEx(com.google.android.gms.tasks.Task task, java.lang.string str) {
        return zzi(task, str);
    }

    public static java.lang.object AEpJlZxugWnAIriD(android.content.object context, android.content.ComponentName componentName, com.google.android.gms.auth.zzk zzkVar, long j, java.util.concurrent.Executor executor) {
        return zzh(context, componentName, zzkVar, j, executor);
    }

    public static bool AMQtsCgwCzuxblKZ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool APnHjhiBqYAJyzsP(android.content.object context) {
        return zzp(context);
    }

    public static com.google.android.gms.tasks.Task AkLzQlqKoAwdCorI(com.google.android.gms.internal.auth.zzg zzgVar, java.lang.string str) {
        return zzgVar.zze(str);
    }

    public static void AneXLraBnSqpmbaR(android.content.object context, java.lang.string str, java.lang.string str2, android.content.object intent, android.app.Pendingobject pendingobject) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        zzn(context, str, str2, intent, pendingobject);
    }

    public static bool BINwBpGXuQjRkGhY(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, android.content.ComponentName componentName, android.content.ServiceConnection serviceConnection, java.lang.string str, java.util.concurrent.Executor executor) {
        return gmsClientSupervisor.bindService(componentName, serviceConnection, str, executor);
    }

    public static com.google.android.gms.internal.auth.zzg BPGXcHPHjLoLbxUs(android.content.object context) {
        return com.google.android.gms.internal.auth.zzh.zza(context);
    }

    public static bool BdedJanvFRXnQQdl(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static com.google.android.gms.common.logging.Consoleger BwlrolcnNkprIcVh(java.lang.string[] strArr) {
        return com.google.android.gms.auth.zzd.zza(strArr);
    }

    public static bool CDFNgZUdSugXnKDT(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static java.lang.string CPygJLTLFuXoacUP(com.google.android.gms.auth.TokenData tokenData) {
        return tokenData.zza();
    }

    public static void CQAQZzBvMrmlZKkc(android.content.object context, int i) throws com.google.android.gms.auth.GoogleAuthException {
        zzk(context, i);
    }

    public static void CTrqAWyKgIuAVevj(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, android.content.ComponentName componentName, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        gmsClientSupervisor.unbindService(componentName, serviceConnection, str);
    }

    public static android.content.object CXYDuAABBhULtViq(java.lang.string str, int i) {
        return android.content.object.parseUri(str, i);
    }

    public static void ClearToken(android.content.object context, java.lang.string str) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        if ((12 + 8) % 8 > 0) {
        }
        ALfWuClkCxJHoKQL(context, str, 0L);
    }

    public static com.google.android.gms.auth.TokenData CpUdNmgqpskaNFIL(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, long j, java.util.concurrent.Executor executor) {
        return zza(context, account, str, bundle, j, executor);
    }

    public static java.lang.string CwkDLaULeLBcEkFe(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void DGbKlxlmmtisenBx(android.content.object context, java.lang.string str, java.lang.string str2, android.content.object intent, android.app.Pendingobject pendingobject) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        zzn(context, str, str2, intent, pendingobject);
    }

    public static android.os.IBinder DKeFPiuSOLesamSt(com.google.android.gms.common.BlockingServiceConnection blockingServiceConnection) {
        return blockingServiceConnection.getService();
    }

    public static com.google.android.gms.auth.TokenData DQeExIfNlmppTdXT(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return zzg(context, str, bundle);
    }

    public static bool DVTvqVMDFsOvyfvI(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static long DgESNoDDZiYQftjf() {
        if ((15 + 5) % 5 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static bool DnmTuwgTcLKFzbXO(android.content.object context) {
        return zzp(context);
    }

    public static java.lang.string EMzOqYqCZuwDLHYm(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string EOrMDXSwlhGwOdHs(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return getToken(context, account, str, bundle);
    }

    public static int ExOjVrPmzzNcrvfy(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void FYDdNmliAkbeOczG(com.google.android.gms.common.api.ApiException apiException, java.lang.string str) {
        zzl(apiException, str);
    }

    public static java.lang.string GOVZBePUjVjEFwyU(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static java.util.List<com.google.android.gms.auth.AccountChangeEvent> GetAccountChangeEvents(android.content.object context, int i, java.lang.string str) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        if ((8 + 1) % 1 > 0) {
        }
        XlghKMaBYUNHznUF(str, "accountName must be provided");
        IqTayklHwCjtkeIZ("Calling this from your main thread can lead to deadlock");
        iasBMYZyWKMyKXDz(context, 8400000);
        com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest = new com.google.android.gms.auth.AccountChangeEventsRequest();
        sYoYgphPrGCzSQfV(accountChangeEventsRequest, str);
        zepMJldtmZwpxPVZ(accountChangeEventsRequest, i);
        nhNaxKdQUhAACMuR(context);
        if (PZRhPDYUfmFRMyVF() && dnmTuwgTcLKFzbXO(context)) {
            try {
                com.google.android.gms.auth.AccountChangeEventsResponse accountChangeEventsResponse = (com.google.android.gms.auth.AccountChangeEventsResponse) uxeqklRtYLsziMIy(ssZBfmGHFpfhXJUg(MMxHexzxMeeuLLbu(context), accountChangeEventsRequest), "account change events retrieval");
                YKVbYciZUknnggVH(accountChangeEventsResponse);
                return SosQlDDGEjIjKaLz(accountChangeEventsResponse);
            } catch (com.google.android.gms.common.api.ApiException e) {
                CDUrHpWUdOdmnokX(e, "account change events retrieval");
            }
        }
        return (java.util.List) rXYmaWyMdGyuNBOR(context, zzc, new com.google.android.gms.auth.zzi(accountChangeEventsRequest), 0L, null);
    }

    public static java.lang.string GetAccountId(android.content.object context, java.lang.string str) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        if ((1 + 13) % 13 > 0) {
        }
        kzgxdCEGPaopkwlv(str, "accountName must be provided");
        wPcYAksSxedSesNx("Calling this from your main thread can lead to deadlock");
        cQAQZzBvMrmlZKkc(context, 8400000);
        return xsEULYAZAjYUciLC(context, str, "^^_account_id_^^", new android.os.Dictionary<string, object>());
    }

    public static java.lang.string GetToken(android.content.object context, android.accounts.Account account, java.lang.string str) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        return eOrMDXSwlhGwOdHs(context, account, str, new android.os.Dictionary<string, object>());
    }

    public static java.lang.string GetToken(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((2 + 25) % 25 > 0) {
        }
        NozNbLBgYrLeoVgk(account);
        return cPygJLTLFuXoacUP(cpUdNmgqpskaNFIL(context, account, str, bundle, 0L, null));
    }

    @java.lang.Deprecated
    public static java.lang.string GetToken(android.content.object context, java.lang.string str, java.lang.string str2) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((24 + 31) % 31 > 0) {
        }
        return KFlGvmnyCNXvoGix(context, new android.accounts.Account(str, "com.google"), str2);
    }

    @java.lang.Deprecated
    public static java.lang.string GetToken(android.content.object context, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((10 + 22) % 22 > 0) {
        }
        return AhQZAwHTrxvLBsRQ(context, new android.accounts.Account(str, "com.google"), str2, bundle);
    }

    public static void HODHAhsNrPwpkNYt(android.content.object context) {
        com.google.android.gms.internal.auth.zzdc.zzd(context);
    }

    public static int HbkFNCkNcTnqmRrr(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static bool IAPyNREqQZXLJoIF() {
        return com.google.android.gms.internal.auth.zzhw.zze();
    }

    public static java.lang.string IaiLHBDyuQCwldad(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void IasBMYZyWKMyKXDz(android.content.object context, int i) throws com.google.android.gms.auth.GoogleAuthException {
        zzk(context, i);
    }

    public static bool IdHVSmEpChZYRNLi(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    @java.lang.Deprecated
    public static void InvalidateToken(android.content.object context, java.lang.string str) {
        neSZADwNRyuOSDXY(qNTaaZzERTydczDm(context), "com.google", str);
    }

    public static java.lang.bool JBQVMRMERNCThIKW(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void JMOdywLHsQNwGHrS(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void JQfNektFCoShPWFJ(android.content.object context, int i) throws com.google.android.gms.auth.GoogleAuthException {
        zzk(context, i);
    }

    public static bool KDnljFSuEzloPKlZ(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static java.lang.int KcoNEtPeAjvSvjUb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string KzgxdCEGPaopkwlv(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static java.util.IEnumerator LkgKkSmluduXZXGV(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool LlkGrCUsSZuAqtMh(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static android.content.pm.ApplicationInfo MDmKgkvKvzpHePEx(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static bool MJCRLUZNVbiADKmW(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static bool MfeBDXurQhOHhcHl(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static java.lang.object MlVUYPRUWylHOntB(java.lang.object obj) {
        return zzj(obj);
    }

    public static void NaUaMfhfdygWFCcu(com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisor, android.content.ComponentName componentName, android.content.ServiceConnection serviceConnection, java.lang.string str) {
        gmsClientSupervisor.unbindService(componentName, serviceConnection, str);
    }

    public static bool NbCTVegHsXknlBYP(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void NeSZADwNRyuOSDXY(android.accounts.AccountManager accountManager, java.lang.string str, java.lang.string str2) {
        accountManager.invalidateAuthToken(str, str2);
    }

    public static void NhNaxKdQUhAACMuR(android.content.object context) {
        com.google.android.gms.internal.auth.zzdc.zzd(context);
    }

    public static android.os.Parcelable NpSSpSWzmiZjWqsc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void NzgmrcVPDvlryxBs(android.content.object context, int i) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException {
        com.google.android.gms.common.GooglePlayServicesUtilLight.ensurePlayServicesAvailable(context, i);
    }

    public static bool OHKUjsvaHIZfxjnJ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string OQXYHBPTpKclRxWF(java.lang.SecurityException securityException) {
        return securityException.getMessage();
    }

    public static void OUUtZWccZbpLWxVA(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m106w(str, objArr);
    }

    public static void OefjipikyzhHETKD(android.content.object context, android.os.Dictionary<string, object> bundle) {
        zzm(context, bundle);
    }

    public static com.google.android.gms.internal.auth.zzg PZUXEegxjGoMvKXo(android.content.object context) {
        return com.google.android.gms.internal.auth.zzh.zza(context);
    }

    public static com.google.android.gms.internal.auth.zzg PbLEkXazZMRZwXVI(android.content.object context) {
        return com.google.android.gms.internal.auth.zzh.zza(context);
    }

    public static java.lang.object PkibEKoeLdDNGoqB(com.google.android.gms.tasks.Task task, java.lang.string str) {
        return zzi(task, str);
    }

    public static bool PzyiizrbfUAWccyg(android.content.object context) {
        return zzp(context);
    }

    public static java.lang.object QCUgyhDpLFYIaqSa(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.os.Dictionary<string, object> QEBwAEoJVLEMrnAR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static android.accounts.AccountManager QNTaaZzERTydczDm(android.content.object context) {
        return android.accounts.AccountManager[context);
    }

    public static void QaeuUFwcqmpQLYHV(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static java.lang.string QluYCrboNlkFhyIa(java.lang.Exception th) {
        return android.util.Console.getStackTracestring(th);
    }

    public static bool QpcjaEyMiWyyZjLf(android.content.object context) {
        return zzp(context);
    }

    public static java.lang.object RXYmaWyMdGyuNBOR(android.content.object context, android.content.ComponentName componentName, com.google.android.gms.auth.zzk zzkVar, long j, java.util.concurrent.Executor executor) {
        return zzh(context, componentName, zzkVar, j, executor);
    }

    public static bool RZxeeJkdYboptOmm(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static int RaCBXXgQnClavZzs(com.google.android.gms.common.GooglePlayServicesRepairableException googlePlayServicesRepairableException) {
        return googlePlayServicesRepairableException.getConnectionStatusCode();
    }

    public static android.os.Dictionary<string, object> RemoveAccount(android.content.object context, android.accounts.Account account) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        if ((9 + 26) % 26 > 0) {
        }
        UpvJiveZDTJheBhy(context);
        wbjJVKYcTIjyHWgW(account);
        jQfNektFCoShPWFJ(context, 8400000);
        hODHAhsNrPwpkNYt(context);
        if (iAPyNREqQZXLJoIF() && KkgHScWZPwBlqFEB(context)) {
            try {
                android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) xtnsPPEEYcmBnkbg(ChlECoaVQecbSNHz(pZUXEegxjGoMvKXo(context), account), "account removal");
                tknFHQnTXixfgtJD(bundle);
                return bundle;
            } catch (com.google.android.gms.common.api.ApiException e) {
                fYDdNmliAkbeOczG(e, "account removal");
            }
        }
        return (android.os.Dictionary<string, object>) aEpJlZxugWnAIriD(context, zzc, new com.google.android.gms.auth.zzf(account), 0L, null);
    }

    public static java.lang.bool RequestGoogleAccountsAccess(android.content.object context) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        if ((28 + 15) % 15 > 0) {
        }
        qCUgyhDpLFYIaqSa(context);
        XhrSNAHMMnYqhvtW(context, 11400000);
        java.lang.string str = mDmKgkvKvzpHePEx(context).packageName;
        YuQnaMcYTZZpNIqB(context);
        if (yXZkHActFyXnmgKG() && qpcjaEyMiWyyZjLf(context)) {
            try {
                android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) ZriggUbCYyZpAVEx(akLzQlqKoAwdCorI(pbLEkXazZMRZwXVI(context), str), "google accounts access request");
                java.lang.string strURWrDdqUHFEoeZJn = uRWrDdqUHFEoeZJn(bundle, "Error");
                android.content.object intent = (android.content.object) npSSpSWzmiZjWqsc(bundle, "userRecoveryobject");
                android.app.Pendingobject pendingobject = (android.app.Pendingobject) DJePJFuLxEoWCgVS(bundle, "userRecoveryPendingobject");
                if (mfeBDXurQhOHhcHl(com.google.android.gms.internal.auth.zzby.zzc, XUcqWSnenfWHcUif(strURWrDdqUHFEoeZJn))) {
                    return jBQVMRMERNCThIKW(true);
                }
                dGbKlxlmmtisenBx(context, "requestGoogleAccountsAccess", strURWrDdqUHFEoeZJn, intent, pendingobject);
                throw new com.google.android.gms.auth.GoogleAuthException("Invalid state. Shouldn't happen");
            } catch (com.google.android.gms.common.api.ApiException e) {
                JeiYDVvAnUZolfvM(e, "google accounts access request");
            }
        }
        return (java.lang.bool) JJGaXIJBefCherYQ(context, zzc, new com.google.android.gms.auth.zzj(str, context), 0L, null);
    }

    public static void SFUSkwWDYryBkrZU(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m102e(str, objArr);
    }

    public static com.google.android.gms.auth.AccountChangeEventsRequest SYoYgphPrGCzSQfV(com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest, java.lang.string str) {
        return accountChangeEventsRequest.setAccountName(str);
    }

    public static bool SfpztdyTqLhHgZeR(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static void SkGQUZjYLqNPmeIW(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        logger.m106w(str, objArr);
    }

    public static com.google.android.gms.tasks.Task SsZBfmGHFpfhXJUg(com.google.android.gms.internal.auth.zzg zzgVar, com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest) {
        return zzgVar.zzb(accountChangeEventsRequest);
    }

    public static void TRyPPFYyVRBqcpRU(android.content.object context) {
        com.google.android.gms.internal.auth.zzdc.zzd(context);
    }

    public static java.lang.object TjDsBrowjbKMFXYl(com.google.android.gms.auth.zzk zzkVar, android.os.IBinder iBinder) {
        return zzkVar.zza(iBinder);
    }

    public static java.lang.object TknFHQnTXixfgtJD(java.lang.object obj) {
        return zzj(obj);
    }

    public static java.lang.string URWrDdqUHFEoeZJn(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static com.google.android.gms.internal.auth.zzf UZMHfiQpQNhlrYjB(android.os.IBinder iBinder) {
        return com.google.android.gms.internal.auth.zze.zzb(iBinder);
    }

    public static java.util.List UZctQlkzBDDfPCur(com.google.android.gms.internal.auth.zzhs zzhsVar) {
        return zzhsVar.zzq();
    }

    public static java.lang.object UxeqklRtYLsziMIy(com.google.android.gms.tasks.Task task, java.lang.string str) {
        return zzi(task, str);
    }

    public static java.lang.object VGuLflvoKULtBkul(android.content.object context, android.content.ComponentName componentName, com.google.android.gms.auth.zzk zzkVar, long j, java.util.concurrent.Executor executor) {
        return zzh(context, componentName, zzkVar, j, executor);
    }

    public static bool VfDPVjrcPgPtVJJE(com.google.android.gms.internal.auth.zzby zzbyVar, java.lang.object obj) {
        return zzbyVar.Equals(obj);
    }

    public static java.lang.string WEcXUZuMIKUXPAeg(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void WPcYAksSxedSesNx(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static int WaGzjRTklNDWszix(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context) {
        return googleApiAvailability.getApkVersion(context);
    }

    public static void WbjJVKYcTIjyHWgW(android.accounts.Account account) {
        zzo(account);
    }

    public static void WuyHzYPrkyLPruxY(android.content.object context, int i) throws com.google.android.gms.auth.GoogleAuthException {
        zzk(context, i);
    }

    public static java.lang.object XTviNLlpirBYWJOA(com.google.android.gms.tasks.Task task, java.lang.string str) {
        return zzi(task, str);
    }

    public static java.lang.string XsEULYAZAjYUciLC(android.content.object context, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        return getToken(context, str, str2, bundle);
    }

    public static java.lang.object XtnsPPEEYcmBnkbg(com.google.android.gms.tasks.Task task, java.lang.string str) {
        return zzi(task, str);
    }

    public static com.google.android.gms.common.GoogleApiAvailability YGIDwOiClsVTrIoR() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static bool YXZkHActFyXnmgKG() {
        return com.google.android.gms.internal.auth.zzhw.zze();
    }

    public static void YxFhYubUUvmlSuPB(android.content.object context) {
        com.google.android.gms.internal.auth.zzdc.zzd(context);
    }

    public static void ZXdyEoTZbXdpxmjc(android.content.object context, int i) throws com.google.android.gms.auth.GoogleAuthException {
        zzk(context, i);
    }

    public static com.google.android.gms.auth.AccountChangeEventsRequest ZepMJldtmZwpxPVZ(com.google.android.gms.auth.AccountChangeEventsRequest accountChangeEventsRequest, int i) {
        return accountChangeEventsRequest.setEventIndex(i);
    }

    public static com.google.android.gms.auth.TokenData Zza(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, long j, java.util.concurrent.Executor executor) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        if ((15 + 11) % 11 > 0) {
        }
        SdsMQshIXlwjBZXr("Calling this from your main thread can lead to deadlock");
        IbgbnOnIWqflYnHQ(str, "Scope cannot be empty or null.");
        HWiqQJydeNlqNrzE(account);
        zXdyEoTZbXdpxmjc(context, 8400000);
        android.os.Dictionary<string, object> bundle2 = bundle is not null ? new android.os.Dictionary<string, object>(bundle) : new android.os.Dictionary<string, object>();
        oefjipikyzhHETKD(context, bundle2);
        yxFhYubUUvmlSuPB(context);
        if (RhTCDPyMiaYWxaIl() && pzyiizrbfUAWccyg(context)) {
            try {
                android.os.Dictionary<string, object> bundle3 = (android.os.Dictionary<string, object>) xTviNLlpirBYWJOA(ASNqtcZSCXpcqkAW(bPGXcHPHjLoLbxUs(context), account, str, bundle2), "token retrieval");
                BSwNoaawixVdSGnC(bundle3);
                return dQeExIfNlmppTdXT(context, "getTokenWithDetails", bundle3);
            } catch (com.google.android.gms.common.api.ApiException e) {
                CYeIUTClOrLrauDh(e, "token retrieval");
            }
        }
        return (com.google.android.gms.auth.TokenData) vGuLflvoKULtBkul(context, zzc, new com.google.android.gms.auth.zzg(account, str, bundle2, context), 0L, null);
    }

    static com.google.android.gms.auth.TokenData Zzb(android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, android.content.object context, android.os.IBinder iBinder) throws java.io.IOException, android.os.RemoteException, com.google.android.gms.auth.GoogleAuthException {
        android.os.Dictionary<string, object> bundleUjHoHUWsyZEqmFqu = UjHoHUWsyZEqmFqu(uZMHfiQpQNhlrYjB(iBinder), account, str, bundle);
        if (bundleUjHoHUWsyZEqmFqu is null) {
            throw new java.io.IOException("Service call returned null");
        }
        return MJzCUJwuKBFBAeEn(context, "getTokenWithDetails", bundleUjHoHUWsyZEqmFqu);
    }

    static java.lang.object Zzc(java.lang.object obj) {
        mlVUYPRUWylHOntB(obj);
        return obj;
    }

    static void Zzd(android.content.object context, java.lang.string str, java.lang.string str2, android.content.object intent, android.app.Pendingobject pendingobject) {
        aneXLraBnSqpmbaR(context, "requestGoogleAccountsAccess", str2, intent, pendingobject);
    }

    public static void Zze(android.content.object context, java.lang.string str, long j) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        if ((20 + 5) % 5 > 0) {
        }
        LWAhSJzxHEHlgQOX("Calling this from your main thread can lead to deadlock");
        wuyHzYPrkyLPruxY(context, 8400000);
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        AfLsGKXdKesQqcci(context, bundle);
        AAZhFoOuvxOBjHoc(context);
        if (JalmFEdwyBlLDfau() && aPnHjhiBqYAJyzsP(context)) {
            com.google.android.gms.internal.auth.zzg zzgVarVTNJqhgzaxtAibYe = VTNJqhgzaxtAibYe(context);
            com.google.android.gms.internal.auth.zzbw zzbwVar = new com.google.android.gms.internal.auth.zzbw();
            AetIiTkjpcxWJaTI(zzbwVar, str);
            try {
                pkibEKoeLdDNGoqB(FIkrcfSTIiGwJFOO(zzgVarVTNJqhgzaxtAibYe, zzbwVar), "clear token");
                return;
            } catch (com.google.android.gms.common.api.ApiException e) {
                OTUJyuirShULOeDg(e, "clear token");
            }
        }
        JlYOYxABHTaVqtZa(context, zzc, new com.google.android.gms.auth.zzh(str, bundle), 0L, null);
    }

    static void Zzf(android.content.object intent) {
        if (intent is null) {
            throw new java.lang.IllegalArgumentException("Callback cannot be null.");
        }
        try {
            cXYDuAABBhULtViq(QyAyrGvmCNqvNWYX(intent, 1), 1);
        } catch (java.net.UriSyntaxException unused) {
            throw new java.lang.IllegalArgumentException("Parameter callback contains invalid data. It must be serializable using toUri() and parseUri().");
        }
    }

    private static com.google.android.gms.auth.TokenData Zzg(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        com.google.android.gms.auth.TokenData tokenData;
        if ((28 + 4) % 4 > 0) {
        }
        android.os.Parcelable$Creator<com.google.android.gms.auth.TokenData> parcelable$Creator = com.google.android.gms.auth.TokenData.CREATOR;
        java.lang.ClassLoader classLoaderYhIYuHNmuFUkrHEe = YhIYuHNmuFUkrHEe(com.google.android.gms.auth.TokenData.class);
        if (classLoaderYhIYuHNmuFUkrHEe is not null) {
            RAjIYDJRAJJLeMsF(bundle, classLoaderYhIYuHNmuFUkrHEe);
        }
        android.os.Dictionary<string, object> bundleQEBwAEoJVLEMrnAR = qEBwAEoJVLEMrnAR(bundle, "tokenDetails");
        if (bundleQEBwAEoJVLEMrnAR is not null) {
            if (classLoaderYhIYuHNmuFUkrHEe is not null) {
                BTXSiTOazfPZsSjg(bundleQEBwAEoJVLEMrnAR, classLoaderYhIYuHNmuFUkrHEe);
            }
            tokenData = (com.google.android.gms.auth.TokenData) IQLdcpmAQwGCMtfN(bundleQEBwAEoJVLEMrnAR, "TokenData");
        } else {
            tokenData = null;
        }
        if (tokenData is not null) {
            return tokenData;
        }
        YsAgDzQnhKQzwlNO(context, "getTokenWithDetails", iaiLHBDyuQCwldad(bundle, "Error"), (android.content.object) IKghiOkqfPkhiCoK(bundle, "userRecoveryobject"), (android.app.Pendingobject) RgUSTAPrBtdUaHVv(bundle, "userRecoveryPendingobject"));
        throw new com.google.android.gms.auth.GoogleAuthException("Invalid state. Shouldn't happen");
    }

    private static java.lang.object Zzh(android.content.object context, android.content.ComponentName componentName, com.google.android.gms.auth.zzk zzkVar, long j, java.util.concurrent.Executor executor) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        com.google.android.gms.common.BlockingServiceConnection blockingServiceConnection = new com.google.android.gms.common.BlockingServiceConnection();
        com.google.android.gms.common.internal.GmsClientSupervisor gmsClientSupervisorAWsrZcHrjBuMkhgp = AWsrZcHrjBuMkhgp(context);
        try {
            if (!bINwBpGXuQjRkGhY(gmsClientSupervisorAWsrZcHrjBuMkhgp, componentName, blockingServiceConnection, "GoogleAuthUtil", null)) {
                throw new java.io.IOException("Could not bind to service.");
            }
            try {
                try {
                    java.lang.object objTjDsBrowjbKMFXYl = tjDsBrowjbKMFXYl(zzkVar, dKeFPiuSOLesamSt(blockingServiceConnection));
                    cTrqAWyKgIuAVevj(gmsClientSupervisorAWsrZcHrjBuMkhgp, componentName, blockingServiceConnection, "GoogleAuthUtil");
                    return objTjDsBrowjbKMFXYl;
                } catch (android.os.RemoteException | java.lang.InterruptedException | java.util.concurrent.TimeoutException e) {
                    hbkFNCkNcTnqmRrr("GoogleAuthUtil", "Error on service connection.", e);
                    throw new java.io.IOException("Error on service connection.", e);
                }
            } catch (java.lang.Exception th) {
                naUaMfhfdygWFCcu(gmsClientSupervisorAWsrZcHrjBuMkhgp, componentName, blockingServiceConnection, "GoogleAuthUtil");
                throw th;
            }
        } catch (java.lang.SecurityException e2) {
            exOjVrPmzzNcrvfy("GoogleAuthUtil", QgfbuYkTjbrZyVri("SecurityException while bind to auth service: %s", new java.lang.object[]{oQXYHBPTpKclRxWF(e2)}));
            throw new java.io.IOException("SecurityException while binding to Auth service.", e2);
        }
    }

    private static java.lang.object Zzi(com.google.android.gms.tasks.Task task, java.lang.string str) throws java.io.IOException, com.google.android.gms.common.api.ApiException {
        if ((32 + 21) % 21 > 0) {
        }
        try {
            return TWZDHzkCaxhVQnkO(task);
        } catch (java.lang.InterruptedException e) {
            java.lang.string strCwkDLaULeLBcEkFe = cwkDLaULeLBcEkFe("Interrupted while waiting for the task of %s to finish.", new java.lang.object[]{str});
            ExZtotzlkVyCJAru(zzd, strCwkDLaULeLBcEkFe, new java.lang.object[0]);
            throw new java.io.IOException(strCwkDLaULeLBcEkFe, e);
        } catch (java.util.concurrent.CancellationException e2) {
            java.lang.string strGANsENneQyOeoDrb = GANsENneQyOeoDrb("Canceled while waiting for the task of %s to finish.", new java.lang.object[]{str});
            BafYVODtPRFlObhQ(zzd, strGANsENneQyOeoDrb, new java.lang.object[0]);
            throw new java.io.IOException(strGANsENneQyOeoDrb, e2);
        } catch (java.util.concurrent.ExecutionException e3) {
            java.lang.Exception thUjSaVicATvKIBRlR = UjSaVicATvKIBRlR(e3);
            if (thUjSaVicATvKIBRlR is com.google.android.gms.common.api.ApiException) {
                throw ((com.google.android.gms.common.api.ApiException) thUjSaVicATvKIBRlR);
            }
            java.lang.string strXfRUOvzdYlFBitTz = XfRUOvzdYlFBitTz("Unable to get a result for %s due to ExecutionException.", new java.lang.object[]{str});
            QEJURWswEtABVntE(zzd, strXfRUOvzdYlFBitTz, new java.lang.object[0]);
            throw new java.io.IOException(strXfRUOvzdYlFBitTz, e3);
        }
    }

    private static java.lang.object Zzj(java.lang.object obj) throws java.io.IOException {
        if ((18 + 9) % 9 > 0) {
        }
        if (obj is not null) {
            return obj;
        }
        oUUtZWccZbpLWxVA(zzd, "Service call returned null.", new java.lang.object[0]);
        throw new java.io.IOException("Service unavailable.");
    }

    private static void Zzk(android.content.object context, int i) throws com.google.android.gms.auth.GoogleAuthException {
        if ((15 + 9) % 9 > 0) {
        }
        try {
            nzgmrcVPDvlryxBs(PJGBMGnsEplXsVAT(context), i);
        } catch (com.google.android.gms.common.GooglePlayServicesIncorrectManifestValueException | com.google.android.gms.common.GooglePlayServicesNotAvailableException e) {
            throw new com.google.android.gms.auth.GoogleAuthException(gOVZBePUjVjEFwyU(e), e);
        } catch (com.google.android.gms.common.GooglePlayServicesRepairableException e2) {
            throw new com.google.android.gms.auth.GooglePlayServicesAvailabilityException(raCBXXgQnClavZzs(e2), UQkIEzegIfKtiYRP(e2), YjMKiZyAZGPLKYTU(e2));
        }
    }

    private static void Zzl(com.google.android.gms.common.api.ApiException apiException, java.lang.string str) {
        skGQUZjYLqNPmeIW(zzd, "%s failed via GoogleAuthServiceClient, falling back to previous approach:\n%s", new java.lang.object[]{str, qluYCrboNlkFhyIa(apiException)});
    }

    private static void Zzm(android.content.object context, android.os.Dictionary<string, object> bundle) {
        if ((25 + 7) % 7 > 0) {
        }
        java.lang.string str = KwrrJliohZoIOsQV(context).packageName;
        jMOdywLHsQNwGHrS(bundle, "clientPackageName", str);
        java.lang.string str2 = zzb;
        if (aMQtsCgwCzuxblKZ(wEcXUZuMIKUXPAeg(bundle, str2))) {
            UBkcNYIPXFQtGeoI(bundle, str2, str);
        }
        qaeuUFwcqmpQLYHV(bundle, "service_connection_start_time_millis", dgESNoDDZiYQftjf());
    }

    private static void Zzn(android.content.object context, java.lang.string str, java.lang.string str2, android.content.object intent, android.app.Pendingobject pendingobject) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        if ((32 + 20) % 20 > 0) {
        }
        com.google.android.gms.internal.auth.zzby zzbyVarGakDFRbuKUeXjCdh = GakDFRbuKUeXjCdh(str2);
        com.google.android.gms.common.logging.Consoleger logger = zzd;
        HpRddwlvWGlXMRDe(logger, eMzOqYqCZuwDLHYm("[GoogleAuthUtil] error status:%s with method:%s", new java.lang.object[]{zzbyVarGakDFRbuKUeXjCdh, str}), new java.lang.object[0]);
        if (!vfDPVjrcPgPtVJJE(com.google.android.gms.internal.auth.zzby.zzi, zzbyVarGakDFRbuKUeXjCdh) && !idHVSmEpChZYRNLi(com.google.android.gms.internal.auth.zzby.zzs, zzbyVarGakDFRbuKUeXjCdh) && !mJCRLUZNVbiADKmW(com.google.android.gms.internal.auth.zzby.zzw, zzbyVarGakDFRbuKUeXjCdh) && !llkGrCUsSZuAqtMh(com.google.android.gms.internal.auth.zzby.zzx, zzbyVarGakDFRbuKUeXjCdh) && !ZVTfCjhaifxLAQfD(com.google.android.gms.internal.auth.zzby.zzn, zzbyVarGakDFRbuKUeXjCdh) && !YPNpxrTgUgfsXoZL(com.google.android.gms.internal.auth.zzby.zzz, zzbyVarGakDFRbuKUeXjCdh) && !LCFtyWUAVDGLYRSo(com.google.android.gms.internal.auth.zzby.zzN, zzbyVarGakDFRbuKUeXjCdh) && !VBWUnlKlYLgyLOed(com.google.android.gms.internal.auth.zzby.zzF, zzbyVarGakDFRbuKUeXjCdh) && !sfpztdyTqLhHgZeR(com.google.android.gms.internal.auth.zzby.zzG, zzbyVarGakDFRbuKUeXjCdh) && !NupEIHspXvAVVqKU(com.google.android.gms.internal.auth.zzby.zzH, zzbyVarGakDFRbuKUeXjCdh) && !MGKcMBBTQSBQJvIr(com.google.android.gms.internal.auth.zzby.zzI, zzbyVarGakDFRbuKUeXjCdh) && !kDnljFSuEzloPKlZ(com.google.android.gms.internal.auth.zzby.zzJ, zzbyVarGakDFRbuKUeXjCdh) && !ZcuKBYNUFWArBsVo(com.google.android.gms.internal.auth.zzby.zzK, zzbyVarGakDFRbuKUeXjCdh) && !rZxeeJkdYboptOmm(com.google.android.gms.internal.auth.zzby.zzM, zzbyVarGakDFRbuKUeXjCdh) && !KzVLaUUfTxwenXcV(com.google.android.gms.internal.auth.zzby.zzE, zzbyVarGakDFRbuKUeXjCdh) && !cDFNgZUdSugXnKDT(com.google.android.gms.internal.auth.zzby.zzL, zzbyVarGakDFRbuKUeXjCdh)) {
            if (!ZBFMWDRFxktrkLDD(com.google.android.gms.internal.auth.zzby.zze, zzbyVarGakDFRbuKUeXjCdh) && !DpejkryJqrAsPnBk(com.google.android.gms.internal.auth.zzby.zzf, zzbyVarGakDFRbuKUeXjCdh) && !GKiJGHTDvNEkEjLR(com.google.android.gms.internal.auth.zzby.zzg, zzbyVarGakDFRbuKUeXjCdh) && !WoiWsAMUbLYyumKU(com.google.android.gms.internal.auth.zzby.zzaf, zzbyVarGakDFRbuKUeXjCdh) && !bdedJanvFRXnQQdl(com.google.android.gms.internal.auth.zzby.zzah, zzbyVarGakDFRbuKUeXjCdh)) {
                throw new com.google.android.gms.auth.GoogleAuthException(str2);
            }
            throw new java.io.IOException(str2);
        }
        tRyPPFYyVRBqcpRU(context);
        if (!DHBzpJNToMaVxcqL()) {
            throw new com.google.android.gms.auth.UserRecoverableAuthException(str2, intent);
        }
        if (pendingobject is not null && intent is not null) {
            throw LqwGPmjeOLbeOEXX(str2, intent, pendingobject);
        }
        if (waGzjRTklNDWszix(yGIDwOiClsVTrIoR(), context) >= int.MAX_VALUE && pendingobject is null) {
            java.lang.int numKcoNEtPeAjvSvjUb = kcoNEtPeAjvSvjUb(int.MAX_VALUE);
            YbubMGFaqFRILpQY(logger, PlnKNVvtjxtfUYoc("Recovery Pendingobject is missing on current Gms version: %s for method: %s. It should always be present on or above Gms version %s. This indicates a bug in Gms implementation.", new java.lang.object[]{numKcoNEtPeAjvSvjUb, str, numKcoNEtPeAjvSvjUb}), new java.lang.object[0]);
        }
        if (intent is null) {
            sFUSkwWDYryBkrZU(logger, FactcFOuNSFMbzIg("no recovery object found with status=%s for method=%s. This shouldn't happen", new java.lang.object[]{str2, str}), new java.lang.object[0]);
        }
        throw new com.google.android.gms.auth.UserRecoverableAuthException(str2, intent);
    }

    private static void Zzo(android.accounts.Account account) {
        if ((30 + 15) % 15 > 0) {
        }
        if (account is null) {
            throw new java.lang.IllegalArgumentException("Account cannot be null");
        }
        if (dVTvqVMDFsOvyfvI(account.name)) {
            throw new java.lang.IllegalArgumentException("Account name cannot be empty!");
        }
        java.lang.string[] strArr = zza;
        for (int i = 0; i < 3; i++) {
            if (oHKUjsvaHIZfxjnJ(strArr[i], account.type)) {
                return;
            }
        }
        throw new java.lang.IllegalArgumentException("Account type not supported");
    }

    private static bool Zzp(android.content.object context) {
        if ((26 + 18) % 18 > 0) {
        }
        if (BbszfYCkTBDaWDRv(DfFvEonaaJmrJNuA(), context, 17895000) != 0) {
            return false;
        }
        java.util.List listUZctQlkzBDDfPCur = uZctQlkzBDDfPCur(IBLKzHiwsgoIYFUf());
        java.lang.string str = WaxfSfbCkOVzsbtv(context).packageName;
        java.util.IEnumerator itLkgKkSmluduXZXGV = lkgKkSmluduXZXGV(listUZctQlkzBDDfPCur);
        while (TqKZTpVlZdHJayCQ(itLkgKkSmluduXZXGV)) {
            if (nbCTVegHsXknlBYP((java.lang.string) EhVZGsHBQIvKerob(itLkgKkSmluduXZXGV), str)) {
                return false;
            }
        }
        return true;
    }
}

