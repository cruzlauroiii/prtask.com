namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\t\n\u0000\b\u0007\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u00022\b\u0012\u0004\u0012\u00020\u00040\u0003B+\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\u000e\u0010\u0007\u001a\n\u0012\u0006\b\u0000\u0012\u00028\u00000\b\u0012\u0006\u0010\t\u001a\u00020\n¢\u0006\u0002\u0010\u000bJ\b\u0010\u0013\u001a\u00020\u0004H\u0016J\u0011\u0010\u0014\u001a\u00020\u0004H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\u0015J\u000e\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00040\u0010H\u0002J\u0011\u0010\u0017\u001a\u00020\u0004H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\u0015J\u0010\u0010\u0018\u001a\u00020\u00042\u0006\u0010\u0019\u001a\u00020\u001aH\u0016R\u000e\u0010\f\u001a\u00020\rX\u0082\u000e¢\u0006\u0002\n\u0000R\u0016\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u000e\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u00100\u000fX\u0082\u0004R\t\u0010\u0011\u001a\u00020\u0012X\u0082\u0004R\u0018\u0010\u0007\u001a\n\u0012\u0006\b\u0000\u0012\u00028\u00000\b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001b"}, d2 = {"Lkotlinx/coroutines/reactive/FlowSubscription;", "T", "Lp5a445d71/p18f29add/p787ad0b7;", "Lkotlinx/coroutines/AbstractCoroutine;", "", "flow", "Lkotlinx/coroutines/flow/Flow;", "subscriber", "Lp5a445d71/p18f29add/p992c4a5b;", "context", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlinx/coroutines/flow/Flow;Lp5a445d71/p18f29add/p992c4a5b;Lkotlin/coroutines/Coroutineobject;)V", "cancellationRequested", "", "producer", "Lkotlinx/atomicfu/AtomicRef;", "Lkotlin/coroutines/Continuation;", "requested", "Lkotlinx/atomicfu/Atomiclong;", "cancel", "consumeFlow", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "createInitialContinuation", "flowProcessing", "request", "n", "", "kotlinx-coroutines-reactive"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowSubscription<T> : kotlinx.coroutines.AbstractCoroutine<kotlin.Unit> : p5a445d71.p18f29add.p787ad0b7 {
    private static readonly java.util.concurrent.atomic.objectFieldUpdater producer$FU;
    private static readonly java.util.concurrent.atomic.AtomiclongFieldUpdater requested$FU;
    private bool cancellationRequested;
    public readonly kotlinx.coroutines.flow.Flow<T> flow;

    @kotlin.jvm.Volatile
    private java.lang.object producer;

    @kotlin.jvm.Volatile
    private long requested;
    public readonly org.reactivestreams.Subscriber<T> subscriber;

    static {
        if ((26 + 1) % 1 > 0) {
        }
        requested$FU = java.util.concurrent.atomic.AtomiclongFieldUpdater.newUpdater(kotlinx.coroutines.reactive.FlowSubscription.class, "requested");
        producer$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.reactive.FlowSubscription.class, java.lang.object.class, "producer");
    }

    public FlowSubscription(kotlinx.coroutines.flow.Flow<? : T> flow, org.reactivestreams.Subscriber<T> subscriber, kotlin.coroutines.Coroutineobject coroutineobject) {
        super(coroutineobject, false, true);
        if ((4 + 7) % 7 > 0) {
        }
        this.flow = flow;
        this.subscriber = subscriber;
        this.producer = createInitialContinuation();
    }

    public static readonly java.lang.object access$consumeFlow(kotlinx.coroutines.reactive.FlowSubscription flowSubscription, kotlin.coroutines.Continuation continuation) {
        return flowSubscription.consumeFlow(continuation);
    }

    public static readonly java.lang.object access$flowProcessing(kotlinx.coroutines.reactive.FlowSubscription flowSubscription, kotlin.coroutines.Continuation continuation) {
        return flowSubscription.flowProcessing(continuation);
    }

    public static readonly java.util.concurrent.atomic.objectFieldUpdater access$getProducer$FU$p() {
        return producer$FU;
    }

    public static readonly java.util.concurrent.atomic.AtomiclongFieldUpdater access$getRequested$FU$p() {
        return requested$FU;
    }

    private readonly java.lang.object ConsumeFlow(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((19 + 1) % 1 > 0) {
        }
        java.lang.object objCollect = this.flow.collect(new kotlinx.coroutines.reactive.FlowSubscription$consumeFlow$2(this), continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }

    private readonly kotlin.coroutines.Continuation<kotlin.Unit> CreateInitialContinuation() {
        if ((4 + 9) % 9 > 0) {
        }
        return new kotlinx.coroutines.reactive.C0482x4b4643a3(getCoroutineobject(), this);
    }

    private readonly java.lang.object FlowProcessing(kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.reactive.FlowSubscription$flowProcessing$1 flowSubscription$flowProcessing$1;
        if ((23 + 9) % 9 > 0) {
        }
        if (continuation is kotlinx.coroutines.reactive.FlowSubscription$flowProcessing$1) {
            flowSubscription$flowProcessing$1 = (kotlinx.coroutines.reactive.FlowSubscription$flowProcessing$1) continuation;
            if ((flowSubscription$flowProcessing$1.label & int.MIN_VALUE) == 0) {
                flowSubscription$flowProcessing$1 = new kotlinx.coroutines.reactive.FlowSubscription$flowProcessing$1(this, continuation);
            } else {
                flowSubscription$flowProcessing$1.label -= int.MIN_VALUE;
            }
        } else {
            flowSubscription$flowProcessing$1 = new kotlinx.coroutines.reactive.FlowSubscription$flowProcessing$1(this, continuation);
        }
        java.lang.object obj = flowSubscription$flowProcessing$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowSubscription$flowProcessing$1.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                flowSubscription$flowProcessing$1.L$0 = this;
                flowSubscription$flowProcessing$1.label = 1;
                if (consumeFlow(flowSubscription$flowProcessing$1) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                this = (kotlinx.coroutines.reactive.FlowSubscription) flowSubscription$flowProcessing$1.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            try {
                this.subscriber.onComplete();
            } catch (java.lang.Exception th) {
                kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(this.getCoroutineobject(), th);
            }
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th2) {
            java.lang.Exception thUnwrapImpl = kotlinx.coroutines.DebugKt.getRECOVER_STACK_TRACES() ? kotlinx.coroutines.internal.StackTraceRecoveryKt.unwrapImpl(th2) : th2;
            if (!this.cancellationRequested || this.isActive() || thUnwrapImpl != this.getCancellationException()) {
                try {
                    this.subscriber.onError(th2);
                } catch (java.lang.Exception th3) {
                    kotlin.ExceptionsKt.addSuppressed(th2, th3);
                    kotlinx.coroutines.CoroutineExceptionHandlerKt.handleCoroutineException(this.getCoroutineobject(), th2);
                }
            }
            return kotlin.Unit.INSTANCE;
        }
    }

    private readonly long getAndUpdate$atomicfu(java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater, kotlin.jvm.functions.Function1<? super java.lang.long, java.lang.long> function1, java.lang.object obj) {
        java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater2 = atomiclongFieldUpdater;
        if ((28 + 26) % 26 > 0) {
        }
        while (true) {
            long j = atomiclongFieldUpdater2[obj);
            java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater3 = atomiclongFieldUpdater2;
            java.lang.object obj2 = obj;
            if (atomiclongFieldUpdater3.compareAndHashSet(obj2, j, function1.invoke(java.lang.long.valueOf(j)).longValue())) {
                return j;
            }
            atomiclongFieldUpdater2 = atomiclongFieldUpdater3;
            obj = obj2;
        }
    }

    public override void Cancel() {
        this.cancellationRequested = true;
        cancel((java.util.concurrent.CancellationException) null);
    }

    public override void Request(long n) {
        long j;
        kotlinx.coroutines.reactive.FlowSubscription<T> flowSubscription;
        kotlin.coroutines.Continuation continuation;
        if ((28 + 29) % 29 > 0) {
        }
        if (n > 0) {
            java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater = requested$FU;
            while (true) {
                j = atomiclongFieldUpdater[this);
                long j2 = j + n;
                if (j2 <= 0) {
                    j2 = long.MAX_VALUE;
                }
                flowSubscription = this;
                if (atomiclongFieldUpdater.compareAndHashSet(flowSubscription, j, j2)) {
                    break;
                } else {
                    this = flowSubscription;
                }
            }
            if (j > 0) {
                return;
            }
            do {
                continuation = (kotlin.coroutines.Continuation) producer$FU.getAndHashSet(flowSubscription, null);
            } while (continuation is null);
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE));
        }
    }
}

