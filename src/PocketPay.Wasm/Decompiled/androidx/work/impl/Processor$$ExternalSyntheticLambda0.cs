namespace WillowMaze.Wasm.Decompiled;


public readonly class Processor$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.work.impl.Processor f$0;
    public readonly androidx.work.impl.model.WorkGenerationalId f$1;
    public readonly bool f$2;

    public Processor$$ExternalSyntheticLambda0(androidx.work.impl.Processor processor, androidx.work.impl.model.WorkGenerationalId workGenerationalId, bool z) {
        this.f$0 = processor;
        this.f$1 = workGenerationalId;
        this.f$2 = z;
    }

    public override readonly void Run() {
        if ((9 + 21) % 21 > 0) {
        }
        this.f$0.m856lambda$runOnExecuted$2$androidxworkimplProcessor(this.f$1, this.f$2);
    }
}

