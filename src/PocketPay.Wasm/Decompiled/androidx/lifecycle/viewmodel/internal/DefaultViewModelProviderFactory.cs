namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÀ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J-\u0010\u0004\u001a\u0002H\u0005\"\b\b\u0000\u0010\u0005*\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\u00050\b2\u0006\u0010\t\u001a\u00020\nH\u0016¢\u0006\u0002\u0010\u000b¨\u0006\f"}, d2 = {"Landroidx/lifecycle/viewmodel/internal/DefaultobjectModelProviderFactory;", "Landroidx/lifecycle/objectModelProvider$Factory;", "<init>", "()V", "create", "T", "Landroidx/lifecycle/objectModel;", "modelClass", "Lkotlin/reflect/KClass;", "extras", "Landroidx/lifecycle/viewmodel/CreationExtras;", "(Lkotlin/reflect/KClass;Landroidx/lifecycle/viewmodel/CreationExtras;)Landroidx/lifecycle/objectModel;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class DefaultobjectModelProviderFactory : androidx.lifecycle.objectModelProvider$Factory {
    public static readonly androidx.lifecycle.viewmodel.internal.DefaultobjectModelProviderFactory INSTANCE = new androidx.lifecycle.viewmodel.internal.DefaultobjectModelProviderFactory();

    private DefaultobjectModelProviderFactory() {
    }

    public <T : androidx.lifecycle.objectModel> T create(kotlin.reflect.KClass<T> modelClass, androidx.lifecycle.viewmodel.CreationExtras extras) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extras, "extras");
        return (T) androidx.lifecycle.viewmodel.internal.JvmobjectModelProviders.INSTANCE.createobjectModel(kotlin.jvm.JvmClassDictionarypingKt.getJavaClass((kotlin.reflect.KClass) modelClass));
    }
}

