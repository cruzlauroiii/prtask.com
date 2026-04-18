namespace WillowMaze.Wasm.Decompiled;


public class LocationHashSettingsResponse : com.google.android.gms.common.api.Response<com.google.android.gms.location.LocationHashSettingsResult> {
    public LocationHashSettingsResponse(com.google.android.gms.location.LocationHashSettingsResult locationHashSettingsResult) {
        super(locationHashSettingsResult);
    }

    public static com.google.android.gms.common.api.Result JMAOyMYcleeButon(com.google.android.gms.location.LocationHashSettingsResponse locationHashSettingsResponse) {
        return locationHashSettingsResponse.getResult();
    }

    public static com.google.android.gms.location.LocationHashSettingsStates RiXQYMkxqlMQlrgj(com.google.android.gms.location.LocationHashSettingsResult locationHashSettingsResult) {
        return locationHashSettingsResult.getLocationHashSettingsStates();
    }

    public com.google.android.gms.location.LocationHashSettingsStates GetLocationHashSettingsStates() {
        return riXQYMkxqlMQlrgj((com.google.android.gms.location.LocationHashSettingsResult) JMAOyMYcleeButon(this));
    }
}

