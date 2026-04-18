namespace WillowMaze.Wasm.Decompiled;

public class Pffdc9a40
{
    private static char[] F1699db0d;
    private static System.Text.RegularExpressions.Regex F2dd17142;
    private static string F412d5bae;
    private static string F4e159b6e;
    private static string F672a6e41;
    private static char[] F73268c88;
    private static System.Text.RegularExpressions.Regex Fba8612c8;
    private static string Fbcd1756e;
    private static string Fd59d6987;
    private static char[] Fe632f76e;
    private p5109d534$p2bd4a59b F0e43a0d8;
    private pba07c23c F113e38fe;
    private pecf7e7e2$p2bd4a59b F125808b1;
    private readonly pdfadebdd F19c3df5f;
    private string F2124d052;
    private string F21afe87d;
    private readonly pdfadebdd F22c48431;
    private pecf7e7e2$p2bd4a59b F270a90b5;
    private readonly p15c2d85f$p2bd4a59b F2c6020ed;
    private readonly p883d7615$p2bd4a59b F3c5f877f;
    private readonly bool F3e2e02ea;
    private p5109d534$p2bd4a59b F42d82546;
    private readonly p15c2d85f$p2bd4a59b F55dc9c18;
    private pecf7e7e2$p2bd4a59b F5639fdbd;
    private p5109d534$p2bd4a59b F56944f85;
    private readonly pdfadebdd F5bc0d3d0;
    private string F6451b262;
    private pdfadebdd$p2bd4a59b F676e707b;
    private pdfadebdd$p2bd4a59b F6a7daf16;
    private string F6ab23305;
    private pba07c23c F6b5ac7c8;
    private readonly p883d7615$p2bd4a59b F70f6c619;
    private readonly string F73ebdc7a;
    private readonly p15c2d85f$p2bd4a59b F7eff8677;
    private p0d3cf03b F815e126f;
    private p0d3cf03b F841a2d68;
    private readonly bool F86a590ff;
    private readonly bool F88d5706a;
    private p5109d534$p2bd4a59b F8fdb6cc7;
    private pecf7e7e2$p2bd4a59b F9c750395;
    private readonly string F9dcb7200;
    private readonly bool Fa07d0be0;
    private readonly bool Fb05d1aa5;
    private string Fbbce94ca;
    private p0d3cf03b Fcf8bc4d6;
    private readonly pdfadebdd Fd0a5760c;
    private pecf7e7e2$p2bd4a59b Fd543e68f;
    private pba07c23c Fdf5feafa;
    private readonly p15c2d85f$p2bd4a59b Fe173452d;
    private readonly p15c2d85f$p2bd4a59b Fe50bac3f;
    private readonly string Fea9f6aca;
    private pba07c23c Feb8c68ce;
    private pdfadebdd$p2bd4a59b Fee019563;
    private pdfadebdd$p2bd4a59b Ffa807fc4;

    private static string CanonicalizeForPath(string P0, bool P1)
    {
        // str: "aa3afad5be31763e60df65fb10d9a433c7c30ca9e49cb9e02daa2184a1e27ba92975263619e3105d"
        // call: string.codePointAt
        // call: pffdc9a40.canonicalizeForPath
        // call: char.charCount
        // call: string.indexOf
        // call: p7e62bc34.readUtf8
        // call: p7e62bc34.<init>
        // call: string.length
        // call: p7e62bc34.writeUtf8
        // call: DecryptString.decryptString
        // type: p7e62bc34
        return string.Empty;
    }

    private static void CanonicalizeForPath(p7e62bc34 P0, string P1, int P2, int P3, bool P4)
    {
        // str: "c711da706d5daeb69b8a282d5a63ed59bea425a9b142d0d750ddd6e34c6436ea1dd03373f4c1d51b"
        // call: p7e62bc34.readByte
        // call: string.codePointAt
        // call: DecryptString.decryptString
        // call: p7e62bc34.exhausted
        // call: char.charCount
        // call: p7e62bc34.<init>
        // call: p7e62bc34.writeUtf8CodePoint
        // call: p7e62bc34.writeByte
        // call: string.indexOf
        // field: paa20ed97.pffdc9a40.f73268c88
        // type: p7e62bc34
    }

    private void AddFormField(string P0, string P1, bool P2)
    {
        // call: p5109d534$p2bd4a59b.add
        // call: p5109d534$p2bd4a59b.addEncoded
        // field: paa20ed97.pffdc9a40.f8fdb6cc7
    }

