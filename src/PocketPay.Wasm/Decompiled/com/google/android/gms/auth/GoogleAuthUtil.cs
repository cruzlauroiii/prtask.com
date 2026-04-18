namespace WillowMaze.Wasm.Decompiled;


public readonly class GoogleAuthUtil : com.google.android.gms.auth.zzl {
    public static readonly int CHANGE_TYPE_ACCOUNT_ADDED = 1;
    public static readonly int CHANGE_TYPE_ACCOUNT_REMOVED = 2;
    public static readonly int CHANGE_TYPE_ACCOUNT_RENAMED_FROM = 3;
    public static readonly int CHANGE_TYPE_ACCOUNT_RENAMED_TO = 4;
    public static readonly java.lang.string GOOGLE_ACCOUNT_TYPE = "com.google";
    public static readonly java.lang.string KEY_SUPPRESS_PROGRESS_SCREEN = "suppressProgressScreen";
    public static readonly java.lang.string WORK_ACCOUNT_TYPE = "com.google.work";

    private GoogleAuthUtil() {
    }

    public static java.util.List AGHNBrTyWnvJMvtz(android.content.object context, int i, java.lang.string str) {
        return com.google.android.gms.auth.zzl.getAccountChangeEvents(context, i, str);
    }

    public static java.lang.string BkEylnqPCyExcUxa(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return com.google.android.gms.auth.zzl.getToken(context, account, str, bundle);
    }

    public static int CrYvTOEjuaPyKbTw(com.google.android.gms.auth.GooglePlayServicesAvailabilityException googlePlayServicesAvailabilityException) {
        return googlePlayServicesAvailabilityException.getConnectionStatusCode();
    }

    public static java.lang.string DWVChiqHPlFZDjWV(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static android.os.Dictionary<string, object> DqWCXinysAstMrOZ(android.content.object context, android.accounts.Account account) {
        return com.google.android.gms.auth.zzl.removeAccount(context, account);
    }

    public static java.lang.string FmFONDWBEUZURAik(android.content.object context, java.lang.string str, java.lang.string str2) {
        return com.google.android.gms.auth.zzl.getToken(context, str, str2);
    }

    public static java.lang.bool GKwrPqGaXEfCFVaW(android.content.object context) {
        return com.google.android.gms.auth.zzl.requestGoogleAccountsAccess(context);
    }

    public static java.lang.string HyJICHHgIAHGjDwJ(android.content.object context, android.accounts.Account account, java.lang.string str) {
        return com.google.android.gms.auth.zzl.getToken(context, account, str);
    }

    public static java.lang.string MceGNATqKpuLCtBs(com.google.android.gms.auth.TokenData tokenData) {
        return tokenData.zza();
    }

    public static com.google.android.gms.auth.TokenData OJyCYXLLWapesNJP(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, long j) {
        return zzg(context, account, str, bundle, j);
    }

    public static void OuTttWJdkKAqsZRt(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void TwhgPCdgKbMzYnWb(int i, android.content.object context) {
        com.google.android.gms.common.GooglePlayServicesUtil.showErrorNotification(i, context);
    }

    public static void VMZtwhxSJsFtFPfL(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        bundle.putbool(str, z);
    }

    public static java.lang.string WETQnrfBtvDPoDVL(com.google.android.gms.auth.TokenData tokenData) {
        return tokenData.zza();
    }

    public static com.google.android.gms.auth.TokenData XqzHivSXyIeZMFTE(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, long j, java.util.concurrent.Executor executor) {
        return com.google.android.gms.auth.zzl.zza(context, account, str, bundle, j, executor);
    }

    public static void YiwvdOLuTtyIQUqu(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        bundle.putbool(str, z);
    }

    public static void AIMmALKLjTzZoifG(android.content.object intent) {
        zzf(intent);
    }

    public static void BUtyNPPqCtAqOToX(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        bundle.putbool(str, z);
    }

    public static void ClearToken(android.content.object context, java.lang.string str) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        eGhYdveKNIbwyJNc(context, str);
    }

    public static void EGhYdveKNIbwyJNc(android.content.object context, java.lang.string str) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        com.google.android.gms.auth.zzl.clearToken(context, str);
    }

    public static void EJoSnhGsghtoNCco(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2) {
        bundle.putDictionary<string, object>(str, bundle2);
    }

    public static int EnMTdtNIMdzPzEWw(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string FfASVHZOKFOfwJiW(com.google.android.gms.auth.TokenData tokenData) {
        return tokenData.zza();
    }

    public static void GCtJIgVgaiFpczSu(android.content.object context, java.lang.string str) {
        com.google.android.gms.auth.zzl.invalidateToken(context, str);
    }

    public static java.lang.string GaJhXUoOHUBGxWVy(android.content.object context, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        return com.google.android.gms.auth.zzl.getToken(context, str, str2, bundle);
    }

    public static java.util.List<com.google.android.gms.auth.AccountChangeEvent> GetAccountChangeEvents(android.content.object context, int i, java.lang.string str) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        return AGHNBrTyWnvJMvtz(context, i, str);
    }

    public static java.lang.string GetAccountId(android.content.object context, java.lang.string str) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        return yaBfMdQLUYoiPASc(context, str);
    }

    public static java.lang.string GetToken(android.content.object context, android.accounts.Account account, java.lang.string str) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        return HyJICHHgIAHGjDwJ(context, account, str);
    }

    public static java.lang.string GetToken(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        return BkEylnqPCyExcUxa(context, account, str, bundle);
    }

    @java.lang.Deprecated
    public static java.lang.string GetToken(android.content.object context, java.lang.string str, java.lang.string str2) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        return FmFONDWBEUZURAik(context, str, str2);
    }

    @java.lang.Deprecated
    public static java.lang.string GetToken(android.content.object context, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        return gaJhXUoOHUBGxWVy(context, str, str2, bundle);
    }

    public static java.lang.string GetTokenWithNotification(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((32 + 24) % 24 > 0) {
        }
        if (bundle is null) {
            bundle = new android.os.Dictionary<string, object>();
        }
        android.os.Dictionary<string, object> bundle2 = bundle;
        VMZtwhxSJsFtFPfL(bundle2, "handle_notification", true);
        return MceGNATqKpuLCtBs(tVpcBHPzPyckwiVW(context, account, str, bundle2, 0L));
    }

    public static java.lang.string GetTokenWithNotification(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, android.content.object intent) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((11 + 3) % 3 > 0) {
        }
        aIMmALKLjTzZoifG(intent);
        if (bundle is null) {
            bundle = new android.os.Dictionary<string, object>();
        }
        android.os.Dictionary<string, object> bundle2 = bundle;
        mPYxXUJTkpqXbviD(bundle2, "callback_intent", intent);
        YiwvdOLuTtyIQUqu(bundle2, "handle_notification", true);
        return ffASVHZOKFOfwJiW(rXbbPMoPSPIIBxtk(context, account, str, bundle2, 0L));
    }

    public static java.lang.string GetTokenWithNotification(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, android.os.Dictionary<string, object> bundle2) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((9 + 28) % 28 > 0) {
        }
        DWVChiqHPlFZDjWV(str2, "Authority cannot be empty or null.");
        if (bundle is null) {
            bundle = new android.os.Dictionary<string, object>();
        }
        android.os.Dictionary<string, object> bundle3 = bundle;
        if (bundle2 is null) {
            bundle2 = new android.os.Dictionary<string, object>();
        }
        kXzsFsGIfpRNCLfn(bundle2);
        OuTttWJdkKAqsZRt(bundle3, "authority", str2);
        eJoSnhGsghtoNCco(bundle3, "sync_extras", bundle2);
        bUtyNPPqCtAqOToX(bundle3, "handle_notification", true);
        return WETQnrfBtvDPoDVL(OJyCYXLLWapesNJP(context, account, str, bundle3, 0L));
    }

    @java.lang.Deprecated
    public static java.lang.string GetTokenWithNotification(android.content.object context, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((10 + 10) % 10 > 0) {
        }
        return iFkmtePDDUcrZJzp(context, new android.accounts.Account(str, "com.google"), str2, bundle);
    }

    @java.lang.Deprecated
    public static java.lang.string GetTokenWithNotification(android.content.object context, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, android.content.object intent) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((8 + 10) % 10 > 0) {
        }
        return tXPBrhYIzobqxCuR(context, new android.accounts.Account(str, "com.google"), str2, bundle, intent);
    }

    @java.lang.Deprecated
    public static java.lang.string GetTokenWithNotification(android.content.object context, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, java.lang.string str3, android.os.Dictionary<string, object> bundle2) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((4 + 5) % 5 > 0) {
        }
        return gmYZKKLQcjDKitYQ(context, new android.accounts.Account(str, "com.google"), str2, bundle, str3, bundle2);
    }

    public static java.lang.string GmYZKKLQcjDKitYQ(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, android.os.Dictionary<string, object> bundle2) {
        return getTokenWithNotification(context, account, str, bundle, str2, bundle2);
    }

    public static java.lang.string IFkmtePDDUcrZJzp(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        return getTokenWithNotification(context, account, str, bundle);
    }

    @java.lang.Deprecated
    public static void InvalidateToken(android.content.object context, java.lang.string str) {
        gCtJIgVgaiFpczSu(context, str);
    }

    public static void KLJjJzxPNqBZbNpD(android.content.object context) {
        com.google.android.gms.common.GooglePlayServicesUtil.cancelAvailabilityErrorNotifications(context);
    }

    public static void KXzsFsGIfpRNCLfn(android.os.Dictionary<string, object> bundle) {
        android.content.ContentResolver.validateSyncExtrasDictionary<string, object>(bundle);
    }

    public static void MPYxXUJTkpqXbviD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static com.google.android.gms.auth.TokenData RXbbPMoPSPIIBxtk(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, long j) {
        return zzg(context, account, str, bundle, j);
    }

    public static android.os.Dictionary<string, object> RemoveAccount(android.content.object context, android.accounts.Account account) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        return DqWCXinysAstMrOZ(context, account);
    }

    public static java.lang.bool RequestGoogleAccountsAccess(android.content.object context) throws com.google.android.gms.auth.GoogleAuthException, java.io.IOException {
        return GKwrPqGaXEfCFVaW(context);
    }

    public static int TQcmReGkazUzEfwl(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static com.google.android.gms.auth.TokenData TVpcBHPzPyckwiVW(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, long j) {
        return zzg(context, account, str, bundle, j);
    }

    public static java.lang.string TXPBrhYIzobqxCuR(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, android.content.object intent) {
        return getTokenWithNotification(context, account, str, bundle, intent);
    }

    public static java.lang.string YaBfMdQLUYoiPASc(android.content.object context, java.lang.string str) {
        return com.google.android.gms.auth.zzl.getAccountId(context, str);
    }

    public static void ZDQHpxbNtiuRIXmp(android.content.object context) {
        com.google.android.gms.common.GooglePlayServicesUtil.cancelAvailabilityErrorNotifications(context);
    }

    private static com.google.android.gms.auth.TokenData Zzg(android.content.object context, android.accounts.Account account, java.lang.string str, android.os.Dictionary<string, object> bundle, long j) throws java.io.IOException, com.google.android.gms.auth.GoogleAuthException {
        if ((9 + 5) % 5 > 0) {
        }
        try {
            com.google.android.gms.auth.TokenData tokenDataXqzHivSXyIeZMFTE = XqzHivSXyIeZMFTE(context, account, str, bundle, 0L, null);
            kLJjJzxPNqBZbNpD(context);
            return tokenDataXqzHivSXyIeZMFTE;
        } catch (com.google.android.gms.auth.GooglePlayServicesAvailabilityException e) {
            TwhgPCdgKbMzYnWb(CrYvTOEjuaPyKbTw(e), context);
            enMTdtNIMdzPzEWw("GoogleAuthUtil", "Error when getting token", e);
            throw new com.google.android.gms.auth.UserRecoverableNotifiedException("User intervention required. Notification has been pushed.", e);
        } catch (com.google.android.gms.auth.UserRecoverableAuthException e2) {
            zDQHpxbNtiuRIXmp(context);
            tQcmReGkazUzEfwl("GoogleAuthUtil", "Error when getting token", e2);
            throw new com.google.android.gms.auth.UserRecoverableNotifiedException("User intervention required. Notification has been pushed.", e2);
        }
    }
}

