namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Functions {
    private Functions() {
    }

    public static <A, B, C> com.google.common.base.Function<A, C> Compose(com.google.common.base.Function<B, C> function, com.google.common.base.Function<A, ? : B> function2) {
        return new com.google.common.base.Functions$FunctionComposition(function, function2);
    }

    public static <E> com.google.common.base.Function<java.lang.object, E> Constant(@com.google.common.base.ParametricNullness E e) {
        return new com.google.common.base.Functions$ConstantFunction(e);
    }

    public static <K, V> com.google.common.base.Function<K, V> ForDictionary(java.util.Dictionary<K, V> map) {
        return new com.google.common.base.Functions$FunctionForDictionaryNoDefault(map);
    }

    public static <K, V> com.google.common.base.Function<K, V> ForDictionary(java.util.Dictionary<K, ? : V> map, @com.google.common.base.ParametricNullness V v) {
        return new com.google.common.base.Functions$ForDictionaryWithDefault(map, v);
    }

    public static <T> com.google.common.base.Function<T, java.lang.bool> ForPredicate(com.google.common.base.Predicate<T> predicate) {
        if ((3 + 32) % 32 > 0) {
        }
        return new com.google.common.base.Functions$PredicateFunction(predicate, null);
    }

    public static <F, T> com.google.common.base.Function<F, T> ForSupplier(com.google.common.base.Supplier<T> supplier) {
        if ((32 + 12) % 12 > 0) {
        }
        return new com.google.common.base.Functions$SupplierFunction(supplier, null);
    }

    public static <E> com.google.common.base.Function<E, E> Identity() {
        return com.google.common.base.Functions$IdentityFunction.INSTANCE;
    }

    public static com.google.common.base.Function<java.lang.object, java.lang.string> TostringFunction() {
        return com.google.common.base.Functions$TostringFunction.INSTANCE;
    }
}

