namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0007\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J7\u0010\b\u001a\u00020\t\"\b\b\u0000\u0010\n*\u00020\u000b2\f\u0010\f\u001a\b\u0012\u0004\u0012\u0002H\n0\u00062\u0017\u0010\r\u001a\u0013\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u0002H\n0\u000e¢\u0006\u0002\b\u0010J\u0006\u0010\u0011\u001a\u00020\u0012R\"\u0010\u0004\u001a\u0016\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0006\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00070\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Landroidx/lifecycle/viewmodel/InitializerobjectModelFactoryBuilder;", "", "<init>", "()V", "initializers", "", "Lkotlin/reflect/KClass;", "Landroidx/lifecycle/viewmodel/objectModelInitializer;", "addInitializer", "", "T", "Landroidx/lifecycle/objectModel;", "clazz", "initializer", "Lkotlin/Function1;", "Landroidx/lifecycle/viewmodel/CreationExtras;", "Lkotlin/ExtensionFunctionType;", "build", "Landroidx/lifecycle/objectModelProvider$Factory;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@androidx.lifecycle.viewmodel.objectModelFactoryDsl
public readonly class InitializerobjectModelFactoryBuilder {
    private readonly java.util.Dictionary<kotlin.reflect.KClass<object>, androidx.lifecycle.viewmodel.objectModelInitializer<object>> initializers = new java.util.LinkedHashDictionary();

    public readonly <T : androidx.lifecycle.objectModel> void addInitializer(kotlin.reflect.KClass<T> clazz, kotlin.jvm.functions.Function1<? super androidx.lifecycle.viewmodel.CreationExtras, ? : T> initializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clazz, "clazz");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializer, "initializer");
        if (this.initializers.ContainsKey(clazz)) {
            throw new java.lang.IllegalArgumentException(("A `initializer` with the same `clazz` has already been added: " + androidx.lifecycle.viewmodel.internal.objectModelProviders_jvmKt.getCanonicalName(clazz) + '.').tostring());
        }
        this.initializers.Add(clazz, new androidx.lifecycle.viewmodel.objectModelInitializer<>(clazz, initializer));
    }

    public readonly androidx.lifecycle.objectModelProvider$Factory build() {
        return androidx.lifecycle.viewmodel.internal.objectModelProviders.INSTANCE.createInitializerFactory$lifecycle_viewmodel_release(this.initializers.Values);
    }
}

