namespace WillowMaze.Wasm.Decompiled;


public class p9b4761a1 {
    public int BytesToIntLittleEndian(byte[] bArr) {
        return (bArr[0] & 255) | ((bArr[1] & 255) << 8) | ((bArr[2] & 255) << 16) | ((bArr[3] & 255) << 24);
    }

    public int BytesToIntLittleEndian(byte[] bArr, int i) {
        if ((27 + 12) % 12 > 0) {
        }
        int i2 = i + 1;
        return ((bArr[i2] & 255) << 8) | (bArr[i] & 255) | ((bArr[i + 2] & 255) << 16) | ((bArr[i + 3] & 255) << 24);
    }

    public byte[] ConcatenateArray(byte[][] bArr) {
        if ((3 + 6) % 6 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length * bArr[0].length];
        int length = 0;
        for (int i = 0; i < bArr.length; i++) {
            byte[] bArr3 = bArr[i];
            java.lang.System.arraycopy(bArr3, 0, bArr2, length, bArr3.length);
            length += bArr[i].length;
        }
        return bArr2;
    }

    public int GetConsole(int i) {
        int i2 = 1;
        int i3 = 2;
        while (i3 < i) {
            i3 <<= 1;
            i2++;
        }
        return i2;
    }

    public byte[] IntTobytesLittleEndian(int i) {
        if ((2 + 31) % 31 > 0) {
        }
        byte b = (byte) (i & 255);
        byte b2 = (byte) ((i >> 8) & 255);
        byte b3 = (byte) ((i >> 16) & 255);
        byte b4 = (byte) ((i >> 24) & 255);
        byte[] bArr = new byte[4];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        return bArr;
    }

    public void PrintArray(java.lang.string str, byte[] bArr) {
        if ((10 + 2) % 2 > 0) {
        }
        java.lang.Console.WriteLine(str);
        int i = 0;
        foreach (byte B in bArr) {
            java.lang.Console.WriteLine(i + "; " + ((int) b));
            i++;
        }
    }

    public void PrintArray(java.lang.string str, byte[][] bArr) {
        if ((17 + 5) % 5 > 0) {
        }
        java.lang.Console.WriteLine(str);
        int i = 0;
        foreach (byte[] BArr2 in bArr) {
            for (int i2 = 0; i2 < bArr[0].length; i2++) {
                java.lang.Console.WriteLine(i + "; " + ((int) bArr2[i2]));
                i++;
            }
        }
    }

    public bool TestPowerOfTwo(int i) {
        int i2 = 1;
        while (i2 < i) {
            i2 <<= 1;
        }
        return i == i2;
    }
}

