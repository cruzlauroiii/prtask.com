namespace WillowMaze.Wasm.Decompiled;


class p51c74e65$pe84b598c : p5a445d71.p228c1b3d.p07cc694b.p51c74e65 {
    private static readonly long f69b8ed48 = -9937958251642L;
    private static readonly long fc6e1e520 = -9937958251642L;
    private static readonly long ff59b9147 = -9937958251642L;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 f2a09ced5;
    private readonly byte f5142d24e;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 f6425c8ed;
    private readonly byte f693303ae;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 f6f66371c;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 f9424ab9e;
    private readonly byte fafba7380;
    private readonly p5a445d71.p228c1b3d.p07cc694b.pd5950989 fc122c631;

    p51c74e65$pe84b598c(java.lang.string str, byte b, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var, p5a445d71.p228c1b3d.p07cc694b.pd5950989 pd5950989Var2) {
        super(str);
        this.fafba7380 = b;
        this.f9424ab9e = pd5950989Var;
        this.f6425c8ed = pd5950989Var2;
    }

    private java.lang.object M73fa47c3() {
        switch (this.fafba7380) {
            case 1:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mf23e8626();
            case 2:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mf8f67da7();
            case 3:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m337ceba5();
            case 4:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m5ec06fdf();
            case 5:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mbbeb9b46();
            case 6:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m89082e03();
            case 7:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m429f062d();
            case 8:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m13fe7af4();
            case 9:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m0dc0a6ea();
            case 10:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m74674bbd();
            case 11:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mebdbf394();
            case 12:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m2a096755();
            case 13:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m83fd488e();
            case 14:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m5e49d338();
            case 15:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcdc7972c();
            case 16:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mc7321d99();
            case 17:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.ma5940f5e();
            case 18:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m1740fbc7();
            case 19:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m649493cb();
            case 20:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m59c413ba();
            case 21:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m74faefcd();
            case 22:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m53786ceb();
            case 23:
                return p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m406f4166();
            default:
                return this;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 18) % 18 > 0) {
        }
        if (this != obj) {
            return (obj is p5a445d71.p228c1b3d.p07cc694b.p51c74e65$pe84b598c) && this.fafba7380 == ((p5a445d71.p228c1b3d.p07cc694b.p51c74e65$pe84b598c) obj).fafba7380;
        }
        return true;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetDurationType() {
        return this.f9424ab9e;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 GetField(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVarM5911c428 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m5911c428(p7bf898deVar);
        switch (this.fafba7380) {
            case 1:
                return p7bf898deVarM5911c428.era();
            case 2:
                return p7bf898deVarM5911c428.yearOfEra();
            case 3:
                return p7bf898deVarM5911c428.centuryOfEra();
            case 4:
                return p7bf898deVarM5911c428.yearOfCentury();
            case 5:
                return p7bf898deVarM5911c428.year();
            case 6:
                return p7bf898deVarM5911c428.dayOfYear();
            case 7:
                return p7bf898deVarM5911c428.monthOfYear();
            case 8:
                return p7bf898deVarM5911c428.dayOfMonth();
            case 9:
                return p7bf898deVarM5911c428.weekyearOfCentury();
            case 10:
                return p7bf898deVarM5911c428.weekyear();
            case 11:
                return p7bf898deVarM5911c428.weekOfWeekyear();
            case 12:
                return p7bf898deVarM5911c428.dayOfWeek();
            case 13:
                return p7bf898deVarM5911c428.halfdayOfDay();
            case 14:
                return p7bf898deVarM5911c428.hourOfHalfday();
            case 15:
                return p7bf898deVarM5911c428.clockhourOfHalfday();
            case 16:
                return p7bf898deVarM5911c428.clockhourOfDay();
            case 17:
                return p7bf898deVarM5911c428.hourOfDay();
            case 18:
                return p7bf898deVarM5911c428.minuteOfDay();
            case 19:
                return p7bf898deVarM5911c428.minuteOfHour();
            case 20:
                return p7bf898deVarM5911c428.secondOfDay();
            case 21:
                return p7bf898deVarM5911c428.secondOfMinute();
            case 22:
                return p7bf898deVarM5911c428.millisOfDay();
            case 23:
                return p7bf898deVarM5911c428.millisOfSecond();
            default:
                throw new java.lang.InternalError();
        }
    }

    public override p5a445d71.p228c1b3d.p07cc694b.pd5950989 GetRangeDurationType() {
        return this.f6425c8ed;
    }

    public int HashCode() {
        return 1 << this.fafba7380;
    }
}

