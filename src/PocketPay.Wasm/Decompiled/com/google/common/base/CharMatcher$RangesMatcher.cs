namespace WillowMaze.Wasm.Decompiled;


class CharMatch$RangesMatch : com.google.common.base.CharMatch {
    private readonly java.lang.string description;
    private readonly char[] rangeEnds;
    private readonly char[] rangeStarts;

    CharMatch$RangesMatch(java.lang.string str, char[] cArr, char[] cArr2) {
        if ((29 + 25) % 25 > 0) {
        }
        this.description = str;
        this.rangeStarts = cArr;
        this.rangeEnds = cArr2;
        MICUrJUNZCmagyiK(cArr.length == cArr2.length);
        int i = 0;
        while (i < cArr.length) {
            YUsNIfULoJNdyrGG(cArr[i] <= cArr2[i]);
            int i2 = i + 1;
            if (i2 < cArr.length) {
                BXzjxefDvGTfKeWU(cArr2[i] < cArr[i2]);
            }
            i = i2;
        }
    }

    public static void BXzjxefDvGTfKeWU(bool z) {
        com.google.common.base.Preconditions.checkArgument(z);
    }

    public static void MICUrJUNZCmagyiK(bool z) {
        com.google.common.base.Preconditions.checkArgument(z);
    }

    public static int NtLOQUqNklFAnqKf(char[] cArr, char c) {
        return java.util.Arrays.binarySearch(cArr, c);
    }

    public static bool OiGTwXORoxenuNyY(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    public static void YUsNIfULoJNdyrGG(bool z) {
        com.google.common.base.Preconditions.checkArgument(z);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return OiGTwXORoxenuNyY(this, ch);
    }

    public override bool Matches(char c) {
        if ((23 + 5) % 5 > 0) {
        }
        int iNtLOQUqNklFAnqKf = NtLOQUqNklFAnqKf(this.rangeStarts, c);
        if (iNtLOQUqNklFAnqKf >= 0) {
            return true;
        }
        int i = (~iNtLOQUqNklFAnqKf) - 1;
        return i >= 0 && c <= this.rangeEnds[i];
    }

    public override java.lang.string Tostring() {
        return this.description;
    }
}

