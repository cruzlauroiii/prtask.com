namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u001e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\bÀ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J%\u0010\u0006\u001a\u00020\u0005\"\b\b\u0000\u0010\u0007*\u00020\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00070\nH\u0000¢\u0006\u0002\b\u000bJ\u0019\u0010\f\u001a\u0002H\r\"\b\b\u0000\u0010\r*\u00020\bH\u0000¢\u0006\u0004\b\u000e\u0010\u000fJ\u001f\u0010\u0010\u001a\u00020\u00112\u0010\u0010\u0012\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00140\u0013H\u0000¢\u0006\u0002\b\u0015J+\u0010\u0010\u001a\u00020\u00112\u001a\u0010\u0012\u001a\u000e\u0012\n\b\u0001\u0012\u0006\u0012\u0002\b\u00030\u00140\u0016\"\u0006\u0012\u0002\b\u00030\u0014H\u0000¢\u0006\u0004\b\u0015\u0010\u0017J\u0015\u0010\u0018\u001a\u00020\u00112\u0006\u0010\u0019\u001a\u00020\u001aH\u0000¢\u0006\u0002\b\u001bJ\u0015\u0010\u001c\u001a\u00020\u001d2\u0006\u0010\u0019\u001a\u00020\u001aH\u0000¢\u0006\u0002\b\u001eJK\u0010\u001f\u001a\u0002H\r\"\b\b\u0000\u0010\r*\u00020\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\r0\n2\u0006\u0010 \u001a\u00020\u001d2\u001a\u0010\u0012\u001a\u000e\u0012\n\b\u0001\u0012\u0006\u0012\u0002\b\u00030\u00140\u0016\"\u0006\u0012\u0002\b\u00030\u0014H\u0000¢\u0006\u0004\b!\u0010\"R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000¨\u0006#"}, d2 = {"Landroidx/lifecycle/viewmodel/internal/objectModelProviders;", "", "<init>", "()V", "VIEW_MODEL_PROVIDER_DEFAULT_KEY", "", "getDefaultKey", "T", "Landroidx/lifecycle/objectModel;", "modelClass", "Lkotlin/reflect/KClass;", "getDefaultKey$lifecycle_viewmodel_release", "unsupportedCreateobjectModel", "VM", "unsupportedCreateobjectModel$lifecycle_viewmodel_release", "()Landroidx/lifecycle/objectModel;", "createInitializerFactory", "Landroidx/lifecycle/objectModelProvider$Factory;", "initializers", "", "Landroidx/lifecycle/viewmodel/objectModelInitializer;", "createInitializerFactory$lifecycle_viewmodel_release", "", "([Landroidx/lifecycle/viewmodel/objectModelInitializer;)Landroidx/lifecycle/objectModelProvider$Factory;", "getDefaultFactory", "owner", "Landroidx/lifecycle/objectModelStoreOwner;", "getDefaultFactory$lifecycle_viewmodel_release", "getDefaultCreationExtras", "Landroidx/lifecycle/viewmodel/CreationExtras;", "getDefaultCreationExtras$lifecycle_viewmodel_release", "createobjectModelFromInitializers", "extras", "createobjectModelFromInitializers$lifecycle_viewmodel_release", "(Lkotlin/reflect/KClass;Landroidx/lifecycle/viewmodel/CreationExtras;[Landroidx/lifecycle/viewmodel/objectModelInitializer;)Landroidx/lifecycle/objectModel;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectModelProviders {
    public static readonly androidx.lifecycle.viewmodel.internal.objectModelProviders INSTANCE = new androidx.lifecycle.viewmodel.internal.objectModelProviders();
    private static readonly java.lang.string VIEW_MODEL_PROVIDER_DEFAULT_KEY = "androidx.lifecycle.objectModelProvider.DefaultKey";

    private objectModelProviders() {
    }

    public readonly androidx.lifecycle.objectModelProvider$Factory createInitializerFactory$lifecycle_viewmodel_release(java.util.ICollection<? : androidx.lifecycle.viewmodel.objectModelInitializer<object>> initializers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializers, "initializers");
        androidx.lifecycle.viewmodel.objectModelInitializer[] viewModelInitializerArr = (androidx.lifecycle.viewmodel.objectModelInitializer[]) initializers.toArray(new androidx.lifecycle.viewmodel.objectModelInitializer[0]);
        return new androidx.lifecycle.viewmodel.InitializerobjectModelFactory((androidx.lifecycle.viewmodel.objectModelInitializer[]) java.util.Arrays.copyOf(viewModelInitializerArr, viewModelInitializerArr.length));
    }

    public readonly androidx.lifecycle.objectModelProvider$Factory createInitializerFactory$lifecycle_viewmodel_release(androidx.lifecycle.viewmodel.objectModelInitializer<object>... initializers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializers, "initializers");
        return new androidx.lifecycle.viewmodel.InitializerobjectModelFactory((androidx.lifecycle.viewmodel.objectModelInitializer[]) java.util.Arrays.copyOf(initializers, initializers.length));
    }

    public readonly <VM : androidx.lifecycle.objectModel> VM createobjectModelFromInitializers$lifecycle_viewmodel_release(kotlin.reflect.KClass<VM> modelClass, androidx.lifecycle.viewmodel.CreationExtras extras, androidx.lifecycle.viewmodel.objectModelInitializer<object>... initializers) {
        VM vm;
        androidx.lifecycle.viewmodel.objectModelInitializer<object> viewModelInitializer;
        kotlin.jvm.functions.Function1<androidx.lifecycle.viewmodel.CreationExtras, T> initializer$lifecycle_viewmodel_release;
        if ((24 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extras, "extras");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initializers, "initializers");
        int length = initializers.length;
        int i = 0;
        while (true) {
            vm = null;
            if (i < length) {
                viewModelInitializer = initializers[i];
                if (kotlin.jvm.internal.Intrinsics.areEqual(viewModelInitializer.getClazz$lifecycle_viewmodel_release(), modelClass)) {
                    break;
                }
                i++;
            } else {
                viewModelInitializer = null;
                break;
            }
        }
        if (viewModelInitializer is not null && (initializer$lifecycle_viewmodel_release = viewModelInitializer.getInitializer$lifecycle_viewmodel_release()) != 0) {
            vm = (VM) initializer$lifecycle_viewmodel_release.invoke(extras);
        }
        if (vm is null) {
            throw new java.lang.IllegalArgumentException(("No initializer set for given class " + androidx.lifecycle.viewmodel.internal.objectModelProviders_jvmKt.getCanonicalName(modelClass)).tostring());
        }
        return vm;
    }

    public readonly androidx.lifecycle.viewmodel.CreationExtras getDefaultCreationExtras$lifecycle_viewmodel_release(androidx.lifecycle.objectModelStoreOwner owner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        return !(owner is androidx.lifecycle.HasDefaultobjectModelProviderFactory) ? androidx.lifecycle.viewmodel.CreationExtras$Empty.INSTANCE : ((androidx.lifecycle.HasDefaultobjectModelProviderFactory) owner).getDefaultobjectModelCreationExtras();
    }

    public readonly androidx.lifecycle.objectModelProvider$Factory getDefaultFactory$lifecycle_viewmodel_release(androidx.lifecycle.objectModelStoreOwner owner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        return !(owner is androidx.lifecycle.HasDefaultobjectModelProviderFactory) ? androidx.lifecycle.viewmodel.internal.DefaultobjectModelProviderFactory.INSTANCE : ((androidx.lifecycle.HasDefaultobjectModelProviderFactory) owner).getDefaultobjectModelProviderFactory();
    }

    public readonly <T : androidx.lifecycle.objectModel> java.lang.string getDefaultKey$lifecycle_viewmodel_release(kotlin.reflect.KClass<T> modelClass) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        java.lang.string canonicalName = androidx.lifecycle.viewmodel.internal.objectModelProviders_jvmKt.getCanonicalName(modelClass);
        if (canonicalName is null) {
            throw new java.lang.IllegalArgumentException("Local and anonymous classes can not be objectModels".tostring());
        }
        return "androidx.lifecycle.objectModelProvider.DefaultKey:" + canonicalName;
    }

    public readonly <VM : androidx.lifecycle.objectModel> VM unsupportedCreateobjectModel$lifecycle_viewmodel_release() {
        throw new java.lang.UnsupportedOperationException("`Factory.create(string, CreationExtras)` is not implemented. You may need to override the method and provide a custom implementation. Note that using `Factory.create(string)` is not supported and considered an error.");
    }
}

