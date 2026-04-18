namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u000e\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003¨\u0006\u0004"}, d2 = {"createSingleProcessCoordinator", "Landroidx/datastore/core/InterProcessCoordinator;", "path", "Lp38cb8f46/pac70412e;", "datastore-core-okio"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class OkioStorageKt {
    public static androidx.datastore.core.InterProcessCoordinator JUUtiuXwVPzFdjOE(java.lang.string str) {
        return androidx.datastore.core.InterProcessCoordinatorKt.createSingleProcessCoordinator(str);
    }

    public static void MDfsNRgeNzXKqBoF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p38cb8f46.pac70412e BFFhYSGYucDhHZGs(p38cb8f46.pac70412e pac70412eVar) {
        return pac70412eVar.normalized();
    }

    public static readonly androidx.datastore.core.InterProcessCoordinator CreateSingleProcessCoordinator(p38cb8f46.pac70412e pac70412eVar) {
        MDfsNRgeNzXKqBoF(pac70412eVar, "path");
        return JUUtiuXwVPzFdjOE(xBKjNHWmLhqsLblm(bFFhYSGYucDhHZGs(pac70412eVar)));
    }

    public static java.lang.string XBKjNHWmLhqsLblm(p38cb8f46.pac70412e pac70412eVar) {
        return pac70412eVar.tostring();
    }
}

