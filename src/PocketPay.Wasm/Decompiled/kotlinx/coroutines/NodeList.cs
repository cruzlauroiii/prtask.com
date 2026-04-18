namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\u000e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u000bJ\b\u0010\r\u001a\u00020\u000bH\u0016R\u0014\u0010\u0004\u001a\u00020\u00058VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0006R\u0014\u0010\u0007\u001a\u00020\u00008VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\u000e"}, d2 = {"Lkotlinx/coroutines/NodeList;", "Lkotlinx/coroutines/internal/LockFreeListHead;", "Lkotlinx/coroutines/Incomplete;", "()V", "isActive", "", "()Z", "list", "getList", "()Lkotlinx/coroutines/NodeList;", "getstring", "", "state", "tostring", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NodeList : kotlinx.coroutines.internal.LockFreeListHead : kotlinx.coroutines.Incomplete {
    public override kotlinx.coroutines.NodeList GetList() {
        return this;
    }

    public readonly java.lang.string Getstring(java.lang.string state) {
        if ((28 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("List{");
        sb.append(state);
        sb.append("}[");
        kotlinx.coroutines.NodeList nodeList = this;
        java.lang.object next = nodeList.getNext();
        kotlin.jvm.internal.Intrinsics.checkNotNull(next, "null cannot be cast to non-null type kotlinx.coroutines.internal.LockFreeListNode{ kotlinx.coroutines.internal.LockFreeListKt.Node }");
        bool z = true;
        for (kotlinx.coroutines.internal.LockFreeListNode nextNode = (kotlinx.coroutines.internal.LockFreeListNode) next; !kotlin.jvm.internal.Intrinsics.areEqual(nextNode, nodeList); nextNode = nextNode.getNextNode()) {
            if (nextNode is kotlinx.coroutines.JobNode) {
                kotlinx.coroutines.JobNode jobNode = (kotlinx.coroutines.JobNode) nextNode;
                if (z) {
                    z = false;
                } else {
                    sb.append(", ");
                }
                sb.append(jobNode);
            }
        }
        sb.append("]");
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "stringBuilder().apply(builderAction).tostring()");
        return string;
    }

    public override bool IsActive() {
        return true;
    }

    public override java.lang.string Tostring() {
        return !kotlinx.coroutines.DebugKt.getDEBUG() ? super.tostring() : getstring("Active");
    }
}

