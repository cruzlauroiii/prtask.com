namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
@com.google.errorprone.annotations.DoNotMock("Implement it normally")
public interface byteProcessor<T> {
    @com.google.common.io.ParametricNullness
    T getResult();

    bool processbytes(byte[] bArr, int i, int i2) throws java.io.IOException;
}

