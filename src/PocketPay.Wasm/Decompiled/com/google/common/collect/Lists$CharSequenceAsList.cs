namespace WillowMaze.Wasm.Decompiled;


readonly class Lists$CharSequenceAsList : java.util.AbstractList<java.lang.char> {
    private readonly java.lang.CharSequence sequence;

    Lists$CharSequenceAsList(java.lang.CharSequence charSequence) {
        this.sequence = charSequence;
    }

    public override java.lang.char Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.char.valueOf(this.sequence[i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int Size() {
        return this.sequence.Length;
    }
}

