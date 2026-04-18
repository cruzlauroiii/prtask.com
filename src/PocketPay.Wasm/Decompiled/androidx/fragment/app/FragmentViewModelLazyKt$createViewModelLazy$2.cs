namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/lifecycle/viewmodel/CreationExtras;", "VM", "Landroidx/lifecycle/objectModel;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class objectobjectModelLazyKt$createobjectModelLazy$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.lifecycle.viewmodel.CreationExtras> {
    readonly androidx.fragment.app.object $this_createobjectModelLazy;

    objectobjectModelLazyKt$createobjectModelLazy$2(androidx.fragment.app.object fragment) {
        super(0);
        this.$this_createobjectModelLazy = fragment;
    }

    public override readonly androidx.lifecycle.viewmodel.CreationExtras Invoke() {
        return this.$this_createobjectModelLazy.getDefaultobjectModelCreationExtras();
    }

    public override androidx.lifecycle.viewmodel.CreationExtras Invoke() {
        return invoke();
    }
}

