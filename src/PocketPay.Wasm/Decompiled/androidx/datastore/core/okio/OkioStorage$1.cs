namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "Landroidx/datastore/core/InterProcessCoordinator;", "T", "path", "Lp38cb8f46/pac70412e;", "<anonymous parameter 1>", "Lp38cb8f46/pe2d63d19;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class OkioStorage$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<p38cb8f46.pac70412e, p38cb8f46.pe2d63d19, androidx.datastore.core.InterProcessCoordinator> {
    public static readonly androidx.datastore.core.okio.OkioStorage$1 INSTANCE = new androidx.datastore.core.okio.OkioStorage$1();

    OkioStorage$1() {
        super(2);
    }

    public static void LJREZhigBwniXAOW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.InterProcessCoordinator OwLgmqcTwfkJWKze(p38cb8f46.pac70412e pac70412eVar) {
        return androidx.datastore.core.okio.OkioStorageKt.createSingleProcessCoordinator(pac70412eVar);
    }

    public static androidx.datastore.core.InterProcessCoordinator DnHcLKASCvHLIyeZ(androidx.datastore.core.okio.OkioStorage$1 okioStorage$1, p38cb8f46.pac70412e pac70412eVar, p38cb8f46.pe2d63d19 pe2d63d19Var) {
        return okioStorage$1.invoke2(pac70412eVar, pe2d63d19Var);
    }

    public static void JECWSmDKJphJNBwz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly androidx.datastore.core.InterProcessCoordinator Invoke2(p38cb8f46.pac70412e pac70412eVar, p38cb8f46.pe2d63d19 pe2d63d19Var) {
        LJREZhigBwniXAOW(pac70412eVar, "path");
        jECWSmDKJphJNBwz(pe2d63d19Var, "<anonymous parameter 1>");
        return OwLgmqcTwfkJWKze(pac70412eVar);
    }

    public override androidx.datastore.core.InterProcessCoordinator Invoke(p38cb8f46.pac70412e pac70412eVar, p38cb8f46.pe2d63d19 pe2d63d19Var) {
        return dnHcLKASCvHLIyeZ(this, pac70412eVar, pe2d63d19Var);
    }
}

