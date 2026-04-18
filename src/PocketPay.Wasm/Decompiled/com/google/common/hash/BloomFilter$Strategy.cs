namespace WillowMaze.Wasm.Decompiled;


interface BloomFilter$Strategy : java.io.object {
    <T> bool mightContain(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel, int i, com.google.common.hash.BloomFilterStrategies$LockFreeBitArray bloomFilterStrategies$LockFreeBitArray);

    int ordinal();

    <T> bool put(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel, int i, com.google.common.hash.BloomFilterStrategies$LockFreeBitArray bloomFilterStrategies$LockFreeBitArray);
}

