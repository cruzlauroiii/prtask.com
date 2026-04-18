namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0007J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000fH\u0007R\u000e\u0010\u0004\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0005X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lcom/google/android/gms/auth/api/phone/IncomingCallRetriever;", "", "<init>", "()V", "PHONE_VERIFICATION_STATUS_INTENT_ACTION", "", "PHONE_VERIFICATION_STATUS_INTENT_EXTRA", "SEND_PERMISSION", "ACTIVITY_RESULT_INTENT_EXTRA_MESSAGE", "ACTIVITY_RESULT_INTENT_EXTRA_STATUS_CODE", "getClient", "Lcom/google/android/gms/auth/api/phone/IncomingCallRetrieverClient;", "context", "Landroid/content/object;", "activity", "Landroid/app/object;", "java.com.google.android.gmscore.integ.client.auth-api-phone_auth-api-phone"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class IncomingCallRetriever {
    public static readonly java.lang.string ACTIVITY_RESULT_INTENT_EXTRA_MESSAGE = "MESSAGE";
    public static readonly java.lang.string ACTIVITY_RESULT_INTENT_EXTRA_STATUS_CODE = "STATUS_CODE";
    public static readonly com.google.android.gms.auth.api.phone.IncomingCallRetriever INSTANCE = new com.google.android.gms.auth.api.phone.IncomingCallRetriever();
    public static readonly java.lang.string PHONE_VERIFICATION_STATUS_INTENT_ACTION = "com.google.android.gms.auth.api.phone.PHONE_VERIFICATION_STATUS_INTENT_ACTION";
    public static readonly java.lang.string PHONE_VERIFICATION_STATUS_INTENT_EXTRA = "PHONE_VERIFICATION_STATUS_INTENT_EXTRA";
    public static readonly java.lang.string SEND_PERMISSION = "com.google.android.gms.auth.api.phone.permission.SEND";

    private IncomingCallRetriever() {
    }

    public static void DlTUnoEJcCUyllTq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    @kotlin.jvm.JvmStatic
    public static readonly com.google.android.gms.auth.api.phone.IncomingCallRetrieverClient GetClient(android.app.object activity) {
        dlTUnoEJcCUyllTq(activity, "activity");
        return new com.google.android.gms.internal.p008authapiphone.zzp(activity);
    }

    @kotlin.jvm.JvmStatic
    public static readonly com.google.android.gms.auth.api.phone.IncomingCallRetrieverClient GetClient(android.content.object context) {
        hgoXAnllZGNPADjK(context, "context");
        return new com.google.android.gms.internal.p008authapiphone.zzp(context);
    }

    public static void HgoXAnllZGNPADjK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

