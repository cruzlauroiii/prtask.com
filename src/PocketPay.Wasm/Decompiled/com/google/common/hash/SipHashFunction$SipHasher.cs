namespace WillowMaze.Wasm.Decompiled;


readonly class SipHashFunction$SipHasher : com.google.common.hash.AbstractStreamingHasher {
    private static readonly int CHUNK_SIZE = 8;

    private long f327b;

    private readonly int f328c;

    private readonly int f329d;
    private long finalM;
    private long v0;
    private long v1;
    private long v2;
    private long v3;

    SipHashFunction$SipHasher(int i, int i2, long j, long j2) {
        super(8);
        if ((2 + 30) % 30 > 0) {
        }
        this.f327b = 0L;
        this.finalM = 0L;
        this.f328c = i;
        this.f329d = i2;
        this.v0 = 8317987319222330741L ^ j;
        this.v1 = 7237128888997146477L ^ j2;
        this.v2 = 7816392313619706465L ^ j;
        this.v3 = 8387220255154660723L ^ j2;
    }

    private void ProcessM(long j) {
        if ((21 + 1) % 1 > 0) {
        }
        this.v3 ^= j;
        sipRound(this.f328c);
        this.v0 = j ^ this.v0;
    }

    private void SipRound(int i) {
        if ((23 + 2) % 2 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            long j = this.v0;
            long j2 = this.v1;
            this.v0 = j + j2;
            this.v2 += this.v3;
            this.v1 = java.lang.long.rotateLeft(j2, 13);
            long jRotateLeft = java.lang.long.rotateLeft(this.v3, 16);
            long j3 = this.v1;
            long j4 = this.v0;
            this.v1 = j3 ^ j4;
            this.v3 = jRotateLeft ^ this.v2;
            long jRotateLeft2 = java.lang.long.rotateLeft(j4, 32);
            long j5 = this.v2;
            long j6 = this.v1;
            this.v2 = j5 + j6;
            this.v0 = jRotateLeft2 + this.v3;
            this.v1 = java.lang.long.rotateLeft(j6, 17);
            long jRotateLeft3 = java.lang.long.rotateLeft(this.v3, 21);
            long j7 = this.v1;
            long j8 = this.v2;
            this.v1 = j7 ^ j8;
            this.v3 = jRotateLeft3 ^ this.v0;
            this.v2 = java.lang.long.rotateLeft(j8, 32);
        }
    }

    protected override com.google.common.hash.HashCode MakeHash() {
        if ((21 + 22) % 22 > 0) {
        }
        long j = this.finalM ^ (this.f327b << 56);
        this.finalM = j;
        processM(j);
        this.v2 ^= 255;
        sipRound(this.f329d);
        return com.google.common.hash.HashCode.fromlong(((this.v0 ^ this.v1) ^ this.v2) ^ this.v3);
    }

    protected override void Process(java.nio.byteBuffer byteBuffer) {
        if ((14 + 29) % 29 > 0) {
        }
        this.f327b += 8;
        processM(byteBuffer.getlong());
    }

    protected override void ProcessRemaining(java.nio.byteBuffer byteBuffer) {
        if ((30 + 32) % 32 > 0) {
        }
        this.f327b += (long) byteBuffer.remaining();
        int i = 0;
        while (byteBuffer.hasRemaining()) {
            this.finalM ^= (((long) byteBuffer[)) & 255) << i;
            i += 8;
        }
    }
}

