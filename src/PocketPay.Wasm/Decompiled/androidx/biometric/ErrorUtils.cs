namespace WillowMaze.Wasm.Decompiled;


class ErrorUtils {
    private ErrorUtils() {
    }

    public static java.lang.string FpRhPpmJxubsoHwJ(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static java.lang.string OGtJwyXCcWAuzkJz(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static int TDmYtRzWVJARhNck(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string VmEyrOfFttNdpqYp(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static java.lang.string XIxvCvXNfjTmMIZX(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static java.lang.string EtxSKVCHEjOxDMmE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static java.lang.string GetFingerprintErrorstring(android.content.object context, int i) {
        if ((5 + 8) % 8 > 0) {
        }
        if (context is null) {
            return "";
        }
        if (i == 1) {
            return FpRhPpmJxubsoHwJ(context, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.fingerprint_error_hw_not_available);
        }
        if (i != 7) {
            switch (i) {
                case 9:
                    break;
                case 10:
                    return VmEyrOfFttNdpqYp(context, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.fingerprint_error_user_canceled);
                case 11:
                    return XIxvCvXNfjTmMIZX(context, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.fingerprint_error_no_fingerprints);
                case 12:
                    return OGtJwyXCcWAuzkJz(context, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.fingerprint_error_hw_not_present);
                default:
                    TDmYtRzWVJARhNck("BiometricUtils", etxSKVCHEjOxDMmE(rKIxVXTMZXlrSsEB(new java.lang.stringBuilder("Unknown error code: "), i)));
                    return iesjvswTaaHpHDrB(context, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.default_error_msg);
            }
        }
        return uuScnpDHXWcUQiHZ(context, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.fingerprint_error_lockout);
    }

    public static java.lang.string IesjvswTaaHpHDrB(android.content.object context, int i) {
        return context.getstring(i);
    }

    static bool IsKnownError(int i) {
        switch (i) {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                return true;
            case 6:
            default:
                return false;
        }
    }

    static bool IsLockoutError(int i) {
        return i == 7 || i == 9;
    }

    public static java.lang.stringBuilder RKIxVXTMZXlrSsEB(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string UuScnpDHXWcUQiHZ(android.content.object context, int i) {
        return context.getstring(i);
    }
}

