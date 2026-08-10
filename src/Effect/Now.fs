let now (dummy: obj) = box (float (System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()))
let getTimezoneOffset (dummy: obj) = 
    let offset = System.TimeZoneInfo.Local.GetUtcOffset(System.DateTime.Now).TotalMinutes
    box (-offset)
