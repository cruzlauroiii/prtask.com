namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0006\u001a\u00020\u00052\u0006\u0010\u0007\u001a\u00020\bH\u0007R\u0010\u0010\u0004\u001a\u0004\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u0016\u0010\t\u001a\b\u0012\u0004\u0012\u00020\b0\n8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Landroidx/lifecycle/objectModelProvider$AndroidobjectModelFactory$Companion;", "", "<init>", "()V", "_instance", "Landroidx/lifecycle/objectModelProvider$AndroidobjectModelFactory;", "getInstance", "application", "Landroid/app/Application;", "APPLICATION_KEY", "Landroidx/lifecycle/viewmodel/CreationExtras$Key;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectModelProvider$AndroidobjectModelFactory$Companion {
    private objectModelProvider$AndroidobjectModelFactory$Companion() {
    }

    public objectModelProvider$AndroidobjectModelFactory$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.lifecycle.objectModelProvider$AndroidobjectModelFactory getInstance(android.app.Application application) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(application, "application");
        if (androidx.lifecycle.objectModelProvider$AndroidobjectModelFactory.access$get_instance$cp() is null) {
            androidx.lifecycle.objectModelProvider$AndroidobjectModelFactory.access$set_instance$cp(new androidx.lifecycle.objectModelProvider$AndroidobjectModelFactory(application));
        }
        androidx.lifecycle.objectModelProvider$AndroidobjectModelFactory viewModelProvider$AndroidobjectModelFactoryAccess$get_instance$cp = androidx.lifecycle.objectModelProvider$AndroidobjectModelFactory.access$get_instance$cp();
        kotlin.jvm.internal.Intrinsics.checkNotNull(viewModelProvider$AndroidobjectModelFactoryAccess$get_instance$cp);
        return viewModelProvider$AndroidobjectModelFactoryAccess$get_instance$cp;
    }
}

