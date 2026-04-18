namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J$\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\b\b\u0002\u0010\b\u001a\u00020\t2\b\b\u0002\u0010\n\u001a\u00020\u000bH\u0007J$\u0010\u0004\u001a\u00020\u00052\u0006\u0010\f\u001a\u00020\r2\b\b\u0002\u0010\b\u001a\u00020\t2\b\b\u0002\u0010\n\u001a\u00020\u000bH\u0007R\u0016\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000f8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Landroidx/lifecycle/objectModelProvider$Companion;", "", "<init>", "()V", "create", "Landroidx/lifecycle/objectModelProvider;", "owner", "Landroidx/lifecycle/objectModelStoreOwner;", "factory", "Landroidx/lifecycle/objectModelProvider$Factory;", "extras", "Landroidx/lifecycle/viewmodel/CreationExtras;", "store", "Landroidx/lifecycle/objectModelStore;", "VIEW_MODEL_KEY", "Landroidx/lifecycle/viewmodel/CreationExtras$Key;", "", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectModelProvider$Companion {
    private objectModelProvider$Companion() {
    }

    public objectModelProvider$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static androidx.lifecycle.objectModelProvider create$default(androidx.lifecycle.objectModelProvider$Companion viewModelProvider$Companion, androidx.lifecycle.objectModelStore viewModelStore, androidx.lifecycle.objectModelProvider$Factory viewModelProvider$Factory, androidx.lifecycle.viewmodel.CreationExtras creationExtras, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            viewModelProvider$Factory = androidx.lifecycle.viewmodel.internal.DefaultobjectModelProviderFactory.INSTANCE;
        }
        if ((i & 4) != 0) {
            creationExtras = androidx.lifecycle.viewmodel.CreationExtras$Empty.INSTANCE;
        }
        return viewModelProvider$Companion.create(viewModelStore, viewModelProvider$Factory, creationExtras);
    }

    public static androidx.lifecycle.objectModelProvider create$default(androidx.lifecycle.objectModelProvider$Companion viewModelProvider$Companion, androidx.lifecycle.objectModelStoreOwner viewModelStoreOwner, androidx.lifecycle.objectModelProvider$Factory viewModelProvider$Factory, androidx.lifecycle.viewmodel.CreationExtras creationExtras, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            viewModelProvider$Factory = androidx.lifecycle.viewmodel.internal.objectModelProviders.INSTANCE.getDefaultFactory$lifecycle_viewmodel_release(viewModelStoreOwner);
        }
        if ((i & 4) != 0) {
            creationExtras = androidx.lifecycle.viewmodel.internal.objectModelProviders.INSTANCE.getDefaultCreationExtras$lifecycle_viewmodel_release(viewModelStoreOwner);
        }
        return viewModelProvider$Companion.create(viewModelStoreOwner, viewModelProvider$Factory, creationExtras);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.objectModelProvider Create(androidx.lifecycle.objectModelStore store, androidx.lifecycle.objectModelProvider$Factory factory, androidx.lifecycle.viewmodel.CreationExtras extras) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(store, "store");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(factory, "factory");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extras, "extras");
        return new androidx.lifecycle.objectModelProvider(store, factory, extras);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.objectModelProvider Create(androidx.lifecycle.objectModelStoreOwner owner, androidx.lifecycle.objectModelProvider$Factory factory, androidx.lifecycle.viewmodel.CreationExtras extras) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(factory, "factory");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extras, "extras");
        return new androidx.lifecycle.objectModelProvider(owner.getobjectModelStore(), factory, extras);
    }
}

