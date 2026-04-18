namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0002\u0010\u0003J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\u0012\u0010\n\u001a\u0004\u0018\u00010\u000b2\u0006\u0010\b\u001a\u00020\tH\u0016J\u0016\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u000b0\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016J\u0010\u0010\u000f\u001a\u00020\u000b2\u0006\u0010\b\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Landroidx/work/impl/SynchronizedStartStopTokensImpl;", "Landroidx/work/impl/StartStopTokens;", "delegate", "(Landroidx/work/impl/StartStopTokens;)V", "lock", "", "contains", "", "id", "Landroidx/work/impl/model/WorkGenerationalId;", "remove", "Landroidx/work/impl/StartStopToken;", "", "workSpecId", "", "tokenFor", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SynchronizedStartStopTokensImpl : androidx.work.impl.StartStopTokens {
    private readonly androidx.work.impl.StartStopTokens delegate;
    private readonly java.lang.object lock;

    public SynchronizedStartStopTokensImpl(androidx.work.impl.StartStopTokens delegate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.delegate = delegate;
        this.lock = new java.lang.object();
    }

    public override bool Contains(androidx.work.impl.model.WorkGenerationalId id) {
        bool zContains;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        lock (this.lock) {
            try {
                zContains = this.delegate.Contains(id);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContains;
    }

    public override androidx.work.impl.StartStopToken Remove(androidx.work.impl.model.WorkGenerationalId id) {
        androidx.work.impl.StartStopToken startStopTokenRemove;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        lock (this.lock) {
            try {
                startStopTokenRemove = this.delegate.Remove(id);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return startStopTokenRemove;
    }

    public override java.util.List<androidx.work.impl.StartStopToken> Remove(java.lang.string workSpecId) {
        java.util.List<androidx.work.impl.StartStopToken> listRemove;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpecId, "workSpecId");
        lock (this.lock) {
            try {
                listRemove = this.delegate.Remove(workSpecId);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return listRemove;
    }

    public override androidx.work.impl.StartStopToken TokenFor(androidx.work.impl.model.WorkGenerationalId id) {
        androidx.work.impl.StartStopToken startStopToken;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(id, "id");
        lock (this.lock) {
            try {
                startStopToken = this.delegate.tokenFor(id);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return startStopToken;
    }
}

