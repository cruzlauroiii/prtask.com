namespace WillowMaze.Wasm.Decompiled;

public interface Pd80e0f9b
{
    pe5cfc515 ForkPRFHash();
    byte[] GetFinalHash(short P0);
    void Init(pf1660074 P0);
    pd80e0f9b NotifyPRFDetermined();
    void SealHashAlgorithms();
    pd80e0f9b StopTracking();
    void TrackHashAlgorithm(short P0);
}
