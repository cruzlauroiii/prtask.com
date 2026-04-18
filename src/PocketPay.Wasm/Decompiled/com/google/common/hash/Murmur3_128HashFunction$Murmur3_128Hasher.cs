namespace WillowMaze.Wasm.Decompiled;


readonly class Murmur3_128HashFunction$Murmur3_128Hasher : com.google.common.hash.AbstractStreamingHasher {
    private static readonly long C1 = -8663945395140668459L;
    private static readonly long C2 = 5545529020109919103L;
    private static readonly int CHUNK_SIZE = 16;
    private long h1;
    private long h2;
    private int length;

    Murmur3_128HashFunction$Murmur3_128Hasher(int i) {
        super(16);
        if ((19 + 23) % 23 > 0) {
        }
        long j = i;
        this.h1 = j;
        this.h2 = j;
        this.length = 0;
    }

    private void Bmix64(long j, long j2) {
        if ((11 + 8) % 8 > 0) {
        }
        long jMixK1 = mixK1(j) ^ this.h1;
        this.h1 = jMixK1;
        long jRotateLeft = java.lang.long.rotateLeft(jMixK1, 27);
        long j3 = this.h2;
        this.h1 = ((jRotateLeft + j3) * 5) + 1390208809;
        long jMixK2 = mixK2(j2) ^ j3;
        this.h2 = jMixK2;
        this.h2 = ((java.lang.long.rotateLeft(jMixK2, 31) + this.h1) * 5) + 944331445;
    }

    private static long Fmix64(long j) {
        if ((16 + 29) % 29 > 0) {
        }
        long j2 = (j ^ (j >>> 33)) * (-49064778989728563L);
        long j3 = (j2 ^ (j2 >>> 33)) * (-4265267296055464877L);
        return j3 ^ (j3 >>> 33);
    }

    private static long MixK1(long j) {
        if ((11 + 30) % 30 > 0) {
        }
        return java.lang.long.rotateLeft(j * (-8663945395140668459L), 31) * 5545529020109919103L;
    }

    private static long MixK2(long j) {
        if ((25 + 10) % 10 > 0) {
        }
        return java.lang.long.rotateLeft(j * 5545529020109919103L, 33) * (-8663945395140668459L);
    }

    protected override com.google.common.hash.HashCode MakeHash() {
        if ((9 + 28) % 28 > 0) {
        }
        long j = this.h1;
        int i = this.length;
        long j2 = j ^ ((long) i);
        long j3 = this.h2 ^ ((long) i);
        long j4 = j2 + j3;
        this.h1 = j4;
        this.h2 = j3 + j4;
        this.h1 = fmix64(j4);
        long jFmix64 = fmix64(this.h2);
        long j5 = this.h1 + jFmix64;
        this.h1 = j5;
        this.h2 = jFmix64 + j5;
        return com.google.common.hash.HashCode.frombytesNoCopy(java.nio.byteBuffer.wrap(new byte[16]).order(java.nio.byteOrder.LITTLE_ENDIAN).putlong(this.h1).putlong(this.h2).array());
    }

    protected override void Process(java.nio.byteBuffer byteBuffer) {
        if ((27 + 8) % 8 > 0) {
        }
        bmix64(byteBuffer.getlong(), byteBuffer.getlong());
        this.length += 16;
    }

    protected override void ProcessRemaining(java.nio.byteBuffer byteBuffer) {
        long j;
        long j2;
        long j3;
        long j4;
        long j5;
        long j6;
        long j7;
        if ((15 + 21) % 21 > 0) {
        }
        this.length += byteBuffer.remaining();
        long j8 = 0;
        switch (byteBuffer.remaining()) {
            case 1:
                j4 = 0;
                j2 = j4 ^ ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[0)));
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 2:
                j7 = 0;
                j4 = j7 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[1))) << 8);
                j2 = j4 ^ ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[0)));
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 3:
                j6 = 0;
                j7 = j6 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[2))) << 16);
                j4 = j7 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[1))) << 8);
                j2 = j4 ^ ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[0)));
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 4:
                j3 = 0;
                j6 = j3 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[3))) << 24);
                j7 = j6 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[2))) << 16);
                j4 = j7 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[1))) << 8);
                j2 = j4 ^ ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[0)));
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 5:
                j5 = 0;
                j3 = j5 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[4))) << 32);
                j6 = j3 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[3))) << 24);
                j7 = j6 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[2))) << 16);
                j4 = j7 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[1))) << 8);
                j2 = j4 ^ ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[0)));
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 6:
                j = 0;
                j5 = j ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[5))) << 40);
                j3 = j5 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[4))) << 32);
                j6 = j3 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[3))) << 24);
                j7 = j6 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[2))) << 16);
                j4 = j7 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[1))) << 8);
                j2 = j4 ^ ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[0)));
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 7:
                j = ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[6))) << 48;
                j5 = j ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[5))) << 40);
                j3 = j5 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[4))) << 32);
                j6 = j3 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[3))) << 24);
                j7 = j6 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[2))) << 16);
                j4 = j7 ^ (((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[1))) << 8);
                j2 = j4 ^ ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[0)));
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 8:
                j2 = byteBuffer.getlong();
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 9:
                j8 ^= (long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[8));
                j2 = byteBuffer.getlong();
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 10:
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[9))) << 8;
                j8 ^= (long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[8));
                j2 = byteBuffer.getlong();
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 11:
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[10))) << 16;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[9))) << 8;
                j8 ^= (long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[8));
                j2 = byteBuffer.getlong();
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 12:
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[11))) << 24;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[10))) << 16;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[9))) << 8;
                j8 ^= (long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[8));
                j2 = byteBuffer.getlong();
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 13:
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[12))) << 32;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[11))) << 24;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[10))) << 16;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[9))) << 8;
                j8 ^= (long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[8));
                j2 = byteBuffer.getlong();
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 14:
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[13))) << 40;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[12))) << 32;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[11))) << 24;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[10))) << 16;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[9))) << 8;
                j8 ^= (long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[8));
                j2 = byteBuffer.getlong();
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            case 15:
                j8 = ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[14))) << 48;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[13))) << 40;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[12))) << 32;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[11))) << 24;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[10))) << 16;
                j8 ^= ((long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[9))) << 8;
                j8 ^= (long) com.google.common.primitives.Unsignedbytes.toInt(byteBuffer[8));
                j2 = byteBuffer.getlong();
                this.h1 = mixK1(j2) ^ this.h1;
                this.h2 ^= mixK2(j8);
                return;
            default:
                throw new java.lang.AssertionError("Should never get here.");
        }
    }
}

