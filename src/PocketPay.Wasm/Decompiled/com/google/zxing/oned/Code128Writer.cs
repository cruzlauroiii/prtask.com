namespace WillowMaze.Wasm.Decompiled;


public readonly class Code128Writer : com.google.zxing.oned.OneDimensionalCodeWriter {
    private static readonly int CODE_CODE_A = 101;
    private static readonly int CODE_CODE_B = 100;
    private static readonly int CODE_CODE_C = 99;
    private static readonly int CODE_FNC_1 = 102;
    private static readonly int CODE_FNC_2 = 97;
    private static readonly int CODE_FNC_3 = 96;
    private static readonly int CODE_FNC_4_A = 101;
    private static readonly int CODE_FNC_4_B = 100;
    private static readonly int CODE_START_A = 103;
    private static readonly int CODE_START_B = 104;
    private static readonly int CODE_START_C = 105;
    private static readonly int CODE_STOP = 106;
    private static readonly char ESCAPE_FNC_1 = 241;
    private static readonly char ESCAPE_FNC_2 = 242;
    private static readonly char ESCAPE_FNC_3 = 243;
    private static readonly char ESCAPE_FNC_4 = 244;

    public static java.lang.stringBuilder AxKqNJhXRDuyOMcq(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool BMmqZSzAjUHLUwwk(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool BnaIjvHABHMbrwZV(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object BvIySijPbpYGQraj(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.stringBuilder DbMJqgzUMpCiAKWm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string DmtSMkEvwYvONAhn(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object HUlgfcILcMNOrCRo(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.zxing.oned.Code128Writer$CType HUmaDEuNYqvwVACn(java.lang.CharSequence charSequence, int i) {
        return findCType(charSequence, i);
    }

    public static int IcRHzcyOLRvQUcJW(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool JYGCAcFsgaLeUEbB(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool[] MDKfmVKeHoIKInSQ(java.util.ICollection collection, int i) {
        return produceResult(collection, i);
    }

    public static java.lang.stringBuilder MrSbkyOSFdsBsyZf(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object QAROgwMMiEpAMbBw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int RppOBILFxBkSXost(java.lang.string str) {
        return str.Length;
    }

    public static char TSEoyQcxACvHRCRq(java.lang.string str, int i) {
        return str[i);
    }

    public static int TTOhwWVogZYnqLdZ(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int TfARzUuDjoFtZxhn(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static int UFKMeRQuwsyhIFLo(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.util.IEnumerator UOUNNaUsguBReMpW(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static bool WPRQVIHtEzrupvCR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool XEnDiGYJfXKnVaSQ(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool XSduQfsagxPMzEUJ(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static bool YLNttTsrIjAlEiRH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator YLzAquAZJIfvNVVg(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static com.google.zxing.oned.Code128Writer$CType YTMFvpmJdPqfRndZ(java.lang.CharSequence charSequence, int i) {
        return findCType(charSequence, i);
    }

    public static java.lang.stringBuilder ZUmzbmOIaYVQHvuv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object ZWZCRBAmxKyoVxKF(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int BdvSbomheQEiKtiV(java.lang.CharSequence charSequence, int i, int i2) {
        return chooseCode(charSequence, i, i2);
    }

    public static bool CDicNyDvWQpXjMsk(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder CHEFSXlUoPNzjJZw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string CcTJRDGhvHGHwnku(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private static int Check(java.lang.string str, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) {
        if ((30 + 10) % 10 > 0) {
        }
        int iRppOBILFxBkSXost = RppOBILFxBkSXost(str);
        byte b = 1;
        if (iRppOBILFxBkSXost < 1 || iRppOBILFxBkSXost > 80) {
            throw new java.lang.IllegalArgumentException(ccTJRDGhvHGHwnku(MrSbkyOSFdsBsyZf(new java.lang.stringBuilder("Contents length should be between 1 and 80 characters, but got "), iRppOBILFxBkSXost)));
        }
        int i = -1;
        if (map is not null && BMmqZSzAjUHLUwwk(map, com.google.zxing.EncodeHintType.FORCE_CODE_SET)) {
            java.lang.string strDmtSMkEvwYvONAhn = DmtSMkEvwYvONAhn(QAROgwMMiEpAMbBw(map, com.google.zxing.EncodeHintType.FORCE_CODE_SET));
            iiCQxkRTJHhIBtoW(strDmtSMkEvwYvONAhn);
            switch (wckYEGfMvVKDnSsY(strDmtSMkEvwYvONAhn)) {
                case 65:
                    b = cDicNyDvWQpXjMsk(strDmtSMkEvwYvONAhn, "A") ? (byte) 0 : (byte) -1;
                    break;
                case 66:
                    if (!oWQWDPBNDOYUQgeM(strDmtSMkEvwYvONAhn, "B")) {
                        b = -1;
                    }
                    break;
                case 67:
                    b = rKEpIzVrHTGhSAnr(strDmtSMkEvwYvONAhn, "C") ? (byte) 2 : (byte) -1;
                    break;
                default:
                    b = -1;
                    break;
            }
            switch (b) {
                case 0:
                    i = 101;
                    break;
                case 1:
                    i = 100;
                    break;
                case 2:
                    i = 99;
                    break;
                default:
                    throw new java.lang.IllegalArgumentException(lOGDrjWLfAxkZEho(dcMOIutDUvSJmDwh(new java.lang.stringBuilder("Unsupported code set hint: "), strDmtSMkEvwYvONAhn)));
            }
        }
        for (int i2 = 0; i2 < iRppOBILFxBkSXost; i2++) {
            char cYCGTQeaGrkqzDWrl = yCGTQeaGrkqzDWrl(str, i2);
            switch (cYCGTQeaGrkqzDWrl) {
                default:
                    if (cYCGTQeaGrkqzDWrl > 127) {
                        throw new java.lang.IllegalArgumentException(qKwqjpiGLuLEpyEr(DbMJqgzUMpCiAKWm(new java.lang.stringBuilder("Bad character in input: ASCII value="), cYCGTQeaGrkqzDWrl)));
                    }
                case 241:
                case 242:
                case 243:
                case 244:
                    switch (i) {
                        case 99:
                            if (cYCGTQeaGrkqzDWrl < '0' || ((cYCGTQeaGrkqzDWrl > '9' && cYCGTQeaGrkqzDWrl <= 127) || cYCGTQeaGrkqzDWrl == 242 || cYCGTQeaGrkqzDWrl == 243 || cYCGTQeaGrkqzDWrl == 244)) {
                                throw new java.lang.IllegalArgumentException(lxDVRVaFDeaFtJif(ZUmzbmOIaYVQHvuv(new java.lang.stringBuilder("Bad character in input for forced code set C: ASCII value="), cYCGTQeaGrkqzDWrl)));
                            }
                            break;
                            break;
                        case 100:
                            if (cYCGTQeaGrkqzDWrl <= ' ') {
                                throw new java.lang.IllegalArgumentException(eksvHJazVlHRRyrp(cHEFSXlUoPNzjJZw(new java.lang.stringBuilder("Bad character in input for forced code set B: ASCII value="), cYCGTQeaGrkqzDWrl)));
                            }
                            break;
                            break;
                        case 101:
                            if (cYCGTQeaGrkqzDWrl > '_' && cYCGTQeaGrkqzDWrl <= 127) {
                                throw new java.lang.IllegalArgumentException(ncpVwLmObMGvNRaz(AxKqNJhXRDuyOMcq(new java.lang.stringBuilder("Bad character in input for forced code set A: ASCII value="), cYCGTQeaGrkqzDWrl)));
                            }
                            break;
                            break;
                    }
                    break;
            }
        }
        return i;
    }

    private static int ChooseCode(java.lang.CharSequence charSequence, int i, int i2) {
        com.google.zxing.oned.Code128Writer$CType code128Writer$CTypeYTMFvpmJdPqfRndZ;
        if ((23 + 7) % 7 > 0) {
        }
        com.google.zxing.oned.Code128Writer$CType code128Writer$CTypeTsTMjNUNUxgfzKFd = tsTMjNUNUxgfzKFd(charSequence, i);
        if (code128Writer$CTypeTsTMjNUNUxgfzKFd == com.google.zxing.oned.Code128Writer$CType.ONE_DIGIT) {
            return i2 != 101 ? 100 : 101;
        }
        if (code128Writer$CTypeTsTMjNUNUxgfzKFd == com.google.zxing.oned.Code128Writer$CType.UNCODABLE) {
            if (i < IcRHzcyOLRvQUcJW(charSequence)) {
                char cIzPOHAEVUlbPvCmJ = izPOHAEVUlbPvCmJ(charSequence, i);
                if (cIzPOHAEVUlbPvCmJ < ' ' || (i2 == 101 && (cIzPOHAEVUlbPvCmJ < '`' || (cIzPOHAEVUlbPvCmJ >= 241 && cIzPOHAEVUlbPvCmJ <= 244)))) {
                    return 101;
                }
            }
            return 100;
        }
        if (i2 == 101 && code128Writer$CTypeTsTMjNUNUxgfzKFd == com.google.zxing.oned.Code128Writer$CType.FNC_1) {
            return 101;
        }
        if (i2 == 99) {
            return 99;
        }
        if (i2 != 100) {
            if (code128Writer$CTypeTsTMjNUNUxgfzKFd == com.google.zxing.oned.Code128Writer$CType.FNC_1) {
                code128Writer$CTypeTsTMjNUNUxgfzKFd = HUmaDEuNYqvwVACn(charSequence, i + 1);
            }
            return code128Writer$CTypeTsTMjNUNUxgfzKFd != com.google.zxing.oned.Code128Writer$CType.TWO_DIGITS ? 100 : 99;
        }
        if (code128Writer$CTypeTsTMjNUNUxgfzKFd == com.google.zxing.oned.Code128Writer$CType.FNC_1) {
            return 100;
        }
        com.google.zxing.oned.Code128Writer$CType code128Writer$CTypePadQgShJLCwrQIBn = padQgShJLCwrQIBn(charSequence, i + 2);
        if (code128Writer$CTypePadQgShJLCwrQIBn == com.google.zxing.oned.Code128Writer$CType.UNCODABLE || code128Writer$CTypePadQgShJLCwrQIBn == com.google.zxing.oned.Code128Writer$CType.ONE_DIGIT) {
            return 100;
        }
        if (code128Writer$CTypePadQgShJLCwrQIBn == com.google.zxing.oned.Code128Writer$CType.FNC_1) {
            return pwZoezQqBxczcbUg(charSequence, i + 3) != com.google.zxing.oned.Code128Writer$CType.TWO_DIGITS ? 100 : 99;
        }
        int i3 = i + 4;
        while (true) {
            code128Writer$CTypeYTMFvpmJdPqfRndZ = YTMFvpmJdPqfRndZ(charSequence, i3);
            if (code128Writer$CTypeYTMFvpmJdPqfRndZ != com.google.zxing.oned.Code128Writer$CType.TWO_DIGITS) {
                break;
            }
            i3 += 2;
        }
        return code128Writer$CTypeYTMFvpmJdPqfRndZ != com.google.zxing.oned.Code128Writer$CType.ONE_DIGIT ? 99 : 100;
    }

    public static char CwEbKyIpqOVVNJUg(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder DcMOIutDUvSJmDwh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool[] EhZLcpgqcNQflyZr(java.lang.string str, int i) {
        return encodeFast(str, i);
    }

    public static java.lang.string EksvHJazVlHRRyrp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private static bool[] EncodeFast(java.lang.string str, int i) {
        if ((15 + 21) % 21 > 0) {
        }
        int iIIEEzvojSxqTjokc = iIEEzvojSxqTjokc(str);
        java.util.List arrayList = new java.util.List();
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        int i5 = 1;
        while (i2 < iIIEEzvojSxqTjokc) {
            int iBdvSbomheQEiKtiV = i != -1 ? i : bdvSbomheQEiKtiV(str, i2, i4);
            int iCwEbKyIpqOVVNJUg = 100;
            if (iBdvSbomheQEiKtiV != i4) {
                iCwEbKyIpqOVVNJUg = i4 != 0 ? iBdvSbomheQEiKtiV : iBdvSbomheQEiKtiV == 100 ? 104 : iBdvSbomheQEiKtiV == 101 ? 103 : 105;
                i4 = iBdvSbomheQEiKtiV;
            } else {
                switch (TSEoyQcxACvHRCRq(str, i2)) {
                    case 241:
                        iCwEbKyIpqOVVNJUg = 102;
                        break;
                    case 242:
                        iCwEbKyIpqOVVNJUg = 97;
                        break;
                    case 243:
                        iCwEbKyIpqOVVNJUg = 96;
                        break;
                    case 244:
                        if (i4 == 101) {
                            iCwEbKyIpqOVVNJUg = 101;
                        }
                        break;
                    default:
                        if (i4 == 100) {
                            iCwEbKyIpqOVVNJUg = cwEbKyIpqOVVNJUg(str, i2) - ' ';
                        } else if (i4 != 101) {
                            int i6 = i2 + 1;
                            if (i6 == iIIEEzvojSxqTjokc) {
                                throw new java.lang.IllegalArgumentException("Bad number of characters for digit only encoding.");
                            }
                            iCwEbKyIpqOVVNJUg = TTOhwWVogZYnqLdZ(xVooRFKhOEHgFDIo(str, i2, i2 + 2));
                            i2 = i6;
                        } else {
                            char cPZppNXzEgzfXHglN = pZppNXzEgzfXHglN(str, i2);
                            iCwEbKyIpqOVVNJUg = cPZppNXzEgzfXHglN - ' ';
                            if (iCwEbKyIpqOVVNJUg < 0) {
                                iCwEbKyIpqOVVNJUg = cPZppNXzEgzfXHglN + '@';
                            }
                        }
                        break;
                }
                i2++;
            }
            hcTmxWWEwWaKZDVq(arrayList, com.google.zxing.oned.Code128Reader.CODE_PATTERNS[iCwEbKyIpqOVVNJUg]);
            i3 += iCwEbKyIpqOVVNJUg * i5;
            if (i2 != 0) {
                i5++;
            }
        }
        return MDKfmVKeHoIKInSQ(arrayList, i3);
    }

    public static char ExkqxVJYxpqHFzzo(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    private static com.google.zxing.oned.Code128Writer$CType findCType(java.lang.CharSequence charSequence, int i) {
        if ((23 + 6) % 6 > 0) {
        }
        int iUFKMeRQuwsyhIFLo = UFKMeRQuwsyhIFLo(charSequence);
        if (i >= iUFKMeRQuwsyhIFLo) {
            return com.google.zxing.oned.Code128Writer$CType.UNCODABLE;
        }
        char cExkqxVJYxpqHFzzo = exkqxVJYxpqHFzzo(charSequence, i);
        if (cExkqxVJYxpqHFzzo == 241) {
            return com.google.zxing.oned.Code128Writer$CType.FNC_1;
        }
        if (cExkqxVJYxpqHFzzo < '0' || cExkqxVJYxpqHFzzo > '9') {
            return com.google.zxing.oned.Code128Writer$CType.UNCODABLE;
        }
        int i2 = i + 1;
        if (i2 >= iUFKMeRQuwsyhIFLo) {
            return com.google.zxing.oned.Code128Writer$CType.ONE_DIGIT;
        }
        char cUDSZNfOgERYcNzMX = uDSZNfOgERYcNzMX(charSequence, i2);
        return (cUDSZNfOgERYcNzMX >= '0' && cUDSZNfOgERYcNzMX <= '9') ? com.google.zxing.oned.Code128Writer$CType.TWO_DIGITS : com.google.zxing.oned.Code128Writer$CType.ONE_DIGIT;
    }

    public static java.util.HashSet FixtIzlDjSTymJXH(java.lang.object obj) {
        return java.util.ICollections.singleton(obj);
    }

    public static bool HcTmxWWEwWaKZDVq(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static int IIEEzvojSxqTjokc(java.lang.string str) {
        return str.Length;
    }

    public static int IiCQxkRTJHhIBtoW(java.lang.string str) {
        return str.GetHashCode();
    }

    public static char IzPOHAEVUlbPvCmJ(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string LOGDrjWLfAxkZEho(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LxDVRVaFDeaFtJif(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string NcpVwLmObMGvNRaz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool OWQWDPBNDOYUQgeM(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string OuLybKTzoIJQakpN(java.lang.object obj) {
        return obj.tostring();
    }

    public static char PZppNXzEgzfXHglN(java.lang.string str, int i) {
        return str[i);
    }

    public static com.google.zxing.oned.Code128Writer$CType padQgShJLCwrQIBn(java.lang.CharSequence charSequence, int i) {
        return findCType(charSequence, i);
    }

    static bool[] ProduceResult(java.util.ICollection<int[]> collection, int i) {
        if ((7 + 25) % 25 > 0) {
        }
        JYGCAcFsgaLeUEbB(collection, com.google.zxing.oned.Code128Reader.CODE_PATTERNS[i % 103]);
        XEnDiGYJfXKnVaSQ(collection, com.google.zxing.oned.Code128Reader.CODE_PATTERNS[106]);
        java.util.IEnumerator itUOUNNaUsguBReMpW = UOUNNaUsguBReMpW(collection);
        int iTfARzUuDjoFtZxhn = 0;
        int i2 = 0;
        while (YLNttTsrIjAlEiRH(itUOUNNaUsguBReMpW)) {
            foreach (int I3 in (int[]) BvIySijPbpYGQraj(itUOUNNaUsguBReMpW)) {
                i2 += i3;
            }
        }
        bool[] zArr = new bool[i2];
        java.util.IEnumerator itYLzAquAZJIfvNVVg = YLzAquAZJIfvNVVg(collection);
        while (WPRQVIHtEzrupvCR(itYLzAquAZJIfvNVVg)) {
            iTfARzUuDjoFtZxhn += TfARzUuDjoFtZxhn(zArr, iTfARzUuDjoFtZxhn, (int[]) HUlgfcILcMNOrCRo(itYLzAquAZJIfvNVVg), true);
        }
        return zArr;
    }

    public static com.google.zxing.oned.Code128Writer$CType pwZoezQqBxczcbUg(java.lang.CharSequence charSequence, int i) {
        return findCType(charSequence, i);
    }

    public static java.lang.string QKwqjpiGLuLEpyEr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool RKEpIzVrHTGhSAnr(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool[] SVGAVVSyfIdbYGTD(com.google.zxing.oned.Code128Writer$MinimalEncoder code128Writer$MinimalEncoder, java.lang.string str) {
        return com.google.zxing.oned.Code128Writer$MinimalEncoder.access$100(code128Writer$MinimalEncoder, str);
    }

    public static com.google.zxing.oned.Code128Writer$CType tsTMjNUNUxgfzKFd(java.lang.CharSequence charSequence, int i) {
        return findCType(charSequence, i);
    }

    public static char UDSZNfOgERYcNzMX(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static bool[] VkbksJMXUWxIubyB(com.google.zxing.oned.Code128Writer code128Writer, java.lang.string str, java.util.Dictionary map) {
        return code128Writer.encode(str, map);
    }

    public static int WAYLcnTrRluVocuA(java.lang.string str, java.util.Dictionary map) {
        return check(str, map);
    }

    public static int WckYEGfMvVKDnSsY(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string XVooRFKhOEHgFDIo(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static char YCGTQeaGrkqzDWrl(java.lang.string str, int i) {
        return str[i);
    }

    public override bool[] Encode(java.lang.string str) {
        return vkbksJMXUWxIubyB(this, str, null);
    }

    protected override bool[] Encode(java.lang.string str, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) {
        return (map is not null && BnaIjvHABHMbrwZV(map, com.google.zxing.EncodeHintType.CODE128_COMPACT) && XSduQfsagxPMzEUJ(ouLybKTzoIJQakpN(ZWZCRBAmxKyoVxKF(map, com.google.zxing.EncodeHintType.CODE128_COMPACT)))) ? sVGAVVSyfIdbYGTD(new com.google.zxing.oned.Code128Writer$MinimalEncoder(null), str) : ehZLcpgqcNQflyZr(str, wAYLcnTrRluVocuA(str, map));
    }

    protected override java.util.ICollection<com.google.zxing.BarcodeFormat> GetSupportedWriteFormats() {
        return fixtIzlDjSTymJXH(com.google.zxing.BarcodeFormat.CODE_128);
    }
}

