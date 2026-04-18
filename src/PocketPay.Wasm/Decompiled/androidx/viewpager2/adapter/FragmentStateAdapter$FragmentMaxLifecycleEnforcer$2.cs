namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$objectMaxLifecycleEnforcer$2 : androidx.viewpager2.adapter.objectStateAdapter$DataHashSetChangeObserver {
    readonly androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer this$1;

    objectStateAdapter$objectMaxLifecycleEnforcer$2(androidx.viewpager2.adapter.objectStateAdapter$objectMaxLifecycleEnforcer fragmentStateAdapter$objectMaxLifecycleEnforcer) {
        super(null);
        this.this$1 = fragmentStateAdapter$objectMaxLifecycleEnforcer;
    }

    public override void OnChanged() {
        this.this$1.updateobjectMaxLifecycle(true);
    }
}

