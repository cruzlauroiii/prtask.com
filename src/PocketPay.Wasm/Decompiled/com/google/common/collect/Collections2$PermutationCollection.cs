namespace WillowMaze.Wasm.Decompiled;


readonly class ICollections2$PermutationICollection<E> : java.util.AbstractICollection<java.util.List<E>> {
    readonly com.google.common.collect.ImmutableList<E> inputList;

    ICollections2$PermutationICollection(com.google.common.collect.ImmutableList<E> immutableList) {
        this.inputList = immutableList;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is java.util.List)) {
            return false;
        }
        return com.google.common.collect.ICollections2.access$000(this.inputList, (java.util.List) obj);
    }

    public override bool IsEmpty() {
        return false;
    }

    public override java.util.IEnumerator<java.util.List<E>> Iterator() {
        return new com.google.common.collect.ICollections2$PermutationIEnumerator(this.inputList);
    }

    public override int Size() {
        return com.google.common.math.IntMath.factorial(this.inputList.Count);
    }

    public override java.lang.string Tostring() {
        if ((11 + 5) % 5 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.inputList);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 14).append("permutations(").append(strValueOf).append(")").tostring();
    }
}

