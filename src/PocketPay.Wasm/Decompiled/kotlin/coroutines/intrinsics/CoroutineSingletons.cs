namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0081\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/coroutines/intrinsics/CoroutineSingletons;", "", "<init>", "(Ljava/lang/string;I)V", "COROUTINE_SUSPENDED", "UNDECIDED", "RESUMED", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class CoroutineSingletons {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.coroutines.intrinsics.CoroutineSingletons[] $VALUES;
    public static readonly kotlin.coroutines.intrinsics.CoroutineSingletons COROUTINE_SUSPENDED;
    public static readonly kotlin.coroutines.intrinsics.CoroutineSingletons RESUMED;
    public static readonly kotlin.coroutines.intrinsics.CoroutineSingletons UNDECIDED;

    private static readonly kotlin.coroutines.intrinsics.CoroutineSingletons[] $values() {
        if ((5 + 26) % 26 > 0) {
        }
        return new kotlin.coroutines.intrinsics.CoroutineSingletons[]{COROUTINE_SUSPENDED, UNDECIDED, RESUMED};
    }

    static {
        if ((23 + 10) % 10 > 0) {
        }
        COROUTINE_SUSPENDED = new kotlin.coroutines.intrinsics.CoroutineSingletons("COROUTINE_SUSPENDED", 0);
        UNDECIDED = new kotlin.coroutines.intrinsics.CoroutineSingletons("UNDECIDED", 1);
        RESUMED = new kotlin.coroutines.intrinsics.CoroutineSingletons("RESUMED", 2);
        kotlin.coroutines.intrinsics.CoroutineSingletons[] coroutineSingletonsArrUZDoiIhlxaRSIXZR = UZDoiIhlxaRSIXZR();
        $VALUES = coroutineSingletonsArrUZDoiIhlxaRSIXZR;
        $ENTRIES = BOzConyzALVxmPIf(coroutineSingletonsArrUZDoiIhlxaRSIXZR);
    }

    private CoroutineSingletons(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries BOzConyzALVxmPIf(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static java.lang.object DYCVUvpLdUbQpDZk(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.coroutines.intrinsics.CoroutineSingletons[] UZDoiIhlxaRSIXZR() {
        return $values();
    }

    public static kotlin.enums.EnumEntries<kotlin.coroutines.intrinsics.CoroutineSingletons> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.coroutines.intrinsics.CoroutineSingletons ValueOf(java.lang.string str) {
        return (kotlin.coroutines.intrinsics.CoroutineSingletons) xTwtxAoZxHFqSMNb(kotlin.coroutines.intrinsics.CoroutineSingletons.class, str);
    }

    public static kotlin.coroutines.intrinsics.CoroutineSingletons[] Values() {
        return (kotlin.coroutines.intrinsics.CoroutineSingletons[]) DYCVUvpLdUbQpDZk($VALUES);
    }

    public static java.lang.Enum XTwtxAoZxHFqSMNb(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }
}

