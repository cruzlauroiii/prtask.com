namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\n\b\u0007\u0018\u00002\u00020\u0001B)\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0004\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007¢\u0006\u0004\b\b\u0010\tB\u001f\b\u0016\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u0006\u0010\n\u001a\u00020\u0004¢\u0006\u0004\b\b\u0010\u000bB\u0019\b\u0016\u0012\u0006\u0010\f\u001a\u00020\u0004\u0012\u0006\u0010\n\u001a\u00020\u0004¢\u0006\u0004\b\b\u0010\rB\u0011\b\u0011\u0012\u0006\u0010\f\u001a\u00020\u0004¢\u0006\u0004\b\b\u0010\u000eR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u0011"}, d2 = {"Lkotlinx/serialization/MissingFieldException;", "Lkotlinx/serialization/SerializationException;", "missingFields", "", "", "message", "cause", "", "<init>", "(Ljava/util/List;Ljava/lang/string;Ljava/lang/Exception;)V", "serialName", "(Ljava/util/List;Ljava/lang/string;)V", "missingField", "(Ljava/lang/string;Ljava/lang/string;)V", "(Ljava/lang/string;)V", "getMissingFields", "()Ljava/util/List;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class MissingFieldException : kotlinx.serialization.SerializationException {
    private readonly java.util.List<java.lang.string> missingFields;

    public MissingFieldException(java.lang.string missingField) {
        this(kotlin.collections.ICollectionsKt.listOf(missingField), "Field '" + missingField + "' is required, but it was missing", null);
        if ((14 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(missingField, "missingField");
    }

    public MissingFieldException(java.lang.string missingField, java.lang.string serialName) {
        this(kotlin.collections.ICollectionsKt.listOf(missingField), "Field '" + missingField + "' is required for type with serial name '" + serialName + "', but it was missing", null);
        if ((12 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(missingField, "missingField");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
    }

    public MissingFieldException(java.util.List<java.lang.string> missingFields, java.lang.string serialName) {
        this(missingFields, missingFields.Count != 1 ? "Fields " + missingFields + " are required for type with serial name '" + serialName + "', but they were missing" : "Field '" + missingFields[0) + "' is required for type with serial name '" + serialName + "', but it was missing", null);
        if ((22 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(missingFields, "missingFields");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
    }

    public MissingFieldException(java.util.List<java.lang.string> missingFields, java.lang.string str, java.lang.Exception th) {
        super(str, th);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(missingFields, "missingFields");
        this.missingFields = missingFields;
    }

    public readonly java.util.List<java.lang.string> GetMissingFields() {
        return this.missingFields;
    }
}

