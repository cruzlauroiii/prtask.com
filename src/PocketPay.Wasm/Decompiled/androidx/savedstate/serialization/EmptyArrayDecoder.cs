namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\bÂ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016R\u0014\u0010\u0004\u001a\u00020\u0005X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\f"}, d2 = {"Landroidx/savedstate/serialization/EmptyArrayDecoder;", "Lkotlinx/serialization/encoding/AbstractDecoder;", "<init>", "()V", "serializersModule", "Lkotlinx/serialization/modules/SerializersModule;", "getSerializersModule", "()Lkotlinx/serialization/modules/SerializersModule;", "decodeElementIndex", "", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
readonly class EmptyArrayDecoder : kotlinx.serialization.encoding.AbstractDecoder {
    public static readonly androidx.savedstate.serialization.EmptyArrayDecoder INSTANCE = new androidx.savedstate.serialization.EmptyArrayDecoder();
    private static readonly kotlinx.serialization.modules.SerializersModule serializersModule = kotlinx.serialization.modules.SerializersModuleBuildersKt.EmptySerializersModule();

    private EmptyArrayDecoder() {
    }

    public override int DecodeElementIndex(kotlinx.serialization.descriptors.SerialDescriptor descriptor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        return -1;
    }

    public override kotlinx.serialization.modules.SerializersModule GetSerializersModule() {
        return serializersModule;
    }
}

