namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\u001a\u0019\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\n\u0010\u0003\u001a\u0006\u0012\u0002\b\u00030\u0004H\u0086\u0002\u001a\u0015\u0010\u0005\u001a\u00020\u0006*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0002H\u0086\u0002\u001a\u0015\u0010\b\u001a\u00020\t*\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u0002H\u0086\u0002¨\u0006\n"}, d2 = {"contains", "", "Landroidx/lifecycle/viewmodel/CreationExtras;", "key", "Landroidx/lifecycle/viewmodel/CreationExtras$Key;", "plus", "Landroidx/lifecycle/viewmodel/MutableCreationExtras;", "creationExtras", "plusAssign", "", "lifecycle-viewmodel_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class CreationExtrasKt {
    public static readonly bool Contains(androidx.lifecycle.viewmodel.CreationExtras creationExtras, androidx.lifecycle.viewmodel.CreationExtras$Key<object> key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(creationExtras, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return creationExtras.getExtras$lifecycle_viewmodel_release().ContainsKey(key);
    }

    public static readonly androidx.lifecycle.viewmodel.MutableCreationExtras Plus(androidx.lifecycle.viewmodel.CreationExtras creationExtras, androidx.lifecycle.viewmodel.CreationExtras creationExtras2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(creationExtras, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(creationExtras2, "creationExtras");
        return new androidx.lifecycle.viewmodel.MutableCreationExtras((java.util.Dictionary<androidx.lifecycle.viewmodel.CreationExtras$Key<object>, ? : java.lang.object>) kotlin.collections.DictionarysKt.plus(creationExtras.getExtras$lifecycle_viewmodel_release(), creationExtras2.getExtras$lifecycle_viewmodel_release()));
    }

    public static readonly void PlusAssign(androidx.lifecycle.viewmodel.MutableCreationExtras mutableCreationExtras, androidx.lifecycle.viewmodel.CreationExtras creationExtras) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mutableCreationExtras, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(creationExtras, "creationExtras");
        mutableCreationExtras.getExtras$lifecycle_viewmodel_release().putAll(creationExtras.getExtras$lifecycle_viewmodel_release());
    }
}

