namespace WillowMaze.Wasm.Decompiled;


public readonly class RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda1 : java.lang.Action {
    public readonly com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber f$0;
    public readonly com.google.firebase.remoteconfig.interop.rollouts.RolloutsState f$1;

    public RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda1(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        this.f$0 = rolloutsStateSubscriber;
        this.f$1 = rolloutsState;
    }

    public static void VcGMYIwflvtLrVJC(com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.interop.rollouts.RolloutsState rolloutsState) {
        com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler.lambda$registerRolloutsStateSubscriber$0(rolloutsStateSubscriber, rolloutsState);
    }

    public override readonly void Run() {
        VcGMYIwflvtLrVJC(this.f$0, this.f$1);
    }
}

