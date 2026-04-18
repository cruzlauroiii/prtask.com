namespace WillowMaze.Wasm.Decompiled;

public class P17a30da3 : SignatureSpi
{
    private p42a46bbe F08406a6e;
    private p234a7530 F1b02f3cb;
    private p42a46bbe F221c9c1d;
    private p234a7530 F7e017ad6;
    private p42a46bbe F8b077b68;
    private p234a7530 F943b0b0b;
    private p42a46bbe F9a20a521;
    private pe5cfc515 Fa277382f;
    private pe5cfc515 Fc10f7796;
    private pe5cfc515 Fc86dec11;
    private p42a46bbe Fe5c1e75f;
    private p234a7530 Ff9d92139;

    private string M3216fd9c(object P0)
    {
        // call: Type.getName
        // call: object.getClass
        return string.Empty;
    }

    private byte[] M5d16b36b(byte[] P0)
    {
        // str: "a5ca69ca453efcd61a31da4f75d8f0c792eef289d5cef1f71b257cce94aea3"
        // call: p63cfd610.<init>
        // call: DecryptString.decryptString
        // call: p63cfd610.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.f7e017ad6
        // type: p63cfd610
        return default!;
    }

    private object EngineGetParameter(string P0)
    {
        return default!;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // str: "Supplied key ("
        // str: ") is not a RSAPrivateKey instance"
        // call: InvalidKeyException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: pe5cfc515.reset
        // call: p42a46bbe.init
        // call: StringBuilder.<init>
        // call: p17a30da3.m3216fd9c
        // call: pf3488fc4.m02ea6360
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.f08406a6e
        // type: StringBuilder
        // type: InvalidKeyException
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: ") is not a RSAPublicKey instance"
        // str: "Supplied key ("
        // call: StringBuilder.append
        // call: pe5cfc515.reset
        // call: InvalidKeyException.<init>
        // call: p42a46bbe.init
        // call: StringBuilder.toString
        // call: p17a30da3.m3216fd9c
        // call: pf3488fc4.mc2499d21
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.f08406a6e
        // type: StringBuilder
        // type: InvalidKeyException
    }

    private void EngineSetParameter(string P0, object P1)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

    private void EngineSetParameter(AlgorithmParameterSpec P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

    private byte[] EngineSign()
    {
        // str: "key too small for signature type"
        // call: Exception.toString
        // call: SignatureException.<init>
        // call: pe5cfc515.doFinal
        // call: p17a30da3.m5d16b36b
        // call: p42a46bbe.processBlock
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.f08406a6e
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: pe5cfc515.getDigestSize
        // call: pff43b8de.m66e765de
        // call: pe5cfc515.doFinal
        // call: p42a46bbe.processBlock
        // call: p17a30da3.m5d16b36b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p17a30da3.f08406a6e
        return false;
    }

}
