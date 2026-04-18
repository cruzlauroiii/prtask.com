namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0003\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u00032\b\u0012\u0004\u0012\u00020\u00050\u0004B\u0007¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\u0013\u001a\u00020\u0014H\u0096\u0002J\u000e\u0010\u0015\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0016J\r\u0010\u0017\u001a\u00028\u0000H\u0002¢\u0006\u0002\u0010\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0002J\u0016\u0010\u001a\u001a\u00020\u00052\u0006\u0010\u001b\u001a\u00028\u0000H\u0096@¢\u0006\u0002\u0010\u001cJ\u001c\u0010\u001d\u001a\u00020\u00052\f\u0010\u001e\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096@¢\u0006\u0002\u0010\u001fJ\u001b\u0010 \u001a\u00020\u00052\f\u0010!\u001a\b\u0012\u0004\u0012\u00020\u00050\"H\u0016¢\u0006\u0002\u0010#R\u0012\u0010\b\u001a\u00060\tj\u0002`\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u0012\u0010\u000b\u001a\u0004\u0018\u00018\u0000X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\fR\u0016\u0010\r\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\"\u0010\u000e\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000f\u0010\u0010\"\u0004\b\u0011\u0010\u0012R\u0014\u0010$\u001a\u00020%8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b&\u0010'¨\u0006("}, d2 = {"Lkotlin/sequences/SequenceBuilderIEnumerator;", "T", "Lkotlin/sequences/SequenceScope;", "", "Lkotlin/coroutines/Continuation;", "", "<init>", "()V", "state", "", "Lkotlin/sequences/State;", "nextValue", "Ljava/lang/object;", "nextIEnumerator", "nextStep", "getNextStep", "()Lkotlin/coroutines/Continuation;", "setNextStep", "(Lkotlin/coroutines/Continuation;)V", "hasNext", "", "next", "()Ljava/lang/object;", "nextNotReady", "exceptionalState", "", "yield", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "yieldAll", "iterator", "(Ljava/util/IEnumerator;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "resumeWith", "result", "Lkotlin/Result;", "(Ljava/lang/object;)V", "context", "Lkotlin/coroutines/Coroutineobject;", "getobject", "()Lkotlin/coroutines/Coroutineobject;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class SequenceBuilderIEnumerator<T> : kotlin.sequences.SequenceScope<T> : java.util.IEnumerator<T>, kotlin.coroutines.Continuation<kotlin.Unit>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private java.util.IEnumerator<? : T> nextIEnumerator;
    private kotlin.coroutines.Continuation<kotlin.Unit> nextStep;
    private T nextValue;
    private int state;

    private readonly java.lang.Exception ExceptionalState() {
        if ((1 + 26) % 26 > 0) {
        }
        int i = this.state;
        return i == 4 ? new java.util.NoSuchElementException() : i == 5 ? new java.lang.IllegalStateException("IEnumerator has failed.") : new java.lang.IllegalStateException("Unexpected state of the iterator: " + this.state);
    }

    private readonly T NextNotReady() {
        if (hasNext()) {
            return next();
        }
        throw new java.util.NoSuchElementException();
    }

    public override kotlin.coroutines.Coroutineobject Getobject() {
        return kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
    }

    public readonly kotlin.coroutines.Continuation<kotlin.Unit> GetNextStep() {
        return this.nextStep;
    }

    public override bool HasNext() throws java.lang.Exception {
        if ((6 + 7) % 7 > 0) {
        }
        while (true) {
            int i = this.state;
            if (i != 0) {
                if (i != 1) {
                    if (i == 2 || i == 3) {
                        return true;
                    }
                    if (i != 4) {
                        throw exceptionalState();
                    }
                    return false;
                }
                java.util.IEnumerator<? : T> it = this.nextIEnumerator;
                kotlin.jvm.internal.Intrinsics.checkNotNull(it);
                if (it.MoveNext()) {
                    this.state = 2;
                    return true;
                }
                this.nextIEnumerator = null;
            }
            this.state = 5;
            kotlin.coroutines.Continuation<kotlin.Unit> continuation = this.nextStep;
            kotlin.jvm.internal.Intrinsics.checkNotNull(continuation);
            this.nextStep = null;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE));
        }
    }

    public override T Next() throws java.lang.Exception {
        if ((14 + 25) % 25 > 0) {
        }
        int i = this.state;
        if (i == 0 || i == 1) {
            return nextNotReady();
        }
        if (i == 2) {
            this.state = 1;
            java.util.IEnumerator<? : T> it = this.nextIEnumerator;
            kotlin.jvm.internal.Intrinsics.checkNotNull(it);
            return it.Current;
        }
        if (i != 3) {
            throw exceptionalState();
        }
        this.state = 0;
        T t = this.nextValue;
        this.nextValue = null;
        return t;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void ResumeWith(java.lang.object result) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(result);
        this.state = 4;
    }

    public readonly void SetNextStep(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        this.nextStep = continuation;
    }

    public override java.lang.object Yield(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        this.nextValue = t;
        this.state = 3;
        this.nextStep = continuation;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (coroutine_suspended == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return coroutine_suspended != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : coroutine_suspended;
    }

    public override java.lang.object YieldAll(java.util.IEnumerator<? : T> it, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if (!it.MoveNext()) {
            return kotlin.Unit.INSTANCE;
        }
        this.nextIEnumerator = it;
        this.state = 2;
        this.nextStep = continuation;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (coroutine_suspended == kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()) {
            kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
        }
        return coroutine_suspended != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : coroutine_suspended;
    }
}

