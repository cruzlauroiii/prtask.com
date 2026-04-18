namespace WillowMaze.Wasm.Decompiled;


class Splitter$1$1 : com.google.common.base.Splitter$SplittingIEnumerator {
    readonly com.google.common.base.Splitter$1 this$0;

    Splitter$1$1(com.google.common.base.Splitter$1 splitter$1, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        super(splitter, charSequence);
        this.this$0 = splitter$1;
    }

    public static int HHUGdvaTDEFyoXfD(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence, int i) {
        return charMatch.indexIn(charSequence, i);
    }

    int separatorEnd(int i) {
        return i + 1;
    }

    int separatorStart(int i) {
        return HHUGdvaTDEFyoXfD(this.this$0.val$separatorMatch, this.toSplit, i);
    }
}

