namespace WillowMaze.Wasm.Decompiled;


abstract class p561f0331$pd57d920c {
    protected readonly long[] f048685d9;
    protected readonly long[] f8367f3cb;
    protected readonly long[] fa7ef7678;
    protected readonly long[] fcb67c0d2;
    protected readonly long[] fe358efa4;
    protected readonly long[] febefb158;
    protected readonly long[] ffc51cea3;

    protected p561f0331$pd57d920c(long[] jArr, long[] jArr2) {
        this.f048685d9 = jArr;
        this.fe358efa4 = jArr2;
    }

    abstract void DecryptBlock(long[] jArr, long[] jArr2);

    abstract void EncryptBlock(long[] jArr, long[] jArr2);
}

