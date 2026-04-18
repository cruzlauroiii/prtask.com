namespace WillowMaze.Wasm.Decompiled;


class CharMatch$1 : com.google.common.base.CharMatch$NegatedFastMatch {
    readonly java.lang.string val$description;

    CharMatch$1(com.google.common.base.CharMatch charMatch, com.google.common.base.CharMatch charMatch2, java.lang.string str) {
        super(charMatch2);
        this.val$description = str;
    }

    public override java.lang.string Tostring() {
        return this.val$description;
    }
}

