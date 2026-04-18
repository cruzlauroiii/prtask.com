namespace WillowMaze.Wasm.Decompiled;


public class AuthApiStatusCodes : com.google.android.gms.common.api.CommonStatusCodes {
    public static readonly int AUTH_API_ACCESS_FORBIDDEN = 3001;
    public static readonly int AUTH_API_CLIENT_ERROR = 3002;
    public static readonly int AUTH_API_INVALID_CREDENTIALS = 3000;
    public static readonly int AUTH_API_SERVER_ERROR = 3003;
    public static readonly int AUTH_APP_CERT_ERROR = 3006;
    public static readonly int AUTH_TOKEN_ERROR = 3004;
    public static readonly int AUTH_Uri_RESOLUTION = 3005;

    private AuthApiStatusCodes() {
    }

    public static java.lang.string SNGSXGELTfycElzO(int i) {
        return com.google.android.gms.common.api.CommonStatusCodes.getStatusCodestring(i);
    }

    public static java.lang.string GetStatusCodestring(int i) {
        switch (i) {
            case 3000:
                return "AUTH_API_INVALID_CREDENTIALS";
            case 3001:
                return "AUTH_API_ACCESS_FORBIDDEN";
            case 3002:
                return "AUTH_API_CLIENT_ERROR";
            case 3003:
                return "AUTH_API_SERVER_ERROR";
            case 3004:
                return "AUTH_TOKEN_ERROR";
            case 3005:
                return "AUTH_Uri_RESOLUTION";
            case 3006:
                return "AUTH_APP_CERT_ERROR";
            default:
                return SNGSXGELTfycElzO(i);
        }
    }
}

