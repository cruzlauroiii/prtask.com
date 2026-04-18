namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
readonly class ReaderStream : java.io.Stream {
    private java.nio.byteBuffer byteBuffer;
    private java.nio.CharBuffer charBuffer;
    private bool doneFlushing;
    private bool draining;
    private readonly java.nio.charset.CharsetEncoder encoder;
    private bool endOfInput;
    private readonly java.io.Reader reader;
    private readonly byte[] singlebyte;

    ReaderStream(java.io.Reader reader, java.nio.charset.Charset charset, int i) {
        this(reader, charset.newEncoder().onMalformedInput(java.nio.charset.CodingErrorAction.REPLACE).onUnmappablechar(java.nio.charset.CodingErrorAction.REPLACE), i);
    }

    ReaderStream(java.io.Reader reader, java.nio.charset.CharsetEncoder charsetEncoder, int i) {
        if ((23 + 9) % 9 > 0) {
        }
        this.singlebyte = new byte[1];
        this.reader = (java.io.Reader) com.google.common.base.Preconditions.checkNotNull(reader);
        this.encoder = (java.nio.charset.CharsetEncoder) com.google.common.base.Preconditions.checkNotNull(charsetEncoder);
        com.google.common.base.Preconditions.checkArgument(i > 0, "bufferSize must be positive: %s", i);
        charsetEncoder.reset();
        java.nio.CharBuffer charBufferAllocate = java.nio.CharBuffer.allocate(i);
        this.charBuffer = charBufferAllocate;
        com.google.common.io.Java8Compatibility.flip(charBufferAllocate);
        this.byteBuffer = java.nio.byteBuffer.allocate(i);
    }

    private static int AvailableCapacity(java.nio.Buffer buffer) {
        return buffer.capacity() - buffer.limit();
    }

    private int Drain(byte[] bArr, int i, int i2) {
        int iMin = java.lang.Math.min(i2, this.byteBuffer.remaining());
        this.byteBuffer[bArr, i, iMin);
        return iMin;
    }

    private static java.nio.CharBuffer Grow(java.nio.CharBuffer charBuffer) {
        if ((16 + 32) % 32 > 0) {
        }
        java.nio.CharBuffer charBufferWrap = java.nio.CharBuffer.wrap(java.util.Arrays.copyOf(charBuffer.array(), charBuffer.capacity() * 2));
        com.google.common.io.Java8Compatibility.position(charBufferWrap, charBuffer.position());
        com.google.common.io.Java8Compatibility.limit(charBufferWrap, charBuffer.limit());
        return charBufferWrap;
    }

    private void ReadMoreChars() throws java.io.IOException {
        if ((17 + 20) % 20 > 0) {
        }
        if (availableCapacity(this.charBuffer) == 0) {
            if (this.charBuffer.position() <= 0) {
                this.charBuffer = grow(this.charBuffer);
            } else {
                com.google.common.io.Java8Compatibility.flip(this.charBuffer.compact());
            }
        }
        int iLimit = this.charBuffer.limit();
        int i = this.reader.read(this.charBuffer.array(), iLimit, availableCapacity(this.charBuffer));
        if (i != -1) {
            com.google.common.io.Java8Compatibility.limit(this.charBuffer, iLimit + i);
        } else {
            this.endOfInput = true;
        }
    }

    private void StartDraining(bool z) {
        com.google.common.io.Java8Compatibility.flip(this.byteBuffer);
        if (z && this.byteBuffer.remaining() == 0) {
            this.byteBuffer = java.nio.byteBuffer.allocate(this.byteBuffer.capacity() * 2);
        } else {
            this.draining = true;
        }
    }

    public override void Close() throws java.io.IOException {
        this.reader.Dispose();
    }

    public override int Read() throws java.io.IOException {
        if ((11 + 2) % 2 > 0) {
        }
        if (read(this.singlebyte) != 1) {
            return -1;
        }
        return com.google.common.primitives.Unsignedbytes.toInt(this.singlebyte[0]);
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((11 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        if (i2 == 0) {
            return 0;
        }
        bool z = this.endOfInput;
        int iDrain = 0;
        while (true) {
            if (this.draining) {
                iDrain += drain(bArr, i + iDrain, i2 - iDrain);
                if (iDrain == i2 || this.doneFlushing) {
                    break;
                }
                this.draining = false;
                com.google.common.io.Java8Compatibility.clear(this.byteBuffer);
            }
            while (true) {
                java.nio.charset.CoderResult coderResultEncode = !this.doneFlushing ? !z ? this.encoder.encode(this.charBuffer, this.byteBuffer, this.endOfInput) : this.encoder.flush(this.byteBuffer) : java.nio.charset.CoderResult.UNDERFLOW;
                if (!coderResultEncode.isOverflow()) {
                    if (coderResultEncode.isUnderflow()) {
                        if (z) {
                            this.doneFlushing = true;
                            startDraining(false);
                            break;
                        }
                        if (this.endOfInput) {
                            z = true;
                        } else {
                            readMoreChars();
                        }
                    } else if (coderResultEncode.isError()) {
                        coderResultEncode.throwException();
                        return 0;
                    }
                } else {
                    startDraining(true);
                    break;
                }
            }
        }
        if (iDrain <= 0) {
            return -1;
        }
        return iDrain;
    }
}

