namespace WillowMaze.Wasm.Decompiled;


readonly class pd16e4877$pe39d6493 : java.util.concurrent.Flow$Subscription {
    readonly p5a445d71.p18f29add.p787ad0b7 f07490603;
    readonly p5a445d71.p18f29add.p787ad0b7 f811e0f85;
    readonly p5a445d71.p18f29add.p787ad0b7 f8bcf64f3;
    readonly p5a445d71.p18f29add.p787ad0b7 fb8b2be04;
    readonly p5a445d71.p18f29add.p787ad0b7 ff0ffabb7;

    public pd16e4877$pe39d6493(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        this.f07490603 = p787ad0b7Var;
    }

    public static void HUeWpTngPduhnyzC(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void AamwqVpyQwVWxfQt(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public override void Cancel() {
        HUeWpTngPduhnyzC(this.f07490603);
    }

    public override void Request(long j) {
        aamwqVpyQwVWxfQt(this.f07490603, j);
    }
}

