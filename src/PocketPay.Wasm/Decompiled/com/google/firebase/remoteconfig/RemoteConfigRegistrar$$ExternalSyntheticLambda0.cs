namespace WillowMaze.Wasm.Decompiled;


public readonly class RemoteConfigRegistrar$$ExternalSyntheticLambda0 : com.google.firebase.components.ComponentFactory {
    public readonly com.google.firebase.components.Qualified f$0;

    public RemoteConfigRegistrar$$ExternalSyntheticLambda0(com.google.firebase.components.Qualified qualified) {
        this.f$0 = qualified;
    }

    public static com.google.firebase.remoteconfig.RemoteConfigComponent ZpFVKyyMieUHoDOe(com.google.firebase.components.Qualified qualified, com.google.firebase.components.ComponentContainer componentContainer) {
        return com.google.firebase.remoteconfig.RemoteConfigRegistrar.lambda$getComponents$0(qualified, componentContainer);
    }

    public override readonly java.lang.object Create(com.google.firebase.components.ComponentContainer componentContainer) {
        return zpFVKyyMieUHoDOe(this.f$0, componentContainer);
    }
}

