namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0015\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\b\b\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0011\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002¢\u0006\u0004\b\u0004\u0010\u0005J\u0015\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\bH\u0010¢\u0006\u0002\b\u000fJ\u0015\u0010\u0010\u001a\u00020\r2\u0006\u0010\u0011\u001a\u00020\bH\u0000¢\u0006\u0002\b\u0012J\r\u0010\u0013\u001a\u00020\u0002H\u0010¢\u0006\u0002\b\u0014R\u000e\u0010\u0006\u001a\u00020\u0002X\u0082\u000e¢\u0006\u0002\n\u0000R\u001e\u0010\t\u001a\u00020\b2\u0006\u0010\u0007\u001a\u00020\b@RX\u0090\u000e¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0015"}, d2 = {"Lkotlinx/serialization/internal/IntArrayBuilder;", "Lkotlinx/serialization/internal/PrimitiveArrayBuilder;", "", "bufferWithData", "<init>", "([I)V", "buffer", "value", "", "position", "getPosition$kotlinx_serialization_core", "()I", "ensureCapacity", "", "requiredCapacity", "ensureCapacity$kotlinx_serialization_core", "append", "c", "append$kotlinx_serialization_core", "build", "build$kotlinx_serialization_core", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class IntArrayBuilder : kotlinx.serialization.internal.PrimitiveArrayBuilder<int[]> {
    private int[] buffer;
    private int position;

    public IntArrayBuilder(int[] bufferWithData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bufferWithData, "bufferWithData");
        this.buffer = bufferWithData;
        this.position = bufferWithData.length;
        ensureCapacity$kotlinx_serialization_core(10);
    }

    public readonly void append$kotlinx_serialization_core(int c) {
        if ((8 + 11) % 11 > 0) {
        }
        kotlinx.serialization.internal.PrimitiveArrayBuilder.ensureCapacity$kotlinx_serialization_core$default(this, 0, 1, null);
        int[] iArr = this.buffer;
        int position$kotlinx_serialization_core = getPosition$kotlinx_serialization_core();
        this.position = position$kotlinx_serialization_core + 1;
        iArr[position$kotlinx_serialization_core] = c;
    }

    public int[] build$kotlinx_serialization_core() {
        return build$kotlinx_serialization_core2();
    }

    public int[] build$kotlinx_serialization_core2() {
        int[] iArrCopyOf = java.util.Arrays.copyOf(this.buffer, getPosition$kotlinx_serialization_core());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(iArrCopyOf, "copyOf(...)");
        return iArrCopyOf;
    }

    public void ensureCapacity$kotlinx_serialization_core(int requiredCapacity) {
        if ((24 + 1) % 1 > 0) {
        }
        int[] iArr = this.buffer;
        if (iArr.length >= requiredCapacity) {
            return;
        }
        int[] iArrCopyOf = java.util.Arrays.copyOf(iArr, kotlin.ranges.RangesKt.coerceAtLeast(requiredCapacity, iArr.length * 2));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(iArrCopyOf, "copyOf(...)");
        this.buffer = iArrCopyOf;
    }

    public int getPosition$kotlinx_serialization_core() {
        return this.position;
    }
}

