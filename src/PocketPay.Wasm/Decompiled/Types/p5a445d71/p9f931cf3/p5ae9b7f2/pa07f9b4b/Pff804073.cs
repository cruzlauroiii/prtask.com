namespace WillowMaze.Wasm.Decompiled;

public class Pff804073 : P35da9a23
{
    private void AdvanceCounter()
    {
        // str: "attempt to increase counter past 2^32."
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9457b3e2
        // type: IllegalStateException
    }

    private void AdvanceCounter(long P0)
    {
        // str: "attempt to increase counter past 2^32."
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9457b3e2
        // type: IllegalStateException
    }

    private void GenerateKeyStream(byte[] P0)
    {
        // call: p96f3a7dc.mfbd10f33
        // call: p4492081c.m45d2d6ef
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9457b3e2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9dd4e461
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f8d7e7aa4
    }

    public string GetAlgorithmName()
    {
        // str: "ChaCha7539"
        return string.Empty;
    }

    private long GetCounter()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9457b3e2
        return 0;
    }

    private int GetNonceSize()
    {
        return 0;
    }

    private void ResetCounter()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9457b3e2
    }

    private void RetreatCounter()
    {
        // str: "attempt to reduce counter past zero."
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9457b3e2
        // type: IllegalStateException
    }

    private void RetreatCounter(long P0)
    {
        // str: "attempt to reduce counter past zero."
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9457b3e2
        // type: IllegalStateException
    }

    private void SetKey(byte[] P0, byte[] P1)
    {
        // str: " requires 256 bit key"
        // call: p4492081c.m0eef4fb6
        // call: pff804073.packTauOrSigma
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: pff804073.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pff804073.f9457b3e2
        // type: IllegalArgumentException
        // type: StringBuilder
    }

}
