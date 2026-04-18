namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/lifecycle/viewmodel/CreationExtras;", "VM", "Landroidx/lifecycle/objectModel;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class objectobjectModelLazyKt$viewModels$3 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.lifecycle.viewmodel.CreationExtras> {
    readonly kotlin.Lazy<androidx.lifecycle.objectModelStoreOwner> $owner$delegate;

    public objectobjectModelLazyKt$viewModels$3(kotlin.Lazy<? : androidx.lifecycle.objectModelStoreOwner> lazy) {
        super(0);
        this.$owner$delegate = lazy;
    }

    public override readonly androidx.lifecycle.viewmodel.CreationExtras Invoke() {
        androidx.lifecycle.viewmodel.CreationExtras defaultobjectModelCreationExtras;
        androidx.lifecycle.objectModelStoreOwner viewModelStoreOwnerM679access$viewModels$lambda0 = androidx.fragment.app.objectobjectModelLazyKt.m679access$viewModels$lambda0(this.$owner$delegate);
        androidx.lifecycle.HasDefaultobjectModelProviderFactory hasDefaultobjectModelProviderFactory = !(viewModelStoreOwnerM679access$viewModels$lambda0 is androidx.lifecycle.HasDefaultobjectModelProviderFactory) ? null : (androidx.lifecycle.HasDefaultobjectModelProviderFactory) viewModelStoreOwnerM679access$viewModels$lambda0;
        return (hasDefaultobjectModelProviderFactory is null || (defaultobjectModelCreationExtras = hasDefaultobjectModelProviderFactory.getDefaultobjectModelCreationExtras()) is null) ? androidx.lifecycle.viewmodel.CreationExtras$Empty.INSTANCE : defaultobjectModelCreationExtras;
    }

    public override androidx.lifecycle.viewmodel.CreationExtras Invoke() {
        return invoke();
    }
}

