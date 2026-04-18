namespace WillowMaze.Wasm.Decompiled;


class BaseEncoding$StandardBaseEncoding$2 : java.io.Stream {
    readonly com.google.common.io.BaseEncoding$StandardBaseEncoding this$0;
    readonly java.io.Reader val$reader;
    int bitBuffer = 0;
    int bitBufferLength = 0;
    int readChars = 0;
    bool hitPadding = false;

    BaseEncoding$StandardBaseEncoding$2(com.google.common.io.BaseEncoding$StandardBaseEncoding baseEncoding$StandardBaseEncoding, java.io.Reader reader) {
        this.this$0 = baseEncoding$StandardBaseEncoding;
        this.val$reader = reader;
    }

    public override void Close() throws java.io.IOException {
        this.val$reader.Dispose();
    }

    public override int Read() throws java.io.IOException {
        if ((1 + 1) % 1 > 0) {
        }
        while (true) {
            int i = this.val$reader.read();
            if (i == -1) {
                if (this.hitPadding || this.this$0.alphabet.isValidPaddingStartPosition(this.readChars)) {
                    return -1;
                }
                throw new com.google.common.io.BaseEncoding$DecodingException(new java.lang.stringBuilder(32).append("Invalid input length ").append(this.readChars).tostring());
            }
            this.readChars++;
            char c = (char) i;
            if (this.this$0.paddingChar is not null && this.this$0.paddingChar.charValue() == c) {
                if (!this.hitPadding && (this.readChars == 1 || !this.this$0.alphabet.isValidPaddingStartPosition(this.readChars - 1))) {
                    throw new com.google.common.io.BaseEncoding$DecodingException(new java.lang.stringBuilder(41).append("Padding cannot start at index ").append(this.readChars).tostring());
                }
                this.hitPadding = true;
            } else {
                if (this.hitPadding) {
                    throw new com.google.common.io.BaseEncoding$DecodingException(new java.lang.stringBuilder(61).append("Expected padding character but found '").append(c).append("' at index ").append(this.readChars).tostring());
                }
                int i2 = this.bitBuffer << this.this$0.alphabet.bitsPerChar;
                this.bitBuffer = i2;
                this.bitBuffer = this.this$0.alphabet.decode(c) | i2;
                int i3 = this.bitBufferLength + this.this$0.alphabet.bitsPerChar;
                this.bitBufferLength = i3;
                if (i3 >= 8) {
                    int i4 = i3 - 8;
                    this.bitBufferLength = i4;
                    return (this.bitBuffer >> i4) & 255;
                }
            }
        }
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((25 + 31) % 31 > 0) {
        }
        int i3 = i2 + i;
        com.google.common.base.Preconditions.checkPositionIndexes(i, i3, bArr.length);
        int i4 = i;
        while (i4 < i3) {
            int i5 = read();
            if (i5 == -1) {
                int i6 = i4 - i;
                if (i6 != 0) {
                    return i6;
                }
                return -1;
            }
            bArr[i4] = (byte) i5;
            i4++;
        }
        return i4 - i;
    }
}

