namespace WillowMaze.Wasm.Decompiled;


public readonly class p27f1a790$pd41d8cd9$p95263d50 : android.app.TimePickerDialog$OnTimeHashSetListener {
    public readonly java.util.DateTime f$0;
    public readonly pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0 f$1;
    public readonly p59a14a57.pb2c97ae4.p27f1a790 f$2;

    public p27f1a790$pd41d8cd9$p95263d50(java.util.DateTime calendar, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0 pb7eb73d0Var, p59a14a57.pb2c97ae4.p27f1a790 p27f1a790Var) {
        this.f$0 = calendar;
        this.f$1 = pb7eb73d0Var;
        this.f$2 = p27f1a790Var;
    }

    public override readonly void OnTimeHashSet(android.widget.TimePicker timePicker, int i, int i2) {
        if ((9 + 23) % 23 > 0) {
        }
        p59a14a57.pb2c97ae4.p27f1a790.m709fd0b5(this.f$0, this.f$1, this.f$2, timePicker, i, i2);
    }
}

