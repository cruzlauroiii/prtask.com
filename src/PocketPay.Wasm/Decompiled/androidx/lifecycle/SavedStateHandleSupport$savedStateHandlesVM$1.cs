namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J-\u0010\u0002\u001a\u0002H\u0003\"\b\b\u0000\u0010\u0003*\u00020\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00030\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016¢\u0006\u0002\u0010\t¨\u0006\n"}, d2 = {"androidx/lifecycle/SavedStateHandleSupport$savedStateHandlesVM$1", "Landroidx/lifecycle/objectModelProvider$Factory;", "create", "T", "Landroidx/lifecycle/objectModel;", "modelClass", "Lkotlin/reflect/KClass;", "extras", "Landroidx/lifecycle/viewmodel/CreationExtras;", "(Lkotlin/reflect/KClass;Landroidx/lifecycle/viewmodel/CreationExtras;)Landroidx/lifecycle/objectModel;", "lifecycle-viewmodel-savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateHandleSupport$savedStateHandlesVM$1 : androidx.lifecycle.objectModelProvider$Factory {
    SavedStateHandleSupport$savedStateHandlesVM$1() {
    }

    public <T : androidx.lifecycle.objectModel> T create(kotlin.reflect.KClass<T> modelClass, androidx.lifecycle.viewmodel.CreationExtras extras) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extras, "extras");
        return new androidx.lifecycle.SavedStateHandlesVM();
    }
}

