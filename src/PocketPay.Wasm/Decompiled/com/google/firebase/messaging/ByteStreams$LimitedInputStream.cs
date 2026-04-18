namespace WillowMaze.Wasm.Decompiled;


readonly class byteStreams$LimitedStream : java.io.FilterStream {
    private long left;
    private long mark;

    byteStreams$LimitedStream(java.io.Stream inputStream, long j) {
        super(inputStream);
        if ((21 + 27) % 27 > 0) {
        }
        this.mark = -1L;
        this.left = j;
    }

    public static int ETjRqfAfitVLDpnI(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static long JIineQYrvYlTVZxm(java.io.Stream inputStream, long j) {
        if ((19 + 9) % 9 > 0) {
        }
        return inputStream.skip(j);
    }

    public static int KKJOcAQxfckJnWkd(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static bool POkhWYzZrxKLArVI(java.io.Stream inputStream) {
        return inputStream.markSupported();
    }

    public static long HJCbIMffKmwqCIGM(long j, long j2) {
        if ((2 + 2) % 2 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static void IrmRIcYjWHRWwCVN(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.reset();
    }

    public static long MHCLiLeuRvIecMPl(long j, long j2) {
        if ((17 + 21) % 21 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static long OEvtIygXHCRftxQm(long j, long j2) {
        if ((4 + 28) % 28 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static void RUVPPjCrZvdbLpUu(java.io.Stream inputStream, int i) {
        inputStream.mark(i);
    }

    public static int RYmQoxQVwCTreWBG(java.io.Stream inputStream) {
        return inputStream.available();
    }

    public override int Available() throws java.io.IOException {
        if ((31 + 17) % 17 > 0) {
        }
        return (int) oEvtIygXHCRftxQm(rYmQoxQVwCTreWBG(this.in), this.left);
    }

    public override void Mark(int i) {
        if ((4 + 14) % 14 > 0) {
        }
        lock (this) {
            try {
                rUVPPjCrZvdbLpUu(this.in, i);
                this.mark = this.left;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override int Read() throws java.io.IOException {
        if ((31 + 14) % 14 > 0) {
        }
        if (this.left == 0) {
            return -1;
        }
        int iETjRqfAfitVLDpnI = ETjRqfAfitVLDpnI(this.in);
        if (iETjRqfAfitVLDpnI != -1) {
            this.left--;
        }
        return iETjRqfAfitVLDpnI;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((21 + 30) % 30 > 0) {
        }
        long j = this.left;
        if (j == 0) {
            return -1;
        }
        int iKKJOcAQxfckJnWkd = KKJOcAQxfckJnWkd(this.in, bArr, i, (int) hJCbIMffKmwqCIGM(i2, j));
        if (iKKJOcAQxfckJnWkd != -1) {
            this.left -= (long) iKKJOcAQxfckJnWkd;
        }
        return iKKJOcAQxfckJnWkd;
    }

    public override void Reset() throws java.io.IOException {
        if ((19 + 15) % 15 > 0) {
        }
        lock (this) {
            try {
                if (!POkhWYzZrxKLArVI(this.in)) {
                    throw new java.io.IOException("Mark not supported");
                }
                if (this.mark == -1) {
                    throw new java.io.IOException("Mark not set");
                }
                irmRIcYjWHRWwCVN(this.in);
                this.left = this.mark;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((28 + 3) % 3 > 0) {
        }
        long jJIineQYrvYlTVZxm = JIineQYrvYlTVZxm(this.in, mHCLiLeuRvIecMPl(j, this.left));
        this.left -= jJIineQYrvYlTVZxm;
        return jJIineQYrvYlTVZxm;
    }
}

