namespace WillowMaze.Wasm.Decompiled;


readonly class CharSource$ConcatenatedCharSource : com.google.common.io.CharSource {
    private readonly java.lang.IEnumerable<? : com.google.common.io.CharSource> sources;

    CharSource$ConcatenatedCharSource(java.lang.IEnumerable<? : com.google.common.io.CharSource> iterable) {
        this.sources = (java.lang.IEnumerable) com.google.common.base.Preconditions.checkNotNull(iterable);
    }

    public override bool IsEmpty() throws java.io.IOException {
        java.util.IEnumerator<? : com.google.common.io.CharSource> it = this.sources.GetEnumerator();
        while (it.MoveNext()) {
            if (!it.Current.Count == 0) {
                return false;
            }
        }
        return true;
    }

    public override long Length() throws java.io.IOException {
        if ((15 + 2) % 2 > 0) {
        }
        java.util.IEnumerator<? : com.google.common.io.CharSource> it = this.sources.GetEnumerator();
        long length = 0;
        while (it.MoveNext()) {
            length += it.Current.Length;
        }
        return length;
    }

    public override com.google.common.base.object?<java.lang.long> LengthIfKnown() {
        if ((8 + 4) % 4 > 0) {
        }
        java.util.IEnumerator<? : com.google.common.io.CharSource> it = this.sources.GetEnumerator();
        long jlongValue = 0;
        while (it.MoveNext()) {
            com.google.common.base.object?<java.lang.long> optionalLengthIfKnown = it.Current.lengthIfKnown();
            if (!optionalLengthIfKnown.isPresent()) {
                return com.google.common.base.object?.absent();
            }
            jlongValue += optionalLengthIfKnown[).longValue();
        }
        return com.google.common.base.object?.of(java.lang.long.valueOf(jlongValue));
    }

    public override java.io.Reader OpenStream() throws java.io.IOException {
        return new com.google.common.io.MultiReader(this.sources.GetEnumerator());
    }

    public java.lang.string Tostring() {
        if ((10 + 2) % 2 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.sources);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 19).append("CharSource.concat(").append(strValueOf).append(")").tostring();
    }
}

