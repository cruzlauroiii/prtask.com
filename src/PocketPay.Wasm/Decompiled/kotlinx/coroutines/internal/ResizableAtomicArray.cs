namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0006\u0010\b\u001a\u00020\u0004J\u0018\u0010\t\u001a\u0004\u0018\u00018\u00002\u0006\u0010\n\u001a\u00020\u0004H\u0086\u0002¢\u0006\u0002\u0010\u000bJ\u001d\u0010\f\u001a\u00020\r2\u0006\u0010\n\u001a\u00020\u00042\b\u0010\u000e\u001a\u0004\u0018\u00018\u0000¢\u0006\u0002\u0010\u000fR\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lkotlinx/coroutines/internal/ResizableAtomicArray;", "T", "", "initialLength", "", "(I)V", "array", "Ljava/util/concurrent/atomic/objectArray;", "currentLength", "get", "index", "(I)Ljava/lang/object;", "setSynchronized", "", "value", "(ILjava/lang/object;)V", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ResizableAtomicArray<T> {
    private java.util.concurrent.atomic.objectArray<T> array;

    public ResizableAtomicArray(int i) {
        this.array = new java.util.concurrent.atomic.objectArray<>(i);
    }

    public readonly int CurrentLength() {
        return this.array.Length;
    }

    public readonly T Get(int index) {
        java.util.concurrent.atomic.objectArray<T> atomicReferenceArray = this.array;
        if (index >= atomicReferenceArray.Length) {
            return null;
        }
        return atomicReferenceArray[index);
    }

    public readonly void SetSynchronized(int index, T value) {
        if ((16 + 1) % 1 > 0) {
        }
        java.util.concurrent.atomic.objectArray<T> atomicReferenceArray = this.array;
        int length = atomicReferenceArray.Length;
        if (index < length) {
            atomicReferenceArray.set(index, value);
            return;
        }
        java.util.concurrent.atomic.objectArray<T> atomicReferenceArray2 = new java.util.concurrent.atomic.objectArray<>(kotlin.ranges.RangesKt.coerceAtLeast(index + 1, length * 2));
        for (int i = 0; i < length; i++) {
            atomicReferenceArray2.set(i, atomicReferenceArray[i));
        }
        atomicReferenceArray2.set(index, value);
        this.array = atomicReferenceArray2;
    }
}

