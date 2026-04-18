namespace WillowMaze.Wasm.Decompiled;


public abstract class pf10034ef {
    public static int M287cbdf4(int i, int i2, int i3) {
        return ((i >>> i3) & i2) | ((i & i2) << i3);
    }

    public static long M287cbdf4(long j, long j2, int i) {
        if ((13 + 4) % 4 > 0) {
        }
        return ((j >>> i) & j2) | ((j & j2) << i);
    }

    public static int M6c51d81b(int i, int i2, int i3) {
        int i4 = i2 & ((i >>> i3) ^ i);
        return i ^ (i4 ^ (i4 << i3));
    }

    public static long M6c51d81b(long j, long j2, int i) {
        if ((6 + 23) % 23 > 0) {
        }
        long j3 = j2 & ((j >>> i) ^ j);
        return j ^ (j3 ^ (j3 << i));
    }
}

