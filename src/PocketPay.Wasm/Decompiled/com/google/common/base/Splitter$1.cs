namespace WillowMaze.Wasm.Decompiled;


class Splitter$1 : com.google.common.base.Splitter$Strategy {
    readonly com.google.common.base.CharMatch val$separatorMatch;

    Splitter$1(com.google.common.base.CharMatch charMatch) {
        this.val$separatorMatch = charMatch;
    }

    public static com.google.common.base.Splitter$SplittingIEnumerator EQjtygjEpwgtWPIL(com.google.common.base.Splitter$1 splitter$1, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter$1.iterator(splitter, charSequence);
    }

    public com.google.common.base.Splitter$SplittingIEnumerator iterator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return new com.google.common.base.Splitter$1$1(this, splitter, charSequence);
    }

    public override java.util.IEnumerator Iterator(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return EQjtygjEpwgtWPIL(this, splitter, charSequence);
    }
}

