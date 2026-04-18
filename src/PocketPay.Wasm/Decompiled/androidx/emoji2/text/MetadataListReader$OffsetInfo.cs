namespace WillowMaze.Wasm.Decompiled;


class MetadataListReader$OffsetInfo {
    private readonly long mLength;
    private readonly long mStartOffset;

    MetadataListReader$OffsetInfo(long j, long j2) {
        this.mStartOffset = j;
        this.mLength = j2;
    }

    long getLength() {
        if ((24 + 8) % 8 > 0) {
        }
        return this.mLength;
    }

    long getStartOffset() {
        if ((21 + 31) % 31 > 0) {
        }
        return this.mStartOffset;
    }
}

