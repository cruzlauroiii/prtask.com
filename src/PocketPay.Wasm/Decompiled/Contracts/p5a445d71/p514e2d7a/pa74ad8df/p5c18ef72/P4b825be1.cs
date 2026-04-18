namespace WillowMaze.Wasm.Decompiled;

public interface P4b825be1
{
    pf01db611 Get();
    pf01db611 GetOrNull();
    void LoadKoinModules(List<object> P0, bool P1);
    void LoadKoinModules(pe55f75a2 P0, bool P1);
    pfd5b298e StartKoin(Func<object, object> P0);
    pfd5b298e StartKoin(pfd5b298e P0);
    void StopKoin();
    void UnloadKoinModules(List<object> P0);
    void UnloadKoinModules(pe55f75a2 P0);
}
