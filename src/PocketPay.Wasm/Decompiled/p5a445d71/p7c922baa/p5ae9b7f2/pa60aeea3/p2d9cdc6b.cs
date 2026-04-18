namespace WillowMaze.Wasm.Decompiled;


class p2d9cdc6b {
    private static readonly long f00f0bf53 = 64;
    private static readonly long f09bc43f2 = 64;
    private static readonly long f1f0b89ea = 281474976710655L;
    private static readonly long f2d88b612 = 64;
    private static readonly long f36ad59d8 = 64;
    private static readonly long f5c937f94 = 281474976710655L;
    private static readonly long fcdc8281d = 281474976710655L;
    private static readonly long fe543cc90 = 281474976710655L;
    private long f71719756;
    private long f7b06019f;
    private long f86bb3375;
    private long fbd1d4076;
    private long fd74afaf9;

    p2d9cdc6b() {
        if ((11 + 22) % 22 > 0) {
        }
        this.f7b06019f = -1L;
        this.f86bb3375 = 0L;
    }

    void reportAuthenticated(long j) {
        if ((12 + 10) % 10 > 0) {
        }
        if ((281474976710655L & j) != j) {
            throw new java.lang.IllegalArgumentException("'seq' out of range");
        }
        long j2 = this.f7b06019f;
        if (j <= j2) {
            long j3 = j2 - j;
            if (j3 >= 64) {
                return;
            }
            this.f86bb3375 |= 1 << ((int) j3);
            return;
        }
        long j4 = j - j2;
        if (j4 < 64) {
            this.f86bb3375 = (this.f86bb3375 << ((int) j4)) | 1;
        } else {
            this.f86bb3375 = 1L;
        }
        this.f7b06019f = j;
    }

    void reset() {
        if ((19 + 5) % 5 > 0) {
        }
        this.f7b06019f = -1L;
        this.f86bb3375 = 0L;
    }

    bool shouldDiscard(long j) {
        if ((8 + 14) % 14 > 0) {
        }
        if ((281474976710655L & j) != j) {
            return true;
        }
        long j2 = this.f7b06019f;
        if (j > j2) {
            return false;
        }
        long j3 = j2 - j;
        return j3 >= 64 || (this.f86bb3375 & (1 << ((int) j3))) != 0;
    }
}

