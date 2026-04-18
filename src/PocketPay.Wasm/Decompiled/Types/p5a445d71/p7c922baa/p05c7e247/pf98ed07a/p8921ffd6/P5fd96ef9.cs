namespace WillowMaze.Wasm.Decompiled;

public class P5fd96ef9 : StreamWriter
{
    private static int F4423bb2b;
    private static int F550884c1;
    private static int F6f52c2c4;
    private static int Fda783878;
    private static int Fdbc32b77;
    private readonly int F4c13186e;
    private readonly int F9cac700f;
    private char[] F9cf15196;
    private readonly int F9d1675f1;
    private char[] Fb1c484bf;
    private char[] Fc1fbd821;
    private char[] Fcb7e52b2;
    private readonly int Fcdc81809;
    private char[] Fe4acc1b5;
    private readonly int Ff01c4723;

    private void M3bdfbd08(string P0)
    {
        // str: "f85fbf7502063d210a4e95718fe5835f1898bc3a39118990844f26a8401e9884fd62708ae72488"
        // str: "-----"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p5fd96ef9.newLine
        // call: DecryptString.decryptString
        // call: p5fd96ef9.write
        // type: StringBuilder
    }

    private void M8fccf6a3(string P0)
    {
        // str: "-----"
        // str: "38b8c19f2f7c63f519db359d4ff10fe7d8f56c70cb9356f31128a2846bd5bfd0db61b67fe5"
        // call: StringBuilder.append
        // call: p5fd96ef9.write
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // call: p5fd96ef9.newLine
        // call: StringBuilder.toString
        // type: StringBuilder
    }

    private void Md5e62e23(byte[] P0)
    {
        // call: p1eb445fa.m97a57645
        // call: p5fd96ef9.write
        // call: p5fd96ef9.newLine
        // field: p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p5fd96ef9.fcb7e52b2
    }

    public int GetOutputSize(p00f5edd4 P0)
    {
        // str: ": "
        // call: string.length
        // call: p2f1d54f8.getValue
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: p00f5edd4.getHeaders
        // call: p00f5edd4.getContent
        // call: p2f1d54f8.getName
        // call: IEnumerator<object>.next
        // call: p00f5edd4.getType
        // call: List<object>.isEmpty
        // field: p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p5fd96ef9.f9d1675f1
        return 0;
    }

    public void WriteObject(p7356ea8d P0)
    {
        // str: ": "
        // call: p5fd96ef9.m8fccf6a3
        // call: p00f5edd4.getContent
        // call: List<object>.isEmpty
        // call: p00f5edd4.getHeaders
        // call: p5fd96ef9.write
        // call: p2f1d54f8.getValue
        // call: p2f1d54f8.getName
        // call: p5fd96ef9.newLine
        // call: p00f5edd4.getType
        // call: IEnumerator<object>.hasNext
        // call: List<object>.iterator
        // call: p5fd96ef9.m3bdfbd08
        // call: p7356ea8d.generate
        // call: p5fd96ef9.md5e62e23
        // call: IEnumerator<object>.next
    }

}
