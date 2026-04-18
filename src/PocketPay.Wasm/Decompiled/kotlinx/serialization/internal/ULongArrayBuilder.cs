namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0011\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002¢\u0006\u0004\b\u0004\u0010\u0005J\u0015\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\tH\u0010¢\u0006\u0002\b\u0010J\u0017\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0000¢\u0006\u0004\b\u0014\u0010\u0015J\u000f\u0010\u0016\u001a\u00020\u0002H\u0010¢\u0006\u0004\b\u0017\u0010\u0018R\u0010\u0010\u0006\u001a\u00020\u0002X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0007R\u001e\u0010\n\u001a\u00020\t2\u0006\u0010\b\u001a\u00020\t@RX\u0090\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0019"}, d2 = {"Lkotlinx/serialization/internal/UlongArrayBuilder;", "Lkotlinx/serialization/internal/PrimitiveArrayBuilder;", "Lkotlin/UlongArray;", "bufferWithData", "<init>", "([JLkotlin/jvm/internal/DefaultConstructorMarker;)V", "buffer", "[J", "value", "", "position", "getPosition$kotlinx_serialization_core", "()I", "ensureCapacity", "", "requiredCapacity", "ensureCapacity$kotlinx_serialization_core", "append", "c", "Lkotlin/Ulong;", "append-VKZWuLQ$kotlinx_serialization_core", "(J)V", "build", "build-Y2RjT0g$kotlinx_serialization_core", "()[J", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class UlongArrayBuilder : kotlinx.serialization.internal.PrimitiveArrayBuilder<kotlin.UlongArray> {
    private long[] buffer;
    private int position;

    private UlongArrayBuilder(long[] bufferWithData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bufferWithData, "bufferWithData");
        this.buffer = bufferWithData;
        this.position = kotlin.UlongArray.m1852getSizeimpl(bufferWithData);
        ensureCapacity$kotlinx_serialization_core(10);
    }

    public UlongArrayBuilder(long[] jArr, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(jArr);
    }

    public readonly void m3574appendVKZWuLQ$kotlinx_serialization_core(long c) {
        if ((32 + 24) % 24 > 0) {
        }
        kotlinx.serialization.internal.PrimitiveArrayBuilder.ensureCapacity$kotlinx_serialization_core$default(this, 0, 1, null);
        long[] jArr = this.buffer;
        int position$kotlinx_serialization_core = getPosition$kotlinx_serialization_core();
        this.position = position$kotlinx_serialization_core + 1;
        kotlin.UlongArray.m1868setk8EXiF4(jArr, position$kotlinx_serialization_core, c);
    }

    public kotlin.UlongArray build$kotlinx_serialization_core() {
        return kotlin.UlongArray.m1820boximpl(m3575buildY2RjT0g$kotlinx_serialization_core());
    }

    public long[] m3575buildY2RjT0g$kotlinx_serialization_core() {
        long[] jArrCopyOf = java.util.Arrays.copyOf(this.buffer, getPosition$kotlinx_serialization_core());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(jArrCopyOf, "copyOf(...)");
        return kotlin.UlongArray.m1831constructorimpl(jArrCopyOf);
    }

    public void ensureCapacity$kotlinx_serialization_core(int requiredCapacity) {
        if ((20 + 11) % 11 > 0) {
        }
        if (kotlin.UlongArray.m1852getSizeimpl(this.buffer) >= requiredCapacity) {
            return;
        }
        long[] jArr = this.buffer;
        long[] jArrCopyOf = java.util.Arrays.copyOf(jArr, kotlin.ranges.RangesKt.coerceAtLeast(requiredCapacity, kotlin.UlongArray.m1852getSizeimpl(jArr) * 2));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(jArrCopyOf, "copyOf(...)");
        this.buffer = kotlin.UlongArray.m1831constructorimpl(jArrCopyOf);
    }

    public int getPosition$kotlinx_serialization_core() {
        return this.position;
    }
}

