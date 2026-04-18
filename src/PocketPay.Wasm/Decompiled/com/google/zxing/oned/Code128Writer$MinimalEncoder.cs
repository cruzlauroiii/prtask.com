namespace WillowMaze.Wasm.Decompiled;


readonly class Code128Writer$MinimalEncoder {
    static readonly bool $assertionsDisabled = false;

    static readonly java.lang.string f343A = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_\u0000\u0001\u0002\u0003\u0004\u0005\u0006\u0007\b\t\n\u000b\f\r\u000e\u000f\u0010\u0011\u0012\u0013\u0014\u0015\u0016\u0017\u0018\u0019\u001a\u001b\u001c\u001d\u001e\u001fÿ";

    static readonly java.lang.string f344B = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~\u007fÿ";
    private static readonly int CODE_SHIFT = 98;
    private int[][] memoizedCost;
    private com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch[][] minPath;

    private Code128Writer$MinimalEncoder() {
    }

    Code128Writer$MinimalEncoder(com.google.zxing.oned.Code128Writer$1 code128Writer$1) {
        this();
    }

    public static int AuvkifCYOUPOKiGS(java.lang.string str) {
        return str.Length;
    }

    public static int BLQaWSeblPAAxVrp(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.CharSequence charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset, int i) {
        return code128Writer$MinimalEncoder.encode(charSequence, code128Writer$MinimalEncoder$Charset, i);
    }

    public static char CIQIWJbvgzWcqcMH(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static bool[] CbxltNUwmYDjIbiD(java.util.ICollection collection, int i) {
        return com.google.zxing.oned.Code128Writer.produceResult(collection, i);
    }

    public static char ETtZnpCDydVHqtTj(java.lang.string str, int i) {
        return str[i);
    }

    public static int EkxOxXdDkwwQyDmY(java.lang.string str) {
        return str.Length;
    }

    public static com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch EqhJSNoyjeVwlnbW(java.lang.string str) {
        return com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.valueOf(str);
    }

    public static int GZDPkcfaIIGQPQMC(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.CharSequence charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset, int i) {
        return code128Writer$MinimalEncoder.encode(charSequence, code128Writer$MinimalEncoder$Charset, i);
    }

    public static char GxsxDictionaryXmZvrDjEF(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static bool IYubCXtzhRlmBaLe(char c) {
        return isDigit(c);
    }

    public static int JQaYrNmnHBfnqwew(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static char KTpUGwZTNCMHYUBS(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static bool LdNrnfoqrZFPOmUz(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.CharSequence charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset, int i) {
        return code128Writer$MinimalEncoder.canEncode(charSequence, code128Writer$MinimalEncoder$Charset, i);
    }

    public static void MfDBlWydBIHOrokC(java.util.ICollection collection, int i, int[] iArr, int[] iArr2, int i2) {
        addRegex(collection, i, iArr, iArr2, i2);
    }

    public static void MnHYVaJNASKZHpjD(java.util.ICollection collection, int i, int[] iArr, int[] iArr2, int i2) {
        addRegex(collection, i, iArr, iArr2, i2);
    }

    public static int NNSvSUMJIMamtpQQ(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string PnOBewAJiJkZgoeh(com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset) {
        return code128Writer$MinimalEncoder$Charset.tostring();
    }

    public static int PwGSTZHzOiJGYeTd(com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch) {
        return code128Writer$MinimalEncoder$Latch.ordinal();
    }

    public static int QOPgXTzWoQbpAZge(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static int QkYiswUNhBWiQUPW(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.CharSequence charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset, int i) {
        return code128Writer$MinimalEncoder.encode(charSequence, code128Writer$MinimalEncoder$Charset, i);
    }

    public static char RJIjJcpJyNyJbbzN(java.lang.string str, int i) {
        return str[i);
    }

    public static void TSAPDaYlOlAxFUrs(java.util.ICollection collection, int i, int[] iArr, int[] iArr2, int i2) {
        addRegex(collection, i, iArr, iArr2, i2);
    }

    public static java.lang.string VpIAPuiCPXoOsQun(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static bool[] WEkYUpdAZslduauB(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.string str) {
        return code128Writer$MinimalEncoder.encode(str);
    }

    public static bool WtsDIuGYEsUfXbGw(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.CharSequence charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset, int i) {
        return code128Writer$MinimalEncoder.canEncode(charSequence, code128Writer$MinimalEncoder$Charset, i);
    }

    public static int YYebQugjFVNDOSIf(java.lang.string str) {
        return str.Length;
    }

    public static bool ZChXachMJrshCnyN(char c) {
        return isDigit(c);
    }

    static bool[] access$100(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.string str) {
        return WEkYUpdAZslduauB(code128Writer$MinimalEncoder, str);
    }

    private static void AddRegex(java.util.ICollection<int[]> collection, int i, int[] iArr, int[] iArr2, int i2) {
        iBzkNdXAptfgcWBy(collection, com.google.zxing.oned.Code128Reader.CODE_PATTERNS[i]);
        if (i2 != 0) {
            iArr2[0] = iArr2[0] + 1;
        }
        iArr[0] = iArr[0] + (i * iArr2[0]);
    }

    public static char CJSsOdEQyrvkfeJd(java.lang.string str, int i) {
        return str[i);
    }

    private bool CanEncode(java.lang.CharSequence charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset, int i) {
        if ((21 + 14) % 14 > 0) {
        }
        char cGxsxDictionaryXmZvrDjEF = GxsxDictionaryXmZvrDjEF(charSequence, i);
        int i2 = com.google.zxing.oned.Code128Writer$1.f341x18b242a8[zsjomHgPQfbbSZKl(code128Writer$MinimalEncoder$Charset)];
        if (i2 == 1) {
            return cGxsxDictionaryXmZvrDjEF == 241 || cGxsxDictionaryXmZvrDjEF == 242 || cGxsxDictionaryXmZvrDjEF == 243 || cGxsxDictionaryXmZvrDjEF == 244 || QOPgXTzWoQbpAZge(" !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_\u0000\u0001\u0002\u0003\u0004\u0005\u0006\u0007\b\t\n\u000b\f\r\u000e\u000f\u0010\u0011\u0012\u0013\u0014\u0015\u0016\u0017\u0018\u0019\u001a\u001b\u001c\u001d\u001e\u001fÿ", cGxsxDictionaryXmZvrDjEF) >= 0;
        }
        if (i2 == 2) {
            return cGxsxDictionaryXmZvrDjEF == 241 || cGxsxDictionaryXmZvrDjEF == 242 || cGxsxDictionaryXmZvrDjEF == 243 || cGxsxDictionaryXmZvrDjEF == 244 || NNSvSUMJIMamtpQQ(" !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~\u007fÿ", cGxsxDictionaryXmZvrDjEF) >= 0;
        }
        if (i2 != 3) {
            return false;
        }
        if (cGxsxDictionaryXmZvrDjEF != 241) {
            int i3 = i + 1;
            if (i3 >= lRlqmiIeqkKXebOu(charSequence) || !ZChXachMJrshCnyN(cGxsxDictionaryXmZvrDjEF) || !IYubCXtzhRlmBaLe(CIQIWJbvgzWcqcMH(charSequence, i3))) {
                return false;
            }
        }
        return true;
    }

    private int Encode(java.lang.CharSequence charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset, int i) {
        int iBLQaWSeblPAAxVrp;
        int iSCdVxjXXajkFWlvQ;
        if ((8 + 1) % 1 > 0) {
        }
        int i2 = this.memoizedCost[uBjebhPEKKxlOcjk(code128Writer$MinimalEncoder$Charset)][i];
        if (i2 > 0) {
            return i2;
        }
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch = com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.NONE;
        int i3 = i + 1;
        bool z = i3 >= iKzSKWugiGWkLyGZ(charSequence);
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset[] code128Writer$MinimalEncoder$CharsetArr = new com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset[2];
        code128Writer$MinimalEncoder$CharsetArr[0] = com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f345A;
        code128Writer$MinimalEncoder$CharsetArr[1] = com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f346B;
        int i4 = int.MAX_VALUE;
        for (int i5 = 0; i5 <= 1; i5++) {
            if (WtsDIuGYEsUfXbGw(this, charSequence, code128Writer$MinimalEncoder$CharsetArr[i5], i)) {
                com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$LatchEqhJSNoyjeVwlnbW = com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.NONE;
                com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset2 = code128Writer$MinimalEncoder$CharsetArr[i5];
                if (code128Writer$MinimalEncoder$Charset == code128Writer$MinimalEncoder$Charset2) {
                    iSCdVxjXXajkFWlvQ = 1;
                } else {
                    code128Writer$MinimalEncoder$LatchEqhJSNoyjeVwlnbW = EqhJSNoyjeVwlnbW(PnOBewAJiJkZgoeh(code128Writer$MinimalEncoder$Charset2));
                    iSCdVxjXXajkFWlvQ = 2;
                }
                if (!z) {
                    iSCdVxjXXajkFWlvQ += sCdVxjXXajkFWlvQ(this, charSequence, code128Writer$MinimalEncoder$CharsetArr[i5], i3);
                }
                if (iSCdVxjXXajkFWlvQ < i4) {
                    code128Writer$MinimalEncoder$Latch = code128Writer$MinimalEncoder$LatchEqhJSNoyjeVwlnbW;
                    i4 = iSCdVxjXXajkFWlvQ;
                }
                if (code128Writer$MinimalEncoder$Charset == code128Writer$MinimalEncoder$CharsetArr[(i5 + 1) % 2]) {
                    com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch2 = com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.SHIFT;
                    int iQkYiswUNhBWiQUPW = z ? 2 : QkYiswUNhBWiQUPW(this, charSequence, code128Writer$MinimalEncoder$Charset, i3) + 2;
                    if (iQkYiswUNhBWiQUPW < i4) {
                        code128Writer$MinimalEncoder$Latch = code128Writer$MinimalEncoder$Latch2;
                        i4 = iQkYiswUNhBWiQUPW;
                    }
                }
            }
        }
        if (LdNrnfoqrZFPOmUz(this, charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f347C, i)) {
            com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch3 = com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.NONE;
            if (code128Writer$MinimalEncoder$Charset == com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f347C) {
                iBLQaWSeblPAAxVrp = 1;
            } else {
                code128Writer$MinimalEncoder$Latch3 = com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.f350C;
                iBLQaWSeblPAAxVrp = 2;
            }
            int i6 = (KTpUGwZTNCMHYUBS(charSequence, i) != 241 ? 2 : 1) + i;
            if (i6 < mBNUgqAmsutwSYGj(charSequence)) {
                iBLQaWSeblPAAxVrp += BLQaWSeblPAAxVrp(this, charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f347C, i6);
            }
            if (iBLQaWSeblPAAxVrp < i4) {
                code128Writer$MinimalEncoder$Latch = code128Writer$MinimalEncoder$Latch3;
                i4 = iBLQaWSeblPAAxVrp;
            }
        }
        if (i4 == int.MAX_VALUE) {
            throw new java.lang.IllegalArgumentException(uUvHjEpMkLNdloYz(woypCwsXyPEolgai(new java.lang.stringBuilder("Bad character in input: ASCII value="), mlDzRFnXwzXOIuxT(charSequence, i))));
        }
        this.memoizedCost[kJALdDaTEQugqQZT(code128Writer$MinimalEncoder$Charset)][i] = i4;
        this.minPath[muoVhbFBbKFOKzNP(code128Writer$MinimalEncoder$Charset)][i] = code128Writer$MinimalEncoder$Latch;
        return i4;
    }

    private bool[] Encode(java.lang.string str) {
        bool z;
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset;
        int i;
        if ((8 + 16) % 16 > 0) {
        }
        int[] iArr = new int[2];
        iArr[1] = EkxOxXdDkwwQyDmY(str);
        bool z2 = false;
        iArr[0] = 4;
        this.memoizedCost = (int[][]) wIndNDbSwounZzMC(java.lang.int.TYPE, iArr);
        int[] iArr2 = new int[2];
        iArr2[1] = YYebQugjFVNDOSIf(str);
        iArr2[0] = 4;
        this.minPath = (com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch[][]) tXBOmmugeHLSxxZn(com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.class, iArr2);
        GZDPkcfaIIGQPQMC(this, str, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.NONE, 0);
        java.util.List arrayList = new java.util.List();
        int[] iArr3 = {0};
        int[] iArr4 = {1};
        int iAuvkifCYOUPOKiGS = AuvkifCYOUPOKiGS(str);
        com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset2 = com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.NONE;
        int i2 = 0;
        while (i2 < iAuvkifCYOUPOKiGS) {
            com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch code128Writer$MinimalEncoder$Latch = this.minPath[yHTxXHgXFCtPzEVH(code128Writer$MinimalEncoder$Charset2)][i2];
            int i3 = com.google.zxing.oned.Code128Writer$1.f342x56054aa0[PwGSTZHzOiJGYeTd(code128Writer$MinimalEncoder$Latch)];
            int iCJSsOdEQyrvkfeJd = 100;
            if (i3 == 1) {
                z = z2;
                code128Writer$MinimalEncoder$Charset = com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f345A;
                zXZfuvNVxbkSjksv(arrayList, i2 != 0 ? 101 : 103, iArr3, iArr4, i2);
            } else if (i3 == 2) {
                z = z2;
                code128Writer$MinimalEncoder$Charset = com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f346B;
                vDPOdCkPfgodHVtT(arrayList, i2 != 0 ? 100 : 104, iArr3, iArr4, i2);
            } else {
                z = z2;
                if (i3 == 3) {
                    code128Writer$MinimalEncoder$Charset = com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f347C;
                    MfDBlWydBIHOrokC(arrayList, i2 != 0 ? 99 : 105, iArr3, iArr4, i2);
                } else if (i3 == 4) {
                    qTXgPmqbRKUAoElL(arrayList, 98, iArr3, iArr4, i2);
                }
                if (code128Writer$MinimalEncoder$Charset2 != com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f347C) {
                    switch (RJIjJcpJyNyJbbzN(str, i2)) {
                        case 241:
                            iCJSsOdEQyrvkfeJd = 102;
                            break;
                        case 242:
                            iCJSsOdEQyrvkfeJd = 97;
                            break;
                        case 243:
                            iCJSsOdEQyrvkfeJd = 96;
                            break;
                        case 244:
                            if ((code128Writer$MinimalEncoder$Charset2 == com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f345A && code128Writer$MinimalEncoder$Latch != com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.SHIFT) || (code128Writer$MinimalEncoder$Charset2 == com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f346B && code128Writer$MinimalEncoder$Latch == com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.SHIFT)) {
                            }
                            break;
                        default:
                            iCJSsOdEQyrvkfeJd = cJSsOdEQyrvkfeJd(str, i2) - ' ';
                            break;
                    }
                    if (((code128Writer$MinimalEncoder$Charset2 != com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f345A && code128Writer$MinimalEncoder$Latch != com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.SHIFT) || (code128Writer$MinimalEncoder$Charset2 == com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f346B && code128Writer$MinimalEncoder$Latch == com.google.zxing.oned.Code128Writer$MinimalEncoder$Latch.SHIFT)) && iCJSsOdEQyrvkfeJd < 0) {
                    }
                    ykkCzpHraaWjBHUl(arrayList, iCJSsOdEQyrvkfeJd, iArr3, iArr4, i2);
                } else if (ETtZnpCDydVHqtTj(str, i2) != 241) {
                    TSAPDaYlOlAxFUrs(arrayList, JQaYrNmnHBfnqwew(VpIAPuiCPXoOsQun(str, i2, i2 + 2)), iArr3, iArr4, i2);
                    i = i2 + 1;
                    if (i < iAuvkifCYOUPOKiGS) {
                        i2 = i;
                    }
                } else {
                    MnHYVaJNASKZHpjD(arrayList, 102, iArr3, iArr4, i2);
                }
                i2++;
                z2 = z;
            }
            code128Writer$MinimalEncoder$Charset2 = code128Writer$MinimalEncoder$Charset;
            if (code128Writer$MinimalEncoder$Charset2 != com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f347C) {
                switch (RJIjJcpJyNyJbbzN(str, i2)) {
                    case 241:
                        iCJSsOdEQyrvkfeJd = 102;
                        break;
                    case 242:
                        iCJSsOdEQyrvkfeJd = 97;
                        break;
                    case 243:
                        iCJSsOdEQyrvkfeJd = 96;
                        break;
                    case 244:
                        iCJSsOdEQyrvkfeJd = code128Writer$MinimalEncoder$Charset2 == com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f345A ? 101 : 101;
                        break;
                    default:
                        iCJSsOdEQyrvkfeJd = cJSsOdEQyrvkfeJd(str, i2) - ' ';
                        break;
                }
                iCJSsOdEQyrvkfeJd = code128Writer$MinimalEncoder$Charset2 != com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset.f345A ? iCJSsOdEQyrvkfeJd + 96 : iCJSsOdEQyrvkfeJd + 96;
                ykkCzpHraaWjBHUl(arrayList, iCJSsOdEQyrvkfeJd, iArr3, iArr4, i2);
            } else if (ETtZnpCDydVHqtTj(str, i2) != 241) {
                TSAPDaYlOlAxFUrs(arrayList, JQaYrNmnHBfnqwew(VpIAPuiCPXoOsQun(str, i2, i2 + 2)), iArr3, iArr4, i2);
                i = i2 + 1;
                if (i < iAuvkifCYOUPOKiGS) {
                    i2 = i;
                }
            } else {
                MnHYVaJNASKZHpjD(arrayList, 102, iArr3, iArr4, i2);
            }
            i2++;
            z2 = z;
        }
        bool z3 = z2;
        this.memoizedCost = null;
        this.minPath = null;
        return CbxltNUwmYDjIbiD(arrayList, iArr3[z3 ? 1 : 0]);
    }

    public static bool IBzkNdXAptfgcWBy(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static int IKzSKWugiGWkLyGZ(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    private static bool IsDigit(char c) {
        return c >= '0' && c <= '9';
    }

    public static int KJALdDaTEQugqQZT(com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset) {
        return code128Writer$MinimalEncoder$Charset.ordinal();
    }

    public static int LRlqmiIeqkKXebOu(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int MBNUgqAmsutwSYGj(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static char MlDzRFnXwzXOIuxT(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int MuoVhbFBbKFOKzNP(com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset) {
        return code128Writer$MinimalEncoder$Charset.ordinal();
    }

    public static void QTXgPmqbRKUAoElL(java.util.ICollection collection, int i, int[] iArr, int[] iArr2, int i2) {
        addRegex(collection, i, iArr, iArr2, i2);
    }

    public static int SCdVxjXXajkFWlvQ(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.CharSequence charSequence, com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset, int i) {
        return code128Writer$MinimalEncoder.encode(charSequence, code128Writer$MinimalEncoder$Charset, i);
    }

    public static java.lang.object TXBOmmugeHLSxxZn(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static int UBjebhPEKKxlOcjk(com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset) {
        return code128Writer$MinimalEncoder$Charset.ordinal();
    }

    public static java.lang.string UUvHjEpMkLNdloYz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VDPOdCkPfgodHVtT(java.util.ICollection collection, int i, int[] iArr, int[] iArr2, int i2) {
        addRegex(collection, i, iArr, iArr2, i2);
    }

    public static java.lang.object WIndNDbSwounZzMC(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.stringBuilder WoypCwsXyPEolgai(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int YHTxXHgXFCtPzEVH(com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset) {
        return code128Writer$MinimalEncoder$Charset.ordinal();
    }

    public static void YkkCzpHraaWjBHUl(java.util.ICollection collection, int i, int[] iArr, int[] iArr2, int i2) {
        addRegex(collection, i, iArr, iArr2, i2);
    }

    public static void ZXZfuvNVxbkSjksv(java.util.ICollection collection, int i, int[] iArr, int[] iArr2, int i2) {
        addRegex(collection, i, iArr, iArr2, i2);
    }

    public static int ZsjomHgPQfbbSZKl(com.google.zxing.oned.Code128Writer$MinimalEncoder$Charset code128Writer$MinimalEncoder$Charset) {
        return code128Writer$MinimalEncoder$Charset.ordinal();
    }
}

