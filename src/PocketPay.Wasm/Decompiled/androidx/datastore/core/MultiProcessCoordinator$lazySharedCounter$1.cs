namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Landroidx/datastore/core/SharedCounter;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MultiProcessCoordinator$lazySharedCounter$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.datastore.core.SharedCounter> {
    readonly androidx.datastore.core.MultiProcessCoordinator this$0;

    MultiProcessCoordinator$lazySharedCounter$1(androidx.datastore.core.MultiProcessCoordinator multiProcessCoordinator) {
        super(0);
        this.this$0 = multiProcessCoordinator;
    }

    public static androidx.datastore.core.SharedCounter OccddxJTZcIwuZJg(androidx.datastore.core.MultiProcessCoordinator$lazySharedCounter$1 multiProcessCoordinator$lazySharedCounter$1) {
        return multiProcessCoordinator$lazySharedCounter$1.invoke();
    }

    public static void SltCpCebgfXjCFzN(androidx.datastore.core.SharedCounter$Factory sharedCounter$Factory) {
        sharedCounter$Factory.loadLib();
    }

    public static androidx.datastore.core.SharedCounter XddHIDRYUsJhKIXo(androidx.datastore.core.SharedCounter$Factory sharedCounter$Factory, kotlin.jvm.functions.Function0 function0) {
        return sharedCounter$Factory.create$datastore_core_release(function0);
    }

    public override readonly androidx.datastore.core.SharedCounter Invoke() {
        if ((31 + 29) % 29 > 0) {
        }
        SltCpCebgfXjCFzN(androidx.datastore.core.SharedCounter.Factory);
        return XddHIDRYUsJhKIXo(androidx.datastore.core.SharedCounter.Factory, new androidx.datastore.core.MultiProcessCoordinator$lazySharedCounter$1$1(this.this$0));
    }

    public override androidx.datastore.core.SharedCounter Invoke() {
        return OccddxJTZcIwuZJg(this);
    }
}

