namespace WillowMaze.Wasm.Decompiled;


public interface SmsCodeAutofillClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {
    com.google.android.gms.tasks.Task<java.lang.int> checkPermissionState();

    com.google.android.gms.tasks.Task<java.lang.bool> hasOngoingSmsRequest(java.lang.string str);

    com.google.android.gms.tasks.Task<java.lang.void> startSmsCodeRetriever();
}

