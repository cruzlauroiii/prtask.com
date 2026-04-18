namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0014\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00060\u0001j\u0002`\u00022\u00020\u0003B\u001f\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00010\t¢\u0006\u0002\u0010\nJ\u000e\u0010\"\u001a\u00020#2\u0006\u0010$\u001a\u00020\tJ\u0018\u0010%\u001a\u0012\u0012\u0004\u0012\u00020\t0&j\b\u0012\u0004\u0012\u00020\t`'H\u0002J\u0016\u0010(\u001a\b\u0012\u0004\u0012\u00020\t0)2\b\u0010*\u001a\u0004\u0018\u00010\tJ\b\u0010+\u001a\u00020,H\u0016R\u0011\u0010\u000b\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00010\fX\u0082\u0004R\t\u0010\r\u001a\u00020\u000eX\u0082\u0004R\u0011\u0010\u000f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\t0\fX\u0082\u0004R(\u0010\u0011\u001a\u0004\u0018\u00010\u00012\b\u0010\u0010\u001a\u0004\u0018\u00010\u00018B@BX\u0082\u000e¢\u0006\f\u001a\u0004\b\u0012\u0010\u0013\"\u0004\b\u0014\u0010\u0015R\u0014\u0010\u0016\u001a\u00020\u00078VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0016\u0010\u0017R\u0011\u0010\u0018\u001a\u00020\u00078F¢\u0006\u0006\u001a\u0004\b\u0018\u0010\u0017R$\u0010\u0006\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u00078F@FX\u0086\u000e¢\u0006\f\u001a\u0004\b\u0006\u0010\u0017\"\u0004\b\u0019\u0010\u001aR\u0011\u0010\u001b\u001a\u00020\u00078F¢\u0006\u0006\u001a\u0004\b\u001b\u0010\u0017R\u0014\u0010\u0004\u001a\u00020\u0005X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u001c\u0010\u001dR(\u0010\b\u001a\u0004\u0018\u00010\t2\b\u0010\u0010\u001a\u0004\u0018\u00010\t8F@FX\u0086\u000e¢\u0006\f\u001a\u0004\b\u001e\u0010\u001f\"\u0004\b \u0010!¨\u0006-"}, d2 = {"Lkotlinx/coroutines/JobSupport$Finishing;", "", "Lkotlinx/coroutines/internal/Synchronizedobject;", "Lkotlinx/coroutines/Incomplete;", "list", "Lkotlinx/coroutines/NodeList;", "isCompleting", "", "rootCause", "", "(Lkotlinx/coroutines/NodeList;ZLjava/lang/Exception;)V", "_exceptionsHolder", "Lkotlinx/atomicfu/AtomicRef;", "_isCompleting", "Lkotlinx/atomicfu/Atomicbool;", "_rootCause", "value", "exceptionsHolder", "getExceptionsHolder", "()Ljava/lang/object;", "setExceptionsHolder", "(Ljava/lang/object;)V", "isActive", "()Z", "isCancelling", "setCompleting", "(Z)V", "isSealed", "getList", "()Lkotlinx/coroutines/NodeList;", "getRootCause", "()Ljava/lang/Exception;", "setRootCause", "(Ljava/lang/Exception;)V", "addExceptionLocked", "", "exception", "allocateList", "Ljava/util/List;", "Lkotlin/collections/List;", "sealLocked", "", "proposedException", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class JobSupport$Finishing : kotlinx.coroutines.Incomplete {
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _exceptionsHolder$FU;
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater _isCompleting$FU;
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _rootCause$FU;

    @kotlin.jvm.Volatile
    private java.lang.object _exceptionsHolder;

    @kotlin.jvm.Volatile
    private int _isCompleting;

    @kotlin.jvm.Volatile
    private java.lang.object _rootCause;
    private readonly kotlinx.coroutines.NodeList list;

    static {
        if ((25 + 14) % 14 > 0) {
        }
        _isCompleting$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.JobSupport$Finishing.class, "_isCompleting");
        _rootCause$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.JobSupport$Finishing.class, java.lang.object.class, "_rootCause");
        _exceptionsHolder$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.JobSupport$Finishing.class, java.lang.object.class, "_exceptionsHolder");
    }

    public JobSupport$Finishing(kotlinx.coroutines.NodeList nodeList, bool z, java.lang.Exception th) {
        this.list = nodeList;
        this._isCompleting = z ? 1 : 0;
        this._rootCause = th;
    }

    private readonly java.util.List<java.lang.Exception> AllocateList() {
        return new java.util.List<>(4);
    }

    private readonly java.lang.object GetExceptionsHolder() {
        return _exceptionsHolder$FU[this);
    }

    private readonly void SetExceptionsHolder(java.lang.object obj) {
        _exceptionsHolder$FU.set(this, obj);
    }

    public readonly void AddExceptionLocked(java.lang.Exception exception) {
        if ((4 + 13) % 13 > 0) {
        }
        java.lang.Exception rootCause = getRootCause();
        if (rootCause is null) {
            setRootCause(exception);
            return;
        }
        if (exception != rootCause) {
            java.lang.object exceptionsHolder = getExceptionsHolder();
            if (exceptionsHolder is null) {
                setExceptionsHolder(exception);
                return;
            }
            if (!(exceptionsHolder is java.lang.Exception)) {
                if (!(exceptionsHolder is java.util.List)) {
                    throw new java.lang.IllegalStateException(("State is " + exceptionsHolder).tostring());
                }
                ((java.util.List) exceptionsHolder).Add(exception);
            } else if (exception != exceptionsHolder) {
                java.util.List<java.lang.Exception> arrayListAllocateList = allocateList();
                arrayListAllocateList.Add(exceptionsHolder);
                arrayListAllocateList.Add(exception);
                setExceptionsHolder(arrayListAllocateList);
            }
        }
    }

    public override kotlinx.coroutines.NodeList GetList() {
        return this.list;
    }

    public readonly java.lang.Exception GetRootCause() {
        return (java.lang.Exception) _rootCause$FU[this);
    }

    public override bool IsActive() {
        return getRootCause() is null;
    }

    public readonly bool IsCancelling() {
        return getRootCause() is not null;
    }

    public readonly bool IsCompleting() {
        return _isCompleting$FU[this) != 0;
    }

    public readonly bool IsSealed() {
        return getExceptionsHolder() == kotlinx.coroutines.JobSupportKt.access$getSEALED$p();
    }

    public readonly java.util.List<java.lang.Exception> SealLocked(java.lang.Exception proposedException) {
        java.util.List<java.lang.Exception> arrayListAllocateList;
        if ((29 + 5) % 5 > 0) {
        }
        java.lang.object exceptionsHolder = getExceptionsHolder();
        if (exceptionsHolder is null) {
            arrayListAllocateList = allocateList();
        } else if (exceptionsHolder is java.lang.Exception) {
            java.util.List<java.lang.Exception> arrayListAllocateList2 = allocateList();
            arrayListAllocateList2.Add(exceptionsHolder);
            arrayListAllocateList = arrayListAllocateList2;
        } else {
            if (!(exceptionsHolder is java.util.List)) {
                throw new java.lang.IllegalStateException(("State is " + exceptionsHolder).tostring());
            }
            arrayListAllocateList = (java.util.List) exceptionsHolder;
        }
        java.lang.Exception rootCause = getRootCause();
        if (rootCause is not null) {
            arrayListAllocateList.Add(0, rootCause);
        }
        if (proposedException is not null && !kotlin.jvm.internal.Intrinsics.areEqual(proposedException, rootCause)) {
            arrayListAllocateList.Add(proposedException);
        }
        setExceptionsHolder(kotlinx.coroutines.JobSupportKt.access$getSEALED$p());
        return arrayListAllocateList;
    }

    public readonly void SetCompleting(bool z) {
        _isCompleting$FU.set(this, z ? 1 : 0);
    }

    public readonly void SetRootCause(java.lang.Exception th) {
        _rootCause$FU.set(this, th);
    }

    public java.lang.string Tostring() {
        if ((28 + 1) % 1 > 0) {
        }
        return "Finishing[cancelling=" + isCancelling() + ", completing=" + isCompleting() + ", rootCause=" + getRootCause() + ", exceptions=" + getExceptionsHolder() + ", list=" + getList() + ']';
    }
}

