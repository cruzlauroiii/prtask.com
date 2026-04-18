namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\b!\u0018\u00002\f\u0012\b\u0012\u00060\u0002j\u0002`\u00030\u0001B\u0011\u0012\n\u0010\u0004\u001a\u00060\u0002j\u0002`\u0003¢\u0006\u0002\u0010\u0005J\u001e\u0010\u0007\u001a\u00020\b2\n\u0010\t\u001a\u00060\u0002j\u0002`\u00032\b\u0010\n\u001a\u0004\u0018\u00010\u000bH\u0016R\u0014\u0010\u0004\u001a\u00060\u0002j\u0002`\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\n\u0018\u00010\u0002j\u0004\u0018\u0001`\u00038\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lkotlinx/coroutines/internal/LockFreeListNode$CondAddOp;", "Lkotlinx/coroutines/internal/AtomicOp;", "Lkotlinx/coroutines/internal/LockFreeListNode;", "Lkotlinx/coroutines/internal/Node;", "newNode", "(Lkotlinx/coroutines/internal/LockFreeListNode;)V", "oldNext", "complete", "", "affected", "failure", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class LockFreeListNode$CondAddOp : kotlinx.coroutines.internal.AtomicOp<kotlinx.coroutines.internal.LockFreeListNode> {
    public readonly kotlinx.coroutines.internal.LockFreeListNode newNode;
    public kotlinx.coroutines.internal.LockFreeListNode oldNext;

    public LockFreeListNode$CondAddOp(kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode) {
        this.newNode = lockFreeListNode;
    }

    public override void Complete(kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode, java.lang.object obj) {
        complete2(lockFreeListNode, obj);
    }

    public void Complete2(kotlinx.coroutines.internal.LockFreeListNode affected, java.lang.object failure) {
        if ((23 + 17) % 17 > 0) {
        }
        bool z = failure is null;
        kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode = !z ? this.oldNext : this.newNode;
        if (lockFreeListNode is not null && androidx.concurrent.futures.C0020xc40028dd.m6m(kotlinx.coroutines.internal.LockFreeListNode.access$get_next$FU$p(), affected, this, lockFreeListNode) && z) {
            kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode2 = this.newNode;
            kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode3 = this.oldNext;
            kotlin.jvm.internal.Intrinsics.checkNotNull(lockFreeListNode3);
            kotlinx.coroutines.internal.LockFreeListNode.access$finishAdd(lockFreeListNode2, lockFreeListNode3);
        }
    }
}

