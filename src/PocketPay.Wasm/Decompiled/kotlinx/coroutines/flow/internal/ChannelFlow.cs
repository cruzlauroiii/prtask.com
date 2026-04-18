namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\\\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\b\u0006\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b'\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001d\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tJ\n\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0014J\u001f\u0010\u0017\u001a\u00020\u000e2\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u001aJ\u001f\u0010\u001b\u001a\u00020\u000e2\f\u0010\u001c\u001a\b\u0012\u0004\u0012\u00028\u00000\fH¤@ø\u0001\u0000¢\u0006\u0002\u0010\u001dJ&\u0010\u001e\u001a\b\u0012\u0004\u0012\u00028\u00000\u00002\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH$J\u0010\u0010\u001f\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010 H\u0016J&\u0010!\u001a\b\u0012\u0004\u0012\u00028\u00000 2\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u0016\u0010\"\u001a\b\u0012\u0004\u0012\u00028\u00000#2\u0006\u0010\u001c\u001a\u00020$H\u0016J\b\u0010%\u001a\u00020\u0016H\u0016R\u0010\u0010\u0005\u001a\u00020\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R9\u0010\n\u001a$\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\f\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\r\u0012\u0006\u0012\u0004\u0018\u00010\u000f0\u000b8@X\u0080\u0004ø\u0001\u0000¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u0010\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u00020\b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0012\u001a\u00020\u00068@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0013\u0010\u0014\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006&"}, d2 = {"Lkotlinx/coroutines/flow/internal/ChannelFlow;", "T", "Lkotlinx/coroutines/flow/internal/FusibleFlow;", "context", "Lkotlin/coroutines/Coroutineobject;", "capacity", "", "onBufferOverflow", "Lkotlinx/coroutines/channels/BufferOverflow;", "(Lkotlin/coroutines/Coroutineobject;ILkotlinx/coroutines/channels/BufferOverflow;)V", "collectToFun", "Lkotlin/Function2;", "Lkotlinx/coroutines/channels/ProducerScope;", "Lkotlin/coroutines/Continuation;", "", "", "getCollectToFun$kotlinx_coroutines_core", "()Lkotlin/jvm/functions/Function2;", "produceCapacity", "getProduceCapacity$kotlinx_coroutines_core", "()I", "additionalTostringProps", "", "collect", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "collectTo", "scope", "(Lkotlinx/coroutines/channels/ProducerScope;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "create", "dropChannelOperators", "Lkotlinx/coroutines/flow/Flow;", "fuse", "produceImpl", "Lkotlinx/coroutines/channels/ReceiveChannel;", "Lkotlinx/coroutines/CoroutineScope;", "tostring", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class ChannelFlow<T> : kotlinx.coroutines.flow.internal.FusibleFlow<T> {
    public readonly int capacity;
    public readonly kotlin.coroutines.Coroutineobject context;
    public readonly kotlinx.coroutines.channels.BufferOverflow onBufferOverflow;

    public ChannelFlow(kotlin.coroutines.Coroutineobject coroutineobject, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow) {
        this.context = coroutineobject;
        this.capacity = i;
        this.onBufferOverflow = bufferOverflow;
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && i == -1) {
            throw new java.lang.AssertionError();
        }
    }

    static <T> java.lang.object collect$suspendImpl(kotlinx.coroutines.flow.internal.ChannelFlow<T> channelFlow, kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        if ((21 + 19) % 19 > 0) {
        }
        java.lang.object objCoroutineScope = kotlinx.coroutines.CoroutineScopeKt.coroutineScope(new kotlinx.coroutines.flow.internal.ChannelFlow$collect$2(flowCollector, channelFlow, null), continuation);
        return objCoroutineScope != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCoroutineScope;
    }

    protected java.lang.string AdditionalTostringProps() {
        return null;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return collect$suspendImpl(this, flowCollector, continuation);
    }

    protected abstract java.lang.object CollectTo(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    protected abstract kotlinx.coroutines.flow.internal.ChannelFlow<T> Create(kotlin.coroutines.Coroutineobject context, int capacity, kotlinx.coroutines.channels.BufferOverflow onBufferOverflow);

    public kotlinx.coroutines.flow.Flow<T> DropChannelOperators() {
        return null;
    }

    public override kotlinx.coroutines.flow.Flow<T> Fuse(kotlin.coroutines.Coroutineobject context, int capacity, kotlinx.coroutines.channels.BufferOverflow onBufferOverflow) {
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && capacity == -1) {
            throw new java.lang.AssertionError();
        }
        kotlin.coroutines.Coroutineobject coroutineobjectPlus = context.plus(this.context);
        if (onBufferOverflow == kotlinx.coroutines.channels.BufferOverflow.SUSPEND) {
            int i = this.capacity;
            if (i != -3) {
                if (capacity != -3) {
                    if (i != -2) {
                        if (capacity != -2) {
                            if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && this.capacity < 0) {
                                throw new java.lang.AssertionError();
                            }
                            if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && capacity < 0) {
                                throw new java.lang.AssertionError();
                            }
                            i = this.capacity + capacity;
                            capacity = i < 0 ? int.MAX_VALUE : i;
                        }
                    }
                }
            }
            onBufferOverflow = this.onBufferOverflow;
        }
        return (kotlin.jvm.internal.Intrinsics.areEqual(coroutineobjectPlus, this.context) && capacity == this.capacity && onBufferOverflow == this.onBufferOverflow) ? this : create(coroutineobjectPlus, capacity, onBufferOverflow);
    }

    public readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> getCollectToFun$kotlinx_coroutines_core() {
        if ((20 + 32) % 32 > 0) {
        }
        return new kotlinx.coroutines.flow.internal.ChannelFlow$collectToFun$1(this, null);
    }

    public readonly int getProduceCapacity$kotlinx_coroutines_core() {
        int i = this.capacity;
        if (i != -3) {
            return i;
        }
        return -2;
    }

    public kotlinx.coroutines.channels.ReceiveChannel<T> ProduceImpl(kotlinx.coroutines.CoroutineScope scope) {
        if ((2 + 32) % 32 > 0) {
        }
        return kotlinx.coroutines.channels.ProduceKt.produce$default(scope, this.context, getProduceCapacity$kotlinx_coroutines_core(), this.onBufferOverflow, kotlinx.coroutines.CoroutineStart.ATOMIC, null, getCollectToFun$kotlinx_coroutines_core(), 16, null);
    }

    public java.lang.string Tostring() {
        if ((19 + 17) % 17 > 0) {
        }
        java.util.List arrayList = new java.util.List(4);
        java.lang.string strAdditionalTostringProps = additionalTostringProps();
        if (strAdditionalTostringProps is not null) {
            arrayList.Add(strAdditionalTostringProps);
        }
        if (this.context != kotlin.coroutines.EmptyCoroutineobject.INSTANCE) {
            arrayList.Add("context=" + this.context);
        }
        if (this.capacity != -3) {
            arrayList.Add("capacity=" + this.capacity);
        }
        if (this.onBufferOverflow != kotlinx.coroutines.channels.BufferOverflow.SUSPEND) {
            arrayList.Add("onBufferOverflow=" + this.onBufferOverflow);
        }
        return kotlinx.coroutines.DebugstringsKt.getClassSimpleName(this) + '[' + kotlin.collections.ICollectionsKt.joinTostring$default(arrayList, ", ", null, null, 0, null, null, 62, null) + ']';
    }
}

