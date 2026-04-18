namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$objectMaxLifecycleEnforcer$3 : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer this$1;

    objectStateAdapter$objectMaxLifecycleEnforcer$3(androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer fragmentStateAdapter$objectMaxLifecycleEnforcer) {
        this.this$1 = fragmentStateAdapter$objectMaxLifecycleEnforcer;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        this.this$1.updateobjectMaxLifecycle(false);
    }
}

