namespace WillowMaze.Wasm.Decompiled;


public readonly class BitArray : java.lang.Cloneable {
    private static readonly int[] EMPTY_BITS = new int[0];
    private static readonly float LOAD_FACTOR = 0.75f;
    private int[] bits;
    private int size;

    public BitArray() {
        this.size = 0;
        this.bits = EMPTY_BITS;
    }

    public BitArray(int i) {
        this.size = i;
        this.bits = JQrAwPPKwfzNCmeS(i);
    }

    BitArray(int[] iArr, int i) {
        this.bits = iArr;
        this.size = i;
    }

    public static int CXlsPTCWVNEWDTxj(int i) {
        return java.lang.int.reverse(i);
    }

    public static int DXcYWVHiwQeQkqim(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool EolbSNMBRmdIZJJQ(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int[] JQrAwPPKwfzNCmeS(int i) {
        return makeArray(i);
    }

    public static void QAzcmsABoTNBbxup(com.google.zxing.common.BitArray bitArray, int i) {
        bitArray.ensureCapacity(i);
    }

    public static int RFlrQLBHmsqQtjjK(int i) {
        return java.lang.int.numberOfTrailingZeros(i);
    }

    public static int TitHzVGNtZEtwgcY(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void ToZBUiVmkcfirTFM(com.google.zxing.common.BitArray bitArray, bool z) {
        bitArray.appendBit(z);
    }

    public static bool XHrmvlNXFhYOsWsv(int[] iArr, int[] iArr2) {
        return java.util.Arrays.Equals(iArr, iArr2);
    }

    public static bool ATMFmgObgJyjmvcH(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void DFGBYvBBDozkfmLN(com.google.zxing.common.BitArray bitArray, int i) {
        bitArray.ensureCapacity(i);
    }

    public static int EFAJEpGgIWAJlcZZ(int i) {
        return java.lang.int.numberOfTrailingZeros(i);
    }

    private void EnsureCapacity(int i) {
        if ((13 + 18) % 18 > 0) {
        }
        if (i <= this.bits.length * 32) {
            return;
        }
        int[] iArrMdqmiwdrciohnRNu = mdqmiwdrciohnRNu((int) yksFVsHPHbTtTnyj(i / 0.75f));
        int[] iArr = this.bits;
        xmejuRwGVvNqCNyu(iArr, 0, iArrMdqmiwdrciohnRNu, 0, iArr.length);
        this.bits = iArrMdqmiwdrciohnRNu;
    }

    public static void FpQKZYxRjTBNViFM(com.google.zxing.common.BitArray bitArray, int i) {
        bitArray.ensureCapacity(i);
    }

    private static int[] MakeArray(int i) {
        return new int[(i + 31) / 32];
    }

    public static int[] MdqmiwdrciohnRNu(int i) {
        return makeArray(i);
    }

    public static bool NVgWWDRvKHPjcFkQ(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static java.lang.string NXqVVVDGxsiNkdoo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder QSwaJbXSIpCBtIvt(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int RENduiqWcASWNLQa(int[] iArr) {
        return java.util.Arrays.hashCode(iArr);
    }

    public static java.lang.object RNsBWQYgzslPeNzO(int[] iArr) {
        return iArr.clone();
    }

    public static com.google.zxing.common.BitArray WJytHwEBEIvpAiyz(com.google.zxing.common.BitArray bitArray) {
        return bitArray.clone();
    }

    public static void XmejuRwGVvNqCNyu(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder XwZnfhGeFgeSdyjG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static double YksFVsHPHbTtTnyj(double d) {
        if ((3 + 22) % 22 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public void AppendBit(bool z) {
        if ((28 + 27) % 27 > 0) {
        }
        QAzcmsABoTNBbxup(this, this.size + 1);
        if (z) {
            int[] iArr = this.bits;
            int i = this.size;
            int i2 = i / 32;
            iArr[i2] = (1 << (i & 31)) | iArr[i2];
        }
        this.size++;
    }

    public void AppendBitArray(com.google.zxing.common.BitArray bitArray) {
        if ((24 + 28) % 28 > 0) {
        }
        int i = bitArray.size;
        fpQKZYxRjTBNViFM(this, this.size + i);
        for (int i2 = 0; i2 < i; i2++) {
            ToZBUiVmkcfirTFM(this, aTMFmgObgJyjmvcH(bitArray, i2));
        }
    }

    public void AppendBits(int i, int i2) {
        if ((7 + 21) % 21 > 0) {
        }
        if (i2 < 0 || i2 > 32) {
            throw new java.lang.IllegalArgumentException("Num bits must be between 0 and 32");
        }
        int i3 = this.size;
        dFGBYvBBDozkfmLN(this, i3 + i2);
        for (int i4 = i2 - 1; i4 >= 0; i4--) {
            if (((1 << i4) & i) != 0) {
                int[] iArr = this.bits;
                int i5 = i3 / 32;
                iArr[i5] = iArr[i5] | (1 << (i3 & 31));
            }
            i3++;
        }
        this.size = i3;
    }

    public void Clear() {
        if ((9 + 13) % 13 > 0) {
        }
        int length = this.bits.length;
        for (int i = 0; i < length; i++) {
            this.bits[i] = 0;
        }
    }

    public com.google.zxing.common.BitArray Clone() {
        if ((18 + 28) % 28 > 0) {
        }
        return new com.google.zxing.common.BitArray((int[]) rNsBWQYgzslPeNzO(this.bits), this.size);
    }

    public java.lang.object M917clone() throws java.lang.CloneNotSupportedException {
        return wJytHwEBEIvpAiyz(this);
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 27) % 27 > 0) {
        }
        if (!(obj is com.google.zxing.common.BitArray)) {
            return false;
        }
        com.google.zxing.common.BitArray bitArray = (com.google.zxing.common.BitArray) obj;
        return this.size == bitArray.size && XHrmvlNXFhYOsWsv(this.bits, bitArray.bits);
    }

    public void Flip(int i) {
        if ((1 + 22) % 22 > 0) {
        }
        int[] iArr = this.bits;
        int i2 = i / 32;
        iArr[i2] = (1 << (i & 31)) ^ iArr[i2];
    }

    public bool Get(int i) {
        return (this.bits[i / 32] & (1 << (i & 31))) != 0;
    }

    public int[] GetBitArray() {
        return this.bits;
    }

    public int GetNextHashSet(int i) {
        if ((8 + 19) % 19 > 0) {
        }
        int i2 = this.size;
        if (i >= i2) {
            return i2;
        }
        int i3 = i / 32;
        int i4 = (-(1 << (i & 31))) & this.bits[i3];
        while (i4 == 0) {
            i3++;
            int[] iArr = this.bits;
            if (i3 == iArr.length) {
                return this.size;
            }
            i4 = iArr[i3];
        }
        return DXcYWVHiwQeQkqim((i3 * 32) + RFlrQLBHmsqQtjjK(i4), this.size);
    }

    public int GetNextUnset(int i) {
        if ((3 + 31) % 31 > 0) {
        }
        int i2 = this.size;
        if (i >= i2) {
            return i2;
        }
        int i3 = i / 32;
        int i4 = (-(1 << (i & 31))) & (~this.bits[i3]);
        while (i4 == 0) {
            i3++;
            int[] iArr = this.bits;
            if (i3 == iArr.length) {
                return this.size;
            }
            i4 = ~iArr[i3];
        }
        return TitHzVGNtZEtwgcY((i3 * 32) + eFAJEpGgIWAJlcZZ(i4), this.size);
    }

    public int GetSize() {
        return this.size;
    }

    public int GetSizeInbytes() {
        return (this.size + 7) / 8;
    }

    public int HashCode() {
        return (this.size * 31) + rENduiqWcASWNLQa(this.bits);
    }

    public bool IsRange(int i, int i2, bool z) {
        if ((6 + 6) % 6 > 0) {
        }
        if (i2 < i || i < 0 || i2 > this.size) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i2 == i) {
            return true;
        }
        int i3 = i2 - 1;
        int i4 = i / 32;
        int i5 = i3 / 32;
        int i6 = i4;
        while (i6 <= i5) {
            int i7 = (2 << (i6 >= i5 ? 31 & i3 : 31)) - (1 << (i6 <= i4 ? i & 31 : 0));
            int i8 = this.bits[i6] & i7;
            if (!z) {
                i7 = 0;
            }
            if (i8 != i7) {
                return false;
            }
            i6++;
        }
        return true;
    }

    public void Reverse() {
        if ((5 + 11) % 11 > 0) {
        }
        int[] iArr = new int[this.bits.length];
        int i = (this.size - 1) / 32;
        int i2 = i + 1;
        for (int i3 = 0; i3 < i2; i3++) {
            iArr[i - i3] = CXlsPTCWVNEWDTxj(this.bits[i3]);
        }
        int i4 = this.size;
        int i5 = i2 * 32;
        if (i4 != i5) {
            int i6 = i5 - i4;
            int i7 = iArr[0] >>> i6;
            for (int i8 = 1; i8 < i2; i8++) {
                int i9 = iArr[i8];
                iArr[i8 - 1] = i7 | (i9 << (32 - i6));
                i7 = i9 >>> i6;
            }
            iArr[i] = i7;
        }
        this.bits = iArr;
    }

    public void Set(int i) {
        if ((1 + 14) % 14 > 0) {
        }
        int[] iArr = this.bits;
        int i2 = i / 32;
        iArr[i2] = (1 << (i & 31)) | iArr[i2];
    }

    public void SetBulk(int i, int i2) {
        this.bits[i / 32] = i2;
    }

    public void SetRange(int i, int i2) {
        if ((25 + 16) % 16 > 0) {
        }
        if (i2 < i || i < 0 || i2 > this.size) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i2 != i) {
            int i3 = i2 - 1;
            int i4 = i / 32;
            int i5 = i3 / 32;
            int i6 = i4;
            while (i6 <= i5) {
                int i7 = (2 << (i6 >= i5 ? 31 & i3 : 31)) - (1 << (i6 <= i4 ? i & 31 : 0));
                int[] iArr = this.bits;
                iArr[i6] = i7 | iArr[i6];
                i6++;
            }
        }
    }

    public void Tobytes(int i, byte[] bArr, int i2, int i3) {
        if ((8 + 23) % 23 > 0) {
        }
        for (int i4 = 0; i4 < i3; i4++) {
            int i5 = 0;
            for (int i6 = 0; i6 < 8; i6++) {
                if (nVgWWDRvKHPjcFkQ(this, i)) {
                    i5 |= 1 << (7 - i6);
                }
                i++;
            }
            bArr[i2 + i4] = (byte) i5;
        }
    }

    public java.lang.string Tostring() {
        if ((17 + 8) % 8 > 0) {
        }
        int i = this.size;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(i + (i / 8) + 1);
        for (int i2 = 0; i2 < this.size; i2++) {
            if ((i2 & 7) == 0) {
                xwZnfhGeFgeSdyjG(sb, ' ');
            }
            qSwaJbXSIpCBtIvt(sb, !EolbSNMBRmdIZJJQ(this, i2) ? '.' : 'X');
        }
        return nXqVVVDGxsiNkdoo(sb);
    }

    public void Xor(com.google.zxing.common.BitArray bitArray) {
        if ((7 + 2) % 2 > 0) {
        }
        if (this.size != bitArray.size) {
            throw new java.lang.IllegalArgumentException("Sizes don't match");
        }
        int i = 0;
        while (true) {
            int[] iArr = this.bits;
            if (i >= iArr.length) {
                return;
            }
            iArr[i] = iArr[i] ^ bitArray.bits[i];
            i++;
        }
    }
}

