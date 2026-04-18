namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessagingRegistrar$$ExternalSyntheticLambda0 : com.google.firebase.components.ComponentFactory {
    public readonly com.google.firebase.components.Qualified f$0;

    public FirebaseMessagingRegistrar$$ExternalSyntheticLambda0(com.google.firebase.components.Qualified qualified) {
        this.f$0 = qualified;
    }

    public static com.google.firebase.messaging.FirebaseMessaging BvzRsvitYOYZorKa(com.google.firebase.components.Qualified qualified, com.google.firebase.components.ComponentContainer componentContainer) {
        return com.google.firebase.messaging.FirebaseMessagingRegistrar.lambda$getComponents$0(qualified, componentContainer);
    }

    public override readonly java.lang.object Create(com.google.firebase.components.ComponentContainer componentContainer) {
        return BvzRsvitYOYZorKa(this.f$0, componentContainer);
    }
}

