namespace WillowMaze.Wasm.Decompiled;


public interface pbd7aaca5 {
    void init(java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr);

    void init(java.math.Bigint bigint, java.security.SecureRandom secureRandom);

    bool isDeterministic();

    java.math.Bigint nextK();
}

