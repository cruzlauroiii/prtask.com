namespace WillowMaze.Wasm.Decompiled;

public interface P1b0ecc4e_p0bb4c52b
{
    void AckSettings();
    void AlternateService(int P0, string P1, p58efa9e8 P2, string P3, int P4, long P5);
    void Data(bool P0, int P1, pcc81e3f6 P2, int P3);
    void GoAway(int P0, p9bc96b38 P1, p58efa9e8 P2);
    void Headers(bool P0, int P1, int P2, List<object> P3);
    void Ping(bool P0, int P1, int P2);
    void Priority(int P0, int P1, int P2, bool P3);
    void PushPromise(int P0, int P1, List<object> P2);
    void RstStream(int P0, p9bc96b38 P1);
    void Settings(bool P0, pf4f70727 P1);
    void WindowUpdate(int P0, long P1);
}
