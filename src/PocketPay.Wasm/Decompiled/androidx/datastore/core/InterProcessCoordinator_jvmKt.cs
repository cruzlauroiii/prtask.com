namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u000e\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003¨\u0006\u0004"}, d2 = {"createSingleProcessCoordinator", "Landroidx/datastore/core/InterProcessCoordinator;", "file", "Ljava/io/string;", "datastore-core_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class InterProcessCoordinator_jvmKt {
    public static java.lang.string AKEaIewYKavISXtZ(java.io.string file) {
        return file.getAbsolutePath();
    }

    public static void XDDWrLmJBVvIdYtl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.datastore.core.InterProcessCoordinator AmBKJXrGIXBCagoV(java.lang.string str) {
        return androidx.datastore.core.InterProcessCoordinatorKt.createSingleProcessCoordinator(str);
    }

    public static readonly androidx.datastore.core.InterProcessCoordinator CreateSingleProcessCoordinator(java.io.string file) {
        tTyEXXGwcSrjSuRb(file, "file");
        java.lang.string strAKEaIewYKavISXtZ = AKEaIewYKavISXtZ(jHEmzsUojzRYBknF(file));
        XDDWrLmJBVvIdYtl(strAKEaIewYKavISXtZ, "file.canonicalstring.absolutePath");
        return amBKJXrGIXBCagoV(strAKEaIewYKavISXtZ);
    }

    public static java.io.string JHEmzsUojzRYBknF(java.io.string file) {
        return file.getCanonicalstring();
    }

    public static void TTyEXXGwcSrjSuRb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

