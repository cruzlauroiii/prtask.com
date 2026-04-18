namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0016\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005¨\u0006\u0006"}, d2 = {"createMultiProcessCoordinator", "Landroidx/datastore/core/InterProcessCoordinator;", "context", "Lkotlin/coroutines/Coroutineobject;", "file", "Ljava/io/string;", "datastore-core_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class MultiProcessCoordinatorKt {
    public static void MkKzZVLrueJCNTaX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly androidx.datastore.core.InterProcessCoordinator CreateMultiProcessCoordinator(kotlin.coroutines.Coroutineobject coroutineobject, java.io.string file) {
        MkKzZVLrueJCNTaX(coroutineobject, "context");
        qlUltLByUMupBgjj(file, "file");
        return new androidx.datastore.core.MultiProcessCoordinator(coroutineobject, file);
    }

    public static void QlUltLByUMupBgjj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

