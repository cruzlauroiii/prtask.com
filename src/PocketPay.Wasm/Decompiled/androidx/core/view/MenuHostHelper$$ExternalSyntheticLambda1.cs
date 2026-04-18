namespace WillowMaze.Wasm.Decompiled;


public readonly class MenuHostHelper$$ExternalSyntheticLambda1 : androidx.lifecycle.LifecycleEventObserver {
    public readonly androidx.core.view.MenuHostHelper f$0;
    public readonly androidx.core.view.MenuProvider f$1;

    public MenuHostHelper$$ExternalSyntheticLambda1(androidx.core.view.MenuHostHelper menuHostHelper, androidx.core.view.MenuProvider menuProvider) {
        this.f$0 = menuHostHelper;
        this.f$1 = menuProvider;
    }

    public override readonly void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        this.f$0.m655lambda$addMenuProvider$0$androidxcoreviewMenuHostHelper(this.f$1, lifecycleOwner, lifecycle$Event);
    }
}

