namespace WillowMaze.Wasm.Decompiled;

public class P9f6c0a62 : Pec546d1c, Object
{
    private pec1219c5 F19b13258;
    private p234a7530 F224efbe7;
    private p234a7530 Fb6fe3164;
    private pec1219c5 Feb708742;

    public static p9f6c0a62 M2129e874(string P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "File for loading is null in JournaledAlgorithm"
        // call: BufferedInputStream.<init>
        // call: p21b3cb64.m257a59b8
        // call: p9f6c0a62.<init>
        // call: Stream.close
        // call: FileInputStream.<init>
        // call: NullPointerException.<init>
        // type: p9f6c0a62
        // type: FileInputStream
        // type: NullPointerException
        // type: BufferedInputStream
        return default!;
    }

    public static p9f6c0a62 M2129e874(Stream P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "stream for loading is null in JournaledAlgorithm"
        // call: Stream.close
        // call: BufferedInputStream.<init>
        // call: p21b3cb64.m257a59b8
        // call: p9f6c0a62.<init>
        // call: NullPointerException.<init>
        // type: p9f6c0a62
        // type: BufferedInputStream
        // type: NullPointerException
        return default!;
    }

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: p9f6c0a62.getEncoded
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.defaultWriteObject
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.readObject
        // call: pa9682fb5.m07091bf1
        // call: p9f6c0a62.me2ad35b5
        // call: ObjectInputStream.defaultReadObject
    }

    private void Me2ad35b5(byte[] P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: pec1219c5.<init>
        // call: p11b04310.getOctets
        // call: p11b04310.m8bab0102
        // call: p80f8c729.getObjectAt
        // call: p234a7530.m8bab0102
        // call: p80f8c729.m8bab0102
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62.feb708742
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62.fb6fe3164
        // type: pec1219c5
    }

    public p234a7530 GetAlgorithmIdentifier()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62.fb6fe3164
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: pec1219c5.getFullTranscript
        // call: pd6ccb7fc.<init>
        // call: p6f0e511c.<init>
        // call: pd6ccb7fc.add
        // call: pb840b7ef.<init>
        // call: pb840b7ef.getEncoded
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62.feb708742
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62.fb6fe3164
        // type: pd6ccb7fc
        // type: p6f0e511c
        // type: pb840b7ef
        return default!;
    }

    public pec1219c5 GetJournalingSecureRandom()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62.feb708742
        return default!;
    }

    public void StoreState(string P0)
    {
        // str: "file for storage is null in JournaledAlgorithm"
        // call: FileOutputStream.close
        // call: FileOutputStream.<init>
        // call: p9f6c0a62.storeState
        // call: NullPointerException.<init>
        // type: FileOutputStream
        // type: NullPointerException
    }

    public void StoreState(Stream P0)
    {
        // str: "output stream for storage is null in JournaledAlgorithm"
        // call: NullPointerException.<init>
        // call: Stream.write
        // call: p9f6c0a62.getEncoded
        // type: NullPointerException
    }

}
