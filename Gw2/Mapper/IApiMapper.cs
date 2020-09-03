using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Mapper
{
    /// <summary>
    /// Interface for mappers for Guild Wars 2 Api
    /// </summary>
    public interface IApiMapper
    {
        /// <summary>
        /// Maps a string to a certain Object type
        /// </summary>
        /// <param name="objectToMap"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        T MapTo<T>(string objectToMap);
    }
}
