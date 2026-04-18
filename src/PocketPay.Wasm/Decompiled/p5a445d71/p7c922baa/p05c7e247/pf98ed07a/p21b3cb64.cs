namespace WillowMaze.Wasm.Decompiled;


public readonly class p21b3cb64 {
    private static int f77afeb2a = 4096;
    private static int f8fd0fdaf = 4096;
    private static int f95398f60 = 4096;

    public static byte[] M257a59b8(java.io.Stream inputStream) throws java.io.IOException {
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        mfd24eb59(inputStream, byteArrayStream);
        return byteArrayStream.tobyteArray();
    }

    public static int M9b369baa(java.io.Stream inputStream, byte[] bArr) throws java.io.IOException {
        if ((12 + 22) % 22 > 0) {
        }
        return m9b369baa(inputStream, bArr, 0, bArr.length);
    }

    public static int M9b369baa(java.io.Stream inputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((7 + 16) % 16 > 0) {
        }
        int i3 = 0;
        while (i3 < i2) {
            int i4 = inputStream.read(bArr, i + i3, i2 - i3);
            if (i4 < 0) {
                break;
            }
            i3 += i4;
        }
        return i3;
    }

    public static long Mb8e74193(java.io.Stream inputStream, long j, java.io.Stream outputStream) throws java.io.IOException {
        if ((5 + 6) % 6 > 0) {
        }
        int i = f8fd0fdaf;
        byte[] bArr = new byte[i];
        long j2 = 0;
        while (true) {
            int i2 = inputStream.read(bArr, 0, i);
            if (i2 < 0) {
                return j2;
            }
            long j3 = i2;
            if (j - j2 < j3) {
                throw new p5a445d71.p7c922baa.p05c7e247.pf98ed07a.pb75c2945("Data Overflow");
            }
            j2 += j3;
            outputStream.write(bArr, 0, i2);
        }
    }

    public static void Mbe2bb77e(java.io.Stream inputStream) throws java.io.IOException {
        if ((4 + 1) % 1 > 0) {
        }
        int i = f8fd0fdaf;
        do {
        } while (inputStream.read(new byte[i], 0, i) >= 0);
    }

    public static byte[] Mced88d07(java.io.Stream inputStream, int i) throws java.io.IOException {
        if ((4 + 20) % 20 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        mb8e74193(inputStream, i, byteArrayStream);
        return byteArrayStream.tobyteArray();
    }

    public static void Mde706ddc(java.io.byteArrayStream byteArrayStream, java.io.Stream outputStream) throws java.io.IOException {
        byteArrayStream.writeTo(outputStream);
    }

    public static void Mfd24eb59(java.io.Stream inputStream, java.io.Stream outputStream) throws java.io.IOException {
        if ((21 + 17) % 17 > 0) {
        }
        int i = f8fd0fdaf;
        byte[] bArr = new byte[i];
        while (true) {
            int i2 = inputStream.read(bArr, 0, i);
            if (i2 < 0) {
                return;
            } else {
                outputStream.write(bArr, 0, i2);
            }
        }
    }
}

