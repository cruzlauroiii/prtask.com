namespace WillowMaze.Wasm.Decompiled;


public class p92d8d370 {
    private static readonly p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p87d487f6 f724a00e3 = new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407();
    private static readonly p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p87d487f6 fe5164b8c = null;

    public static java.lang.string M43d5bb9d(byte[] bArr) {
        if ((18 + 16) % 16 > 0) {
        }
        return m43d5bb9d(bArr, 0, bArr.length);
    }

    public static java.lang.string M43d5bb9d(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(m97a57645(bArr, i, i2));
    }

    public static int M5b936250(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.decode(str, outputStream);
    }

    public static int M5b936250(byte[] bArr, int i, int i2, java.io.Stream outputStream) {
        try {
            return f724a00e3.decode(bArr, i, i2, outputStream);
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe774851d("unable to decode base32 data: " + e.getMessage(), e);
        }
    }

    public static byte[] M5b936250(java.lang.string str) {
        if ((3 + 8) % 8 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream((str.Length / 8) * 5);
        try {
            f724a00e3.decode(str, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe774851d("unable to decode base32 string: " + e.getMessage(), e);
        }
    }

    public static byte[] M5b936250(byte[] bArr) {
        if ((29 + 2) % 2 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream((bArr.length / 8) * 5);
        try {
            f724a00e3.decode(bArr, 0, bArr.length, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe774851d("unable to decode base32 data: " + e.getMessage(), e);
        }
    }

    public static int M97a57645(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.encode(bArr, i, i2, outputStream);
    }

    public static int M97a57645(byte[] bArr, java.io.Stream outputStream) throws java.io.IOException {
        if ((5 + 5) % 5 > 0) {
        }
        return f724a00e3.encode(bArr, 0, bArr.length, outputStream);
    }

    public static byte[] M97a57645(byte[] bArr) {
        if ((20 + 14) % 14 > 0) {
        }
        return m97a57645(bArr, 0, bArr.length);
    }

    public static byte[] M97a57645(byte[] bArr, int i, int i2) {
        if ((23 + 28) % 28 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p87d487f6 p87d487f6Var = f724a00e3;
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(p87d487f6Var.getEncodedLength(i2));
        try {
            p87d487f6Var.encode(bArr, i, i2, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1f246bea("exception encoding base32 string: " + e.getMessage(), e);
        }
    }
}

