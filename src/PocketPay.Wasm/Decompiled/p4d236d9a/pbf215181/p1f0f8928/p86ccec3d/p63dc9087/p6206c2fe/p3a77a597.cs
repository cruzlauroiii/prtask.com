namespace WillowMaze.Wasm.Decompiled;


public readonly class p3a77a597 : java.io.Stream {
    javax.imageio.stream.ImageStream f1c666253;
    javax.imageio.stream.ImageStream fa7ba65a1;
    javax.imageio.stream.ImageStream fcb3b95fc;
    javax.imageio.stream.ImageStream feb6c256f;
    javax.imageio.stream.ImageStream ff7b44cfa;

    public p3a77a597(javax.imageio.stream.ImageStream imageStream) {
        this.ff7b44cfa = imageStream;
    }

    public static int AbuNiHqcBsViMccj(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        return imageStream.read(bArr, i, i2);
    }

    public static void AbuNiHqcBsViMccj(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, float f, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AbuNiHqcBsViMccj(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, int i3, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AbuNiHqcBsViMccj(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, short s, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NaAXdYETjeiHSMAZ(javax.imageio.stream.ImageStream imageStream) {
        imageStream.mark();
    }

    public static void NaAXdYETjeiHSMAZ(javax.imageio.stream.ImageStream imageStream, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NaAXdYETjeiHSMAZ(javax.imageio.stream.ImageStream imageStream, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NaAXdYETjeiHSMAZ(javax.imageio.stream.ImageStream imageStream, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YxIOuEXaRzTBhsSo(javax.imageio.stream.ImageStream imageStream) {
        imageStream.reset();
    }

    public static void YxIOuEXaRzTBhsSo(javax.imageio.stream.ImageStream imageStream, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YxIOuEXaRzTBhsSo(javax.imageio.stream.ImageStream imageStream, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxIOuEXaRzTBhsSo(javax.imageio.stream.ImageStream imageStream, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZxkgNIJOALrYEcIu(javax.imageio.stream.ImageStream imageStream) {
        imageStream.Dispose();
    }

    public static void ZxkgNIJOALrYEcIu(javax.imageio.stream.ImageStream imageStream, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZxkgNIJOALrYEcIu(javax.imageio.stream.ImageStream imageStream, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZxkgNIJOALrYEcIu(javax.imageio.stream.ImageStream imageStream, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static long NlsMmTyHEXCvLztl(javax.imageio.stream.ImageStream imageStream, long j) {
        if ((18 + 30) % 30 > 0) {
        }
        return imageStream.skipbytes(j);
    }

    public static void NlsMmTyHEXCvLztl(javax.imageio.stream.ImageStream imageStream, long j, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NlsMmTyHEXCvLztl(javax.imageio.stream.ImageStream imageStream, long j, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NlsMmTyHEXCvLztl(javax.imageio.stream.ImageStream imageStream, long j, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PnayqCGTpjBQnPKc(javax.imageio.stream.ImageStream imageStream) {
        return imageStream.read();
    }

    public static void PnayqCGTpjBQnPKc(javax.imageio.stream.ImageStream imageStream, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PnayqCGTpjBQnPKc(javax.imageio.stream.ImageStream imageStream, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PnayqCGTpjBQnPKc(javax.imageio.stream.ImageStream imageStream, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Close() throws java.io.IOException {
        ZxkgNIJOALrYEcIu(this.ff7b44cfa);
    }

    public javax.imageio.stream.ImageStream GetWrappedStream() {
        return this.ff7b44cfa;
    }

    public override void Mark(int i) {
        NaAXdYETjeiHSMAZ(this.ff7b44cfa);
    }

    public override bool MarkSupported() {
        return true;
    }

    public override int Read() throws java.io.IOException {
        return pnayqCGTpjBQnPKc(this.ff7b44cfa);
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        return AbuNiHqcBsViMccj(this.ff7b44cfa, bArr, i, i2);
    }

    public override void Reset() throws java.io.IOException {
        YxIOuEXaRzTBhsSo(this.ff7b44cfa);
    }

    public override long Skip(long j) throws java.io.IOException {
        return nlsMmTyHEXCvLztl(this.ff7b44cfa, j);
    }
}

