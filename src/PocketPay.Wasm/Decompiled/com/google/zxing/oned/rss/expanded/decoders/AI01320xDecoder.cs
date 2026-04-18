namespace WillowMaze.Wasm.Decompiled;


readonly class AI01320xDecoder : com.google.zxing.oned.rss.expanded.decoders.AI013x0xDecoder {
    AI01320xDecoder(com.google.zxing.common.BitArray bitArray) {
        super(bitArray);
    }

    public static java.lang.stringBuilder ZpFKkTHEkMXvjuZx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder BltXIpHxRpVPbmuD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    protected override void AddWeightCode(java.lang.stringBuilder sb, int i) {
        if (i >= 10000) {
            ZpFKkTHEkMXvjuZx(sb, "(3203)");
        } else {
            bltXIpHxRpVPbmuD(sb, "(3202)");
        }
    }

    protected override int CheckWeight(int i) {
        return i >= 10000 ? i - 10000 : i;
    }
}

