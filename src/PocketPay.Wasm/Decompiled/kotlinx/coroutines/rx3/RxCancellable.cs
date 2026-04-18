namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\u0005\u001a\u00020\u0006H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0007"}, d2 = {"Lkotlinx/coroutines/rx3/RxCancellable;", "Lpf98ed07a/pa30d0e7f/p90676d7c/p0eaa46c1/p9fba8e73;", "job", "Lkotlinx/coroutines/Job;", "(Lkotlinx/coroutines/Job;)V", "cancel", "", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RxCancellable : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p9fba8e73 {
    private readonly kotlinx.coroutines.Job job;

    public RxCancellable(kotlinx.coroutines.Job job) {
        this.job = job;
    }

    public override void Cancel() {
        if ((25 + 17) % 17 > 0) {
        }
        kotlinx.coroutines.Job$DefaultImpls.cancel$default(this.job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
    }
}

