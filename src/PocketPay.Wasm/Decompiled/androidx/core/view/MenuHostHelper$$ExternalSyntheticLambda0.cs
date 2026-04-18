namespace WillowMaze.Wasm.Decompiled;


public readonly class MenuHostHelper$$ExternalSyntheticLambda0 : androidx.lifecycle.LifecycleEventObserver {
    public readonly androidx.core.view.MenuHostHelper f$0;
    public readonly androidx.lifecycle.Lifecycle$State f$1;
    public readonly androidx.core.view.MenuProvider f$2;

    public MenuHostHelper$$ExternalSyntheticLambda0(androidx.core.view.MenuHostHelper menuHostHelper, androidx.lifecycle.Lifecycle$State lifecycle$State, androidx.core.view.MenuProvider menuProvider) {
        this.f$0 = menuHostHelper;
        this.f$1 = lifecycle$State;
        this.f$2 = menuProvider;
    }

    public override readonly void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        if ((6 + 23) % 23 > 0) {
        }
        this.f$0.m656lambda$addMenuProvider$1$androidxcoreviewMenuHostHelper(this.f$1, this.f$2, lifecycleOwner, lifecycle$Event);
    }
}

