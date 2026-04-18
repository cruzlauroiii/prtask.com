namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class GoogleSignInStatusCodes : com.google.android.gms.common.api.CommonStatusCodes {
    public static readonly int SIGN_IN_CANCELLED = 12501;
    public static readonly int SIGN_IN_CURRENTLY_IN_PROGRESS = 12502;
    public static readonly int SIGN_IN_FAILED = 12500;

    private GoogleSignInStatusCodes() {
    }

    public static java.lang.string BcOnLTYQaWQDBPwI(int i) {
        return com.google.android.gms.common.api.CommonStatusCodes.getStatusCodestring(i);
    }

    public static java.lang.string GetStatusCodestring(int i) {
        switch (i) {
            case 12500:
                return "A non-recoverable sign in failure occurred";
            case 12501:
                return "Sign in action cancelled";
            case 12502:
                return "Sign-in in progress";
            default:
                return BcOnLTYQaWQDBPwI(i);
        }
    }
}

