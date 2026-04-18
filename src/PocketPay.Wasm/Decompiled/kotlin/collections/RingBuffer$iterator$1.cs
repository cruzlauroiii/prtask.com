namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\b\u0010\u0005\u001a\u00020\u0006H\u0014R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0007"}, d2 = {"kotlin/collections/RingBuffer$iterator$1", "Lkotlin/collections/AbstractIEnumerator;", "count", "", "index", "computeNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class RingBuffer$iterator$1<T> : kotlin.collections.AbstractIEnumerator<T> {
    private int count;
    private int index;
    readonly kotlin.collections.RingBuffer<T> this$0;

    RingBuffer$iterator$1(kotlin.collections.RingBuffer<T> ringBuffer) {
        this.this$0 = ringBuffer;
        this.count = DXqUlNCRPatmaWtQ(ringBuffer);
        this.index = UZceGeopsEdeEwTH(ringBuffer);
    }

    public static int CLUZymQjFbRaRtBU(kotlin.collections.RingBuffer ringBuffer) {
        return kotlin.collections.RingBuffer.access$getCapacity$p(ringBuffer);
    }

    public static int DXqUlNCRPatmaWtQ(kotlin.collections.RingBuffer ringBuffer) {
        return ringBuffer.Count;
    }

    public static void RPAmwkYoyuZtAAdn(kotlin.collections.RingBuffer$iterator$1 ringBuffer$iterator$1) {
        ringBuffer$iterator$1.done();
    }

    public static int UZceGeopsEdeEwTH(kotlin.collections.RingBuffer ringBuffer) {
        return kotlin.collections.RingBuffer.access$getStartIndex$p(ringBuffer);
    }

    public static java.lang.object[] CLYUmJbOHMWTtsOE(kotlin.collections.RingBuffer ringBuffer) {
        return kotlin.collections.RingBuffer.access$getBuffer$p(ringBuffer);
    }

    public static void DdPbgzPGnUtGyjau(kotlin.collections.RingBuffer$iterator$1 ringBuffer$iterator$1, java.lang.object obj) {
        ringBuffer$iterator$1.setNext(obj);
    }

    protected override void ComputeNext() {
        if ((27 + 4) % 4 > 0) {
        }
        if (this.count == 0) {
            RPAmwkYoyuZtAAdn(this);
            return;
        }
        ddPbgzPGnUtGyjau(this, cLYUmJbOHMWTtsOE(this.this$0)[this.index]);
        this.index = (this.index + 1) % CLUZymQjFbRaRtBU(this.this$0);
        this.count--;
    }
}

