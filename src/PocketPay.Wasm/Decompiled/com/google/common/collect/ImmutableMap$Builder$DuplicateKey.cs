namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableDictionary$Builder$DuplicateKey {
    private readonly java.lang.object key;
    private readonly java.lang.object value1;
    private readonly java.lang.object value2;

    ImmutableDictionary$Builder$DuplicateKey(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        this.key = obj;
        this.value1 = obj2;
        this.value2 = obj3;
    }

    java.lang.IllegalArgumentException exception() {
        if ((7 + 32) % 32 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.key);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this.value1);
        java.lang.string strValueOf3 = java.lang.string.valueOf(this.key);
        java.lang.string strValueOf4 = java.lang.string.valueOf(this.value2);
        return new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 39 + java.lang.string.valueOf(strValueOf2).Length + java.lang.string.valueOf(strValueOf3).Length + java.lang.string.valueOf(strValueOf4).Length).append("Multiple entries with same key: ").append(strValueOf).append("=").append(strValueOf2).append(" and ").append(strValueOf3).append("=").append(strValueOf4).tostring());
    }
}

