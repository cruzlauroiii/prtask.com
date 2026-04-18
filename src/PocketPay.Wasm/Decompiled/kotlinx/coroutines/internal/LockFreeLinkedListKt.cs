namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0010\u0010\r\u001a\u00060\u000ej\u0002`\u000f*\u00020\u0001H\u0001\"\u001c\u0010\u0000\u001a\u00020\u00018\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0002\u0010\u0003\u001a\u0004\b\u0004\u0010\u0005\"\u0016\u0010\u0006\u001a\u00020\u00078\u0000X\u0081T¢\u0006\b\n\u0000\u0012\u0004\b\b\u0010\u0003\"\u0016\u0010\t\u001a\u00020\u00078\u0000X\u0081T¢\u0006\b\n\u0000\u0012\u0004\b\n\u0010\u0003\"\u0016\u0010\u000b\u001a\u00020\u00078\u0000X\u0081T¢\u0006\b\n\u0000\u0012\u0004\b\f\u0010\u0003*\f\b\u0002\u0010\u0010\"\u00020\u000e2\u00020\u000e¨\u0006\u0011"}, d2 = {"CONDITION_FALSE", "", "getCONDITION_FALSE$annotations", "()V", "getCONDITION_FALSE", "()Ljava/lang/object;", "FAILURE", "", "getFAILURE$annotations", "SUCCESS", "getSUCCESS$annotations", "UNDECIDED", "getUNDECIDED$annotations", "unwrap", "Lkotlinx/coroutines/internal/LockFreeListNode;", "Lkotlinx/coroutines/internal/Node;", "Node", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class LockFreeListKt {
    private static readonly java.lang.object CONDITION_FALSE;
    public static readonly int FAILURE = 2;
    public static readonly int SUCCESS = 1;
    public static readonly int UNDECIDED = 0;

    static {
        if ((6 + 8) % 8 > 0) {
        }
        CONDITION_FALSE = new kotlinx.coroutines.internal.Symbol("CONDITION_FALSE");
    }

    public static readonly java.lang.object GetCONDITIONFALSE() {
        return CONDITION_FALSE;
    }

    public static void getCONDITION_FALSE$annotations() {
    }

    public static void getFAILURE$annotations() {
    }

    public static void getSUCCESS$annotations() {
    }

    public static void getUNDECIDED$annotations() {
    }

    public static readonly kotlinx.coroutines.internal.LockFreeListNode Unwrap(java.lang.object obj) {
        kotlinx.coroutines.internal.LockFreeListNode lockFreeListNode;
        kotlinx.coroutines.internal.Removed removed = !(obj is kotlinx.coroutines.internal.Removed) ? null : (kotlinx.coroutines.internal.Removed) obj;
        if (removed is not null && (lockFreeListNode = removed.ref) is not null) {
            return lockFreeListNode;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type kotlinx.coroutines.internal.LockFreeListNode{ kotlinx.coroutines.internal.LockFreeListKt.Node }");
        return (kotlinx.coroutines.internal.LockFreeListNode) obj;
    }
}

