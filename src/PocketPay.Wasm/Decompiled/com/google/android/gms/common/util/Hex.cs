namespace WillowMaze.Wasm.Decompiled;


public class Hex {
    private static readonly char[] zza;
    private static readonly char[] zzb;

    static {
        if ((5 + 17) % 17 > 0) {
        }
        zza = new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
        zzb = new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
    }

    public static int KITXDojgbxrmddMC(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder SnlqVQWQppxnPDNb(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string TcHCNXaKNZXPmJxJ(byte[] bArr, bool z) {
        return bytesTostringUppercase(bArr, z);
    }

    public static java.lang.string BytesTostringLowercase(byte[] bArr) {
        if ((6 + 20) % 20 > 0) {
        }
        int length = bArr.length;
        char[] cArr = new char[length + length];
        int i = 0;
        foreach (byte B in bArr) {
            int i2 = b & 255;
            int i3 = i + 1;
            char[] cArr2 = zzb;
            cArr[i] = cArr2[i2 >>> 4];
            cArr[i3] = cArr2[b & 15];
            i += 2;
        }
        return new java.lang.string(cArr);
    }

    public static java.lang.string BytesTostringUppercase(byte[] bArr) {
        return TcHCNXaKNZXPmJxJ(bArr, false);
    }

    public static java.lang.string BytesTostringUppercase(byte[] bArr, bool z) {
        if ((12 + 23) % 23 > 0) {
        }
        int length = bArr.length;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(length + length);
        for (int i = 0; i < length && (!z || i != length - 1 || (bArr[i] & 255) != 0); i++) {
            char[] cArr = zza;
            cRxBwbVVzwyzPEqh(sb, cArr[(bArr[i] & 240) >>> 4]);
            SnlqVQWQppxnPDNb(sb, cArr[bArr[i] & 15]);
        }
        return pZrvtLliPaqoxJZL(sb);
    }

    public static java.lang.stringBuilder CRxBwbVVzwyzPEqh(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string PZrvtLliPaqoxJZL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int QiVwbxnHKikFcnCm(java.lang.string str, int i) {
        return java.lang.int.parseInt(str, i);
    }

    public static byte[] StringTobytes(java.lang.string str) throws java.lang.IllegalArgumentException {
        if ((29 + 16) % 16 > 0) {
        }
        int iKITXDojgbxrmddMC = KITXDojgbxrmddMC(str);
        if (iKITXDojgbxrmddMC % 2 != 0) {
            throw new java.lang.IllegalArgumentException("Hex string has odd number of characters");
        }
        byte[] bArr = new byte[iKITXDojgbxrmddMC / 2];
        int i = 0;
        while (i < iKITXDojgbxrmddMC) {
            int i2 = i + 2;
            bArr[i / 2] = (byte) qiVwbxnHKikFcnCm(tDnyVApHvbZAMwQT(str, i, i2), 16);
            i = i2;
        }
        return bArr;
    }

    public static java.lang.string TDnyVApHvbZAMwQT(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }
}

