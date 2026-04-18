namespace WillowMaze.Wasm.Decompiled;

public class Pd13f0ad0
{
    private static int F04af2474;
    private static int F1473579b;
    private static int F14c14333;
    private static string F17d0ce3a;
    private static string F2005ec9b;
    private static int F2aa12717;
    public static pd13f0ad0 F3045f7c3;
    private static int F39dd12ab;
    private static int F3ea13de5;
    public static pd13f0ad0 F4343aa51;
    private static string F43ad3e75;
    private static string F4a24a50b;
    private static int F4fd89f18;
    private static int F5021954f;
    private static int F546dea48;
    private static int F59388c51;
    private static int F6cfcecfd;
    private static int F73a7ddb1;
    public static pd13f0ad0 F76425f17;
    private static int F798557f0;
    private static int F7da8fbd2;
    private static int F80239f88;
    private static int F83174460;
    private static string F84b1ce11;
    private static int F892a9600;
    private static int F896fd198;
    private static string F8c4f4370;
    private static int Fa01f1fd8;
    private static int Fa422484c;
    private static int Fa56018ac;
    private static int Fbc7d5e31;
    private static int Fbcaa8584;
    private static int Fbd63ba18;
    private static string Fc4bd4dae;
    private static int Fc5f34279;
    private static int Fc6a27360;
    private static string Fd34508ba;
    private static int Fd76b34ff;
    private static int Fde0e705a;
    private static string Fe39c23c8;
    private static int Ff0247d01;
    private static string Ff0ce71b4;
    private static int Ff2643098;
    private static string Ff4a47f9c;
    private static string Ff5846713;
    private static int Ff5f9a22c;
    private static string Ffb457131;

    private byte[] Mc136ce98(string P0)
    {
        // str: "toCharArray(...)"
        // str: "50eb1885fcbc6c2c8e6c7afbc6cb5b3b99c89702515fc5d445fcdab9459752003aa961349e8524404da11266b4dc"
        // str: "037ad4eb0ecbae297e0db815cfe82c6fcc3d84b9c1c8d3ed18462a49a11efc"
        // call: DecryptString.decryptString
        // call: Intrinsics.checkNotNullExpressionValue
        // call: string.toCharArray
        // call: SecretKeyFactory.getInstance
        // call: byte[].<init>
        // call: SecretKeyFactory.generateSecret
        // call: SecretKey.getEncoded
        // call: PBEKeySpec.<init>
        // call: p5e5d682d.decode
        // field: p2b3583e6.p5ae9b7f2.p5e5d682d.f76425f17
        // field: p2b3583e6.p5ae9b7f2.pd13f0ad0.f8c4f4370
        // type: byte[]
        // type: PBEKeySpec
        return default!;
    }

    private byte[] Md4723c26(byte[] P0, int P1, int P2)
    {
        // call: ArraysKt.copyInto
        return default!;
    }

    private byte[] Md844b504(byte[][] P0)
    {
        // call: ArraysKt.copyInto
        return default!;
    }

    private byte[] Mda11e2bd()
    {
        // call: Random.nextBytes
        // call: Random.<init>
        // type: Random
        return default!;
    }

    public string Decrypt(string P0, string P1)
    {
        // str: "key"
        // str: "UTF_8"
        // str: "85a89f5a288073ad750649a4ad480c01de53f7c24a955cd8a3321f20cd39f2cb34774192e37cf5d1ba922dd213e0249a"
        // str: "encryptedText"
        // call: Intrinsics.checkNotNullParameter
        // call: string.<init>
        // call: DecryptString.decryptString
        // call: System.Security.Cryptography.Aes.init
        // call: IvParameterSpec.<init>
        // call: Intrinsics.checkNotNull
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pd13f0ad0.mc136ce98
        // call: pd13f0ad0.md4723c26
        // call: p5e5d682d.decode
        // call: System.Security.Cryptography.Aes.doFinal
        // call: System.Security.Cryptography.Aes.getInstance
        // field: java.nio.charset.StandardCharsets.UTF_8
        // field: p2b3583e6.p5ae9b7f2.p5e5d682d.f76425f17
        // type: string
        // type: IvParameterSpec
        return string.Empty;
    }

    public string Encrypt(string P0, string P1)
    {
        // str: "key"
        // str: "90915ed36aa2007dd1131f3b4612ca3fc4f724903570209cb83c405dffebec34248aa80c000fea5a26b611f0d7d66780"
        // str: "UTF_8"
        // str: "text"
        // str: "getBytes(...)"
        // call: pd13f0ad0.md844b504
        // call: pd13f0ad0.mc136ce98
        // call: pd13f0ad0.mda11e2bd
        // call: string.getBytes
        // call: System.Security.Cryptography.Aes.getInstance
        // call: p5e5d682d.bytesToHex
        // call: IvParameterSpec.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: System.Security.Cryptography.Aes.init
        // call: DecryptString.decryptString
        // call: System.Security.Cryptography.Aes.doFinal
        // field: p2b3583e6.p5ae9b7f2.p5e5d682d.f76425f17
        // field: java.nio.charset.StandardCharsets.UTF_8
        // type: IvParameterSpec
        return string.Empty;
    }

    public string GenerateKey(string P0, string P1, bool P2)
    {
        // str: "deviceId"
        // str: "rqUuid"
        // call: StringBuilder.toString
        // call: int.parseInt
        // call: p1c60700c.sha256custom
        // call: StringBuilder.append
        // call: StringsKt.reversed
        // call: Intrinsics.checkNotNullParameter
        // call: StringsKt.takeLast
        // call: StringsKt.take
        // call: object.toString
        // call: p5e5d682d.bytesToHex
        // call: StringBuilder.<init>
        // field: p2b3583e6.p5ae9b7f2.p1c60700c.f76425f17
        // field: p2b3583e6.p5ae9b7f2.p5e5d682d.f76425f17
        // type: StringBuilder
        return string.Empty;
    }

    public string RequestBodyToString(p0d3cf03b P0)
    {
        // str: "requestBody"
        // call: p0d3cf03b.writeTo
        // call: p7e62bc34.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.readUtf8
        // type: p7e62bc34
        return string.Empty;
    }

}
