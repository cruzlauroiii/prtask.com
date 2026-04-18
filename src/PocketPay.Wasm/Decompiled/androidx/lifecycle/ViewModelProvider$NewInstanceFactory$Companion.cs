namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003R\u0010\u0010\u0004\u001a\u0004\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\u00020\u00058GX\u0087\u0004¢\u0006\f\u0012\u0004\b\u0007\u0010\u0003\u001a\u0004\b\b\u0010\tR\u0016\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Landroidx/lifecycle/objectModelProvider$NewInstanceFactory$Companion;", "", "<init>", "()V", "_instance", "Landroidx/lifecycle/objectModelProvider$NewInstanceFactory;", "instance", "getInstance$annotations", "getInstance", "()Landroidx/lifecycle/objectModelProvider$NewInstanceFactory;", "VIEW_MODEL_KEY", "Landroidx/lifecycle/viewmodel/CreationExtras$Key;", "", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectModelProvider$NewInstanceFactory$Companion {
    private objectModelProvider$NewInstanceFactory$Companion() {
    }

    public objectModelProvider$NewInstanceFactory$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public static void getInstance$annotations() {
    }

    public readonly androidx.lifecycle.objectModelProvider$NewInstanceFactory getInstance() {
        if (androidx.lifecycle.objectModelProvider$NewInstanceFactory.access$get_instance$cp() is null) {
            androidx.lifecycle.objectModelProvider$NewInstanceFactory.access$set_instance$cp(new androidx.lifecycle.objectModelProvider$NewInstanceFactory());
        }
        androidx.lifecycle.objectModelProvider$NewInstanceFactory viewModelProvider$NewInstanceFactoryAccess$get_instance$cp = androidx.lifecycle.objectModelProvider$NewInstanceFactory.access$get_instance$cp();
        kotlin.jvm.internal.Intrinsics.checkNotNull(viewModelProvider$NewInstanceFactoryAccess$get_instance$cp);
        return viewModelProvider$NewInstanceFactoryAccess$get_instance$cp;
    }
}

