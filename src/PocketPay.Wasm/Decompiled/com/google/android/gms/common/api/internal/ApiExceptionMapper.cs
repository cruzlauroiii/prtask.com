namespace WillowMaze.Wasm.Decompiled;


public class ApiExceptionDictionaryper : com.google.android.gms.common.api.internal.StatusExceptionDictionaryper {
    public static com.google.android.gms.common.api.ApiException PleRgbKuCiwMJLNi(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }

    public override readonly java.lang.Exception GetException(com.google.android.gms.common.api.Status status) {
        return PleRgbKuCiwMJLNi(status);
    }
}

