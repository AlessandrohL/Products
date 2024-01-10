﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Products.Domain.Errors
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ErrorType
    {
        NotFound,
        Validation,
        Conflict,
        Failure
    }
}
