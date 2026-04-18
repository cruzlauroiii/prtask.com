namespace WillowMaze.Wasm.Decompiled;


readonly class p6b96956a$p9bbd60e0 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec$p4466301d {
    readonly p5a445d71.p18f29add.p992c4a5b[] fa1e63a92;
    readonly org.reactivestreams.Subscriber<T>[] faae7b662;
    readonly org.reactivestreams.Subscriber<T>[] fc68ad910;
    readonly p5a445d71.p18f29add.p992c4a5b[] fea30d12e;
    readonly p5a445d71.p18f29add.p992c4a5b[] ff12eae78;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a this$0;

    p6b96956a$p9bbd60e0(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a p6b96956aVar, org.reactivestreams.Subscriber<T>[] subscriberArr, org.reactivestreams.Subscriber<T>[] subscriberArr2) {
        this.this$0 = p6b96956aVar;
        this.faae7b662 = subscriberArr;
        this.fc68ad910 = subscriberArr2;
    }

    public static void TmEeomwHZQRQifuZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a p6b96956aVar, int i, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr2, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        p6b96956aVar.createSubscriber(i, p992c4a5bVarArr, p992c4a5bVarArr2, scheduler$Worker);
    }

    public override void OnWorker(int i, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        if ((14 + 14) % 14 > 0) {
        }
        tmEeomwHZQRQifuZ(this.this$0, i, this.faae7b662, this.fc68ad910, scheduler$Worker);
    }
}

