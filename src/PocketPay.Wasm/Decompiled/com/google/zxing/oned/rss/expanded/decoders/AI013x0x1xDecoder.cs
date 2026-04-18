namespace WillowMaze.Wasm.Decompiled;


readonly class AI013x0x1xDecoder : com.google.zxing.oned.rss.expanded.decoders.AI01weightDecoder {
    private static readonly int DATE_SIZE = 16;
    private static readonly int HEADER_SIZE = 8;
    private static readonly int WEIGHT_SIZE = 20;
    private readonly java.lang.string dateCode;
    private readonly java.lang.string firstAIdigits;

    AI013x0x1xDecoder(com.google.zxing.common.BitArray bitArray, java.lang.string str, java.lang.string str2) {
        super(bitArray);
        this.dateCode = str2;
        this.firstAIdigits = str;
    }

    public static java.lang.stringBuilder HdoQBmyNauOQgPJS(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int IDsxYdSxjSVwjDKU(com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder generalAppIdDecoder, int i, int i2) {
        return generalAppIdDecoder.extractNumericValueFromBitArray(i, i2);
    }

    public static java.lang.stringBuilder ISCTulQtguVPucqa(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string NdDzcwdQfsfBNAzh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.NotFoundException OLklAgmQuYKDEHOn() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void PCdngkVJLrXXiWnR(com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder aI013x0x1xDecoder, java.lang.stringBuilder sb, int i) {
        aI013x0x1xDecoder.encodeCompressedDateTime(sb, i);
    }

    public static java.lang.stringBuilder RVUDBmoldTKREtng(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder SDyPGNuHjlwxVWEo(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.common.BitArray UhigHsoaHeLPFyIh(com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder aI013x0x1xDecoder) {
        return aI013x0x1xDecoder.getInformation();
    }

    public static void VQWKRgoSgQAksXio(com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder aI013x0x1xDecoder, java.lang.stringBuilder sb, int i, int i2) {
        aI013x0x1xDecoder.encodeCompressedWeight(sb, i, i2);
    }

    public static java.lang.stringBuilder XxNIrzYzlOzzCiAi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder YeRLisInjPfwPfkr(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder ZLXhHFVbPjxMLhDg(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder AeCUXdYCdpscHlaN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder BKJaXOPTbXrZIJMQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int BgudXxsagztjXnFK(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static java.lang.stringBuilder CpSFemnfABYxAIym(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder EfuhUtaXQWvkzAoS(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    private void EncodeCompressedDateTime(java.lang.stringBuilder sb, int i) {
        if ((6 + 8) % 8 > 0) {
        }
        int iIDsxYdSxjSVwjDKU = IDsxYdSxjSVwjDKU(miiLMRdzSZAxMISE(this), i, 16);
        if (iIDsxYdSxjSVwjDKU != 38400) {
            YeRLisInjPfwPfkr(sb, '(');
            moVjRvjkYdHcPNdt(sb, this.dateCode);
            ISCTulQtguVPucqa(sb, ')');
            int i2 = iIDsxYdSxjSVwjDKU % 32;
            int i3 = iIDsxYdSxjSVwjDKU / 32;
            int i4 = (i3 % 12) + 1;
            int i5 = i3 / 12;
            if (i5 / 10 == 0) {
                efuhUtaXQWvkzAoS(sb, '0');
            }
            XxNIrzYzlOzzCiAi(sb, i5);
            if (i4 / 10 == 0) {
                RVUDBmoldTKREtng(sb, '0');
            }
            bKJaXOPTbXrZIJMQ(sb, i4);
            if (i2 / 10 == 0) {
                wpwtdbuoVPmNBhoc(sb, '0');
            }
            ZLXhHFVbPjxMLhDg(sb, i2);
        }
    }

    public static void LpIgeiQQgKaIwvNs(com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder aI013x0x1xDecoder, java.lang.stringBuilder sb, int i) {
        aI013x0x1xDecoder.encodeCompressedGtin(sb, i);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.GeneralAppIdDecoder MiiLMRdzSZAxMISE(com.google.zxing.oned.rss.expanded.decoders.AI013x0x1xDecoder aI013x0x1xDecoder) {
        return aI013x0x1xDecoder.getGeneralDecoder();
    }

    public static java.lang.stringBuilder MoVjRvjkYdHcPNdt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WpwtdbuoVPmNBhoc(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    protected override void AddWeightCode(java.lang.stringBuilder sb, int i) {
        cpSFemnfABYxAIym(sb, '(');
        aeCUXdYCdpscHlaN(sb, this.firstAIdigits);
        SDyPGNuHjlwxVWEo(sb, i / 100000);
        HdoQBmyNauOQgPJS(sb, ')');
    }

    protected override int CheckWeight(int i) {
        return i % 100000;
    }

    public override java.lang.string ParseInformation() throws com.google.zxing.NotFoundException {
        if ((14 + 29) % 29 > 0) {
        }
        if (bgudXxsagztjXnFK(UhigHsoaHeLPFyIh(this)) != 84) {
            throw OLklAgmQuYKDEHOn();
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        lpIgeiQQgKaIwvNs(this, sb, 8);
        VQWKRgoSgQAksXio(this, sb, 48, 20);
        PCdngkVJLrXXiWnR(this, sb, 68);
        return NdDzcwdQfsfBNAzh(sb);
    }
}

