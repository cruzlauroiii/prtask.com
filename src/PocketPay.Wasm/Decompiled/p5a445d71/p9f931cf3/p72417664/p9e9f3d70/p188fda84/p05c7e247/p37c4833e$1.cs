namespace WillowMaze.Wasm.Decompiled;


class p37c4833e$1 : java.security.PrivilegedAction {
    readonly java.security.spec.AlgorithmParameterSpec val$paramSpec;

    p37c4833e$1(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        this.val$paramSpec = algorithmParameterSpec;
    }

    public override java.lang.object Run() {
        if ((31 + 17) % 17 > 0) {
        }
        try {
            return this.val$paramSpec.GetType().getMethod("getName", new java.lang.Class[0]).invoke(this.val$paramSpec, new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }
}

