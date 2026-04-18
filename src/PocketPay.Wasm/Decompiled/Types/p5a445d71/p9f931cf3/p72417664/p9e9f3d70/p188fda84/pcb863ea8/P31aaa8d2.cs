namespace WillowMaze.Wasm.Decompiled;

public class P31aaa8d2 : P0529b267
{
    private p42a46bbe F08406a6e;
    private AlgorithmParameters F20c904fb;
    private AlgorithmParameterSpec F303fde02;
    private p42a46bbe F369f65f8;
    private AlgorithmParameters F57af1c01;
    private AlgorithmParameterSpec Fa731a5a7;
    private AlgorithmParameterSpec Fc965120b;
    private p0529b267$pf0d24f46 Fea03596c;
    private p0529b267$pf0d24f46 Ff55b8df9;
    private AlgorithmParameters Ffb8ea07f;

    private void M8872f202(OAEPParameterSpec P0)
    {
        // str: "no match on OAEP constructor for digest algorithm: "
        // call: NoSuchPaddingException.<init>
        // call: p599eb12d.<init>
        // call: p92e20001.me0825354
        // call: StringBuilder.toString
        // call: PSource$PSpecified.getValue
        // call: MGF1ParameterSpec.getDigestAlgorithm
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: OAEPParameterSpec.getPSource
        // call: OAEPParameterSpec.getMGFParameters
        // call: pa06e6d1d.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f303fde02
        // type: StringBuilder
        // type: pa06e6d1d
        // type: p599eb12d
        // type: NoSuchPaddingException
    }

    private byte[] Me09f6787()
    {
        // str: "unable to decrypt block"
        // call: p0529b267$pf0d24f46.erase
        // call: pec7a0e67.<init>
        // call: p0529b267$pf0d24f46.getBuf
        // call: p0529b267$pf0d24f46.size
        // call: p42a46bbe.processBlock
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.ff55b8df9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f08406a6e
        // type: pec7a0e67
        return default!;
    }

