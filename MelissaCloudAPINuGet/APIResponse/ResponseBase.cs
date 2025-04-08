using System;
using System.Linq;
using System.Reflection;

namespace MelissaData.CloudAPI
{
  public abstract class ResponseBase
  {
    /// <summary>
    /// All response structures will inherit the Response Base and be able to access this function.
    /// This is a getter function that allows you to get response structure variable values by their name
    /// </summary>
    /// <param name="value"></param>
    /// <returns>the value of the response structure variable</returns>
    /// <exception cref="ArgumentException"></exception>
    public string GetValue(string value)
    {
      // Get all fields of the current type
      var fields = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

      // Find the fields with a case-insensitive match
      var propInfo = fields.FirstOrDefault(p => string.Equals(p.Name, value, StringComparison.OrdinalIgnoreCase));

      if (propInfo != null)
      {
        return propInfo.GetValue(this, null)?.ToString();
      }

      throw new ArgumentException("Property not found", nameof(value));
    }
  }
}
