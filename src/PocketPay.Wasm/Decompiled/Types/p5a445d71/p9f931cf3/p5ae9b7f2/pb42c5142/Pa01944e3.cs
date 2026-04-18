namespace WillowMaze.Wasm.Decompiled;

public class Pa01944e3 : Pd1977c1b
{
    private static Hashtable F38bc3f68;
    private static Hashtable F723b5d8e;
    private static Hashtable Fb249009f;
    private static Hashtable Fcd9c9b9d;
    private readonly p234a7530 F33c7ab86;
    private bool F353b44c5;
    private bool F39c7e2db;
    private readonly p42a46bbe F3b6fd14c;
    private readonly p234a7530 F64bfb11e;
    private readonly p234a7530 F7e017ad6;
    private readonly p42a46bbe F80d87361;
    private readonly p42a46bbe F81847f5e;
    private readonly p234a7530 F97b12b5b;
    private readonly p234a7530 F98ae46f8;
    private readonly pe5cfc515 Fae898dc4;
    private readonly pe5cfc515 Fc10f7796;
    private readonly p42a46bbe Fcf3f9ffb;
    private readonly pe5cfc515 Fddf36901;
    private readonly p42a46bbe Ff52b9b44;
    private readonly pe5cfc515 Ff8ef92f9;

    private byte[] M5d16b36b(byte[] P0)
    {
        // str: "4f62514e8d79989d777f290c53145b898bb645d1c07456ddc96bcb33676f49"
        // str: "malformed DigestInfo for NONEwithRSA hash: "
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // call: p63cfd610.m8bab0102
        // call: IllegalArgumentException.getMessage
        // call: p63cfd610.<init>
        // call: StringBuilder.<init>
        // call: p63cfd610.getEncoded
        // call: StringBuilder.append
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.f7e017ad6
        // type: StringBuilder
        // type: IOException
        // type: p63cfd610
        return default!;
    }

    public byte[] GenerateSignature()
    {
        // str: "RSADigestSigner not initialised for signature generation."
        // str: "unable to encode signature: "
        // call: StringBuilder.<init>
        // call: pe5cfc515.getDigestSize
        // call: IllegalStateException.<init>
        // call: pe5cfc515.doFinal
        // call: pa01944e3.m5d16b36b
        // call: p42a46bbe.processBlock
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: IOException.getMessage
        // call: p48d8e57f.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.f80d87361
        // type: p48d8e57f
        // type: IllegalStateException
        // type: StringBuilder
        return default!;
    }

    public string GetAlgorithmName()
    {
        // str: "withRSA"
        // call: pe5cfc515.getAlgorithmName
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.fc10f7796
        // type: StringBuilder
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "verification requires public key"
        // str: "signing requires private key"
        // call: pa01944e3.reset
        // call: pcfffbc4a.isPrivate
        // call: p4715f007.getParameters
        // call: IllegalArgumentException.<init>
        // call: p42a46bbe.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.f80d87361
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.f39c7e2db
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.fc10f7796
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.fc10f7796
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.fc10f7796
    }

    public bool VerifySignature(byte[] P0)
    {
        // str: "RSADigestSigner not initialised for verification"
        // call: pff43b8de.m66e765de
        // call: pe5cfc515.getDigestSize
        // call: IllegalStateException.<init>
        // call: pe5cfc515.doFinal
        // call: p42a46bbe.processBlock
        // call: pa01944e3.m5d16b36b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pa01944e3.f80d87361
        // type: IllegalStateException
        return false;
    }

}
