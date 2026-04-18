namespace WillowMaze.Wasm.Decompiled;


class p9fc2d28c$1 : java.security.PrivilegedAction {
    readonly java.lang.string val$propertyName;

    p9fc2d28c$1(java.lang.string str) {
        this.val$propertyName = str;
    }

    public override java.lang.object Run() {
        return java.security.Security.getProperty(this.val$propertyName);
    }
}

