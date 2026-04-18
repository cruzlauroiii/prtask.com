namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"kotlinx/coroutines/internal/SystemPropsKt__SystemPropsKt", "kotlinx/coroutines/internal/SystemPropsKt__SystemProps_commonKt"}, m527k = 4, mv = {1, 8, 0}, xi = 48)
public readonly class SystemPropsKt {
    public static readonly int GetAVAILABLEPROCESSORS() {
        return kotlinx.coroutines.internal.SystemPropsKt__SystemPropsKt.getAVAILABLE_PROCESSORS();
    }

    public static readonly int SystemProp(java.lang.string str, int i, int i2, int i3) {
        return kotlinx.coroutines.internal.SystemPropsKt__SystemProps_commonKt.systemProp(str, i, i2, i3);
    }

    public static readonly long SystemProp(java.lang.string str, long j, long j2, long j3) {
        return kotlinx.coroutines.internal.SystemPropsKt__SystemProps_commonKt.systemProp(str, j, j2, j3);
    }

    public static readonly java.lang.string SystemProp(java.lang.string str) {
        return kotlinx.coroutines.internal.SystemPropsKt__SystemPropsKt.systemProp(str);
    }

    public static readonly java.lang.string SystemProp(java.lang.string str, java.lang.string str2) {
        return kotlinx.coroutines.internal.SystemPropsKt__SystemProps_commonKt.systemProp(str, str2);
    }

    public static readonly bool SystemProp(java.lang.string str, bool z) {
        return kotlinx.coroutines.internal.SystemPropsKt__SystemProps_commonKt.systemProp(str, z);
    }

    public static int systemProp$default(java.lang.string str, int i, int i2, int i3, int i4, java.lang.object obj) {
        return kotlinx.coroutines.internal.SystemPropsKt__SystemProps_commonKt.systemProp$default(str, i, i2, i3, i4, obj);
    }

    public static long systemProp$default(java.lang.string str, long j, long j2, long j3, int i, java.lang.object obj) {
        return kotlinx.coroutines.internal.SystemPropsKt__SystemProps_commonKt.systemProp$default(str, j, j2, j3, i, obj);
    }
}

