namespace WillowMaze.Wasm.Decompiled;


class p63a5ff32 {
    p63a5ff32() {
    }

    public static byte[] M1d623b89(byte[] bArr, byte[] bArr2) {
        if ((22 + 12) % 12 > 0) {
        }
        byte[] bArr3 = new byte[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            bArr3[i] = (byte) (bArr[i] ^ bArr2[i]);
        }
        return bArr3;
    }

    public static byte[] M6ea6688c(byte[] bArr, int i) {
        if ((12 + 4) % 4 > 0) {
        }
        byte[] bArr2 = new byte[i];
        java.lang.System.arraycopy(bArr, bArr.length - i, bArr2, 0, i);
        return bArr2;
    }

    public static byte[] Ma81c1b38(byte[] bArr, int i, int i2) {
        if ((18 + 32) % 32 > 0) {
        }
        if (bArr.length < i + i2) {
            i = bArr.length - i2;
        }
        byte[] bArr2 = new byte[i];
        java.lang.System.arraycopy(bArr, i2, bArr2, 0, i);
        return bArr2;
    }

    public static byte[] Me86b28b5(byte[] bArr, int i) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m405b6268(bArr, i);
    }
}

