namespace WillowMaze.Wasm.Decompiled;

public interface P15bc97bf
{
    string CreateJws(p62c91bb3 P0, p82fb9ae9 P1, string P2);
    string DecryptFromJwe(p62c91bb3 P0, p82fb9ae9 P1, string P2);
    string EncryptToJwe(p62c91bb3 P0, string P1);
    long GetAppNonce(p62c91bb3 P0, bool P1);
    string GetAuthorizationToken(p62c91bb3 P0);
    Gson GetGson();
    byte[] GetHardwareFingerprint();
    string GetSecurityChecksResult(p62c91bb3 P0, p9e5254cf P1);
    p1f3f6c41 GetTophNetworkSettings();
    string ParseJws(p62c91bb3 P0, string P1);
}
