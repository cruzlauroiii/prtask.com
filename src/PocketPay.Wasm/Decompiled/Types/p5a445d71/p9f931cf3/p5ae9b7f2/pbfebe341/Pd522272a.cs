namespace WillowMaze.Wasm.Decompiled;

public class Pd522272a
{
    private static System.Numerics.BigInteger M8b71e888(System.Numerics.BigInteger P0)
    {
        // call: p08716e2c.getDigestSize
        // call: System.Numerics.BigInteger.<init>
        // call: p08716e2c.doFinal
        // call: p08716e2c.<init>
        // call: p08716e2c.update
        // call: System.Numerics.BigInteger.toByteArray
        // type: p08716e2c
        // type: System.Numerics.BigInteger
        return default!;
    }

    public static void Mfad58de7(string[] P0)
    {
        // str: "g^{q} mod p = "
        // str: "********* Initialization **********"
        // str: "KP{x3}={"
        // str: "Alice checks g^{x4}!=1: OK"
        // str: "KP{x4}={"
        // str: "},{"
        // str: "g^{x1}="
        // str: " bits): "
        // str: "p ("
        // str: "Public parameters for the cyclic group:"
        // str: "Bob sends to Alice"
        // str: "Bob checks KP{x1},: OK"
        // str: "g ("
        // str: "q ("
        // str: ""
        // str: "Bob computes key material 	 K="
        // str: "KP{x2*s}={"
        // str: "bob"
        // str: "************ Round 1 **************"
        // str: "MacTag="
        // call: StringBuilder.toString
        // call: TextWriter.println
        // call: StringBuilder.<init>
        // call: pcc112f44.getQ
        // call: System.Numerics.BigInteger.toString
        // call: p5365ed9b.getKnowledgeProofForX2s
        // call: StringBuilder.append
        // call: p5f186ad6.createRound1PayloadToSend
        // call: pbe9504a0.getKnowledgeProofForX2
        // call: p5f186ad6.createRound3PayloadToSend
        // call: pbe9504a0.getKnowledgeProofForX1
        // call: pcc112f44.getP
        // call: p5f186ad6.calculateKeyingMaterial
        // call: System.Numerics.BigInteger.bitLength
        // call: System.Security.Cryptography.RandomNumberGenerator.<init>
        // call: p5365ed9b.getA
        // call: string.toCharArray
        // call: pd522272a.m8b71e888
        // call: pbe9504a0.getGx2
        // call: System.Numerics.BigInteger.modPow
        // field: java.lang.System.out
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p3084613c.f519a950b
        // type: StringBuilder
        // type: p5f186ad6
        // type: p08716e2c
        // type: System.Security.Cryptography.RandomNumberGenerator
    }

}
