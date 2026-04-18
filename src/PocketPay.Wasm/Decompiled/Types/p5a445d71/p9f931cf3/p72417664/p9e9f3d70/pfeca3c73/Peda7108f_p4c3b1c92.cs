namespace WillowMaze.Wasm.Decompiled;

public abstract class Peda7108f_p4c3b1c92 : P29bd365e
{
    private byte[] F0b688c81;
    private p364bf33a F56ba422e;
    private p364bf33a F88497db0;
    private p364bf33a F9e635b8c;
    private p364bf33a Fa4167731;
    private p364bf33a Facdb896b;
    private byte[] Fdc9c16cf;
    private byte[] Ff0b53b2d;

    private static p364bf33a M07095bac(string P0)
    {
        // str: "Unknown SBOX name: "
        // call: p89be9433.mb8a8247c
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Dictionary<string, object>.get
        // call: StringBuilder.append
        // call: peda7108f.mf23e8626
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private static p364bf33a M07095bac(byte[] P0)
    {
        // call: p9682f740.m875e8966
        // call: peda7108f$p4c3b1c92.m07095bac
        return default!;
    }

    private byte[] EngineGetEncoded()
    {
        // str: "ASN.1"
        // call: peda7108f$p4c3b1c92.engineGetEncoded
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "Unknown parameter format: "
        // call: peda7108f$p4c3b1c92.localGetEncoded
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: peda7108f$p4c3b1c92.isASN1FormatString
        // call: StringBuilder.append
        // type: IOException
        // type: StringBuilder
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "IvParameterSpec required to initialise a IV parameters algorithm parameters object"
        // call: IllegalArgumentException.getMessage
        // call: IvParameterSpec.getIV
        // call: pc5c653c7.getIV
        // call: InvalidParameterSpecException.<init>
        // call: pc5c653c7.getSBox
        // call: peda7108f$p4c3b1c92.m07095bac
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p4c3b1c92.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p4c3b1c92.fa4167731
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // str: "ASN.1"
        // call: peda7108f$p4c3b1c92.engineInit
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown parameter format: "
        // str: "Parameter parsing failed: "
        // str: "Encoded parameters cannot be null"
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: StringBuilder.<init>
        // call: NullPointerException.<init>
        // call: peda7108f$p4c3b1c92.localInit
        // call: Exception.getMessage
        // call: peda7108f$p4c3b1c92.isASN1FormatString
        // call: StringBuilder.append
        // type: StringBuilder
        // type: IOException
        // type: NullPointerException
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "AlgorithmParameterSpec not recognized: "
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pc5c653c7.<init>
        // call: Type.getName
        // call: StringBuilder.append
        // call: InvalidParameterSpecException.<init>
        // call: IvParameterSpec.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p4c3b1c92.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p4c3b1c92.fa4167731
        // type: IvParameterSpec
        // type: StringBuilder
        // type: AlgorithmParameterSpec
        // type: InvalidParameterSpecException
        // type: pc5c653c7
        return default!;
    }

    private byte[] LocalGetEncoded()
    {
        // call: p9f54f8ae.<init>
        // call: p9f54f8ae.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p4c3b1c92.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p4c3b1c92.fa4167731
        // type: p9f54f8ae
        return default!;
    }

    private void LocalInit(byte[] P0)
    {
    }

}
