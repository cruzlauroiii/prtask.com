Get-ChildItem "C:\Program Files\dotnet\packs\" -Directory |
    Where-Object { $_.Name -match "AspNetCore" } |
    ForEach-Object { $_.Name }
