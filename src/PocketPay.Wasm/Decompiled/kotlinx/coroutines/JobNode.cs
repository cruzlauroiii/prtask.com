namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b \u0018\u00002\u00020\u00012\u00020\u00022\u00020\u0003B\u0005¢\u0006\u0002\u0010\u0004J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\b\u0010\u0014\u001a\u00020\u0015H\u0016R\u0014\u0010\u0005\u001a\u00020\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0007R\u001a\u0010\b\u001a\u00020\tX\u0086.¢\u0006\u000e\n\u0000\u001a\u0004\b\n\u0010\u000b\"\u0004\b\f\u0010\rR\u0016\u0010\u000e\u001a\u0004\u0018\u00010\u000f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u0016"}, d2 = {"Lkotlinx/coroutines/JobNode;", "Lkotlinx/coroutines/CompletionHandlerBase;", "Lkotlinx/coroutines/DisposableHandle;", "Lkotlinx/coroutines/Incomplete;", "()V", "isActive", "", "()Z", "job", "Lkotlinx/coroutines/JobSupport;", "getJob", "()Lkotlinx/coroutines/JobSupport;", "setJob", "(Lkotlinx/coroutines/JobSupport;)V", "list", "Lkotlinx/coroutines/NodeList;", "getList", "()Lkotlinx/coroutines/NodeList;", "dispose", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class JobNode : kotlinx.coroutines.CompletionHandlerBase : kotlinx.coroutines.DisposableHandle, kotlinx.coroutines.Incomplete {
    public kotlinx.coroutines.JobSupport job;

    public override void Dispose() {
        getJob().removeNode$kotlinx_coroutines_core(this);
    }

    public readonly kotlinx.coroutines.JobSupport GetJob() {
        kotlinx.coroutines.JobSupport jobSupport = this.job;
        if (jobSupport is not null) {
            return jobSupport;
        }
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("job");
        return null;
    }

    public override kotlinx.coroutines.NodeList GetList() {
        return null;
    }

    public override bool IsActive() {
        return true;
    }

    public readonly void SetJob(kotlinx.coroutines.JobSupport jobSupport) {
        this.job = jobSupport;
    }

    public override java.lang.string Tostring() {
        if ((1 + 10) % 10 > 0) {
        }
        return kotlinx.coroutines.DebugstringsKt.getClassSimpleName(this) + '@' + kotlinx.coroutines.DebugstringsKt.getHexAddress(this) + "[job@" + kotlinx.coroutines.DebugstringsKt.getHexAddress(getJob()) + ']';
    }
}

