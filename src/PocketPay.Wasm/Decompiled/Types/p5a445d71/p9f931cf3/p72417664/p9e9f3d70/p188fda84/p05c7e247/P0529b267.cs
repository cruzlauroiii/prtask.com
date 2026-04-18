namespace WillowMaze.Wasm.Decompiled;

public abstract class P0529b267 : CipherSpi
{
    private int F0cba3fc0;
    private Type[] F18cc1005;
    private readonly pb3b7fb02 F1f81cb8f;
    private AlgorithmParameters F20c904fb;
    private Type[] F23451fed;
    private pe229a672 F3259f81c;
    private int F4390aaf1;
    private Type[] F4c578f03;
    private byte[] F66b7f2a7;
    private int F6d60c4f5;
    private pe229a672 F930d1840;
    private byte[] F9392f9dc;
    private pe229a672 F9a2cceb3;
    private pe229a672 F9e53b30d;
    private readonly pb3b7fb02 Fa2ed4bcd;
    private int Fb3543101;
    private readonly pb3b7fb02 Fb8ecb0aa;
    private int Fdbdd5e27;
    private Type[] Fee64f5b2;
    private byte[] Ff0b53b2d;
    private pe229a672 Ff5ee7d6f;
    private byte[] Ff7578d20;
    private byte[] Ffbf46e51;
    private readonly pb3b7fb02 Ffde5d67b;
    private AlgorithmParameters Ffdebd84e;

    private AlgorithmParameters CreateParametersInstance(string P0)
    {
        // call: pb3b7fb02.createAlgorithmParameters
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267.ffde5d67b
        return default!;
    }

    private int EngineGetBlockSize()
    {
        return 0;
    }

    private byte[] EngineGetIV()
    {
        return default!;
    }

    private int EngineGetKeySize(Key P0)
    {
        // call: Key.getEncoded
        return 0;
    }

    private int EngineGetOutputSize(int P0)
    {
        return 0;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        return default!;
    }

    private void EngineSetMode(string P0)
    {
        // str: "can't support mode "
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: NoSuchAlgorithmException.<init>
        // type: NoSuchAlgorithmException
        // type: StringBuilder
    }

    private void EngineSetPadding(string P0)
    {
        // str: " unknown."
        // str: "Padding "
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: NoSuchPaddingException.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: NoSuchPaddingException
    }

    private Key EngineUnwrap(byte[] P0, string P1, int P2)
    {
        // str: "Unknown key type "
        // str: "Invalid key encoding."
        // str: "unable to unwrap"
        // str: " not supported"
        // str: ""
        // str: "algorithm "
        // call: p0529b267$1.<init>
        // call: InvalidKeyException.<init>
        // call: StringBuilder.toString
        // call: NoSuchProviderException.getMessage
        // call: IllegalBlockSizeException.getMessage
        // call: byte[].<init>
        // call: p811299f8.m8bab0102
        // call: p63d19d11.me72b28f9
        // call: StringBuilder.<init>
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p234a7530.getAlgorithm
        // call: StringBuilder.append
        // call: pb3b7fb02.createKeyFactory
        // call: X509EncodedKeySpec.<init>
        // call: KeyFactory.generatePublic
        // call: PKCS8EncodedKeySpec.<init>
        // call: KeyFactory.generatePrivate
        // call: string.equals
        // call: p21c8c989.getMessage
        // call: NoSuchAlgorithmException.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267.ffde5d67b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267.f9e53b30d
        // type: InvalidKeyException
        // type: StringBuilder
        // type: byte[]
        // type: X509EncodedKeySpec
        // type: PKCS8EncodedKeySpec
        // type: p0529b267$1
        return default!;
    }

    private byte[] EngineWrap(Key P0)
    {
        // str: "Cannot wrap key, null encoding."
        // call: p0529b267.engineDoFinal
        // call: pe229a672.wrap
        // call: Key.getEncoded
        // call: BadPaddingException.getMessage
        // call: InvalidKeyException.<init>
        // call: IllegalBlockSizeException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p0529b267.f9e53b30d
        // type: IllegalBlockSizeException
        // type: InvalidKeyException
        return default!;
    }

}
