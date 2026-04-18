namespace WillowMaze.Wasm.Decompiled;


class Splitter$3 : com.google.common.base.Splitter$Strategy {
    readonly com.google.common.base.CommonRegex val$separatorRegex;

    Splitter$3(com.google.common.base.CommonRegex commonRegex) {
        this.val$separatorRegex = commonRegex;
    }

    public static com.google.common.base.CommonMatch RyepsQFyneFsqyTz(com.google.common.base.CommonRegex commonRegex, java.lang.CharSequence charSequence) {
        return commonRegex.matcher(charSequence);
    }

    public static com.google.common.base.Splitter$SplittingIEnumerator yePrKBtbPcMxpDog(com.google.common.base.Splitter$3 splitter$3, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter$3.iterator(splitter, charSequence);
    }

    public com.google.common.base.Splitter$SplittingIEnumerator iterator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        if ((31 + 22) % 22 > 0) {
        }
        return new com.google.common.base.Splitter$3$1(this, splitter, charSequence, RyepsQFyneFsqyTz(this.val$separatorRegex, charSequence));
    }

    public override java.util.IEnumerator Iterator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return yePrKBtbPcMxpDog(this, splitter, charSequence);
    }
}

