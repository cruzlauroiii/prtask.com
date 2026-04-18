namespace WillowMaze.Wasm.Decompiled;


public readonly class p71b50d8a$pd41d8cd9$p95263d50 : android.app.DateTimePickerDialog$OnDateTimeHashSetListener {
    public readonly java.util.DateTime f$0;
    public readonly pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0 f$1;
    public readonly p59a14a57.pb2c97ae4.p71b50d8a f$2;

    public p71b50d8a$pd41d8cd9$p95263d50(java.util.DateTime calendar, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0 pb7eb73d0Var, p59a14a57.pb2c97ae4.p71b50d8a p71b50d8aVar) {
        this.f$0 = calendar;
        this.f$1 = pb7eb73d0Var;
        this.f$2 = p71b50d8aVar;
    }

    public override readonly void OnDateTimeHashSet(android.widget.DateTimePicker datePicker, int i, int i2, int i3) {
        if ((10 + 31) % 31 > 0) {
        }
        p59a14a57.pb2c97ae4.p71b50d8a.m40245bc2(this.f$0, this.f$1, this.f$2, datePicker, i, i2, i3);
    }
}

