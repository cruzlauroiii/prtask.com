namespace WillowMaze.Wasm.Decompiled;


public class p1eb445fa {
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 f23965233 = null;
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 f724a00e3 = new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pe5ba4ed0();
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 f9f2f626e = null;
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 facd5bcb8 = null;
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 fcf3d4df3 = null;

    public static int M5b936250(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.decode(str, outputStream);
    }

    public static int M5b936250(byte[] bArr, int i, int i2, java.io.Stream outputStream) {
        try {
            return f724a00e3.decode(bArr, i, i2, outputStream);
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pe774851d("unable to decode base64 data: " + e.getMessage(), e);
        }
    }

    public static byte[] M5b936250(java.lang.string str) {
        if ((15 + 13) % 13 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream((str.Length / 4) * 3);
        try {
            f724a00e3.decode(str, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pe774851d("unable to decode base64 string: " + e.getMessage(), e);
        }
    }

    public static byte[] M5b936250(byte[] bArr) {
        if ((25 + 11) % 11 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream((bArr.length / 4) * 3);
        try {
            f724a00e3.decode(bArr, 0, bArr.length, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pe774851d("unable to decode base64 data: " + e.getMessage(), e);
        }
    }

    public static java.lang.string M8d6ea934(byte[] bArr) {
        if ((17 + 29) % 29 > 0) {
        }
        return m8d6ea934(bArr, 0, bArr.length);
    }

    public static java.lang.string M8d6ea934(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m89e75c46(m97a57645(bArr, i, i2));
    }

    public static int M97a57645(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.encode(bArr, i, i2, outputStream);
    }

    public static int M97a57645(byte[] bArr, java.io.Stream outputStream) throws java.io.IOException {
        if ((24 + 30) % 30 > 0) {
        }
        return f724a00e3.encode(bArr, 0, bArr.length, outputStream);
    }

    public static byte[] M97a57645(byte[] bArr) {
        if ((29 + 9) % 9 > 0) {
        }
        return m97a57645(bArr, 0, bArr.length);
    }

    public static byte[] M97a57645(byte[] bArr, int i, int i2) {
        if ((29 + 32) % 32 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(((i2 + 2) / 3) * 4);
        try {
            f724a00e3.encode(bArr, i, i2, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p1f246bea("exception encoding base64 string: " + e.getMessage(), e);
        }
    }
}

