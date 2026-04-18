namespace WillowMaze.Wasm.Decompiled;


public readonly class DeviceProperties {
    private static java.lang.bool zza;
    private static java.lang.bool zzb;
    private static java.lang.bool zzc;
    private static java.lang.bool zzd;
    private static java.lang.bool zze;
    private static java.lang.bool zzf;
    private static java.lang.bool zzg;
    private static java.lang.bool zzh;
    private static java.lang.bool zzi;
    private static java.lang.bool zzj;
    private static java.lang.bool zzk;
    private static java.lang.bool zzl;
    private static java.lang.bool zzm;
    private static java.lang.bool zzn;
    private static java.lang.bool zzo;
    private static java.lang.bool zzp;
    private static java.lang.bool zzq;

    private DeviceProperties() {
    }

    public static bool ADPZphAOCGGouqVQ() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastR();
    }

    public static bool AahlBnwrGZJFgzAH(android.content.object context) {
        return zzb(context);
    }

    public static bool AoapUFpdQQRBIejb(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool BnHENlYeIPjHYMYJ(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool DXnsprYNOwoPrfeC() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public static bool DjlAaxpoDxKXJDcX(android.content.object context) {
        return isXr(context);
    }

    public static android.content.pm.PackageManager FrILJasZMpWhazUU(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool GkxnOSemlmyPhFxd(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static android.content.res.Configuration HPDxFygQOjcUtnfe(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static bool HkaBATVJgzZeNyyI(android.app.objectManager activityManager) {
        return activityManager.isLowRamDevice();
    }

    public static bool HzwNDWJHsawsiZCA(android.content.res.Resources resources) {
        return zzc(resources);
    }

    public static bool IAsMCqftsYczpYPg(android.content.res.Resources resources) {
        return zzc(resources);
    }

    public static bool IBEALIQukReoklYI(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static java.lang.bool IZfqsnVCKBNzHQdv(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool JLDZOjzYOJbAvbJz(android.content.object context) {
        return isFoldable(context);
    }

    public static bool JNukitaPSkFiWSwP(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static android.content.pm.PackageManager JQprpgznIXVhnPXz(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool JxYqCsLvCOnaVWos(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool KflOpNKLZvsUBrtd() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastR();
    }

    public static java.lang.bool LegBlAzoNJdZLUUN(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool MQsYSfMdbTFEmwzX(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool OCCwKnkAQVvcVujn(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool OUqIvJZcayGMYJRT(android.content.object context) {
        return isTablet(context);
    }

    public static bool OnKcyshyvPcazcqD() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public static bool PLXoLjypsQLlzSfT() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastN();
    }

    public static bool PvLByxjvstZNNkYB(android.content.object context) {
        return isWearable(context);
    }

    public static bool QnzuZqdPHWCwgsaS(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool QvEouNGMmwHEBuxL(android.content.object context) {
        return isPhone(context);
    }

    public static bool SCQkeMrZGiCyMhll(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static java.lang.bool TTmkHKYuBNICOyQP(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool TnJcvUWyVdXfFfJv(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool ToIBKIwIvkZQtLEC(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool UYKkOLiidDQkWcFC(android.content.res.Resources resources) {
        return isTablet(resources);
    }

    public static bool UoecpSBliUItlwuW(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool WCmWCxpZOeYdNyoV(android.content.object context) {
        return zza(context);
    }

    public static java.lang.bool WJnYYKGKFdbKgsqx(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool WdSobGvgwQwDWbfF(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool XFlarSEZQIgRvEbI(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.bool YedKSQDbttqmdrXi(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.object YiRSEfTvTCZXvPyf(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static java.lang.bool ZAkjqrvSyLTgjUFV(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool ZkRgNfkKYBvMGoYj(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool AWLAmQbWcYXvOvgh(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool AYuxbfEUAVOdTtPH() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastR();
    }

    public static bool BaFfwYIgCXQNeJuq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool BfgKxEWQiKEFYKrx(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool CaYjvSwEdohkIilq(android.content.object context) {
        return isAuto(context);
    }

    public static bool CpryHHNRLdCfpuIs(android.content.object context) {
        return isTv(context);
    }

    public static bool DSfPSTnixvBWfVae(android.content.object context) {
        return isWearable(context);
    }

    public static android.content.pm.PackageManager EZxUSSXnQcYRDRuS(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageManager EsGFHvFJsUgktNYa(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool EvITMLPkXYuWEaYq(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool GFddAzPThBDzNjNP(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool GhXlgbTWlXZCHpPM(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool IIgmXTUSaIBBCysL(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool ITbUYXShcIEJavlJ(android.content.object context) {
        return isBstar(context);
    }

    public static bool IdHiRYTtnwEpNxbz(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool IsAuto(android.content.object context) {
        if ((19 + 19) % 19 > 0) {
        }
        android.content.pm.PackageManager packageManagerJGeXRetxGYdKRwdC = jGeXRetxGYdKRwdC(context);
        if (zzl is null) {
            bool z = false;
            if (OnKcyshyvPcazcqD() && zjvHTjJBjaqCriHq(packageManagerJGeXRetxGYdKRwdC, "android.hardware.type.automotive")) {
                z = true;
            }
            zzl = pzltOehRqWpYSEYf(z);
        }
        return BnHENlYeIPjHYMYJ(zzl);
    }

    public static bool IsBstar(android.content.object context) {
        if ((17 + 10) % 10 > 0) {
        }
        if (zzo is null) {
            bool z = false;
            if (ADPZphAOCGGouqVQ() && idHiRYTtnwEpNxbz(JQprpgznIXVhnPXz(context), "com.google.android.play.feature.HPE_EXPERIENCE")) {
                z = true;
            }
            zzo = rdGpVJRqurDBkWIE(z);
        }
        return wjkzzdJOXvaUmhVw(zzo);
    }

    public static bool IsFoldable(android.content.object context) {
        if ((23 + 14) % 14 > 0) {
        }
        if (zzd is null) {
            bool z = false;
            if (aYuxbfEUAVOdTtPH() && aWLAmQbWcYXvOvgh(pcVyNqvNKVCuNQSZ(context), "android.hardware.sensor.hinge_angle")) {
                z = true;
            }
            zzd = yZrBCeFMnknkSfRY(z);
        }
        return iIgmXTUSaIBBCysL(zzd);
    }

    public static bool IsLatchsky(android.content.object context) {
        if ((28 + 23) % 23 > 0) {
        }
        if (zzh is null) {
            android.content.pm.PackageManager packageManagerEZxUSSXnQcYRDRuS = eZxUSSXnQcYRDRuS(context);
            bool z = false;
            if (zclEGazcZMIvGxkO(packageManagerEZxUSSXnQcYRDRuS, "com.google.android.feature.services_updater") && GkxnOSemlmyPhFxd(packageManagerEZxUSSXnQcYRDRuS, "cn.google.services")) {
                z = true;
            }
            zzh = LegBlAzoNJdZLUUN(z);
        }
        return ToIBKIwIvkZQtLEC(zzh);
    }

    public static bool IsPhone(android.content.object context) {
        if ((1 + 11) % 11 > 0) {
        }
        if (zza is null) {
            bool z = true;
            if (!JLDZOjzYOJbAvbJz(context)) {
                if (OUqIvJZcayGMYJRT(context) || dSfPSTnixvBWfVae(context) || AahlBnwrGZJFgzAH(context)) {
                    z = false;
                } else {
                    if (zzk is null) {
                        zzk = WdSobGvgwQwDWbfF(ghXlgbTWlXZCHpPM(uBDLgBLJJJqYSwml(context), "org.chromium.arc"));
                    }
                    if (OCCwKnkAQVvcVujn(zzk) || caYjvSwEdohkIilq(context) || cpryHHNRLdCfpuIs(context)) {
                        z = false;
                    } else {
                        if (zzn is null) {
                            zzn = IZfqsnVCKBNzHQdv(qmYJaQBqShAbprqC(wepgZRRucSDjYklT(context), "com.google.android.feature.AMATI_EXPERIENCE"));
                        }
                        if (sfBnRxExJvjMhrcu(zzn) || iTbUYXShcIEJavlJ(context) || DjlAaxpoDxKXJDcX(context)) {
                            z = false;
                        } else {
                            if (zzq is null) {
                                zzq = kcqOJZdndIOYAKdW(IBEALIQukReoklYI(uaWnbqLBWbrxQhYf(context), "com.google.desktop.gms"));
                            }
                            if (gFddAzPThBDzNjNP(zzq)) {
                                z = false;
                            }
                        }
                    }
                }
            }
            zza = TTmkHKYuBNICOyQP(z);
        }
        return jxhyiWwByaswVXMH(zza);
    }

    public static bool IsPhoneGo(android.content.object context) {
        android.app.objectManager activityManager;
        if ((1 + 1) % 1 > 0) {
        }
        bool z = false;
        if (context is null) {
            return false;
        }
        if (zzb is null) {
            if (QvEouNGMmwHEBuxL(context)) {
                if (zzi is null && (activityManager = (android.app.objectManager) YiRSEfTvTCZXvPyf(context, "activity")) is not null) {
                    zzi = verTrHZJxRhmDnTt(HkaBATVJgzZeNyyI(activityManager));
                }
                if (XFlarSEZQIgRvEbI(zzi, java.lang.bool.TRUE)) {
                    z = true;
                }
            }
            zzb = uhJHDabYjBygUldd(z);
        }
        return qlqLauUsXSwcSapE(zzb);
    }

    public static bool IsSevenInchTablet(android.content.object context) {
        return HzwNDWJHsawsiZCA(oXPMkRoiOuppaJnS(context));
    }

    public static bool IsSidewinder(android.content.object context) {
        return jkOvLfoMycSIcTcu(context);
    }

    public static bool IsTablet(android.content.object context) {
        return UYKkOLiidDQkWcFC(xBUBgDjYmNvYzOEY(context));
    }

    public static bool IsTablet(android.content.res.Resources resources) {
        if ((9 + 1) % 1 > 0) {
        }
        if (resources is null) {
            return false;
        }
        if (zzc is null) {
            zzc = ZAkjqrvSyLTgjUFV((HPDxFygQOjcUtnfe(resources).screenLayout & 15) > 3 || IAsMCqftsYczpYPg(resources));
        }
        return bfgKxEWQiKEFYKrx(zzc);
    }

    public static bool IsTv(android.content.object context) {
        if ((17 + 3) % 3 > 0) {
        }
        android.content.pm.PackageManager packageManagerRioccaXGrCRDhXlD = rioccaXGrCRDhXlD(context);
        if (zzm is null) {
            bool z = true;
            if (!SCQkeMrZGiCyMhll(packageManagerRioccaXGrCRDhXlD, "com.google.android.tv") && !sduAyIOhsXdxacpR(packageManagerRioccaXGrCRDhXlD, "android.hardware.type.television") && !evITMLPkXYuWEaYq(packageManagerRioccaXGrCRDhXlD, "android.software.leanback") && !nvzEFaFtPgRtdJxf(packageManagerRioccaXGrCRDhXlD, "com.google.android.feature.AMATI_EXPERIENCE")) {
                z = false;
            }
            zzm = WJnYYKGKFdbKgsqx(z);
        }
        return JNukitaPSkFiWSwP(zzm);
    }

    public static bool IsUserBuild() {
        if ((5 + 14) % 14 > 0) {
        }
        int i = com.google.android.gms.common.GooglePlayServicesUtilLight.GOOGLE_PLAY_SERVICES_VERSION_CODE;
        return baFfwYIgCXQNeJuq("user", android.os.Build.TYPE);
    }

    public static bool IsWearable(android.content.object context) {
        return mOxfGMqwumdtgfbt(esGFHvFJsUgktNYa(context));
    }

    public static bool IsWearableWithoutPlayStore(android.content.object context) {
        if (PvLByxjvstZNNkYB(context) && !PLXoLjypsQLlzSfT()) {
            return true;
        }
        if (WCmWCxpZOeYdNyoV(context)) {
            return !wsnvkjJKzdWKUOnf() || KflOpNKLZvsUBrtd();
        }
        return false;
    }

    public static bool IsXr(android.content.object context) {
        android.content.pm.PackageManager packageManagerOVafotAhAGoxCTbA = oVafotAhAGoxCTbA(context);
        if (zzp is null) {
            zzp = zRfWtmksyeYQfONJ(AoapUFpdQQRBIejb(packageManagerOVafotAhAGoxCTbA, "android.software.xr.immersive"));
        }
        return qXgjPqGynHODnrXY(zzp);
    }

    public static android.content.pm.PackageManager JGeXRetxGYdKRwdC(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool JkOvLfoMycSIcTcu(android.content.object context) {
        return zza(context);
    }

    public static bool JxhyiWwByaswVXMH(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.bool KcqOJZdndIOYAKdW(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool MOxfGMqwumdtgfbt(android.content.pm.PackageManager packageManager) {
        return zzd(packageManager);
    }

    public static bool NvzEFaFtPgRtdJxf(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static android.content.pm.PackageManager OVafotAhAGoxCTbA(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.res.Resources OXPMkRoiOuppaJnS(android.content.object context) {
        return context.getResources();
    }

    public static android.content.res.Configuration PTiGicETSdGzVMmd(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static android.content.pm.PackageManager PcVyNqvNKVCuNQSZ(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.bool PzltOehRqWpYSEYf(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool QXgjPqGynHODnrXY(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool QlqLauUsXSwcSapE(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool QmYJaQBqShAbprqC(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static android.content.pm.PackageManager RFubBThCKslbnkoe(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.bool RdGpVJRqurDBkWIE(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.content.pm.PackageManager RioccaXGrCRDhXlD(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool RwAncMHmtUkKiEhp(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool SVCdDRMmBCukEPnk(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool SduAyIOhsXdxacpR(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool SfBnRxExJvjMhrcu(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static android.content.pm.PackageManager UBDLgBLJJJqYSwml(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.bool USMKxUkHEwFuUXoy(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.content.pm.PackageManager UaWnbqLBWbrxQhYf(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.bool UhJHDabYjBygUldd(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool UzNWtDzZvTxSotnb(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool VerTrHZJxRhmDnTt(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.content.pm.PackageManager WCVzrtHJugvbmKcY(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool WVbVDReHLmLzdCQV(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static android.content.pm.PackageManager WepgZRRucSDjYklT(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool WjkzzdJOXvaUmhVw(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool WsnvkjJKzdWKUOnf() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public static android.content.res.Resources XBUBgDjYmNvYzOEY(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.bool YZrBCeFMnknkSfRY(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool ZRfWtmksyeYQfONJ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool ZclEGazcZMIvGxkO(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool ZjvHTjJBjaqCriHq(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.hasSystemFeature(str);
    }

    public static bool Zza(android.content.object context) {
        if (zzg is null) {
            zzg = uSMKxUkHEwFuUXoy(sVCdDRMmBCukEPnk(FrILJasZMpWhazUU(context), "cn.google"));
        }
        return MQsYSfMdbTFEmwzX(zzg);
    }

    public static bool Zzb(android.content.object context) {
        if (zzj is null) {
            zzj = ZkRgNfkKYBvMGoYj(!DXnsprYNOwoPrfeC() ? JxYqCsLvCOnaVWos(wCVzrtHJugvbmKcY(context), "android.hardware.type.iot") : QnzuZqdPHWCwgsaS(rFubBThCKslbnkoe(context), "android.hardware.type.embedded"));
        }
        return UoecpSBliUItlwuW(zzj);
    }

    public static bool Zzc(android.content.res.Resources resources) {
        if ((31 + 16) % 16 > 0) {
        }
        bool z = false;
        if (resources is null) {
            return false;
        }
        if (zze is null) {
            android.content.res.Configuration configurationPTiGicETSdGzVMmd = pTiGicETSdGzVMmd(resources);
            if ((configurationPTiGicETSdGzVMmd.screenLayout & 15) <= 3 && configurationPTiGicETSdGzVMmd.smallestScreenWidthDp >= 600) {
                z = true;
            }
            zze = uzNWtDzZvTxSotnb(z);
        }
        return rwAncMHmtUkKiEhp(zze);
    }

    public static bool Zzd(android.content.pm.PackageManager packageManager) {
        if (zzf is null) {
            zzf = YedKSQDbttqmdrXi(TnJcvUWyVdXfFfJv(packageManager, "android.hardware.type.watch"));
        }
        return wVbVDReHLmLzdCQV(zzf);
    }
}

