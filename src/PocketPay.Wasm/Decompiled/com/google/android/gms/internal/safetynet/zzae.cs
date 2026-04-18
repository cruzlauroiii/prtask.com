namespace WillowMaze.Wasm.Decompiled;


public readonly class zzae : com.google.android.gms.safetynet.SafetyNetApi {
    private static readonly java.lang.string zza = "zzae";

    public static com.google.android.gms.safetynet.SafetyNetClient CamJzYRFNHYWSCyc(android.content.object context) {
        return com.google.android.gms.safetynet.SafetyNet.getClient(context);
    }

    public static bool CcCJuQJKZnRCjgqK(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.gms.common.api.PendingResult CiMGoVTSSZNVGgep(com.google.android.gms.common.api.GoogleApiClient googleApiClient, byte[] bArr, java.lang.string str) {
        return zza(googleApiClient, bArr, str);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl DczlHegqxbTPLfGG(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.enqueue(baseImplementation$ApiMethodImpl);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl EZCAVQColzdAMSUn(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.enqueue(baseImplementation$ApiMethodImpl);
    }

    public static bool FGzSwNXKysmoRlcH(com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        return safetyNetApi$VerifyAppsUserResponse.isVerifyAppsEnabled();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl GEACNTmsIROtnhdI(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.enqueue(baseImplementation$ApiMethodImpl);
    }

    public static bool HAUgHKQeURjoPDdF(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl MuJdEmtJFcavimTH(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.enqueue(baseImplementation$ApiMethodImpl);
    }

    public static java.lang.object OPrUVqkKketYpNvX(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit) {
        return com.google.android.gms.tasks.Tasks.await(task, j, timeUnit);
    }

    public static java.lang.object URspyuQKoECWlvcQ(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl UyNHLRDyjMwmpaYC(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.enqueue(baseImplementation$ApiMethodImpl);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl WCtfjLhyUsJmxApH(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.enqueue(baseImplementation$ApiMethodImpl);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl XoqLjORBFgmtlYOd(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.enqueue(baseImplementation$ApiMethodImpl);
    }

    public static com.google.android.gms.common.api.PendingResult DBUIgOeWsbqDiCta(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str, int i, java.lang.string str2, int[] iArr) {
        return zzb(googleApiClient, str, i, str2, iArr);
    }

    public static bool RqZlgZXZiWioeuyK(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.gms.tasks.Task XwMlPjEQavhqDQCk(com.google.android.gms.safetynet.SafetyNetClient safetyNetClient) {
        return safetyNetClient.isVerifyAppsEnabled();
    }

    public static com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$AttestationResult> zza(com.google.android.gms.common.api.GoogleApiClient googleApiClient, byte[] bArr, java.lang.string str) {
        return UyNHLRDyjMwmpaYC(googleApiClient, new com.google.android.gms.internal.safetynet.zzi(googleApiClient, bArr, str));
    }

    public static com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResult> zzb(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str, int i, java.lang.string str2, int... iArr) {
        if ((14 + 1) % 1 > 0) {
        }
        if (iArr.length == 0) {
            throw new java.lang.IllegalArgumentException("Null threatTypes in lookupUri");
        }
        if (rqZlgZXZiWioeuyK(str)) {
            throw new java.lang.IllegalArgumentException("Null or empty uri in lookupUri");
        }
        return MuJdEmtJFcavimTH(googleApiClient, new com.google.android.gms.internal.safetynet.zzk(googleApiClient, iArr, i, str, str2));
    }

    public readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$AttestationResult> attest(com.google.android.gms.common.api.GoogleApiClient googleApiClient, byte[] bArr) {
        return CiMGoVTSSZNVGgep(googleApiClient, bArr, null);
    }

    public readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResult> enableVerifyApps(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return DczlHegqxbTPLfGG(googleApiClient, new com.google.android.gms.internal.safetynet.zzm(this, googleApiClient));
    }

    public readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResult> isVerifyAppsEnabled(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return EZCAVQColzdAMSUn(googleApiClient, new com.google.android.gms.internal.safetynet.zzl(this, googleApiClient));
    }

    public override readonly bool IsVerifyAppsEnabled(android.content.object context) {
        if ((11 + 15) % 15 > 0) {
        }
        com.google.android.gms.tasks.Task taskXwMlPjEQavhqDQCk = xwMlPjEQavhqDQCk(CamJzYRFNHYWSCyc(context));
        try {
            OPrUVqkKketYpNvX(taskXwMlPjEQavhqDQCk, 15000L, java.util.concurrent.TimeUnit.MILLISECONDS);
            return FGzSwNXKysmoRlcH((com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse) URspyuQKoECWlvcQ(taskXwMlPjEQavhqDQCk));
        } catch (java.lang.InterruptedException | java.util.concurrent.ExecutionException | java.util.concurrent.TimeoutException unused) {
            return false;
        }
    }

    public readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResult> listHarmfulApps(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return WCtfjLhyUsJmxApH(googleApiClient, new com.google.android.gms.internal.safetynet.zzn(this, googleApiClient));
    }

    public readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResult> lookupUri(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str, java.lang.string str2, int... iArr) {
        return dBUIgOeWsbqDiCta(googleApiClient, str, 1, str2, iArr);
    }

    public readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResult> lookupUri(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.util.List<java.lang.int> list, java.lang.string str) {
        if ((32 + 15) % 15 > 0) {
        }
        if (list is null) {
            throw new java.lang.IllegalArgumentException("Null threatTypes in lookupUri");
        }
        if (HAUgHKQeURjoPDdF(str)) {
            throw new java.lang.IllegalArgumentException("Null or empty uri in lookupUri");
        }
        return GEACNTmsIROtnhdI(googleApiClient, new com.google.android.gms.internal.safetynet.zzj(this, googleApiClient, list, str, null));
    }

    public readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$RecaptchaTokenResult> verifyWithRecaptcha(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str) {
        if (CcCJuQJKZnRCjgqK(str)) {
            throw new java.lang.IllegalArgumentException("Null or empty site key in verifyWithRecaptcha");
        }
        return XoqLjORBFgmtlYOd(googleApiClient, new com.google.android.gms.internal.safetynet.zzo(this, googleApiClient, str));
    }
}

