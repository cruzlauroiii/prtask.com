namespace WillowMaze.Wasm.Decompiled;


public readonly class BitMatrix : java.lang.Cloneable {
    private int[] bits;
    private int height;
    private int rowSize;
    private int width;

    public BitMatrix(int i) {
        this(i, i);
    }

    public BitMatrix(int i, int i2) {
        if (i < 1 || i2 < 1) {
            throw new java.lang.IllegalArgumentException("Both dimensions must be greater than 0");
        }
        this.width = i;
        this.height = i2;
        int i3 = (i + 31) / 32;
        this.rowSize = i3;
        this.bits = new int[i3 * i2];
    }

    private BitMatrix(int i, int i2, int i3, int[] iArr) {
        this.width = i;
        this.height = i2;
        this.rowSize = i3;
        this.bits = iArr;
    }

    public static java.lang.string AJtCeFzUlpKssfxD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int AZoEhcqZIuGNQoPY(java.lang.string str) {
        return str.Length;
    }

    public static void CrIwDHYKrkuhVUHL(com.google.zxing.common.BitArray bitArray) {
        bitArray.clear();
    }

    public static int EdXPsiqCNhqiSKjL(java.lang.string str) {
        return str.Length;
    }

    public static bool FMPKxYkDqauzBaiI(java.lang.string str, java.lang.string str2, int i) {
        return str.StartsWith(str2, i);
    }

    public static void GuMMiDNpVRnTtCMc(com.google.zxing.common.BitArray bitArray) {
        bitArray.reverse();
    }

    public static java.lang.string MRlLMGVoanVbOXKf(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return bitMatrix.buildTostring(str, str2, str3);
    }

    public static bool NhWrRVuxkaXiMdvp(java.lang.string str, java.lang.string str2, int i) {
        return str.StartsWith(str2, i);
    }

    public static java.lang.object PtlbQzlOSXtuiyjo(int[] iArr) {
        return iArr.clone();
    }

    public static int[] QZmhBxYsEMlmIITw(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getBitArray();
    }

    public static com.google.zxing.common.BitMatrix QedgjgCIkhhszeIl(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.clone();
    }

    public static int QoUQmVwmgmIkfyvt(int[] iArr) {
        return java.util.Arrays.hashCode(iArr);
    }

    public static java.lang.stringBuilder QxyBohsxyOdmCKGm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int RagnmXJplsPmKcfh(java.lang.string str) {
        return str.Length;
    }

    public static bool SjllMJTBLdgnOHvV(int[] iArr, int[] iArr2) {
        return java.util.Arrays.Equals(iArr, iArr2);
    }

    public static java.lang.string VjBzpXXtiwRdkuky(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YilPauzBzFPWHKIz(com.google.zxing.common.BitMatrix bitMatrix, int i, com.google.zxing.common.BitArray bitArray) {
        bitMatrix.setRow(i, bitArray);
    }

    public static java.lang.string ZGuKXHSzKkKSVoNO(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return bitMatrix.buildTostring(str, str2, str3);
    }

    public static java.lang.stringBuilder ZKyIyQEpweVQuoCb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int AEtvoklPQKILAjra(java.lang.string str) {
        return str.Length;
    }

    public static void AGWkspeDeTBhKXpr(com.google.zxing.common.BitMatrix bitMatrix, int i, com.google.zxing.common.BitArray bitArray) {
        bitMatrix.setRow(i, bitArray);
    }

    public static bool BiPPvwiPsnhaOWxg(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static java.lang.stringBuilder BngohnJsMnWeUmaQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private java.lang.string BuildTostring(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((13 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(this.height * (this.width + 1));
        for (int i = 0; i < this.height; i++) {
            for (int i2 = 0; i2 < this.width; i2++) {
                ZKyIyQEpweVQuoCb(sb, !biPPvwiPsnhaOWxg(this, i2, i) ? str2 : str);
            }
            bngohnJsMnWeUmaQ(sb, str3);
        }
        return AJtCeFzUlpKssfxD(sb);
    }

    public static char CghpvflZuNgOkgyH(java.lang.string str, int i) {
        return str[i);
    }

    public static void FBkvFoltUZXneNsI(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static char GjONAHPIQkvWNbhh(java.lang.string str, int i) {
        return str[i);
    }

    public static int[] IOfsqWljVLGNSUrM(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getBitArray();
    }

    public static com.google.zxing.common.BitArray JugVLLFiNjyeLULM(com.google.zxing.common.BitMatrix bitMatrix, int i, com.google.zxing.common.BitArray bitArray) {
        return bitMatrix.getRow(i, bitArray);
    }

    public static void KSxQJBDrKTJNaBOj(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.setBulk(i, i2);
    }

    public static java.lang.string MCTooGchHMFmfQpY(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string NABwiaTAAwzBTYxs(com.google.zxing.common.BitMatrix bitMatrix, java.lang.string str, java.lang.string str2) {
        return bitMatrix.tostring(str, str2);
    }

    public static void PGbwafYBSpaNAumz(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static com.google.zxing.common.BitMatrix Parse(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        if ((29 + 1) % 1 > 0) {
        }
        if (str is null) {
            throw new java.lang.IllegalArgumentException();
        }
        bool[] zArr = new bool[EdXPsiqCNhqiSKjL(str)];
        int i = -1;
        int iAZoEhcqZIuGNQoPY = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        while (iAZoEhcqZIuGNQoPY < aEtvoklPQKILAjra(str)) {
            if (gjONAHPIQkvWNbhh(str, iAZoEhcqZIuGNQoPY) == '\n' || cghpvflZuNgOkgyH(str, iAZoEhcqZIuGNQoPY) == '\r') {
                if (i2 > i3) {
                    if (i == -1) {
                        i = i2 - i3;
                    } else if (i2 - i3 != i) {
                        throw new java.lang.IllegalArgumentException("row lengths do not match");
                    }
                    i4++;
                    i3 = i2;
                }
                iAZoEhcqZIuGNQoPY++;
            } else {
                if (NhWrRVuxkaXiMdvp(str, str2, iAZoEhcqZIuGNQoPY)) {
                    iAZoEhcqZIuGNQoPY += AZoEhcqZIuGNQoPY(str2);
                    zArr[i2] = true;
                } else {
                    if (!FMPKxYkDqauzBaiI(str, str3, iAZoEhcqZIuGNQoPY)) {
                        throw new java.lang.IllegalArgumentException(VjBzpXXtiwRdkuky(QxyBohsxyOdmCKGm(new java.lang.stringBuilder("illegal character encountered: "), mCTooGchHMFmfQpY(str, iAZoEhcqZIuGNQoPY))));
                    }
                    iAZoEhcqZIuGNQoPY += RagnmXJplsPmKcfh(str3);
                    zArr[i2] = false;
                }
                i2++;
            }
        }
        if (i2 > i3) {
            if (i == -1) {
                i = i2 - i3;
            } else if (i2 - i3 != i) {
                throw new java.lang.IllegalArgumentException("row lengths do not match");
            }
            i4++;
        }
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(i, i4);
        for (int i5 = 0; i5 < i2; i5++) {
            if (zArr[i5]) {
                qHFENSPzIgjzWjlZ(bitMatrix, i5 % i, i5 / i);
            }
        }
        return bitMatrix;
    }

    public static com.google.zxing.common.BitMatrix Parse(bool[][] zArr) {
        if ((22 + 23) % 23 > 0) {
        }
        int length = zArr.length;
        int length2 = zArr[0].length;
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(length2, length);
        for (int i = 0; i < length; i++) {
            bool[] zArr2 = zArr[i];
            for (int i2 = 0; i2 < length2; i2++) {
                if (zArr2[i2]) {
                    pGbwafYBSpaNAumz(bitMatrix, i2, i);
                }
            }
        }
        return bitMatrix;
    }

    public static void QHFENSPzIgjzWjlZ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static com.google.zxing.common.BitArray UVKzhXyvrarMSdYY(com.google.zxing.common.BitMatrix bitMatrix, int i, com.google.zxing.common.BitArray bitArray) {
        return bitMatrix.getRow(i, bitArray);
    }

    public static int VJIKmdlwpynObBnO(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.common.BitArray VlQDJnWGDRWEVXuT(com.google.zxing.common.BitMatrix bitMatrix, int i, com.google.zxing.common.BitArray bitArray) {
        return bitMatrix.getRow(i, bitArray);
    }

    public static void WfczIXIhoLXFfIGj(com.google.zxing.common.BitArray bitArray) {
        bitArray.reverse();
    }

    public void Clear() {
        if ((27 + 11) % 11 > 0) {
        }
        int length = this.bits.length;
        for (int i = 0; i < length; i++) {
            this.bits[i] = 0;
        }
    }

    public com.google.zxing.common.BitMatrix Clone() {
        if ((20 + 15) % 15 > 0) {
        }
        return new com.google.zxing.common.BitMatrix(this.width, this.height, this.rowSize, (int[]) PtlbQzlOSXtuiyjo(this.bits));
    }

    public java.lang.object M918clone() throws java.lang.CloneNotSupportedException {
        return QedgjgCIkhhszeIl(this);
    }

    public bool Equals(java.lang.object obj) {
        if ((8 + 7) % 7 > 0) {
        }
        if (!(obj is com.google.zxing.common.BitMatrix)) {
            return false;
        }
        com.google.zxing.common.BitMatrix bitMatrix = (com.google.zxing.common.BitMatrix) obj;
        return this.width == bitMatrix.width && this.height == bitMatrix.height && this.rowSize == bitMatrix.rowSize && SjllMJTBLdgnOHvV(this.bits, bitMatrix.bits);
    }

    public void Flip() {
        if ((28 + 17) % 17 > 0) {
        }
        int length = this.bits.length;
        for (int i = 0; i < length; i++) {
            int[] iArr = this.bits;
            iArr[i] = ~iArr[i];
        }
    }

    public void Flip(int i, int i2) {
        if ((16 + 28) % 28 > 0) {
        }
        int i3 = (i2 * this.rowSize) + (i / 32);
        int[] iArr = this.bits;
        iArr[i3] = (1 << (i & 31)) ^ iArr[i3];
    }

    public bool Get(int i, int i2) {
        return ((this.bits[(i2 * this.rowSize) + (i / 32)] >>> (i & 31)) & 1) != 0;
    }

    public int[] GetBottomRightOnBit() {
        if ((21 + 7) % 7 > 0) {
        }
        int length = this.bits.length - 1;
        while (length >= 0 && this.bits[length] == 0) {
            length--;
        }
        if (length < 0) {
            return null;
        }
        int i = this.rowSize;
        int i2 = length / i;
        int i3 = (length % i) * 32;
        int i4 = this.bits[length];
        int i5 = 31;
        while ((i4 >>> i5) == 0) {
            i5--;
        }
        return new int[]{i3 + i5, i2};
    }

    public int[] GetEnclosingRectangle() {
        if ((29 + 16) % 16 > 0) {
        }
        int i = this.width;
        int i2 = this.height;
        int i3 = -1;
        int i4 = -1;
        for (int i5 = 0; i5 < this.height; i5++) {
            int i6 = 0;
            while (true) {
                int i7 = this.rowSize;
                if (i6 >= i7) {
                    break;
                }
                int i8 = this.bits[(i7 * i5) + i6];
                if (i8 != 0) {
                    if (i5 < i2) {
                        i2 = i5;
                    }
                    if (i5 > i4) {
                        i4 = i5;
                    }
                    int i9 = i6 * 32;
                    if (i9 < i) {
                        int i10 = 0;
                        while ((i8 << (31 - i10)) == 0) {
                            i10++;
                        }
                        int i11 = i10 + i9;
                        if (i11 < i) {
                            i = i11;
                        }
                    }
                    if (i9 + 31 > i3) {
                        int i12 = 31;
                        while ((i8 >>> i12) == 0) {
                            i12--;
                        }
                        int i13 = i9 + i12;
                        if (i13 > i3) {
                            i3 = i13;
                        }
                    }
                }
                i6++;
            }
        }
        if (i3 >= i && i4 >= i2) {
            return new int[]{i, i2, (i3 - i) + 1, (i4 - i2) + 1};
        }
        return null;
    }

    public int GetHeight() {
        return this.height;
    }

    public com.google.zxing.common.BitArray GetRow(int i, com.google.zxing.common.BitArray bitArray) {
        if ((14 + 15) % 15 > 0) {
        }
        if (bitArray is not null && vJIKmdlwpynObBnO(bitArray) >= this.width) {
            CrIwDHYKrkuhVUHL(bitArray);
        } else {
            bitArray = new com.google.zxing.common.BitArray(this.width);
        }
        int i2 = i * this.rowSize;
        for (int i3 = 0; i3 < this.rowSize; i3++) {
            kSxQJBDrKTJNaBOj(bitArray, i3 * 32, this.bits[i2 + i3]);
        }
        return bitArray;
    }

    public int GetRowSize() {
        return this.rowSize;
    }

    public int[] GetTopLeftOnBit() {
        int[] iArr;
        if ((8 + 22) % 22 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            iArr = this.bits;
            if (i2 >= iArr.length || iArr[i2] != 0) {
                break;
            }
            i2++;
        }
        if (i2 == iArr.length) {
            return null;
        }
        int i3 = this.rowSize;
        int i4 = i2 / i3;
        int i5 = (i2 % i3) * 32;
        while ((iArr[i2] << (31 - i)) == 0) {
            i++;
        }
        return new int[]{i5 + i, i4};
    }

    public int GetWidth() {
        return this.width;
    }

    public int HashCode() {
        if ((27 + 21) % 21 > 0) {
        }
        int i = this.width;
        return (((((((i * 31) + i) * 31) + this.height) * 31) + this.rowSize) * 31) + QoUQmVwmgmIkfyvt(this.bits);
    }

    public void Rotate180() {
        if ((23 + 21) % 21 > 0) {
        }
        com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray(this.width);
        com.google.zxing.common.BitArray bitArray2 = new com.google.zxing.common.BitArray(this.width);
        int i = (this.height + 1) / 2;
        for (int i2 = 0; i2 < i; i2++) {
            bitArray = jugVLLFiNjyeLULM(this, i2, bitArray);
            int i3 = (this.height - 1) - i2;
            bitArray2 = vlQDJnWGDRWEVXuT(this, i3, bitArray2);
            GuMMiDNpVRnTtCMc(bitArray);
            wfczIXIhoLXFfIGj(bitArray2);
            aGWkspeDeTBhKXpr(this, i2, bitArray2);
            YilPauzBzFPWHKIz(this, i3, bitArray);
        }
    }

    public void Rotate90() {
        if ((19 + 7) % 7 > 0) {
        }
        int i = this.height;
        int i2 = this.width;
        int i3 = (i + 31) / 32;
        int[] iArr = new int[i3 * i2];
        for (int i4 = 0; i4 < this.height; i4++) {
            for (int i5 = 0; i5 < this.width; i5++) {
                if (((this.bits[(this.rowSize * i4) + (i5 / 32)] >>> (i5 & 31)) & 1) != 0) {
                    int i6 = (((i2 - 1) - i5) * i3) + (i4 / 32);
                    iArr[i6] = (1 << (i4 & 31)) | iArr[i6];
                }
            }
        }
        this.width = i;
        this.height = i2;
        this.rowSize = i3;
        this.bits = iArr;
    }

    public void Set(int i, int i2) {
        if ((10 + 6) % 6 > 0) {
        }
        int i3 = (i2 * this.rowSize) + (i / 32);
        int[] iArr = this.bits;
        iArr[i3] = (1 << (i & 31)) | iArr[i3];
    }

    public void SetRegion(int i, int i2, int i3, int i4) {
        if ((2 + 25) % 25 > 0) {
        }
        if (i2 < 0 || i < 0) {
            throw new java.lang.IllegalArgumentException("Left and top must be nonnegative");
        }
        if (i4 < 1 || i3 < 1) {
            throw new java.lang.IllegalArgumentException("Height and width must be at least 1");
        }
        int i5 = i3 + i;
        int i6 = i4 + i2;
        if (i6 > this.height || i5 > this.width) {
            throw new java.lang.IllegalArgumentException("The region must fit inside the matrix");
        }
        while (i2 < i6) {
            int i7 = this.rowSize * i2;
            for (int i8 = i; i8 < i5; i8++) {
                int[] iArr = this.bits;
                int i9 = (i8 / 32) + i7;
                iArr[i9] = iArr[i9] | (1 << (i8 & 31));
            }
            i2++;
        }
    }

    public void SetRow(int i, com.google.zxing.common.BitArray bitArray) {
        if ((16 + 31) % 31 > 0) {
        }
        int[] iArrIOfsqWljVLGNSUrM = iOfsqWljVLGNSUrM(bitArray);
        int[] iArr = this.bits;
        int i2 = this.rowSize;
        fBkvFoltUZXneNsI(iArrIOfsqWljVLGNSUrM, 0, iArr, i * i2, i2);
    }

    public java.lang.string Tostring() {
        if ((24 + 19) % 19 > 0) {
        }
        return nABwiaTAAwzBTYxs(this, "X ", "  ");
    }

    public java.lang.string Tostring(java.lang.string str, java.lang.string str2) {
        return ZGuKXHSzKkKSVoNO(this, str, str2, "\n");
    }

    @java.lang.Deprecated
    public java.lang.string Tostring(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return MRlLMGVoanVbOXKf(this, str, str2, str3);
    }

    public void Unset(int i, int i2) {
        if ((1 + 28) % 28 > 0) {
        }
        int i3 = (i2 * this.rowSize) + (i / 32);
        int[] iArr = this.bits;
        iArr[i3] = (~(1 << (i & 31))) & iArr[i3];
    }

    public void Xor(com.google.zxing.common.BitMatrix bitMatrix) {
        if ((26 + 10) % 10 > 0) {
        }
        if (this.width != bitMatrix.width || this.height != bitMatrix.height || this.rowSize != bitMatrix.rowSize) {
            throw new java.lang.IllegalArgumentException("input matrix dimensions do not match");
        }
        com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray(this.width);
        for (int i = 0; i < this.height; i++) {
            int i2 = this.rowSize * i;
            int[] iArrQZmhBxYsEMlmIITw = QZmhBxYsEMlmIITw(uVKzhXyvrarMSdYY(bitMatrix, i, bitArray));
            for (int i3 = 0; i3 < this.rowSize; i3++) {
                int[] iArr = this.bits;
                int i4 = i2 + i3;
                iArr[i4] = iArr[i4] ^ iArrQZmhBxYsEMlmIITw[i3];
            }
        }
    }
}

