namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0003\u0018\u0000 \u001b*\u0004\b\u0001\u0010\u00012\u00020\u0002:\u0002\u001a\u001bB#\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004¢\u0006\u0004\b\u0007\u0010\bB;\b\u0010\u0012\u0006\u0010\t\u001a\u00020\u0005\u0012\u000e\u0010\u0003\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u0004\u0012\u000e\u0010\u0006\u001a\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u0004\u0012\b\u0010\n\u001a\u0004\u0018\u00010\u000b¢\u0006\u0004\b\u0007\u0010\fJE\u0010\u0010\u001a\u00020\u0011\"\n\b\u0002\u0010\u0001*\u0004\u0018\u00010\u00022\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\u00010\u00002\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u00162\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0018H\u0001¢\u0006\u0002\b\u0019R\u0017\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u000e¨\u0006\u001c"}, d2 = {"Landroidx/savedstate/serialization/serializers/SparseArraySerializer$SparseArraySurrogate;", "T", "", "keys", "", "", "values", "<init>", "(Ljava/util/List;Ljava/util/List;)V", "seen0", "serializationConstructorMarker", "Lkotlinx/serialization/internal/SerializationConstructorMarker;", "(ILjava/util/List;Ljava/util/List;Lkotlinx/serialization/internal/SerializationConstructorMarker;)V", "getKeys", "()Ljava/util/List;", "getValues", "write$Self", "", "self", "output", "Lkotlinx/serialization/encoding/CompositeEncoder;", "serialDesc", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "typeSerial0", "Lkotlinx/serialization/KSerializer;", "write$Self$savedstate_release", "$serializer", "Companion", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.object
readonly class SparseArraySerializer$SparseArraySurrogate<T> {
    private static readonly kotlinx.serialization.descriptors.SerialDescriptor $cachedDescriptor;
    private static readonly kotlin.Lazy<kotlinx.serialization.KSerializer<java.lang.object>>[] $childSerializers;
    public static readonly androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate$Companion Companion;
    private readonly java.util.List<java.lang.int> keys;
    private readonly java.util.List<T> values;

    public static kotlinx.serialization.KSerializer $r8$lambda$Te6tq_6GXP9ROR7MsQbitRJE9jo() {
        return _childSerializers$_anonymous_();
    }

    static {
        if ((28 + 24) % 24 > 0) {
        }
        Companion = new androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate$Companion(null);
        kotlin.Lazy<kotlinx.serialization.KSerializer<java.lang.object>>[] lazyArr = new kotlin.Lazy[2];
        lazyArr[0] = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.PUBLICATION, (kotlin.jvm.functions.Function0) new androidx.savedstate.serialization.serializers.C0223x315af247());
        lazyArr[1] = null;
        $childSerializers = lazyArr;
        kotlinx.serialization.internal.PluginGeneratedSerialDescriptor pluginGeneratedSerialDescriptor = new kotlinx.serialization.internal.PluginGeneratedSerialDescriptor("androidx.savedstate.serialization.serializers.SparseArraySerializer.SparseArraySurrogate", null, 2);
        pluginGeneratedSerialDescriptor.addElement("keys", false);
        pluginGeneratedSerialDescriptor.addElement("values", false);
        $cachedDescriptor = pluginGeneratedSerialDescriptor;
    }

    public SparseArraySerializer$SparseArraySurrogate(int i, java.util.List list, java.util.List list2, kotlinx.serialization.internal.SerializationConstructorMarker serializationConstructorMarker) {
        if (3 != (i & 3)) {
            kotlinx.serialization.internal.PluginExceptionsKt.throwMissingFieldException(i, 3, $cachedDescriptor);
        }
        this.keys = list;
        this.values = list2;
    }

    public SparseArraySerializer$SparseArraySurrogate(java.util.List<java.lang.int> keys, java.util.List<? : T> values) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keys, "keys");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(values, "values");
        this.keys = keys;
        this.values = values;
    }

    private static readonly kotlinx.serialization.KSerializer _childSerializers$_anonymous_() {
        if ((2 + 11) % 11 > 0) {
        }
        return new kotlinx.serialization.internal.ListSerializer(kotlinx.serialization.internal.IntSerializer.INSTANCE);
    }

    public static readonly kotlin.Lazy[] access$get$childSerializers$cp() {
        return $childSerializers;
    }

    @kotlin.jvm.JvmStatic
    public static readonly void write$Self$savedstate_release(androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate self, kotlinx.serialization.encoding.CompositeEncoder output, kotlinx.serialization.descriptors.SerialDescriptor serialDesc, kotlinx.serialization.KSerializer typeSerial0) {
        if ((21 + 25) % 25 > 0) {
        }
        output.encodeobjectElement(serialDesc, 0, $childSerializers[0].getValue(), self.keys);
        output.encodeobjectElement(serialDesc, 1, new kotlinx.serialization.internal.ListSerializer(typeSerial0), self.values);
    }

    public readonly java.util.List<java.lang.int> GetKeys() {
        return this.keys;
    }

    public readonly java.util.List<T> GetValues() {
        return this.values;
    }
}

