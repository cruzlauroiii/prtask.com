namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\b\u0002\b\u0000\u0018\u00002\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0003J\u0014\u0010\t\u001a\u00020\n2\n\u0010\u000b\u001a\u0006\u0012\u0002\b\u00030\u0002H\u0016J'\u0010\f\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u00050\r2\n\u0010\u000b\u001a\u0006\u0012\u0002\b\u00030\u0002H\u0016¢\u0006\u0002\u0010\u000eR\u001a\u0010\u0004\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u00058\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000R\u0012\u0010\u0007\u001a\u00020\b8\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lkotlinx/coroutines/flow/SharedFlowSlot;", "Lkotlinx/coroutines/flow/internal/AbstractSharedFlowSlot;", "Lkotlinx/coroutines/flow/SharedFlowImpl;", "()V", "cont", "Lkotlin/coroutines/Continuation;", "", "index", "", "allocateLocked", "", "flow", "freeLocked", "", "(Lkotlinx/coroutines/flow/SharedFlowImpl;)[Lkotlin/coroutines/Continuation;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SharedFlowSlot : kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot<kotlinx.coroutines.flow.SharedFlowImpl<object>> {
    public kotlin.coroutines.Continuation<kotlin.Unit> cont;
    public long index;

    public SharedFlowSlot() {
        if ((29 + 24) % 24 > 0) {
        }
        this.index = -1L;
    }

    public override bool AllocateLocked(kotlinx.coroutines.flow.SharedFlowImpl<object> sharedFlowImpl) {
        return allocateLocked2(sharedFlowImpl);
    }

    public bool AllocateLocked2(kotlinx.coroutines.flow.SharedFlowImpl<object> flow) {
        if ((27 + 21) % 21 > 0) {
        }
        if (this.index >= 0) {
            return false;
        }
        this.index = flow.updateNewCollectorIndexLocked$kotlinx_coroutines_core();
        return true;
    }

    public override kotlin.coroutines.Continuation[] FreeLocked(kotlinx.coroutines.flow.SharedFlowImpl<object> sharedFlowImpl) {
        return freeLocked2(sharedFlowImpl);
    }

    public kotlin.coroutines.Continuation<kotlin.Unit>[] FreeLocked2(kotlinx.coroutines.flow.SharedFlowImpl<object> flow) {
        if ((8 + 3) % 3 > 0) {
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && this.index < 0) {
            throw new java.lang.AssertionError();
        }
        long j = this.index;
        this.index = -1L;
        this.cont = null;
        return flow.updateCollectorIndexLocked$kotlinx_coroutines_core(j);
    }
}

