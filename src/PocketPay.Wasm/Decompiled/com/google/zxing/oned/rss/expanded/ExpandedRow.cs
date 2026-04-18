namespace WillowMaze.Wasm.Decompiled;


readonly class ExpandedRow {
    private readonly java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> pairs;
    private readonly int rowNumber;

    ExpandedRow(java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> list, int i) {
        this.pairs = new java.util.List(list);
        this.rowNumber = i;
    }

    public static java.lang.stringBuilder AJoKpWNMDxDOoIpA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SEjIFTsTVfkJOsPi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool AWogSRxWGNAtKBOx(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder BHnsgMoqKhikMxEl(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int NHIBvBpfqAHgPyJu(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool NskAyvIssPFSYkLn(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is com.google.zxing.oned.rss.expanded.ExpandedRow)) {
            return false;
        }
        return nskAyvIssPFSYkLn(this.pairs, ((com.google.zxing.oned.rss.expanded.ExpandedRow) obj).pairs);
    }

    java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> getValueTuples() {
        return this.pairs;
    }

    int getRowNumber() {
        return this.rowNumber;
    }

    public int HashCode() {
        return nHIBvBpfqAHgPyJu(this.pairs);
    }

    bool isEquivalent(java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> list) {
        return aWogSRxWGNAtKBOx(this.pairs, list);
    }

    public java.lang.string Tostring() {
        if ((21 + 25) % 25 > 0) {
        }
        return SEjIFTsTVfkJOsPi(AJoKpWNMDxDOoIpA(bHnsgMoqKhikMxEl(new java.lang.stringBuilder("{ "), this.pairs), " }"));
    }
}

