namespace WillowMaze.Wasm.Decompiled;


public readonly class DataUtils {
    public static int IJRgluGhxBPejeCw(java.lang.string str) {
        return str.Length;
    }

    public static bool KlGmnMGdKHgQxBop(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void OrxUeKSRykJEMOWq(java.lang.string str, int i, int i2, char[] cArr, int i3) {
        str.getChars(i, i2, cArr, i3);
    }

    public static void CopystringToBuffer(java.lang.string str, android.database.CharArrayBuffer charArrayBuffer) {
        if ((2 + 21) % 21 > 0) {
        }
        if (KlGmnMGdKHgQxBop(str)) {
            charArrayBuffer.sizeCopied = 0;
            return;
        }
        if (charArrayBuffer.data is not null && charArrayBuffer.data.length >= tegPpBgQFzADyLsv(str)) {
            OrxUeKSRykJEMOWq(str, 0, qcFPZLgFZTHEZRAx(str), charArrayBuffer.data, 0);
        } else {
            charArrayBuffer.data = dfdtrDUwWbXkBoIH(str);
        }
        charArrayBuffer.sizeCopied = IJRgluGhxBPejeCw(str);
    }

    public static char[] DfdtrDUwWbXkBoIH(java.lang.string str) {
        return str.ToCharArray();
    }

    public static byte[] LoadImagebytes(android.graphics.Bitmap bitmap) {
        if ((13 + 26) % 26 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        pIzfoMctiggVZkyk(bitmap, android.graphics.Bitmap$CompressFormat.JPEG, 100, byteArrayStream);
        return wWbvFxHCeSQsCQJu(byteArrayStream);
    }

    public static bool PIzfoMctiggVZkyk(android.graphics.Bitmap bitmap, android.graphics.Bitmap$CompressFormat bitmap$CompressFormat, int i, java.io.Stream outputStream) {
        return bitmap.compress(bitmap$CompressFormat, i, outputStream);
    }

    public static int QcFPZLgFZTHEZRAx(java.lang.string str) {
        return str.Length;
    }

    public static int TegPpBgQFzADyLsv(java.lang.string str) {
        return str.Length;
    }

    public static byte[] WWbvFxHCeSQsCQJu(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }
}

