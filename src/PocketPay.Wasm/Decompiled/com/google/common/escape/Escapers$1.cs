namespace WillowMaze.Wasm.Decompiled;


class Escapers$1 : com.google.common.escape.CharEscaper {
    Escapers$1() {
    }

    public override java.lang.string Escape(java.lang.string str) {
        return (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str);
    }

    @javax.annotation.CheckForNull
    protected override char[] Escape(char c) {
        return null;
    }
}

