namespace WillowMaze.Wasm.Decompiled;

public class Pd4093fa8 : P4846363f
{
    private PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "openssh private key is not dsa privare key"
        // call: pe0946edd.getQ
        // call: DSAPrivateKeySpec.<init>
        // call: pacb8a170.getParameters
        // call: p4846363f.engineGeneratePrivate
        // call: pe0946edd.getP
        // call: pacb8a170.getX
        // call: pc8fff9db.m72ace772
        // call: p8ffa3299.<init>
        // call: p56177f0b.getEncoded
        // call: pe0946edd.getG
        // call: IllegalArgumentException.<init>
        // call: pd4093fa8.engineGeneratePrivate
        // type: IllegalArgumentException
        // type: DSAPrivateKeySpec
        // type: p8ffa3299
        return default!;
    }

    private PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "invalid KeySpec: "
        // str: "openssh public key is not dsa public key"
        // call: p4846363f.engineGeneratePublic
        // call: StringBuilder.toString
        // call: pd4093fa8$1.<init>
        // call: p0a9c4e5e.getEncoded
        // call: pf574193a.getParameters
        // call: pe0946edd.getG
        // call: IllegalArgumentException.<init>
        // call: p84e9a1d3.<init>
        // call: StringBuilder.append
        // call: pe0946edd.getP
        // call: StringBuilder.<init>
        // call: pd4093fa8.engineGeneratePublic
        // call: pf574193a.getY
        // call: Exception.getMessage
        // call: pcc11822a.m5355d3b5
        // call: pe0946edd.getQ
        // call: DSAPublicKeySpec.<init>
        // type: IllegalArgumentException
        // type: DSAPublicKeySpec
        // type: StringBuilder
        // type: p84e9a1d3
        // type: pd4093fa8$1
        return default!;
    }

    private KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "unable to produce encoding: "
        // call: DSAParams.getQ
        // call: DSAParams.getP
        // call: DSAPrivateKey.getParams
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: DSAParams.getG
        // call: DSAPrivateKey.getX
        // call: IllegalArgumentException.<init>
        // call: DSAPublicKey.getY
        // call: DSAPublicKey.getParams
        // call: pe0946edd.<init>
        // call: pf574193a.<init>
        // call: pcc11822a.m092fb0ff
        // call: p0a9c4e5e.<init>
        // call: IOException.getMessage
        // call: StringBuilder.append
        // call: DSAPublicKeySpec.<init>
        // call: Type.isAssignableFrom
        // call: p4846363f.engineGetKeySpec
        // call: pacb8a170.<init>
        // type: StringBuilder
        // type: p56177f0b
        // type: DSAPrivateKeySpec
        // type: p0a9c4e5e
        // type: pf574193a
        // type: pe0946edd
        // type: DSAPublicKeySpec
        // type: pacb8a170
        // type: IllegalArgumentException
        return default!;
    }

    private Key EngineTranslateKey(Key P0)
    {
        // str: "key type unknown"
        // call: p8ffa3299.<init>
        // call: InvalidKeyException.<init>
        // call: p84e9a1d3.<init>
        // type: p8ffa3299
        // type: InvalidKeyException
        // type: p84e9a1d3
        return default!;
    }

    public PrivateKey GeneratePrivate(p811299f8 P0)
    {
        // str: " in key not recognised"
        // str: "algorithm identifier "
        // call: StringBuilder.<init>
        // call: pff72be26.m0b4dfdc0
        // call: StringBuilder.append
        // call: p234a7530.getAlgorithm
        // call: StringBuilder.toString
        // call: p8ffa3299.<init>
        // call: IOException.<init>
        // call: p811299f8.getPrivateKeyAlgorithm
        // type: StringBuilder
        // type: p8ffa3299
        // type: IOException
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // str: " in key not recognised"
        // str: "algorithm identifier "
        // call: p3cdccfc9.getAlgorithm
        // call: IOException.<init>
        // call: p234a7530.getAlgorithm
        // call: StringBuilder.append
        // call: pff72be26.m0b4dfdc0
        // call: StringBuilder.toString
        // call: p84e9a1d3.<init>
        // call: StringBuilder.<init>
        // type: IOException
        // type: StringBuilder
        // type: p84e9a1d3
        return default!;
    }

}
