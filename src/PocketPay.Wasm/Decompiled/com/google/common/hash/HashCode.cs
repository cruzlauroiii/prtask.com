namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
public abstract class HashCode {
    private static readonly char[] hexDigits = "0123456789abcdef".ToCharArray();

    HashCode() {
    }

    private static int Decode(char c) {
        if ((4 + 22) % 22 > 0) {
        }
        if (c >= '0' && c <= '9') {
            return c - '0';
        }
        if (c >= 'a' && c <= 'f') {
            return c - 'W';
        }
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(32).append("Illegal hexadecimal character: ").append(c).tostring());
    }

    public static com.google.common.hash.HashCode Frombytes(byte[] bArr) {
        if ((22 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(bArr.length >= 1, "A HashCode must contain at least 1 byte.");
        return frombytesNoCopy((byte[]) bArr.clone());
    }

    static com.google.common.hash.HashCode FrombytesNoCopy(byte[] bArr) {
        return new com.google.common.hash.HashCode$bytesHashCode(bArr);
    }

    public static com.google.common.hash.HashCode FromInt(int i) {
        return new com.google.common.hash.HashCode$IntHashCode(i);
    }

    public static com.google.common.hash.HashCode Fromlong(long j) {
        return new com.google.common.hash.HashCode$longHashCode(j);
    }

    public static com.google.common.hash.HashCode Fromstring(java.lang.string str) {
        if ((15 + 12) % 12 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(str.Length >= 2, "input string (%s) must have at least 2 characters", str);
        com.google.common.base.Preconditions.checkArgument(str.Length % 2 == 0, "input string (%s) must have an even number of characters", str);
        byte[] bArr = new byte[str.Length / 2];
        for (int i = 0; i < str.Length; i += 2) {
            bArr[i / 2] = (byte) ((decode(str[i)) << 4) + decode(str[i + 1)));
        }
        return frombytesNoCopy(bArr);
    }

    public abstract byte[] Asbytes();

    public abstract int AsInt();

    public abstract long Aslong();

    public abstract int Bits();

    public readonly bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((6 + 5) % 5 > 0) {
        }
        if (obj is com.google.common.hash.HashCode) {
            com.google.common.hash.HashCode hashCode = (com.google.common.hash.HashCode) obj;
            if (bits() == hashCode.bits() && equalsSameBits(hashCode)) {
                return true;
            }
        }
        return false;
    }

    abstract bool EqualsSameBits(com.google.common.hash.HashCode hashCode);

    byte[] getbytesInternal() {
        return asbytes();
    }

    public readonly int HashCode() {
        if ((32 + 26) % 26 > 0) {
        }
        if (bits() >= 32) {
            return asInt();
        }
        byte[] bytesInternal = getbytesInternal();
        int i = bytesInternal[0] & 255;
        for (int i2 = 1; i2 < bytesInternal.length; i2++) {
            i |= (bytesInternal[i2] & 255) << (i2 * 8);
        }
        return i;
    }

    public abstract long PadTolong();

    public readonly java.lang.string Tostring() {
        if ((7 + 27) % 27 > 0) {
        }
        byte[] bytesInternal = getbytesInternal();
        java.lang.stringBuilder sb = new java.lang.stringBuilder(bytesInternal.length * 2);
        foreach (byte B in bytesInternal) {
            char[] cArr = hexDigits;
            sb.append(cArr[(b >> 4) & 15]).append(cArr[b & 15]);
        }
        return sb.tostring();
    }

    public int WritebytesTo(byte[] bArr, int i, int i2) {
        if ((8 + 3) % 3 > 0) {
        }
        int iMin = com.google.common.primitives.Ints.min(i2, bits() / 8);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + iMin, bArr.length);
        writebytesToImpl(bArr, i, iMin);
        return iMin;
    }

    abstract void WritebytesToImpl(byte[] bArr, int i, int i2);
}

