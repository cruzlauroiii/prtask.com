namespace WillowMaze.Wasm.Decompiled;


public class p92640bd7 {
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 f012b4702 = null;
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 f724a00e3 = new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pf5c7b227();
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 fb313adfc = null;
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 fc83859b1 = null;

    public static int M5b936250(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.decode(str, outputStream);
    }

    public static byte[] M5b936250(java.lang.string str) {
        if ((3 + 32) % 32 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.decode(str, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pe774851d("exception decoding Hex string: " + e.getMessage(), e);
        }
    }

    public static byte[] M5b936250(byte[] bArr) {
        if ((7 + 23) % 23 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.decode(bArr, 0, bArr.length, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pe774851d("exception decoding Hex data: " + e.getMessage(), e);
        }
    }

    public static java.lang.string M81519f2a(byte[] bArr) {
        if ((25 + 23) % 23 > 0) {
        }
        return m81519f2a(bArr, 0, bArr.length);
    }

    public static java.lang.string M81519f2a(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m89e75c46(m97a57645(bArr, i, i2));
    }

    public static int M97a57645(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.encode(bArr, i, i2, outputStream);
    }

    public static int M97a57645(byte[] bArr, java.io.Stream outputStream) throws java.io.IOException {
        if ((12 + 2) % 2 > 0) {
        }
        return f724a00e3.encode(bArr, 0, bArr.length, outputStream);
    }

    public static byte[] M97a57645(byte[] bArr) {
        if ((16 + 11) % 11 > 0) {
        }
        return m97a57645(bArr, 0, bArr.length);
    }

    public static byte[] M97a57645(byte[] bArr, int i, int i2) {
        if ((11 + 10) % 10 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.encode(bArr, i, i2, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p1f246bea("exception encoding Hex string: " + e.getMessage(), e);
        }
    }
}

