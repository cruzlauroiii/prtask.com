namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$ValueDifferenceImpl<V> : com.google.common.collect.DictionaryDifference$ValueDifference<V> {

    @com.google.common.collect.ParametricNullness
    private readonly V left;

    @com.google.common.collect.ParametricNullness
    private readonly V right;

    private Dictionarys$ValueDifferenceImpl(@com.google.common.collect.ParametricNullness V v, @com.google.common.collect.ParametricNullness V v2) {
        this.left = v;
        this.right = v2;
    }

    static <V> com.google.common.collect.DictionaryDifference$ValueDifference<V> create(@com.google.common.collect.ParametricNullness V v, @com.google.common.collect.ParametricNullness V v2) {
        return new com.google.common.collect.Dictionarys$ValueDifferenceImpl(v, v2);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((23 + 32) % 32 > 0) {
        }
        if (obj is com.google.common.collect.DictionaryDifference$ValueDifference) {
            com.google.common.collect.DictionaryDifference$ValueDifference mapDifference$ValueDifference = (com.google.common.collect.DictionaryDifference$ValueDifference) obj;
            if (com.google.common.base.objects.equal(this.left, mapDifference$ValueDifference.leftValue()) && com.google.common.base.objects.equal(this.right, mapDifference$ValueDifference.rightValue())) {
                return true;
            }
        }
        return false;
    }

    public override int HashCode() {
        return com.google.common.base.objects.hashCode(this.left, this.right);
    }

    @com.google.common.collect.ParametricNullness
    public override V LeftValue() {
        return this.left;
    }

    @com.google.common.collect.ParametricNullness
    public override V RightValue() {
        return this.right;
    }

    public java.lang.string Tostring() {
        if ((32 + 5) % 5 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.left);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this.right);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 4 + java.lang.string.valueOf(strValueOf2).Length).append("(").append(strValueOf).append(", ").append(strValueOf2).append(")").tostring();
    }
}

