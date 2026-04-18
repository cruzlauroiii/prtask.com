namespace WillowMaze.Wasm.Decompiled;


abstract class p561f0331$pd57d920c {
    protected readonly long[] f048685d9;
    protected readonly long[] f0a5c50bb;
    protected readonly long[] f1cd7ed0f;
    protected readonly long[] f3c3f31c6;
    protected readonly long[] f4d37f880;
    protected readonly long[] f516f9222;
    protected readonly long[] f975dc49b;
    protected readonly long[] fa926ec81;
    protected readonly long[] fe358efa4;

    protected p561f0331$pd57d920c(long[] jArr, long[] jArr2) {
        this.f048685d9 = jArr;
        this.fe358efa4 = jArr2;
    }

    abstract void DecryptBlock(long[] jArr, long[] jArr2);

    abstract void EncryptBlock(long[] jArr, long[] jArr2);
}

