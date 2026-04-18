Get-ChildItem "C:/Program Files/dotnet/packs/Microsoft.AspNetCore.App.Ref/10.0.4/ref/net10.0" -Filter "*Endpoint*" | Select-Object -ExpandProperty Name
