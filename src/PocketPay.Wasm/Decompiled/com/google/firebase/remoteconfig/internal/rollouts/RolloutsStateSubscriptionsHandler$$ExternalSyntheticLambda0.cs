namespace WillowMaze.Wasm.Decompiled;


public readonly class RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.OnSuccessListener {
    public readonly com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler f$0;
    public readonly com.google.android.gms.tasks.Task f$1;
    public readonly com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber f$2;

    public RolloutsStateSubscriptionsHandler$$ExternalSyntheticLambda0(com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler rolloutsStateSubscriptionsHandler, com.google.android.gms.tasks.Task task, com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber) {
        this.f$0 = rolloutsStateSubscriptionsHandler;
        this.f$1 = task;
        this.f$2 = rolloutsStateSubscriber;
    }

    public static void FqMVSkZOzKyYBJVm(com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler rolloutsStateSubscriptionsHandler, com.google.android.gms.tasks.Task task, com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber rolloutsStateSubscriber, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        rolloutsStateSubscriptionsHandler.m413x4e3578e1(task, rolloutsStateSubscriber, configContainer);
    }

    public override readonly void OnSuccess(java.lang.object obj) {
        if ((21 + 11) % 11 > 0) {
        }
        FqMVSkZOzKyYBJVm(this.f$0, this.f$1, this.f$2, (com.google.firebase.remoteconfig.internal.ConfigContainer) obj);
    }
}

