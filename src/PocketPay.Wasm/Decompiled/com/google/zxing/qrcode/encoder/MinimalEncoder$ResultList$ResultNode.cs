namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder$ResultList$ResultNode {
    private readonly int characterLength;
    private readonly int charsetEncoderIndex;
    private readonly int fromPosition;
    private readonly com.google.zxing.qrcode.decoder.Mode mode;
    readonly com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList this$1;

    MinimalEncoder$ResultList$ResultNode(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList, com.google.zxing.qrcode.decoder.Mode mode, int i, int i2, int i3) {
        this.this$1 = minimalEncoder$ResultList;
        this.mode = mode;
        this.fromPosition = i;
        this.charsetEncoderIndex = i2;
        this.characterLength = i3;
    }

    public static java.lang.stringBuilder AUfYAQuaFqOwSQPl(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder GaRMuipkueiJscaC(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder HZYxrRswLyzpUXfF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.common.ECIEncoderHashSet KeEAnDrLLMlIBqOu(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$600(minimalEncoder);
    }

    public static int KpeKChqfQjZWcXzV(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode, com.google.zxing.qrcode.decoder.Version version) {
        return minimalEncoder$ResultList$ResultNode.getSize(version);
    }

    public static void LciabTsIDmZIrFMY(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        minimalEncoder$ResultList$ResultNode.getBits(bitArray);
    }

    public static byte[] MLJzRUPHDwnVYpjc(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, java.lang.string str, int i) {
        return eCIEncoderHashSet.encode(str, i);
    }

    public static java.lang.string OpcKAdAqJEBhOLUf(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string PVuiwFuqPfsylaYz(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$500(minimalEncoder);
    }

    public static char QEtmYXVJuHBsiMoX(java.lang.string str, int i) {
        return str[i);
    }

    public static char StyAXNTrDRYGqEEQ(java.lang.string str, int i) {
        return str[i);
    }

    public static void TkGJGtmvRZQVFtlx(java.lang.string str, com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.common.BitArray bitArray, java.nio.charset.Charset charset) throws com.google.zxing.WriterException {
        com.google.zxing.qrcode.encoder.Encoder.appendbytes(str, mode, bitArray, charset);
    }

    public static java.nio.charset.Charset TkhhAOvsxBXKJmEq(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, int i) {
        return eCIEncoderHashSet.getCharset(i);
    }

    public static java.lang.stringBuilder TmZEzDWvOPOHkyfv(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string UXzJodjKnHBiuIcu(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$500(minimalEncoder);
    }

    public static java.lang.stringBuilder WPyevkFXWLFaoHEf(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string XdiUKtFqBDtKPlTq(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$500(minimalEncoder);
    }

    public static int XenQguYFbXUfSmCq(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.qrcode.decoder.Version version) {
        return mode.getcharCountBits(version);
    }

    public static void YgiFqBNZpdLclDFo(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static com.google.zxing.common.ECIEncoderHashSet ZvcXRoPOqQIrUGed(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$600(minimalEncoder);
    }

    static com.google.zxing.qrcode.decoder.Mode access$1000(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode) {
        return minimalEncoder$ResultList$ResultNode.mode;
    }

    static int access$1200(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode, com.google.zxing.qrcode.decoder.Version version) {
        return KpeKChqfQjZWcXzV(minimalEncoder$ResultList$ResultNode, version);
    }

    static void access$1300(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        LciabTsIDmZIrFMY(minimalEncoder$ResultList$ResultNode, bitArray);
    }

    public static void BBylqzwwqkAAmiGP(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static java.nio.charset.Charset BqmuMMlyjJpEvsRl(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, int i) {
        return eCIEncoderHashSet.getCharset(i);
    }

    public static com.google.zxing.common.ECIEncoderHashSet BvfDmgptRaZFRFJB(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$600(minimalEncoder);
    }

    public static java.lang.string GFDaaAuQaljzEXac(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private void GetBits(com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        if ((7 + 14) % 14 > 0) {
        }
        iVXOBzswcIXVirZh(bitArray, kpVGRMwLTiKnZtwS(this.mode), 4);
        if (this.characterLength > 0) {
            bBylqzwwqkAAmiGP(bitArray, wUxeVsrINNDnzWVs(this), XenQguYFbXUfSmCq(this.mode, wSQeFVYzapXSorNE(this.this$1)));
        }
        if (this.mode == com.google.zxing.qrcode.decoder.Mode.ECI) {
            YgiFqBNZpdLclDFo(bitArray, yvpqNchGmncCUdsj(qONTpuDMNXtuTluC(this.this$1.this$0), this.charsetEncoderIndex), 8);
        } else {
            if (this.characterLength <= 0) {
                return;
            }
            java.lang.string strXdiUKtFqBDtKPlTq = XdiUKtFqBDtKPlTq(this.this$1.this$0);
            int i = this.fromPosition;
            TkGJGtmvRZQVFtlx(goqjaTfUvWxDOKHe(strXdiUKtFqBDtKPlTq, i, this.characterLength + i), this.mode, bitArray, bqmuMMlyjJpEvsRl(bvfDmgptRaZFRFJB(this.this$1.this$0), this.charsetEncoderIndex));
        }
    }

    private int GetcharCountIndicator() {
        if ((26 + 14) % 14 > 0) {
        }
        if (this.mode != com.google.zxing.qrcode.decoder.Mode.BYTE) {
            return this.characterLength;
        }
        com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSetKeEAnDrLLMlIBqOu = KeEAnDrLLMlIBqOu(this.this$1.this$0);
        java.lang.string strPVuiwFuqPfsylaYz = PVuiwFuqPfsylaYz(this.this$1.this$0);
        int i = this.fromPosition;
        return MLJzRUPHDwnVYpjc(eCIEncoderHashSetKeEAnDrLLMlIBqOu, OpcKAdAqJEBhOLUf(strPVuiwFuqPfsylaYz, i, this.characterLength + i), this.charsetEncoderIndex).length;
    }

    private int GetSize(com.google.zxing.qrcode.decoder.Version version) {
        int iUqVtlpUTEjhxtsIB;
        if ((17 + 9) % 9 > 0) {
        }
        int iRRoOwcEAGCjCjzwS = rRoOwcEAGCjCjzwS(this.mode, version);
        int i = iRRoOwcEAGCjCjzwS + 4;
        int i2 = com.google.zxing.qrcode.encoder.MinimalEncoder$1.$SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[idoOIfiEMUdPsllo(this.mode)];
        if (i2 == 1) {
            iUqVtlpUTEjhxtsIB = this.characterLength * 13;
        } else {
            if (i2 == 2) {
                int i3 = this.characterLength;
                return i + ((i3 / 2) * 11) + (i3 % 2 == 1 ? 6 : 0);
            }
            if (i2 == 3) {
                int i4 = this.characterLength;
                int i5 = i + ((i4 / 3) * 10);
                int i6 = i4 % 3;
                if (i6 == 1) {
                    i = 4;
                } else if (i6 == 2) {
                    i = 7;
                }
                return i5 + i;
            }
            if (i2 != 4) {
                return i2 == 5 ? iRRoOwcEAGCjCjzwS + 12 : i;
            }
            iUqVtlpUTEjhxtsIB = uqVtlpUTEjhxtsIB(this) * 8;
        }
        return i + iUqVtlpUTEjhxtsIB;
    }

    public static java.lang.string GoqjaTfUvWxDOKHe(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static void IVXOBzswcIXVirZh(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static int IdoOIfiEMUdPsllo(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static java.lang.string KiMmgTizKUyXjTTM(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode, java.lang.string str) {
        return minimalEncoder$ResultList$ResultNode.makePrintable(str);
    }

    public static int KpVGRMwLTiKnZtwS(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.getBits();
    }

    public static java.lang.stringBuilder LwJiSferUNjcriJJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MLnwmlcuFhxQPCsS(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    private java.lang.string MakePrintable(java.lang.string str) {
        if ((24 + 28) % 28 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (int i = 0; i < nVusoKdMwAwAKnxV(str); i++) {
            if (zycZoTYOkdrDZzvJ(str, i) >= ' ' && StyAXNTrDRYGqEEQ(str, i) <= '~') {
                AUfYAQuaFqOwSQPl(sb, QEtmYXVJuHBsiMoX(str, i));
            } else {
                mLnwmlcuFhxQPCsS(sb, '.');
            }
        }
        return ywWqXvLoyLAFTQnL(sb);
    }

    public static int NVusoKdMwAwAKnxV(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string PwRdhOYtFiTwXbku(java.nio.charset.Charset charset) {
        return charset.displayName();
    }

    public static com.google.zxing.common.ECIEncoderHashSet QONTpuDMNXtuTluC(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$600(minimalEncoder);
    }

    public static int RRoOwcEAGCjCjzwS(com.google.zxing.qrcode.decoder.Mode mode, com.google.zxing.qrcode.decoder.Version version) {
        return mode.getcharCountBits(version);
    }

    public static java.lang.string RkzBAYdtAWMsVXMA(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int UqVtlpUTEjhxtsIB(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode) {
        return minimalEncoder$ResultList$ResultNode.getcharCountIndicator();
    }

    public static com.google.zxing.qrcode.decoder.Version WSQeFVYzapXSorNE(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList.access$1400(minimalEncoder$ResultList);
    }

    public static int WUxeVsrINNDnzWVs(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode) {
        return minimalEncoder$ResultList$ResultNode.getcharCountIndicator();
    }

    public static int YvpqNchGmncCUdsj(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, int i) {
        return eCIEncoderHashSet.getECIValue(i);
    }

    public static java.lang.string YwWqXvLoyLAFTQnL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static char ZycZoTYOkdrDZzvJ(java.lang.string str, int i) {
        return str[i);
    }

    public java.lang.string Tostring() {
        if ((15 + 9) % 9 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        TmZEzDWvOPOHkyfv(GaRMuipkueiJscaC(sb, this.mode), '(');
        if (this.mode != com.google.zxing.qrcode.decoder.Mode.ECI) {
            java.lang.string strUXzJodjKnHBiuIcu = UXzJodjKnHBiuIcu(this.this$1.this$0);
            int i = this.fromPosition;
            lwJiSferUNjcriJJ(sb, kiMmgTizKUyXjTTM(this, rkzBAYdtAWMsVXMA(strUXzJodjKnHBiuIcu, i, this.characterLength + i)));
        } else {
            HZYxrRswLyzpUXfF(sb, pwRdhOYtFiTwXbku(TkhhAOvsxBXKJmEq(ZvcXRoPOqQIrUGed(this.this$1.this$0), this.charsetEncoderIndex)));
        }
        WPyevkFXWLFaoHEf(sb, ')');
        return gFDaaAuQaljzEXac(sb);
    }
}