    private int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "output buffer too short for input."
        // str: "too much data for ElGamal block"
        // call: ArrayIndexOutOfBoundsException.<init>
        // call: p0529b267$pf0d24f46.write
        // call: ShortBufferException.<init>
        // call: p42a46bbe.getInputBlockSize
        // call: p31aaa8d2.me09f6787
        // call: p31aaa8d2.engineGetOutputSize
        // call: p0529b267$pf0d24f46.size
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.ff55b8df9
        // type: ArrayIndexOutOfBoundsException
        // type: ShortBufferException
        return 0;
    }

    private byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // str: "too much data for ElGamal block"
        // call: p31aaa8d2.me09f6787
        // call: ArrayIndexOutOfBoundsException.<init>
        // call: p42a46bbe.getInputBlockSize
        // call: p0529b267$pf0d24f46.size
        // call: p0529b267$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.ff55b8df9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f08406a6e
        // type: ArrayIndexOutOfBoundsException
        return default!;
    }

    private int EngineGetBlockSize()
    {
        // call: p42a46bbe.getInputBlockSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f08406a6e
        return 0;
    }

    private int EngineGetKeySize(Key P0)
    {
        // str: "not an ElGamal key!"
        // call: pdcabce2f.getP
        // call: System.Numerics.BigInteger.bitLength
        // call: p65f7e056.getParameters
        // call: IllegalArgumentException.<init>
        // call: DHKey.getParams
        // call: DHParameterSpec.getP
        // type: IllegalArgumentException
        return 0;
    }

    private int EngineGetOutputSize(int P0)
    {
        // call: p42a46bbe.getOutputBlockSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f08406a6e
        return 0;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        // str: "OAEP"
        // call: Exception.<init>
        // call: p31aaa8d2.createParametersInstance
        // call: AlgorithmParameters.init
        // call: Exception.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f20c904fb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f303fde02
        // type: Exception
        return default!;
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "can't handle parameters in ElGamal"
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

    private void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "Eeeek! "
        // call: p31aaa8d2.engineInit
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: InvalidKeyException.<init>
        // call: InvalidAlgorithmParameterException.toString
        // type: InvalidKeyException
        // type: StringBuilder
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "unkown MGF parameters"
        // str: "13396577c70ab4bb2a9725b6f08a533df234af0bbaee8bd3d50be709b63d67c4"
        // str: "unknown parameter type."
        // str: "unknown key type passed to ElGamal"
        // str: "no match on MGF digest algorithm: "
        // str: " passed to ElGamal"
        // str: "unknown mask generation function specified"
        // str: "unknown opmode "
        // str: "no match on digest algorithm: "
        // call: StringBuilder.append
        // call: InvalidKeyException.<init>
        // call: OAEPParameterSpec.getMGFParameters
        // call: InvalidAlgorithmParameterException.<init>
        // call: StringBuilder.toString
        // call: OAEPParameterSpec.getMGFAlgorithm
        // call: pc89bbf9f.mc2499d21
        // call: StringBuilder.<init>
        // call: OAEPParameterSpec.getDigestAlgorithm
        // call: p364bf33a.getId
        // call: p42a46bbe.init
        // call: pc89bbf9f.m02ea6360
        // call: OAEPParameterSpec.getPSource
        // call: PSource$PSpecified.getValue
        // call: DecryptString.decryptString
        // call: string.equalsIgnoreCase
        // call: MGF1ParameterSpec.getDigestAlgorithm
        // call: p4715f007.<init>
        // call: pa06e6d1d.<init>
        // call: InvalidParameterException.<init>
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f303fde02
        // type: InvalidAlgorithmParameterException
        // type: pa06e6d1d
        // type: StringBuilder
        // type: InvalidKeyException
        // type: p599eb12d
        // type: p4715f007
        // type: InvalidParameterException
    }

    private void EngineSetMode(string P0)
    {
        // str: "can't support mode "
        // str: "ECB"
        // str: "9df9bd4e9abc7e7301c0a628f32fe49215ba9944faa1c6438d4e024f5e794874"
        // call: string.equals
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: NoSuchAlgorithmException.<init>
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // call: p89be9433.mb8a8247c
        // type: StringBuilder
        // type: NoSuchAlgorithmException
    }

    private void EngineSetPadding(string P0)
    {
        // str: "OAEPWITHSHA3-256ANDMGF1PADDING"
        // str: "SHA3-512"
        // str: "OAEPWITHMD5ANDMGF1PADDING"
        // str: "89c4ce67b94e6650a4244ad34256eb1e392ad831859a4b16deaf412c4bff842fb54e60"
        // str: "b45bbfc6de51b505862d4b4b43638b89529188e05796517242c6da1fae48a3789fc974"
        // str: "OAEPWITHSHA256ANDMGF1PADDING"
        // str: "OAEPWITHSHA224ANDMGF1PADDING"
        // str: " unavailable with ElGamal."
        // str: "OAEPWITHSHA3-512ANDMGF1PADDING"
        // str: "OAEPWITHSHA512ANDMGF1PADDING"
        // str: "8391e74c0010db626e46ec8993d21e994a7a782e53198779e455efce1b50feeaf81f53"
        // str: "MD5"
        // str: "ISO9796-1PADDING"
        // str: "OAEPWITHSHA3-384ANDMGF1PADDING"
        // str: "SHA3-224"
        // str: "5c65538db1b72bb20f80fc9d57148ce5f60d0020e6e99863580d04cae867e4cf"
        // str: "29293f45abf64b5f4eaae1d58b02d167f108363863e98db76a7a42136966c132d8728b"
        // str: "NOPADDING"
        // str: "SHA3-384"
        // str: "789fb2fae84e63b61116ec5527a691d9ca01fbc92aa8ea15079bd48b64a0107524a83ce8"
        // call: string.equals
        // call: p31aaa8d2.m8872f202
        // call: p599eb12d.<init>
        // call: OAEPParameterSpec.<init>
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // call: StringBuilder.append
        // call: p89be9433.mb8a8247c
        // call: MGF1ParameterSpec.<init>
        // call: pb4e47103.<init>
        // call: StringBuilder.<init>
        // call: p2ddea612.<init>
        // call: NoSuchPaddingException.<init>
        // field: javax.crypto.spec.PSource$PSpecified.DEFAULT
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.f08406a6e
        // field: javax.crypto.spec.OAEPParameterSpec.DEFAULT
        // field: java.security.spec.MGF1ParameterSpec.SHA384
        // field: java.security.spec.MGF1ParameterSpec.SHA512
        // field: java.security.spec.MGF1ParameterSpec.SHA256
        // type: MGF1ParameterSpec
        // type: p599eb12d
        // type: pb4e47103
        // type: p2ddea612
        // type: OAEPParameterSpec
        // type: StringBuilder
        // type: NoSuchPaddingException
    }

    private int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: p0529b267$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.ff55b8df9
        return 0;
    }

    private byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: p0529b267$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.p31aaa8d2.ff55b8df9
        return default!;
    }

}
