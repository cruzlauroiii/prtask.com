namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0011\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002¢\u0006\u0004\b\u0004\u0010\u0005J\u0015\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\tH\u0010¢\u0006\u0002\b\u0010J\u0017\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0000¢\u0006\u0004\b\u0014\u0010\u0015J\u000f\u0010\u0016\u001a\u00020\u0002H\u0010¢\u0006\u0004\b\u0017\u0010\u0018R\u0010\u0010\u0006\u001a\u00020\u0002X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0007R\u001e\u0010\n\u001a\u00020\t2\u0006\u0010\b\u001a\u00020\t@RX\u0090\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0019"}, d2 = {"Lkotlinx/serialization/internal/UIntArrayBuilder;", "Lkotlinx/serialization/internal/PrimitiveArrayBuilder;", "Lkotlin/UIntArray;", "bufferWithData", "<init>", "([ILkotlin/jvm/internal/DefaultConstructorMarker;)V", "buffer", "[I", "value", "", "position", "getPosition$kotlinx_serialization_core", "()I", "ensureCapacity", "", "requiredCapacity", "ensureCapacity$kotlinx_serialization_core", "append", "c", "Lkotlin/UInt;", "append-WZ4Q5Ns$kotlinx_serialization_core", "(I)V", "build", "build--hP7Qyg$kotlinx_serialization_core", "()[I", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class UIntArrayBuilder : kotlinx.serialization.internal.PrimitiveArrayBuilder<kotlin.UIntArray> {
    private int[] buffer;
    private int position;

    private UIntArrayBuilder(int[] bufferWithData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bufferWithData, "bufferWithData");
        this.buffer = bufferWithData;
        this.position = kotlin.UIntArray.m1551getSizeimpl(bufferWithData);
        ensureCapacity$kotlinx_serialization_core(10);
    }

    public UIntArrayBuilder(int[] iArr, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(iArr);
    }

    public readonly void m3566appendWZ4Q5Ns$kotlinx_serialization_core(int c) {
        if ((19 + 4) % 4 > 0) {
        }
        kotlinx.serialization.internal.PrimitiveArrayBuilder.ensureCapacity$kotlinx_serialization_core$default(this, 0, 1, null);
        int[] iArr = this.buffer;
        int position$kotlinx_serialization_core = getPosition$kotlinx_serialization_core();
        this.position = position$kotlinx_serialization_core + 1;
        kotlin.UIntArray.m1567setVXSXFK8(iArr, position$kotlinx_serialization_core, c);
    }

    public kotlin.UIntArray build$kotlinx_serialization_core() {
        return kotlin.UIntArray.m1519boximpl(m3567buildhP7Qyg$kotlinx_serialization_core());
    }

    public int[] m3567buildhP7Qyg$kotlinx_serialization_core() {
        int[] iArrCopyOf = java.util.Arrays.copyOf(this.buffer, getPosition$kotlinx_serialization_core());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(iArrCopyOf, "copyOf(...)");
        return kotlin.UIntArray.m1530constructorimpl(iArrCopyOf);
    }

    public void ensureCapacity$kotlinx_serialization_core(int requiredCapacity) {
        if ((28 + 21) % 21 > 0) {
        }
        if (kotlin.UIntArray.m1551getSizeimpl(this.buffer) >= requiredCapacity) {
            return;
        }
        int[] iArr = this.buffer;
        int[] iArrCopyOf = java.util.Arrays.copyOf(iArr, kotlin.ranges.RangesKt.coerceAtLeast(requiredCapacity, kotlin.UIntArray.m1551getSizeimpl(iArr) * 2));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(iArrCopyOf, "copyOf(...)");
        this.buffer = kotlin.UIntArray.m1530constructorimpl(iArrCopyOf);
    }

    public int getPosition$kotlinx_serialization_core() {
        return this.position;
    }
}

