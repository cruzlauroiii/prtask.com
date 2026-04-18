namespace WillowMaze.Wasm.Decompiled;

public class P0dff68fb
{
    private p32551d15 F08406a6e;
    private BufferedInputStream F13b5bfe9;
    private BufferedOutputStream F17d6c156;
    private byte[] F3802dc3b;
    private p32551d15 F389625c5;
    private byte[] F3c6e0b8a;
    private byte[] F4205d33b;
    private p32551d15 F4cd0dea9;
    private bool F53c82eba;
    private BufferedOutputStream F586e7ffa;
    private byte[] F6fb7fab2;
    private p32551d15 F6fdbb16f;
    private BufferedInputStream F70eddaab;
    private BufferedOutputStream F7f5dccbe;
    private BufferedOutputStream Fbac4ffd5;
    private BufferedInputStream Fbaf7a969;
    private BufferedOutputStream Fc68271a6;
    private bool Fcd34059a;
    private p32551d15 Fce1aabb1;
    private BufferedInputStream Fd2dd1df8;

    private void M0164cace(byte[] P0)
    {
        // call: p32551d15.getOutputSize
        // call: BufferedInputStream.read
        // call: p32551d15.processBytes
        // call: p92640bd7.m97a57645
        // call: BufferedOutputStream.write
        // call: p32551d15.init
        // call: p94919be6.<init>
        // call: IOException.printStackTrace
        // call: p32551d15.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.f13b5bfe9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.fc68271a6
        // type: p94919be6
    }

    private void M114a66f4(byte[] P0)
    {
        // call: p32551d15.doFinal
        // call: BufferedOutputStream.write
        // call: StreamReader.<init>
        // call: p32551d15.init
        // call: IOException.printStackTrace
        // call: p94919be6.<init>
        // call: StreamReader.readLine
        // call: p92640bd7.m5b936250
        // call: p32551d15.getOutputSize
        // call: p32551d15.processBytes
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.fc68271a6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.f13b5bfe9
        // type: StreamReader
        // type: p94919be6
        // type: StreamReader
    }

    private void M50751408()
    {
        // str: "exception closing resources: "
        // call: p32551d15.<init>
        // call: StringBuilder.append
        // call: TextWriter.println
        // call: p0dff68fb.m114a66f4
        // call: BufferedInputStream.close
        // call: BufferedOutputStream.flush
        // call: BufferedOutputStream.close
        // call: StringBuilder.<init>
        // call: IOException.getMessage
        // call: p0dff68fb.m0164cace
        // call: pc346e9ef.<init>
        // call: StringBuilder.toString
        // call: pc5fbce64.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.f53c82eba
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.f3c6e0b8a
        // field: java.lang.System.err
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.f13b5bfe9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.fc68271a6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb.f08406a6e
        // type: pc5fbce64
        // type: pc346e9ef
        // type: StringBuilder
        // type: p32551d15
    }

    public static void Mfad58de7(string[] P0)
    {
        // str: "deskey.dat"
        // str: "Usage: java "
        // str: " infile outfile [keyfile]"
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p0dff68fb.<init>
        // call: System.exit
        // call: TextWriter.println
        // call: p0dff68fb.m50751408
        // call: StringBuilder.<init>
        // call: object.getClass
        // call: Type.getName
        // field: java.lang.System.err
        // type: StringBuilder
        // type: p0dff68fb
    }

}
