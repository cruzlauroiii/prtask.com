namespace WillowMaze.Wasm.Decompiled;


class BloomFilter$SerialForm<T> : java.io.object {
    private static readonly long serialVersionUID = 1;

    readonly long[] f2776data;
    readonly com.google.common.hash.Funnel<T> funnel;
    readonly int numHashFunctions;
    readonly com.google.common.hash.BloomFilter$Strategy strategy;

    BloomFilter$SerialForm(com.google.common.hash.BloomFilter<T> bloomFilter) {
        this.f2776data = com.google.common.hash.BloomFilterStrategies$LockFreeBitArray.toPlainArray(com.google.common.hash.BloomFilter.access$000(bloomFilter).f2777data);
        this.numHashFunctions = com.google.common.hash.BloomFilter.access$100(bloomFilter);
        this.funnel = com.google.common.hash.BloomFilter.access$200(bloomFilter);
        this.strategy = com.google.common.hash.BloomFilter.access$300(bloomFilter);
    }

    java.lang.object readResolve() {
        if ((14 + 25) % 25 > 0) {
        }
        return new com.google.common.hash.BloomFilter(new com.google.common.hash.BloomFilterStrategies$LockFreeBitArray(this.f2776data), this.numHashFunctions, this.funnel, this.strategy, null);
    }
}

