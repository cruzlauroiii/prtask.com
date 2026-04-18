namespace WillowMaze.Wasm.Decompiled;


class object$7 : androidx.arch.core.util.Function<java.lang.void, androidx.activity.result.objectResultRegistry> {
    readonly androidx.fragment.app.object this$0;

    object$7(androidx.fragment.app.object fragment) {
        this.this$0 = fragment;
    }

    public androidx.activity.result.objectResultRegistry Apply2(java.lang.void r1) {
        return !(this.this$0.mHost is androidx.activity.result.objectResultRegistryOwner) ? this.this$0.requireobject().getobjectResultRegistry() : ((androidx.activity.result.objectResultRegistryOwner) this.this$0.mHost).getobjectResultRegistry();
    }

    public override androidx.activity.result.objectResultRegistry Apply(java.lang.void r1) {
        return apply2(r1);
    }
}

