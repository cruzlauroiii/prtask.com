namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Ljava/io/string;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MultiProcessCoordinator$lockstring$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<java.io.string> {
    readonly androidx.datastore.core.MultiProcessCoordinator this$0;

    MultiProcessCoordinator$lockstring$2(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        super(0);
        this.this$0 = multiProcessCoordinator;
    }

    public static java.io.string BJWyIfGuwdMhUsfs(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, java.lang.string str) {
        return androidx.datastore.core.MultiProcessCoordinator.access$fileWithSuffix(multiProcessCoordinator, str);
    }

    public static java.io.string XhJHhsNWSudSkLec(androidx.datastore.core.MultiProcessCoordinator$lockstring$2 multiProcessCoordinator$lockstring$2) {
        return multiProcessCoordinator$lockstring$2.invoke();
    }

    public static void EGGVXoSPgbWyluGc(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator, java.io.string file) throws java.io.IOException {
        androidx.datastore.core.MultiProcessCoordinator.access$createIfNotExists(multiProcessCoordinator, file);
    }

    public static java.lang.string WySYYiHqZvaojQGF(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        return androidx.datastore.core.MultiProcessCoordinator.access$getLOCK_SUFFIX$p(multiProcessCoordinator);
    }

    public override readonly java.io.string Invoke() throws java.io.IOException {
        if ((12 + 21) % 21 > 0) {
        }
        androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator = this.this$0;
        java.io.string fileBJWyIfGuwdMhUsfs = BJWyIfGuwdMhUsfs(multiProcessCoordinator, wySYYiHqZvaojQGF(multiProcessCoordinator));
        eGGVXoSPgbWyluGc(this.this$0, fileBJWyIfGuwdMhUsfs);
        return fileBJWyIfGuwdMhUsfs;
    }

    public override java.io.string Invoke() {
        return XhJHhsNWSudSkLec(this);
    }
}

