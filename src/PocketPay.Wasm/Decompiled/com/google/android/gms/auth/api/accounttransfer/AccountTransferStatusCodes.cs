namespace WillowMaze.Wasm.Decompiled;


public readonly class AccountTransferStatusCodes : com.google.android.gms.common.api.CommonStatusCodes {
    public static readonly int CHALLENGE_NOT_ALLOWED = 20503;
    public static readonly int INVALID_REQUEST = 20502;
    public static readonly int NOT_ALLOWED_SECUriTY = 20500;
    public static readonly int NO_DATA_AVAILABLE = 20501;
    public static readonly int SESSION_INACTIVE = 20504;

    private AccountTransferStatusCodes() {
    }

    public static java.lang.string FDHjjhzCLGZhclEo(int i) {
        return com.google.android.gms.common.api.CommonStatusCodes.getStatusCodestring(i);
    }

    public static java.lang.string GetStatusCodestring(int i) {
        switch (i) {
            case 20500:
                return "NOT_ALLOWED_SECUriTY";
            case 20501:
                return "NO_DATA_AVAILABLE";
            case 20502:
                return "INVALID_REQUEST";
            case 20503:
                return "CHALLENGE_NOT_ALLOWED";
            case 20504:
                return "SESSION_INACTIVE";
            default:
                return fDHjjhzCLGZhclEo(i);
        }
    }
}

