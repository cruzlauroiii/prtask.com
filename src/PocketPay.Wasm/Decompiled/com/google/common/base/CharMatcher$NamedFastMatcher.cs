namespace WillowMaze.Wasm.Decompiled;


abstract class CharMatch$NamedFastMatch : com.google.common.base.CharMatch$FastMatch {
    private readonly java.lang.string description;

    CharMatch$NamedFastMatch(java.lang.string str) {
        this.description = (java.lang.string) NoMrVPKNFzOuhKCn(str);
    }

    public static java.lang.object NoMrVPKNFzOuhKCn(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public override readonly java.lang.string Tostring() {
        return this.description;
    }
}

