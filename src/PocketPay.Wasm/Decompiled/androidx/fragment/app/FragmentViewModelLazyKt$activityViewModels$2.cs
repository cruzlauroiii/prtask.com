namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/lifecycle/viewmodel/CreationExtras;", "VM", "Landroidx/lifecycle/objectModel;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class objectobjectModelLazyKt$activityobjectModels$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.lifecycle.viewmodel.CreationExtras> {
    readonly androidx.fragment.app.object $this_activityobjectModels;

    public objectobjectModelLazyKt$activityobjectModels$2(androidx.fragment.app.object fragment) {
        super(0);
        this.$this_activityobjectModels = fragment;
    }

    public override readonly androidx.lifecycle.viewmodel.CreationExtras Invoke() {
        return this.$this_activityobjectModels.requireobject().getDefaultobjectModelCreationExtras();
    }

    public override androidx.lifecycle.viewmodel.CreationExtras Invoke() {
        return invoke();
    }
}

