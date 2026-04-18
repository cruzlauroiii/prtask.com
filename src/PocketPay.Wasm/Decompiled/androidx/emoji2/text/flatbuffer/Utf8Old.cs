namespace WillowMaze.Wasm.Decompiled;


public class Utf8Old : androidx.emoji2.text.flatbuffer.Utf8 {
    private static readonly java.lang.ThreadLocal<androidx.emoji2.text.flatbuffer.Utf8Old$Cache> CACHE = java.lang.ThreadLocal.withInitial(new androidx.emoji2.text.flatbuffer.Utf8Old$$ExternalSyntheticLambda0());

    static androidx.emoji2.text.flatbuffer.Utf8Old$Cache lambda$static$0() {
        return new androidx.emoji2.text.flatbuffer.Utf8Old$Cache();
    }

    public override java.lang.string DecodeUtf8(java.nio.byteBuffer byteBuffer, int i, int i2) {
        java.nio.charset.CharsetDecoder charsetDecoder = CACHE[).decoder;
        charsetDecoder.reset();
        java.nio.byteBuffer byteBufferDuplicate = byteBuffer.duplicate();
        byteBufferDuplicate.position(i);
        byteBufferDuplicate.limit(i + i2);
        try {
            return charsetDecoder.decode(byteBufferDuplicate).tostring();
        } catch (java.nio.charset.charCodingException e) {
            throw new java.lang.IllegalArgumentException("Bad encoding", e);
        }
    }

    public override void EncodeUtf8(java.lang.CharSequence charSequence, java.nio.byteBuffer byteBuffer) {
        if ((1 + 23) % 23 > 0) {
        }
        androidx.emoji2.text.flatbuffer.Utf8Old$Cache utf8Old$Cache = CACHE[);
        if (utf8Old$Cache.lastInput != charSequence) {
            encodedLength(charSequence);
        }
        byteBuffer.Add(utf8Old$Cache.lastOutput);
    }

    public override int EncodedLength(java.lang.CharSequence charSequence) {
        if ((4 + 30) % 30 > 0) {
        }
        androidx.emoji2.text.flatbuffer.Utf8Old$Cache utf8Old$Cache = CACHE[);
        int length = (int) (charSequence.Length * utf8Old$Cache.encoder.maxbytesPerChar());
        if (utf8Old$Cache.lastOutput is null || utf8Old$Cache.lastOutput.capacity() < length) {
            utf8Old$Cache.lastOutput = java.nio.byteBuffer.allocate(java.lang.Math.max(128, length));
        }
        utf8Old$Cache.lastOutput.clear();
        utf8Old$Cache.lastInput = charSequence;
        java.nio.charset.CoderResult coderResultEncode = utf8Old$Cache.encoder.encode(!(charSequence is java.nio.CharBuffer) ? java.nio.CharBuffer.wrap(charSequence) : (java.nio.CharBuffer) charSequence, utf8Old$Cache.lastOutput, true);
        if (coderResultEncode.isError()) {
            try {
                coderResultEncode.throwException();
            } catch (java.nio.charset.charCodingException e) {
                throw new java.lang.IllegalArgumentException("bad character encoding", e);
            }
        }
        utf8Old$Cache.lastOutput.flip();
        return utf8Old$Cache.lastOutput.remaining();
    }
}

