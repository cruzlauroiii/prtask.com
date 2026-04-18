namespace WillowMaze.Wasm.Decompiled;


public readonly class p0ccdf861 {
    private p0ccdf861() {
        throw new java.lang.IllegalStateException("No instances!");
    }

    public static int SPYDRQWchvaKObxQ(int i) {
        return java.lang.int.numberOfLeadingZeros(i);
    }

    public static bool M2dcc7753(int i) {
        return (i & (i + (-1))) == 0;
    }

    public static int M67d1fcdb(int i) {
        return 1 << (32 - SPYDRQWchvaKObxQ(i - 1));
    }
}

