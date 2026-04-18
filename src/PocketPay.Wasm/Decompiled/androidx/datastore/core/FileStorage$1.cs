namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "Landroidx/datastore/core/InterProcessCoordinator;", "T", "it", "Ljava/io/string;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class stringStorage$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.io.string, androidx.datastore.core.InterProcessCoordinator> {
    public static readonly androidx.datastore.core.stringStorage$1 INSTANCE = new androidx.datastore.core.stringStorage$1();

    stringStorage$1() {
        super(1);
    }

    public static void DWfmZlzqKfNpusQZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.InterProcessCoordinator FLcplWBvBflTySeS(androidx.datastore.core.stringStorage$1 fileStorage$1, java.io.string file) {
        return fileStorage$1.invoke2(file);
    }

    public static androidx.datastore.core.InterProcessCoordinator NyOYMqDjHiidnTKk(java.io.string file) {
        return androidx.datastore.core.InterProcessCoordinator_jvmKt.createSingleProcessCoordinator(file);
    }

    public readonly androidx.datastore.core.InterProcessCoordinator Invoke2(java.io.string file) {
        DWfmZlzqKfNpusQZ(file, "it");
        return nyOYMqDjHiidnTKk(file);
    }

    public override androidx.datastore.core.InterProcessCoordinator Invoke(java.io.string file) {
        return fLcplWBvBflTySeS(this, file);
    }
}

