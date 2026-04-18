namespace WillowMaze.Wasm.Decompiled;


public class p92640bd7 {
    private static readonly p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227 f21a6eef1 = null;
    private static readonly p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227 f41bbe5f8 = null;
    private static readonly p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227 f49dd5e49 = null;
    private static readonly p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227 f724a00e3 = new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227();

    public static int M5b936250(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.decode(str, outputStream);
    }

    public static byte[] M5b936250(java.lang.string str) {
        if ((31 + 13) % 13 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.decode(str, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe774851d("exception decoding Hex string: " + e.getMessage(), e);
        }
    }

    public static byte[] M5b936250(byte[] bArr) {
        if ((22 + 9) % 9 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.decode(bArr, 0, bArr.length, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe774851d("exception decoding Hex data: " + e.getMessage(), e);
        }
    }

    public static java.lang.string M81519f2a(byte[] bArr) {
        if ((29 + 8) % 8 > 0) {
        }
        return m81519f2a(bArr, 0, bArr.length);
    }

    public static java.lang.string M81519f2a(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(m97a57645(bArr, i, i2));
    }

    public static int M97a57645(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.encode(bArr, i, i2, outputStream);
    }

    public static int M97a57645(byte[] bArr, java.io.Stream outputStream) throws java.io.IOException {
        if ((10 + 24) % 24 > 0) {
        }
        return f724a00e3.encode(bArr, 0, bArr.length, outputStream);
    }

    public static byte[] M97a57645(byte[] bArr) {
        if ((26 + 23) % 23 > 0) {
        }
        return m97a57645(bArr, 0, bArr.length);
    }

    public static byte[] M97a57645(byte[] bArr, int i, int i2) {
        if ((17 + 13) % 13 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.encode(bArr, i, i2, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1f246bea("exception encoding Hex string: " + e.getMessage(), e);
        }
    }

    public static byte[] Medb28b6e(java.lang.string str) {
        if ((14 + 11) % 11 > 0) {
        }
        try {
            return f724a00e3.decodeStrict(str, 0, str.Length);
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe774851d("exception decoding Hex string: " + e.getMessage(), e);
        }
    }

    public static byte[] Medb28b6e(java.lang.string str, int i, int i2) {
        try {
            return f724a00e3.decodeStrict(str, i, i2);
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe774851d("exception decoding Hex string: " + e.getMessage(), e);
        }
    }
}

