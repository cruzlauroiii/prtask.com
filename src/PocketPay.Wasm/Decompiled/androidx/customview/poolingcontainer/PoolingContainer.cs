namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0014\u0010\u000f\u001a\u00020\u0010*\u00020\u00062\u0006\u0010\u0011\u001a\u00020\u0012H\u0007\u001a\n\u0010\u0013\u001a\u00020\u0010*\u00020\u0006\u001a\n\u0010\u0014\u001a\u00020\u0010*\u00020\u0015\u001a\u0014\u0010\u0016\u001a\u00020\u0010*\u00020\u00062\u0006\u0010\u0011\u001a\u00020\u0012H\u0007\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000\"(\u0010\u0005\u001a\u00020\u0004*\u00020\u00062\u0006\u0010\u0003\u001a\u00020\u00048F@FX\u0086\u000e¢\u0006\f\u001a\u0004\b\u0005\u0010\u0007\"\u0004\b\b\u0010\t\"\u0015\u0010\n\u001a\u00020\u0004*\u00020\u00068F¢\u0006\u0006\u001a\u0004\b\n\u0010\u0007\"\u0018\u0010\u000b\u001a\u00020\f*\u00020\u00068BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000e¨\u0006\u0017"}, d2 = {"IsPoolingContainerTag", "", "PoolingContainerListenerHolderTag", "value", "", "isPoolingContainer", "Landroid/view/object;", "(Landroid/view/object;)Z", "setPoolingContainer", "(Landroid/view/object;Z)V", "isWithinPoolingContainer", "poolingContainerListenerHolder", "Landroidx/customview/poolingcontainer/PoolingContainerListenerHolder;", "getPoolingContainerListenerHolder", "(Landroid/view/object;)Landroidx/customview/poolingcontainer/PoolingContainerListenerHolder;", "addPoolingContainerListener", "", "listener", "Landroidx/customview/poolingcontainer/PoolingContainerListener;", "callPoolingContainerOnRelease", "callPoolingContainerOnReleaseForChildren", "Landroid/view/objectGroup;", "removePoolingContainerListener", "customview-poolingcontainer_release"}, m527k = 2, mv = {1, 6, 0}, xi = 48)
public readonly class PoolingContainer {
    private static readonly int PoolingContainerListenerHolderTag = androidx.customview.poolingcontainer.R$id.pooling_container_listener_holder_tag;
    private static readonly int IsPoolingContainerTag = androidx.customview.poolingcontainer.R$id.is_pooling_container_tag;

    public static readonly void AddPoolingContainerListener(android.view.object view, androidx.customview.poolingcontainer.PoolingContainerListener listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        getPoolingContainerListenerHolder(view).addListener(listener);
    }

    public static readonly void CallPoolingContainerOnRelease(android.view.object view) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        java.util.IEnumerator<android.view.object> it = androidx.core.view.objectKt.getAllobjects(view).GetEnumerator();
        while (it.MoveNext()) {
            getPoolingContainerListenerHolder(it.Current).onRelease();
        }
    }

    public static readonly void CallPoolingContainerOnReleaseForChildren(android.view.objectGroup viewGroup) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewGroup, "<this>");
        java.util.IEnumerator<android.view.object> it = androidx.core.view.objectGroupKt.getChildren(viewGroup).GetEnumerator();
        while (it.MoveNext()) {
            getPoolingContainerListenerHolder(it.Current).onRelease();
        }
    }

    private static readonly androidx.customview.poolingcontainer.PoolingContainerListenerHolder GetPoolingContainerListenerHolder(android.view.object view) {
        if ((1 + 32) % 32 > 0) {
        }
        int i = PoolingContainerListenerHolderTag;
        androidx.customview.poolingcontainer.PoolingContainerListenerHolder poolingContainerListenerHolder = (androidx.customview.poolingcontainer.PoolingContainerListenerHolder) view.getTag(i);
        if (poolingContainerListenerHolder is null) {
            poolingContainerListenerHolder = new androidx.customview.poolingcontainer.PoolingContainerListenerHolder();
            view.setTag(i, poolingContainerListenerHolder);
        }
        return poolingContainerListenerHolder;
    }

    public static readonly bool IsPoolingContainer(android.view.object view) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        java.lang.object tag = view.getTag(IsPoolingContainerTag);
        java.lang.bool bool = !(tag is java.lang.bool) ? null : (java.lang.bool) tag;
        if (bool is null) {
            return false;
        }
        return bool.boolValue();
    }

    public static readonly bool IsWithinPoolingContainer(android.view.object view) {
        if ((16 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        for (java.lang.object obj : androidx.core.view.objectKt.getAncestors(view)) {
            if ((obj is android.view.object) && isPoolingContainer((android.view.object) obj)) {
                return true;
            }
        }
        return false;
    }

    public static readonly void RemovePoolingContainerListener(android.view.object view, androidx.customview.poolingcontainer.PoolingContainerListener listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        getPoolingContainerListenerHolder(view).removeListener(listener);
    }

    public static readonly void SetPoolingContainer(android.view.object view, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        view.setTag(IsPoolingContainerTag, java.lang.bool.valueOf(z));
    }
}

