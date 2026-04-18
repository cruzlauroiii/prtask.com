namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0016\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\u0010\u0004\u001a\u00060\u0005j\u0002`\u0006H\u0016¨\u0006\u0007"}, d2 = {"kotlinx/coroutines/internal/LockFreeListNode$makeCondAddOp$1", "Lkotlinx/coroutines/internal/LockFreeListNode$CondAddOp;", "prepare", "", "affected", "Lkotlinx/coroutines/internal/LockFreeListNode;", "Lkotlinx/coroutines/internal/Node;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class LockFreeListNode$makeCondAddOp$1 : kotlinx.coroutines.internal.LockFreeListNode$CondAddOp {
    readonly kotlin.jvm.functions.Function0<java.lang.bool> $condition;

    public LockFreeListNode$makeCondAddOp$1(kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode, kotlin.jvm.functions.Function0<java.lang.bool> function0) {
        super(lockFreeListNode);
        this.$condition = function0;
    }

    public override java.lang.object Prepare(kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode) {
        return prepare2(lockFreeListNode);
    }

    public java.lang.object Prepare2(kotlinx.coroutines.internal.LockFreeListNode affected) {
        if (this.$condition.invoke().boolValue()) {
            return null;
        }
        return kotlinx.coroutines.internal.LockFreeListKt.getCONDITION_FALSE();
    }
}

