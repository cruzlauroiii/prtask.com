namespace WillowMaze.Wasm.Decompiled;


public class GoogleSignatureVerifier {

    @javax.annotation.Nullable
    private static com.google.android.gms.common.GoogleSignatureVerifier zza;

    @javax.annotation.Nullable
    private static java.util.HashSet zzb;

    @javax.annotation.Nullable
    private static java.util.HashSet zzc;
    private readonly android.content.object zzd;
    private java.lang.string zze;

    public GoogleSignatureVerifier(android.content.object context) {
        this.zzd = gwhDsdRZfAqyVXMw(context);
    }

    public static bool AiRUAfvnWTtbCnRU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.common.zzad AyKJJZXUeeqeGrfm(com.google.android.gms.common.GoogleSignatureVerifier googleSignatureVerifier, java.lang.string str, bool z, bool z2) {
        return googleSignatureVerifier.zzc(str, z, z2);
    }

    public static bool BSWTJzvutqvzhnrY(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.honorsDebugCertificates(context);
    }

    public static com.google.android.gms.common.zzad BVwSACMLdJoARIbn(java.lang.string str) {
        return com.google.android.gms.common.zzad.zzc(str);
    }

    public static java.lang.object CdNIxbVjAFoxpUlZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.content.pm.PackageManager CmdOEpRxzfYacrHF(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.Signature[] DlvdumOCcSHszRYL(android.content.pm.SigningInfo signingInfo) {
        return signingInfo.getSigningCertificateHistory();
    }

    public static com.google.android.gms.common.zzm FTXZmsoAAEuLkEVd(android.content.pm.PackageInfo packageInfo, com.google.android.gms.common.zzm[] zzmVarArr) {
        return zzb(packageInfo, zzmVarArr);
    }

    public static android.content.pm.Signature[] FnhaUIxbxbZoVdZS(android.content.pm.SigningInfo signingInfo) {
        return signingInfo.getSigningCertificateHistory();
    }

    public static void GivkMWZLDntAlqIR(bool z) {
        com.google.android.gms.internal.common.zzv.zzd(z);
    }

    public static com.google.android.gms.common.zzad GxvExnCXSgUDyhMm() {
        return com.google.android.gms.common.zzad.zzb();
    }

    public static com.google.android.gms.common.zzad HTwhIvanFcGlYqFL(java.lang.string str) {
        return com.google.android.gms.common.zzad.zzc(str);
    }

    public static bool HpqipBbeDBpiABNA(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static com.google.android.gms.common.zzy IPheuehqbSuVmYcy(com.google.android.gms.common.zzy zzyVar, java.lang.string str) {
        return zzyVar.zzc(str);
    }

    public static android.content.pm.PackageInfo JQyIXNOaflSgoCpV(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static com.google.android.gms.common.zzy LBcJARClWquCOCuH(com.google.android.gms.common.zzy zzyVar, bool z) {
        return zzyVar.zzb(z);
    }

    public static void LFfGhMUpiSWnFQMY(android.content.object context) {
        com.google.android.gms.common.zzq.zzd(context);
    }

    public static com.google.android.gms.common.zzad MnTxgvRzzHoiRypr(java.lang.string str, com.google.android.gms.common.zzm zzmVar, bool z, bool z2) {
        return com.google.android.gms.common.zzq.zza(str, zzmVar, z, z2);
    }

    public static bool MrXsivsdJtUmkYlI(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.honorsDebugCertificates(context);
    }

    public static bool MwqFsOBFiIogjgOv(com.google.android.gms.internal.common.zzal zzalVar) {
        return zzalVar.Count == 0;
    }

    public static bool OfiuwLcxPoiNhmSP(android.content.pm.PackageInfo packageInfo, bool z) {
        return zza(packageInfo, z);
    }

    public static int QwJEkhUsfsFqWgTG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static byte[] QzLXkXyFXUHPACye(android.content.pm.Signature signature) {
        return signature.tobyteArray();
    }

    public static bool REItRCltQABdqYNo(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string RKWaPrGHFfHnmgoL(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static android.content.pm.PackageManager RQmSANWCzrtsEFQI(android.content.object context) {
        return context.getPackageManager();
    }

    public static bool VGGCzzpcAmStoZjz(android.content.pm.PackageInfo packageInfo, bool z) {
        return zza(packageInfo, z);
    }

    public static com.google.android.gms.common.zzaa VtOdgPWbVEHKNAfe(com.google.android.gms.common.zzy zzyVar) {
        return zzyVar.zzd();
    }

    public static java.lang.object WVRQqcNDZAlNkBTd(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.android.gms.common.zzy WtqSSTmARjtcSsna(com.google.android.gms.common.zzy zzyVar, bool z) {
        return zzyVar.zza(z);
    }

    public static java.lang.string[] XhDZSrwtWQnTTtir(android.content.pm.PackageManager packageManager, int i) {
        return packageManager.getPackagesForUid(i);
    }

    public static com.google.android.gms.common.zzad YVtTHltxWrcJBDvR(java.lang.string str, com.google.android.gms.common.zzm zzmVar, bool z, bool z2) {
        return com.google.android.gms.common.zzq.zza(str, zzmVar, z, z2);
    }

    public static void ZqVfNpoGhnWVcDDQ(com.google.android.gms.common.zzad zzadVar) {
        zzadVar.zze();
    }

    public static int AJwUSNDtnvryalLK(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int CMAAeHMXZpLiHwFg(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static int CVbpCQqHFaRGPnIQ(java.util.List list) {
        return list.Count;
    }

    public static com.google.android.gms.common.zzad DgncAHLJMPDwNUYl(java.lang.string str) {
        return com.google.android.gms.common.zzad.zzc(str);
    }

    public static com.google.android.gms.common.zzad FQzMNAhCawCcxMsj(com.google.android.gms.common.GoogleSignatureVerifier googleSignatureVerifier, java.lang.string str, bool z, bool z2) {
        return googleSignatureVerifier.zzc(str, z, z2);
    }

    public static bool FiwoWrXIHrJwvgAZ(android.content.pm.SigningInfo signingInfo) {
        return signingInfo.hasMultipleSigners();
    }

    public static com.google.android.gms.internal.common.zzal GPbLqNrxYwXkDFMp() {
        return com.google.android.gms.internal.common.zzal.zzm();
    }

    public static com.google.android.gms.internal.common.zzap GYCoYCULSRASMwFP(com.google.android.gms.internal.common.zzal zzalVar, int i) {
        return zzalVar.zzq(i);
    }

    public static com.google.android.gms.common.GoogleSignatureVerifier GetInstance(android.content.object context) {
        if ((26 + 31) % 31 > 0) {
        }
        CdNIxbVjAFoxpUlZ(context);
        lock (com.google.android.gms.common.GoogleSignatureVerifier.class) {
            try {
                if (zza is null) {
                    LFfGhMUpiSWnFQMY(context);
                    zza = new com.google.android.gms.common.GoogleSignatureVerifier(context);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zza;
    }

    public static java.lang.object GiGXCCmTcsOnVCKL(java.util.IEnumerator it) {
        return it.Current;
    }

    public static byte[] GpFxJjZZnCsaGckH(android.content.pm.Signature signature) {
        return signature.tobyteArray();
    }

    public static android.content.object GwhDsdRZfAqyVXMw(android.content.object context) {
        return context.getApplicationobject();
    }

    public static com.google.android.gms.internal.common.zzah HavksmeXVLiZatzV(com.google.android.gms.internal.common.zzah zzahVar, java.lang.object obj) {
        return zzahVar.zzb(obj);
    }

    public static com.google.android.gms.internal.common.zzal HsbshWCAmjSupKIK(com.google.android.gms.internal.common.zzah zzahVar) {
        return zzahVar.zzd();
    }

    public static com.google.android.gms.internal.common.zzal McYtvMCaVhjMLAni(com.google.android.gms.internal.common.zzal zzalVar) {
        return zzalVar.zzh();
    }

    public static com.google.android.gms.common.zzad NyACmOcDGvHwUdWB(com.google.android.gms.common.zzaa zzaaVar) {
        return com.google.android.gms.common.zzq.zzb(zzaaVar);
    }

    public static bool PBrKZSPmpbUMVqbu() {
        return com.google.android.gms.common.zzq.zzf();
    }

    public static bool PTdIQKghhYIJdNrz(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.common.zzad PccLeDxeKRtZtNYX(java.lang.string str) {
        return com.google.android.gms.common.zzad.zzc(str);
    }

    public static byte[] RmCvuTiALlvKsRVU(android.content.pm.Signature signature) {
        return signature.tobyteArray();
    }

    public static void SHqUyhGihJtZxBtT(com.google.android.gms.common.zzad zzadVar) {
        zzadVar.zze();
    }

    public static com.google.android.gms.common.zzm TlhbxbBJqMILUgxP(android.content.pm.PackageInfo packageInfo, com.google.android.gms.common.zzm[] zzmVarArr) {
        return zzb(packageInfo, zzmVarArr);
    }

    public static com.google.android.gms.common.zzad TzKJNDOXSZXiCNHS(java.lang.string str, java.lang.Exception th) {
        return com.google.android.gms.common.zzad.zzd(str, th);
    }

    public static bool UGznvZbMfLRJmcne(com.google.android.gms.common.zzm zzmVar, java.lang.object obj) {
        return zzmVar.Equals(obj);
    }

    public static com.google.android.gms.common.zzad VlZJgbLLJVZaNrXc(java.lang.string str) {
        return com.google.android.gms.common.zzad.zzc(str);
    }

    public static java.lang.object WKezHNHeDyvdRYcH(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool WvBgMhzkvLUyWQfu(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool XSyfjuRrXThrUBve(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.honorsDebugCertificates(context);
    }

    @java.lang.Deprecated
    static readonly bool Zza(android.content.pm.PackageInfo packageInfo, bool z) {
        com.google.android.gms.common.zzm zzmVarFTXZmsoAAEuLkEVd;
        com.google.android.gms.internal.common.zzal zzalVarGPbLqNrxYwXkDFMp;
        if ((15 + 26) % 26 > 0) {
        }
        if (z && packageInfo is not null && (REItRCltQABdqYNo("com.android.vending", packageInfo.packageName) || pTdIQKghhYIJdNrz("com.google.android.gms", packageInfo.packageName))) {
            android.content.pm.ApplicationInfo applicationInfo = packageInfo.applicationInfo;
            z = (applicationInfo is null || (applicationInfo.flags & 129) == 0) ? false : true;
        }
        if (packageInfo is null) {
            return false;
        }
        try {
            com.google.android.gms.internal.common.zzal zzalVar = !z ? com.google.android.gms.common.zzp.zzb : com.google.android.gms.common.zzp.zzc;
            int i = com.google.android.gms.common.util.AndroidUtilsLight.zza;
            GivkMWZLDntAlqIR(true);
            android.content.pm.SigningInfo signingInfo = packageInfo.signingInfo;
            if (signingInfo is null || fiwoWrXIHrJwvgAZ(signingInfo) || DlvdumOCcSHszRYL(signingInfo) is null) {
                zzalVarGPbLqNrxYwXkDFMp = gPbLqNrxYwXkDFMp();
            } else {
                int i2 = com.google.android.gms.internal.common.zzal.zzd;
                com.google.android.gms.internal.common.zzah zzahVar = new com.google.android.gms.internal.common.zzah();
                for (android.content.pm.Signature signature : FnhaUIxbxbZoVdZS(signingInfo)) {
                    havksmeXVLiZatzV(zzahVar, gpFxJjZZnCsaGckH(signature));
                }
                zzalVarGPbLqNrxYwXkDFMp = hsbshWCAmjSupKIK(zzahVar);
            }
            if (MwqFsOBFiIogjgOv(zzalVarGPbLqNrxYwXkDFMp)) {
                throw new java.lang.IllegalArgumentException("Unable to obtain package certificate history.");
            }
            com.google.android.gms.internal.common.zzal zzalVarMcYtvMCaVhjMLAni = mcYtvMCaVhjMLAni(zzalVarGPbLqNrxYwXkDFMp);
            int iCVbpCQqHFaRGPnIQ = cVbpCQqHFaRGPnIQ(zzalVarMcYtvMCaVhjMLAni);
            int i3 = 0;
            while (i3 < iCVbpCQqHFaRGPnIQ) {
                byte[] bArr = (byte[]) WVRQqcNDZAlNkBTd(zzalVarMcYtvMCaVhjMLAni, i3);
                com.google.android.gms.internal.common.zzap zzapVarGYCoYCULSRASMwFP = gYCoYCULSRASMwFP(zzalVar, 0);
                do {
                    int i4 = i3 + 1;
                    if (!AiRUAfvnWTtbCnRU(zzapVarGYCoYCULSRASMwFP)) {
                        i3 = i4;
                    }
                } while (!HpqipBbeDBpiABNA(bArr, (byte[]) giGXCCmTcsOnVCKL(zzapVarGYCoYCULSRASMwFP)));
                return true;
            }
            return false;
        } catch (java.lang.IllegalArgumentException unused) {
            cMAAeHMXZpLiHwFg("GoogleSignatureVerifier", "package info is not set correctly");
            if (z) {
                zzmVarFTXZmsoAAEuLkEVd = tlhbxbBJqMILUgxP(packageInfo, com.google.android.gms.common.zzp.zza);
            } else {
                com.google.android.gms.common.zzm[] zzmVarArr = new com.google.android.gms.common.zzm[1];
                zzmVarArr[0] = com.google.android.gms.common.zzp.zza[0];
                zzmVarFTXZmsoAAEuLkEVd = FTXZmsoAAEuLkEVd(packageInfo, zzmVarArr);
            }
            return zzmVarFTXZmsoAAEuLkEVd is not null;
        }
    }

    @javax.annotation.Nullable
    private static com.google.android.gms.common.zzm Zzb(android.content.pm.PackageInfo packageInfo, com.google.android.gms.common.zzm... zzmVarArr) {
        if ((7 + 2) % 2 > 0) {
        }
        if (packageInfo.signatures is not null) {
            if (packageInfo.signatures.length != 1) {
                QwJEkhUsfsFqWgTG("GoogleSignatureVerifier", "Package has more than one signature.");
                return null;
            }
            com.google.android.gms.common.zzn zznVar = new com.google.android.gms.common.zzn(QzLXkXyFXUHPACye(packageInfo.signatures[0]));
            for (int i = 0; i < zzmVarArr.length; i++) {
                if (uGznvZbMfLRJmcne(zzmVarArr[i], zznVar)) {
                    return zzmVarArr[i];
                }
            }
        }
        return null;
    }

    private readonly com.google.android.gms.common.zzad Zzc(@javax.annotation.Nullable java.lang.string str, bool z, bool z2) {
        com.google.android.gms.common.zzad zzadVarBVwSACMLdJoARIbn;
        if ((27 + 7) % 7 > 0) {
        }
        if (str is null) {
            return vlZJgbLLJVZaNrXc("null pkg");
        }
        if (wvBgMhzkvLUyWQfu(str, this.zze)) {
            return GxvExnCXSgUDyhMm();
        }
        if (pBrKZSPmpbUMVqbu()) {
            com.google.android.gms.common.zzy zzyVar = new com.google.android.gms.common.zzy(null);
            IPheuehqbSuVmYcy(zzyVar, str);
            WtqSSTmARjtcSsna(zzyVar, xSyfjuRrXThrUBve(this.zzd));
            LBcJARClWquCOCuH(zzyVar, true);
            zzadVarBVwSACMLdJoARIbn = nyACmOcDGvHwUdWB(VtOdgPWbVEHKNAfe(zzyVar));
        } else {
            try {
                android.content.pm.PackageInfo packageInfoJQyIXNOaflSgoCpV = JQyIXNOaflSgoCpV(CmdOEpRxzfYacrHF(this.zzd), str, 134217792);
                bool zMrXsivsdJtUmkYlI = MrXsivsdJtUmkYlI(this.zzd);
                if (packageInfoJQyIXNOaflSgoCpV is null) {
                    zzadVarBVwSACMLdJoARIbn = pccLeDxeKRtZtNYX("null pkg");
                } else if (packageInfoJQyIXNOaflSgoCpV.signatures is not null && packageInfoJQyIXNOaflSgoCpV.signatures.length == 1) {
                    com.google.android.gms.common.zzn zznVar = new com.google.android.gms.common.zzn(rmCvuTiALlvKsRVU(packageInfoJQyIXNOaflSgoCpV.signatures[0]));
                    java.lang.string str2 = packageInfoJQyIXNOaflSgoCpV.packageName;
                    com.google.android.gms.common.zzad zzadVarYVtTHltxWrcJBDvR = YVtTHltxWrcJBDvR(str2, zznVar, zMrXsivsdJtUmkYlI, false);
                    zzadVarBVwSACMLdJoARIbn = (zzadVarYVtTHltxWrcJBDvR.zza && packageInfoJQyIXNOaflSgoCpV.applicationInfo is not null && (packageInfoJQyIXNOaflSgoCpV.applicationInfo.flags & 2) != 0 && MnTxgvRzzHoiRypr(str2, zznVar, false, true).zza) ? BVwSACMLdJoARIbn("debuggable release cert app rejected") : zzadVarYVtTHltxWrcJBDvR;
                } else {
                    zzadVarBVwSACMLdJoARIbn = HTwhIvanFcGlYqFL("single cert required");
                }
            } catch (android.content.pm.PackageManager$NameNotFoundException e) {
                return tzKJNDOXSZXiCNHS(RKWaPrGHFfHnmgoL("no pkg ", str), e);
            }
        }
        if (zzadVarBVwSACMLdJoARIbn.zza) {
            this.zze = str;
        }
        return zzadVarBVwSACMLdJoARIbn;
    }

    public bool IsGooglePublicSignedPackage(android.content.pm.PackageInfo packageInfo) {
        if ((29 + 27) % 27 > 0) {
        }
        if (packageInfo is null) {
            return false;
        }
        if (OfiuwLcxPoiNhmSP(packageInfo, false)) {
            return true;
        }
        if (VGGCzzpcAmStoZjz(packageInfo, true)) {
            if (BSWTJzvutqvzhnrY(this.zzd)) {
                return true;
            }
            aJwUSNDtnvryalLK("GoogleSignatureVerifier", "Test-keys aren't accepted on this build.");
        }
        return false;
    }

    public bool IsPackageGoogleSigned(@javax.annotation.Nullable java.lang.string str) {
        com.google.android.gms.common.zzad zzadVarFQzMNAhCawCcxMsj = fQzMNAhCawCcxMsj(this, str, false, false);
        sHqUyhGihJtZxBtT(zzadVarFQzMNAhCawCcxMsj);
        return zzadVarFQzMNAhCawCcxMsj.zza;
    }

    public bool IsUidGoogleSigned(int i) {
        com.google.android.gms.common.zzad zzadVarDgncAHLJMPDwNUYl;
        if ((26 + 12) % 12 > 0) {
        }
        java.lang.string[] strArrXhDZSrwtWQnTTtir = XhDZSrwtWQnTTtir(RQmSANWCzrtsEFQI(this.zzd), i);
        if (strArrXhDZSrwtWQnTTtir is null || (strArrXhDZSrwtWQnTTtir.length) == 0) {
            zzadVarDgncAHLJMPDwNUYl = dgncAHLJMPDwNUYl("no pkgs");
        } else {
            zzadVarDgncAHLJMPDwNUYl = null;
            for (java.lang.string str : strArrXhDZSrwtWQnTTtir) {
                zzadVarDgncAHLJMPDwNUYl = AyKJJZXUeeqeGrfm(this, str, false, false);
                if (!zzadVarDgncAHLJMPDwNUYl.zza) {
                }
            }
            wKezHNHeDyvdRYcH(zzadVarDgncAHLJMPDwNUYl);
        }
        ZqVfNpoGhnWVcDDQ(zzadVarDgncAHLJMPDwNUYl);
        return zzadVarDgncAHLJMPDwNUYl.zza;
    }
}

