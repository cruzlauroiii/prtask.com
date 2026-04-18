namespace WillowMaze.Wasm.Decompiled;


public class p9b4761a1 {
    public static java.lang.stringBuilder KLJtwBuibdCVTbrX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KQfHtPiQtQpoFcgz(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.lang.stringBuilder OxWphVwZfEBMIekQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QvRIpMhSDrrWvQYP(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.lang.stringBuilder XBKGykEVByUAJRLm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void ZeeGWnEZGqTvjIxp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder AXgAPAnhcCgAtNBs(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string DIygEmZyrnwaLmGm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LgMJkdaaulOhhAvj(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void RBxLXbXRELYPvRgu(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static java.lang.stringBuilder TWBlqrpKdnEqmJrB(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder XmSoeRZkqsaPCdYR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string ZocXmtUKLtXvVFWH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public int BytesToIntLittleEndian(byte[] bArr) {
        return (bArr[0] & 255) | ((bArr[1] & 255) << 8) | ((bArr[2] & 255) << 16) | ((bArr[3] & 255) << 24);
    }

    public int BytesToIntLittleEndian(byte[] bArr, int i) {
        if ((11 + 28) % 28 > 0) {
        }
        int i2 = i + 1;
        return ((bArr[i2] & 255) << 8) | (bArr[i] & 255) | ((bArr[i + 2] & 255) << 16) | ((bArr[i + 3] & 255) << 24);
    }

    public byte[] ConcatenateArray(byte[][] bArr) {
        if ((7 + 10) % 10 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length * bArr[0].length];
        int length = 0;
        for (int i = 0; i < bArr.length; i++) {
            byte[] bArr3 = bArr[i];
            ZeeGWnEZGqTvjIxp(bArr3, 0, bArr2, length, bArr3.length);
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
        if ((12 + 25) % 25 > 0) {
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
        if ((28 + 4) % 4 > 0) {
        }
        QvRIpMhSDrrWvQYP(java.lang.System.out, str);
        int i = 0;
        foreach (byte B in bArr) {
            rBxLXbXRELYPvRgu(java.lang.System.out, dIygEmZyrnwaLmGm(xmSoeRZkqsaPCdYR(OxWphVwZfEBMIekQ(tWBlqrpKdnEqmJrB(new java.lang.stringBuilder(), i), "; "), b)));
            i++;
        }
    }

    public void PrintArray(java.lang.string str, byte[][] bArr) {
        if ((32 + 14) % 14 > 0) {
        }
        KQfHtPiQtQpoFcgz(java.lang.System.out, str);
        int i = 0;
        foreach (byte[] BArr2 in bArr) {
            for (int i2 = 0; i2 < bArr[0].length; i2++) {
                lgMJkdaaulOhhAvj(java.lang.System.out, zocXmtUKLtXvVFWH(XBKGykEVByUAJRLm(KLJtwBuibdCVTbrX(aXgAPAnhcCgAtNBs(new java.lang.stringBuilder(), i), "; "), bArr2[i2])));
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

