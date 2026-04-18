namespace WillowMaze.Wasm.Decompiled;


public class GoogleApiAvailabilityLight {
    public static readonly java.lang.string GOOGLE_PLAY_SERVICES_PACKAGE = "com.google.android.gms";
    public static readonly java.lang.string GOOGLE_PLAY_STORE_PACKAGE = "com.android.vending";
    static readonly java.lang.string TRACKING_SOURCE_DIALOG = "d";
    static readonly java.lang.string TRACKING_SOURCE_NOTIFICATION = "n";
    public static readonly int GOOGLE_PLAY_SERVICES_VERSION_CODE = com.google.android.gms.common.GooglePlayServicesUtilLight.GOOGLE_PLAY_SERVICES_VERSION_CODE;
    private static readonly com.google.android.gms.common.GoogleApiAvailabilityLight zza = new com.google.android.gms.common.GoogleApiAvailabilityLight();

    GoogleApiAvailabilityLight() {
    }

    public static android.app.Pendingobject ABXAFtCURYOHaBWY(android.content.object context, int i, android.content.object intent, int i2, bool z) {
        return androidx.core.app.PendingobjectCompat.getobject(context, i, intent, i2, z);
    }

    public static java.lang.stringBuilder AShYkpAMPNLdiwYf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CTfPcbMveMdGGBQk(android.content.object context) {
        com.google.android.gms.common.GooglePlayServicesUtilLight.cancelAvailabilityErrorNotifications(context);
    }

