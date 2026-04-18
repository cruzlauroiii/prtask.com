namespace WillowMaze.Wasm.Decompiled;

public class Pd775ff95
{
    public static int F001ea2de;
    public static int F05f35d8f;
    public static long F068df0dc;
    public static int F0c24fc7c;
    public static int F0c9da2a7;
    public static int F0e2c3bba;
    public static int F0ef32437;
    public static int F1124f269;
    public static int F16292714;
    public static int F16cdc6bd;
    public static int F1f922ba7;
    public static int F23f80a77;
    public static int F2a27b543;
    public static int F2f7e2114;
    public static long F3214b733;
    public static int F36d17c90;
    public static long F3b4b879a;
    public static int F3bbf796d;
    public static int F3c5ad98a;
    public static int F3eb92ff1;
    public static int F497402f8;
    public static int F498f1219;
    public static string F4aec1411;
    public static int F4c04ac34;
    public static long F4cf9a908;
    public static int F4f1ba490;
    public static int F52f47211;
    public static int F5402af48;
    public static int F599d32a4;
    public static int F5f9e51d5;
    public static int F608b7cf4;
    public static int F65667482;
    public static int F65f926ad;
    public static int F66205e5e;
    public static long F67b45e84;
    public static int F684c351e;
    public static int F68f9d72d;
    public static int F6aa0277b;
    public static int F6ac77694;
    public static int F7272cddf;
    public static int F7315d056;
    public static long F7391c835;
    public static pd775ff95 F76425f17;
    public static int F7bf4246d;
    public static int F8293c416;
    public static int F833cfd7c;
    public static int F89053c80;
    public static int F89b75ce7;
    public static int F9399f374;
    public static int F9567b63d;
    public static int F9ad46326;
    public static string F9c703a22;
    public static int Fa3144957;
    public static int Fa543bba3;
    public static int Fa5fa611b;
    public static string Fa9136d41;
    public static long Fad016c0b;
    public static int Fb15dfa51;
    public static int Fb79a3d84;
    public static long Fb994c47b;
    public static int Fbf0815d1;
    public static int Fc3be5f1d;
    public static int Fc7e19ac5;
    public static long Fcb3599e7;
    public static int Fd1270b78;
    public static int Fd1a0ff62;
    public static int Fd3f32ceb;
    public static int Fd950a023;
    public static long Fe074d3ed;
    public static int Fe129a498;
    public static int Fe144afd1;
    public static int Fe982372c;
    public static int Fe9ad8fef;
    public static string Fec5d4d84;
    public static int Fece68516;
    public static int Ff41c276f;
    public static int Ffac02413;
    public static pd775ff95 Ffbe66c45;
    public static int Ffcce4fd6;
    public static int Ffdc189c8;

    public string AcceptHeader(string P0)
    {
        // str: "key"
        // str: "eb5b5094c31b1bb24d4b2932580988e6cf2c5a4c3afc42ace6ef17075dadd2cf1e7e85c34bf9304eda14fd539fbd24bfa..."
        // call: DecryptString.decryptString
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: p58efa9e8.base64
        // call: p58efa9e8$p910eef8c.encodeUtf8
        // call: p58efa9e8.sha1
        // field: p38cb8f46.p58efa9e8.f910eef8c
        return string.Empty;
    }

    public string CloseCodeExceptionMessage(int P0)
    {
        // str: "Code must be in range [1000,5000): "
        // str: " is reserved and may not be used."
        // str: "Code "
        // call: StringBuilder.<init>
        // call: int.valueOf
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Intrinsics.stringPlus
        // type: StringBuilder
        return string.Empty;
    }

    public void ToggleMask(p7e62bc34$p43882412 P0, byte[] P1)
    {
        // str: "key"
        // str: "cursor"
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34$p43882412.next
        // field: p38cb8f46.p7e62bc34$p43882412.f7f021a14
        // field: p38cb8f46.p7e62bc34$p43882412.f8d777f38
        // field: p38cb8f46.p7e62bc34$p43882412.fea2b2676
    }

    public void ValidateCloseCode(int P0)
    {
        // call: IllegalArgumentException.<init>
        // call: pd775ff95.closeCodeExceptionMessage
        // call: Intrinsics.checkNotNull
        // call: object.toString
        // type: IllegalArgumentException
    }

}
