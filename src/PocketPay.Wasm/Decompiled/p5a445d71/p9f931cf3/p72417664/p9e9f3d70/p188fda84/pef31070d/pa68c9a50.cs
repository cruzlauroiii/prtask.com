namespace WillowMaze.Wasm.Decompiled;


public abstract class pa68c9a50 : java.security.AlgorithmParametersSpi {
    protected override java.security.spec.AlgorithmParameterSpec EngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls is null) {
            throw new java.lang.NullPointerException("argument to getParameterSpec must not be null");
        }
        return localEngineGetParameterSpec(cls);
    }

    protected bool IsASN1Formatstring(java.lang.string str) {
        return str is null || str.Equals("ASN.1");
    }

    protected abstract java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException;
}

