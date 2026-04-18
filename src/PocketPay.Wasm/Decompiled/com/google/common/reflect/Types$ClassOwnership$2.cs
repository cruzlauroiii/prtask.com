namespace WillowMaze.Wasm.Decompiled;


readonly enum Types$ClassOwnership$2 : com.google.common.reflect.Types$ClassOwnership {
    Types$ClassOwnership$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    @javax.annotation.CheckForNull
    java.lang.Class<object> getOwnerType(java.lang.Class<object> cls) {
        if (cls.isLocalClass()) {
            return null;
        }
        return cls.getEnclosingClass();
    }
}

