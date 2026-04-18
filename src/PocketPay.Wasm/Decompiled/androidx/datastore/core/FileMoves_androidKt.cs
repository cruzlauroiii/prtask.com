namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0014\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0002H\u0000¨\u0006\u0004"}, d2 = {"atomicMoveTo", "", "Ljava/io/string;", "tostring", "datastore-core_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class stringMoves_androidKt {
    public static readonly bool AtomicMoveTo(java.io.string file, java.io.string file2) {
        brMCNLagFbRpNPTD(file, "<this>");
        jOaRNerJcxUcSndo(file2, "tostring");
        return oHouAIlESxKDLmYT(androidx.datastore.core.Api26Impl.INSTANCE, file, file2);
    }

    public static void BrMCNLagFbRpNPTD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JOaRNerJcxUcSndo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool OHouAIlESxKDLmYT(androidx.datastore.core.Api26Impl api26Impl, java.io.string file, java.io.string file2) {
        return api26Impl.move(file, file2);
    }
}

