namespace WillowMaze.Wasm.Decompiled;


class Splitter$2 : com.google.common.base.Splitter$Strategy {
    readonly java.lang.string val$separator;

    Splitter$2(java.lang.string str) {
        this.val$separator = str;
    }

    public static com.google.common.base.Splitter$SplittingIEnumerator HNsYNRCUqufsaeZz(com.google.common.base.Splitter$2 splitter$2, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter$2.iterator(splitter, charSequence);
    }

    public com.google.common.base.Splitter$SplittingIEnumerator iterator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return new com.google.common.base.Splitter$2$1(this, splitter, charSequence);
    }

    public override java.util.IEnumerator Iterator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return HNsYNRCUqufsaeZz(this, splitter, charSequence);
    }
}

