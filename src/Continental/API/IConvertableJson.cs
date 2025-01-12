﻿using System;
using System.Collections.Generic;

namespace Continental.API
{
    /// <summary>
    ///     Represents a JSON file that can be converted to another JSON file format using <see cref="IConvertableParameter"/>s.
    /// </summary>
    public interface IConvertableJson
    {
        /// <summary>
        ///     Retrieves the exposed parameters of this JSON.
        /// </summary>
        /// <returns>A collection of parameters for processing.</returns>
        List<IConvertableParameter> GetParameters();
        
        /// <summary>
        ///     Handles converting a collection of <see cref="IConvertableParameter"/>s. <see cref="IConversionHandler"/>s deal with transferring data to these parameters. 
        /// </summary>
        /// <param name="parameters">The parameters to use.</param>
        void Convert(IReadOnlyCollection<IConvertableParameter> parameters);

        /// <summary>
        ///     Grabs the parameter of a certain name, expecting to follow the given type.
        /// </summary>
        /// <param name="parameters">The parameters to search.</param>
        /// <param name="name">The name of the parameter we want.</param>
        /// <typeparam name="T">The parameter's type.</typeparam>
        /// <returns>The parameter, if found.</returns>
        T GetParameter<T>(IReadOnlyCollection<IConvertableParameter> parameters, string name);
    }
}