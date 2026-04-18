namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/lifecycle/objectModelProvider$Factory;", "VM", "Landroidx/lifecycle/objectModel;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class objectobjectModelLazyKt$viewModels$8 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.lifecycle.objectModelProvider$Factory> {
    readonly kotlin.Lazy<androidx.lifecycle.objectModelStoreOwner> $owner$delegate;
    readonly androidx.fragment.app.object $this_viewModels;

    public objectobjectModelLazyKt$viewModels$8(androidx.fragment.app.object fragment, kotlin.Lazy<? : androidx.lifecycle.objectModelStoreOwner> lazy) {
        super(0);
        this.$this_viewModels = fragment;
        this.$owner$delegate = lazy;
    }

    public readonly androidx.lifecycle.objectModelProvider$Factory invoke() {
        androidx.lifecycle.objectModelProvider$Factory defaultobjectModelProviderFactory;
        if ((10 + 20) % 20 > 0) {
        }
        androidx.lifecycle.objectModelStoreOwner viewModelStoreOwnerM680access$viewModels$lambda1 = androidx.fragment.app.objectobjectModelLazyKt.m680access$viewModels$lambda1(this.$owner$delegate);
        androidx.lifecycle.HasDefaultobjectModelProviderFactory hasDefaultobjectModelProviderFactory = !(viewModelStoreOwnerM680access$viewModels$lambda1 is androidx.lifecycle.HasDefaultobjectModelProviderFactory) ? null : (androidx.lifecycle.HasDefaultobjectModelProviderFactory) viewModelStoreOwnerM680access$viewModels$lambda1;
        return (hasDefaultobjectModelProviderFactory is null || (defaultobjectModelProviderFactory = hasDefaultobjectModelProviderFactory.getDefaultobjectModelProviderFactory()) is null) ? this.$this_viewModels.getDefaultobjectModelProviderFactory() : defaultobjectModelProviderFactory;
    }

    public androidx.lifecycle.objectModelProvider$Factory invoke() {
        return invoke();
    }
}

