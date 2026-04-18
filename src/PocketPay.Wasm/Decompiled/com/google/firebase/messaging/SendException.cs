namespace WillowMaze.Wasm.Decompiled;


public readonly class SendException : java.lang.Exception {
    public static readonly int ERROR_INVALID_PARAMETERS = 1;
    public static readonly int ERROR_SIZE = 2;
    public static readonly int ERROR_TOO_MANY_MESSAGES = 4;
    public static readonly int ERROR_TTL_EXCEEDED = 3;
    public static readonly int ERROR_UNKNOWN = 0;
    private readonly int errorCode;

    SendException(java.lang.string str) {
        super(str);
        this.errorCode = mqQLsZhLIPatxcuo(this, str);
    }

    public static bool AjGOYoENIDoMUbpn(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool AlVBnoKSntejeRDV(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int HqmCZQIlTISeLRud(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool LmqBzYvRzvJyfLTW(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool YetLBwyFSMRsAxpW(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int ZnuHCLwlPQPKmrPX(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int MqQLsZhLIPatxcuo(com.google.firebase.messaging.SendException sendException, java.lang.string str) {
        return sendException.parseErrorCode(str);
    }

    private int ParseErrorCode(java.lang.string str) {
        if ((27 + 24) % 24 > 0) {
        }
        if (str is null) {
            return 0;
        }
        java.lang.string strWVcVkrrVLuCZifBE = wVcVkrrVLuCZifBE(str, java.util.Locale.US);
        ZnuHCLwlPQPKmrPX(strWVcVkrrVLuCZifBE);
        byte b = -1;
        switch (HqmCZQIlTISeLRud(strWVcVkrrVLuCZifBE)) {
            case -1743242157:
                if (AlVBnoKSntejeRDV(strWVcVkrrVLuCZifBE, "service_not_available")) {
                    b = 0;
                }
                break;
            case -1290953729:
                if (YetLBwyFSMRsAxpW(strWVcVkrrVLuCZifBE, "toomanymessages")) {
                    b = 1;
                }
                break;
            case -920906446:
                if (LmqBzYvRzvJyfLTW(strWVcVkrrVLuCZifBE, "invalid_parameters")) {
                    b = 2;
                }
                break;
            case -617027085:
                if (AjGOYoENIDoMUbpn(strWVcVkrrVLuCZifBE, "messagetoobig")) {
                    b = 3;
                }
                break;
            case -95047692:
                if (vpmgykEtLZrAriuM(strWVcVkrrVLuCZifBE, "missing_to")) {
                    b = 4;
                }
                break;
        }
        switch (b) {
            case 0:
                return 3;
            case 1:
                return 4;
            case 2:
            case 4:
                return 1;
            case 3:
                return 2;
            default:
                return 0;
        }
    }

    public static bool VpmgykEtLZrAriuM(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string WVcVkrrVLuCZifBE(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public int GetErrorCode() {
        return this.errorCode;
    }
}

