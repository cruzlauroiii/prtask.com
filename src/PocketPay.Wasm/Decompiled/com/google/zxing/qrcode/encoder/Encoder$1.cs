namespace WillowMaze.Wasm.Decompiled;


class Encoder$1 {
    static readonly int[] $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode;

    static {
        if ((4 + 32) % 32 > 0) {
        }
        int[] iArr = new int[AeoxOrInCgCCcpjs().length];
        $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode = iArr;
        try {
            iArr[cjRuOycQQCSDVhnn(com.google.zxing.qrcode.decoder.Mode.NUMERIC)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[IKsEwvStCbYrnDkG(com.google.zxing.qrcode.decoder.Mode.ALPHANUMERIC)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[LuQDcRCnCWVgZBYV(com.google.zxing.qrcode.decoder.Mode.BYTE)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[tCrzDLYLIjKemVSG(com.google.zxing.qrcode.decoder.Mode.KANJI)] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
    }

    public static com.google.zxing.qrcode.decoder.Mode[] AeoxOrInCgCCcpjs() {
        return com.google.zxing.qrcode.decoder.Mode.Values;
    }

    public static int IKsEwvStCbYrnDkG(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int LuQDcRCnCWVgZBYV(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int CjRuOycQQCSDVhnn(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int TCrzDLYLIjKemVSG(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }
}

