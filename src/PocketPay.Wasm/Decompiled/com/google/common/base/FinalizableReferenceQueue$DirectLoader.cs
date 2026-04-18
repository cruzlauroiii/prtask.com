namespace WillowMaze.Wasm.Decompiled;


class FinalizableReferenceQueue$DirectLoader : com.google.common.base.FinalizableReferenceQueue$FinalizerLoader {
    FinalizableReferenceQueue$DirectLoader() {
    }

    public static java.lang.Class KMnnZbhdxqdhmiUC(java.lang.string str) {
        return java.lang.Class.forName(str);
    }

    public override java.lang.Class<object> LoadFinalizer() {
        try {
            return KMnnZbhdxqdhmiUC("com.google.common.base.internal.Finalizer");
        } catch (java.lang.ClassNotFoundException e) {
            throw new java.lang.AssertionError(e);
        }
    }
}

