namespace WillowMaze.Wasm.Decompiled;


public readonly class Subscriber$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.common.eventbus.Subscriber f$0;
    public readonly java.lang.object f$1;

    public Subscriber$$ExternalSyntheticLambda0(com.google.common.eventbus.Subscriber subscriber, java.lang.object obj) {
        this.f$0 = subscriber;
        this.f$1 = obj;
    }

    public override readonly void Run() {
        this.f$0.m872lambda$dispatchEvent$0$comgooglecommoneventbusSubscriber(this.f$1);
    }
}

