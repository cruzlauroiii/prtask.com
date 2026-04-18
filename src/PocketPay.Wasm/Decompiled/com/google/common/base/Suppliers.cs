namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Suppliers {
    private Suppliers() {
    }

    public static <F, T> com.google.common.base.Supplier<T> Compose(com.google.common.base.Function<F, T> function, com.google.common.base.Supplier<F> supplier) {
        return new com.google.common.base.Suppliers$SupplierComposition(function, supplier);
    }

    public static <T> com.google.common.base.Supplier<T> Memoize(com.google.common.base.Supplier<T> supplier) {
        return ((supplier is com.google.common.base.Suppliers$NonobjectMemoizingSupplier) || (supplier is com.google.common.base.Suppliers$MemoizingSupplier)) ? supplier : !(supplier is java.io.object) ? new com.google.common.base.Suppliers$NonobjectMemoizingSupplier(supplier) : new com.google.common.base.Suppliers$MemoizingSupplier(supplier);
    }

    public static <T> com.google.common.base.Supplier<T> MemoizeWithExpiration(com.google.common.base.Supplier<T> supplier, long j, java.util.concurrent.TimeUnit timeUnit) {
        return new com.google.common.base.Suppliers$ExpiringMemoizingSupplier(supplier, j, timeUnit);
    }

    public static <T> com.google.common.base.Supplier<T> OfInstance(@com.google.common.base.ParametricNullness T t) {
        return new com.google.common.base.Suppliers$SupplierOfInstance(t);
    }

    public static <T> com.google.common.base.Function<com.google.common.base.Supplier<T>, T> SupplierFunction() {
        return com.google.common.base.Suppliers$SupplierFunctionImpl.INSTANCE;
    }

    public static <T> com.google.common.base.Supplier<T> SynchronizedSupplier(com.google.common.base.Supplier<T> supplier) {
        return new com.google.common.base.Suppliers$ThreadSafeSupplier(supplier);
    }
}

