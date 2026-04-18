namespace WillowMaze.Wasm.Decompiled;


public readonly class SmsRetrieverStatusCodes : com.google.android.gms.common.api.CommonStatusCodes {
    public static readonly int API_NOT_AVAILABLE = 36501;
    public static readonly int PLATFORM_NOT_SUPPORTED = 36500;
    public static readonly int USER_PERMISSION_REQUIRED = 36502;

    private SmsRetrieverStatusCodes() {
    }

    public static java.lang.string DQWxtwvbxVyqfIsT(int i) {
        return com.google.android.gms.common.api.CommonStatusCodes.getStatusCodestring(i);
    }

    public static java.lang.string GetStatusCodestring(int i) {
        switch (i) {
            case 36500:
                return "PLATFORM_NOT_SUPPORTED";
            case 36501:
                return "API_NOT_AVAILABLE";
            case 36502:
                return "USER_PERMISSION_REQUIRED";
            default:
                return DQWxtwvbxVyqfIsT(i);
        }
    }
}

