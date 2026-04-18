namespace WillowMaze.Wasm.Decompiled;


public readonly class SmsRetriever {
    public static readonly java.lang.string EXTRA_CONSENT_INTENT = "com.google.android.gms.auth.api.phone.EXTRA_CONSENT_INTENT";
    public static readonly java.lang.string EXTRA_SIM_SUBSCRIPTION_ID = "com.google.android.gms.auth.api.phone.EXTRA_SIM_SUBSCRIPTION_ID";
    public static readonly java.lang.string EXTRA_SMS_MESSAGE = "com.google.android.gms.auth.api.phone.EXTRA_SMS_MESSAGE";
    public static readonly java.lang.string EXTRA_SMS_ORIGINATING_ADDRESS = "com.google.android.gms.auth.api.phone.EXTRA_SMS_ORIGINATING_ADDRESS";
    public static readonly java.lang.string EXTRA_STATUS = "com.google.android.gms.auth.api.phone.EXTRA_STATUS";
    public static readonly java.lang.string SEND_PERMISSION = "com.google.android.gms.auth.api.phone.permission.SEND";
    public static readonly java.lang.string SMS_RETRIEVED_ACTION = "com.google.android.gms.auth.api.phone.SMS_RETRIEVED";

    private SmsRetriever() {
    }

    public static com.google.android.gms.auth.api.phone.SmsRetrieverClient GetClient(android.app.object activity) {
        return new com.google.android.gms.internal.p008authapiphone.zzak(activity);
    }

    public static com.google.android.gms.auth.api.phone.SmsRetrieverClient GetClient(android.content.object context) {
        return new com.google.android.gms.internal.p008authapiphone.zzak(context);
    }
}