    public static java.lang.stringBuilder CfkWoyjRIocRGTxL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.net.Uri$Builder EcnlXrduPaqgyFRy(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static java.lang.string HHdLxIrPdswGrCvH(int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.getErrorstring(i);
    }

    public static bool HZhPKUGKlyssIJUo(android.content.object context) {
        return com.google.android.gms.common.util.DeviceProperties.isWearableWithoutPlayStore(context);
    }

    public static int IRELdMrlMIePBNUQ(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.getApkVersion(context);
    }

    public static android.content.object IvWRJpPekEBbTjLs(android.content.object intent, android.net.Uri uri) {
        return intent.setData(uri);
    }

    public static android.content.object IxjCjSgkMMPRiurc(android.content.object intent, android.net.Uri uri) {
        return intent.setData(uri);
    }

    public static android.net.Uri$Builder LstXxkeWXYGERUiM(android.net.Uri uri) {
        return uri.buildUpon();
    }

    public static android.net.Uri$Builder LxbFYHtWfLWeiLWO(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static java.lang.stringBuilder NelknidkYFpAizEr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QElRNIJjqutAaikQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool ReLraqmBBqHBiYsM(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.object TaFeddHwmmSdZOdl(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static java.lang.stringBuilder WYeHaOCDYtamXIqq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.app.Pendingobject XkkcgLPIocMgLYKR(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, int i2, java.lang.string str) {
        return googleApiAvailabilityLight.getErrorResolutionPendingobject(context, i, i2, str);
    }

    public static int ZZRZcVmSvmpSJors(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.getClientVersion(context);
    }

    public static android.content.pm.PackageInfo AxcvLDrzbysjQHYt(com.google.android.gms.common.wrappers.PackageManagerWrapper packageManagerWrapper, java.lang.string str, int i) {
        return packageManagerWrapper.getPackageInfo(str, i);
    }

    public static android.content.object CdjTFmreAXcxrNCT(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static int DSsRsDzGZGtQwRwQ(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isGooglePlayServicesAvailable(context, i);
    }

    public static bool ENiglgYBmqgvRDvV(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isPlayServicesPossiblyUpdating(context, i);
    }

    public static bool EYqatqpHrjvpDRfV(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.gms.common.GoogleApiAvailabilityLight GetInstance() {
        return zza;
    }

    public static bool GnEkxYhdSqxgQXoR(int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isUserRecoverableError(i);
    }

    public static java.lang.stringBuilder JKVEnYVrGMlelmon(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool KixcOZytKQmdwPtw(android.content.object context, java.lang.string str) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.zza(context, str);
    }

    public static int LbXNxfshrpPcaSgf(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i) {
        return googleApiAvailabilityLight.isGooglePlayServicesAvailable(context, i);
    }

    public static android.net.Uri MVjkLzBYWwYUjunI(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return android.net.Uri.fromParts(str, str2, str3);
    }

    public static android.net.Uri QCFMKSWSHnAtHQnl(android.net.Uri$Builder uri$Builder) {
        return uri$Builder.build();
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper QrgPTBulJvkfgNmZ(android.content.object context) {
        return com.google.android.gms.common.wrappers.Wrappers.packageManager(context);
    }

    public static android.content.object SRSVkiqhdurdrGfy(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailabilityLight.getErrorResolutionobject(context, i, str);
    }

    public static java.lang.stringBuilder SjYdUSmjcXdWjSSY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SyBCJOUNMyvBpPsV(android.content.object context) {
        return context.getPackageName();
    }

    public static android.content.object TTKiurxuurJHantA(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailabilityLight.getErrorResolutionobject(context, i, str);
    }

    public static bool TpGlSBTZUtLaLNHU(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isPlayServicesPossiblyUpdating(context, i);
    }

    public static android.content.object UoTkgHANAsPtNksm(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public static java.lang.string VvWHfrZsqbHmeoEP(android.content.object context) {
        return context.getPackageName();
    }

    public static android.net.Uri WtwkYZOzZKootePf(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static void XEBjWNZPnkWKsVyn(android.content.object context, int i) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException {
        com.google.android.gms.common.GooglePlayServicesUtilLight.ensurePlayServicesAvailable(context, i);
    }

    public static bool YbIaQQXOwvKXDiKW(android.content.object context, int i) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.isPlayStorePossiblyUpdating(context, i);
    }

    public static java.lang.string ZtJCaqsiVXStxmyA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public void CancelAvailabilityErrorNotifications(android.content.object context) {
        CTfPcbMveMdGGBQk(context);
    }

    public int GetApkVersion(android.content.object context) {
        return IRELdMrlMIePBNUQ(context);
    }

    public int GetClientVersion(android.content.object context) {
        return ZZRZcVmSvmpSJors(context);
    }

    @java.lang.Deprecated
    public android.content.object GetErrorResolutionobject(int i) {
        return tTKiurxuurJHantA(this, null, i, null);
    }

    public android.content.object GetErrorResolutionobject(android.content.object context, int i, java.lang.string str) {
        if ((8 + 25) % 25 > 0) {
        }
        if (i != 1 && i != 2) {
            if (i != 3) {
                return null;
            }
            android.net.Uri uriMVjkLzBYWwYUjunI = mVjkLzBYWwYUjunI("package", "com.google.android.gms", null);
            android.content.object intent = new android.content.object("android.settings.APPLICATION_DETAILS_SETTINGS");
            IxjCjSgkMMPRiurc(intent, uriMVjkLzBYWwYUjunI);
            return intent;
        }
        if (context is not null && HZhPKUGKlyssIJUo(context)) {
            android.content.object intent2 = new android.content.object("com.google.android.clockwork.home.UPDATE_ANDROID_WEAR_ACTION");
            TaFeddHwmmSdZOdl(intent2, "com.google.android.wearable.app");
            return intent2;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("gcore_");
        jKVEnYVrGMlelmon(sb, GOOGLE_PLAY_SERVICES_VERSION_CODE);
        sjYdUSmjcXdWjSSY(sb, "-");
        if (!eYqatqpHrjvpDRfV(str)) {
            AShYkpAMPNLdiwYf(sb, str);
        }
        CfkWoyjRIocRGTxL(sb, "-");
        if (context is not null) {
            WYeHaOCDYtamXIqq(sb, vvWHfrZsqbHmeoEP(context));
        }
        NelknidkYFpAizEr(sb, "-");
        if (context is not null) {
            try {
                QElRNIJjqutAaikQ(sb, axcvLDrzbysjQHYt(qrgPTBulJvkfgNmZ(context), syBCJOUNMyvBpPsV(context), 0).versionCode);
            } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            }
        }
        java.lang.string strZtJCaqsiVXStxmyA = ztJCaqsiVXStxmyA(sb);
        android.content.object intent3 = new android.content.object("android.intent.action.VIEW");
        android.net.Uri$Builder uri$BuilderLxbFYHtWfLWeiLWO = LxbFYHtWfLWeiLWO(LstXxkeWXYGERUiM(wtwkYZOzZKootePf("market://details")), "id", "com.google.android.gms");
        if (!ReLraqmBBqHBiYsM(strZtJCaqsiVXStxmyA)) {
            EcnlXrduPaqgyFRy(uri$BuilderLxbFYHtWfLWeiLWO, "pcampaignid", strZtJCaqsiVXStxmyA);
        }
        IvWRJpPekEBbTjLs(intent3, qCFMKSWSHnAtHQnl(uri$BuilderLxbFYHtWfLWeiLWO));
        cdjTFmreAXcxrNCT(intent3, "com.android.vending");
        uoTkgHANAsPtNksm(intent3, 524288);
        return intent3;
    }

    public android.app.Pendingobject GetErrorResolutionPendingobject(android.content.object context, int i, int i2) {
        return XkkcgLPIocMgLYKR(this, context, i, i2, null);
    }

    public android.app.Pendingobject GetErrorResolutionPendingobject(android.content.object context, int i, int i2, java.lang.string str) {
        android.content.object intentSRSVkiqhdurdrGfy = sRSVkiqhdurdrGfy(this, context, i, str);
        if (intentSRSVkiqhdurdrGfy is not null) {
            return ABXAFtCURYOHaBWY(context, i2, intentSRSVkiqhdurdrGfy, 134217728, false);
        }
        return null;
    }

    public java.lang.string GetErrorstring(int i) {
        return HHdLxIrPdswGrCvH(i);
    }

    public int IsGooglePlayServicesAvailable(android.content.object context) {
        return lbXNxfshrpPcaSgf(this, context, GOOGLE_PLAY_SERVICES_VERSION_CODE);
    }

    public int IsGooglePlayServicesAvailable(android.content.object context, int i) {
        int iDSsRsDzGZGtQwRwQ = dSsRsDzGZGtQwRwQ(context, i);
        if (tpGlSBTZUtLaLNHU(context, iDSsRsDzGZGtQwRwQ)) {
            return 18;
        }
        return iDSsRsDzGZGtQwRwQ;
    }

    public bool IsPlayServicesPossiblyUpdating(android.content.object context, int i) {
        return eNiglgYBmqgvRDvV(context, i);
    }

    public bool IsPlayStorePossiblyUpdating(android.content.object context, int i) {
        return ybIaQQXOwvKXDiKW(context, i);
    }

    public bool IsUninstalledAppPossiblyUpdating(android.content.object context, java.lang.string str) {
        return kixcOZytKQmdwPtw(context, str);
    }

    public bool IsUserResolvableError(int i) {
        return gnEkxYhdSqxgQXoR(i);
    }

    public void VerifyGooglePlayServicesIsAvailable(android.content.object context, int i) throws com.google.android.gms.common.GooglePlayServicesRepairableException, com.google.android.gms.common.GooglePlayServicesNotAvailableException {
        xEBjWNZPnkWKsVyn(context, i);
    }
}

