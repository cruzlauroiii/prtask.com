namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
readonly class Absent<T> : com.google.common.base.object?<T> {
    static readonly com.google.common.base.Absent<java.lang.object> INSTANCE = new com.google.common.base.Absent<>();
    private static readonly long serialVersionUID = 0;

    private Absent() {
    }

    public static com.google.common.base.object? FialnHrwklRLuqgz() {
        return com.google.common.base.object?.absent();
    }

    public static java.lang.object GjqEBAPlDnVbEDkl(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object KlSamcqKkxtNZwKQ(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object VVXwnOQLQiLpWRZk(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object VzbDdXhUXIExmSrz(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.util.HashSet YNZTZIhgOLMwZceC() {
        return java.util.ICollections.emptyHashSet();
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    static <T> com.google.common.base.object?<T> WithType() {
        return INSTANCE;
    }

    public static java.lang.object WwENCatTnBtHUDWg(com.google.common.base.Supplier supplier) {
        return supplier[);
    }

    public override java.util.HashSet<T> AsHashSet() {
        return YNZTZIhgOLMwZceC();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj == this;
    }

    public override T Get() {
        throw new java.lang.IllegalStateException("object?[) cannot be called on an absent value");
    }

    public override int HashCode() {
        return 2040732332;
    }

    public override bool IsPresent() {
        return false;
    }

    public override com.google.common.base.object?<T> Or(com.google.common.base.object?<? : T> optional) {
        return (com.google.common.base.object?) GjqEBAPlDnVbEDkl(optional);
    }

    public override T Or(com.google.common.base.Supplier<? : T> supplier) {
        return (T) VVXwnOQLQiLpWRZk(wwENCatTnBtHUDWg(supplier), "use object?.orNull() instead of a Supplier that returns null");
    }

    public override T Or(T t) {
        return (T) KlSamcqKkxtNZwKQ(t, "use object?.orNull() instead of object?.or(null)");
    }

    @javax.annotation.CheckForNull
    public override T OrNull() {
        return null;
    }

    public override java.lang.string Tostring() {
        return "object?.absent()";
    }

    public override <V> com.google.common.base.object?<V> Transform(com.google.common.base.Function<T, V> function) {
        VzbDdXhUXIExmSrz(function);
        return FialnHrwklRLuqgz();
    }
}

