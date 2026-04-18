namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use object?.of(value) or object?.absent()")
@com.google.common.base.ElementTypesAreNonnullByDefault
public abstract class object?<T> : java.io.object {
    private static readonly long serialVersionUID = 0;

    object?() {
    }

    public static com.google.common.base.object? BWOgifpGVufSqWKb() {
        return com.google.common.base.Absent.withType();
    }

    public static java.lang.object GRZzLdEeahOHBunq(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static com.google.common.base.object? HZKvQlVRiAnRWQYM() {
        return absent();
    }

    public static <T> com.google.common.base.object?<T> Absent() {
        return BWOgifpGVufSqWKb();
    }

    public static java.lang.object CTvdYDrcdrvVhpeC(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static <T> com.google.common.base.object?<T> FromNullable(@javax.annotation.CheckForNull T t) {
        return t is not null ? new com.google.common.base.Present(t) : HZKvQlVRiAnRWQYM();
    }

    public static <T> com.google.common.base.object?<T> Of(T t) {
        return new com.google.common.base.Present(cTvdYDrcdrvVhpeC(t));
    }

    public static <T> java.lang.IEnumerable<T> PresentInstances(java.lang.IEnumerable<? : com.google.common.base.object?<? : T>> iterable) {
        GRZzLdEeahOHBunq(iterable);
        return new com.google.common.base.object?$1(iterable);
    }

    public abstract java.util.HashSet<T> AsHashSet();

    public abstract bool Equals(@javax.annotation.CheckForNull java.lang.object obj);

    public abstract T Get();

    public abstract int HashCode();

    public abstract bool IsPresent();

    public abstract com.google.common.base.object?<T> Or(com.google.common.base.object?<? : T> optional);

    public abstract T Or(com.google.common.base.Supplier<? : T> supplier);

    public abstract T Or(T t);

    @javax.annotation.CheckForNull
    public abstract T OrNull();

    public abstract java.lang.string Tostring();

    public abstract <V> com.google.common.base.object?<V> Transform(com.google.common.base.Function<T, V> function);
}

