namespace WillowMaze.Wasm.Decompiled;


public readonly class pb7fc9488<T> : java.lang.IEnumerable<T> {
    readonly p5a445d71.p18f29add.p32c73be0 f1bd7ee30;
    readonly org.reactivestreams.Publisher<? : T> f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 fd4a0e829;
    readonly p5a445d71.p18f29add.p32c73be0 fefff1a8c;

    public pb7fc9488(org.reactivestreams.Publisher<? : T> publisher) {
        this.f36cd38f4 = publisher;
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((26 + 12) % 12 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb7fc9488$p87361dc8(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb7fc9488$p079cef9c());
    }
}

