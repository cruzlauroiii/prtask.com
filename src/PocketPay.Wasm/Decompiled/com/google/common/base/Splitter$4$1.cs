namespace WillowMaze.Wasm.Decompiled;


class Splitter$4$1 : com.google.common.base.Splitter$SplittingIEnumerator {
    readonly com.google.common.base.Splitter$4 this$0;

    Splitter$4$1(com.google.common.base.Splitter$4 splitter$4, com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        super(splitter, charSequence);
        this.this$0 = splitter$4;
    }

    public static int EOjvCfscPUTzDCBl(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public override int SeparatorEnd(int i) {
        return i;
    }

    public override int SeparatorStart(int i) {
        int i2 = i + this.this$0.val$length;
        if (i2 >= EOjvCfscPUTzDCBl(this.toSplit)) {
            return -1;
        }
        return i2;
    }
}

