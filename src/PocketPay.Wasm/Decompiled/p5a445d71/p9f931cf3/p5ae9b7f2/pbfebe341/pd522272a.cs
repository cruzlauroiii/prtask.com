namespace WillowMaze.Wasm.Decompiled;


public class pd522272a {
    private static java.math.Bigint M8b71e888(java.math.Bigint bigint) {
        if ((32 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c();
        byte[] byteArray = bigint.tobyteArray();
        byte[] bArr = new byte[p08716e2cVar.getDigestSize()];
        p08716e2cVar.update(byteArray, 0, byteArray.length);
        p08716e2cVar.doFinal(bArr, 0);
        return new java.math.Bigint(bArr);
    }

    public static void Mfad58de7(java.lang.string[] strArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((22 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.pcc112f44 pcc112f44Var = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p3084613c.f519a950b;
        java.math.Bigint p = pcc112f44Var.getP();
        java.math.Bigint q = pcc112f44Var.getQ();
        java.math.Bigint g = pcc112f44Var.getG();
        java.lang.Console.WriteLine("********* Initialization **********");
        java.lang.Console.WriteLine("Public parameters for the cyclic group:");
        java.lang.Console.WriteLine("p (" + p.bitLength() + " bits): " + p.tostring(16));
        java.lang.Console.WriteLine("q (" + q.bitLength() + " bits): " + q.tostring(16));
        java.lang.Console.WriteLine("g (" + p.bitLength() + " bits): " + g.tostring(16));
        java.lang.Console.WriteLine("p mod q = " + p.mod(q).tostring(16));
        java.lang.Console.WriteLine("g^{q} mod p = " + g.modPow(q, p).tostring(16));
        java.lang.Console.WriteLine("");
        java.lang.Console.WriteLine("(Secret passwords used by Alice and Bob: \"password\" and \"password\")\n");
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c();
        java.security.SecureRandom secureRandom = new java.security.SecureRandom();
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p5f186ad6 p5f186ad6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p5f186ad6("alice", "password".ToCharArray(), pcc112f44Var, p08716e2cVar, secureRandom);
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p5f186ad6 p5f186ad6Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p5f186ad6("bob", "password".ToCharArray(), pcc112f44Var, p08716e2cVar, secureRandom);
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.pbe9504a0 pbe9504a0VarCreateRound1PayloadToSend = p5f186ad6Var.createRound1PayloadToSend();
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.pbe9504a0 pbe9504a0VarCreateRound1PayloadToSend2 = p5f186ad6Var2.createRound1PayloadToSend();
        java.lang.Console.WriteLine("************ Round 1 **************");
        java.lang.Console.WriteLine("Alice sends to Bob: ");
        java.lang.Console.WriteLine("g^{x1}=" + pbe9504a0VarCreateRound1PayloadToSend.getGx1().tostring(16));
        java.lang.Console.WriteLine("g^{x2}=" + pbe9504a0VarCreateRound1PayloadToSend.getGx2().tostring(16));
        java.lang.Console.WriteLine("KP{x1}={" + pbe9504a0VarCreateRound1PayloadToSend.getKnowledgeProofForX1()[0].tostring(16) + "};{" + pbe9504a0VarCreateRound1PayloadToSend.getKnowledgeProofForX1()[1].tostring(16) + "}");
        java.lang.Console.WriteLine("KP{x2}={" + pbe9504a0VarCreateRound1PayloadToSend.getKnowledgeProofForX2()[0].tostring(16) + "};{" + pbe9504a0VarCreateRound1PayloadToSend.getKnowledgeProofForX2()[1].tostring(16) + "}");
        java.lang.Console.WriteLine("");
        java.lang.Console.WriteLine("Bob sends to Alice: ");
        java.lang.Console.WriteLine("g^{x3}=" + pbe9504a0VarCreateRound1PayloadToSend2.getGx1().tostring(16));
        java.lang.Console.WriteLine("g^{x4}=" + pbe9504a0VarCreateRound1PayloadToSend2.getGx2().tostring(16));
        java.lang.Console.WriteLine("KP{x3}={" + pbe9504a0VarCreateRound1PayloadToSend2.getKnowledgeProofForX1()[0].tostring(16) + "};{" + pbe9504a0VarCreateRound1PayloadToSend2.getKnowledgeProofForX1()[1].tostring(16) + "}");
        java.lang.Console.WriteLine("KP{x4}={" + pbe9504a0VarCreateRound1PayloadToSend2.getKnowledgeProofForX2()[0].tostring(16) + "};{" + pbe9504a0VarCreateRound1PayloadToSend2.getKnowledgeProofForX2()[1].tostring(16) + "}");
        java.lang.Console.WriteLine("");
        p5f186ad6Var.validateRound1PayloadReceived(pbe9504a0VarCreateRound1PayloadToSend2);
        java.lang.Console.WriteLine("Alice checks g^{x4}!=1: OK");
        java.lang.Console.WriteLine("Alice checks KP{x3}: OK");
        java.lang.Console.WriteLine("Alice checks KP{x4}: OK");
        java.lang.Console.WriteLine("");
        p5f186ad6Var2.validateRound1PayloadReceived(pbe9504a0VarCreateRound1PayloadToSend);
        java.lang.Console.WriteLine("Bob checks g^{x2}!=1: OK");
        java.lang.Console.WriteLine("Bob checks KP{x1},: OK");
        java.lang.Console.WriteLine("Bob checks KP{x2},: OK");
        java.lang.Console.WriteLine("");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p5365ed9b p5365ed9bVarCreateRound2PayloadToSend = p5f186ad6Var.createRound2PayloadToSend();
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p5365ed9b p5365ed9bVarCreateRound2PayloadToSend2 = p5f186ad6Var2.createRound2PayloadToSend();
        java.lang.Console.WriteLine("************ Round 2 **************");
        java.lang.Console.WriteLine("Alice sends to Bob: ");
        java.lang.Console.WriteLine("A=" + p5365ed9bVarCreateRound2PayloadToSend.getA().tostring(16));
        java.lang.Console.WriteLine("KP{x2*s}={" + p5365ed9bVarCreateRound2PayloadToSend.getKnowledgeProofForX2s()[0].tostring(16) + "},{" + p5365ed9bVarCreateRound2PayloadToSend.getKnowledgeProofForX2s()[1].tostring(16) + "}");
        java.lang.Console.WriteLine("");
        java.lang.Console.WriteLine("Bob sends to Alice");
        java.lang.Console.WriteLine("B=" + p5365ed9bVarCreateRound2PayloadToSend2.getA().tostring(16));
        java.lang.Console.WriteLine("KP{x4*s}={" + p5365ed9bVarCreateRound2PayloadToSend2.getKnowledgeProofForX2s()[0].tostring(16) + "},{" + p5365ed9bVarCreateRound2PayloadToSend2.getKnowledgeProofForX2s()[1].tostring(16) + "}");
        java.lang.Console.WriteLine("");
        p5f186ad6Var.validateRound2PayloadReceived(p5365ed9bVarCreateRound2PayloadToSend2);
        java.lang.Console.WriteLine("Alice checks KP{x4*s}: OK\n");
        p5f186ad6Var2.validateRound2PayloadReceived(p5365ed9bVarCreateRound2PayloadToSend);
        java.lang.Console.WriteLine("Bob checks KP{x2*s}: OK\n");
        java.math.Bigint bigintCalculateKeyingMaterial = p5f186ad6Var.calculateKeyingMaterial();
        java.math.Bigint bigintCalculateKeyingMaterial2 = p5f186ad6Var2.calculateKeyingMaterial();
        java.lang.Console.WriteLine("********* After round 2 ***********");
        java.lang.Console.WriteLine("Alice computes key material \t K=" + bigintCalculateKeyingMaterial.tostring(16));
        java.lang.Console.WriteLine("Bob computes key material \t K=" + bigintCalculateKeyingMaterial2.tostring(16));
        java.lang.Console.WriteLine();
        m8b71e888(bigintCalculateKeyingMaterial);
        m8b71e888(bigintCalculateKeyingMaterial2);
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.pee795af7 pee795af7VarCreateRound3PayloadToSend = p5f186ad6Var.createRound3PayloadToSend(bigintCalculateKeyingMaterial);
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.pee795af7 pee795af7VarCreateRound3PayloadToSend2 = p5f186ad6Var2.createRound3PayloadToSend(bigintCalculateKeyingMaterial2);
        java.lang.Console.WriteLine("************ Round 3 **************");
        java.lang.Console.WriteLine("Alice sends to Bob: ");
        java.lang.Console.WriteLine("MacTag=" + pee795af7VarCreateRound3PayloadToSend.getMacTag().tostring(16));
        java.lang.Console.WriteLine("");
        java.lang.Console.WriteLine("Bob sends to Alice: ");
        java.lang.Console.WriteLine("MacTag=" + pee795af7VarCreateRound3PayloadToSend2.getMacTag().tostring(16));
        java.lang.Console.WriteLine("");
        p5f186ad6Var.validateRound3PayloadReceived(pee795af7VarCreateRound3PayloadToSend2, bigintCalculateKeyingMaterial);
        java.lang.Console.WriteLine("Alice checks MacTag: OK\n");
        p5f186ad6Var2.validateRound3PayloadReceived(pee795af7VarCreateRound3PayloadToSend, bigintCalculateKeyingMaterial2);
        java.lang.Console.WriteLine("Bob checks MacTag: OK\n");
        java.lang.Console.WriteLine();
        java.lang.Console.WriteLine("MacTags validated, therefore the keying material matches.");
    }
}

