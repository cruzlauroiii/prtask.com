namespace WillowMaze.Wasm.Decompiled;

public class P27f1a790 : P71b50d8a
{
    private static void M28c7a361(p27f1a790 P0, object P1)
    {
        // str: "it"
        // call: Intrinsics.checkNotNullParameter
        // call: p27f1a790.mcbdce6f9
        // field: pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0.fb078ffd2
        // field: kotlin.Unit.INSTANCE
    }

    public static void M3e592341(p27f1a790 P0, object P1)
    {
        // call: p27f1a790.m28c7a361
    }

    private void M5a93eb90()
    {
        // str: "c7b147a4227d5ec1b0a6f9da6fe5d3a85d919e7948bd87d0f71e3830c8da123b5cfc56"
        // str: ""
        // call: CultureInfo.getDefault
        // call: p27f1a790.getDateStart
        // call: string.<init>
        // call: DecryptString.decryptString
        // call: TextInputEditText.setText
        // call: p8cf10d23.toDate
        // call: string.format
        // call: p27f1a790.getTimeStart
        // type: string
    }

    private static void M61ed57dd(DateTime P0, pb7eb73d0 P1, p27f1a790 P2, TimePicker P3, int P4, int P5)
    {
        // call: pb7eb73d0.ordinal
        // call: p27f1a790.checkDatesError
        // call: p27f1a790.setCurrentFilterDurationType
        // call: p27f1a790.setDateEnd
        // call: NoWhenBranchMatchedException.<init>
        // call: p27f1a790.m5a93eb90
        // call: p8cf10d23.<init>
        // call: DateTime.set
        // call: p27f1a790.setDateStart
        // call: p27f1a790.m9798e064
        // field: p59a14a57.pb2c97ae4.p27f1a790$p12c674ac.$EnumSwitchMapping$0
        // type: NoWhenBranchMatchedException
        // type: p8cf10d23
    }

    public static void M709fd0b5(DateTime P0, pb7eb73d0 P1, p27f1a790 P2, TimePicker P3, int P4, int P5)
    {
        // call: p27f1a790.m61ed57dd
    }

    private static void M80095a09(p27f1a790 P0, object P1)
    {
        // str: "it"
        // call: Intrinsics.checkNotNullParameter
        // call: p27f1a790.mcbdce6f9
        // field: kotlin.Unit.INSTANCE
        // field: pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pb7eb73d0.fb1a326c0
    }

    private void M9798e064()
    {
        // str: ""
        // str: "ee3147f3ea0cc29674f5aae77ded96607c662a38c51472a7314d033da9c9d0e4aacdec"
        // call: p27f1a790.getDateEnd
        // call: DecryptString.decryptString
        // call: string.format
        // call: CultureInfo.getDefault
        // call: p8cf10d23.toDate
        // call: p27f1a790.getTimeEnd
        // call: TextInputEditText.setText
        // call: string.<init>
        // type: string
    }

    public static void Ma41b9506(p27f1a790 P0, object P1)
    {
        // call: p27f1a790.m80095a09
    }

    private void Mbe128bb6()
    {
        // call: p27f1a790$pd41d8cd9$pcca4ef0e.<init>
        // call: p27f1a790.getTimeStart
        // call: p27f1a790.getTimeLayout
        // call: pf5e18aff.m2fa6d087
        // call: p27f1a790.getTimeEnd
        // call: p27f1a790$pd41d8cd9$p144e4630.<init>
        // call: LinearLayout.setVisibility
        // type: p27f1a790$pd41d8cd9$p144e4630
        // type: p27f1a790$pd41d8cd9$pcca4ef0e
    }

    private void Mc051ccff()
    {
        // call: p27f1a790.m5a93eb90
        // call: p27f1a790.m9798e064
    }

    private void Mcbdce6f9(pb7eb73d0 P0)
    {
        // call: p8cf10d23.<init>
        // call: pb7eb73d0.ordinal
        // call: p8cf10d23.toCalendar
        // call: p27f1a790.getDateStart
        // call: NoWhenBranchMatchedException.<init>
        // call: p27f1a790$pd41d8cd9$p95263d50.<init>
        // call: CultureInfo.getDefault
        // call: p27f1a790.getDateEnd
        // call: TimePickerDialog.<init>
        // call: p27f1a790.getContext
        // call: TimePickerDialog.show
        // call: DateTime.get
        // field: p59a14a57.pb2c97ae4.p27f1a790$p12c674ac.$EnumSwitchMapping$0
        // type: NoWhenBranchMatchedException
        // type: p8cf10d23
        // type: TimePickerDialog
        // type: p27f1a790$pd41d8cd9$p95263d50
    }

    private void UpdateDates()
    {
        // call: p27f1a790.mc051ccff
        // call: p71b50d8a.updateDates
    }

}
