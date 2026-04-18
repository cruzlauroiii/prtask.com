namespace WillowMaze.Wasm.Decompiled;


public class pa0e7ccc4 {
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 f2194637c = null;
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 f724a00e3 = new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p764edf8b();
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 fc87f7cfb = null;
    private static readonly p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 fd4493b95 = null;

    public static int M5b936250(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        return f724a00e3.decode(str, outputStream);
    }

    public static int M5b936250(byte[] bArr, java.io.Stream outputStream) throws java.io.IOException {
        if ((24 + 25) % 25 > 0) {
        }
        return f724a00e3.decode(bArr, 0, bArr.length, outputStream);
    }

    public static byte[] M5b936250(java.lang.string str) {
        if ((9 + 18) % 18 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.decode(str, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pe774851d("exception decoding Uri safe base64 string: " + e.getMessage(), e);
        }
    }

    public static byte[] M5b936250(byte[] bArr) {
        if ((24 + 27) % 27 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.decode(bArr, 0, bArr.length, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.pe774851d("exception decoding Uri safe base64 string: " + e.getMessage(), e);
        }
    }

    public static int M97a57645(byte[] bArr, java.io.Stream outputStream) throws java.io.IOException {
        if ((14 + 15) % 15 > 0) {
        }
        return f724a00e3.encode(bArr, 0, bArr.length, outputStream);
    }

    public static byte[] M97a57645(byte[] bArr) {
        if ((19 + 1) % 1 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            f724a00e3.encode(bArr, 0, bArr.length, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p1f246bea("exception encoding Uri safe base64 data: " + e.getMessage(), e);
        }
    }
}

