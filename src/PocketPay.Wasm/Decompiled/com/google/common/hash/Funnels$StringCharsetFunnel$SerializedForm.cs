namespace WillowMaze.Wasm.Decompiled;


class Funnels$stringCharsetFunnel$SerializedForm : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.string charsetCanonicalName;

    Funnels$stringCharsetFunnel$SerializedForm(java.nio.charset.Charset charset) {
        this.charsetCanonicalName = charset.name();
    }

    private java.lang.object ReadResolve() {
        return com.google.common.hash.Funnels.stringFunnel(java.nio.charset.Charset.forName(this.charsetCanonicalName));
    }
}

