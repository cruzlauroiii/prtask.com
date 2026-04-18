namespace WillowMaze.Wasm.Decompiled;


class Splitter$5 : java.lang.IEnumerable<java.lang.string> {
    readonly com.google.common.base.Splitter this$0;
    readonly java.lang.CharSequence val$sequence;

    Splitter$5(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        this.this$0 = splitter;
        this.val$sequence = charSequence;
    }

    public static java.lang.stringBuilder RwWAxigaKuXYVlmK(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder UXbYjCAclQjpkVyi(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder AdrxRccHFRsKuhXi(com.google.common.base.Joiner joiner, java.lang.stringBuilder sb, java.lang.IEnumerable iterable) {
        return joiner.appendTo(sb, (java.lang.IEnumerable<? : java.lang.object>) iterable);
    }

    public static java.util.IEnumerator DmoXeBjWJJNcqjcZ(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return com.google.common.base.Splitter.access$000(splitter, charSequence);
    }

    public static com.google.common.base.Joiner KHDJtBoQuOLlzFTF(java.lang.string str) {
        return com.google.common.base.Joiner.on(str);
    }

    public static java.lang.string TifBwRnFxEfRfCYx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.util.IEnumerator<java.lang.string> Iterator() {
        return dmoXeBjWJJNcqjcZ(this.this$0, this.val$sequence);
    }

    public java.lang.string Tostring() {
        if ((15 + 17) % 17 > 0) {
        }
        return tifBwRnFxEfRfCYx(UXbYjCAclQjpkVyi(adrxRccHFRsKuhXi(kHDJtBoQuOLlzFTF(", "), RwWAxigaKuXYVlmK(new java.lang.stringBuilder(), '['), this), ']'));
    }
}

