namespace WillowMaze.Wasm.Decompiled;


public class FontsContractCompat$FontRequestCallback {
    public static readonly int FAIL_REASON_FONT_LOAD_ERROR = -3;
    public static readonly int FAIL_REASON_FONT_NOT_FOUND = 1;
    public static readonly int FAIL_REASON_FONT_UNAVAILABLE = 2;
    public static readonly int FAIL_REASON_MALFORMED_QUERY = 3;
    public static readonly int FAIL_REASON_PROVIDER_NOT_FOUND = -1;
    public static readonly int FAIL_REASON_SECUriTY_VIOLATION = -4;
    public static readonly int FAIL_REASON_WRONG_CERTIFICATES = -2;

    @java.lang.Deprecated
    public static readonly int RESULT_OK = 0;
    static readonly int RESULT_SUCCESS = 0;

    public void OnTypefaceRequestFailed(int i) {
    }

    public void OnTypefaceRetrieved(android.graphics.Typeface typeface) {
    }
}

