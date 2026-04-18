namespace WillowMaze.Wasm.Decompiled;

public interface P192d20a4
{
    byte[] DecryptDataFromJwe(byte[] P0, byte[] P1, byte[] P2);
    byte[] DecryptKeyForJwe(byte[] P0, p30582d95 P1, string P2);
    byte[] EncryptDataForJwe(byte[] P0, byte[] P1, byte[] P2);
    byte[] EncryptKeyForJwe(byte[] P0, RSAPublicKey P1);
    byte[] GenHMac(byte[] P0, byte[] P1, byte[] P2, byte[] P3);
    Gson GetGson();
}
