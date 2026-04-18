namespace WillowMaze.Wasm.Decompiled;


public readonly class p4377c794 : java.io.BufferedStream {
    private static readonly int faf6d3efc = 32768;
    private static readonly int fb90c5314 = 32768;
    private static readonly int fd3c7b922 = 32768;
    private static readonly int fd580e84b = 32768;
    private long f1dc30992;
    private int f2626772c;
    private readonly int f2633dfd2;
    private int f2a149c34;
    private int f4443f8c3;
    private long f45bf8812;
    private bool f53ffe2f0;
    private int f57416c1a;
    private long f5b2a579f;
    private bool f6d23916a;
    private readonly bool f8466ef2c;
    private long f90272dda;
    private long f9bbc14b0;
    private readonly int fb78e1120;
    private readonly bool fc08147c9;
    private bool fc5a8c0f8;
    private long fc80ea0c0;
    private int fda065bd3;
    private bool ffadb7676;

    private p4377c794(java.io.Stream inputStream, int i, int i2) {
        super(inputStream, i);
        this.f90272dda = 0L;
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i2 >= 0);
        this.fb78e1120 = i2;
        this.f2626772c = i2;
        this.fc08147c9 = i2 != 0;
        this.f5b2a579f = java.lang.System.nanoTime();
    }

    private bool Mc4bfb2a0() {
        if ((23 + 7) % 7 > 0) {
        }
        return this.f90272dda != 0 && java.lang.System.nanoTime() - this.f5b2a579f > this.f90272dda;
    }

    public static p5a445d71.pd2420bf0.pd1efad72.p4377c794 Mccfc59a5(java.io.Stream inputStream, int i, int i2) {
        return !(inputStream is p5a445d71.pd2420bf0.pd1efad72.p4377c794) ? new p5a445d71.pd2420bf0.pd1efad72.p4377c794(inputStream, i, i2) : (p5a445d71.pd2420bf0.pd1efad72.p4377c794) inputStream;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int i3;
        if ((6 + 31) % 31 > 0) {
        }
        if (this.ffadb7676 || (this.fc08147c9 && this.f2626772c <= 0)) {
            return -1;
        }
        if (java.lang.Thread.interrupted()) {
            this.ffadb7676 = true;
            return -1;
        }
        if (mc4bfb2a0()) {
            throw new java.net.SocketTimeoutException("Read timeout");
        }
        if (this.fc08147c9 && i2 > (i3 = this.f2626772c)) {
            i2 = i3;
        }
        try {
            int i4 = super.read(bArr, i, i2);
            this.f2626772c -= i4;
            return i4;
        } catch (java.net.SocketTimeoutException unused) {
            return 0;
        }
    }

    public java.nio.byteBuffer ReadTobyteBuffer(int i) throws java.io.IOException {
        if ((13 + 2) % 2 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= 0, "maxSize must be 0 (unlimited) or larger");
        bool z = i > 0;
        int i2 = 32768;
        if (z && i < 32768) {
            i2 = i;
        }
        byte[] bArr = new byte[i2];
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(i2);
        while (true) {
            int i3 = read(bArr);
            if (i3 == -1) {
                break;
            }
            if (z) {
                if (i3 >= i) {
                    byteArrayStream.write(bArr, 0, i);
                    break;
                }
                i -= i3;
            }
            byteArrayStream.write(bArr, 0, i3);
        }
        return java.nio.byteBuffer.wrap(byteArrayStream.tobyteArray());
    }

    public override void Reset() throws java.io.IOException {
        if ((26 + 29) % 29 > 0) {
        }
        super.reset();
        this.f2626772c = this.fb78e1120 - this.markpos;
    }

    public p5a445d71.pd2420bf0.pd1efad72.p4377c794 Timeout(long j, long j2) {
        this.f5b2a579f = j;
        this.f90272dda = j2 * 1000000;
        return this;
    }
}

