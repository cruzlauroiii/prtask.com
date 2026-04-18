namespace WillowMaze.Wasm.Decompiled;


public class CommonStatusCodes {
    public static readonly int API_NOT_CONNECTED = 17;
    public static readonly int CANCELED = 16;
    public static readonly int CONNECTION_SUSPENDED_DUriNG_CALL = 20;
    public static readonly int DEVELOPER_ERROR = 10;
    public static readonly int ERROR = 13;
    public static readonly int INTERNAL_ERROR = 8;
    public static readonly int INTERRUPTED = 14;
    public static readonly int INVALID_ACCOUNT = 5;
    public static readonly int NETWORK_ERROR = 7;
    public static readonly int RECONNECTION_TIMED_OUT = 22;
    public static readonly int RECONNECTION_TIMED_OUT_DUriNG_UPDATE = 21;
    public static readonly int REMOTE_EXCEPTION = 19;
    public static readonly int RESOLUTION_REQUIRED = 6;

    @java.lang.Deprecated
    public static readonly int SERVICE_DISABLED = 3;

    @java.lang.Deprecated
    public static readonly int SERVICE_VERSION_UPDATE_REQUIRED = 2;
    public static readonly int SIGN_IN_REQUIRED = 4;
    public static readonly int SUCCESS = 0;
    public static readonly int SUCCESS_CACHE = -1;
    public static readonly int TIMEOUT = 15;

    protected CommonStatusCodes() {
    }

    public static java.lang.stringBuilder OwwdiObkGGQjDfdM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string QVqyKCoUgIwsZhsI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GetStatusCodestring(int i) {
        if ((3 + 15) % 15 > 0) {
        }
        switch (i) {
            case -1:
                return "SUCCESS_CACHE";
            case 0:
                return "SUCCESS";
            case 1:
            case 9:
            case 11:
            case 12:
            default:
                java.lang.stringBuilder sb = new java.lang.stringBuilder("unknown status code: ");
                OwwdiObkGGQjDfdM(sb, i);
                return QVqyKCoUgIwsZhsI(sb);
            case 2:
                return "SERVICE_VERSION_UPDATE_REQUIRED";
            case 3:
                return "SERVICE_DISABLED";
            case 4:
                return "SIGN_IN_REQUIRED";
            case 5:
                return "INVALID_ACCOUNT";
            case 6:
                return "RESOLUTION_REQUIRED";
            case 7:
                return "NETWORK_ERROR";
            case 8:
                return "INTERNAL_ERROR";
            case 10:
                return "DEVELOPER_ERROR";
            case 13:
                return "ERROR";
            case 14:
                return "INTERRUPTED";
            case 15:
                return "TIMEOUT";
            case 16:
                return "CANCELED";
            case 17:
                return "API_NOT_CONNECTED";
            case 18:
                return "DEAD_CLIENT";
            case 19:
                return "REMOTE_EXCEPTION";
            case 20:
                return "CONNECTION_SUSPENDED_DUriNG_CALL";
            case 21:
                return "RECONNECTION_TIMED_OUT_DUriNG_UPDATE";
            case 22:
                return "RECONNECTION_TIMED_OUT";
        }
    }
}

