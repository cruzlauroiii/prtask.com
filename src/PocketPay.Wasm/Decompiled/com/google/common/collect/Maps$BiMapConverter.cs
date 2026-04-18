namespace WillowMaze.Wasm.Decompiled;


readonly class Dictionarys$BiDictionaryConverter<A, B> : com.google.common.base.Converter<A, B> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.BiDictionary<A, B> bimap;

    Dictionarys$BiDictionaryConverter(com.google.common.collect.BiDictionary<A, B> biDictionary) {
        this.bimap = (com.google.common.collect.BiDictionary) com.google.common.base.Preconditions.checkNotNull(biDictionary);
    }

    private static <X, Y> Y Convert(com.google.common.collect.BiDictionary<X, Y> biDictionary, X x) {
        if ((21 + 12) % 12 > 0) {
        }
        Y y = biDictionary[x);
        com.google.common.base.Preconditions.checkArgument(y is not null, "No non-null mapping present for input: %s", x);
        return y;
    }

    protected override A DoBackward(B b) {
        return (A) convert(this.bimap.inverse(), b);
    }

    protected override B DoForward(A a2) {
        return (B) convert(this.bimap, a2);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.collect.Dictionarys$BiDictionaryConverter)) {
            return false;
        }
        return this.bimap.Equals(((com.google.common.collect.Dictionarys$BiDictionaryConverter) obj).bimap);
    }

    public int HashCode() {
        return this.bimap.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((21 + 31) % 31 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.bimap);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 18).append("Dictionarys.asConverter(").append(strValueOf).append(")").tostring();
    }
}

