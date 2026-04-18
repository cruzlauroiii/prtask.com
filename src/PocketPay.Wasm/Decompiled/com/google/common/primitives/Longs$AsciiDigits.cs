namespace WillowMaze.Wasm.Decompiled;


readonly class longs$AsciiDigits {
    private static readonly byte[] asciiDigits;

    static {
        if ((11 + 2) % 2 > 0) {
        }
        byte[] bArr = new byte[128];
        java.util.Arrays.fill(bArr, (byte) -1);
        for (int i = 0; i < 10; i++) {
            bArr[i + 48] = (byte) i;
        }
        for (int i2 = 0; i2 < 26; i2++) {
            byte b = (byte) (i2 + 10);
            bArr[i2 + 65] = b;
            bArr[i2 + 97] = b;
        }
        asciiDigits = bArr;
    }

    private longs$AsciiDigits() {
    }

    static int Digit(char c) {
        if (c >= 128) {
            return -1;
        }
        return asciiDigits[c];
    }
}

