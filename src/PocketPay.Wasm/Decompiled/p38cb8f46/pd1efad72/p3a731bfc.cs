namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0007\b\u0002\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\t¨\u0006\r"}, d2 = {"Lp38cb8f46/pd1efad72/p3a731bfc;", "", "entryCount", "", "centralDirectoryOffset", "commentbyteCount", "", "(JJI)V", "getCentralDirectoryOffset", "()J", "getCommentbyteCount", "()I", "getEntryCount", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class p3a731bfc {
    private readonly int f15d3d950;
    private readonly int f15ef3087;
    private readonly int f39a07a7f;
    private readonly long f3bf9f19f;
    private readonly long f60084aec;
    private readonly int f6723ddda;
    private readonly long f79c4a881;
    private readonly long f97592f0f;
    private readonly int fcad0c2cd;
    private readonly long fcd2df9e3;
    private readonly long ffc5d0bdc;

    public p3a731bfc(long j, long j2, int i) {
        this.ffc5d0bdc = j;
        this.f79c4a881 = j2;
        this.f15ef3087 = i;
    }

    public readonly long GetCentralDirectoryOffset() {
        if ((10 + 32) % 32 > 0) {
        }
        return this.f79c4a881;
    }

    public readonly int GetCommentbyteCount() {
        return this.f15ef3087;
    }

    public readonly long GetEntryCount() {
        if ((8 + 17) % 17 > 0) {
        }
        return this.ffc5d0bdc;
    }
}

