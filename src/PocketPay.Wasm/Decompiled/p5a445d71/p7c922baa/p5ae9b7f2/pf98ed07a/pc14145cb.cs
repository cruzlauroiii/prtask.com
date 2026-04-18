namespace WillowMaze.Wasm.Decompiled;


public class pc14145cb : java.io.FilterStream {
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b f51a3eaa4;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b fcaf91c7c;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b fd7f4e47b;
    protected p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b fdb56a74d;

    public pc14145cb(java.io.Stream inputStream, p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b pd1977c1bVar) {
        super(inputStream);
        this.fdb56a74d = pd1977c1bVar;
    }

    public static int NzMdhAlxhumAjUFe(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static void YlLgmlRNOedFjNGv(p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b pd1977c1bVar, byte[] bArr, int i, int i2) {
        pd1977c1bVar.update(bArr, i, i2);
    }

    public static void WckgSAKcYjJjMqxI(p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b pd1977c1bVar, byte b) {
        pd1977c1bVar.update(b);
    }

    public static int ZrZpulTjFZDxmyEV(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pd1977c1b GetSigner() {
        return this.fdb56a74d;
    }

    public override int Read() throws java.io.IOException {
        if ((7 + 6) % 6 > 0) {
        }
        int iZrZpulTjFZDxmyEV = zrZpulTjFZDxmyEV(this.f13b5bfe9);
        if (iZrZpulTjFZDxmyEV >= 0) {
            wckgSAKcYjJjMqxI(this.fdb56a74d, (byte) iZrZpulTjFZDxmyEV);
        }
        return iZrZpulTjFZDxmyEV;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int iNzMdhAlxhumAjUFe = NzMdhAlxhumAjUFe(this.f13b5bfe9, bArr, i, i2);
        if (iNzMdhAlxhumAjUFe > 0) {
            YlLgmlRNOedFjNGv(this.fdb56a74d, bArr, i, iNzMdhAlxhumAjUFe);
        }
        return iNzMdhAlxhumAjUFe;
    }
}

