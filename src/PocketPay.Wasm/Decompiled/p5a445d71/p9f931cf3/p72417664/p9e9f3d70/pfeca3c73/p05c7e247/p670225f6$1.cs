namespace WillowMaze.Wasm.Decompiled;


class p670225f6$1 : java.security.PrivilegedAction {
    readonly java.lang.string val$className;

    p670225f6$1(java.lang.string str) {
        this.val$className = str;
    }

    public override java.lang.object Run() {
        try {
            return java.lang.Class.forName(this.val$className);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }
}

