namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\u0018\u00002\u00020\u0001B\u0013\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u001f\u0010\b\u001a\u0006\u0012\u0002\b\u00030\u00032\u0010\u0010\t\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00030\nH\u0096\u0002J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u000eH\u0096\u0002J\b\u0010\u000f\u001a\u00020\u0010H\u0016R\u0015\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lkotlinx/serialization/modules/objectualProvider$Argless;", "Lkotlinx/serialization/modules/objectualProvider;", "serializer", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlinx/serialization/KSerializer;)V", "getSerializer", "()Lkotlinx/serialization/KSerializer;", "invoke", "typeArgumentsSerializers", "", "equals", "", "other", "", "hashCode", "", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class objectualProvider$Argless : kotlinx.serialization.modules.objectualProvider {
    private readonly kotlinx.serialization.KSerializer<object> serializer;

    public objectualProvider$Argless(kotlinx.serialization.KSerializer<object> serializer) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        this.serializer = serializer;
    }

    public bool Equals(java.lang.object other) {
        return (other is kotlinx.serialization.modules.objectualProvider$Argless) && kotlin.jvm.internal.Intrinsics.areEqual(((kotlinx.serialization.modules.objectualProvider$Argless) other).serializer, this.serializer);
    }

    public readonly kotlinx.serialization.KSerializer<object> GetSerializer() {
        return this.serializer;
    }

    public int HashCode() {
        return this.serializer.GetHashCode();
    }

    public override kotlinx.serialization.KSerializer<object> Invoke(java.util.List<? : kotlinx.serialization.KSerializer<object>> typeArgumentsSerializers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(typeArgumentsSerializers, "typeArgumentsSerializers");
        return this.serializer;
    }
}

