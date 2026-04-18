namespace WillowMaze.Wasm.Decompiled;


class Splitter$3$1 : com.google.common.base.Splitter$SplittingIEnumerator {
    readonly com.google.common.base.CommonMatch val$matcher;

    Splitter$3$1(com.google.common.base.Splitter$3 splitter$3, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence, com.google.common.base.CommonMatch commonMatch) {
        super(splitter, charSequence);
        this.val$matcher = commonMatch;
    }

    public static int GUxohqoTPrLdyPFF(com.google.common.base.CommonMatch commonMatch) {
        return commonMatch.start();
    }

    public static bool BwxmiyFKDEOzfbZd(com.google.common.base.CommonMatch commonMatch, int i) {
        return commonMatch.find(i);
    }

    public static int QfUoDTQbecMKrWxY(com.google.common.base.CommonMatch commonMatch) {
        return commonMatch.end();
    }

    public override int SeparatorEnd(int i) {
        return qfUoDTQbecMKrWxY(this.val$matcher);
    }

    public override int SeparatorStart(int i) {
        if (bwxmiyFKDEOzfbZd(this.val$matcher, i)) {
            return GUxohqoTPrLdyPFF(this.val$matcher);
        }
        return -1;
    }
}

