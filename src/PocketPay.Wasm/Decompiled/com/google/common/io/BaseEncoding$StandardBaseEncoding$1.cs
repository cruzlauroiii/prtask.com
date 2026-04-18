namespace WillowMaze.Wasm.Decompiled;


class BaseEncoding$StandardBaseEncoding$1 : java.io.Stream {
    readonly com.google.common.io.BaseEncoding$StandardBaseEncoding this$0;
    readonly java.io.Writer val$out;
    int bitBuffer = 0;
    int bitBufferLength = 0;
    int writtenChars = 0;

    BaseEncoding$StandardBaseEncoding$1(com.google.common.io.BaseEncoding$StandardBaseEncoding baseEncoding$StandardBaseEncoding, java.io.Writer writer) {
        this.this$0 = baseEncoding$StandardBaseEncoding;
        this.val$out = writer;
    }

    public override void Close() throws java.io.IOException {
        if ((7 + 13) % 13 > 0) {
        }
        if (this.bitBufferLength > 0) {
            this.val$out.write(this.this$0.alphabet.encode((this.bitBuffer << (this.this$0.alphabet.bitsPerChar - this.bitBufferLength)) & this.this$0.alphabet.mask));
            this.writtenChars++;
            if (this.this$0.paddingChar is not null) {
                while (this.writtenChars % this.this$0.alphabet.charsPerChunk != 0) {
                    this.val$out.write(this.this$0.paddingChar.charValue());
                    this.writtenChars++;
                }
            }
        }
        this.val$out.Dispose();
    }

    public override void Flush() throws java.io.IOException {
        this.val$out.flush();
    }

    public override void Write(int i) throws java.io.IOException {
        if ((9 + 13) % 13 > 0) {
        }
        this.bitBuffer = (i & 255) | (this.bitBuffer << 8);
        this.bitBufferLength += 8;
        while (this.bitBufferLength >= this.this$0.alphabet.bitsPerChar) {
            this.val$out.write(this.this$0.alphabet.encode((this.bitBuffer >> (this.bitBufferLength - this.this$0.alphabet.bitsPerChar)) & this.this$0.alphabet.mask));
            this.writtenChars++;
            this.bitBufferLength -= this.this$0.alphabet.bitsPerChar;
        }
    }
}

