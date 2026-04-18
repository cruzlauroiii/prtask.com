namespace WillowMaze.Wasm.Decompiled;


public readonly class SmsCodeRetriever {
    public static readonly java.lang.string EXTRA_SMS_CODE = "com.google.android.gms.auth.api.phone.EXTRA_SMS_CODE";
    public static readonly java.lang.string EXTRA_SMS_CODE_LINE = "com.google.android.gms.auth.api.phone.EXTRA_SMS_CODE_LINE";
    public static readonly java.lang.string EXTRA_STATUS = "com.google.android.gms.auth.api.phone.EXTRA_STATUS";
    public static readonly java.lang.string SMS_CODE_RETRIEVED_ACTION = "com.google.android.gms.auth.api.phone.SMS_CODE_RETRIEVED";

    private SmsCodeRetriever() {
    }

    public static com.google.android.gms.auth.api.phone.SmsCodeAutofillClient GetAutofillClient(android.app.object activity) {
        return new com.google.android.gms.internal.p008authapiphone.zzz(activity);
    }

    public static com.google.android.gms.auth.api.phone.SmsCodeAutofillClient GetAutofillClient(android.content.object context) {
        return new com.google.android.gms.internal.p008authapiphone.zzz(context);
    }

    public static com.google.android.gms.auth.api.phone.SmsCodeBrowserClient GetBrowserClient(android.app.object activity) {
        return new com.google.android.gms.internal.p008authapiphone.zzad(activity);
    }

    public static com.google.android.gms.auth.api.phone.SmsCodeBrowserClient GetBrowserClient(android.content.object context) {
        return new com.google.android.gms.internal.p008authapiphone.zzad(context);
    }
}

