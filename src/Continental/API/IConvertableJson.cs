﻿using System.Collections.Generic;

namespace Continental.API
{
    /// <summary>
    ///     Represents a JSON file that can be converted to another JSON file format using <see cref="IConvertableParameter"/>s.
    /// </summary>
    public interface IConvertableJson
    {
        bool Convert(IReadOnlyCollection<ConvertableParameter<>>)
    }
}