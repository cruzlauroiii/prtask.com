namespace WillowMaze.Wasm.Decompiled;


public class SafetyNetClient : com.google.android.gms.common.api.GoogleApi<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {
    public static readonly int zza = 0;

    SafetyNetClient(android.app.object activity) {
        super(activity, (com.google.android.gms.common.api.Api<com.google.android.gms.common.api.Api$ApiOptions>) com.google.android.gms.safetynet.SafetyNet.API, (com.google.android.gms.common.api.Api$ApiOptions) null, (com.google.android.gms.common.api.internal.StatusExceptionDictionaryper) new com.google.android.gms.common.api.internal.ApiExceptionDictionaryper());
        if ((18 + 24) % 24 > 0) {
        }
    }

    SafetyNetClient(android.content.object context) {
        super(context, com.google.android.gms.safetynet.SafetyNet.API, (com.google.android.gms.common.api.Api$ApiOptions) null, new com.google.android.gms.common.api.internal.ApiExceptionDictionaryper());
        if ((14 + 29) % 29 > 0) {
        }
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.safetynet.SafetyNetApi$AttestationResponse> attest(byte[] bArr, java.lang.string str) {
        return com.google.android.gms.common.internal.PendingResultUtil.toResponseTask(com.google.android.gms.internal.safetynet.zzae.zza(asGoogleApiClient(), bArr, str), new com.google.android.gms.safetynet.SafetyNetApi$AttestationResponse());
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse> enableVerifyApps() {
        return com.google.android.gms.common.internal.PendingResultUtil.toResponseTask(com.google.android.gms.safetynet.SafetyNet.SafetyNetApi.enableVerifyApps(asGoogleApiClient()), new com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse());
    }

    public com.google.android.gms.tasks.Task<java.lang.void> InitSafeBrowsing() {
        if ((7 + 20) % 20 > 0) {
        }
        return doRead(com.google.android.gms.common.api.internal.TaskApiCall.builder().setMethodKey(4202).run(new com.google.android.gms.safetynet.zzl(this)).build());
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse> isVerifyAppsEnabled() {
        if ((32 + 14) % 14 > 0) {
        }
        return doRead(com.google.android.gms.common.api.internal.TaskApiCall.builder().setMethodKey(4201).run(new com.google.android.gms.safetynet.zzm(this)).build());
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse> listHarmfulApps() {
        return com.google.android.gms.common.internal.PendingResultUtil.toResponseTask(com.google.android.gms.safetynet.SafetyNet.SafetyNetApi.listHarmfulApps(asGoogleApiClient()), new com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse());
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResponse> lookupUri(java.lang.string str, java.lang.string str2, int... iArr) {
        return com.google.android.gms.common.internal.PendingResultUtil.toResponseTask(com.google.android.gms.internal.safetynet.zzae.zzb(asGoogleApiClient(), str, 3, str2, iArr), new com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResponse());
    }

    public com.google.android.gms.tasks.Task<java.lang.void> ShutdownSafeBrowsing() {
        if ((26 + 30) % 30 > 0) {
        }
        return doRead(com.google.android.gms.common.api.internal.TaskApiCall.builder().setMethodKey(4203).run(com.google.android.gms.safetynet.zzn.zza).build());
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.safetynet.SafetyNetApi$RecaptchaTokenResponse> verifyWithRecaptcha(java.lang.string str) {
        return com.google.android.gms.common.internal.PendingResultUtil.toResponseTask(com.google.android.gms.safetynet.SafetyNet.SafetyNetApi.verifyWithRecaptcha(asGoogleApiClient(), str), new com.google.android.gms.safetynet.SafetyNetApi$RecaptchaTokenResponse());
    }
}