    private void AddHeader(string P0, string P1)
    {
        // str: "53c6c3b59796ec881df1e2eb18d22db9f946c3c6f5675ab50069159b211140a537ebb47be781a6d6"
        // str: "Malformed content type: "
        // call: StringBuilder.toString
        // call: string.equalsIgnoreCase
        // call: IllegalArgumentException.<init>
        // call: p883d7615$p2bd4a59b.add
        // call: StringBuilder.append
        // call: pba07c23c.mb5eda0a7
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // field: paa20ed97.pffdc9a40.f70f6c619
        // field: paa20ed97.pffdc9a40.fdf5feafa
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    private void AddHeaders(p883d7615 P0)
    {
        // call: p883d7615$p2bd4a59b.addAll
        // field: paa20ed97.pffdc9a40.f70f6c619
    }

    private void AddPart(p883d7615 P0, p0d3cf03b P1)
    {
        // call: pecf7e7e2$p2bd4a59b.addPart
        // field: paa20ed97.pffdc9a40.f9c750395
    }

    private void AddPart(pecf7e7e2$p5bfce74a P0)
    {
        // call: pecf7e7e2$p2bd4a59b.addPart
        // field: paa20ed97.pffdc9a40.f9c750395
    }

    private void AddPathParam(string P0, string P1, bool P2)
    {
        // str: "}"
        // str: "@Path parameters shouldn't perform path traversal ('.' or '..'): "
        // str: "{"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: pffdc9a40.canonicalizeForPath
        // call: string.replace
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: System.Text.RegularExpressions.Regex.matcher
        // call: Matcher.matches
        // call: AssertionError.<init>
        // field: paa20ed97.pffdc9a40.f6ab23305
        // field: paa20ed97.pffdc9a40.f2dd17142
        // type: AssertionError
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    private void AddQueryParam(string P0, string P1, bool P2)
    {
        // str: ", Relative: "
        // str: "Malformed URL. Base: "
        // call: StringBuilder.append
        // call: pdfadebdd$p2bd4a59b.addQueryParameter
        // call: pdfadebdd.newBuilder
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pdfadebdd$p2bd4a59b.addEncodedQueryParameter
        // field: paa20ed97.pffdc9a40.f676e707b
        // field: paa20ed97.pffdc9a40.f6ab23305
        // field: paa20ed97.pffdc9a40.f22c48431
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    private void AddTag(Type P0, object P1)
    {
        // call: p15c2d85f$p2bd4a59b.tag
        // field: paa20ed97.pffdc9a40.f2c6020ed
    }

    private p15c2d85f$p2bd4a59b Get()
    {
        // str: "bbbb4475bfdb58e3fd174e5dd9a43c6bd2f163adaadec62aa319c8afbff10ae2b294243d50212bf9"
        // str: ", Relative: "
        // str: "Malformed URL. Base: "
        // call: IllegalArgumentException.<init>
        // call: pba07c23c.toString
        // call: StringBuilder.append
        // call: pdfadebdd$p2bd4a59b.build
        // call: p883d7615$p2bd4a59b.add
        // call: p15c2d85f$p2bd4a59b.method
        // call: pecf7e7e2$p2bd4a59b.build
        // call: pffdc9a40$pe21857d9.<init>
        // call: p5109d534$p2bd4a59b.build
        // call: p0d3cf03b.m76ea0beb
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // call: pdfadebdd.resolve
        // call: StringBuilder.<init>
        // call: p15c2d85f$p2bd4a59b.url
        // call: p883d7615$p2bd4a59b.build
        // call: p15c2d85f$p2bd4a59b.headers
        // field: paa20ed97.pffdc9a40.fb05d1aa5
        // field: paa20ed97.pffdc9a40.f22c48431
        // field: paa20ed97.pffdc9a40.f841a2d68
        // field: paa20ed97.pffdc9a40.f8fdb6cc7
        // field: paa20ed97.pffdc9a40.f6ab23305
        // field: paa20ed97.pffdc9a40.f70f6c619
        // field: paa20ed97.pffdc9a40.fdf5feafa
        // field: paa20ed97.pffdc9a40.f9c750395
        // field: paa20ed97.pffdc9a40.fea9f6aca
        // field: paa20ed97.pffdc9a40.f2c6020ed
        // field: paa20ed97.pffdc9a40.f676e707b
        // type: pffdc9a40$pe21857d9
        // type: StringBuilder
        // type: IllegalArgumentException
        return default!;
    }

    private void SetBody(p0d3cf03b P0)
    {
        // field: paa20ed97.pffdc9a40.f841a2d68
    }

    private void SetRelativeUrl(object P0)
    {
        // call: object.toString
        // field: paa20ed97.pffdc9a40.f6ab23305
    }

}
