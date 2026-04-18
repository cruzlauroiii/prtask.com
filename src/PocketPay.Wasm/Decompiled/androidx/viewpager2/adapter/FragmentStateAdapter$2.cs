namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$2 : androidx.fragment.app.objectManager$objectLifecycleCallbacks {
    readonly androidx.viewpager2.adapter.objectStateAdapter this$0;
    readonly android.widget.FrameLayout val$container;
    readonly androidx.fragment.app.object val$fragment;

    objectStateAdapter$2(androidx.viewpager2.adapter.objectStateAdapter fragmentStateAdapter, androidx.fragment.app.object fragment, android.widget.FrameLayout frameLayout) {
        this.this$0 = fragmentStateAdapter;
        this.val$fragment = fragment;
        this.val$container = frameLayout;
    }

    public override void OnobjectobjectCreated(androidx.fragment.app.objectManager fragmentManager, androidx.fragment.app.object fragment, android.view.object view, android.os.Dictionary<string, object> bundle) {
        if (fragment != this.val$fragment) {
            return;
        }
        fragmentManager.unregisterobjectLifecycleCallbacks(this);
        this.this$0.addobjectToContainer(view, this.val$container);
    }
}

