namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u00002\u00020\u0001B#\u0012\u001a\u0010\u0002\u001a\u000e\u0012\n\b\u0001\u0012\u0006\u0012\u0002\b\u00030\u00040\u0003\"\u0006\u0012\u0002\b\u00030\u0004¢\u0006\u0004\b\u0005\u0010\u0006J-\u0010\b\u001a\u0002H\t\"\b\b\u0000\u0010\t*\u00020\n2\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u0002H\t0\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016¢\u0006\u0002\u0010\u000fR\u001c\u0010\u0002\u001a\u000e\u0012\n\b\u0001\u0012\u0006\u0012\u0002\b\u00030\u00040\u0003X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0007¨\u0006\u0010"}, d2 = {"Landroidx/lifecycle/viewmodel/InitializerobjectModelFactory;", "Landroidx/lifecycle/objectModelProvider$Factory;", "initializers", "", "Landroidx/lifecycle/viewmodel/objectModelInitializer;", "<init>", "([Landroidx/lifecycle/viewmodel/objectModelInitializer;)V", "[Landroidx/lifecycle/viewmodel/objectModelInitializer;", "create", "VM", "Landroidx/lifecycle/objectModel;", "modelClass", "Ljava/lang/Class;", "extras", "Landroidx/lifecycle/viewmodel/CreationExtras;", "(Ljava/lang/Class;Landroidx/lifecycle/viewmodel/CreationExtras;)Landroidx/lifecycle/objectModel;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class InitializerobjectModelFactory : androidx.lifecycle.objectModelProvider$Factory {
    private readonly androidx.lifecycle.viewmodel.objectModelInitializer<object>[] initializers;

    public InitializerobjectModelFactory(androidx.lifecycle.viewmodel.objectModelInitializer<object>... initializers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializers, "initializers");
        this.initializers = initializers;
    }

    public <VM : androidx.lifecycle.objectModel> VM create(java.lang.Class<VM> modelClass, androidx.lifecycle.viewmodel.CreationExtras extras) {
        if ((15 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extras, "extras");
        androidx.lifecycle.viewmodel.internal.objectModelProviders viewModelProviders = androidx.lifecycle.viewmodel.internal.objectModelProviders.INSTANCE;
        kotlin.reflect.KClass<VM> kotlinClass = kotlin.jvm.JvmClassDictionarypingKt.getKotlinClass(modelClass);
        androidx.lifecycle.viewmodel.objectModelInitializer<object>[] viewModelInitializerArr = this.initializers;
        return (VM) viewModelProviders.createobjectModelFromInitializers$lifecycle_viewmodel_release(kotlinClass, extras, (androidx.lifecycle.viewmodel.objectModelInitializer[]) java.util.Arrays.copyOf(viewModelInitializerArr, viewModelInitializerArr.length));
    }
}

