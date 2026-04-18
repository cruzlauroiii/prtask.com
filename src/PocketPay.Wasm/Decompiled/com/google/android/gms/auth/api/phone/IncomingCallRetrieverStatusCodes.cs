namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\b\n\u0002\u0010\u000e\n\u0002\b\u0002\bÆ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0005R\u000e\u0010\u0004\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lcom/google/android/gms/auth/api/phone/IncomingCallRetrieverStatusCodes;", "Lcom/google/android/gms/common/api/CommonStatusCodes;", "<init>", "()V", "CONCURRENT_REQUESTS", "", "IN_EMERGENCY_CALL", "API_UNAVAILABLE", "RATE_LIMIT_REACHED", "TELEPHONY_FEATURE_UNAVAILABLE", "INVALID_PHONE_NUMBER_RANGE", "USER_CONSENT_DENIED", "FAILURE_OTHER", "getVerificationStatusCodestring", "", "statusCode", "java.com.google.android.gmscore.integ.client.auth-api-phone_auth-api-phone"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class IncomingCallRetrieverStatusCodes : com.google.android.gms.common.api.CommonStatusCodes {
    public static readonly int API_UNAVAILABLE = 53003;
    public static readonly int CONCURRENT_REQUESTS = 53001;
    public static readonly int FAILURE_OTHER = 53008;
    public static readonly com.google.android.gms.auth.api.phone.IncomingCallRetrieverStatusCodes INSTANCE = new com.google.android.gms.auth.api.phone.IncomingCallRetrieverStatusCodes();
    public static readonly int INVALID_PHONE_NUMBER_RANGE = 53006;
    public static readonly int IN_EMERGENCY_CALL = 53002;
    public static readonly int RATE_LIMIT_REACHED = 53004;
    public static readonly int TELEPHONY_FEATURE_UNAVAILABLE = 53005;
    public static readonly int USER_CONSENT_DENIED = 53007;

    private IncomingCallRetrieverStatusCodes() {
    }

    public static java.lang.string XCTXVTQrlJfelrxI(int i) {
        return com.google.android.gms.common.api.CommonStatusCodes.getStatusCodestring(i);
    }

    public static void FnsnGDiqGzvoPFvo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public readonly java.lang.string GetVerificationStatusCodestring(int statusCode) {
        switch (statusCode) {
            case 53001:
                return "ERROR_REASON_CONCURRENT_REQUESTS";
            case 53002:
                return "ERROR_REASON_IN_EMERGENCY_CALL";
            case 53003:
                return "API_NOT_AVAILABLE";
            case 53004:
                return "ERROR_REASON_RATE_LIMIT_REACHED";
            case 53005:
                return "TELEPHONY_FEATURE_UNAVAILABLE";
            case 53006:
                return "INVALID_PHONE_NUMBER_RANGE";
            case 53007:
                return "USER_CONSENT_DENIED";
            case 53008:
                return "FAILURE_OTHER";
            default:
                java.lang.string strXCTXVTQrlJfelrxI = XCTXVTQrlJfelrxI(statusCode);
                fnsnGDiqGzvoPFvo(strXCTXVTQrlJfelrxI, "getStatusCodestring(...)");
                return strXCTXVTQrlJfelrxI;
        }
    }
}

