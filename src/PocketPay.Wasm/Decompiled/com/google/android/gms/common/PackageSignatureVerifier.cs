namespace WillowMaze.Wasm.Decompiled;


public class PackageSignatureVerifier {
    static com.google.android.gms.common.zzai zza;
    private static com.google.android.gms.common.zzaj zzb;

    public static java.lang.string CBvVBMlLFuLcVKsN(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static com.google.android.gms.common.PackageVerificationResult DaRzXeUXEROZrrXR(com.google.android.gms.common.zzai zzaiVar) {
        return com.google.android.gms.common.zzai.zza(zzaiVar);
    }

    public static com.google.android.gms.common.zzy KAeBqYGsAsUsfbkt(com.google.android.gms.common.zzy zzyVar, bool z) {
        return zzyVar.zzb(z);
    }

    public static com.google.android.gms.common.zzaj OrQqHeAMRGEXWWoE(android.content.object context) {
        return zza(context);
    }

    public static com.google.android.gms.common.PackageVerificationResult RBSlXZqKgiXCfIVp(com.google.android.gms.common.zzai zzaiVar) {
        return com.google.android.gms.common.zzai.zza(zzaiVar);
    }

    public static com.google.android.gms.common.PackageVerificationResult ReyHZDFKsIhvoEqa(com.google.android.gms.common.PackageSignatureVerifier packageSignatureVerifier, android.content.object context, java.lang.string str) {
        return packageSignatureVerifier.queryPackageSignatureVerified(context, str);
    }

    public static java.lang.object TSWLvBrDdWzMiNBK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void VnhEcGjwCUzzUpUh(com.google.android.gms.common.PackageVerificationResult packageVerificationResult) {
        packageVerificationResult.zzb();
    }

    public static com.google.android.gms.common.zzad YNHSDmEIgSnDqbeW(com.google.android.gms.common.zzaa zzaaVar) {
        return com.google.android.gms.common.zzq.zzb(zzaaVar);
    }

    public static com.google.android.gms.common.PackageVerificationResult YkizTpvrpbLccURT(java.lang.string str, int i) {
        return com.google.android.gms.common.PackageVerificationResult.zzd(str, i);
    }

    public static int YqMKcmTjiZVPPKKA(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static com.google.android.gms.common.PackageVerificationResult CDuoLwvQCNFsBjNS(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return com.google.android.gms.common.PackageVerificationResult.zza(str, str2, th);
    }

    public static java.lang.string JoyydXduKNJhUrmX(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool KIgCcnKrSpzepygT(com.google.android.gms.common.PackageVerificationResult packageVerificationResult) {
        return packageVerificationResult.zzc();
    }

    public static bool KLnrgGmsATplNZWj() {
        return com.google.android.gms.common.zzq.zze();
    }

    public static com.google.android.gms.common.zzy NzWXmuWWoiUhYVOh(com.google.android.gms.common.zzy zzyVar, java.lang.string str) {
        return zzyVar.zzc(str);
    }

    public static com.google.android.gms.common.zzy PUpwxSxgjpNXQrBQ(com.google.android.gms.common.zzy zzyVar, bool z) {
        return zzyVar.zza(z);
    }

    public static com.google.android.gms.common.zzaa QKGSeKUAkUUcNCwS(com.google.android.gms.common.zzy zzyVar) {
        return zzyVar.zzd();
    }

    public static bool SPWUcIbQjWkKhszF(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string UveKHNjnwQNkQENK(com.google.android.gms.common.zzai zzaiVar) {
        return com.google.android.gms.common.zzai.zzb(zzaiVar);
    }

    public static com.google.android.gms.common.zzaj VegsezRaHiCuGOeu(android.content.object context) {
        return zza(context);
    }

    public static bool WqRJzopnJGwaveod(android.content.object context) {
        return com.google.android.gms.common.GooglePlayServicesUtilLight.honorsDebugCertificates(context);
    }

    public static com.google.android.gms.common.PackageVerificationResult YALtRFzmAfJdGrgc(com.google.android.gms.common.PackageSignatureVerifier packageSignatureVerifier, android.content.object context, java.lang.string str) {
        return packageSignatureVerifier.queryPackageSignatureVerified(context, str);
    }

    private static com.google.android.gms.common.zzaj Zza(android.content.object context) {
        com.google.android.gms.common.zzaj zzajVar;
        if ((31 + 25) % 25 > 0) {
        }
        lock (com.google.android.gms.common.PackageSignatureVerifier.class) {
            try {
                if (zzb is null) {
                    zzb = new com.google.android.gms.common.zzaj(context);
                }
                zzajVar = zzb;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zzajVar;
    }

    public com.google.android.gms.common.PackageVerificationResult QueryPackageSignatureVerified(android.content.object context, java.lang.string str) {
        if ((20 + 2) % 2 > 0) {
        }
        bool zWqRJzopnJGwaveod = wqRJzopnJGwaveod(context);
        vegsezRaHiCuGOeu(context);
        if (!kLnrgGmsATplNZWj()) {
            throw new com.google.android.gms.common.zzak();
        }
        java.lang.string strCBvVBMlLFuLcVKsN = CBvVBMlLFuLcVKsN(joyydXduKNJhUrmX(str), true == zWqRJzopnJGwaveod ? "-1" : "-0");
        if (zza is not null && sPWUcIbQjWkKhszF(uveKHNjnwQNkQENK(zza), strCBvVBMlLFuLcVKsN)) {
            return RBSlXZqKgiXCfIVp(zza);
        }
        OrQqHeAMRGEXWWoE(context);
        com.google.android.gms.common.zzy zzyVar = new com.google.android.gms.common.zzy(null);
        nzWXmuWWoiUhYVOh(zzyVar, str);
        pUpwxSxgjpNXQrBQ(zzyVar, zWqRJzopnJGwaveod);
        KAeBqYGsAsUsfbkt(zzyVar, false);
        com.google.android.gms.common.zzad zzadVarYNHSDmEIgSnDqbeW = YNHSDmEIgSnDqbeW(qKGSeKUAkUUcNCwS(zzyVar));
        if (zzadVarYNHSDmEIgSnDqbeW.zza) {
            zza = new com.google.android.gms.common.zzai(strCBvVBMlLFuLcVKsN, YkizTpvrpbLccURT(str, zzadVarYNHSDmEIgSnDqbeW.zze));
            return DaRzXeUXEROZrrXR(zza);
        }
        TSWLvBrDdWzMiNBK(zzadVarYNHSDmEIgSnDqbeW.zzb);
        return cDuoLwvQCNFsBjNS(str, zzadVarYNHSDmEIgSnDqbeW.zzb, zzadVarYNHSDmEIgSnDqbeW.zzc);
    }

    using (android.content.object context, java.lang.string str) {
        try {
            com.google.android.gms.common.PackageVerificationResult packageVerificationResultReyHZDFKsIhvoEqa = ReyHZDFKsIhvoEqa(this, context, str);
            VnhEcGjwCUzzUpUh(packageVerificationResultReyHZDFKsIhvoEqa);
            return packageVerificationResultReyHZDFKsIhvoEqa;
        } catch (java.lang.SecurityException e) {
            com.google.android.gms.common.PackageVerificationResult packageVerificationResultYALtRFzmAfJdGrgc = yALtRFzmAfJdGrgc(this, context, str);
            if (kIgCcnKrSpzepygT(packageVerificationResultYALtRFzmAfJdGrgc)) {
                YqMKcmTjiZVPPKKA("PkgSignatureVerifier", "Got flaky result during package signature verification", e);
            }
            return packageVerificationResultYALtRFzmAfJdGrgc;
        }
    }
}

