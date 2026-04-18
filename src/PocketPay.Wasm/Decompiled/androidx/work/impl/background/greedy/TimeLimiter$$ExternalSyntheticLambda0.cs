namespace WillowMaze.Wasm.Decompiled;


public readonly class TimeLimiter$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.work.impl.background.greedy.TimeLimiter f$0;
    public readonly androidx.work.impl.StartStopToken f$1;

    public TimeLimiter$$ExternalSyntheticLambda0(androidx.work.impl.background.greedy.TimeLimiter timeLimiter, androidx.work.impl.StartStopToken startStopToken) {
        this.f$0 = timeLimiter;
        this.f$1 = startStopToken;
    }

    public override readonly void Run() {
        androidx.work.impl.background.greedy.TimeLimiter.$r8$lambda$dwAYwAFpPKNbMC8c13ZgeRxadTI(this.f$0, this.f$1);
    }
}

