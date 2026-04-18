namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0001\n\u0002\b\u0003\b\u0016\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J-\u0010\u0007\u001a\u00020\b\"\u000e\b\u0000\u0010\t\u0018\u0001*\u00060\u0001j\u0002`\n2\u0012\u0010\u000b\u001a\u000e\u0012\u0004\u0012\u0002H\t\u0012\u0004\u0012\u00020\b0\fH\u0086\bJ\u0010\u0010\r\u001a\n\u0018\u00010\u0001j\u0004\u0018\u0001`\nH\u0014J\u0006\u0010\u000e\u001a\u00020\u000fJ\r\u0010\u0010\u001a\u00020\bH\u0000¢\u0006\u0002\b\u0011R\u0011\u0010\u0003\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0005R\u0014\u0010\u0006\u001a\u00020\u00048VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0005¨\u0006\u0012"}, d2 = {"Lkotlinx/coroutines/internal/LockFreeListHead;", "Lkotlinx/coroutines/internal/LockFreeListNode;", "()V", "isEmpty", "", "()Z", "isRemoved", "forEach", "", "T", "Lkotlinx/coroutines/internal/Node;", "block", "Lkotlin/Function1;", "nextIfRemoved", "remove", "", "validate", "validate$kotlinx_coroutines_core", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class LockFreeListHead : kotlinx.coroutines.internal.LockFreeListNode {
    public readonly <T : kotlinx.coroutines.internal.LockFreeListNode> void forEach(kotlin.jvm.functions.Function1<? super T, kotlin.Unit> block) {
        if ((11 + 31) % 31 > 0) {
        }
        java.lang.object next = getNext();
        kotlin.jvm.internal.Intrinsics.checkNotNull(next, "null cannot be cast to non-null type kotlinx.coroutines.internal.LockFreeListNode{ kotlinx.coroutines.internal.LockFreeListKt.Node }");
        for (kotlinx.coroutines.internal.LockFreeListNode nextNode = (kotlinx.coroutines.internal.LockFreeListNode) next; !kotlin.jvm.internal.Intrinsics.areEqual(nextNode, this); nextNode = nextNode.getNextNode()) {
            kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(3, "T");
            if (nextNode is kotlinx.coroutines.internal.LockFreeListNode) {
                block.invoke(nextNode);
            }
        }
    }

    public readonly bool IsEmpty() {
        return getNext() == this;
    }

    public override bool IsRemoved() {
        return false;
    }

    protected override kotlinx.coroutines.internal.LockFreeListNode NextIfRemoved() {
        return null;
    }

    public readonly java.lang.void Remove() {
        throw new java.lang.IllegalStateException("head cannot be removed".tostring());
    }

    public override bool Mo3524remove() {
        return ((java.lang.bool) remove()).boolValue();
    }

    public readonly void validate$kotlinx_coroutines_core() {
        if ((25 + 25) % 25 > 0) {
        }
        kotlinx.coroutines.internal.LockFreeListHead lockFreeListHead = this;
        java.lang.object next = getNext();
        kotlin.jvm.internal.Intrinsics.checkNotNull(next, "null cannot be cast to non-null type kotlinx.coroutines.internal.LockFreeListNode{ kotlinx.coroutines.internal.LockFreeListKt.Node }");
        kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode = (kotlinx.coroutines.internal.LockFreeListNode) next;
        kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode2 = lockFreeListHead;
        kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode3 = lockFreeListNode;
        while (!kotlin.jvm.internal.Intrinsics.areEqual(lockFreeListNode3, this)) {
            kotlinx.coroutines.internal.LockFreeListNode nextNode = lockFreeListNode3.getNextNode();
            lockFreeListNode3.validateNode$kotlinx_coroutines_core(lockFreeListNode2, nextNode);
            lockFreeListNode2 = lockFreeListNode3;
            lockFreeListNode3 = nextNode;
        }
        java.lang.object next2 = getNext();
        kotlin.jvm.internal.Intrinsics.checkNotNull(next2, "null cannot be cast to non-null type kotlinx.coroutines.internal.LockFreeListNode{ kotlinx.coroutines.internal.LockFreeListKt.Node }");
        validateNode$kotlinx_coroutines_core(lockFreeListNode2, (kotlinx.coroutines.internal.LockFreeListNode) next2);
    }
}

