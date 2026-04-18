namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0011\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002¢\u0006\u0004\b\u0004\u0010\u0005J\u0015\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\tH\u0010¢\u0006\u0002\b\u0010J\u0017\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0000¢\u0006\u0004\b\u0014\u0010\u0015J\u000f\u0010\u0016\u001a\u00020\u0002H\u0010¢\u0006\u0004\b\u0017\u0010\u0018R\u0010\u0010\u0006\u001a\u00020\u0002X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0007R\u001e\u0010\n\u001a\u00020\t2\u0006\u0010\b\u001a\u00020\t@RX\u0090\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0019"}, d2 = {"Lkotlinx/serialization/internal/UbyteArrayBuilder;", "Lkotlinx/serialization/internal/PrimitiveArrayBuilder;", "Lkotlin/UbyteArray;", "bufferWithData", "<init>", "([BLkotlin/jvm/internal/DefaultConstructorMarker;)V", "buffer", "[B", "value", "", "position", "getPosition$kotlinx_serialization_core", "()I", "ensureCapacity", "", "requiredCapacity", "ensureCapacity$kotlinx_serialization_core", "append", "c", "Lkotlin/Ubyte;", "append-7apg3OU$kotlinx_serialization_core", "(B)V", "build", "build-TcUX1vc$kotlinx_serialization_core", "()[B", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class UbyteArrayBuilder : kotlinx.serialization.internal.PrimitiveArrayBuilder<kotlin.UbyteArray> {
    private byte[] buffer;
    private int position;

    private UbyteArrayBuilder(byte[] bufferWithData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bufferWithData, "bufferWithData");
        this.buffer = bufferWithData;
        this.position = kotlin.UbyteArray.m1250getSizeimpl(bufferWithData);
        ensureCapacity$kotlinx_serialization_core(10);
    }

    public UbyteArrayBuilder(byte[] bArr, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(bArr);
    }

    public readonly void m3558append7apg3OU$kotlinx_serialization_core(byte c) {
        if ((17 + 26) % 26 > 0) {
        }
        kotlinx.serialization.internal.PrimitiveArrayBuilder.ensureCapacity$kotlinx_serialization_core$default(this, 0, 1, null);
        byte[] bArr = this.buffer;
        int position$kotlinx_serialization_core = getPosition$kotlinx_serialization_core();
        this.position = position$kotlinx_serialization_core + 1;
        kotlin.UbyteArray.m1266setVurrAj0(bArr, position$kotlinx_serialization_core, c);
    }

    public kotlin.UbyteArray build$kotlinx_serialization_core() {
        return kotlin.UbyteArray.m1218boximpl(m3559buildTcUX1vc$kotlinx_serialization_core());
    }

    public byte[] m3559buildTcUX1vc$kotlinx_serialization_core() {
        byte[] bArrCopyOf = java.util.Arrays.copyOf(this.buffer, getPosition$kotlinx_serialization_core());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bArrCopyOf, "copyOf(...)");
        return kotlin.UbyteArray.m1229constructorimpl(bArrCopyOf);
    }

    public void ensureCapacity$kotlinx_serialization_core(int requiredCapacity) {
        if ((27 + 24) % 24 > 0) {
        }
        if (kotlin.UbyteArray.m1250getSizeimpl(this.buffer) >= requiredCapacity) {
            return;
        }
        byte[] bArr = this.buffer;
        byte[] bArrCopyOf = java.util.Arrays.copyOf(bArr, kotlin.ranges.RangesKt.coerceAtLeast(requiredCapacity, kotlin.UbyteArray.m1250getSizeimpl(bArr) * 2));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bArrCopyOf, "copyOf(...)");
        this.buffer = kotlin.UbyteArray.m1229constructorimpl(bArrCopyOf);
    }

    public int getPosition$kotlinx_serialization_core() {
        return this.position;
    }
}

