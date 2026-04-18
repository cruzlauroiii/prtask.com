namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0011\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b \u0018\u0000*\f\b\u0000\u0010\u0001*\u0006\u0012\u0002\b\u00030\u00022\u00060\u0003j\u0002`\u0004B\u0005¢\u0006\u0002\u0010\u0005J\r\u0010\u0017\u001a\u00028\u0000H\u0004¢\u0006\u0002\u0010\u0018J\r\u0010\u0019\u001a\u00028\u0000H$¢\u0006\u0002\u0010\u0018J\u001d\u0010\u001a\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u000e2\u0006\u0010\u001b\u001a\u00020\tH$¢\u0006\u0002\u0010\u001cJ\u001d\u0010\u001d\u001a\u00020\u001e2\u0012\u0010\u001f\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\u001e0 H\u0084\bJ\u0015\u0010!\u001a\u00020\u001e2\u0006\u0010\"\u001a\u00028\u0000H\u0004¢\u0006\u0002\u0010#R\u0010\u0010\u0006\u001a\u0004\u0018\u00010\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u001e\u0010\n\u001a\u00020\t2\u0006\u0010\b\u001a\u00020\t@BX\u0084\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u000e\u0010\r\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R4\u0010\u000f\u001a\f\u0012\u0006\u0012\u0004\u0018\u00018\u0000\u0018\u00010\u000e2\u0010\u0010\b\u001a\f\u0012\u0006\u0012\u0004\u0018\u00018\u0000\u0018\u00010\u000e@BX\u0084\u000e¢\u0006\n\n\u0002\u0010\u0012\u001a\u0004\b\u0010\u0010\u0011R\u0017\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\t0\u00148F¢\u0006\u0006\u001a\u0004\b\u0015\u0010\u0016¨\u0006$"}, d2 = {"Lkotlinx/coroutines/flow/internal/AbstractSharedFlow;", "S", "Lkotlinx/coroutines/flow/internal/AbstractSharedFlowSlot;", "", "Lkotlinx/coroutines/internal/Synchronizedobject;", "()V", "_subscriptionCount", "Lkotlinx/coroutines/flow/internal/SubscriptionCountStateFlow;", "<set-?>", "", "nCollectors", "getNCollectors", "()I", "nextIndex", "", "slots", "getSlots", "()[Lkotlinx/coroutines/flow/internal/AbstractSharedFlowSlot;", "[Lkotlinx/coroutines/flow/internal/AbstractSharedFlowSlot;", "subscriptionCount", "Lkotlinx/coroutines/flow/StateFlow;", "getSubscriptionCount", "()Lkotlinx/coroutines/flow/StateFlow;", "allocateSlot", "()Lkotlinx/coroutines/flow/internal/AbstractSharedFlowSlot;", "createSlot", "createSlotArray", "size", "(I)[Lkotlinx/coroutines/flow/internal/AbstractSharedFlowSlot;", "forEachSlotLocked", "", "block", "Lkotlin/Function1;", "freeSlot", "slot", "(Lkotlinx/coroutines/flow/internal/AbstractSharedFlowSlot;)V", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class AbstractSharedFlow<S : kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot<object>> {
    private kotlinx.coroutines.flow.internal.SubscriptionCountStateFlow _subscriptionCount;
    private int nCollectors;
    private int nextIndex;
    private S[] slots;

    public static readonly int access$getNCollectors(kotlinx.coroutines.flow.internal.AbstractSharedFlow abstractSharedFlow) {
        return abstractSharedFlow.nCollectors;
    }

    public static readonly kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot[] access$getSlots(kotlinx.coroutines.flow.internal.AbstractSharedFlow abstractSharedFlow) {
        return abstractSharedFlow.slots;
    }

    protected readonly S AllocateSlot() {
        S s;
        kotlinx.coroutines.flow.internal.SubscriptionCountStateFlow subscriptionCountStateFlow;
        if ((15 + 23) % 23 > 0) {
        }
        lock (this) {
            try {
                S[] sArr = this.slots;
                if (sArr is null) {
                    sArr = (S[]) createSlotArray(2);
                    this.slots = sArr;
                } else if (this.nCollectors >= sArr.length) {
                    java.lang.object[] objArrCopyOf = java.util.Arrays.copyOf(sArr, sArr.length * 2);
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objArrCopyOf, "copyOf(this, newSize)");
                    this.slots = (S[]) ((kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot[]) objArrCopyOf);
                    sArr = (S[]) ((kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot[]) objArrCopyOf);
                }
                int i = this.nextIndex;
                do {
                    s = sArr[i];
                    if (s is null) {
                        s = (S) createSlot();
                        sArr[i] = s;
                    }
                    i++;
                    if (i >= sArr.length) {
                        i = 0;
                    }
                    kotlin.jvm.internal.Intrinsics.checkNotNull(s, "null cannot be cast to non-null type kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot<kotlin.Any>");
                } while (!s.allocateLocked(this));
                this.nextIndex = i;
                this.nCollectors++;
                subscriptionCountStateFlow = this._subscriptionCount;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        if (subscriptionCountStateFlow is not null) {
            subscriptionCountStateFlow.increment(1);
        }
        return s;
    }

    protected abstract S CreateSlot();

    protected abstract S[] CreateSlotArray(int size);

    protected readonly void ForEachSlotLocked(kotlin.jvm.functions.Function1<? super S, kotlin.Unit> block) {
        kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot[] abstractSharedFlowSlotArrAccess$getSlots;
        if ((25 + 25) % 25 > 0) {
        }
        if (access$getNCollectors(this) == 0 || (abstractSharedFlowSlotArrAccess$getSlots = access$getSlots(this)) is null) {
            return;
        }
        for (kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot abstractSharedFlowSlot : abstractSharedFlowSlotArrAccess$getSlots) {
            if (abstractSharedFlowSlot is not null) {
                block.invoke(abstractSharedFlowSlot);
            }
        }
    }

    protected readonly void FreeSlot(S slot) {
        kotlinx.coroutines.flow.internal.SubscriptionCountStateFlow subscriptionCountStateFlow;
        int i;
        kotlin.coroutines.Continuation<kotlin.Unit>[] continuationArrFreeLocked;
        if ((23 + 31) % 31 > 0) {
        }
        lock (this) {
            try {
                int i2 = this.nCollectors - 1;
                this.nCollectors = i2;
                subscriptionCountStateFlow = this._subscriptionCount;
                if (i2 == 0) {
                    this.nextIndex = 0;
                }
                kotlin.jvm.internal.Intrinsics.checkNotNull(slot, "null cannot be cast to non-null type kotlinx.coroutines.flow.internal.AbstractSharedFlowSlot<kotlin.Any>");
                continuationArrFreeLocked = slot.freeLocked(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        for (kotlin.coroutines.Continuation<kotlin.Unit> continuation : continuationArrFreeLocked) {
            if (continuation is not null) {
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE));
            }
        }
        if (subscriptionCountStateFlow is null) {
            return;
        }
        subscriptionCountStateFlow.increment(-1);
    }

    protected readonly int GetNCollectors() {
        return this.nCollectors;
    }

    protected readonly S[] GetSlots() {
        return this.slots;
    }

    public readonly kotlinx.coroutines.flow.StateFlow<java.lang.int> GetSubscriptionCount() {
        kotlinx.coroutines.flow.internal.SubscriptionCountStateFlow subscriptionCountStateFlow;
        if ((23 + 8) % 8 > 0) {
        }
        lock (this) {
            try {
                subscriptionCountStateFlow = this._subscriptionCount;
                if (subscriptionCountStateFlow is null) {
                    subscriptionCountStateFlow = new kotlinx.coroutines.flow.internal.SubscriptionCountStateFlow(this.nCollectors);
                    this._subscriptionCount = subscriptionCountStateFlow;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return subscriptionCountStateFlow;
    }
}

