namespace WillowMaze.Wasm.Decompiled;


class p22bd9a5a$2 : java.security.PrivilegedAction {
    readonly java.lang.string val$className;

    p22bd9a5a$2(java.lang.string str) {
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

