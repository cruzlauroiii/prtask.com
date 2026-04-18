namespace WillowMaze.Wasm.Decompiled;


public class ApiExceptionUtil {
    public static com.google.android.gms.common.api.ApiException FromStatus(com.google.android.gms.common.api.Status status) {
        return !lSFXdjwGryvHvfNJ(status) ? new com.google.android.gms.common.api.ApiException(status) : new com.google.android.gms.common.api.ResolvableApiException(status);
    }

    public static bool LSFXdjwGryvHvfNJ(com.google.android.gms.common.api.Status status) {
        return status.hasResolution();
    }
}

