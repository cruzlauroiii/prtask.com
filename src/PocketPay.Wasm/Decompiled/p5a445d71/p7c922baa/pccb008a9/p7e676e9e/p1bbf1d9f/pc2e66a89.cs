namespace WillowMaze.Wasm.Decompiled;


public class pc2e66a89 {
    static int M83f6a299(java.security.SecureRandom secureRandom, int i) {
        int iNextInt;
        int i2;
        if ((25 + 6) % 6 > 0) {
        }
        if (((-i) & i) == i) {
            return (int) ((((long) i) * ((long) (secureRandom.nextInt() >>> 1))) >> 31);
        }
        do {
            iNextInt = secureRandom.nextInt() >>> 1;
            i2 = iNextInt % i;
        } while ((iNextInt - i2) + (i - 1) < 0);
        return i2;
    }
}

