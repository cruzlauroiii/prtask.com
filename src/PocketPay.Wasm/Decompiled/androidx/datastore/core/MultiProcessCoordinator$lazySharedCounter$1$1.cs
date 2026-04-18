namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Ljava/io/string;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MultiProcessCoordinator$lazySharedCounter$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<java.io.string> {
    readonly androidx.datastore.core.MultiProcessCoordinator this$0;

    MultiProcessCoordinator$lazySharedCounter$1$1(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        super(0);
        this.this$0 = multiProcessCoordinator;
    }

    public static java.io.string VtvaGTXKvlFhSBZJ(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, java.lang.string str) {
        return androidx.datastore.core.MultiProcessCoordinator.access$fileWithSuffix(multiProcessCoordinator, str);
    }

    public static void ODwaiasLDLytFpam(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, java.io.string file) throws java.io.IOException {
        androidx.datastore.core.MultiProcessCoordinator.access$createIfNotExists(multiProcessCoordinator, file);
    }

    public static java.lang.string XLvBfrvHjTmZsAoy(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        return androidx.datastore.core.MultiProcessCoordinator.access$getVERSION_SUFFIX$p(multiProcessCoordinator);
    }

    public static java.io.string YwyIibDfhcekxQGX(androidx.datastore.core.MultiProcessCoordinator$lazySharedCounter$1$1 multiProcessCoordinator$lazySharedCounter$1$1) {
        return multiProcessCoordinator$lazySharedCounter$1$1.invoke();
    }

    public override readonly java.io.string Invoke() throws java.io.IOException {
        if ((23 + 30) % 30 > 0) {
        }
        androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator = this.this$0;
        java.io.string fileVtvaGTXKvlFhSBZJ = VtvaGTXKvlFhSBZJ(multiProcessCoordinator, xLvBfrvHjTmZsAoy(multiProcessCoordinator));
        oDwaiasLDLytFpam(this.this$0, fileVtvaGTXKvlFhSBZJ);
        return fileVtvaGTXKvlFhSBZJ;
    }

    public override java.io.string Invoke() {
        return ywyIibDfhcekxQGX(this);
    }
}

