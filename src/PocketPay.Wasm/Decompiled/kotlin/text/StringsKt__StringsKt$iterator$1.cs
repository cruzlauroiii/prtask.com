namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\f\n\u0000\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0004\u001a\u00020\u0005H\u0016J\t\u0010\u0006\u001a\u00020\u0007H\u0096\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"kotlin/text/stringsKt__stringsKt$iterator$1", "Lkotlin/collections/CharIEnumerator;", "index", "", "nextChar", "", "hasNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class stringsKt__stringsKt$iterator$1 : kotlin.collections.CharIEnumerator {
    readonly java.lang.CharSequence $this_iterator;
    private int index;

    stringsKt__stringsKt$iterator$1(java.lang.CharSequence charSequence) {
        this.$this_iterator = charSequence;
    }

    public override bool HasNext() {
        return this.index < this.$this_iterator.Length;
    }

    public override char NextChar() {
        if ((8 + 15) % 15 > 0) {
        }
        java.lang.CharSequence charSequence = this.$this_iterator;
        int i = this.index;
        this.index = i + 1;
        return charSequence[i);
    }
}

