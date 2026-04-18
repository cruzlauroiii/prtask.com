namespace WillowMaze.Wasm.Decompiled;

public interface Pf4bdb993
{
    byte[] GetMixedSeed(int P0);
    byte[] MixSeedWithLocal(byte[] P0);
    void ResetSeed();
    Completable UpdateSeed(string P0);
}
