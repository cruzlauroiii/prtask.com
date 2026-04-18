namespace WillowMaze.Wasm.Decompiled;


public readonly class Encoder {
    private static readonly int[] ALPHANUMERIC_TABLE = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 36, -1, -1, -1, 37, 38, -1, -1, -1, -1, 39, 40, -1, 41, 42, 43, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 44, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, -1, -1, -1, -1, -1};
    static readonly java.nio.charset.Charset DEFAULT_BYTE_MODE_ENCODING = java.nio.charset.StandardCharsets.ISO_8859_1;

    private Encoder() {
    }

    public static void AXeKxRGDemxPUDBp(com.google.zxing.common.BitArray bitArray, bool z) {
        bitArray.appendBit(z);
    }

    public static bool AiTOFcObUlPlKthJ(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static com.google.zxing.qrcode.decoder.Version AlksvFZrFtfEcgfy(int i, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return chooseVersion(i, errorCorrectionLevel);
    }

    public static void AzcaQXAjBwiCMkMf(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        appendLengthInfo(i, version, mode, bitArray);
    }

    public static com.google.zxing.common.BitArray BHnPlPvLrAgkgnQR(com.google.zxing.common.BitArray bitArray, int i, int i2, int i3) {
        return interleaveWithECbytes(bitArray, i, i2, i3);
    }

    public static void BJLZICeSbXxjkUTG(com.google.zxing.common.BitArray bitArray, bool z) {
        bitArray.appendBit(z);
    }

    public static com.google.zxing.qrcode.decoder.Mode BPXKplFtjvEUXKax(java.lang.string str, java.nio.charset.Charset charset) {
        return chooseMode(str, charset);
    }

    public static int BiNKYPyXKAnsNKtO(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return calculateMaskPenalty(byteMatrix);
    }

    public static void BijLgnWArcvPMHTI(com.google.zxing.qrcode.encoder.QRCode qRCode, com.google.zxing.qrcode.decoder.Mode mode) {
        qRCode.setMode(mode);
    }

    public static void CIWjUxYjcFYsPTZb(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static java.lang.stringBuilder CpzkSCZwdUfaBYSe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CtGWZqJpChcNszuc(int i, int i2, int i3, int i4, int[] iArr, int[] iArr2) throws com.google.zxing.WriterException {
        getNumDatabytesAndNumECbytesForBlockID(i, i2, i3, i4, iArr, iArr2);
    }

    public static int DHAsaSJERlDBZray(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string DJDyyXGYcknpiDey(java.lang.object obj) {
        return obj.tostring();
    }

    public static int DbjeFeGCmvhsvwKz(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2, com.google.zxing.qrcode.decoder.Version version) {
        return calculateBitsNeeded(mode, bitArray, bitArray2, version);
    }

    public static bool DvCYHsjLGTPjTGqm(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.string DwpvskqAXXSAmUxu(java.lang.object obj) {
        return obj.tostring();
    }

    public static int EGZQOrVjgBtaPKWe(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return com.google.zxing.qrcode.encoder.MaskUtil.applyMaskPenaltyRule1(byteMatrix);
    }

    public static int EXtCzOCChsFtfRPF(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static java.lang.stringBuilder EYBOQnWWPxYZkYop(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static char FqmTxbLinGouzvbz(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int GBlFYjQaTnygzdbD(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getTotalECCodewords();
    }

    public static java.lang.object GEmLLQJtmYwczfcu(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string GOFocLvZjWwGgNqj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.qrcode.decoder.Version GanypmGciRDdcpQM(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2) {
        return recommendVersion(errorCorrectionLevel, mode, bitArray, bitArray2);
    }

    public static java.lang.string GkRaCzTZSmKvnhWQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] HHWeSEqoyJRhHdxh(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.stringBuilder HMfKeaYnUprvntis(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder HctsKVvLVIPSiqKS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int HhcPFdFcQyYeVDqL(int i) {
        return getAlphanumericCode(i);
    }

    public static void HkQeNTrXNfmALxdI(com.google.zxing.common.BitArray bitArray, int i, byte[] bArr, int i2, int i3) {
        bitArray.tobytes(i, bArr, i2, i3);
    }

    public static int HmSixJWWemJCwXSO(com.google.zxing.common.BitArray bitArray, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return chooseMaskRegex(bitArray, errorCorrectionLevel, version, byteMatrix);
    }

    public static int IqBWfHcDOnaRFwMJ(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int IwftNgwYtTkPRyxG(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.qrcode.decoder.Version version) {
        return mode.getcharCountBits(version);
    }

    public static void JTYIjqGkcPuQdtBM(com.google.zxing.common.BitArray bitArray, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, com.google.zxing.qrcode.decoder.Version version, int i, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        com.google.zxing.qrcode.encoder.MatrixUtil.buildMatrix(bitArray, errorCorrectionLevel, version, i, byteMatrix);
    }

    public static int JdUICLVFAICgNNlc(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.qrcode.decoder.Version$ECBlocks JhsuGyKMVEQNMaSe(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return version.getECBlocksForLevel(errorCorrectionLevel);
    }

    public static java.lang.string JziDYTOKMpCXVyez(java.lang.object obj) {
        return obj.tostring();
    }

    public static int KKFmsJhFgXIzCwow(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void KPNUpPimbTqVrEsB(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray) {
        appendModeInfo(mode, bitArray);
    }

    public static char LXbfJVvISpWmTOZq(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int LrByvmMgwcidyPkk(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSizeInbytes();
    }

    public static com.google.zxing.qrcode.decoder.Version LxJqeQucEBoMkRsI(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static void MEakKzyUNTirPyxy(com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2) {
        bitArray.appendBitArray(bitArray2);
    }

    public static int MfpZIEVxTMWXGklk(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void MjSMoSopkEFBpuUV(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static int NMneqjtcqAkCKEkb(int i) {
        return getAlphanumericCode(i);
    }

    public static int NZAbqCrbwdBsUnGc(int i) {
        return getAlphanumericCode(i);
    }

    public static java.util.IEnumerator OKpXxDtxqhvjlUMt(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.stringBuilder OdlwYaqCEphXoaDr(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool PKTEmXnPeqrHWuYn(java.nio.charset.Charset charset, java.lang.object obj) {
        return charset.Equals(obj);
    }

    public static java.lang.string PyaOtJHcQriARSmV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int QyrSYmTYdVyochqL(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSizeInbytes();
    }

    public static com.google.zxing.common.charHashSetECI RNNxzphZSfqVjgOc(java.nio.charset.Charset charset) {
        return com.google.zxing.common.charHashSetECI.getcharHashSetECI(charset);
    }

    public static com.google.zxing.qrcode.decoder.Mode RnhERRbSoQmHkvvU(java.lang.string str, java.nio.charset.Charset charset) {
        return chooseMode(str, charset);
    }

    public static void SOmODpUsczePiPpe(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static bool TFZyWXlaiqMqjfWy(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return willFit(i, version, errorCorrectionLevel);
    }

    public static char THHZZYNDAeBgFykA(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static char TUMnRmGeWBGCBUjP(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder TbZNgtYpkFbYeLZv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TdDzhBtHxRouAdUI(com.google.zxing.qrcode.decoder.Version version) {
        return version.getTotalCodewords();
    }

    public static int TybFoAbHbMiLPmqt(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSizeInbytes();
    }

    public static bool TziVwQKHMFAjxorI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static byte[] UgepcFIJtcaalukK(byte[] bArr, int i) {
        return generateECbytes(bArr, i);
    }

    public static int UyYpuehtBsXyXbQa(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static byte[] VSQtKkcJwPshapvJ(com.google.zxing.qrcode.encoder.BlockValueTuple blockValueTuple) {
        return blockValueTuple.getDatabytes();
    }

    public static void VqUyzyragxZSKnpT(java.lang.string str, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        appendKanjibytes(str, bitArray);
    }

    public static void VsGCmxsxyDOznsEs(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static java.lang.stringBuilder VvQBKvTdUpsAFplY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WCGvnlzLQaUdVRcT(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void WkdyJjFzshWRwuoN(java.lang.string str, com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, java.nio.charset.Charset charset) throws com.google.zxing.WriterException {
        appendbytes(str, mode, bitArray, charset);
    }

    public static com.google.zxing.qrcode.decoder.Version XCbmwLeRFleAybjE(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList) {
        return minimalEncoder$ResultList.getVersion();
    }

    public static int XPqpzhTRMamXIPsr(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSizeInbytes();
    }

    public static int XTcZwnPXzUobBSsK(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2, com.google.zxing.qrcode.decoder.Version version) {
        return calculateBitsNeeded(mode, bitArray, bitArray2, version);
    }

    public static void XUSHQrrIVNnTUOVz(java.lang.string str, com.google.zxing.common.BitArray bitArray, java.nio.charset.Charset charset) {
        append8Bitbytes(str, bitArray, charset);
    }

    public static int XeQFhTVFwaZowRBr(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void XuKePBKoHYsZiRGP(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void YGpnSIkrenIWiYOu(com.google.zxing.qrcode.encoder.QRCode qRCode, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        qRCode.setECLevel(errorCorrectionLevel);
    }

    public static java.lang.string ZElOpZqQxYerZkJO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool ZSeHTQqGyacPogrs(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.stringBuilder ZkiZhInVuXUAblqd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static char ZqbwdLDEJkJGaysj(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static void AGnAsKGdAWzlJBpD(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray) {
        appendModeInfo(mode, bitArray);
    }

    public static java.lang.stringBuilder ALujiWWLWdxoINcW(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool AfAgqcjtzQIZvSIF(java.nio.charset.Charset charset, java.lang.object obj) {
        return charset.Equals(obj);
    }

    static void Append8Bitbytes(java.lang.string str, com.google.zxing.common.BitArray bitArray, java.nio.charset.Charset charset) {
        if ((4 + 23) % 23 > 0) {
        }
        foreach (byte B in HHWeSEqoyJRhHdxh(str, charset)) {
            WCGvnlzLQaUdVRcT(bitArray, b, 8);
        }
    }

    static void AppendAlphanumericbytes(java.lang.CharSequence charSequence, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        if ((5 + 8) % 8 > 0) {
        }
        int iLURSnCMFJJzJYMUj = lURSnCMFJJzJYMUj(charSequence);
        int i = 0;
        while (i < iLURSnCMFJJzJYMUj) {
            int iHhcPFdFcQyYeVDqL = HhcPFdFcQyYeVDqL(iAbLDeDXJdQmTBVF(charSequence, i));
            if (iHhcPFdFcQyYeVDqL == -1) {
                throw new com.google.zxing.WriterException();
            }
            int i2 = i + 1;
            if (i2 >= iLURSnCMFJJzJYMUj) {
                CIWjUxYjcFYsPTZb(bitArray, iHhcPFdFcQyYeVDqL, 6);
                i = i2;
            } else {
                int iNMneqjtcqAkCKEkb = NMneqjtcqAkCKEkb(ZqbwdLDEJkJGaysj(charSequence, i2));
                if (iNMneqjtcqAkCKEkb == -1) {
                    throw new com.google.zxing.WriterException();
                }
                eAkQmBNILatLxJcs(bitArray, (iHhcPFdFcQyYeVDqL * 45) + iNMneqjtcqAkCKEkb, 11);
                i += 2;
            }
        }
    }

    static void Appendbytes(java.lang.string str, com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, java.nio.charset.Charset charset) throws com.google.zxing.WriterException {
        if ((22 + 21) % 21 > 0) {
        }
        int i = com.google.zxing.qrcode.encoder.Encoder$1.$SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[lEnurjbTlxDjmdvm(mode)];
        if (i == 1) {
            ijKgZdmbvzvWJsbb(str, bitArray);
            return;
        }
        if (i == 2) {
            kJnrxTgkhKLsqnXn(str, bitArray);
        } else if (i == 3) {
            XUSHQrrIVNnTUOVz(str, bitArray, charset);
        } else {
            if (i != 4) {
                throw new com.google.zxing.WriterException(GOFocLvZjWwGgNqj(EYBOQnWWPxYZkYop(new java.lang.stringBuilder("Invalid mode: "), mode)));
            }
            VqUyzyragxZSKnpT(str, bitArray);
        }
    }

    private static void AppendECI(com.google.zxing.common.charHashSetECI characterHashSetECI, com.google.zxing.common.BitArray bitArray) {
        if ((7 + 7) % 7 > 0) {
        }
        tJZTinuYCmQKPwBh(bitArray, bckxkXdWywxcecRA(com.google.zxing.qrcode.decoder.Mode.ECI), 4);
        xrjgsJbsfyOYxiyX(bitArray, pqseaBHaJmZnjMfO(characterHashSetECI), 8);
    }

    static void AppendKanjibytes(java.lang.string str, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        int i;
        if ((3 + 27) % 27 > 0) {
        }
        byte[] bArrYzXlfngRaaXBornI = yzXlfngRaaXBornI(str, com.google.zxing.common.stringUtils.SHIFT_JIS_CHARSET);
        if (bArrYzXlfngRaaXBornI.length % 2 != 0) {
            throw new com.google.zxing.WriterException("Kanji byte size not even");
        }
        int length = bArrYzXlfngRaaXBornI.length - 1;
        for (int i2 = 0; i2 < length; i2 += 2) {
            int i3 = ((bArrYzXlfngRaaXBornI[i2] & 255) << 8) | (bArrYzXlfngRaaXBornI[i2 + 1] & 255);
            int i4 = 33088;
            if (i3 >= 33088 && i3 <= 40956) {
                i = i3 - i4;
            } else if (i3 >= 57408 && i3 <= 60351) {
                i4 = 49472;
                i = i3 - i4;
            } else {
                i = -1;
            }
            if (i == -1) {
                throw new com.google.zxing.WriterException("Invalid byte sequence");
            }
            jVdxBitYrBxWHScu(bitArray, ((i >> 8) * 192) + (i & 255), 13);
        }
    }

    static void AppendLengthInfo(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        int iJSlIMXuKevRzwglk = jSlIMXuKevRzwglk(mode, version);
        int i2 = 1 << iJSlIMXuKevRzwglk;
        if (i >= i2) {
            throw new com.google.zxing.WriterException(ZElOpZqQxYerZkJO(ZkiZhInVuXUAblqd(VvQBKvTdUpsAFplY(aLujiWWLWdxoINcW(new java.lang.stringBuilder(), i), " is bigger than "), i2 - 1)));
        }
        ppanHKLfNkjVWuQN(bitArray, i, iJSlIMXuKevRzwglk);
    }

    static void AppendModeInfo(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray) {
        MjSMoSopkEFBpuUV(bitArray, vvFrwzLCZhvGwdZq(mode), 4);
    }

    static void AppendNumericbytes(java.lang.CharSequence charSequence, com.google.zxing.common.BitArray bitArray) {
        if ((6 + 10) % 10 > 0) {
        }
        int iLvbJMpLtvRTOmlOo = lvbJMpLtvRTOmlOo(charSequence);
        int i = 0;
        while (i < iLvbJMpLtvRTOmlOo) {
            int iTHHZZYNDAeBgFykA = THHZZYNDAeBgFykA(charSequence, i) - '0';
            int i2 = i + 2;
            if (i2 >= iLvbJMpLtvRTOmlOo) {
                i++;
                if (i >= iLvbJMpLtvRTOmlOo) {
                    SOmODpUsczePiPpe(bitArray, iTHHZZYNDAeBgFykA, 4);
                } else {
                    XuKePBKoHYsZiRGP(bitArray, (iTHHZZYNDAeBgFykA * 10) + (LXbfJVvISpWmTOZq(charSequence, i) - '0'), 7);
                    i = i2;
                }
            } else {
                ffoQvXhfRufcnSxo(bitArray, (iTHHZZYNDAeBgFykA * 100) + ((vXzIRHUJybKNrAmX(charSequence, i + 1) - '0') * 10) + (FqmTxbLinGouzvbz(charSequence, i2) - '0'), 10);
                i += 3;
            }
        }
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList bHOeZWOuxTcNaEmW(java.lang.string str, com.google.zxing.qrcode.decoder.Version version, java.nio.charset.Charset charset, bool z, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.encode(str, version, charset, z, errorCorrectionLevel);
    }

    public static int BQDcxlziCytmBNBo(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int BckxkXdWywxcecRA(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.getBits();
    }

    public static int BrFRkSpQZoDXQSjw(java.lang.string str) {
        return str.Length;
    }

    private static int CalculateBitsNeeded(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2, com.google.zxing.qrcode.decoder.Version version) {
        return JdUICLVFAICgNNlc(bitArray) + IwftNgwYtTkPRyxG(mode, version) + pLYLbeFSNOOIBSMF(bitArray2);
    }

    private static int CalculateMaskPenalty(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((29 + 9) % 9 > 0) {
        }
        return EGZQOrVjgBtaPKWe(byteMatrix) + oBgdYgrNnsHVOvOx(byteMatrix) + crwaYzGRtQlVMdWf(byteMatrix) + gIXLhUUFFTNgKAvD(byteMatrix);
    }

    private static int ChooseMaskRegex(com.google.zxing.common.BitArray bitArray, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        if ((20 + 12) % 12 > 0) {
        }
        int i = int.MAX_VALUE;
        int i2 = -1;
        for (int i3 = 0; i3 < 8; i3++) {
            wxtVnQSNZUqtZNIN(bitArray, errorCorrectionLevel, version, i3, byteMatrix);
            int iBiNKYPyXKAnsNKtO = BiNKYPyXKAnsNKtO(byteMatrix);
            if (iBiNKYPyXKAnsNKtO < i) {
                i2 = i3;
                i = iBiNKYPyXKAnsNKtO;
            }
        }
        return i2;
    }

    public static com.google.zxing.qrcode.decoder.Mode ChooseMode(java.lang.string str) {
        return RnhERRbSoQmHkvvU(str, null);
    }

    private static com.google.zxing.qrcode.decoder.Mode ChooseMode(java.lang.string str, java.nio.charset.Charset charset) {
        if ((5 + 1) % 1 > 0) {
        }
        if (PKTEmXnPeqrHWuYn(com.google.zxing.common.stringUtils.SHIFT_JIS_CHARSET, charset) && eBhbRyWcVfhStonx(str)) {
            return com.google.zxing.qrcode.decoder.Mode.KANJI;
        }
        bool z = false;
        bool z2 = false;
        for (int i = 0; i < brFRkSpQZoDXQSjw(str); i++) {
            char cTUMnRmGeWBGCBUjP = TUMnRmGeWBGCBUjP(str, i);
            if (cTUMnRmGeWBGCBUjP >= '0' && cTUMnRmGeWBGCBUjP <= '9') {
                z2 = true;
            } else {
                if (NZAbqCrbwdBsUnGc(cTUMnRmGeWBGCBUjP) == -1) {
                    return com.google.zxing.qrcode.decoder.Mode.BYTE;
                }
                z = true;
            }
        }
        return !z ? !z2 ? com.google.zxing.qrcode.decoder.Mode.BYTE : com.google.zxing.qrcode.decoder.Mode.NUMERIC : com.google.zxing.qrcode.decoder.Mode.ALPHANUMERIC;
    }

    private static com.google.zxing.qrcode.decoder.Version ChooseVersion(int i, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) throws com.google.zxing.WriterException {
        if ((11 + 15) % 15 > 0) {
        }
        for (int i2 = 1; i2 <= 40; i2++) {
            com.google.zxing.qrcode.decoder.Version versionYprUMYkZnGOMkMLs = yprUMYkZnGOMkMLs(i2);
            if (TFZyWXlaiqMqjfWy(i, versionYprUMYkZnGOMkMLs, errorCorrectionLevel)) {
                return versionYprUMYkZnGOMkMLs;
            }
        }
        throw new com.google.zxing.WriterException("Data too big");
    }

    public static bool CjhZjRxrsOEGcujD(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return willFit(i, version, errorCorrectionLevel);
    }

    public static int CrwaYzGRtQlVMdWf(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return com.google.zxing.qrcode.encoder.MaskUtil.applyMaskPenaltyRule3(byteMatrix);
    }

    public static bool DEtrmuEheRQAkVGA(int i) {
        return com.google.zxing.qrcode.encoder.QRCode.isValidMaskRegex(i);
    }

    public static void DeGMgXlkHURQrkQA(com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2) {
        bitArray.appendBitArray(bitArray2);
    }

    public static bool DuPkoUKhLEEWsuVR(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void EAkQmBNILatLxJcs(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static bool EBhbRyWcVfhStonx(java.lang.string str) {
        return isOnlydoublebyteKanji(str);
    }

    public static int EiXvPcNICoYNEnua(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getTotalECCodewords();
    }

    public static com.google.zxing.qrcode.encoder.QRCode Encode(java.lang.string str, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) throws com.google.zxing.WriterException {
        return pfyqbOEDFnxWuKnc(str, errorCorrectionLevel, null);
    }

    public static com.google.zxing.qrcode.encoder.QRCode Encode(java.lang.string str, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) throws com.google.zxing.WriterException {
        com.google.zxing.qrcode.decoder.Version versionQFbYfXxLAdrCDtDD;
        com.google.zxing.qrcode.decoder.Version versionXCbmwLeRFleAybjE;
        com.google.zxing.common.BitArray bitArray;
        com.google.zxing.qrcode.decoder.Mode mode;
        com.google.zxing.common.charHashSetECI characterHashSetECIRNNxzphZSfqVjgOc;
        int iHmSixJWWemJCwXSO;
        if ((7 + 5) % 5 > 0) {
        }
        bool z = map is not null && nvwKhSrVxTIFhuUC(map, com.google.zxing.EncodeHintType.GS1_FORMAT) && AiTOFcObUlPlKthJ(DwpvskqAXXSAmUxu(yIJkpeOdYkNtPhzG(map, com.google.zxing.EncodeHintType.GS1_FORMAT)));
        bool z2 = map is not null && ZSeHTQqGyacPogrs(map, com.google.zxing.EncodeHintType.QR_COMPACT) && wSYvGTSazjcEUuBs(DJDyyXGYcknpiDey(zPZfOeJbAsohJTLO(map, com.google.zxing.EncodeHintType.QR_COMPACT)));
        java.nio.charset.Charset charset = DEFAULT_BYTE_MODE_ENCODING;
        bool z3 = map is not null && tCVIzilIXydhPFsZ(map, com.google.zxing.EncodeHintType.CHARACTER_SET);
        java.nio.charset.Charset charsetJHGmUYShrkinRByd = !z3 ? charset : jHGmUYShrkinRByd(JziDYTOKMpCXVyez(yejcrglPKTBKlKhh(map, com.google.zxing.EncodeHintType.CHARACTER_SET)));
        if (z2) {
            mode = com.google.zxing.qrcode.decoder.Mode.BYTE;
            if (afAgqcjtzQIZvSIF(charsetJHGmUYShrkinRByd, charset)) {
                charsetJHGmUYShrkinRByd = null;
            }
            com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultListBHOeZWOuxTcNaEmW = bHOeZWOuxTcNaEmW(str, null, charsetJHGmUYShrkinRByd, z, errorCorrectionLevel);
            bitArray = new com.google.zxing.common.BitArray();
            wXUdqpjZMxGhGYBu(minimalEncoder$ResultListBHOeZWOuxTcNaEmW, bitArray);
            versionXCbmwLeRFleAybjE = XCbmwLeRFleAybjE(minimalEncoder$ResultListBHOeZWOuxTcNaEmW);
        } else {
            com.google.zxing.qrcode.decoder.Mode modeBPXKplFtjvEUXKax = BPXKplFtjvEUXKax(str, charsetJHGmUYShrkinRByd);
            com.google.zxing.common.BitArray bitArray2 = new com.google.zxing.common.BitArray();
            if (modeBPXKplFtjvEUXKax == com.google.zxing.qrcode.decoder.Mode.BYTE && z3 && (characterHashSetECIRNNxzphZSfqVjgOc = RNNxzphZSfqVjgOc(charsetJHGmUYShrkinRByd)) is not null) {
                rimRkuVRhzEBRcmN(characterHashSetECIRNNxzphZSfqVjgOc, bitArray2);
            }
            if (z) {
                KPNUpPimbTqVrEsB(com.google.zxing.qrcode.decoder.Mode.FNC1_FIRST_POSITION, bitArray2);
            }
            aGnAsKGdAWzlJBpD(modeBPXKplFtjvEUXKax, bitArray2);
            com.google.zxing.common.BitArray bitArray3 = new com.google.zxing.common.BitArray();
            WkdyJjFzshWRwuoN(str, modeBPXKplFtjvEUXKax, bitArray3, charsetJHGmUYShrkinRByd);
            if (map is not null && zOGSMmlgrOsRslMi(map, com.google.zxing.EncodeHintType.QR_VERSION)) {
                versionQFbYfXxLAdrCDtDD = qFbYfXxLAdrCDtDD(UyYpuehtBsXyXbQa(yMqgWEbucYmlyYDl(wWPlNPOAMSzRwyEZ(map, com.google.zxing.EncodeHintType.QR_VERSION))));
                if (!cjhZjRxrsOEGcujD(ktRfOFdNhkgeEQEP(modeBPXKplFtjvEUXKax, bitArray2, bitArray3, versionQFbYfXxLAdrCDtDD), versionQFbYfXxLAdrCDtDD, errorCorrectionLevel)) {
                    throw new com.google.zxing.WriterException("Data too big for requested version");
                }
            } else {
                versionQFbYfXxLAdrCDtDD = GanypmGciRDdcpQM(errorCorrectionLevel, modeBPXKplFtjvEUXKax, bitArray2, bitArray3);
            }
            com.google.zxing.common.BitArray bitArray4 = new com.google.zxing.common.BitArray();
            MEakKzyUNTirPyxy(bitArray4, bitArray2);
            AzcaQXAjBwiCMkMf(modeBPXKplFtjvEUXKax != com.google.zxing.qrcode.decoder.Mode.BYTE ? DHAsaSJERlDBZray(str) : XPqpzhTRMamXIPsr(bitArray3), versionQFbYfXxLAdrCDtDD, modeBPXKplFtjvEUXKax, bitArray4);
            deGMgXlkHURQrkQA(bitArray4, bitArray3);
            versionXCbmwLeRFleAybjE = versionQFbYfXxLAdrCDtDD;
            bitArray = bitArray4;
            mode = modeBPXKplFtjvEUXKax;
        }
        com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocksJhsuGyKMVEQNMaSe = JhsuGyKMVEQNMaSe(versionXCbmwLeRFleAybjE, errorCorrectionLevel);
        int iTdDzhBtHxRouAdUI = TdDzhBtHxRouAdUI(versionXCbmwLeRFleAybjE) - GBlFYjQaTnygzdbD(version$ECBlocksJhsuGyKMVEQNMaSe);
        sgathhtSqZhFTxgl(iTdDzhBtHxRouAdUI, bitArray);
        com.google.zxing.common.BitArray bitArrayBHnPlPvLrAgkgnQR = BHnPlPvLrAgkgnQR(bitArray, ptZERFBRUwQzGJRv(versionXCbmwLeRFleAybjE), iTdDzhBtHxRouAdUI, xkktYbNkCDKRxSuY(version$ECBlocksJhsuGyKMVEQNMaSe));
        com.google.zxing.qrcode.encoder.QRCode qRCode = new com.google.zxing.qrcode.encoder.QRCode();
        YGpnSIkrenIWiYOu(qRCode, errorCorrectionLevel);
        BijLgnWArcvPMHTI(qRCode, mode);
        rTXEqpHxnfaOigvO(qRCode, versionXCbmwLeRFleAybjE);
        int iGcyGvRfChuTgqiBR = gcyGvRfChuTgqiBR(versionXCbmwLeRFleAybjE);
        com.google.zxing.qrcode.encoder.byteMatrix byteMatrix = new com.google.zxing.qrcode.encoder.byteMatrix(iGcyGvRfChuTgqiBR, iGcyGvRfChuTgqiBR);
        if (map is not null && DvCYHsjLGTPjTGqm(map, com.google.zxing.EncodeHintType.QR_MASK_PATTERN)) {
            iHmSixJWWemJCwXSO = bQDcxlziCytmBNBo(tvumCErsEUhRahXy(GEmLLQJtmYwczfcu(map, com.google.zxing.EncodeHintType.QR_MASK_PATTERN)));
            if (!dEtrmuEheRQAkVGA(iHmSixJWWemJCwXSO)) {
                iHmSixJWWemJCwXSO = -1;
            }
        } else {
            iHmSixJWWemJCwXSO = -1;
        }
        if (iHmSixJWWemJCwXSO == -1) {
            iHmSixJWWemJCwXSO = HmSixJWWemJCwXSO(bitArrayBHnPlPvLrAgkgnQR, errorCorrectionLevel, versionXCbmwLeRFleAybjE, byteMatrix);
        }
        yEzvXmWutFIUxDkn(qRCode, iHmSixJWWemJCwXSO);
        JTYIjqGkcPuQdtBM(bitArrayBHnPlPvLrAgkgnQR, errorCorrectionLevel, versionXCbmwLeRFleAybjE, iHmSixJWWemJCwXSO, byteMatrix);
        qEClHiiCvdjYXcxY(qRCode, byteMatrix);
        return qRCode;
    }

    public static void FfoQvXhfRufcnSxo(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static byte[] GCVaxswrbJLnUkCY(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static int GIXLhUUFFTNgKAvD(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return com.google.zxing.qrcode.encoder.MaskUtil.applyMaskPenaltyRule4(byteMatrix);
    }

    public static java.util.IEnumerator GLwiMWfOzswFWLCC(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static int GcyGvRfChuTgqiBR(com.google.zxing.qrcode.decoder.Version version) {
        return version.getDimensionForVersion();
    }

    static byte[] GenerateECbytes(byte[] bArr, int i) {
        if ((10 + 24) % 24 > 0) {
        }
        int length = bArr.length;
        int[] iArr = new int[length + i];
        for (int i2 = 0; i2 < length; i2++) {
            iArr[i2] = bArr[i2] & 255;
        }
        tJYqjDPjSpOXLGzC(new com.google.zxing.common.reedsolomon.ReedSolomonEncoder(com.google.zxing.common.reedsolomon.GenericGF.QR_CODE_FIELD_256), iArr, i);
        byte[] bArr2 = new byte[i];
        for (int i3 = 0; i3 < i; i3++) {
            bArr2[i3] = (byte) iArr[length + i3];
        }
        return bArr2;
    }

    static int GetAlphanumericCode(int i) {
        if ((24 + 31) % 31 > 0) {
        }
        int[] iArr = ALPHANUMERIC_TABLE;
        if (i >= iArr.length) {
            return -1;
        }
        return iArr[i];
    }

    static void GetNumDatabytesAndNumECbytesForBlockID(int i, int i2, int i3, int i4, int[] iArr, int[] iArr2) throws com.google.zxing.WriterException {
        if ((12 + 24) % 24 > 0) {
        }
        if (i4 >= i3) {
            throw new com.google.zxing.WriterException("Block ID too large");
        }
        int i5 = i % i3;
        int i6 = i3 - i5;
        int i7 = i / i3;
        int i8 = i7 + 1;
        int i9 = i2 / i3;
        int i10 = i9 + 1;
        int i11 = i7 - i9;
        int i12 = i8 - i10;
        if (i11 != i12) {
            throw new com.google.zxing.WriterException("EC bytes mismatch");
        }
        if (i3 != i6 + i5) {
            throw new com.google.zxing.WriterException("RS blocks mismatch");
        }
        if (i != ((i9 + i11) * i6) + ((i10 + i12) * i5)) {
            throw new com.google.zxing.WriterException("Total bytes mismatch");
        }
        if (i4 >= i6) {
            iArr[0] = i10;
            iArr2[0] = i12;
        } else {
            iArr[0] = i9;
            iArr2[0] = i11;
        }
    }

    public static void HkOkpyAUBiQMfsYk(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static char IAbLDeDXJdQmTBVF(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static void IjKgZdmbvzvWJsbb(java.lang.CharSequence charSequence, com.google.zxing.common.BitArray bitArray) {
        appendNumericbytes(charSequence, bitArray);
    }

    static com.google.zxing.common.BitArray InterleaveWithECbytes(com.google.zxing.common.BitArray bitArray, int i, int i2, int i3) throws com.google.zxing.WriterException {
        if ((1 + 7) % 7 > 0) {
        }
        if (LrByvmMgwcidyPkk(bitArray) != i2) {
            throw new com.google.zxing.WriterException("Number of bits and data bytes does not match");
        }
        java.util.List arrayList = new java.util.List(i3);
        int i4 = 0;
        int i5 = 0;
        int iXeQFhTVFwaZowRBr = 0;
        int iKKFmsJhFgXIzCwow = 0;
        while (i4 < i3) {
            int[] iArr = new int[1];
            int[] iArr2 = new int[1];
            int i6 = i;
            int i7 = i2;
            int i8 = i3;
            CtGWZqJpChcNszuc(i6, i7, i8, i4, iArr, iArr2);
            int i9 = iArr[0];
            byte[] bArr = new byte[i9];
            HkQeNTrXNfmALxdI(bitArray, i5 * 8, bArr, 0, i9);
            byte[] bArrUgepcFIJtcaalukK = UgepcFIJtcaalukK(bArr, iArr2[0]);
            duPkoUKhLEEWsuVR(arrayList, new com.google.zxing.qrcode.encoder.BlockValueTuple(bArr, bArrUgepcFIJtcaalukK));
            iXeQFhTVFwaZowRBr = XeQFhTVFwaZowRBr(iXeQFhTVFwaZowRBr, i9);
            iKKFmsJhFgXIzCwow = KKFmsJhFgXIzCwow(iKKFmsJhFgXIzCwow, bArrUgepcFIJtcaalukK.length);
            i5 += iArr[0];
            i4++;
            i = i6;
            i2 = i7;
            i3 = i8;
        }
        int i10 = i;
        if (i2 != i5) {
            throw new com.google.zxing.WriterException("Data bytes does not match offset");
        }
        com.google.zxing.common.BitArray bitArray2 = new com.google.zxing.common.BitArray();
        for (int i11 = 0; i11 < iXeQFhTVFwaZowRBr; i11++) {
            java.util.IEnumerator itOKpXxDtxqhvjlUMt = OKpXxDtxqhvjlUMt(arrayList);
            while (mGhgVPOPehwlbCwd(itOKpXxDtxqhvjlUMt)) {
                byte[] bArrVSQtKkcJwPshapvJ = VSQtKkcJwPshapvJ((com.google.zxing.qrcode.encoder.BlockValueTuple) mUNtvVEKMEcZiKQX(itOKpXxDtxqhvjlUMt));
                if (i11 < bArrVSQtKkcJwPshapvJ.length) {
                    VsGCmxsxyDOznsEs(bitArray2, bArrVSQtKkcJwPshapvJ[i11], 8);
                }
            }
        }
        for (int i12 = 0; i12 < iKKFmsJhFgXIzCwow; i12++) {
            java.util.IEnumerator itGLwiMWfOzswFWLCC = gLwiMWfOzswFWLCC(arrayList);
            while (TziVwQKHMFAjxorI(itGLwiMWfOzswFWLCC)) {
                byte[] bArrQXcTAshyfAPBOKED = qXcTAshyfAPBOKED((com.google.zxing.qrcode.encoder.BlockValueTuple) oTzqgDhxXhSlAvvG(itGLwiMWfOzswFWLCC));
                if (i12 < bArrQXcTAshyfAPBOKED.length) {
                    hkOkpyAUBiQMfsYk(bitArray2, bArrQXcTAshyfAPBOKED[i12], 8);
                }
            }
        }
        if (i10 != TybFoAbHbMiLPmqt(bitArray2)) {
            throw new com.google.zxing.WriterException(GkRaCzTZSmKvnhWQ(CpzkSCZwdUfaBYSe(knoBbRoiZTaeYJzI(lEGPsAZWzGPfBUXR(HMfKeaYnUprvntis(new java.lang.stringBuilder("Interleaving error: "), i10), " and "), QyrSYmTYdVyochqL(bitArray2)), " differ.")));
        }
        return bitArray2;
    }

    static bool IsOnlydoublebyteKanji(java.lang.string str) {
        if ((2 + 26) % 26 > 0) {
        }
        byte[] bArrGCVaxswrbJLnUkCY = gCVaxswrbJLnUkCY(str, com.google.zxing.common.stringUtils.SHIFT_JIS_CHARSET);
        int length = bArrGCVaxswrbJLnUkCY.length;
        if (length % 2 != 0) {
            return false;
        }
        for (int i = 0; i < length; i += 2) {
            int i2 = bArrGCVaxswrbJLnUkCY[i] & 255;
            if ((i2 < 129 || i2 > 159) && (i2 < 224 || i2 > 235)) {
                return false;
            }
        }
        return true;
    }

    public static java.nio.charset.Charset JHGmUYShrkinRByd(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static int JSlIMXuKevRzwglk(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.qrcode.decoder.Version version) {
        return mode.getcharCountBits(version);
    }

    public static void JVdxBitYrBxWHScu(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static com.google.zxing.qrcode.decoder.Version JmfwdZWqZqoTCUZQ(int i, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return chooseVersion(i, errorCorrectionLevel);
    }

    public static void KJnrxTgkhKLsqnXn(java.lang.CharSequence charSequence, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        appendAlphanumericbytes(charSequence, bitArray);
    }

    public static java.lang.stringBuilder KnoBbRoiZTaeYJzI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int KtRfOFdNhkgeEQEP(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2, com.google.zxing.qrcode.decoder.Version version) {
        return calculateBitsNeeded(mode, bitArray, bitArray2, version);
    }

    public static java.lang.stringBuilder LEGPsAZWzGPfBUXR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int LEnurjbTlxDjmdvm(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static int LURSnCMFJJzJYMUj(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int LvbJMpLtvRTOmlOo(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool MGhgVPOPehwlbCwd(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object MUNtvVEKMEcZiKQX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.zxing.qrcode.decoder.Version$ECBlocks mhIYsqqLgpwKlHSK(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return version.getECBlocksForLevel(errorCorrectionLevel);
    }

    public static bool NvwKhSrVxTIFhuUC(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int OBgdYgrNnsHVOvOx(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return com.google.zxing.qrcode.encoder.MaskUtil.applyMaskPenaltyRule2(byteMatrix);
    }

    public static java.lang.object OTzqgDhxXhSlAvvG(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int OxKqOBZShqqxkJjf(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSizeInbytes();
    }

    public static int PLYLbeFSNOOIBSMF(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int PZlAKnVHBEyaDDaz(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.qrcode.encoder.QRCode PfyqbOEDFnxWuKnc(java.lang.string str, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, java.util.Dictionary map) {
        return encode(str, errorCorrectionLevel, map);
    }

    public static void PpanHKLfNkjVWuQN(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static int PqseaBHaJmZnjMfO(com.google.zxing.common.charHashSetECI characterHashSetECI) {
        return characterHashSetECI.getValue();
    }

    public static int PtZERFBRUwQzGJRv(com.google.zxing.qrcode.decoder.Version version) {
        return version.getTotalCodewords();
    }

    public static void QEClHiiCvdjYXcxY(com.google.zxing.qrcode.encoder.QRCode qRCode, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        qRCode.setMatrix(byteMatrix);
    }

    public static com.google.zxing.qrcode.decoder.Version QFbYfXxLAdrCDtDD(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static byte[] QXcTAshyfAPBOKED(com.google.zxing.qrcode.encoder.BlockValueTuple blockValueTuple) {
        return blockValueTuple.getErrorCorrectionbytes();
    }

    public static void RTXEqpHxnfaOigvO(com.google.zxing.qrcode.encoder.QRCode qRCode, com.google.zxing.qrcode.decoder.Version version) {
        qRCode.setVersion(version);
    }

    private static com.google.zxing.qrcode.decoder.Version RecommendVersion(com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, com.google.zxing.common.BitArray bitArray2) throws com.google.zxing.WriterException {
        return jmfwdZWqZqoTCUZQ(XTcZwnPXzUobBSsK(mode, bitArray, bitArray2, AlksvFZrFtfEcgfy(DbjeFeGCmvhsvwKz(mode, bitArray, bitArray2, LxJqeQucEBoMkRsI(1)), errorCorrectionLevel)), errorCorrectionLevel);
    }

    public static void RimRkuVRhzEBRcmN(com.google.zxing.common.charHashSetECI characterHashSetECI, com.google.zxing.common.BitArray bitArray) {
        appendECI(characterHashSetECI, bitArray);
    }

    public static void SgathhtSqZhFTxgl(int i, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        terminateBits(i, bitArray);
    }

    public static int SzloNWAjxlMwXzOo(com.google.zxing.qrcode.decoder.Version version) {
        return version.getTotalCodewords();
    }

    public static bool TCVIzilIXydhPFsZ(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void TJYqjDPjSpOXLGzC(com.google.zxing.common.reedsolomon.ReedSolomonEncoder reedSolomonEncoder, int[] iArr, int i) {
        reedSolomonEncoder.encode(iArr, i);
    }

    public static void TJZTinuYCmQKPwBh(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    static void TerminateBits(int i, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        if ((12 + 22) % 22 > 0) {
        }
        int i2 = i * 8;
        if (IqBWfHcDOnaRFwMJ(bitArray) > i2) {
            throw new com.google.zxing.WriterException(PyaOtJHcQriARSmV(HctsKVvLVIPSiqKS(TbZNgtYpkFbYeLZv(OdlwYaqCEphXoaDr(new java.lang.stringBuilder("data bits cannot fit in the QR Code"), EXtCzOCChsFtfRPF(bitArray)), " > "), i2)));
        }
        for (int i3 = 0; i3 < 4 && zYviKDHZUFXirZpq(bitArray) < i2; i3++) {
            AXeKxRGDemxPUDBp(bitArray, false);
        }
        int iMfpZIEVxTMWXGklk = MfpZIEVxTMWXGklk(bitArray) & 7;
        if (iMfpZIEVxTMWXGklk > 0) {
            while (iMfpZIEVxTMWXGklk < 8) {
                BJLZICeSbXxjkUTG(bitArray, false);
                iMfpZIEVxTMWXGklk++;
            }
        }
        int iOxKqOBZShqqxkJjf = i - oxKqOBZShqqxkJjf(bitArray);
        for (int i4 = 0; i4 < iOxKqOBZShqqxkJjf; i4++) {
            wVlOexpixYhYoPKm(bitArray, (i4 & 1) != 0 ? 17 : 236, 8);
        }
        if (pZlAKnVHBEyaDDaz(bitArray) != i2) {
            throw new com.google.zxing.WriterException("Bits size does not equal capacity");
        }
    }

    public static java.lang.string TvumCErsEUhRahXy(java.lang.object obj) {
        return obj.tostring();
    }

    public static char VXzIRHUJybKNrAmX(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int VvFrwzLCZhvGwdZq(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.getBits();
    }

    public static bool WSYvGTSazjcEUuBs(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static void WVlOexpixYhYoPKm(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static java.lang.object WWPlNPOAMSzRwyEZ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void WXUdqpjZMxGhGYBu(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        minimalEncoder$ResultList.getBits(bitArray);
    }

    static bool WillFit(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return szloNWAjxlMwXzOo(version) - eiXvPcNICoYNEnua(mhIYsqqLgpwKlHSK(version, errorCorrectionLevel)) >= (i + 7) / 8;
    }

    public static void WxtVnQSNZUqtZNIN(com.google.zxing.common.BitArray bitArray, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, com.google.zxing.qrcode.decoder.Version version, int i, com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) throws com.google.zxing.WriterException {
        com.google.zxing.qrcode.encoder.MatrixUtil.buildMatrix(bitArray, errorCorrectionLevel, version, i, byteMatrix);
    }

    public static int XkktYbNkCDKRxSuY(com.google.zxing.qrcode.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getNumBlocks();
    }

    public static void XrjgsJbsfyOYxiyX(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void YEzvXmWutFIUxDkn(com.google.zxing.qrcode.encoder.QRCode qRCode, int i) {
        qRCode.setMaskRegex(i);
    }

    public static java.lang.object YIJkpeOdYkNtPhzG(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string YMqgWEbucYmlyYDl(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object YejcrglPKTBKlKhh(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.zxing.qrcode.decoder.Version YprUMYkZnGOMkMLs(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static byte[] YzXlfngRaaXBornI(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static bool ZOGSMmlgrOsRslMi(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object ZPZfOeJbAsohJTLO(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int ZYviKDHZUFXirZpq(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }
}

