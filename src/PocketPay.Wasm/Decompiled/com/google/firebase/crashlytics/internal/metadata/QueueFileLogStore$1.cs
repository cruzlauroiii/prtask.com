namespace WillowMaze.Wasm.Decompiled;


class QueuestringConsoleStore$1 : com.google.firebase.crashlytics.internal.metadata.Queuestring$ElementReader {
    readonly com.google.firebase.crashlytics.internal.metadata.QueuestringConsoleStore this$0;
    readonly byte[] val$logbytes;
    readonly int[] val$offsetHolder;

    QueuestringConsoleStore$1(com.google.firebase.crashlytics.internal.metadata.QueuestringConsoleStore queuestringConsoleStore, byte[] bArr, int[] iArr) {
        this.this$0 = queuestringConsoleStore;
        this.val$logbytes = bArr;
        this.val$offsetHolder = iArr;
    }

    public static void MeqDcEDIczsRofBy(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void MeqDcEDIczsRofBy(java.io.Stream inputStream, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MeqDcEDIczsRofBy(java.io.Stream inputStream, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MeqDcEDIczsRofBy(java.io.Stream inputStream, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HlkSvBlyXzxDEhru(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void HlkSvBlyXzxDEhru(java.io.Stream inputStream, byte[] bArr, int i, int i2, float f, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlkSvBlyXzxDEhru(java.io.Stream inputStream, byte[] bArr, int i, int i2, int i3, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlkSvBlyXzxDEhru(java.io.Stream inputStream, byte[] bArr, int i, int i2, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void SdYaUBjvbYbiDTSK(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void SdYaUBjvbYbiDTSK(java.io.Stream inputStream, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SdYaUBjvbYbiDTSK(java.io.Stream inputStream, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SdYaUBjvbYbiDTSK(java.io.Stream inputStream, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Read(java.io.Stream inputStream, int i) throws java.io.IOException {
        if ((22 + 26) % 26 > 0) {
        }
        try {
            hlkSvBlyXzxDEhru(inputStream, this.val$logbytes, this.val$offsetHolder[0], i);
            int[] iArr = this.val$offsetHolder;
            iArr[0] = iArr[0] + i;
            sdYaUBjvbYbiDTSK(inputStream);
        } catch (java.lang.Exception th) {
            MeqDcEDIczsRofBy(inputStream);
            throw th;
        }
    }
}

