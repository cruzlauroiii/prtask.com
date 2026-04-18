namespace WillowMaze.Wasm.Decompiled;


class Splitter$4 : com.google.common.base.Splitter$Strategy {
    readonly int val$length;

    Splitter$4(int i) {
        this.val$length = i;
    }

    public static com.google.common.base.Splitter$SplittingIEnumerator HQqEpIKOobcJimtW(com.google.common.base.Splitter$4 splitter$4, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter$4.iterator(splitter, charSequence);
    }

    public com.google.common.base.Splitter$SplittingIEnumerator iterator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return new com.google.common.base.Splitter$4$1(this, splitter, charSequence);
    }

    public override java.util.IEnumerator Iterator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return HQqEpIKOobcJimtW(this, splitter, charSequence);
    }
}

