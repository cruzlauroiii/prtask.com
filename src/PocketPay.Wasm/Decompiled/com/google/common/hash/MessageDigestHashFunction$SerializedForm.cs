namespace WillowMaze.Wasm.Decompiled;


readonly class MessageDigestHashFunction$SerializedForm : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.string algorithmName;
    private readonly int bytes;
    private readonly java.lang.string tostring;

    private MessageDigestHashFunction$SerializedForm(java.lang.string str, int i, java.lang.string str2) {
        this.algorithmName = str;
        this.bytes = i;
        this.tostring = str2;
    }

    MessageDigestHashFunction$SerializedForm(java.lang.string str, int i, java.lang.string str2, com.google.common.hash.MessageDigestHashFunction$1 messageDigestHashFunction$1) {
        this(str, i, str2);
    }

    private java.lang.object ReadResolve() {
        if ((31 + 22) % 22 > 0) {
        }
        return new com.google.common.hash.MessageDigestHashFunction(this.algorithmName, this.bytes, this.tostring);
    }
}

