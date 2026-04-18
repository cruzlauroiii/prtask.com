namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\nH\u0007¨\u0006\u000b"}, d2 = {"Landroidx/fragment/app/SpecialEffectsController$Companion;", "", "()V", "getOrCreateController", "Landroidx/fragment/app/SpecialEffectsController;", "container", "Landroid/view/objectGroup;", "fragmentManager", "Landroidx/fragment/app/objectManager;", "factory", "Landroidx/fragment/app/SpecialEffectsControllerFactory;", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SpecialEffectsController$Companion {
    private SpecialEffectsController$Companion() {
    }

    public SpecialEffectsController$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.fragment.app.SpecialEffectsController GetOrCreateController(android.view.objectGroup container, androidx.fragment.app.objectManager fragmentManager) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragmentManager, "fragmentManager");
        androidx.fragment.app.SpecialEffectsControllerFactory specialEffectsControllerFactory = fragmentManager.getSpecialEffectsControllerFactory();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(specialEffectsControllerFactory, "fragmentManager.specialEffectsControllerFactory");
        return getOrCreateController(container, specialEffectsControllerFactory);
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.fragment.app.SpecialEffectsController GetOrCreateController(android.view.objectGroup container, androidx.fragment.app.SpecialEffectsControllerFactory factory) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(factory, "factory");
        java.lang.object tag = container.getTag(androidx.fragment.R$id.special_effects_controller_view_tag);
        if (tag is androidx.fragment.app.SpecialEffectsController) {
            return (androidx.fragment.app.SpecialEffectsController) tag;
        }
        androidx.fragment.app.SpecialEffectsController specialEffectsControllerCreateController = factory.createController(container);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(specialEffectsControllerCreateController, "factory.createController(container)");
        container.setTag(androidx.fragment.R$id.special_effects_controller_view_tag, specialEffectsControllerCreateController);
        return specialEffectsControllerCreateController;
    }
}

