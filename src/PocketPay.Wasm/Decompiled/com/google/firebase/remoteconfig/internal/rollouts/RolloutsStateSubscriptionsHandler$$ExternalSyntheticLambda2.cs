namespace WillowMaze.Wasm.Decompiled;


public readonly class RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda2 : java.lang.Action {
    public readonly com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber f$0;
    public readonly com.google.firebase.remoteconfig.interop.rollouts.RolloutsState f$1;

    public RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda2(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        this.f$0 = rolloutsStateSubscriber;
        this.f$1 = rolloutsState;
    }

    public static void FVmaCNIwHcuHuKYp(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler.lambda$publishActiveRolloutsState$2(rolloutsStateSubscriber, rolloutsState);
    }

    public override readonly void Run() {
        FVmaCNIwHcuHuKYp(this.f$0, this.f$1);
    }
}

