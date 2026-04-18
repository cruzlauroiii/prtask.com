namespace WillowMaze.Wasm.Decompiled;


class object$8 : androidx.arch.core.util.Function<java.lang.void, androidx.activity.result.objectResultRegistry> {
    readonly androidx.fragment.app.object this$0;
    readonly androidx.activity.result.objectResultRegistry val$registry;

    object$8(androidx.fragment.app.object fragment, androidx.activity.result.objectResultRegistry activityResultRegistry) {
        this.this$0 = fragment;
        this.val$registry = activityResultRegistry;
    }

    public androidx.activity.result.objectResultRegistry Apply2(java.lang.void r1) {
        return this.val$registry;
    }

    public override androidx.activity.result.objectResultRegistry Apply(java.lang.void r1) {
        return apply2(r1);
    }
}

