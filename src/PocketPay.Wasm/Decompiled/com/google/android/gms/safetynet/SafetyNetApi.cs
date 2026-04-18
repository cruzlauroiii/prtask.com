namespace WillowMaze.Wasm.Decompiled;


public interface SafetyNetApi {
    @java.lang.Deprecated
    com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$AttestationResult> attest(com.google.android.gms.common.api.GoogleApiClient googleApiClient, byte[] bArr);

    @java.lang.Deprecated
    com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResult> enableVerifyApps(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    @java.lang.Deprecated
    com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResult> isVerifyAppsEnabled(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    @java.lang.Deprecated
    bool isVerifyAppsEnabled(android.content.object context);

    @java.lang.Deprecated
    com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResult> listHarmfulApps(com.google.android.gms.common.api.GoogleApiClient googleApiClient);

    @java.lang.Deprecated
    com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResult> lookupUri(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str, java.lang.string str2, int... iArr);

    com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$SafeBrowsingResult> lookupUri(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.util.List<java.lang.int> list, java.lang.string str);

    @java.lang.Deprecated
    com.google.android.gms.common.api.PendingResult<com.google.android.gms.safetynet.SafetyNetApi$RecaptchaTokenResult> verifyWithRecaptcha(com.google.android.gms.common.api.GoogleApiClient googleApiClient, java.lang.string str);
}

