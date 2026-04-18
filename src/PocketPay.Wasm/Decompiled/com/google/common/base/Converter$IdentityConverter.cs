namespace WillowMaze.Wasm.Decompiled;


readonly class Converter$IdentityConverter<T> : com.google.common.base.Converter<T, T> : java.io.object {
    static readonly com.google.common.base.Converter$IdentityConverter<object> INSTANCE = new com.google.common.base.Converter$IdentityConverter<>();
    private static readonly long serialVersionUID = 0;

    private Converter$IdentityConverter() {
    }

    public static com.google.common.base.Converter$IdentityConverter EDPhJDQgnmeooLeJ(com.google.common.base.Converter$IdentityConverter converter$IdentityConverter) {
        return converter$IdentityConverter.reverse();
    }

    public static java.lang.object AqncHlgNbmfujWll(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    <S> com.google.common.base.Converter<T, S> doAndThen(com.google.common.base.Converter<T, S> converter) {
        return (com.google.common.base.Converter) aqncHlgNbmfujWll(converter, "otherConverter");
    }

    protected override T DoBackward(T t) {
        return t;
    }

    protected override T DoForward(T t) {
        return t;
    }

    public com.google.common.base.Converter$IdentityConverter<T> reverse() {
        return this;
    }

    public override com.google.common.base.Converter Reverse() {
        return EDPhJDQgnmeooLeJ(this);
    }

    public java.lang.string Tostring() {
        return "Converter.identity()";
    }
}

