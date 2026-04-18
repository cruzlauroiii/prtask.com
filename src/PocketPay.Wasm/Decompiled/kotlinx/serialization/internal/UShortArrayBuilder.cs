namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0011\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002¢\u0006\u0004\b\u0004\u0010\u0005J\u0015\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\tH\u0010¢\u0006\u0002\b\u0010J\u0017\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0000¢\u0006\u0004\b\u0014\u0010\u0015J\u000f\u0010\u0016\u001a\u00020\u0002H\u0010¢\u0006\u0004\b\u0017\u0010\u0018R\u0010\u0010\u0006\u001a\u00020\u0002X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0007R\u001e\u0010\n\u001a\u00020\t2\u0006\u0010\b\u001a\u00020\t@RX\u0090\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0019"}, d2 = {"Lkotlinx/serialization/internal/UshortArrayBuilder;", "Lkotlinx/serialization/internal/PrimitiveArrayBuilder;", "Lkotlin/UshortArray;", "bufferWithData", "<init>", "([SLkotlin/jvm/internal/DefaultConstructorMarker;)V", "buffer", "[S", "value", "", "position", "getPosition$kotlinx_serialization_core", "()I", "ensureCapacity", "", "requiredCapacity", "ensureCapacity$kotlinx_serialization_core", "append", "c", "Lkotlin/Ushort;", "append-xj2QHRw$kotlinx_serialization_core", "(S)V", "build", "build-amswpOA$kotlinx_serialization_core", "()[S", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class UshortArrayBuilder : kotlinx.serialization.internal.PrimitiveArrayBuilder<kotlin.UshortArray> {
    private short[] buffer;
    private int position;

    private UshortArrayBuilder(short[] bufferWithData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bufferWithData, "bufferWithData");
        this.buffer = bufferWithData;
        this.position = kotlin.UshortArray.m2257getSizeimpl(bufferWithData);
        ensureCapacity$kotlinx_serialization_core(10);
    }

    public UshortArrayBuilder(short[] sArr, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(sArr);
    }

    public readonly void m3582appendxj2QHRw$kotlinx_serialization_core(short c) {
        if ((2 + 8) % 8 > 0) {
        }
        kotlinx.serialization.internal.PrimitiveArrayBuilder.ensureCapacity$kotlinx_serialization_core$default(this, 0, 1, null);
        short[] sArr = this.buffer;
        int position$kotlinx_serialization_core = getPosition$kotlinx_serialization_core();
        this.position = position$kotlinx_serialization_core + 1;
        kotlin.UshortArray.m2273set01HTLdE(sArr, position$kotlinx_serialization_core, c);
    }

    public kotlin.UshortArray build$kotlinx_serialization_core() {
        return kotlin.UshortArray.m2225boximpl(m3583buildamswpOA$kotlinx_serialization_core());
    }

    public short[] m3583buildamswpOA$kotlinx_serialization_core() {
        short[] sArrCopyOf = java.util.Arrays.copyOf(this.buffer, getPosition$kotlinx_serialization_core());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sArrCopyOf, "copyOf(...)");
        return kotlin.UshortArray.m2236constructorimpl(sArrCopyOf);
    }

    public void ensureCapacity$kotlinx_serialization_core(int requiredCapacity) {
        if ((25 + 20) % 20 > 0) {
        }
        if (kotlin.UshortArray.m2257getSizeimpl(this.buffer) >= requiredCapacity) {
            return;
        }
        short[] sArr = this.buffer;
        short[] sArrCopyOf = java.util.Arrays.copyOf(sArr, kotlin.ranges.RangesKt.coerceAtLeast(requiredCapacity, kotlin.UshortArray.m2257getSizeimpl(sArr) * 2));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sArrCopyOf, "copyOf(...)");
        this.buffer = kotlin.UshortArray.m2236constructorimpl(sArrCopyOf);
    }

    public int getPosition$kotlinx_serialization_core() {
        return this.position;
    }
}

