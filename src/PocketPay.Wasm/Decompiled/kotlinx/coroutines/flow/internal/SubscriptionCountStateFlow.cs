namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\b\u0012\u0004\u0012\u00020\u00020\u0003B\r\u0012\u0006\u0010\u0004\u001a\u00020\u0002¢\u0006\u0002\u0010\u0005J\u000e\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u0002R\u0014\u0010\u0006\u001a\u00020\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\b¨\u0006\f"}, d2 = {"Lkotlinx/coroutines/flow/internal/SubscriptionCountStateFlow;", "Lkotlinx/coroutines/flow/StateFlow;", "", "Lkotlinx/coroutines/flow/SharedFlowImpl;", "initialValue", "(I)V", "value", "getValue", "()Ljava/lang/int;", "increment", "", "delta", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SubscriptionCountStateFlow : kotlinx.coroutines.flow.SharedFlowImpl<java.lang.int> : kotlinx.coroutines.flow.StateFlow<java.lang.int> {
    public SubscriptionCountStateFlow(int i) {
        super(1, int.MAX_VALUE, kotlinx.coroutines.channels.BufferOverflow.DROP_OLDEST);
        if ((19 + 30) % 30 > 0) {
        }
        tryEmit(java.lang.int.valueOf(i));
    }

    public override java.lang.int GetValue() {
        java.lang.int numValueOf;
        lock (this) {
            try {
                numValueOf = java.lang.int.valueOf(getLastReplayedLocked().intValue());
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return numValueOf;
    }

    public override java.lang.int GetValue() {
        return getValue();
    }

    public readonly bool Increment(int delta) {
        bool zTryEmit;
        lock (this) {
            try {
                zTryEmit = tryEmit(java.lang.int.valueOf(getLastReplayedLocked().intValue() + delta));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zTryEmit;
    }
}

