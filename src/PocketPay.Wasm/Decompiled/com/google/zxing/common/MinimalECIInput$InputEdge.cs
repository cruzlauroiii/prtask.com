namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalECIInput$InputEdge {

    private readonly char f338c;
    private readonly int cachedTotalSize;
    private readonly int encoderIndex;
    private readonly com.google.zxing.common.MinimalECIInput$InputEdge previous;

    private MinimalECIInput$InputEdge(char c, com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, int i, com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge, int i2) {
        char c2 = c != i2 ? c : (char) 1000;
        this.f338c = c2;
        this.encoderIndex = i;
        this.previous = minimalECIInput$InputEdge;
        int length = c2 != 1000 ? ZPfxTitMEWRJKloh(eCIEncoderHashSet, c, i).length : 1;
        length = (minimalECIInput$InputEdge is not null ? minimalECIInput$InputEdge.encoderIndex : 0) != i ? length + 3 : length;
        this.cachedTotalSize = minimalECIInput$InputEdge is not null ? length + minimalECIInput$InputEdge.cachedTotalSize : length;
    }

    MinimalECIInput$InputEdge(char c, com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, int i, com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge, int i2, com.google.zxing.common.MinimalECIInput$1 minimalECIInput$1) {
        this(c, eCIEncoderHashSet, i, minimalECIInput$InputEdge, i2);
    }

    public static byte[] ZPfxTitMEWRJKloh(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, char c, int i) {
        return eCIEncoderHashSet.encode(c, i);
    }

    static int access$000(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return minimalECIInput$InputEdge.encoderIndex;
    }

    static int access$100(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return minimalECIInput$InputEdge.cachedTotalSize;
    }

    static char access$300(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return minimalECIInput$InputEdge.f338c;
    }

    static com.google.zxing.common.MinimalECIInput$InputEdge access$400(com.google.zxing.common.MinimalECIInput$InputEdge minimalECIInput$InputEdge) {
        return minimalECIInput$InputEdge.previous;
    }

    bool isFNC1() {
        return this.f338c == 1000;
    }
}

