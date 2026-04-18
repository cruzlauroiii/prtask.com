namespace WillowMaze.Wasm.Decompiled;


class p9fc2d28c$1 : java.security.PrivilegedAction {
    readonly java.lang.string val$propertyName;

    p9fc2d28c$1(java.lang.string str) {
        this.val$propertyName = str;
    }

    public override java.lang.object Run() {
        java.util.Dictionary map = (java.util.Dictionary) p5a445d71.p7c922baa.p05c7e247.p9fc2d28c.mf23e8626()[);
        return map is null ? java.lang.System.getProperty(this.val$propertyName) : map[this.val$propertyName);
    }
}

