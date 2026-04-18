namespace WillowMaze.Wasm.Decompiled;

public interface P20cbdf86
{
    pdf338aa3 GetCipher();
    pa6f0eace GetCompression();
    void NotifyAlertRaised(short P0, short P1, string P2, Exception P3);
    void NotifyAlertReceived(short P0, short P1);
    void NotifyHandshakeComplete();
    void NotifySecureRenegotiation(bool P0);
    bool ShouldUseGMTUnixTime();
}
