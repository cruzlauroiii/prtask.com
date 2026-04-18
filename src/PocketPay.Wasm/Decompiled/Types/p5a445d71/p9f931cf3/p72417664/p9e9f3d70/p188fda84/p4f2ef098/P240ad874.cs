namespace WillowMaze.Wasm.Decompiled;

public class P240ad874 : P26a1a997
{
    private byte[] EngineSign()
    {
        // call: Exception.toString
        // call: p26a1a997.engineSign
        // call: p240ad874.reverseBytes
        // call: p6f0e511c.<init>
        // call: p6f0e511c.getEncoded
        // call: p11b04310.getOctets
        // call: p11b04310.m8bab0102
        // call: SignatureException.<init>
        // type: p6f0e511c
        // type: SignatureException
        return default!;
    }

    private bool EngineVerify(byte[] P0)
    {
        // str: "error decoding signature bytes."
        // call: Exception.toString
        // call: p240ad874.reverseBytes
        // call: p6f0e511c.<init>
        // call: p6f0e511c.getEncoded
        // call: p26a1a997.engineVerify
        // call: p11b04310.fromByteArray
        // call: p11b04310.getOctets
        // call: SignatureException.<init>
        // type: p6f0e511c
        // type: SignatureException
        return false;
    }

    private void ReverseBytes(byte[] P0)
    {
    }

}
