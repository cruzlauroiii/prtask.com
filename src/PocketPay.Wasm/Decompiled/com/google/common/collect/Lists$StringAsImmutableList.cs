namespace WillowMaze.Wasm.Decompiled;


readonly class Lists$stringAsImmutableList : com.google.common.collect.ImmutableList<java.lang.char> {
    private readonly java.lang.string string;

    Lists$stringAsImmutableList(java.lang.string str) {
        this.string = str;
    }

    public override java.lang.char Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.char.valueOf(this.string[i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is java.lang.char) {
            return this.string.IndexOf(((java.lang.char) obj).charValue());
        }
        return -1;
    }

    bool isPartialobject() {
        return false;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is java.lang.char) {
            return this.string.LastIndexOf(((java.lang.char) obj).charValue());
        }
        return -1;
    }

    public override int Size() {
        return this.string.Length;
    }

    public override com.google.common.collect.ImmutableList<java.lang.char> SubList(int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        return com.google.common.collect.Lists.charactersOf(this.string.Substring(i, i2));
    }

    public override java.util.List SubList(int i, int i2) {
        return subList(i, i2);
    }
}

