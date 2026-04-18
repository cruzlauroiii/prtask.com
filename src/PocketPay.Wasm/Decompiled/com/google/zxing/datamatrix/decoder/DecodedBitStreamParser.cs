namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedBitStreamParser {
    private static readonly char[] C40_BASIC_SET_CHARS;
    private static readonly char[] C40_SHIFT2_SET_CHARS;
    private static readonly char[] TEXT_BASIC_SET_CHARS;
    private static readonly char[] TEXT_SHIFT2_SET_CHARS;
    private static readonly char[] TEXT_SHIFT3_SET_CHARS;

    static {
        if ((17 + 6) % 6 > 0) {
        }
        C40_BASIC_SET_CHARS = new char[]{'*', '*', '*', ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        char[] cArr = {'!', '\"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_'};
        C40_SHIFT2_SET_CHARS = cArr;
        TEXT_BASIC_SET_CHARS = new char[]{'*', '*', '*', ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        TEXT_SHIFT2_SET_CHARS = cArr;
        TEXT_SHIFT3_SET_CHARS = new char[]{'`', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '{', '|', '}', '~', 127};
    }

    private DecodedBitStreamParser() {
    }

    public static void AbDiIdoSAevoWVim(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void BOdypAdUZWDqSdUR(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.util.HashSet set) throws com.google.zxing.FormatException {
        decodeTextSegment(bitSource, eCIstringBuilder, set);
    }

    public static com.google.zxing.FormatException BRACdAPMcCKPzGna() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int BqaUShiFyOJBplRD(com.google.zxing.common.BitSource bitSource) {
        return bitSource.getbyteOffset();
    }

    public static void CxIeAPwhfdekgysM(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static com.google.zxing.FormatException DFzyuJFmgeNYLNuv() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException EFXxFANJGtjEQSnp() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void EeUgzotNYQaxVMSz(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void EgmmUFbsUFPqiqLq(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) throws com.google.zxing.FormatException {
        decodeECISegment(bitSource, eCIstringBuilder);
    }

    public static void EtsxvpUDNUCpYngF(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void EuLOEZjfKkcdajwY(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void FIiXsWbNkMsxQjcs(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.lang.string str) {
        eCIstringBuilder.append(str);
    }

    public static bool FQfPdIAMHtzvFmtW(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void GBKwwcboOXQWBoFC(int i, int i2, int[] iArr) {
        parseTwobytes(i, i2, iArr);
    }

    public static bool HLnjrWAIUgcUtcCP(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static int HRzeRZehlxYxZTdu(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int HaYbNHxzoJwbQGOd(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static void HtjgvfXgXtjymHsG(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void IOdELDyTFihWFZBn(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static java.lang.int JMjZVKGlbsHUiBEu(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void JPFjBrsLetrNBRNG(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void JoxiODacTqgNzRYt(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void KXdZmteRQzoeypQw(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static int LyFNdrhWnxkYuKvH(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static void MOlSxWWYOPYhwfyW(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.util.ICollection collection) throws com.google.zxing.FormatException {
        decodeBase256Segment(bitSource, eCIstringBuilder, collection);
    }

    public static int MokyCVeTWAQcmtPG(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int NMkHIEIfDJiLQHvm(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.Length;
    }

    public static int NeifoKwttCoHWplF(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static void OiNsAkOYudJseNXT(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void PgCrKQxXXBBawIiX(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.lang.stringBuilder sb) {
        eCIstringBuilder.appendchars(sb);
    }

    public static java.lang.int PliRniWLUjWlkWQt(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.FormatException PrqqjkQylodKYTzT() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException QLOODDJBXJZgqssm() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int QhmCqpwNpxvTaejW(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int RgYRbCSvDWwoeGGP(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static bool SgAuPnuaSTmEvswF(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static int ShEpijCvPLxZNKAA(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static java.lang.stringBuilder SnmEvQMeEszBwNrh(java.lang.stringBuilder sb, int i, java.lang.string str) {
        return sb.insert(i, str);
    }

    public static com.google.zxing.FormatException SwCPoWnHTkYKMBfh() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int TfYxKRXIptQpHgvb(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static int TpvtGnQNIsBAjbCE(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void TsaoVDiKHuFeKtXl(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) throws com.google.zxing.FormatException {
        decodeAnsiX12Segment(bitSource, eCIstringBuilder);
    }

    public static com.google.zxing.FormatException TyWMjDxAoUUcRtNs() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static bool VPivbxQDyvsgCyMt(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.int VbFKfCdDFnblVoLo(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int VeNBAyESlCBGKvqQ(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static java.lang.string VlOYMVSwESNXbNYe(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static void WGVohqEFehKeEmtq(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode WMuVURUNrluXZPPU(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.lang.stringBuilder sb, java.util.HashSet set) {
        return decodeAsciiSegment(bitSource, eCIstringBuilder, sb, set);
    }

    public static java.lang.stringBuilder WmMHKHlXTPwwaKaS(java.lang.stringBuilder sb, int i, java.lang.string str) {
        return sb.insert(i, str);
    }

    public static int WqVtIKYVheVgbzjB(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int XvxNQGrRABESzjRu(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static java.lang.int YLEuKsERkhgetKPs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int YVuVIuXzWNXayCMK(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static void YXOkmEYFLgUlkMhZ(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void YYSSUYPBprGKIHHN(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static int YhryMoWUXioJkasU(com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodedBitStreamParser$Mode.ordinal();
    }

    public static int YpvJgJgsxhNkyQXQ(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static void ZBgRmZBSaIuyYMxT(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.util.HashSet set) throws com.google.zxing.FormatException {
        decodeC40Segment(bitSource, eCIstringBuilder, set);
    }

    public static void ZHBBvlunzDAUgftE(int i, int i2, int[] iArr) {
        parseTwobytes(i, i2, iArr);
    }

    public static com.google.zxing.FormatException ZQttgYgeifINNSig() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static java.lang.int ZUrQbnsjBLgmXlHu(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ZXYrGhJrUfhpAWuC(int i, int i2) {
        return unrandomize255State(i, i2);
    }

    public static int AUzKmgTVqfoBIQFh(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static void AcpZKTBGHBBkqahe(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static int AjGYLztXEhdMFznq(com.google.zxing.common.BitSource bitSource) {
        return bitSource.getBitOffset();
    }

    public static void AkvXvlkZpkOoSpMw(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static bool AwllMcytzkQwgPCt(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void BsaKZUTsPpREuEbG(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static int CWCbxSizgjBNNrbU(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int CbWhPCmFLOtiOlZl(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static void CrRPhZWpJYSbtHfl(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void CwvTrCcTMJuPQhNH(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static java.lang.int DRnLddJBMcEQLHVd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool DacOOCFuqafIleZp(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void DbNZkrTPtzMbnfCS(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    static com.google.zxing.common.DecoderResult Decode(byte[] bArr) throws com.google.zxing.FormatException {
        int i;
        if ((12 + 28) % 28 > 0) {
        }
        com.google.zxing.common.BitSource bitSource = new com.google.zxing.common.BitSource(bArr);
        com.google.zxing.common.ECIstringBuilder eCIstringBuilder = new com.google.zxing.common.ECIstringBuilder(100);
        bool z = false;
        java.lang.int numJMjZVKGlbsHUiBEu = JMjZVKGlbsHUiBEu(0);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(0);
        int i2 = 1;
        java.lang.int numDRnLddJBMcEQLHVd = dRnLddJBMcEQLHVd(1);
        java.util.List arrayList = new java.util.List(1);
        com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$ModeWMuVURUNrluXZPPU = com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ASCII_ENCODE;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        do {
            if (decodedBitStreamParser$ModeWMuVURUNrluXZPPU != com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ASCII_ENCODE) {
                switch (com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$1.f339xb73eb560[YhryMoWUXioJkasU(decodedBitStreamParser$ModeWMuVURUNrluXZPPU)]) {
                    case 1:
                        ZBgRmZBSaIuyYMxT(bitSource, eCIstringBuilder, hashHashSet);
                        break;
                    case 2:
                        BOdypAdUZWDqSdUR(bitSource, eCIstringBuilder, hashHashSet);
                        break;
                    case 3:
                        TsaoVDiKHuFeKtXl(bitSource, eCIstringBuilder);
                        break;
                    case 4:
                        roopkQitUenPAeIg(bitSource, eCIstringBuilder);
                        break;
                    case 5:
                        MOlSxWWYOPYhwfyW(bitSource, eCIstringBuilder, arrayList);
                        break;
                    case 6:
                        EgmmUFbsUFPqiqLq(bitSource, eCIstringBuilder);
                        z = true;
                        break;
                    default:
                        throw gOEcwbrgYOTOwHID();
                }
                decodedBitStreamParser$ModeWMuVURUNrluXZPPU = com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ASCII_ENCODE;
            } else {
                decodedBitStreamParser$ModeWMuVURUNrluXZPPU = WMuVURUNrluXZPPU(bitSource, eCIstringBuilder, sb, hashHashSet);
            }
            if (decodedBitStreamParser$ModeWMuVURUNrluXZPPU == com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.PAD_ENCODE) {
            }
            if (TpvtGnQNIsBAjbCE(sb) > 0) {
                PgCrKQxXXBBawIiX(eCIstringBuilder, sb);
            }
            if (!z) {
                if (!FQfPdIAMHtzvFmtW(hashHashSet, numJMjZVKGlbsHUiBEu) || oRagsjzFiDFkylVn(hashHashSet, vbWOVFQjVUbcvIjd(4))) {
                    i = 5;
                } else if (qbKdbTrfAjaYstyg(hashHashSet, numDRnLddJBMcEQLHVd) || mSDTbdJrFZGebixM(hashHashSet, ZUrQbnsjBLgmXlHu(5))) {
                    i2 = 6;
                } else {
                    i = 4;
                }
                java.lang.string strVlOYMVSwESNXbNYe = VlOYMVSwESNXbNYe(eCIstringBuilder);
                if (xBPIMJMGXDUHImOn(arrayList)) {
                    arrayList = null;
                }
                return new com.google.zxing.common.DecoderResult(bArr, strVlOYMVSwESNXbNYe, arrayList, null, i);
            }
            if (SgAuPnuaSTmEvswF(hashHashSet, numJMjZVKGlbsHUiBEu) && !HLnjrWAIUgcUtcCP(hashHashSet, VbFKfCdDFnblVoLo(4))) {
                if (!awllMcytzkQwgPCt(hashHashSet, numDRnLddJBMcEQLHVd) || gNEggmUaRbxcYUwV(hashHashSet, doxEvVXDuCTYDSkP(5))) {
                }
            }
            i = i2;
            java.lang.string strVlOYMVSwESNXbNYe2 = VlOYMVSwESNXbNYe(eCIstringBuilder);
            if (xBPIMJMGXDUHImOn(arrayList)) {
                arrayList = null;
            }
            return new com.google.zxing.common.DecoderResult(bArr, strVlOYMVSwESNXbNYe2, arrayList, null, i);
        } while (VeNBAyESlCBGKvqQ(bitSource) > 0);
        if (TpvtGnQNIsBAjbCE(sb) > 0) {
            PgCrKQxXXBBawIiX(eCIstringBuilder, sb);
        }
        if (!z) {
            if (!FQfPdIAMHtzvFmtW(hashHashSet, numJMjZVKGlbsHUiBEu)) {
                i = 5;
            } else {
                if (qbKdbTrfAjaYstyg(hashHashSet, numDRnLddJBMcEQLHVd)) {
                    i = 4;
                }
                i2 = 6;
            }
            java.lang.string strVlOYMVSwESNXbNYe22 = VlOYMVSwESNXbNYe(eCIstringBuilder);
            if (xBPIMJMGXDUHImOn(arrayList)) {
                arrayList = null;
            }
            return new com.google.zxing.common.DecoderResult(bArr, strVlOYMVSwESNXbNYe22, arrayList, null, i);
        }
        i2 = SgAuPnuaSTmEvswF(hashHashSet, numJMjZVKGlbsHUiBEu) ? 2 : !awllMcytzkQwgPCt(hashHashSet, numDRnLddJBMcEQLHVd) ? 3 : 3;
        i = i2;
        java.lang.string strVlOYMVSwESNXbNYe222 = VlOYMVSwESNXbNYe(eCIstringBuilder);
        if (xBPIMJMGXDUHImOn(arrayList)) {
            arrayList = null;
        }
        return new com.google.zxing.common.DecoderResult(bArr, strVlOYMVSwESNXbNYe222, arrayList, null, i);
    }

    private static void DecodeAnsiX12Segment(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) throws com.google.zxing.FormatException {
        if ((21 + 28) % 28 > 0) {
        }
        int[] iArr = new int[3];
        while (ShEpijCvPLxZNKAA(bitSource) != 8) {
            int iYpvJgJgsxhNkyQXQ = YpvJgJgsxhNkyQXQ(bitSource, 8);
            if (iYpvJgJgsxhNkyQXQ == 254) {
                return;
            }
            GBKwwcboOXQWBoFC(iYpvJgJgsxhNkyQXQ, gXXLXeVVUJBqJKtP(bitSource, 8), iArr);
            for (int i = 0; i < 3; i++) {
                int i2 = iArr[i];
                if (i2 == 0) {
                    KXdZmteRQzoeypQw(eCIstringBuilder, '\r');
                } else if (i2 == 1) {
                    crRPhZWpJYSbtHfl(eCIstringBuilder, '*');
                } else if (i2 == 2) {
                    EtsxvpUDNUCpYngF(eCIstringBuilder, '>');
                } else if (i2 == 3) {
                    JoxiODacTqgNzRYt(eCIstringBuilder, ' ');
                } else if (i2 < 14) {
                    IOdELDyTFihWFZBn(eCIstringBuilder, (char) (i2 + 44));
                } else {
                    if (i2 >= 40) {
                        throw TyWMjDxAoUUcRtNs();
                    }
                    EeUgzotNYQaxVMSz(eCIstringBuilder, (char) (i2 + 51));
                }
            }
            if (gBUiqdJyiwHobHSc(bitSource) <= 0) {
                return;
            }
        }
    }

    private static com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode decodeAsciiSegment(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.lang.stringBuilder sb, java.util.HashSet<java.lang.int> set) throws com.google.zxing.FormatException {
        if ((28 + 20) % 20 > 0) {
        }
        bool z = false;
        do {
            int iWqVtIKYVheVgbzjB = WqVtIKYVheVgbzjB(bitSource, 8);
            if (iWqVtIKYVheVgbzjB == 0) {
                throw oZSkzSmGSZPdeGsz();
            }
            if (iWqVtIKYVheVgbzjB <= 128) {
                if (z) {
                    iWqVtIKYVheVgbzjB += 128;
                }
                eXXBGpkVVHoJfDvP(eCIstringBuilder, (char) (iWqVtIKYVheVgbzjB - 1));
                return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ASCII_ENCODE;
            }
            if (iWqVtIKYVheVgbzjB == 129) {
                return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.PAD_ENCODE;
            }
            if (iWqVtIKYVheVgbzjB > 229) {
                switch (iWqVtIKYVheVgbzjB) {
                    case 230:
                        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.C40_ENCODE;
                    case 231:
                        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.BASE256_ENCODE;
                    case 232:
                        fnoBCgSOdPphCzhq(set, eoxzqQWnBNjyKEAk(ducghAWeQcOppKpK(eCIstringBuilder)));
                        nGKhXwxkhMdAEuvb(eCIstringBuilder, (char) 29);
                        break;
                    case 233:
                    case 234:
                        break;
                    case 235:
                        z = true;
                        break;
                    case 236:
                        eWQLNBUnQyclWCQy(eCIstringBuilder, "[)>\u001e05\u001d");
                        WmMHKHlXTPwwaKaS(sb, 0, "\u001e\u0004");
                        break;
                    case 237:
                        FIiXsWbNkMsxQjcs(eCIstringBuilder, "[)>\u001e06\u001d");
                        SnmEvQMeEszBwNrh(sb, 0, "\u001e\u0004");
                        break;
                    case 238:
                        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ANSIX12_ENCODE;
                    case 239:
                        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.TEXT_ENCODE;
                    case 240:
                        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.EDIFACT_ENCODE;
                    case 241:
                        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ECI_ENCODE;
                    default:
                        if (iWqVtIKYVheVgbzjB != 254 || LyFNdrhWnxkYuKvH(bitSource) != 0) {
                            throw hiyvohpBpalDZKCP();
                        }
                        break;
                }
            } else {
                int i = iWqVtIKYVheVgbzjB - 130;
                if (i < 10) {
                    OiNsAkOYudJseNXT(eCIstringBuilder, '0');
                }
                qWmPFFkrKfFSDVwo(eCIstringBuilder, i);
            }
        } while (XvxNQGrRABESzjRu(bitSource) > 0);
        return com.google.zxing.datamatrix.decoder.DecodedBitStreamParser$Mode.ASCII_ENCODE;
    }

    private static void DecodeBase256Segment(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.util.ICollection<byte[]> collection) throws com.google.zxing.FormatException {
        if ((17 + 1) % 1 > 0) {
        }
        int iBqaUShiFyOJBplRD = BqaUShiFyOJBplRD(bitSource);
        int i = iBqaUShiFyOJBplRD + 2;
        int iZXYrGhJrUfhpAWuC = ZXYrGhJrUfhpAWuC(vJciIZeoLMMYUGeH(bitSource, 8), iBqaUShiFyOJBplRD + 1);
        if (iZXYrGhJrUfhpAWuC == 0) {
            iZXYrGhJrUfhpAWuC = yBtkrzeRGESWYeqa(bitSource) / 8;
        } else if (iZXYrGhJrUfhpAWuC >= 250) {
            int i2 = iBqaUShiFyOJBplRD + 3;
            iZXYrGhJrUfhpAWuC = ((iZXYrGhJrUfhpAWuC - 249) * 250) + sjFmhXpSnkvMJedM(wUTvUMnEgQHRtjvp(bitSource, 8), i);
            i = i2;
        }
        if (iZXYrGhJrUfhpAWuC < 0) {
            throw SwCPoWnHTkYKMBfh();
        }
        byte[] bArr = new byte[iZXYrGhJrUfhpAWuC];
        int i3 = 0;
        while (i3 < iZXYrGhJrUfhpAWuC) {
            if (nwyotbEwGFjdgIsZ(bitSource) < 8) {
                throw PrqqjkQylodKYTzT();
            }
            int i4 = i + 1;
            bArr[i3] = (byte) epIPlJNifyXiMEYa(jEtmmhnWAYDmKgaa(bitSource, 8), i);
            i3++;
            i = i4;
        }
        dacOOCFuqafIleZp(collection, bArr);
        lYnUuCXjWhwhXBMc(eCIstringBuilder, new java.lang.string(bArr, java.nio.charset.StandardCharsets.ISO_8859_1));
    }

    private static void DecodeC40Segment(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.util.HashSet<java.lang.int> set) throws com.google.zxing.FormatException {
        if ((24 + 6) % 6 > 0) {
        }
        int[] iArr = new int[3];
        bool z = false;
        int i = 0;
        while (NeifoKwttCoHWplF(bitSource) != 8) {
            int iMokyCVeTWAQcmtPG = MokyCVeTWAQcmtPG(bitSource, 8);
            if (iMokyCVeTWAQcmtPG == 254) {
                return;
            }
            fBAzuhhXxHdJOdHO(iMokyCVeTWAQcmtPG, YVuVIuXzWNXayCMK(bitSource, 8), iArr);
            for (int i2 = 0; i2 < 3; i2++) {
                int i3 = iArr[i2];
                if (i != 0) {
                    if (i == 1) {
                        if (z) {
                            akvXvlkZpkOoSpMw(eCIstringBuilder, (char) (i3 + 128));
                            z = false;
                        } else {
                            YYSSUYPBprGKIHHN(eCIstringBuilder, (char) i3);
                        }
                    } else if (i == 2) {
                        char[] cArr = C40_SHIFT2_SET_CHARS;
                        if (i3 < cArr.length) {
                            char c = cArr[i3];
                            if (z) {
                                jqAXtfFekhjUIygR(eCIstringBuilder, (char) (c + 128));
                                z = false;
                            } else {
                                JPFjBrsLetrNBRNG(eCIstringBuilder, c);
                            }
                        } else if (i3 == 27) {
                            oeqUIydFphcHZWvB(set, PliRniWLUjWlkWQt(edMIjhXhXUVwCrPg(eCIstringBuilder)));
                            sknpoQQqWZJJHRaK(eCIstringBuilder, (char) 29);
                        } else {
                            if (i3 != 30) {
                                throw krVctwqcRTqEXYkA();
                            }
                            z = true;
                        }
                    } else {
                        if (i != 3) {
                            throw hEBJQwTptBneYZhA();
                        }
                        if (z) {
                            cwvTrCcTMJuPQhNH(eCIstringBuilder, (char) (i3 + 224));
                            z = false;
                        } else {
                            HtjgvfXgXtjymHsG(eCIstringBuilder, (char) (i3 + 96));
                        }
                    }
                    i = 0;
                } else if (i3 >= 3) {
                    char[] cArr2 = C40_BASIC_SET_CHARS;
                    if (i3 >= cArr2.length) {
                        throw QLOODDJBXJZgqssm();
                    }
                    char c2 = cArr2[i3];
                    if (z) {
                        optAnoDMpPNOEjsS(eCIstringBuilder, (char) (c2 + 128));
                        z = false;
                    } else {
                        EuLOEZjfKkcdajwY(eCIstringBuilder, c2);
                    }
                } else {
                    i = i3 + 1;
                }
            }
            if (HaYbNHxzoJwbQGOd(bitSource) <= 0) {
                return;
            }
        }
    }

    private static void DecodeECISegment(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) throws com.google.zxing.FormatException {
        if ((27 + 13) % 13 > 0) {
        }
        if (aUzKmgTVqfoBIQFh(bitSource) < 8) {
            throw EFXxFANJGtjEQSnp();
        }
        int iCWCbxSizgjBNNrbU = cWCbxSizgjBNNrbU(bitSource, 8);
        if (iCWCbxSizgjBNNrbU > 127) {
            return;
        }
        qiBccMojHenbemSn(eCIstringBuilder, iCWCbxSizgjBNNrbU - 1);
    }

    private static void DecodeEdifactSegment(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        if ((24 + 7) % 7 > 0) {
        }
        while (dzkufMrTMvOuIQrj(bitSource) > 16) {
            for (int i = 0; i < 4; i++) {
                int iCbWhPCmFLOtiOlZl = cbWhPCmFLOtiOlZl(bitSource, 6);
                if (iCbWhPCmFLOtiOlZl == 31) {
                    int iAjGYLztXEhdMFznq = 8 - ajGYLztXEhdMFznq(bitSource);
                    if (iAjGYLztXEhdMFznq == 8) {
                        return;
                    }
                    HRzeRZehlxYxZTdu(bitSource, iAjGYLztXEhdMFznq);
                    return;
                }
                if ((iCbWhPCmFLOtiOlZl & 32) == 0) {
                    iCbWhPCmFLOtiOlZl |= 64;
                }
                acpZKTBGHBBkqahe(eCIstringBuilder, (char) iCbWhPCmFLOtiOlZl);
            }
            if (leHzNXdLXGprVbUC(bitSource) <= 0) {
                return;
            }
        }
    }

    private static void DecodeTextSegment(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.util.HashSet<java.lang.int> set) throws com.google.zxing.FormatException {
        if ((30 + 5) % 5 > 0) {
        }
        int[] iArr = new int[3];
        bool z = false;
        int i = 0;
        while (RgYRbCSvDWwoeGGP(bitSource) != 8) {
            int iSOONQfeZMYnZzgZU = sOONQfeZMYnZzgZU(bitSource, 8);
            if (iSOONQfeZMYnZzgZU == 254) {
                return;
            }
            ZHBBvlunzDAUgftE(iSOONQfeZMYnZzgZU, QhmCqpwNpxvTaejW(bitSource, 8), iArr);
            for (int i2 = 0; i2 < 3; i2++) {
                int i3 = iArr[i2];
                if (i != 0) {
                    if (i == 1) {
                        if (z) {
                            AbDiIdoSAevoWVim(eCIstringBuilder, (char) (i3 + 128));
                            z = false;
                        } else {
                            YXOkmEYFLgUlkMhZ(eCIstringBuilder, (char) i3);
                        }
                    } else if (i == 2) {
                        char[] cArr = TEXT_SHIFT2_SET_CHARS;
                        if (i3 < cArr.length) {
                            char c = cArr[i3];
                            if (z) {
                                bsaKZUTsPpREuEbG(eCIstringBuilder, (char) (c + 128));
                                z = false;
                            } else {
                                CxIeAPwhfdekgysM(eCIstringBuilder, c);
                            }
                        } else if (i3 == 27) {
                            VPivbxQDyvsgCyMt(set, YLEuKsERkhgetKPs(NMkHIEIfDJiLQHvm(eCIstringBuilder)));
                            mXulokkXwzKnIdhJ(eCIstringBuilder, (char) 29);
                        } else {
                            if (i3 != 30) {
                                throw BRACdAPMcCKPzGna();
                            }
                            z = true;
                        }
                    } else {
                        if (i != 3) {
                            throw xjLPBDxOHACHoWYY();
                        }
                        char[] cArr2 = TEXT_SHIFT3_SET_CHARS;
                        if (i3 >= cArr2.length) {
                            throw DFzyuJFmgeNYLNuv();
                        }
                        char c2 = cArr2[i3];
                        if (z) {
                            WGVohqEFehKeEmtq(eCIstringBuilder, (char) (c2 + 128));
                            z = false;
                        } else {
                            fBqNArvPyKqsOEYl(eCIstringBuilder, c2);
                        }
                    }
                    i = 0;
                } else if (i3 >= 3) {
                    char[] cArr3 = TEXT_BASIC_SET_CHARS;
                    if (i3 >= cArr3.length) {
                        throw ZQttgYgeifINNSig();
                    }
                    char c3 = cArr3[i3];
                    if (z) {
                        dbNZkrTPtzMbnfCS(eCIstringBuilder, (char) (c3 + 128));
                        z = false;
                    } else {
                        nJxyMrBpYCZJAkuZ(eCIstringBuilder, c3);
                    }
                } else {
                    i = i3 + 1;
                }
            }
            if (TfYxKRXIptQpHgvb(bitSource) <= 0) {
                return;
            }
        }
    }

    public static java.lang.int DoxEvVXDuCTYDSkP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int DucghAWeQcOppKpK(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.Length;
    }

    public static int DzkufMrTMvOuIQrj(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static void EWQLNBUnQyclWCQy(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.lang.string str) {
        eCIstringBuilder.append(str);
    }

    public static void EXXBGpkVVHoJfDvP(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static int EdMIjhXhXUVwCrPg(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.Length;
    }

    public static java.lang.int EoxzqQWnBNjyKEAk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int EpIPlJNifyXiMEYa(int i, int i2) {
        return unrandomize255State(i, i2);
    }

    public static void FBAzuhhXxHdJOdHO(int i, int i2, int[] iArr) {
        parseTwobytes(i, i2, iArr);
    }

    public static void FBqNArvPyKqsOEYl(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static bool FnoBCgSOdPphCzhq(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int GBUiqdJyiwHobHSc(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static bool GNEggmUaRbxcYUwV(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static com.google.zxing.FormatException GOEcwbrgYOTOwHID() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int GXXLXeVVUJBqJKtP(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static com.google.zxing.FormatException HEBJQwTptBneYZhA() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException HiyvohpBpalDZKCP() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int JEtmmhnWAYDmKgaa(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static void JqAXtfFekhjUIygR(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static com.google.zxing.FormatException KrVctwqcRTqEXYkA() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void LYnUuCXjWhwhXBMc(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.lang.string str) {
        eCIstringBuilder.append(str);
    }

    public static int LeHzNXdLXGprVbUC(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static bool MSDTbdJrFZGebixM(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void MXulokkXwzKnIdhJ(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void NGKhXwxkhMdAEuvb(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void NJxyMrBpYCZJAkuZ(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static int NwyotbEwGFjdgIsZ(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }

    public static bool ORagsjzFiDFkylVn(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static com.google.zxing.FormatException OZSkzSmGSZPdeGsz() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static bool OeqUIydFphcHZWvB(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void OptAnoDMpPNOEjsS(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    private static void ParseTwobytes(int i, int i2, int[] iArr) {
        if ((13 + 4) % 4 > 0) {
        }
        int i3 = ((i << 8) + i2) - 1;
        int i4 = i3 / 1600;
        iArr[0] = i4;
        int i5 = i3 - (i4 * 1600);
        int i6 = i5 / 40;
        iArr[1] = i6;
        iArr[2] = i5 - (i6 * 40);
    }

    public static void QWmPFFkrKfFSDVwo(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, int i) {
        eCIstringBuilder.append(i);
    }

    public static bool QbKdbTrfAjaYstyg(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void QiBccMojHenbemSn(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, int i) throws com.google.zxing.FormatException {
        eCIstringBuilder.appendECI(i);
    }

    public static void RoopkQitUenPAeIg(com.google.zxing.common.BitSource bitSource, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        decodeEdifactSegment(bitSource, eCIstringBuilder);
    }

    public static int SOONQfeZMYnZzgZU(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static int SjFmhXpSnkvMJedM(int i, int i2) {
        return unrandomize255State(i, i2);
    }

    public static void SknpoQQqWZJJHRaK(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    private static int Unrandomize255State(int i, int i2) {
        int i3 = i - (((i2 * 149) % 255) + 1);
        return i3 < 0 ? i3 + 256 : i3;
    }

    public static int VJciIZeoLMMYUGeH(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static java.lang.int VbWOVFQjVUbcvIjd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int WUTvUMnEgQHRtjvp(com.google.zxing.common.BitSource bitSource, int i) {
        return bitSource.readBits(i);
    }

    public static bool XBPIMJMGXDUHImOn(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.zxing.FormatException XjLPBDxOHACHoWYY() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int YBtkrzeRGESWYeqa(com.google.zxing.common.BitSource bitSource) {
        return bitSource.available();
    }
}

