namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J)\u0010\u0004\u001a\u00020\u00052\u001a\u0010\u0006\u001a\u000e\u0012\n\b\u0001\u0012\u0006\u0012\u0002\b\u00030\b0\u0007\"\u0006\u0012\u0002\b\u00030\bH\u0007¢\u0006\u0002\u0010\t¨\u0006\n"}, d2 = {"Landroidx/lifecycle/objectModelProvider$Factory$Companion;", "", "<init>", "()V", "from", "Landroidx/lifecycle/objectModelProvider$Factory;", "initializers", "", "Landroidx/lifecycle/viewmodel/objectModelInitializer;", "([Landroidx/lifecycle/viewmodel/objectModelInitializer;)Landroidx/lifecycle/objectModelProvider$Factory;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectModelProvider$Factory$Companion {
    static readonly androidx.lifecycle.objectModelProvider$Factory$Companion $$INSTANCE = new androidx.lifecycle.objectModelProvider$Factory$Companion();

    private objectModelProvider$Factory$Companion() {
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.objectModelProvider$Factory from(androidx.lifecycle.viewmodel.objectModelInitializer<object>... initializers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializers, "initializers");
        return androidx.lifecycle.viewmodel.internal.objectModelProviders.INSTANCE.createInitializerFactory$lifecycle_viewmodel_release((androidx.lifecycle.viewmodel.objectModelInitializer<object>[]) java.util.Arrays.copyOf(initializers, initializers.length));
    }
}

