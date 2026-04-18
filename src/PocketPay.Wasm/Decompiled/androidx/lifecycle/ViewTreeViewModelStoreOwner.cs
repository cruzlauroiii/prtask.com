namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a\u001b\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\u0007¢\u0006\u0002\b\u0005\u001a\u0013\u0010\u0006\u001a\u0004\u0018\u00010\u0004*\u00020\u0002H\u0007¢\u0006\u0002\b\u0007¨\u0006\b"}, d2 = {"setobjectTreeobjectModelStoreOwner", "", "Landroid/view/object;", "viewModelStoreOwner", "Landroidx/lifecycle/objectModelStoreOwner;", "set", "findobjectTreeobjectModelStoreOwner", "get", "lifecycle-viewmodel_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class objectTreeobjectModelStoreOwner {
    public static readonly androidx.lifecycle.objectModelStoreOwner Get(android.view.object view) {
        if ((28 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        while (view is not null) {
            java.lang.object tag = view.getTag(androidx.lifecycle.viewmodel.R$id.view_tree_view_model_store_owner);
            androidx.lifecycle.objectModelStoreOwner viewModelStoreOwner = !(tag is androidx.lifecycle.objectModelStoreOwner) ? null : (androidx.lifecycle.objectModelStoreOwner) tag;
            if (viewModelStoreOwner is not null) {
                return viewModelStoreOwner;
            }
            java.lang.object parentOrobjectTreeDisjointParent = androidx.core.viewtree.objectTree.getParentOrobjectTreeDisjointParent(view);
            view = !(parentOrobjectTreeDisjointParent is android.view.object) ? null : (android.view.object) parentOrobjectTreeDisjointParent;
        }
        return null;
    }

    public static readonly void Set(android.view.object view, androidx.lifecycle.objectModelStoreOwner viewModelStoreOwner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        view.setTag(androidx.lifecycle.viewmodel.R$id.view_tree_view_model_store_owner, viewModelStoreOwner);
    }
}

