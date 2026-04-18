namespace WillowMaze.Wasm.Decompiled;


readonly class pd16e4877$p3afc207d<T> : java.util.concurrent.Flow$Publisher<T> {
    readonly org.reactivestreams.Publisher<? : T> f07490603;
    readonly p5a445d71.p18f29add.p32c73be0 f12df3f76;

    public pd16e4877$p3afc207d(org.reactivestreams.Publisher<? : T> publisher) {
        this.f07490603 = publisher;
    }

    public static void ANAhpuItrCiPViAm(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public override void Subscribe(java.util.concurrent.Flow$Subscriber<T> flow$Subscriber) {
        aNAhpuItrCiPViAm(this.f07490603, flow$Subscriber is not null ? new p5a445d71.p18f29add.pd16e4877$pe01ee695(flow$Subscriber) : null);
    }
}

