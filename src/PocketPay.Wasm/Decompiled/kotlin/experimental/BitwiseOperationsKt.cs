namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0005\n\u0002\b\u0004\n\u0002\u0010\n\n\u0000\u001a\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0087\f\u001a\u0015\u0010\u0003\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0087\f\u001a\u0015\u0010\u0004\u001a\u00020\u0001*\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0087\f\u001a\r\u0010\u0005\u001a\u00020\u0001*\u00020\u0001H\u0087\b\u001a\u0015\u0010\u0000\u001a\u00020\u0006*\u00020\u00062\u0006\u0010\u0002\u001a\u00020\u0006H\u0087\f\u001a\u0015\u0010\u0003\u001a\u00020\u0006*\u00020\u00062\u0006\u0010\u0002\u001a\u00020\u0006H\u0087\f\u001a\u0015\u0010\u0004\u001a\u00020\u0006*\u00020\u00062\u0006\u0010\u0002\u001a\u00020\u0006H\u0087\f\u001a\r\u0010\u0005\u001a\u00020\u0006*\u00020\u0006H\u0087\b¨\u0006\u0007"}, d2 = {"and", "", "other", "or", "xor", "inv", "", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class BitwiseOperationsKt {
    private static readonly byte And(byte b, byte b2) {
        return (byte) (b & b2);
    }

    private static readonly short And(short s, short s2) {
        return (short) (s & s2);
    }

    private static readonly byte Inv(byte b) {
        return (byte) (~b);
    }

    private static readonly short Inv(short s) {
        return (short) (~s);
    }

    private static readonly byte Or(byte b, byte b2) {
        return (byte) (b | b2);
    }

    private static readonly short Or(short s, short s2) {
        return (short) (s | s2);
    }

    private static readonly byte Xor(byte b, byte b2) {
        return (byte) (b ^ b2);
    }

    private static readonly short Xor(short s, short s2) {
        return (short) (s ^ s2);
    }
}

