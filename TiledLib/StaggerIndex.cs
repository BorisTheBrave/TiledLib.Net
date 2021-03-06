﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TiledLib
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StaggerIndex : byte
    {
        None = 0,
        [EnumMember(Value = "odd")]
        odd,
        [EnumMember(Value = "even")]
        even,
    }
}