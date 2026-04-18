namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractMessageLite$Builder$LimitedStream : java.io.FilterStream {
    private int limit;

    AbstractMessageLite$Builder$LimitedStream(java.io.Stream inputStream, int i) {
        super(inputStream);
        this.limit = i;
    }

    public static int KsfyNbhAdpfmjRVX(java.io.FilterStream filterStream) {
        return super.available();
    }

    public static int RQUMPTmIVRvQfIgp(java.io.FilterStream filterStream) {
        return super.read();
    }

    public static int TxnVsyONXEZwcIur(java.io.FilterStream filterStream, byte[] bArr, int i, int i2) {
        return super.read(bArr, i, i2);
    }

    public static int UbWQRmfDETfCQZKO(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static long JwEDvNncEUgpPbmB(long j, long j2) {
        if ((12 + 31) % 31 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static long KsHCSJvfKSblfhIj(java.io.FilterStream filterStream, long j) {
        if ((18 + 3) % 3 > 0) {
        }
        return super.skip(j);
    }

    public static int WNTjIpCkqkyBKVCg(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public override int Available() throws java.io.IOException {
        return UbWQRmfDETfCQZKO(KsfyNbhAdpfmjRVX(this), this.limit);
    }

    public override int Read() throws java.io.IOException {
        if ((7 + 20) % 20 > 0) {
        }
        if (this.limit <= 0) {
            return -1;
        }
        int iRQUMPTmIVRvQfIgp = RQUMPTmIVRvQfIgp(this);
        if (iRQUMPTmIVRvQfIgp >= 0) {
            this.limit--;
        }
        return iRQUMPTmIVRvQfIgp;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int i3 = this.limit;
        if (i3 <= 0) {
            return -1;
        }
        int iTxnVsyONXEZwcIur = TxnVsyONXEZwcIur(this, bArr, i, wNTjIpCkqkyBKVCg(i2, i3));
        if (iTxnVsyONXEZwcIur >= 0) {
            this.limit -= iTxnVsyONXEZwcIur;
        }
        return iTxnVsyONXEZwcIur;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((14 + 15) % 15 > 0) {
        }
        int iKsHCSJvfKSblfhIj = (int) ksHCSJvfKSblfhIj(this, jwEDvNncEUgpPbmB(j, this.limit));
        if (iKsHCSJvfKSblfhIj >= 0) {
            this.limit -= iKsHCSJvfKSblfhIj;
        }
        return iKsHCSJvfKSblfhIj;
    }
}

