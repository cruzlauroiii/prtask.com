namespace WillowMaze.Wasm.Decompiled;

public class P5fd96ef9 : StreamWriter
{
    private static int F5a54323b;
    private static int Fda783878;
    private readonly int F11603c91;
    private char[] F81d92dc1;
    private readonly int F9d1675f1;
    private readonly int Fc3ee6ce4;
    private char[] Fcb7e52b2;
    private readonly int Ff6598c3c;

    private void M3bdfbd08(string P0)
    {
        // str: "-----"
        // str: "87788d453183fad3024b7d14ab16b922c86582dbdd05bd3f7e82c0ab992e86089da627a52fa1ef"
        // call: StringBuilder.append
        // call: p5fd96ef9.newLine
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // call: p5fd96ef9.write
        // type: StringBuilder
    }

    private void M8fccf6a3(string P0)
    {
        // str: "d7d1542ad9526003aa61a98fa253a67eb09cd3195cfc450383d3a45da27618cba1cefbff7f"
        // str: "-----"
        // call: DecryptString.decryptString
        // call: p5fd96ef9.write
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: p5fd96ef9.newLine
        // call: StringBuilder.toString
        // type: StringBuilder
    }

    private void Md5e62e23(byte[] P0)
    {
        // call: p1eb445fa.m97a57645
        // call: p5fd96ef9.write
        // call: p5fd96ef9.newLine
        // field: p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p5fd96ef9.fcb7e52b2
    }

    public int GetOutputSize(p00f5edd4 P0)
    {
        // str: ": "
        // call: List<object>.isEmpty
        // call: p00f5edd4.getHeaders
        // call: List<object>.iterator
        // call: string.length
        // call: IEnumerator<object>.next
        // call: p00f5edd4.getContent
        // call: IEnumerator<object>.hasNext
        // call: p00f5edd4.getType
        // call: p2f1d54f8.getValue
        // call: p2f1d54f8.getName
        // field: p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p5fd96ef9.f9d1675f1
        return 0;
    }

    public void WriteObject(p7356ea8d P0)
    {
        // str: ": "
        // call: List<object>.iterator
        // call: p00f5edd4.getHeaders
        // call: p00f5edd4.getType
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: p7356ea8d.generate
        // call: p5fd96ef9.newLine
        // call: p2f1d54f8.getValue
        // call: p5fd96ef9.md5e62e23
        // call: p5fd96ef9.m3bdfbd08
        // call: p5fd96ef9.write
        // call: p5fd96ef9.m8fccf6a3
        // call: p2f1d54f8.getName
        // call: List<object>.isEmpty
        // call: p00f5edd4.getContent
    }

}
