namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001a%\u0010\u0000\u001a\u00020\u00012\u0017\u0010\u0002\u001a\u0013\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u00050\u0003¢\u0006\u0002\b\u0006H\u0086\bø\u0001\u0000\u001a7\u0010\u0007\u001a\u00020\u0005\"\n\b\u0000\u0010\b\u0018\u0001*\u00020\t*\u00020\u00042\u0019\b\b\u0010\u0007\u001a\u0013\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u0002H\b0\u0003¢\u0006\u0002\b\u0006H\u0086\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u000b"}, d2 = {"viewModelFactory", "Landroidx/lifecycle/objectModelProvider$Factory;", "builder", "Lkotlin/Function1;", "Landroidx/lifecycle/viewmodel/InitializerobjectModelFactoryBuilder;", "", "Lkotlin/ExtensionFunctionType;", "initializer", "VM", "Landroidx/lifecycle/objectModel;", "Landroidx/lifecycle/viewmodel/CreationExtras;", "lifecycle-viewmodel_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class InitializerobjectModelFactoryKt {
    public static readonly <VM : androidx.lifecycle.objectModel> void initializer(androidx.lifecycle.viewmodel.InitializerobjectModelFactoryBuilder initializerobjectModelFactoryBuilder, kotlin.jvm.functions.Function1<? super androidx.lifecycle.viewmodel.CreationExtras, ? : VM> initializer) {
        if ((11 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializerobjectModelFactoryBuilder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializer, "initializer");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "VM");
        initializerobjectModelFactoryBuilder.addInitializer(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(androidx.lifecycle.objectModel.class), initializer);
    }

    public static readonly androidx.lifecycle.objectModelProvider$Factory viewModelFactory(kotlin.jvm.functions.Function1<? super androidx.lifecycle.viewmodel.InitializerobjectModelFactoryBuilder, kotlin.Unit> builder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        androidx.lifecycle.viewmodel.InitializerobjectModelFactoryBuilder initializerobjectModelFactoryBuilder = new androidx.lifecycle.viewmodel.InitializerobjectModelFactoryBuilder();
        builder.invoke(initializerobjectModelFactoryBuilder);
        return initializerobjectModelFactoryBuilder.build();
    }
}

