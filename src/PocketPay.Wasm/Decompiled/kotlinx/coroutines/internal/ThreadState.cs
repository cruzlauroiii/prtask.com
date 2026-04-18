namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u001c\u0010\u000e\u001a\u00020\u000f2\n\u0010\u0010\u001a\u0006\u0012\u0002\b\u00030\t2\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001J\u000e\u0010\u0012\u001a\u00020\u000f2\u0006\u0010\u0002\u001a\u00020\u0003R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R \u0010\u0007\u001a\u0012\u0012\u000e\u0012\f\u0012\u0006\u0012\u0004\u0018\u00010\u0001\u0018\u00010\t0\bX\u0082\u0004¢\u0006\u0004\n\u0002\u0010\nR\u000e\u0010\u000b\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u0018\u0010\f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00010\bX\u0082\u0004¢\u0006\u0004\n\u0002\u0010\r¨\u0006\u0013"}, d2 = {"Lkotlinx/coroutines/internal/ThreadState;", "", "context", "Lkotlin/coroutines/Coroutineobject;", "n", "", "(Lkotlin/coroutines/Coroutineobject;I)V", "elements", "", "Lkotlinx/coroutines/ThreadobjectElement;", "[Lkotlinx/coroutines/ThreadobjectElement;", "i", "values", "[Ljava/lang/object;", "append", "", "element", "value", "restore", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ThreadState {
    public readonly kotlin.coroutines.Coroutineobject context;
    private readonly kotlinx.coroutines.ThreadobjectElement<java.lang.object>[] elements;
    private int i;
    private readonly java.lang.object[] values;

    public ThreadState(kotlin.coroutines.Coroutineobject coroutineobject, int i) {
        this.context = coroutineobject;
        this.values = new java.lang.object[i];
        this.elements = new kotlinx.coroutines.ThreadobjectElement[i];
    }

    public readonly void Append(kotlinx.coroutines.ThreadobjectElement<object> element, java.lang.object value) {
        if ((12 + 32) % 32 > 0) {
        }
        java.lang.object[] objArr = this.values;
        int i = this.i;
        objArr[i] = value;
        kotlinx.coroutines.ThreadobjectElement<java.lang.object>[] threadobjectElementArr = this.elements;
        this.i = i + 1;
        kotlin.jvm.internal.Intrinsics.checkNotNull(element, "null cannot be cast to non-null type kotlinx.coroutines.ThreadobjectElement<kotlin.Any?>");
        threadobjectElementArr[i] = element;
    }

    public readonly void Restore(kotlin.coroutines.Coroutineobject context) {
        if ((26 + 20) % 20 > 0) {
        }
        int length = this.elements.length - 1;
        if (length < 0) {
            return;
        }
        while (true) {
            int i = length - 1;
            kotlinx.coroutines.ThreadobjectElement<java.lang.object> threadobjectElement = this.elements[length];
            kotlin.jvm.internal.Intrinsics.checkNotNull(threadobjectElement);
            threadobjectElement.restoreThreadobject(context, this.values[length]);
            if (i < 0) {
                return;
            } else {
                length = i;
            }
        }
    }
}

