namespace WillowMaze.Wasm.Decompiled;

public interface P97f30e5f
{
    p97f30e5f M8bab0102(p63d209b5 P0);
    byte[] DecryptDataFromJwe(byte[] P0, byte[] P1, byte[] P2);
    byte[] DecryptDataFromStorage(p30582d95 P0, byte[] P1);
    byte[] DecryptKeyForJwe(byte[] P0, p30582d95 P1, string P2);
    byte[] DecryptWithCipher(System.Security.Cryptography.Aes P0, byte[] P1);
    byte[] EncryptDataForJwe(byte[] P0, byte[] P1, byte[] P2);
    byte[] EncryptDataForStorage(p30582d95 P0, byte[] P1);
    byte[] EncryptKeyForJwe(byte[] P0, RSAPublicKey P1);
    byte[] EncryptSensitiveData(byte[] P0, RSAPublicKey P1);
    byte[] EncryptWithCipher(System.Security.Cryptography.Aes P0, byte[] P1);
    byte[] GenHMac(byte[] P0, byte[] P1, byte[] P2, byte[] P3);
    System.Security.Cryptography.Aes GetDecryptionCipher(p30582d95 P0, byte[] P1);
    System.Security.Cryptography.Aes GetEncryptionCipher(p30582d95 P0);
    byte[] GetSignatureForJws(string P0, p30582d95 P1);
    bool VerifyJwsSignature(string P0, byte[] P1, RSAPublicKey P2);
}
