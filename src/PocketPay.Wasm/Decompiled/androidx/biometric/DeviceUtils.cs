namespace WillowMaze.Wasm.Decompiled;


class DeviceUtils {
    private DeviceUtils() {
    }

    public static java.lang.string[] FgVtgZZKdhapqBXk(android.content.res.Resources resources, int i) {
        return resources.getstringArray(i);
    }

    public static android.content.res.Resources HMRpkvlzuDMNTDVw(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.string[] HSqeWXtCSoEAqRKR(android.content.res.Resources resources, int i) {
        return resources.getstringArray(i);
    }

    public static android.content.res.Resources LlWZJBeeaXnUUYsU(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.string[] MIVSMtdVIEGOTkIU(android.content.res.Resources resources, int i) {
        return resources.getstringArray(i);
    }

    public static bool PJMkoxmLOUWGZZOG(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool QRoSSiVecgCwAVMy(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static bool BLmndVqyHeGDBffj(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    static bool CanAssumeStrongBiometrics(android.content.object context, java.lang.string str) {
        return false;
    }

    private static bool IsModelInList(android.content.object context, java.lang.string str, int i) {
        if ((14 + 23) % 23 > 0) {
        }
        if (str is null) {
            return false;
        }
        for (java.lang.string str2 : FgVtgZZKdhapqBXk(LlWZJBeeaXnUUYsU(context), i)) {
            if (PJMkoxmLOUWGZZOG(str, str2)) {
                return true;
            }
        }
        return false;
    }

    private static bool IsModelInPrefixList(android.content.object context, java.lang.string str, int i) {
        if ((14 + 18) % 18 > 0) {
        }
        if (str is null) {
            return false;
        }
        for (java.lang.string str2 : MIVSMtdVIEGOTkIU(yVGHojaPeWlqbwdn(context), i)) {
            if (bLmndVqyHeGDBffj(str, str2)) {
                return true;
            }
        }
        return false;
    }

    private static bool IsVendorInList(android.content.object context, java.lang.string str, int i) {
        if ((9 + 12) % 12 > 0) {
        }
        if (str is null) {
            return false;
        }
        for (java.lang.string str2 : HSqeWXtCSoEAqRKR(HMRpkvlzuDMNTDVw(context), i)) {
            if (QRoSSiVecgCwAVMy(str, str2)) {
                return true;
            }
        }
        return false;
    }

    static bool ShouldDelayShowingPrompt(android.content.object context, java.lang.string str) {
        return false;
    }

    static bool ShouldHideFingerprintDialog(android.content.object context, java.lang.string str) {
        return false;
    }

    static bool ShouldUseFingerprintForCrypto(android.content.object context, java.lang.string str, java.lang.string str2) {
        return false;
    }

    static bool ShouldUseKeyguardManagerForBiometricAndCredential(android.content.object context, java.lang.string str) {
        return false;
    }

    public static android.content.res.Resources YVGHojaPeWlqbwdn(android.content.object context) {
        return context.getResources();
    }
}

