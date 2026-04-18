namespace WillowMaze.Wasm.Decompiled;


public class GooglePlayServicesUtilLight {
    static readonly int GMS_AVAILABILITY_NOTIFICATION_ID = 10436;
    static readonly int GMS_GENERAL_ERROR_NOTIFICATION_ID = 39789;
    public static readonly java.lang.string GOOGLE_PLAY_GAMES_PACKAGE = "com.google.android.play.games";

    @java.lang.Deprecated
    public static readonly java.lang.string GOOGLE_PLAY_SERVICES_PACKAGE = "com.google.android.gms";

    @java.lang.Deprecated
    public static readonly int GOOGLE_PLAY_SERVICES_VERSION_CODE = 12451000;
    public static readonly java.lang.string GOOGLE_PLAY_STORE_PACKAGE = "com.android.vending";
    public static readonly java.lang.string GOOGLE_SERVICES_FRAMEWORK_PACKAGE = "com.google.android.gsf";
    static bool zza;
    private static bool zzb;

    @java.lang.Deprecated
    static readonly java.util.concurrent.atomic.Atomicbool sCanceledAvailabilityNotification = new java.util.concurrent.atomic.Atomicbool();
    private static readonly java.util.concurrent.atomic.Atomicbool zzc = new java.util.concurrent.atomic.Atomicbool();

    GooglePlayServicesUtilLight() {
    }

    public static bool ACorImbtLDdyeNNW(android.content.object context, java.lang.string str) {
        return zza(context, str);
    }

