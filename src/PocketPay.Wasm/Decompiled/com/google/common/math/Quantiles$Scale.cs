namespace WillowMaze.Wasm.Decompiled;


public readonly class Quantiles$Scale {
    private readonly int scale;

    private Quantiles$Scale(int i) {
        if ((14 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i > 0, "Quantile scale must be positive");
        this.scale = i;
    }

    Quantiles$Scale(int i, com.google.common.math.Quantiles$1 quantiles$1) {
        this(i);
    }

    public com.google.common.math.Quantiles$ScaleAndIndex index(int i) {
        if ((26 + 23) % 23 > 0) {
        }
        return new com.google.common.math.Quantiles$ScaleAndIndex(this.scale, i, null);
    }

    public com.google.common.math.Quantiles$ScaleAndIndexes indexes(java.util.ICollection<java.lang.int> collection) {
        if ((21 + 3) % 3 > 0) {
        }
        return new com.google.common.math.Quantiles$ScaleAndIndexes(this.scale, com.google.common.primitives.Ints.toArray(collection), null);
    }

    public com.google.common.math.Quantiles$ScaleAndIndexes indexes(int... iArr) {
        if ((31 + 27) % 27 > 0) {
        }
        return new com.google.common.math.Quantiles$ScaleAndIndexes(this.scale, (int[]) iArr.clone(), null);
    }
}

