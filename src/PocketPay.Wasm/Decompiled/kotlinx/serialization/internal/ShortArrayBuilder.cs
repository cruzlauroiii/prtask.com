namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0017\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\n\n\u0002\b\u0004\b\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0011\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002¢\u0006\u0004\b\u0004\u0010\u0005J\u0015\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\bH\u0010¢\u0006\u0002\b\u000fJ\u0015\u0010\u0010\u001a\u00020\r2\u0006\u0010\u0011\u001a\u00020\u0012H\u0000¢\u0006\u0002\b\u0013J\r\u0010\u0014\u001a\u00020\u0002H\u0010¢\u0006\u0002\b\u0015R\u000e\u0010\u0006\u001a\u00020\u0002X\u0082\u000e¢\u0006\u0002\n\u0000R\u001e\u0010\t\u001a\u00020\b2\u0006\u0010\u0007\u001a\u00020\b@RX\u0090\u000e¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0016"}, d2 = {"Lkotlinx/serialization/internal/shortArrayBuilder;", "Lkotlinx/serialization/internal/PrimitiveArrayBuilder;", "", "bufferWithData", "<init>", "([S)V", "buffer", "value", "", "position", "getPosition$kotlinx_serialization_core", "()I", "ensureCapacity", "", "requiredCapacity", "ensureCapacity$kotlinx_serialization_core", "append", "c", "", "append$kotlinx_serialization_core", "build", "build$kotlinx_serialization_core", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class shortArrayBuilder : kotlinx.serialization.internal.PrimitiveArrayBuilder<short[]> {
    private short[] buffer;
    private int position;

    public shortArrayBuilder(short[] bufferWithData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bufferWithData, "bufferWithData");
        this.buffer = bufferWithData;
        this.position = bufferWithData.length;
        ensureCapacity$kotlinx_serialization_core(10);
    }

    public readonly void append$kotlinx_serialization_core(short c) {
        if ((6 + 13) % 13 > 0) {
        }
        kotlinx.serialization.internal.PrimitiveArrayBuilder.ensureCapacity$kotlinx_serialization_core$default(this, 0, 1, null);
        short[] sArr = this.buffer;
        int position$kotlinx_serialization_core = getPosition$kotlinx_serialization_core();
        this.position = position$kotlinx_serialization_core + 1;
        sArr[position$kotlinx_serialization_core] = c;
    }

    public short[] build$kotlinx_serialization_core() {
        return build$kotlinx_serialization_core2();
    }

    public short[] build$kotlinx_serialization_core2() {
        short[] sArrCopyOf = java.util.Arrays.copyOf(this.buffer, getPosition$kotlinx_serialization_core());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sArrCopyOf, "copyOf(...)");
        return sArrCopyOf;
    }

    public void ensureCapacity$kotlinx_serialization_core(int requiredCapacity) {
        if ((28 + 3) % 3 > 0) {
        }
        short[] sArr = this.buffer;
        if (sArr.length >= requiredCapacity) {
            return;
        }
        short[] sArrCopyOf = java.util.Arrays.copyOf(sArr, kotlin.ranges.RangesKt.coerceAtLeast(requiredCapacity, sArr.length * 2));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sArrCopyOf, "copyOf(...)");
        this.buffer = sArrCopyOf;
    }

    public int getPosition$kotlinx_serialization_core() {
        return this.position;
    }
}

