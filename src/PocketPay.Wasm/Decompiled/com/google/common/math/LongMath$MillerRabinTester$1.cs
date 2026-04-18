namespace WillowMaze.Wasm.Decompiled;


readonly enum longMath$MillerRabinTester$1 : com.google.common.math.longMath$MillerRabinTester {
    longMath$MillerRabinTester$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    long mulMod(long j, long j2, long j3) {
        return (j * j2) % j3;
    }

    long squareMod(long j, long j2) {
        return (j * j) % j2;
    }
}

