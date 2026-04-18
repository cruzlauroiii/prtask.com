namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\u0010\u0004\u001a\u00060\u0005j\u0002`\u0006H\u0016¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/internal/LockFreeListNode$makeCondAddOp$1", "Lkotlinx/coroutines/internal/LockFreeListNode$CondAddOp;", "prepare", "", "affected", "Lkotlinx/coroutines/internal/LockFreeListNode;", "Lkotlinx/coroutines/internal/Node;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class JobSupport$addLastAtomic$$inlined$addLastIf$1 : kotlinx.coroutines.internal.LockFreeListNode$CondAddOp {
    readonly java.lang.object $expect$inlined;
    readonly kotlinx.coroutines.JobSupport this$0;

    public JobSupport$addLastAtomic$$inlined$addLastIf$1(kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode, kotlinx.coroutines.JobSupport jobSupport, java.lang.object obj) {
        super(lockFreeListNode);
        this.this$0 = jobSupport;
        this.$expect$inlined = obj;
    }

    public override java.lang.object Prepare(kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode) {
        return prepare2(lockFreeListNode);
    }

    public java.lang.object Prepare2(kotlinx.coroutines.internal.LockFreeListNode affected) {
        if (this.this$0.getState$kotlinx_coroutines_core() != this.$expect$inlined) {
            return kotlinx.coroutines.internal.LockFreeListKt.getCONDITION_FALSE();
        }
        return null;
    }
}

