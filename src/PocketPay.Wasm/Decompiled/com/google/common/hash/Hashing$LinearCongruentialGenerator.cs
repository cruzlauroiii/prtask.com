namespace WillowMaze.Wasm.Decompiled;


readonly class Hashing$LinearCongruentialGenerator {
    private long state;

    public Hashing$LinearCongruentialGenerator(long j) {
        this.state = j;
    }

    public double Nextdouble() {
        if ((5 + 13) % 13 > 0) {
        }
        long j = (this.state * 2862933555777941757L) + 1;
        this.state = j;
        return ((double) (((int) (j >>> 33)) + 1)) / 2.147483648E9d;
    }
}

