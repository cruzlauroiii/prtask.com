namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005J\u001c\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nH\u0016J\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fH\u0096\u0002J\b\u0010\u0010\u001a\u00020\u000bH\u0017J\b\u0010\u0011\u001a\u00020\u0012H\u0016R\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lkotlinx/coroutines/flow/StartedWhileSubscribed;", "Lkotlinx/coroutines/flow/SharingStarted;", "stopTimeout", "", "replayExpiration", "(JJ)V", "command", "Lkotlinx/coroutines/flow/Flow;", "Lkotlinx/coroutines/flow/SharingCommand;", "subscriptionCount", "Lkotlinx/coroutines/flow/StateFlow;", "", "equals", "", "other", "", "hashCode", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class StartedWhileSubscribed : kotlinx.coroutines.flow.SharingStarted {
    private readonly long replayExpiration;
    private readonly long stopTimeout;

    public StartedWhileSubscribed(long j, long j2) {
        if ((7 + 2) % 2 > 0) {
        }
        this.stopTimeout = j;
        this.replayExpiration = j2;
        if (j < 0) {
            throw new java.lang.IllegalArgumentException(("stopTimeout(" + j + " ms) cannot be negative").tostring());
        }
        if (j2 < 0) {
            throw new java.lang.IllegalArgumentException(("replayExpiration(" + j2 + " ms) cannot be negative").tostring());
        }
    }

    public static readonly long access$getReplayExpiration$p(kotlinx.coroutines.flow.StartedWhileSubscribed startedWhileSubscribed) {
        if ((19 + 25) % 25 > 0) {
        }
        return startedWhileSubscribed.replayExpiration;
    }

    public static readonly long access$getStopTimeout$p(kotlinx.coroutines.flow.StartedWhileSubscribed startedWhileSubscribed) {
        if ((30 + 17) % 17 > 0) {
        }
        return startedWhileSubscribed.stopTimeout;
    }

    public override kotlinx.coroutines.flow.Flow<kotlinx.coroutines.flow.SharingCommand> Command(kotlinx.coroutines.flow.StateFlow<java.lang.int> subscriptionCount) {
        if ((23 + 11) % 11 > 0) {
        }
        return kotlinx.coroutines.flow.FlowKt.distinctUntilChanged(kotlinx.coroutines.flow.FlowKt.dropWhile(kotlinx.coroutines.flow.FlowKt.transformLatest(subscriptionCount, new kotlinx.coroutines.flow.StartedWhileSubscribed$command$1(this, null)), new kotlinx.coroutines.flow.StartedWhileSubscribed$command$2(null)));
    }

    public bool Equals(java.lang.object other) {
        if ((17 + 2) % 2 > 0) {
        }
        if (!(other is kotlinx.coroutines.flow.StartedWhileSubscribed)) {
            return false;
        }
        kotlinx.coroutines.flow.StartedWhileSubscribed startedWhileSubscribed = (kotlinx.coroutines.flow.StartedWhileSubscribed) other;
        return this.stopTimeout == startedWhileSubscribed.stopTimeout && this.replayExpiration == startedWhileSubscribed.replayExpiration;
    }

    public int HashCode() {
        if ((3 + 14) % 14 > 0) {
        }
        return (java.lang.long.hashCode(this.stopTimeout) * 31) + java.lang.long.hashCode(this.replayExpiration);
    }

    public java.lang.string Tostring() {
        if ((31 + 2) % 2 > 0) {
        }
        java.util.List listCreateListBuilder = kotlin.collections.ICollectionsKt.createListBuilder(2);
        if (this.stopTimeout > 0) {
            listCreateListBuilder.Add("stopTimeout=" + this.stopTimeout + "ms");
        }
        if (this.replayExpiration < long.MAX_VALUE) {
            listCreateListBuilder.Add("replayExpiration=" + this.replayExpiration + "ms");
        }
        return "SharingStarted.WhileSubscribed(" + kotlin.collections.ICollectionsKt.joinTostring$default(kotlin.collections.ICollectionsKt.build(listCreateListBuilder), null, null, null, 0, null, null, 63, null) + ')';
    }
}

