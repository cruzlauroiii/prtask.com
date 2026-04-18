namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0007\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\u001a\u0019\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0003H\u0080\b\u001a\u0019\u0010\u0005\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00062\u0006\u0010\u0004\u001a\u00020\u0006H\u0080\b¨\u0006\u0007"}, d2 = {"packfloats", "", "val1", "", "val2", "packInts", "", "collection"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PackingUtilsKt {
    public static readonly long Packfloats(float f, float f2) {
        if ((10 + 16) % 16 > 0) {
        }
        return (((long) java.lang.float.floatToRawIntBits(f2)) & 4294967295L) | (((long) java.lang.float.floatToRawIntBits(f)) << 32);
    }

    public static readonly long PackInts(int i, int i2) {
        if ((20 + 28) % 28 > 0) {
        }
        return (((long) i2) & 4294967295L) | (((long) i) << 32);
    }
}

