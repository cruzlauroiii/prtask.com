namespace WillowMaze.Wasm.Decompiled;

public class P6e76d416 : ViewModel
{
    private readonly pae610a30 F086654cc;
    private readonly p5f846b3c F1d209aad;
    private readonly p5f846b3c F2c75231c;
    private readonly p5f846b3c F32f8a13f;
    private readonly pfdb21b31 F37b6a15b;
    private readonly p2e423cc6 F4734ade7;
    private readonly pfdb21b31 F4ee7688c;
    private readonly p2e423cc6 F518aadae;
    private readonly pae610a30 F5a693db3;
    private readonly p5f846b3c F68c4283d;
    private readonly MutableLiveData F6ce2b2ff;
    private readonly MutableLiveData F7d48ec59;
    private readonly MutableLiveData F8a5a1dc9;
    private readonly p2e423cc6 F909ffff4;
    private readonly pae610a30 F94048320;
    private readonly pae610a30 Fbe05724a;
    private readonly pae610a30 Fc0327df4;
    private readonly MutableLiveData Fc9ae99b6;
    private readonly p2e423cc6 Fccb09fd1;
    private readonly pee785de8 Fd1d18895;
    private readonly pee785de8 Ff3395cd5;
    private readonly p2e423cc6 Ff90b9376;

    public static MutableLiveData M48a9fa36(p6e76d416 P0)
    {
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f8a5a1dc9
        return default!;
    }

    public static pae610a30 M5f112c96(p6e76d416 P0)
    {
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f086654cc
        return default!;
    }

    public string GetPaymentAddress()
    {
        // call: pfdb21b31.getPaymentAddress
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f37b6a15b
        return string.Empty;
    }

    public string GetPaymentPlace()
    {
        // call: pfdb21b31.getPaymentPlace
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f37b6a15b
        return string.Empty;
    }

    public bool GetUserLocationSetting()
    {
        // call: pfdb21b31.getUserLocationSetting
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f37b6a15b
        return false;
    }

    public bool IsAddressesMatches()
    {
        // call: pfdb21b31.isAddressesMatches
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f37b6a15b
        return false;
    }

    public LiveData ObserveAddresses()
    {
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f8a5a1dc9
        return default!;
    }

    public void OnPaymentPlaceSaved()
    {
        // call: pee785de8.getFastSellDataSavedKey
        // call: pee785de8.sendResult
        // call: p6e76d416.openPreviousScreen
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.ff3395cd5
        // field: kotlin.Unit.INSTANCE
    }

    public void OpenPreviousScreen()
    {
        // call: pee785de8.back
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.ff3395cd5
    }

    public void SetAddressesMatches(bool P0)
    {
        // call: p5f846b3c.reportPlaceAndAddressSameEvent
        // call: pfdb21b31.setAddressesMatches
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f37b6a15b
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f68c4283d
    }

    public void SetPaymentPlaceAndAddress(string P0, string P1, bool P2, bool P3)
    {
        // str: "paymentPlace"
        // str: "paymentAddress"
        // str: "347cfcab1c33421aa723d94bbd54e81d3570af5a7fb88ca9ccd4150ad1ec70b8f01465533b2e9fbcf2625e034e"
        // call: p325296ab.<init>
        // call: DecryptString.decryptString
        // call: pad7a6ae3.m1c1e012b
        // call: pfdb21b31.updateLocationSettings
        // call: p2e423cc6.getString
        // call: Intrinsics.checkNotNullParameter
        // call: pfdb21b31.getUserLocationInfo
        // call: pee785de8.sendResult
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.ff3395cd5
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f4734ade7
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f37b6a15b
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.saving_payment_place_success
        // type: p325296ab
    }

    public void UpdateUserLocation()
    {
        // call: p6e76d416$p90fed63e$1.<init>
        // call: ViewModelKt.getViewModelScope
        // call: BuildersKt.launch$default
        // type: p6e76d416$p90fed63e$1
    }

    public void UserLocationOff()
    {
        // call: p5f846b3c.reportUserLocationOffEvent
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f68c4283d
    }

    public void UserLocationOn()
    {
        // call: p5f846b3c.reportUserLocationOnEvent
        // field: p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.p6e76d416.f68c4283d
    }

}
