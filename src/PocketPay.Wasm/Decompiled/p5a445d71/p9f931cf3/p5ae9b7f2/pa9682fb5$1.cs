namespace WillowMaze.Wasm.Decompiled;


class pa9682fb5$1 : java.security.PrivilegedAction<java.lang.object> {
    readonly java.security.Permission val$permission;
    readonly java.lang.SecurityManager val$securityManager;

    pa9682fb5$1(java.lang.SecurityManager securityManager, java.security.Permission permission) {
        this.val$securityManager = securityManager;
        this.val$permission = permission;
    }

    public override java.lang.object Run() {
        this.val$securityManager.checkPermission(this.val$permission);
        return null;
    }
}

