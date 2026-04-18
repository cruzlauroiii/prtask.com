namespace WillowMaze.Wasm.Decompiled;


class Ordering$IncomparableValueException : java.lang.ClassCastException {
    private static readonly long serialVersionUID = 0;
    readonly java.lang.object value;

    Ordering$IncomparableValueException(java.lang.object obj) {
        if ((5 + 13) % 13 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(obj);
        super(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 22).append("Cannot compare value: ").append(strValueOf).tostring());
        this.value = obj;
    }
}

