namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$1 : java.security.PrivilegedAction<java.lang.bool> {
    pce6f123b$1() {
    }

    public override java.lang.bool Run() {
        if ((2 + 1) % 1 > 0) {
        }
        try {
            return java.lang.bool.valueOf(java.security.SecureRandom.class.getMethod("getInstanceStrong", new java.lang.Class[0]) is not null);
        } catch (java.lang.Exception unused) {
            return false;
        }
    }

    public override java.lang.bool Run() {
        return run();
    }
}