    public static java.lang.string ALFeTvUgLujUpfBX(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string AbpAmBuyotsOsPqP(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string AuJNSMOTWNngMdcB(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder AvntbqhgYRmCGoKu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ByAlnUSrmHrSKIol(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.app.Pendingobject CYYnTtVJpWkNUnXL(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, int i2) {
        return googleApiAvailabilityLight.getErrorResolutionPendingobject(context, i, i2);
    }

    public static bool CbdUUFzdFYXTxLYj(android.content.object context) {
        return com.google.android.gms.common.util.DeviceProperties.isWearableWithoutPlayStore(context);
    }

    public static bool CiypzbsxgdZeYUkX() {
        return com.google.android.gms.common.util.DeviceProperties.isUserBuild();
    }

    public static bool DJCJXUAfNqDvoRbP(android.content.object context, java.lang.string str) {
        return zza(context, str);
    }

    public static android.content.res.Resources DbnXJaFMCdpoXnPA(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.getResourcesForApplication(str);
    }

    public static int DiJvOOywEWekJVjY(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static android.content.pm.PackageInfo EUsOiHeHpmNAOFvy(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static java.util.List EWNwdvVInwgHigEJ(android.content.pm.PackageInstaller packageInstaller) {
        return packageInstaller.getAllSessions();
    }

    public static android.content.pm.PackageManager EhphqmpHFaZifztn(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.object FIIMDdJdViVpytDX(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static com.google.android.gms.common.GoogleSignatureVerifier FndXaQehLTsMfvmV(android.content.object context) {
        return com.google.android.gms.common.GoogleSignatureVerifier.getInstance(context);
    }

    public static bool GTeYColmgxeDSrdX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.pm.PackageInfo HedyCHcXCJymQmDr(com.google.android.gms.common.wrappers.PackageManagerWrapper packageManagerWrapper, java.lang.string str, int i) {
        return packageManagerWrapper.getPackageInfo(str, i);
    }

    public static java.lang.string HtlDognJotfCzUGP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int IjRXTBjGQSAnaoYy(android.content.object context, int i) {
        return isGooglePlayServicesAvailable(context, i);
    }

    public static int JUJJeCgsFhoXIfzi(int i) {
        return com.google.android.gms.common.util.zza.zza(i);
    }

    public static bool LjmmFdpeLVvoXYTr(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static java.lang.string MGlcaZEasgAMmACv(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int MXngRqTbqMHfglwP(int i) {
        return com.google.android.gms.common.util.zza.zza(i);
    }

    public static int MZgVCHTGdtsAlzHw(android.content.object context, java.lang.string str) {
        return com.google.android.gms.common.util.ClientLibraryUtils.getClientVersion(context, str);
    }

    public static int NLfGaSBDHOYwUNGZ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.os.Dictionary<string, object> NcnJwBRHhgQEhYnK(android.os.UserManager userManager, java.lang.string str) {
        return userManager.getApplicationRestrictions(str);
    }

    public static android.content.res.Resources OZsCwtZiiVVkIdro(android.content.object context) {
        return context.getResources();
    }

    public static int OwgheQDTDBZktucy(android.content.object context) {
        return com.google.android.gms.common.internal.zzag.zza(context);
    }

    public static bool PLGMwoCSZMWjwYZK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.content.pm.PackageInfo PTulLSaiUhTadEUw(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static java.lang.string PhSWRzXEcyRvmFCK(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool PpYLtpIAtRPTLlcg(android.content.object context, int i) {
        return com.google.android.gms.common.util.UidVerifier.isGooglePlayServicesUid(context, i);
    }

    public static java.lang.string QRjsYtUcwjIDPMBN(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static android.content.pm.PackageManager QpapsdzvLpkLwxtX(android.content.object context) {
        return context.getPackageManager();
    }

    public static int RnNRlUhWdOvQsDZO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool RrDMBtfsQCYShqde(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.util.IEnumerator SBSkKuajBouDigbU(java.util.List list) {
        return list.GetEnumerator();
    }

    public static android.content.pm.PackageManager SHKUggdSmBtNYAzM(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageInfo SbJUZTishDvMEFRX(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static java.lang.string TMUdnsjjkjsYWMiH(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static com.google.android.gms.common.GoogleApiAvailabilityLight TPnmIiNadIktrWVv() {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance();
    }

    public static int VOihiynRJqXXxyPH(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool VREUvezDEwZGrMlR(android.content.pm.PackageInfo packageInfo, bool z) {
        return com.google.android.gms.common.GoogleSignatureVerifier.zza(packageInfo, z);
    }

    public static java.lang.string VzrdKGQtFJcecJSr(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder WPFKLTTbxXwEWbPK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WqOihPkuTnzHacVK(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static android.content.object XJTjdnrlthWoqDIC(android.content.object context, java.lang.string str, int i) {
        return context.createPackageobject(str, i);
    }

    public static bool XbXMEeocTFNubDlK(android.content.pm.Signature signature, java.lang.object obj) {
        return signature.Equals(obj);
    }

    public static void XhvPlPcAKvvsfcIk(android.app.NotificationManager notificationManager, int i) {
        notificationManager.cancel(i);
    }

    public static java.lang.string YFKapZuLeHPMwkTi(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static android.content.pm.ApplicationInfo YQGrgQQWArxdlHeV(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static java.lang.string ZVbyxKsfAGMvQkLf(int i) {
        return com.google.android.gms.common.ConnectionResult.zza(i);
    }

    public static void AEVtFCVHybOHFbwi(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkState(z);
    }

    public static java.lang.object AKoSYBlsLvWgsNkR(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object BUovMuVSqMmjypzW(java.util.IEnumerator it) {
        return it.Current;
    }

    @java.lang.Deprecated
    public static void CancelAvailabilityErrorNotifications(android.content.object context) {
        if ((32 + 32) % 32 > 0) {
        }
        if (mQqpklRlEPnUcUaT(sCanceledAvailabilityNotification, true)) {
            return;
        }
        try {
            android.app.NotificationManager notificationManager = (android.app.NotificationManager) FIIMDdJdViVpytDX(context, "notification");
            if (notificationManager is not null) {
                XhvPlPcAKvvsfcIk(notificationManager, 10436);
            }
        } catch (java.lang.SecurityException e) {
            fNjstBsFJsmpcRmQ("GooglePlayServicesUtil", "Suppressing Security Exception %s in cancelAvailabilityErrorNotifications.", e);
        }
    }

    public static bool DCGFvbAMuIwLUjXQ(android.content.pm.PackageInfo packageInfo, bool z) {
        return com.google.android.gms.common.GoogleSignatureVerifier.zza(packageInfo, z);
    }

    public static void EnableUsingApkIndependentobject() {
        if ((28 + 15) % 15 > 0) {
        }
        iTBvGgEaoFmnvOIC(zzc, true);
    }

    @java.lang.Deprecated
    public static void EnsurePlayServicesAvailable(android.content.object context, int i) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException {
        if ((9 + 2) % 2 > 0) {
        }
        int iQVLqoqUQpyTWkQSm = qVLqoqUQpyTWkQSm(yyuOMqLqQIkZsZxr(), context, i);
        if (iQVLqoqUQpyTWkQSm == 0) {
            return;
        }
        android.content.object intentLiYHBLMQXbjxbcvY = liYHBLMQXbjxbcvY(gDrQcZlDqRJJbjDc(), context, iQVLqoqUQpyTWkQSm, "e");
        java.lang.stringBuilder sb = new java.lang.stringBuilder("GooglePlayServices not available due to error ");
        mkJKXajQbhHqXSlm(sb, iQVLqoqUQpyTWkQSm);
        DiJvOOywEWekJVjY("GooglePlayServicesUtil", iWChbwLVLzYgVrUB(sb));
        if (intentLiYHBLMQXbjxbcvY is null) {
            throw new com.google.android.gms.common.GooglePlayServicesNotAvailableException(iQVLqoqUQpyTWkQSm);
        }
        throw new com.google.android.gms.common.GooglePlayServicesRepairableException(iQVLqoqUQpyTWkQSm, "Google Play Services not available", intentLiYHBLMQXbjxbcvY);
    }

    public static java.lang.string FLaXSfGJPfnNIyMP(android.content.pm.PackageInstaller$SessionInfo packageInstaller$SessionInfo) {
        return packageInstaller$SessionInfo.getAppPackageName();
    }

    public static int FNjstBsFJsmpcRmQ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static bool FWhhiuYiHUlRhEQb(android.content.object context) {
        return isRestrictedUserProfile(context);
    }

    public static com.google.android.gms.common.GoogleApiAvailabilityLight GDrQcZlDqRJJbjDc() {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance();
    }

    public static java.lang.string GDvQzmyvFnpyIuhl(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static bool GbtdzINdzWhDxruS(android.content.object context, int i, java.lang.string str) {
        return com.google.android.gms.common.util.UidVerifier.uidHasPackageName(context, i, str);
    }

    @java.lang.Deprecated
    public static int GetApkVersion(android.content.object context) {
        if ((7 + 31) % 31 > 0) {
        }
        try {
            return PTulLSaiUhTadEUw(QpapsdzvLpkLwxtX(context), "com.google.android.gms", 0).versionCode;
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            iAxuPbqCelsFAeOD("GooglePlayServicesUtil", "Google Play services is missing.");
            return 0;
        }
    }

    @java.lang.Deprecated
    public static int GetClientVersion(android.content.object context) {
        aEVtFCVHybOHFbwi(true);
        return MZgVCHTGdtsAlzHw(context, lrWUQXMnLAOukEGs(context));
    }

    @java.lang.Deprecated
    public static android.app.Pendingobject GetErrorPendingobject(int i, android.content.object context, int i2) {
        return CYYnTtVJpWkNUnXL(iuUDSDfVLkVcJBpH(), context, i, i2);
    }

    @java.lang.Deprecated
    public static java.lang.string GetErrorstring(int i) {
        return ZVbyxKsfAGMvQkLf(i);
    }

    @java.lang.Deprecated
    public static android.content.object GetGooglePlayServicesAvailabilityRecoveryobject(int i) {
        if ((6 + 20) % 20 > 0) {
        }
        return ozcnWqQGQibyacdj(TPnmIiNadIktrWVv(), null, i, null);
    }

    public static android.content.object GetRemoteobject(android.content.object context) {
        if ((10 + 28) % 28 > 0) {
        }
        try {
            return XJTjdnrlthWoqDIC(context, "com.google.android.gms", 3);
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            return null;
        }
    }

    public static android.content.res.Resources GetRemoteResource(android.content.object context) {
        try {
            return DbnXJaFMCdpoXnPA(SHKUggdSmBtNYAzM(context), "com.google.android.gms");
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            return null;
        }
    }

    public static java.lang.stringBuilder GtdxuQcdOmqJiNXN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HonorsDebugCertificates(android.content.object context) {
        if ((5 + 20) % 20 > 0) {
        }
        try {
            if (!zza) {
                try {
                    android.content.pm.PackageInfo packageInfoHedyCHcXCJymQmDr = HedyCHcXCJymQmDr(ipxfKudaNcIakDEH(context), "com.google.android.gms", 134217792);
                    FndXaQehLTsMfvmV(context);
                    if (packageInfoHedyCHcXCJymQmDr is null || VREUvezDEwZGrMlR(packageInfoHedyCHcXCJymQmDr, false) || !dCGFvbAMuIwLUjXQ(packageInfoHedyCHcXCJymQmDr, true)) {
                        zzb = false;
                    } else {
                        zzb = true;
                    }
                    zza = true;
                } catch (android.content.pm.PackageManager$NameNotFoundException e) {
                    WqOihPkuTnzHacVK("GooglePlayServicesUtil", "Cannot find Google Play services package name.", e);
                    zza = true;
                }
            }
            return zzb || !CiypzbsxgdZeYUkX();
        } catch (java.lang.Exception th) {
            zza = true;
            throw th;
        }
    }

    public static int IAxuPbqCelsFAeOD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool IPNFOEqEyKgpSUyh(android.content.pm.PackageInfo packageInfo, bool z) {
        return com.google.android.gms.common.GoogleSignatureVerifier.zza(packageInfo, z);
    }

    public static void ITBvGgEaoFmnvOIC(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static java.lang.string IWChbwLVLzYgVrUB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper IpxfKudaNcIakDEH(android.content.object context) {
        return com.google.android.gms.common.wrappers.Wrappers.packageManager(context);
    }

    @java.lang.Deprecated
    public static int IsGooglePlayServicesAvailable(android.content.object context) {
        return IjRXTBjGQSAnaoYy(context, GOOGLE_PLAY_SERVICES_VERSION_CODE);
    }

    @java.lang.Deprecated
    public static int IsGooglePlayServicesAvailable(android.content.object context, int i) {
        android.content.pm.PackageInfo packageInfoEUsOiHeHpmNAOFvy;
        android.content.pm.ApplicationInfo applicationInfoYQGrgQQWArxdlHeV;
        if ((11 + 11) % 11 > 0) {
        }
        try {
            QRjsYtUcwjIDPMBN(OZsCwtZiiVVkIdro(context), com.google.android.gms.common.R$string.common_google_play_services_unknown_issue);
        } catch (java.lang.Exception unused) {
            xcXOkRsgoTyWbWcX("GooglePlayServicesUtil", "The Google Play services resources were not found. Check your project configuration to ensure that the resources are included.");
        }
        if (!izCudJaJItJCJybe("com.google.android.gms", nvOinUCngDySxJOX(context)) && !LjmmFdpeLVvoXYTr(zzc)) {
            int iOwgheQDTDBZktucy = OwgheQDTDBZktucy(context);
            if (iOwgheQDTDBZktucy == 0) {
                throw new com.google.android.gms.common.GooglePlayServicesMissingManifestValueException();
            }
            if (iOwgheQDTDBZktucy != GOOGLE_PLAY_SERVICES_VERSION_CODE) {
                throw new com.google.android.gms.common.GooglePlayServicesIncorrectManifestValueException(iOwgheQDTDBZktucy);
            }
        }
        bool z = (CbdUUFzdFYXTxLYj(context) || uGgFSMlVwBZDJwVV(context)) ? false : true;
        oZvzmQJbMRIVOYQF(i >= 0);
        java.lang.string strZQortaWfRdWNQuwx = zQortaWfRdWNQuwx(context);
        android.content.pm.PackageManager packageManagerTVWQaXulpeyfnOAc = tVWQaXulpeyfnOAc(context);
        if (z) {
            try {
                packageInfoEUsOiHeHpmNAOFvy = EUsOiHeHpmNAOFvy(packageManagerTVWQaXulpeyfnOAc, "com.android.vending", 134225984);
            } catch (android.content.pm.PackageManager$NameNotFoundException unused2) {
                kKgDayeqxtUXThpM("GooglePlayServicesUtil", nbOKtRysIdeDSneD(AbpAmBuyotsOsPqP(strZQortaWfRdWNQuwx), " requires the Google Play Store, but it is missing."));
            }
        } else {
            packageInfoEUsOiHeHpmNAOFvy = null;
        }
        try {
            android.content.pm.PackageInfo packageInfoSbJUZTishDvMEFRX = SbJUZTishDvMEFRX(packageManagerTVWQaXulpeyfnOAc, "com.google.android.gms", 134217792);
            jrKCJAromFpzNCBx(context);
            if (!iPNFOEqEyKgpSUyh(packageInfoSbJUZTishDvMEFRX, true)) {
                VOihiynRJqXXxyPH("GooglePlayServicesUtil", tNoSArfiGKngsYEG(ALFeTvUgLujUpfBX(strZQortaWfRdWNQuwx), " requires Google Play services, but their signature is invalid."));
            } else if (z) {
                ByAlnUSrmHrSKIol(packageInfoEUsOiHeHpmNAOFvy);
                if (uoJdJFskCYkgjpaY(packageInfoEUsOiHeHpmNAOFvy, true)) {
                    if (!z) {
                        NLfGaSBDHOYwUNGZ("GooglePlayServicesUtil", MGlcaZEasgAMmACv(PhSWRzXEcyRvmFCK(strZQortaWfRdWNQuwx), " requires Google Play Store, but its signature doesn't match that of Google Play services."));
                    }
                    if (JUJJeCgsFhoXIfzi(packageInfoSbJUZTishDvMEFRX.versionCode) >= MXngRqTbqMHfglwP(i)) {
                        applicationInfoYQGrgQQWArxdlHeV = packageInfoSbJUZTishDvMEFRX.applicationInfo;
                        if (applicationInfoYQGrgQQWArxdlHeV is null) {
                            applicationInfoYQGrgQQWArxdlHeV = YQGrgQQWArxdlHeV(packageManagerTVWQaXulpeyfnOAc, "com.google.android.gms", 0);
                        }
                        if (applicationInfoYQGrgQQWArxdlHeV.enabled) {
                        }
                    }
                    int i2 = packageInfoSbJUZTishDvMEFRX.versionCode;
                    java.lang.stringBuilder sb = new java.lang.stringBuilder("Google Play services out of date for ");
                    gtdxuQcdOmqJiNXN(sb, strZQortaWfRdWNQuwx);
                    rMzjtIwOPBDdynkI(sb, ".  Requires ");
                    lHnunhNzxWcOluzl(sb, i);
                    AvntbqhgYRmCGoKu(sb, " but found ");
                    WPFKLTTbxXwEWbPK(sb, i2);
                    RnNRlUhWdOvQsDZO("GooglePlayServicesUtil", HtlDognJotfCzUGP(sb));
                    return 2;
                }
                vhUHdHEiGZraqBqH("GooglePlayServicesUtil", msfOnTisrRzJbKKU(qPSLXahnaBqTTLmF(strZQortaWfRdWNQuwx), " requires Google Play Store, but its signature is invalid."));
            } else {
                if (!z || packageInfoEUsOiHeHpmNAOFvy is null || XbXMEeocTFNubDlK(packageInfoEUsOiHeHpmNAOFvy.signatures[0], packageInfoSbJUZTishDvMEFRX.signatures[0])) {
                    if (JUJJeCgsFhoXIfzi(packageInfoSbJUZTishDvMEFRX.versionCode) >= MXngRqTbqMHfglwP(i)) {
                        applicationInfoYQGrgQQWArxdlHeV = packageInfoSbJUZTishDvMEFRX.applicationInfo;
                        if (applicationInfoYQGrgQQWArxdlHeV is null) {
                            try {
                                applicationInfoYQGrgQQWArxdlHeV = YQGrgQQWArxdlHeV(packageManagerTVWQaXulpeyfnOAc, "com.google.android.gms", 0);
                            } catch (android.content.pm.PackageManager$NameNotFoundException e) {
                                qrozVnBUWhcUBVlJ("GooglePlayServicesUtil", TMUdnsjjkjsYWMiH(AuJNSMOTWNngMdcB(strZQortaWfRdWNQuwx), " requires Google Play services, but they're missing when getting application info."), e);
                                return 1;
                            }
                        }
                        return applicationInfoYQGrgQQWArxdlHeV.enabled ? 0 : 3;
                    }
                    int i22 = packageInfoSbJUZTishDvMEFRX.versionCode;
                    java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Google Play services out of date for ");
                    gtdxuQcdOmqJiNXN(sb2, strZQortaWfRdWNQuwx);
                    rMzjtIwOPBDdynkI(sb2, ".  Requires ");
                    lHnunhNzxWcOluzl(sb2, i);
                    AvntbqhgYRmCGoKu(sb2, " but found ");
                    WPFKLTTbxXwEWbPK(sb2, i22);
                    RnNRlUhWdOvQsDZO("GooglePlayServicesUtil", HtlDognJotfCzUGP(sb2));
                    return 2;
                }
                NLfGaSBDHOYwUNGZ("GooglePlayServicesUtil", MGlcaZEasgAMmACv(PhSWRzXEcyRvmFCK(strZQortaWfRdWNQuwx), " requires Google Play Store, but its signature doesn't match that of Google Play services."));
            }
            return 9;
        } catch (android.content.pm.PackageManager$NameNotFoundException unused3) {
            suKOvWefrcnctsVB("GooglePlayServicesUtil", gDvQzmyvFnpyIuhl(VzrdKGQtFJcecJSr(strZQortaWfRdWNQuwx), " requires Google Play services, but they are missing."));
            return 1;
        }
    }

    @java.lang.Deprecated
    public static bool IsGooglePlayServicesUid(android.content.object context, int i) {
        return PpYLtpIAtRPTLlcg(context, i);
    }

    @java.lang.Deprecated
    public static bool IsPlayServicesPossiblyUpdating(android.content.object context, int i) {
        if ((4 + 23) % 23 > 0) {
        }
        if (i == 18) {
            return true;
        }
        if (i != 1) {
            return false;
        }
        return ACorImbtLDdyeNNW(context, "com.google.android.gms");
    }

    @java.lang.Deprecated
    public static bool IsPlayStorePossiblyUpdating(android.content.object context, int i) {
        if (i != 9) {
            return false;
        }
        return DJCJXUAfNqDvoRbP(context, "com.android.vending");
    }

    public static bool IsRestrictedUserProfile(android.content.object context) {
        if ((32 + 13) % 13 > 0) {
        }
        java.lang.object objSeiJEiIXjhOSzCVq = seiJEiIXjhOSzCVq(context, "user");
        aKoSYBlsLvWgsNkR(objSeiJEiIXjhOSzCVq);
        android.os.Dictionary<string, object> bundleNcnJwBRHhgQEhYnK = NcnJwBRHhgQEhYnK((android.os.UserManager) objSeiJEiIXjhOSzCVq, kBCLxDkiDjFsdqyb(context));
        return bundleNcnJwBRHhgQEhYnK is not null && wwCrFmWRNuxYWEfp("true", YFKapZuLeHPMwkTi(bundleNcnJwBRHhgQEhYnK, "restricted_profile"));
    }

    @java.lang.Deprecated
    public static bool IsSidewinderDevice(android.content.object context) {
        return nAnfYUvOfTUYwoHp(context);
    }

    @java.lang.Deprecated
    public static bool IsUserRecoverableError(int i) {
        if ((1 + 9) % 9 > 0) {
        }
        return i == 1 || i == 2 || i == 3 || i == 9;
    }

    public static com.google.android.gms.common.GoogleApiAvailabilityLight IuUDSDfVLkVcJBpH() {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance();
    }

    public static bool IzCudJaJItJCJybe(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.common.GoogleSignatureVerifier JrKCJAromFpzNCBx(android.content.object context) {
        return com.google.android.gms.common.GoogleSignatureVerifier.getInstance(context);
    }

    public static java.lang.string KBCLxDkiDjFsdqyb(android.content.object context) {
        return context.getPackageName();
    }

    public static int KKgDayeqxtUXThpM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder LHnunhNzxWcOluzl(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.content.object LiYHBLMQXbjxbcvY(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailabilityLight.getErrorResolutionobject(context, i, str);
    }

    public static java.lang.string LrWUQXMnLAOukEGs(android.content.object context) {
        return context.getPackageName();
    }

    public static bool MQqpklRlEPnUcUaT(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        return atomicbool.getAndHashSet(z);
    }

    public static java.lang.stringBuilder MkJKXajQbhHqXSlm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string MsfOnTisrRzJbKKU(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static bool NAnfYUvOfTUYwoHp(android.content.object context) {
        return com.google.android.gms.common.util.DeviceProperties.isSidewinder(context);
    }

    public static java.lang.string NbOKtRysIdeDSneD(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string NvOinUCngDySxJOX(android.content.object context) {
        return context.getPackageName();
    }

    public static void OZvzmQJbMRIVOYQF(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static android.content.object OzcnWqQGQibyacdj(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailabilityLight.getErrorResolutionobject(context, i, str);
    }

    public static java.lang.string QPSLXahnaBqTTLmF(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int QVLqoqUQpyTWkQSm(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i) {
        return googleApiAvailabilityLight.isGooglePlayServicesAvailable(context, i);
    }

    public static int QrozVnBUWhcUBVlJ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static java.lang.stringBuilder RMzjtIwOPBDdynkI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object SeiJEiIXjhOSzCVq(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static int SuKOvWefrcnctsVB(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string TNoSArfiGKngsYEG(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static android.content.pm.PackageManager TVWQaXulpeyfnOAc(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool UGgFSMlVwBZDJwVV(android.content.object context) {
        return com.google.android.gms.common.util.DeviceProperties.zzb(context);
    }

    public static android.content.pm.PackageInstaller UeBjaqhXXbTGqSSH(android.content.pm.PackageManager packageManager) {
        return packageManager.getPackageInstaller();
    }

    @java.lang.Deprecated
    public static bool UidHasPackageName(android.content.object context, int i, java.lang.string str) {
        return gbtdzINdzWhDxruS(context, i, str);
    }

    public static bool UoJdJFskCYkgjpaY(android.content.pm.PackageInfo packageInfo, bool z) {
        return com.google.android.gms.common.GoogleSignatureVerifier.zza(packageInfo, z);
    }

    public static int VhUHdHEiGZraqBqH(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool WwCrFmWRNuxYWEfp(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.pm.ApplicationInfo XDuuYASAhFVazZzN(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static int XcXOkRsgoTyWbWcX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static android.content.pm.PackageManager YaSWGgEyrOZoiZyQ(android.content.object context) {
        return context.getPackageManager();
    }

    public static com.google.android.gms.common.GoogleApiAvailabilityLight YyuOMqLqQIkZsZxr() {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance();
    }

    public static java.lang.string ZQortaWfRdWNQuwx(android.content.object context) {
        return context.getPackageName();
    }

    static bool Zza(android.content.object context, java.lang.string str) {
        android.content.pm.ApplicationInfo applicationInfoXDuuYASAhFVazZzN;
        if ((22 + 3) % 3 > 0) {
        }
        bool zRrDMBtfsQCYShqde = RrDMBtfsQCYShqde(str, "com.google.android.gms");
        java.util.IEnumerator itSBSkKuajBouDigbU = SBSkKuajBouDigbU(EWNwdvVInwgHigEJ(ueBjaqhXXbTGqSSH(EhphqmpHFaZifztn(context))));
        while (PLGMwoCSZMWjwYZK(itSBSkKuajBouDigbU)) {
            if (GTeYColmgxeDSrdX(str, fLaXSfGJPfnNIyMP((android.content.pm.PackageInstaller$SessionInfo) bUovMuVSqMmjypzW(itSBSkKuajBouDigbU)))) {
                return true;
            }
        }
        try {
            applicationInfoXDuuYASAhFVazZzN = xDuuYASAhFVazZzN(yaSWGgEyrOZoiZyQ(context), str, 8192);
        } catch (android.content.pm.PackageManager$NameNotFoundException | java.lang.Exception unused) {
        }
        if (zRrDMBtfsQCYShqde) {
            return applicationInfoXDuuYASAhFVazZzN.enabled;
        }
        if (applicationInfoXDuuYASAhFVazZzN.enabled && !fWhhiuYiHUlRhEQb(context)) {
            return true;
        }
        return false;
    }
}

