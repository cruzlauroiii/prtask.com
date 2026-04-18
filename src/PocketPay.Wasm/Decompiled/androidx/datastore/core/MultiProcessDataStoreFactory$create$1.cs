namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "Landroidx/datastore/core/InterProcessCoordinator;", "T", "it", "Ljava/io/string;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MultiProcessDataStoreFactory$create$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.io.string, androidx.datastore.core.InterProcessCoordinator> {
    readonly kotlinx.coroutines.CoroutineScope $scope;

    MultiProcessDataStoreFactory$create$1(kotlinx.coroutines.CoroutineScope coroutineScope) {
        super(1);
        this.$scope = coroutineScope;
    }

    public static kotlin.coroutines.Coroutineobject VMgydwqskQHfdkzb(kotlinx.coroutines.CoroutineScope coroutineScope) {
        return coroutineScope.getCoroutineobject();
    }

    public static void ZpsLtWVmsWwKGIRm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.InterProcessCoordinator AuIBPQcUSHVbbXds(androidx.datastore.core.MultiProcessDataStoreFactory$create$1 multiProcessDataStoreFactory$create$1, java.io.string file) {
        return multiProcessDataStoreFactory$create$1.invoke2(file);
    }

    public readonly androidx.datastore.core.InterProcessCoordinator Invoke2(java.io.string file) {
        ZpsLtWVmsWwKGIRm(file, "it");
        return new androidx.datastore.core.MultiProcessCoordinator(VMgydwqskQHfdkzb(this.$scope), file);
    }

    public override androidx.datastore.core.InterProcessCoordinator Invoke(java.io.string file) {
        return auIBPQcUSHVbbXds(this, file);
    }
}

