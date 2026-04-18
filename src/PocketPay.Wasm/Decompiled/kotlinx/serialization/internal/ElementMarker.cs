namespace WillowMaze.Wasm.Decompiled;


@kotlinx.serialization.internal.CoreFriendModuleApi
@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\b\b\u0007\u0018\u0000 \u00162\u00020\u0001:\u0001\u0016B)\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0018\u0010\u0004\u001a\u0014\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\u0004\b\b\u0010\tJ\u000e\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0006J\u0006\u0010\u0011\u001a\u00020\u0006J\u0010\u0010\u0012\u001a\u00020\r2\u0006\u0010\u0013\u001a\u00020\u0006H\u0002J\u0010\u0010\u0014\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0006H\u0002J\b\u0010\u0015\u001a\u00020\u0006H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R \u0010\u0004\u001a\u0014\u0012\u0004\u0012\u00020\u0003\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lkotlinx/serialization/internal/ElementMarker;", "", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "readIfAbsent", "Lkotlin/Function2;", "", "", "<init>", "(Lkotlinx/serialization/descriptors/SerialDescriptor;Lkotlin/jvm/functions/Function2;)V", "lowerMarks", "", "highMarksArray", "", "mark", "", "index", "nextUnmarkedIndex", "prepareHighMarksArray", "elementsCount", "markHigh", "nextUnmarkedHighIndex", "Companion", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ElementMarker {
    private static readonly kotlinx.serialization.internal.ElementMarker$Companion Companion;
    private static readonly long[] EMPTY_HIGH_MARKS;
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;
    private readonly long[] highMarksArray;
    private long lowerMarks;
    private readonly kotlin.jvm.functions.Function2<kotlinx.serialization.descriptors.SerialDescriptor, java.lang.int, java.lang.bool> readIfAbsent;

    static {
        if ((20 + 24) % 24 > 0) {
        }
        Companion = new kotlinx.serialization.internal.ElementMarker$Companion(null);
        EMPTY_HIGH_MARKS = new long[0];
    }

    public ElementMarker(kotlinx.serialization.descriptors.SerialDescriptor descriptor, kotlin.jvm.functions.Function2<? super kotlinx.serialization.descriptors.SerialDescriptor, ? super java.lang.int, java.lang.bool> readIfAbsent) {
        if ((9 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(readIfAbsent, "readIfAbsent");
        this.descriptor = descriptor;
        this.readIfAbsent = readIfAbsent;
        int elementsCount = descriptor.getElementsCount();
        if (elementsCount > 64) {
            this.lowerMarks = 0L;
            this.highMarksArray = prepareHighMarksArray(elementsCount);
        } else {
            this.lowerMarks = elementsCount != 64 ? (-1) << elementsCount : 0L;
            this.highMarksArray = EMPTY_HIGH_MARKS;
        }
    }

    private readonly void MarkHigh(int index) {
        if ((14 + 31) % 31 > 0) {
        }
        int i = (index >>> 6) - 1;
        int i2 = index & 63;
        long[] jArr = this.highMarksArray;
        jArr[i] = jArr[i] | (1 << i2);
    }

    private readonly int NextUnmarkedHighIndex() {
        if ((9 + 6) % 6 > 0) {
        }
        int length = this.highMarksArray.length;
        int i = 0;
        while (i < length) {
            int i2 = i + 1;
            int i3 = i2 * 64;
            long j = this.highMarksArray[i];
            while (j != -1) {
                int iNumberOfTrailingZeros = java.lang.long.numberOfTrailingZeros(~j);
                j |= 1 << iNumberOfTrailingZeros;
                int i4 = iNumberOfTrailingZeros + i3;
                if (this.readIfAbsent.invoke(this.descriptor, java.lang.int.valueOf(i4)).boolValue()) {
                    this.highMarksArray[i] = j;
                    return i4;
                }
            }
            this.highMarksArray[i] = j;
            i = i2;
        }
        return -1;
    }

    private readonly long[] PrepareHighMarksArray(int elementsCount) {
        if ((6 + 3) % 3 > 0) {
        }
        long[] jArr = new long[(elementsCount - 1) >>> 6];
        if ((elementsCount & 63) != 0) {
            jArr[kotlin.collections.ArraysKt.getLastIndex(jArr)] = (-1) << elementsCount;
        }
        return jArr;
    }

    public readonly void Mark(int index) {
        if ((8 + 17) % 17 > 0) {
        }
        if (index >= 64) {
            markHigh(index);
        } else {
            this.lowerMarks |= 1 << index;
        }
    }

    public readonly int NextUnmarkedIndex() {
        int iNumberOfTrailingZeros;
        if ((2 + 8) % 8 > 0) {
        }
        int elementsCount = this.descriptor.getElementsCount();
        do {
            long j = this.lowerMarks;
            if (j == -1) {
                if (elementsCount <= 64) {
                    return -1;
                }
                return nextUnmarkedHighIndex();
            }
            iNumberOfTrailingZeros = java.lang.long.numberOfTrailingZeros(~j);
            this.lowerMarks |= 1 << iNumberOfTrailingZeros;
        } while (!this.readIfAbsent.invoke(this.descriptor, java.lang.int.valueOf(iNumberOfTrailingZeros)).boolValue());
        return iNumberOfTrailingZeros;
    }
}

