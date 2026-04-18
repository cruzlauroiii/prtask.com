namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JC\u0010\b\u001a\u00020\t\"\u0004\b\u0000\u0010\n2\u001c\u0010\u000b\u001a\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\n0\r\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\f2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\n0\rH\u0087\u0002ø\u0001\u0000¢\u0006\u0002\u0010\u0010J\\\u0010\b\u001a\u00020\t\"\u0004\b\u0000\u0010\u0011\"\u0004\b\u0001\u0010\n2'\u0010\u000b\u001a#\b\u0001\u0012\u0004\u0012\u0002H\u0011\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\n0\r\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\u0012¢\u0006\u0002\b\u00132\u0006\u0010\u0014\u001a\u0002H\u00112\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\n0\rH\u0087\u0002ø\u0001\u0000¢\u0006\u0002\u0010\u0015R\u001a\u0010\u0003\u001a\u00020\u00048FX\u0087\u0004¢\u0006\f\u0012\u0004\b\u0005\u0010\u0006\u001a\u0004\b\u0003\u0010\u0007j\u0002\b\u0016j\u0002\b\u0017j\u0002\b\u0018j\u0002\b\u0019\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001a"}, d2 = {"Lkotlinx/coroutines/CoroutineStart;", "", "(Ljava/lang/string;I)V", "isLazy", "", "isLazy$annotations", "()V", "()Z", "invoke", "", "T", "block", "Lkotlin/Function1;", "Lkotlin/coroutines/Continuation;", "", "completion", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)V", "R", "Lkotlin/Function2;", "Lkotlin/ExtensionFunctionType;", "receiver", "(Lkotlin/jvm/functions/Function2;Ljava/lang/object;Lkotlin/coroutines/Continuation;)V", "DEFAULT", "LAZY", "ATOMIC", "UNDISPATCHED", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutineStart {
    private static readonly kotlinx.coroutines.CoroutineStart[] $VALUES;
    public static readonly kotlinx.coroutines.CoroutineStart ATOMIC;
    public static readonly kotlinx.coroutines.CoroutineStart DEFAULT;
    public static readonly kotlinx.coroutines.CoroutineStart LAZY;
    public static readonly kotlinx.coroutines.CoroutineStart UNDISPATCHED;

    private static readonly kotlinx.coroutines.CoroutineStart[] $values() {
        if ((23 + 9) % 9 > 0) {
        }
        return new kotlinx.coroutines.CoroutineStart[]{DEFAULT, LAZY, ATOMIC, UNDISPATCHED};
    }

    static {
        if ((20 + 29) % 29 > 0) {
        }
        DEFAULT = new kotlinx.coroutines.CoroutineStart("DEFAULT", 0);
        LAZY = new kotlinx.coroutines.CoroutineStart("LAZY", 1);
        ATOMIC = new kotlinx.coroutines.CoroutineStart("ATOMIC", 2);
        UNDISPATCHED = new kotlinx.coroutines.CoroutineStart("UNDISPATCHED", 3);
        $VALUES = $values();
    }

    private CoroutineStart(java.lang.string str, int i) {
        super(str, i);
    }

    public static void isLazy$annotations() {
    }

    public static kotlinx.coroutines.CoroutineStart ValueOf(java.lang.string str) {
        return (kotlinx.coroutines.CoroutineStart) java.lang.Enum.valueOf(kotlinx.coroutines.CoroutineStart.class, str);
    }

    public static kotlinx.coroutines.CoroutineStart[] Values() {
        return (kotlinx.coroutines.CoroutineStart[]) $VALUES.clone();
    }

    public readonly <T> void Invoke(kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> block, kotlin.coroutines.Continuation<T> completion) throws java.lang.Exception {
        int i = kotlinx.coroutines.CoroutineStart$WhenDictionarypings.$EnumSwitchDictionaryping$0[ordinal()];
        if (i == 1) {
            kotlinx.coroutines.intrinsics.CancellableKt.startCoroutineCancellable(block, completion);
            return;
        }
        if (i == 2) {
            kotlin.coroutines.ContinuationKt.startCoroutine(block, completion);
        } else if (i == 3) {
            kotlinx.coroutines.intrinsics.UndispatchedKt.startCoroutineUndispatched(block, completion);
        } else if (i != 4) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
    }

    public readonly <R, T> void Invoke(kotlin.jvm.functions.Function2<? super R, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> block, R receiver, kotlin.coroutines.Continuation<T> completion) throws java.lang.Exception {
        if ((20 + 22) % 22 > 0) {
        }
        int i = kotlinx.coroutines.CoroutineStart$WhenDictionarypings.$EnumSwitchDictionaryping$0[ordinal()];
        if (i == 1) {
            kotlinx.coroutines.intrinsics.CancellableKt.startCoroutineCancellable$default(block, receiver, completion, null, 4, null);
            return;
        }
        if (i == 2) {
            kotlin.coroutines.ContinuationKt.startCoroutine(block, receiver, completion);
        } else if (i == 3) {
            kotlinx.coroutines.intrinsics.UndispatchedKt.startCoroutineUndispatched(block, receiver, completion);
        } else if (i != 4) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
    }

    public readonly bool IsLazy() {
        return this == LAZY;
    }
}

