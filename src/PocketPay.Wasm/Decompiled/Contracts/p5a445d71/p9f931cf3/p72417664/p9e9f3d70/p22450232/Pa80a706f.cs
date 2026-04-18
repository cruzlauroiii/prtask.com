namespace WillowMaze.Wasm.Decompiled;

public interface Pa80a706f
{
    void AddAlgorithm(string P0, string P1);
    void AddAlgorithm(string P0, p364bf33a P1, string P2);
    void AddAttributes(string P0, Dictionary<string, object> P1);
    void AddKeyInfoConverter(p364bf33a P0, pae2f7198 P1);
    pae2f7198 GetKeyInfoConverter(p364bf33a P0);
    bool HasAlgorithm(string P0, string P1);
    void SetParameter(string P0, object P1);
}
