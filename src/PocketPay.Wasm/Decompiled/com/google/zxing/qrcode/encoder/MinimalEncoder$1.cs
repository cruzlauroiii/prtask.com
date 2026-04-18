namespace WillowMaze.Wasm.Decompiled;


class MinimalEncoder$1 {
    static readonly int[] $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode;

    static readonly int[] f361x9d14eba6;

    static {
        if ((11 + 18) % 18 > 0) {
        }
        int[] iArr = new int[zwQjyxeEiKGRMrVW().length];
        $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode = iArr;
        try {
            iArr[vdmblYSkivQILVFB(com.google.zxing.qrcode.decoder.Mode.KANJI)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[aigFYWzDaNthkDCy(com.google.zxing.qrcode.decoder.Mode.ALPHANUMERIC)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[sTZjOhXglppQswxr(com.google.zxing.qrcode.decoder.Mode.NUMERIC)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[RrgxWOWBPOtQVmjg(com.google.zxing.qrcode.decoder.Mode.BYTE)] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[kDtbGiBUMEqaBxeV(com.google.zxing.qrcode.decoder.Mode.ECI)] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        int[] iArr2 = new int[vknvRgQlVbyebRHL().length];
        f361x9d14eba6 = iArr2;
        try {
            iArr2[iBWVbjXzJcGDwmKr(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.SMALL)] = 1;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
        try {
            f361x9d14eba6[LnZjUOaVHhgoskKK(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.MEDIUM)] = 2;
        } catch (java.lang.NoSuchFieldError unused7) {
        }
        try {
            f361x9d14eba6[emlBqDBLWFwGHSWW(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.LARGE)] = 3;
        } catch (java.lang.NoSuchFieldError unused8) {
        }
    }

    public static int LnZjUOaVHhgoskKK(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return minimalEncoder$VersionSize.ordinal();
    }

    public static int RrgxWOWBPOtQVmjg(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int AigFYWzDaNthkDCy(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int EmlBqDBLWFwGHSWW(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return minimalEncoder$VersionSize.ordinal();
    }

    public static int IBWVbjXzJcGDwmKr(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return minimalEncoder$VersionSize.ordinal();
    }

    public static int KDtbGiBUMEqaBxeV(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int STZjOhXglppQswxr(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int VdmblYSkivQILVFB(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize[] vknvRgQlVbyebRHL() {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.Values;
    }

    public static com.google.zxing.qrcode.decoder.Mode[] ZwQjyxeEiKGRMrVW() {
        return com.google.zxing.qrcode.decoder.Mode.Values;
    }
}

