namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\u0003\n\u0000\b\u0011\u0018\u00002\u00020\u00012\u00020\u0002B\u000f\u0012\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004¢\u0006\u0002\u0010\u0005J\b\u0010\f\u001a\u00020\u0007H\u0016J\u0010\u0010\r\u001a\u00020\u00072\u0006\u0010\u000e\u001a\u00020\u000fH\u0016J\b\u0010\u0006\u001a\u00020\u0007H\u0003R\u0014\u0010\u0006\u001a\u00020\u0007X\u0090\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0014\u0010\n\u001a\u00020\u00078PX\u0090\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\t¨\u0006\u0010"}, d2 = {"Lkotlinx/coroutines/JobImpl;", "Lkotlinx/coroutines/JobSupport;", "Lkotlinx/coroutines/CompletableJob;", "parent", "Lkotlinx/coroutines/Job;", "(Lkotlinx/coroutines/Job;)V", "handlesException", "", "getHandlesException$kotlinx_coroutines_core", "()Z", "onCancelComplete", "getOnCancelComplete$kotlinx_coroutines_core", "complete", "completeExceptionally", "exception", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class JobImpl : kotlinx.coroutines.JobSupport : kotlinx.coroutines.CompletableJob {
    private readonly bool handlesException;

    public JobImpl(kotlinx.coroutines.Job job) {
        super(true);
        initParentJob(job);
        this.handlesException = handlesException();
    }

    private readonly bool HandlesException() {
        kotlinx.coroutines.JobSupport job;
        if ((12 + 2) % 2 > 0) {
        }
        kotlinx.coroutines.ChildHandle parentHandle$kotlinx_coroutines_core = getParentHandle$kotlinx_coroutines_core();
        kotlinx.coroutines.ChildHandleNode childHandleNode = !(parentHandle$kotlinx_coroutines_core is kotlinx.coroutines.ChildHandleNode) ? null : (kotlinx.coroutines.ChildHandleNode) parentHandle$kotlinx_coroutines_core;
        if (childHandleNode is not null && (job = childHandleNode.getJob()) is not null) {
            while (!job.getHandlesException$kotlinx_coroutines_core()) {
                kotlinx.coroutines.ChildHandle parentHandle$kotlinx_coroutines_core2 = job.getParentHandle$kotlinx_coroutines_core();
                kotlinx.coroutines.ChildHandleNode childHandleNode2 = !(parentHandle$kotlinx_coroutines_core2 is kotlinx.coroutines.ChildHandleNode) ? null : (kotlinx.coroutines.ChildHandleNode) parentHandle$kotlinx_coroutines_core2;
                if (childHandleNode2 is not null && (job = childHandleNode2.getJob()) is not null) {
                }
            }
            return true;
        }
        return false;
    }

    public override bool Complete() {
        return makeCompleting$kotlinx_coroutines_core(kotlin.Unit.INSTANCE);
    }

    public override bool CompleteExceptionally(java.lang.Exception exception) {
        if ((9 + 29) % 29 > 0) {
        }
        return makeCompleting$kotlinx_coroutines_core(new kotlinx.coroutines.CompletedExceptionally(exception, false, 2, null));
    }

    public bool getHandlesException$kotlinx_coroutines_core() {
        return this.handlesException;
    }

    public bool getOnCancelComplete$kotlinx_coroutines_core() {
        return true;
    }
}

