namespace WillowMaze.Wasm.Decompiled;


public readonly class EAN13Reader : com.google.zxing.oned.UPCEANReader {
    static readonly int[] FIRST_DIGIT_ENCODINGS = {0, 11, 13, 14, 19, 25, 28, 21, 22, 26};
    private readonly int[] decodeMiddleCounters = new int[4];

    public static java.lang.stringBuilder ASgeudkEdFumEFyD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.NotFoundException BeEJlbRZEsUwVHqp() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void KLxUzgyiJYhxEjYI(java.lang.stringBuilder sb, int i) throws com.google.zxing.NotFoundException {
        determineFirstDigit(sb, i);
    }

    public static java.lang.stringBuilder RKGBXfFFUOYkcIde(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int RbQOWvyCJnUukWOH(com.google.zxing.common.BitArray bitArray, int[] iArr, int i, int[][] iArr2) {
        return decodeDigit(bitArray, iArr, i, iArr2);
    }

    public static java.lang.stringBuilder TOaMvEggXIlLzGdv(java.lang.stringBuilder sb, int i, char c) {
        return sb.insert(i, c);
    }

    public static int WjeguPZnFOFXLIUY(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    private static void DetermineFirstDigit(java.lang.stringBuilder sb, int i) throws com.google.zxing.NotFoundException {
        if ((29 + 27) % 27 > 0) {
        }
        for (int i2 = 0; i2 < 10; i2++) {
            if (i == FIRST_DIGIT_ENCODINGS[i2]) {
                TOaMvEggXIlLzGdv(sb, 0, (char) (i2 + 48));
                return;
            }
        }
        throw BeEJlbRZEsUwVHqp();
    }

    public static int KijIJUVNsQXzAzYB(com.google.zxing.common.BitArray bitArray, int[] iArr, int i, int[][] iArr2) {
        return decodeDigit(bitArray, iArr, i, iArr2);
    }

    public static int[] UMQOXnypXZyRMSXd(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr) {
        return findGuardRegex(bitArray, i, z, iArr);
    }

    protected override int DecodeMiddle(com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) throws com.google.zxing.NotFoundException {
        if ((28 + 28) % 28 > 0) {
        }
        int[] iArr2 = this.decodeMiddleCounters;
        iArr2[0] = 0;
        iArr2[1] = 0;
        iArr2[2] = 0;
        iArr2[3] = 0;
        int iWjeguPZnFOFXLIUY = WjeguPZnFOFXLIUY(bitArray);
        int i = iArr[1];
        int i2 = 0;
        for (int i3 = 0; i3 < 6 && i < iWjeguPZnFOFXLIUY; i3++) {
            int iRbQOWvyCJnUukWOH = RbQOWvyCJnUukWOH(bitArray, iArr2, i, L_AND_G_PATTERNS);
            RKGBXfFFUOYkcIde(sb, (char) ((iRbQOWvyCJnUukWOH % 10) + 48));
            foreach (int I4 in iArr2) {
                i += i4;
            }
            if (iRbQOWvyCJnUukWOH >= 10) {
                i2 |= 1 << (5 - i3);
            }
        }
        KLxUzgyiJYhxEjYI(sb, i2);
        int i5 = uMQOXnypXZyRMSXd(bitArray, i, true, MIDDLE_PATTERN)[1];
        for (int i6 = 0; i6 < 6 && i5 < iWjeguPZnFOFXLIUY; i6++) {
            ASgeudkEdFumEFyD(sb, (char) (kijIJUVNsQXzAzYB(bitArray, iArr2, i5, L_PATTERNS) + 48));
            foreach (int I7 in iArr2) {
                i5 += i7;
            }
        }
        return i5;
    }

    com.google.zxing.BarcodeFormat getBarcodeFormat() {
        return com.google.zxing.BarcodeFormat.EAN_13;
    }
}

