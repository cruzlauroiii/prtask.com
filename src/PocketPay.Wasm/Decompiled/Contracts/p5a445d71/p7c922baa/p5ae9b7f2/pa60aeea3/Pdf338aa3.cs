namespace WillowMaze.Wasm.Decompiled;

public interface Pdf338aa3
{
    byte[] DecodeCiphertext(long P0, short P1, byte[] P2, int P3, int P4);
    byte[] EncodePlaintext(long P0, short P1, byte[] P2, int P3, int P4);
    int GetPlaintextLimit(int P0);
}
