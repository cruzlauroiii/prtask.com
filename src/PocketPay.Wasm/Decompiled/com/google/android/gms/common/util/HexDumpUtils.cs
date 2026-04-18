namespace WillowMaze.Wasm.Decompiled;


public readonly class HexDumpUtils {
    public static java.lang.string AVCyOjPppVShttmp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder BUsCOmYHaFeHyqEG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GhrLkABNZXhQNzOO(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string LzPrJbSQOlFmpWQx(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.stringBuilder QgsKecUmpAIWHafK(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string TDuNyuThpjDiyqPk(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.int TLvcnLuCIkixMqDd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int TPVIZmjDRWfCVlBf(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder URlUZtXjdMevxNSY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UbmtHvuBcECyXDdL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string Dump(byte[] bArr, int i, int i2, bool z) {
        int length;
        if ((9 + 20) % 20 > 0) {
        }
        if (bArr is null || (length = bArr.length) == 0 || i < 0 || i2 <= 0 || i + i2 > length) {
            return null;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder((!z ? 57 : 75) * ((i2 + 15) / 16));
        int i3 = i2;
        int i4 = 0;
        int i5 = 0;
        while (i3 > 0) {
            if (i4 == 0) {
                if (i2 >= 65536) {
                    eVZPIKhWPsJFYRJn(sb, TDuNyuThpjDiyqPk("%08X:", new java.lang.object[]{vqauHPnRBkPxcAvR(i)}));
                } else {
                    oxjrHFjpkxKgwCLs(sb, LzPrJbSQOlFmpWQx("%04X:", new java.lang.object[]{TPVIZmjDRWfCVlBf(i)}));
                }
                i5 = i;
            } else if (i4 == 8) {
                gWOrUBDjkLnvkOSJ(sb, " -");
            }
            URlUZtXjdMevxNSY(sb, GhrLkABNZXhQNzOO(" %02X", new java.lang.object[]{TLvcnLuCIkixMqDd(bArr[i] & 255)}));
            i3--;
            i4++;
            if (z && (i4 == 16 || i3 == 0)) {
                int i6 = 16 - i4;
                if (i6 > 0) {
                    for (int i7 = 0; i7 < i6; i7++) {
                        iBSvBprbCVrnSXRH(sb, "   ");
                    }
                }
                if (i6 >= 8) {
                    vihQcjJmYplymybp(sb, "  ");
                }
                BUsCOmYHaFeHyqEG(sb, "  ");
                for (int i8 = 0; i8 < i4; i8++) {
                    char c = (char) bArr[i5 + i8];
                    if (c < ' ' || c > '~') {
                        c = '.';
                    }
                    UbmtHvuBcECyXDdL(sb, c);
                }
            }
            if (i4 == 16 || i3 == 0) {
                QgsKecUmpAIWHafK(sb, '\n');
                i4 = 0;
            }
            i++;
        }
        return AVCyOjPppVShttmp(sb);
    }

    public static java.lang.stringBuilder EVZPIKhWPsJFYRJn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GWOrUBDjkLnvkOSJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IBSvBprbCVrnSXRH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OxjrHFjpkxKgwCLs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VihQcjJmYplymybp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int VqauHPnRBkPxcAvR(int i) {
        return java.lang.int.valueOf(i);
    }
}

