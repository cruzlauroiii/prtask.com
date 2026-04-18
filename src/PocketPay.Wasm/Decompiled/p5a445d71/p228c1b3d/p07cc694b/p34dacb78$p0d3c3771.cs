namespace WillowMaze.Wasm.Decompiled;


readonly class p34dacb78$p0d3c3771 : java.io.object {
    private static readonly long f93c759c5 = -6471952376487863581L;
    private static readonly long fc31cd6dd = -6471952376487863581L;
    private static readonly long fc3c03d4e = -6471952376487863581L;
    private static readonly long fc6e1e520 = -6471952376487863581L;
    private static readonly long fd5c7dac2 = -6471952376487863581L;
    private java.lang.string f04ccd5f5;
    private java.lang.string f41b5ebf9;

    p34dacb78$p0d3c3771(java.lang.string str) {
        this.f41b5ebf9 = str;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeUTF(this.f41b5ebf9);
    }

    private java.lang.object M73fa47c3() throws java.io.objectStreamException {
        return p5a445d71.p228c1b3d.p07cc694b.p34dacb78.m1ff20793(this.f41b5ebf9);
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException {
        this.f41b5ebf9 = objectStream.readUTF();
    }
}

