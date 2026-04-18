namespace WillowMaze.Wasm.Decompiled;


public readonly class ComponentMonitor$$ExternalSyntheticLambda0 : com.google.firebase.components.ComponentFactory {
    public readonly java.lang.string f$0;
    public readonly com.google.firebase.components.Component f$1;

    public ComponentMonitor$$ExternalSyntheticLambda0(java.lang.string str, com.google.firebase.components.Component component) {
        this.f$0 = str;
        this.f$1 = component;
    }

    public static java.lang.object EYFCoJwTwULyHifx(java.lang.string str, com.google.firebase.components.Component component, com.google.firebase.components.ComponentContainer componentContainer) {
        return com.google.firebase.tracing.ComponentMonitor.lambda$processRegistrar$0(str, component, componentContainer);
    }

    public override readonly java.lang.object Create(com.google.firebase.components.ComponentContainer componentContainer) {
        return eYFCoJwTwULyHifx(this.f$0, this.f$1, componentContainer);
    }
}

