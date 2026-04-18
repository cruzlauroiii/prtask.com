namespace WillowMaze.Wasm.Decompiled;

public class Pe93197c1_pb4973f02 : Pe93197c1
{
    public void EngineLoad(Stream P0, char[] P1)
    {
        // str: "Wrong version of key store."
        // str: "KeyStore integrity check failed."
        // str: "Key store corrupted."
        // str: "OldPBEWithSHAAndTwofish-CBC"
        // str: "d82547d49f98d1837a400be29023bfefa6c5c40328b85f2b5bf6b18389a054d2a7fefa6dc24e8a7f0993d33d1156cf36a..."
        // call: pe93197c1$pb4973f02.makePBECipher
        // call: DataInputStream.readInt
        // call: pe5cfc515.getDigestSize
        // call: IOException.<init>
        // call: DecryptString.decryptString
        // call: DataInputStream.readFully
        // call: p9cd0c098.<init>
        // call: pe5cfc515.doFinal
        // call: p37a347a1.<init>
        // call: pff43b8de.m66e765de
        // call: p21b3cb64.m9b369baa
        // call: DataInputStream.<init>
        // call: Hashtable.clear
        // call: pe93197c1$pb4973f02.loadStore
        // call: pbb8d585d.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pb4973f02.faab9e1de
        // type: pbb8d585d
        // type: IOException
        // type: DataInputStream
        // type: p37a347a1
        // type: p9cd0c098
    }

    public void EngineStore(Stream P0, char[] P1)
    {
        // str: "69e4cc3ba39986e98d975b74417ae8d747febecc336e0f2c0866a990d47c6a42e42447cf6e0b17f7532d5fe701fa33003..."
        // call: pe93197c1$pb4973f02.saveStore
        // call: p701a89d2.<init>
        // call: p9cd0c098.<init>
        // call: pe93197c1$pb4973f02.makePBECipher
        // call: DataOutputStream.writeInt
        // call: DataOutputStream.<init>
        // call: pdf4cabf6.<init>
        // call: System.Security.Cryptography.RandomNumberGenerator.nextInt
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p701a89d2.close
        // call: pa05dbf55.getDigest
        // call: DecryptString.decryptString
        // call: DataOutputStream.write
        // call: p701a89d2.write
        // call: pa05dbf55.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pb4973f02.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pb4973f02.f2af72f10
        // type: pa05dbf55
        // type: p701a89d2
        // type: p9cd0c098
        // type: DataOutputStream
        // type: pdf4cabf6
    }

}
