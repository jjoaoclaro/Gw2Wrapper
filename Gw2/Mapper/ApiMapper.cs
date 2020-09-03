using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Gw2.Mapper
{
    /// <summary>
    /// Mapper for Guild Wars 2 Api
    /// </summary>
    public class ApiMapper : IApiMapper
    {
        /// <summary>
        /// Maps a string to a certain Object type
        /// </summary>
        /// <param name="objectToMap"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public T MapTo<T>(string objectToMap)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    AllowTrailingCommas = true,
                    PropertyNameCaseInsensitive = true,
                };
                T result = JsonSerializer.Deserialize<T>(objectToMap, options);
                return result;
            }
            catch (Exception e)
            {
                return default(T);
            }
        }
    }
}
