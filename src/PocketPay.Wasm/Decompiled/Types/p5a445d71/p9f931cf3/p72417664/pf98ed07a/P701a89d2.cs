namespace WillowMaze.Wasm.Decompiled;

public class P701a89d2 : FilterOutputStream
{
    private readonly byte[] F05a2648f;
    private readonly System.Security.Cryptography.Aes F08406a6e;
    private readonly byte[] F293b6b59;
    private readonly System.Security.Cryptography.Aes F39b65473;
    private readonly System.Security.Cryptography.Aes F69b01419;
    private readonly byte[] Fd286a781;
    private readonly System.Security.Cryptography.Aes Ffbb8dc78;

    public void Close()
    {
        // str: "Error closing stream: "
        // str: "Error during cipher finalisation"
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: p5553727c.<init>
        // call: System.Security.Cryptography.Aes.doFinal
        // call: Stream.write
        // call: IOException.<init>
        // call: p701a89d2.flush
        // call: Stream.close
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2.fc68271a6
        // type: StringBuilder
        // type: p5553727c
        // type: IOException
    }

    public void Flush()
    {
        // call: Stream.flush
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2.fc68271a6
    }

    public void Write(int P0)
    {
        // call: p701a89d2.write
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2.f05a2648f
    }

    public void Write(byte[] P0, int P1, int P2)
    {
        // call: Stream.write
        // call: System.Security.Cryptography.Aes.update
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.p701a89d2.fc68271a6
    }

}
