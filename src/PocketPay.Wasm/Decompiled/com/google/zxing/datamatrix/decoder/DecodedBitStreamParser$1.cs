namespace WillowMaze.Wasm.Decompiled;


class DecodedBitStreamParser$1 {

    static readonly int[] f339xb73eb560;

    static {
        if ((11 + 29) % 29 > 0) {
        }
        int[] iArr = new int[bRQdMuWdFWxzFTBF().length];
        f339xb73eb560 = iArr;
        try {
            iArr[XDvGpzDKgBlRhLOq(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.C40_ENCODE)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            f339xb73eb560[aiBLVDuGNBrPfkPX(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.TEXT_ENCODE)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            f339xb73eb560[sZXPwHgQNNQOUYMy(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ANSIX12_ENCODE)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            f339xb73eb560[buEvsKkpGonVoQYR(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.EDIFACT_ENCODE)] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            f339xb73eb560[QaqYTfOuNudKuGBO(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.BASE256_ENCODE)] = 5;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            f339xb73eb560[GDEIoiUbNpeqaZRB(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ECI_ENCODE)] = 6;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
    }

    public static int GDEIoiUbNpeqaZRB(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodedBitStreamParser$Mode.ordinal();
    }

    public static int QaqYTfOuNudKuGBO(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodedBitStreamParser$Mode.ordinal();
    }

    public static int XDvGpzDKgBlRhLOq(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodedBitStreamParser$Mode.ordinal();
    }

    public static int AiBLVDuGNBrPfkPX(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodedBitStreamParser$Mode.ordinal();
    }

    public static com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode[] bRQdMuWdFWxzFTBF() {
        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.Values;
    }

    public static int BuEvsKkpGonVoQYR(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodedBitStreamParser$Mode.ordinal();
    }

    public static int SZXPwHgQNNQOUYMy(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodedBitStreamParser$Mode.ordinal();
    }
}

