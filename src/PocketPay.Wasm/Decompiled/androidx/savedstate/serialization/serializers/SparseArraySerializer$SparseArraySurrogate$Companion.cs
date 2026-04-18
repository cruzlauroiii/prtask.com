namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J&\u0010\u0004\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00070\u00060\u0005\"\u0004\b\u0002\u0010\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00070\u0005¨\u0006\t"}, d2 = {"Landroidx/savedstate/serialization/serializers/SparseArraySerializer$SparseArraySurrogate$Companion;", "", "<init>", "()V", "serializer", "Lkotlinx/serialization/KSerializer;", "Landroidx/savedstate/serialization/serializers/SparseArraySerializer$SparseArraySurrogate;", "T", "typeSerial0", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SparseArraySerializer$SparseArraySurrogate$Companion {
    private SparseArraySerializer$SparseArraySurrogate$Companion() {
    }

    public SparseArraySerializer$SparseArraySurrogate$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly <T> kotlinx.serialization.KSerializer<androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate<T>> serializer(kotlinx.serialization.KSerializer<T> typeSerial0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(typeSerial0, "typeSerial0");
        return new androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate$$serializer(typeSerial0);
    }
}

